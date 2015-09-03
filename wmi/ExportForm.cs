using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wmi.Models;
using wmi.Services;
using wmi.Services.Interfaces;
using ExportToExcel;
using System.Reflection;

namespace wmi
{
    public partial class ExportForm : Form
    {
        private enum ExportOptions
        {
            SystemInfo,
            Services,
            Software,
            Printers,
            Drives,
            LocalAccounts
        }
        #region Properties
        public string SingleHostname;
        public string SingleUsername;
        public string SinglePassword;
        #endregion 

        #region Fields
        private BackgroundWorker exportWorker;
        private StreamWriter _writer;
        private SystemConnector _sysConnector;
        private IExportService _export;
        //private IServicesService _services;
        //private ISoftwareService _applications;
        //private IPrintersService _printers;
        //private ISystemInfoService _sysInfo;
        //private IDiskService _disk;
        //private ILocalAccountService _localAccounts;
        private string _watermark = @"domain OR pcname\username";
        private List<MultiSystemInput> systemsList;
        private string openFilename;
        #endregion

        #region Form Events
        public ExportForm()
        {
            InitializeComponent();
        }

        private void ExportForm_Load(object sender, EventArgs e)
        {
            ((ListBox)this.checkedListBoxExport).DataSource = new List<string>()
            {
                ExportOptions.SystemInfo.ToString(), ExportOptions.Services.ToString(),
                ExportOptions.Software.ToString(), ExportOptions.Printers.ToString(),
                ExportOptions.Drives.ToString(), ExportOptions.LocalAccounts.ToString()
            };

            SetMultiFileControlState(false);

            //TODO: Temporary - remove once implemented
            //rbMultiMode.Enabled = false;
            rbSingleMode.Checked = true;
        }
        #endregion

        #region Button Clicks
        private void btnExportBrowse_Click(object sender, EventArgs e)
        {
            if (this.openFileExport.ShowDialog() == DialogResult.OK)
            {
                openFilename = this.openFileExport.FileName;
                txtInputList.Text = openFilename;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                this.saveFileExport.Filter = "Excel files (*.xlsx) | *.xlsx";
                if(this.saveFileExport.ShowDialog() == DialogResult.OK)
                {
                    if(exportWorker == null || !exportWorker.IsBusy)
                    {
                        this.Cursor = Cursors.WaitCursor;
                        btnExport.Enabled = false;
                        using (exportWorker = new BackgroundWorker())
                        {
                            if (rbSingleMode.Checked) { ExportSingleCurrent(); }
                            else if (rbMultiMode.Checked) { ExportMultipleFromFile(); }
                            else { MessageBox.Show("You must select an export mode first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                        }
                    }              
                }
            }
            catch(Exception ex)
            {
                this.Cursor = Cursors.Default;
                btnExport.Enabled = true;
                var message = new MessageWindow("Error", ex);
                message.ShowDialog();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (exportWorker != null) { exportWorker.CancelAsync(); }
            this.Close();
        }
        #endregion

        #region Control Events
        private void rbMultiMode_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rbMultiMode.Checked)
            {
                SetMultiFileControlState(true);
            }
            else
            {
                SetMultiFileControlState(false);
            }
        }

        #endregion

        #region Export Single Mode Worker Methods
        private void ExportSingleCurrent()
        {
            InitializeConnection(SingleUsername, SinglePassword, SingleHostname);
            _export = new ExportService(_sysConnector.Scope, _sysConnector.Options);

            exportWorker.DoWork += new DoWorkEventHandler(ExportSingleWorker_DoWork);
            exportWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(ExportSingleWorker_RunWorkerCompleted);
            //exportWorker.ProgressChanged += new ProgressChangedEventHandler(ExportSingleWorker_ProgressChanged);
            //exportWorker.WorkerReportsProgress = true;
            exportWorker.WorkerSupportsCancellation = true;

            exportWorker.RunWorkerAsync();
        }

        private void ExportSingleWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //TODO: add in progress bar in UI to report progress per checkbox
        }

        private void ExportSingleWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                DataSet resultSet = e.Result as DataSet;
                CreateExcelFile.CreateExcelDocument(resultSet, saveFileExport.FileName);
                this.Cursor = Cursors.Default;
                MessageBox.Show(String.Format("System info exported to: {0}", saveFileExport.FileName), "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information); //TODO: Change message
                this.Close();
            }
            catch(Exception ex)
            {
                this.Cursor = Cursors.Default;
                btnExport.Enabled = true;
                var message = new MessageWindow("Error", ex);
                message.ShowDialog();
            }
        }

        private void ExportSingleWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                DataSet dsSingle = new DataSet();
                foreach(var item in checkedListBoxExport.CheckedItems)
                {
                    var exportItem = item.ToString().ToEnum<ExportOptions>();
                    AddInfoToDataSet(dsSingle, exportItem);
                }
                e.Result = dsSingle;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Export Multiple Mode Worker Methods
        private void ExportMultipleFromFile()
        {
            exportWorker.DoWork += new DoWorkEventHandler(ExportMultpleWorker_DoWork);
            exportWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(ExportMultipleWorker_RunWorkerCompleted);
            //exportWorker.ProgressChanged += new ProgressChangedEventHandler(ExportMultipleWorker_ProgressChanged);
            //exportWorker.WorkerReportsProgress = true;
            exportWorker.WorkerSupportsCancellation = true;

            exportWorker.RunWorkerAsync();
        }

        private void ExportMultipleWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }

        private void ExportMultipleWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                DataSet resultSet = e.Result as DataSet;
                CreateExcelFile.CreateExcelDocument(resultSet, saveFileExport.FileName);
                this.Cursor = Cursors.Default;
                MessageBox.Show(String.Format("System info exported to: {0}", saveFileExport.FileName), "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information); //TODO: Change message
                this.Close();
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                btnExport.Enabled = true;
                var message = new MessageWindow("Error", ex);
                message.ShowDialog();
            }
        }

        private void ExportMultpleWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var inputSystemsRaw = File.ReadAllLines(openFilename).ToList();
                ProcessInputFile(inputSystemsRaw);
                //TODO: need to re-think how to do this...
                //Worksheets will be unorganized with many systems (e.g. Disks / Services)
                //Can't make worksheets by system b/c dataset is excel sheet creates worksheets based on tables in DataSet
                //Maybe need to create new excel file for each system????
                DataSet dsMultiple = new DataSet();
                foreach(var item in checkedListBoxExport.CheckedItems)
                {
                    var exportItem = item.ToString().ToEnum<ExportOptions>();
                    foreach(var system in systemsList)
                    {
                        InitializeConnection(system.Username, system.Password, system.Hostname);
                        _export = new ExportService(_sysConnector.Scope, _sysConnector.Options);
                        AddInfoToDataSet(dsMultiple, exportItem);
                    }
                }
                e.Result = dsMultiple;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Helper Methods
        private void SetMultiFileControlState(bool enabledState)
        {
            this.txtInputList.Enabled = enabledState;
            this.btnExportBrowse.Enabled = enabledState;
            this.groupFileCredentials.Enabled = enabledState;
        }

        private void SetupConnection(string parHostname, string parUsername, string parPassword)
        {
            if ((!String.IsNullOrWhiteSpace(parUsername) && !parUsername.Equals(_watermark))
                    && !String.IsNullOrWhiteSpace(parPassword))
            {
                var options = new ConnectionOptions();
                options.Username = parUsername;
                options.Password = parPassword;
                _sysConnector = new SystemConnector(parHostname, options);
            }
            else
            {
                _sysConnector = new SystemConnector(parHostname);
            }
        }

        private void AddInfoToDataSet(DataSet ds, ExportOptions exportType)
        {
            //TODO: need to fix items that have lists as properties... how to make those into datatable with parent? 
            if (exportType == ExportOptions.Drives) { ds.Tables.Add(_export.GetDrivesInfo()); }
            else if (exportType == ExportOptions.LocalAccounts) { ds.Tables.Add(_export.GetLocalAccountsInfo()); }
            else if (exportType == ExportOptions.Printers) { ds.Tables.Add(_export.GetPrintersInfo()); }
            else if (exportType == ExportOptions.Services) { ds.Tables.Add(_export.GetServicesInfo()); }
            else if (exportType == ExportOptions.Software) { ds.Tables.Add(_export.GetSoftwareInfo()); }
            else if (exportType == ExportOptions.SystemInfo)
            {
                var dtSysInfos = _export.GetSystemInfo();
                foreach(var t in dtSysInfos)
                {
                    ds.Tables.Add(t);
                }
            }
        }

        private void InitializeConnection(string username, string password, string hostname)
        {
            if (!username.Equals(String.Empty) && !username.Equals(String.Empty))
            {
                //TODO: can password be blank???
                if ((!String.IsNullOrWhiteSpace(username) && !username.Equals(_watermark))
                    && !String.IsNullOrWhiteSpace(password))
                {
                    var options = new ConnectionOptions();
                    options.Username = username;
                    options.Password = password;
                    _sysConnector = new SystemConnector(hostname, options);
                }
                else
                {
                    _sysConnector = new SystemConnector(hostname);
                }
            }
            else
            {
                _sysConnector = new SystemConnector(hostname);
            }
        }

        private void ProcessInputFile(List<string> rawInput)
        {
            systemsList = new List<MultiSystemInput>();
            if(rbFileCredsSingle.Checked)
            {
                GenerateMultiSystemSingleCredList(rawInput, systemsList);
            }
            else if(rbFileCredsMulti.Checked)
            {
                GenerateMultiSystemMultiCredList(rawInput, systemsList);
            }
        }

        private void GenerateMultiSystemSingleCredList(List<string> rawInput, List<MultiSystemInput> sysList)
        {
            var credsLine = rawInput[0].Split(',');
            if (credsLine.Length < 1)
            {
                throw new Exception("First line of input file must contain comma separated credentials in format: username,password");
            }
            var username = credsLine[0];
            var password = credsLine[1];

            rawInput.RemoveAt(0);

            foreach(var line in rawInput)
            {
                if (line[0] == '#') { continue; }
                sysList.Add(new MultiSystemInput
                {
                    Username = username,
                    Password = password,
                    Hostname = line
                });
            }
        }

        private void GenerateMultiSystemMultiCredList(List<string> rawInput, List<MultiSystemInput> sysList)
        {
            foreach(var line in rawInput)
            {
                if (line[0] == '#') { continue; }
                var splitLine = line.Split(',');
                if(splitLine.Length < 3)
                {
                    var lineIndex = rawInput.IndexOf(line);
                    throw new Exception(String.Format("Line {0} is invalid.  Must be comma separated format: hostname,username,password", lineIndex + 1));
                }
                sysList.Add(new MultiSystemInput
                {
                    Hostname = splitLine[0],
                    Username = splitLine[1],
                    Password = splitLine[2]
                });
            }
        }
        #endregion

        #region Converting ObjectArray to DataTable


        #endregion
    }
}
