using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        #region Fields
        private BackgroundWorker exportMultipleWorker;
        StreamWriter _writer;
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
        }
        #endregion

        #region Button Clicks
        private void btnExportBrowse_Click(object sender, EventArgs e)
        {
            if (this.openFileExport.ShowDialog() == DialogResult.OK)
            {
                var openFilename = this.openFileExport.FileName;
                var inputSystemsRaw = File.ReadAllLines(openFilename).ToList();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            this.saveFileExport.CheckFileExists = true;
            if(this.saveFileExport.ShowDialog() == DialogResult.OK)
            {
                using (_writer = new StreamWriter(this.saveFileExport.FileName))
                {
                    if(exportMultipleWorker == null || !exportMultipleWorker.IsBusy)
                    {
                        using (exportMultipleWorker = new BackgroundWorker())
                        {
                            this.exportMultipleWorker.DoWork += new DoWorkEventHandler(ExportMultpleWorker_DoWork);
                            this.exportMultipleWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(ExportMultipleWorker_RunWorkerCompleted);
                            this.exportMultipleWorker.ProgressChanged += new ProgressChangedEventHandler(ExportMultipleWorker_ProgressChanged);
                            exportMultipleWorker.WorkerReportsProgress = true;
                            exportMultipleWorker.WorkerSupportsCancellation = true;

                            exportMultipleWorker.RunWorkerAsync(); //TODO: send in parameter for processing?
                        }
                    }

                    //writer.WriteLine();
                }                
            }

        }

        private void ExportMultipleWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ExportMultipleWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Error != null)
            {
                //TODO: handle error
            }
            else if(e.Cancelled)
            {
                //TODO: handle cancel
            }
            else
            {
                _writer = (StreamWriter)e.Result;
            }
            throw new NotImplementedException();
        }

        private void ExportMultpleWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //TODO: do processing.... 
            //e.Result = "method that returns streamwriter or list?"
            throw new NotImplementedException();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
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

        #region Helper Methods
        private void SetMultiFileControlState(bool isEnabled)
        {
            this.txtInputList.Enabled = isEnabled;
            this.btnExportBrowse.Enabled = isEnabled;
        }
        #endregion
    }
}
