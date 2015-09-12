using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wmi.Models;
using wmi.Services;
using wmi.Services.Interfaces;

namespace wmi
{
    public partial class Main : Form
    {
        #region Private Fields
        private SystemConnector _sysConnector;
        private IServicesService _services;
        private ISoftwareService _applications;
        private IPrintersService _printers;
        private ISystemInfoService _sysInfo;
        private IDiskService _disk;
        private ILocalAccountService _localAccounts;
        private string _watermark = @"domain OR pcname\username";
        #endregion

        public Main()
        {
            InitializeComponent();

            //TODO: remove once complete to enable the Export menu
            //this.exportToolStripMenuItem.Enabled = false;
            this.toolsToolStripMenuItem.ToolTipText = "Feature in development.";

            txtUserName.SetWatermark(_watermark);

            txtUserName.Enabled = false;
            txtPassword.Enabled = false;
        }

        #region System Info
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrWhiteSpace(this.txtCompName.Text))
                {
                    MessageBox.Show("Please enter a computer name or IP.", "No system!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.Cursor = Cursors.WaitCursor;

                    ClearAllTabControls();
                    InitializeConnection();

                    _sysInfo = new SystemInfoService(_sysConnector.Scope, _sysConnector.Options);
                    var sysInfo = _sysInfo.GetSystemInfo().FirstOrDefault();

                    SetGenericSystemInfo(sysInfo);
                    SetMemoryInfo(sysInfo);
                    SetDiskInfo(sysInfo);
                    SetComputerSystemInfo(sysInfo);

                    this.Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                var message = new MessageWindow("Error", ex);
                message.ShowDialog();
                this.Cursor = Cursors.Default;
            }

        }
        #endregion

        #region Services
        private void btnGetServices_Click(object sender, EventArgs e)
        {
            try
            {
                if (_sysConnector == null) { ShowConnectionErrorMessage(); }
                else
                {
                    _services = new ServicesService(_sysConnector.Scope, _sysConnector.Options);
                    listServices.DataSource = new BindingList<string>(_services.GetServicesNameList());
                }
            }
            catch (Exception ex)
            {
                var message = new MessageWindow("Error", ex);
                message.ShowDialog();
            }
        }

        private void btnServiceStart_Click(object sender, EventArgs e)
        {
            try
            {
                var serviceName = listServices.SelectedItem.ToString();
                var isStarted = _services.StartService(serviceName);
                if (isStarted) { lblServiceStatus.Text = _services.GetServiceStatus(serviceName); }
            }
            catch(Exception ex)
            {
                var message = new MessageWindow("Error", ex);
                message.ShowDialog();
            }
        }

        private void btnServiceStop_Click(object sender, EventArgs e)
        {
            try
            {
                var serviceName = listServices.SelectedItem.ToString();
                var isStopped = _services.StopService(serviceName);
                if (isStopped) { lblServiceStatus.Text = _services.GetServiceStatus(serviceName); }
            }
            catch (Exception ex)
            {
                var message = new MessageWindow("Error", ex);
                message.ShowDialog();
            }
        }

        private void listServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var serviceName = listServices.SelectedItem.ToString();
                lblServiceStatus.Text = _services.GetServiceStatus(serviceName);
            }
            catch (Exception ex)
            {
                var message = new MessageWindow("Error", ex);
                message.ShowDialog();
            }

        }
        #endregion

        #region Software
        private void btnGetSoftware_Click(object sender, EventArgs e)
        {
            try
            {
                if (_sysConnector == null) { ShowConnectionErrorMessage(); }
                else
                {
                    this.Cursor = Cursors.WaitCursor;
                    _applications = new SoftwareService(_sysConnector.Scope, _sysConnector.Options);
                    listSoftware.DataSource = new BindingList<SoftwareInfo>(_applications.GetAllSoftware());
                    listSoftware.DisplayMember = "Name";
                    this.Cursor = Cursors.Default;
                }
            }
            catch(Exception ex)
            {
                var message = new MessageWindow("Error", ex);
                message.ShowDialog();
            }
        }

        private void btnSoftwareUninstall_Click(object sender, EventArgs e)
        {
            try
            {
                var applicationName = listSoftware.SelectedItem.ToString();
                var isRemoved = _applications.UninstallSoftware(applicationName);
            }
            catch (Exception ex) 
            {
                var message = new MessageWindow("Error", ex);
                message.ShowDialog();
            }
        } 
        #endregion

        #region Printers
        private void btnGetPrinters_Click(object sender, EventArgs e)
        {
            try
            {
                if (_sysConnector == null) { ShowConnectionErrorMessage(); }
                else
                {
                    _printers = new PrintersService(_sysConnector.Scope, _sysConnector.Options);
                    listPrinters.DataSource = new BindingList<PrinterInfo>(_printers.GetPrinters());
                    listPrinters.DisplayMember = "Name";
                }
            }
            catch (Exception ex)
            {
                var message = new MessageWindow("Error", ex);
                message.ShowDialog();
            }
        }

        private void btnUninstallPrinter_Click(object sender, EventArgs e)
        {
            try
            {
                var printerName = listPrinters.SelectedItem.ToString();
                var isRemoved = _printers.UninstallPrinter(printerName);
            }
            catch (Exception ex) 
            {
                var message = new MessageWindow("Error", ex);
                message.ShowDialog();
            }
        }
        #endregion

        #region Drives
        private void btnGetDisks_Click(object sender, EventArgs e)
        {
            try
            {
                if (_sysConnector == null) { ShowConnectionErrorMessage(); }
                else
                {
                    var sysInfo = _sysInfo.GetSystemInfo().FirstOrDefault();
                    listDrives.DataSource = new BindingList<DriveInfo>(sysInfo.Drives);
                    listDrives.DisplayMember = "Model";
                    listDrives.ValueMember = "DeviceId";
                }
            }
            catch (Exception ex)
            {
                var message = new MessageWindow("Error", ex);
                message.ShowDialog();
            }

        }

        private void listDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (_sysConnector == null) { ShowConnectionErrorMessage(); }
                else
                {
                    var selectedDrive = listDrives.SelectedItem as DriveInfo;
                    //var diskSizeInGB = Math.Round((((double)Convert.ToDouble(selectedDrive.SizeInBytes) / 1024) / 1024 / 1024), 2).ToString("N");

                    lblDriveModel.Text = selectedDrive.Model;
                    lblDrivePartitionCount.Text = selectedDrive.Partitions;
                    lblDriveSize.Text = String.Format("{0} bytes ({1} GB)", selectedDrive.SizeInBytes, selectedDrive.SizeInGB);
                    lblDriveDeviceId.Text = selectedDrive.DeviceId;
                }
            }
            catch (Exception ex)
            {
                var message = new MessageWindow("Error", ex);
                message.ShowDialog();
            }
        }
        #endregion

        #region Local Accounts
        private void btnGetLocalAccounts_Click(object sender, EventArgs e)
        {
            try
            {
                if (_sysConnector == null) { ShowConnectionErrorMessage(); }
                else
                {
                    _localAccounts = new LocalAccountService(_sysConnector.Scope, _sysConnector.Options);
                    listLocalAccounts.DataSource = new BindingList<LocalAccountInfo>(_localAccounts.GetAllLocalAccounts());
                    listLocalAccounts.DisplayMember = "Name";
                    listLocalAccounts.ValueMember = "SID";
                }
            }
            catch(Exception ex)
            {
                var message = new MessageWindow("Error", ex);
                message.ShowDialog();
            }
        }

        private void listLocalAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                var localAccount = listLocalAccounts.SelectedItem as LocalAccountInfo;
                lblAccountCaption.Text = localAccount.Caption;
                lblAccountPassDisabled.Text = localAccount.Disabled;
                lblAccountPassChangeable.Text = localAccount.PasswordChangeable;
                lblAccountPassExpires.Text = localAccount.PasswordExpires;
                lblAccountPassRequired.Text = localAccount.PasswordRequired;
                lblAccountLockoutStatus.Text = localAccount.Lockout;
            }
            catch(Exception ex)
            {
                var message = new MessageWindow("Error", ex);
                message.ShowDialog();
            }
        }
        #endregion

        #region Control Events
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutScreen = new AboutBox1();
            aboutScreen.Show();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var exportWindow = new ExportForm();
            exportWindow.SingleHostname = txtCompName.Text;
            exportWindow.SingleUsername = txtUserName.Text;
            exportWindow.SinglePassword = txtPassword.Text;
            exportWindow.ShowDialog();
        }

        private void remoteAssistanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //https://technet.microsoft.com/en-us/magazine/ff356868.aspx
                var hostname = (String.IsNullOrWhiteSpace(txtCompName.Text) || txtCompName.Text.Equals("127.0.0.1")) ? String.Empty : txtCompName.Text;
                Process p = new Process();
                p.StartInfo.FileName = Environment.ExpandEnvironmentVariables(@"%windir%\system32\msra.exe");
                p.StartInfo.Arguments = String.Format("/offerra {0}", hostname);
                p.EnableRaisingEvents = true;
                p.Start();
            }
            catch (Exception ex)
            {
                var message = new MessageWindow("Error", ex);
                message.ShowDialog();
            }
        }

        private void checkRequiresCredentials_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRequiresCredentials.Checked)
            {
                txtUserName.Enabled = true;
                txtPassword.Enabled = true;
            }
            else
            {
                txtUserName.Enabled = false;
                txtPassword.Enabled = false;
            }
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if(txtUserName.Text.Equals(_watermark)) { txtUserName.SetWatermark(String.Empty); }
                        
        }
        #endregion

        #region Helper Methods
        private void ShowConnectionErrorMessage()
        {
            MessageBox.Show("Please connect to a system first.", "No Connection!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void SetComputerSystemInfo(SystemInfo sysInfo)
        {
            var compSystem = sysInfo.CompSystem.First();
            lblCurrentUser.Text = compSystem.Username;
            lblAdminStatus.Text = compSystem.PasswordStatus;
            lblHWManufacturer.Text = compSystem.Manufacturer;
            lblHWModel.Text = compSystem.Model;
        }

        private void SetDiskInfo(SystemInfo sysInfo)
        {
            var disk = sysInfo.Disks.First();
            lblDiskName.Text = disk.DiskName;
            //var diskSizeGB = Math.Round((((double)Convert.ToDouble(disk.SizeInBytes) / 1024) / 1024 / 1024), 2).ToString("N");
            //var diskFreeGB = Math.Round((((double)Convert.ToDouble(disk.FreeSpaceInBytes) / 1024) / 1024 / 1024), 2).ToString("N");
            lblDiskSize.Text = String.Format("{0} bytes ({1} GB)", disk.SizeInBytes, disk.SizeInGB);
            lblDiskFree.Text = String.Format("{0} bytes ({1} GB)", disk.FreeSpaceInBytes, disk.FreeSpaceInGB);
        }

        private void SetMemoryInfo(SystemInfo sysInfo)
        {
            //var memoryGB = Math.Round((((double)Convert.ToDouble(sysInfo.MemoryInBytes) / 1024) / 1024), 2).ToString("N");
            lblRam.Text = String.Format("{0} bytes ({1} GB)", sysInfo.MemoryInBytes, sysInfo.MemoryInGB);
        }

        private void SetGenericSystemInfo(SystemInfo sysInfo)
        {
            lblComputerName.Text = sysInfo.HostName;
            lblWinDir.Text = sysInfo.WinDir;
            lblCaption.Text = sysInfo.Caption;
            lblOSManufacturer.Text = sysInfo.OSManufacturer;
            lblVer.Text = sysInfo.Version;
            lblProcCount.Text = sysInfo.ProcessCount;
            lblArch.Text = sysInfo.OSArchitecture;
            lblServp.Text = sysInfo.ServicePack;
        }

        private void InitializeConnection()
        {
            if(checkRequiresCredentials.Checked)
            {
                //TODO: can password be blank???
                if ((!String.IsNullOrWhiteSpace(txtUserName.Text) && !txtUserName.Text.Equals(_watermark)) 
                    && !String.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    var options = new ConnectionOptions();
                    options.Username = txtUserName.Text;
                    options.Password = txtPassword.Text;
                    _sysConnector = new SystemConnector(this.txtCompName.Text, options);
                }
                else
                {
                    _sysConnector = new SystemConnector(this.txtCompName.Text);
                }
            }
            else
            {
                _sysConnector = new SystemConnector(this.txtCompName.Text);
            }
        }
        #endregion

        #region Clear Methods
        private void ClearSystemInfoControls()
        {
            lblComputerName.Text = String.Empty;
            lblAdminStatus.Text = String.Empty;
            lblDiskName.Text = String.Empty;
            lblDiskSize.Text = String.Empty;
            lblDiskFree.Text = String.Empty;
            lblArch.Text = String.Empty;
            lblProcCount.Text = String.Empty;
            lblCurrentUser.Text = String.Empty;
            lblRam.Text = String.Empty;
            lblWinDir.Text = String.Empty;
            lblCaption.Text = String.Empty;
            lblServp.Text = String.Empty;
            lblVer.Text = String.Empty;
            lblOSManufacturer.Text = String.Empty;
            lblHWModel.Text = String.Empty;
            lblHWManufacturer.Text = String.Empty;
        }

        private void ClearServicesControls()
        {
            listServices.DataSource = new List<string>();
            lblServiceStatus.Text = String.Empty;
        }

        private void ClearSoftwareControls()
        {
            listSoftware.DataSource = new List<string>();
        }

        private void ClearPrintersControls()
        {
            listPrinters.DataSource = new List<string>();
        }

        private void ClearDrivesControls()
        {
            listDrives.DataSource = new List<string>();
            lblDriveModel.Text = String.Empty;
            lblDrivePartitionCount.Text = String.Empty;
            lblDriveSize.Text = String.Empty;
            lblDriveDeviceId.Text = String.Empty;
        }

        private void ClearLocalAccountsControls()
        {
            listLocalAccounts.DataSource = new List<string>();
            lblAccountCaption.Text = String.Empty;
            lblAccountPassDisabled.Text = String.Empty;
            lblAccountPassChangeable.Text = String.Empty;
            lblAccountPassExpires.Text = String.Empty;
            lblAccountPassRequired.Text = String.Empty;
            lblAccountLockoutStatus.Text = String.Empty;
        }

        private void ClearAllTabControls()
        {
            ClearSystemInfoControls();
            ClearServicesControls();
            ClearSoftwareControls();
            ClearPrintersControls();
            ClearDrivesControls();
            ClearLocalAccountsControls();
        }
        #endregion
    }
}
