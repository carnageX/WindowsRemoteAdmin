using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        #endregion

        public Main()
        {
            InitializeComponent();
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
                    _sysConnector = new SystemConnector(this.txtCompName.Text);
                    _sysInfo = new SystemInfoService(_sysConnector.Scope, _sysConnector.Options);
                    var sysInfo = _sysInfo.GetSystemInfo().FirstOrDefault();

                    lblComputerName.Text = sysInfo.HostName;
                    lblWinDir.Text = sysInfo.WinDir;
                    lblCaption.Text = sysInfo.Caption;
                    lblManufacturer.Text = sysInfo.Manufacturer;
                    lblVer.Text = sysInfo.Version;
                    lblProcCount.Text = sysInfo.ProcessCount;
                    lblArch.Text = sysInfo.OSArchitecture;
                    var memoryGB = Math.Round((((double)Convert.ToDouble(sysInfo.MemoryInBytes) / 1024) / 1024), 2).ToString("N");
                    lblRam.Text = String.Format("{0} bytes ({1} GB)", sysInfo.MemoryInBytes, memoryGB);

                    var disk = sysInfo.Disks.First();
                    lblDiskName.Text = disk.DiskName;
                    var diskSizeGB = Math.Round((((double)Convert.ToDouble(disk.SizeInBytes) / 1024) / 1024 / 1024), 2).ToString("N");
                    var diskFreeGB = Math.Round((((double)Convert.ToDouble(disk.FreeSpaceInBytes) / 1024) / 1024 / 1024), 2).ToString("N");
                    lblDiskSize.Text = String.Format("{0} bytes ({1} GB)", disk.SizeInBytes, diskSizeGB );
                    lblDiskFree.Text = String.Format("{0} bytes ({1} GB)", disk.FreeSpaceInBytes, diskFreeGB);

                    var adminStatus = sysInfo.AdminPasswordStatuses.First();
                    lblCurrentUser.Text = adminStatus.Username;
                    lblAdminStatus.Text = adminStatus.Status;
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
                if (_sysConnector == null) { MessageBox.Show("Please connect to a system first.", "No Connection!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
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
                if (_sysConnector == null) { MessageBox.Show("Please connect to a system first.", "No Connection!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else
                {
                    this.Cursor = Cursors.WaitCursor;
                    _applications = new SoftwareService(_sysConnector.Scope, _sysConnector.Options);
                    listSoftware.DataSource = new BindingList<string>(_applications.GetAllSoftwareNames());
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
                if (_sysConnector == null) { MessageBox.Show("Please connect to a system first.", "No Connection!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else
                {
                    _printers = new PrintersService(_sysConnector.Scope, _sysConnector.Options);
                    listPrinters.DataSource = new BindingList<string>(_printers.GetPrinterNames());
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
                if (_sysConnector == null) { MessageBox.Show("Please connect to a system first.", "No Connection!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
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
        #endregion
    }
}
