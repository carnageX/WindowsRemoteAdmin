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
        private SystemConnector _sysConnector;
        private IServicesService _services;
        private ISoftwareService _applications;
        private IPrintersService _printers;

        public Main()
        {
            InitializeComponent();
        }

        #region System Info
        private void btnConnect_Click(object sender, EventArgs e)
        {
            _sysConnector = new SystemConnector(this.txtCompName.Text);
            var sysInfoService = new SystemInfoService(_sysConnector.Scope, _sysConnector.Options);
            var sysInfo = sysInfoService.GetSystemInfo().FirstOrDefault();

            lblComputerName.Text = sysInfo.HostName;
            lblWinDir.Text = sysInfo.WinDir;
            lblCaption.Text = sysInfo.Caption;
            lblManufacturer.Text = sysInfo.Manufacturer;
            lblVer.Text = sysInfo.Version;
            lblProcCount.Text = sysInfo.ProcessCount;
            lblArch.Text = sysInfo.OSArchitecture;
            lblRam.Text = String.Format("{0} bytes", sysInfo.MemoryInBytes);

            var disk = sysInfo.Disks.First();
            lblDiskName.Text = disk.DiskName;
            lblDiskSize.Text = String.Format("{0} bytes", disk.SizeInBytes);
            lblDiskFree.Text = String.Format("{0} bytes", disk.FreeSpaceInBytes);

            var adminStatus = sysInfo.AdminPasswordStatuses.First();
            lblCurrentUser.Text = adminStatus.Username;
            lblAdminStatus.Text = adminStatus.Status;
        }
        #endregion

        #region Services
        private void btnGetServices_Click(object sender, EventArgs e)
        {
            if (_sysConnector == null) { MessageBox.Show("Please connect to a system first.", "No Connection!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            _services = new ServicesService(_sysConnector.Scope, _sysConnector.Options);
            listServices.DataSource = new BindingList<string>(_services.GetServicesNameList());
        }

        private void btnServiceStart_Click(object sender, EventArgs e)
        {
            var serviceName = listServices.SelectedItem.ToString();
            var isStarted = _services.StartService(serviceName);
            if (isStarted) { lblServiceStatus.Text = _services.GetServiceStatus(serviceName); }
        }

        private void btnServiceStop_Click(object sender, EventArgs e)
        {
            var serviceName = listServices.SelectedItem.ToString();
            var isStopped = _services.StopService(serviceName);
            if (isStopped) { lblServiceStatus.Text = _services.GetServiceStatus(serviceName); }
        }

        private void listServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            var serviceName = listServices.SelectedItem.ToString();
            lblServiceStatus.Text = _services.GetServiceStatus(serviceName);
        }
        #endregion

        #region Software
        private void btnGetSoftware_Click(object sender, EventArgs e)
        {
            if (_sysConnector == null) { MessageBox.Show("Please connect to a system first.", "No Connection!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            _applications = new SoftwareService(_sysConnector.Scope, _sysConnector.Options);
            listSoftware.DataSource = new BindingList<string>(_applications.GetAllSoftwareNames());
        }

        private void btnSoftwareUninstall_Click(object sender, EventArgs e)
        {
            var applicationName = listSoftware.SelectedItem.ToString();
            var isRemoved = _applications.UninstallSoftware(applicationName);
        }
        #endregion

        #region Printers
        private void btnGetPrinters_Click(object sender, EventArgs e)
        {
            if (_sysConnector == null) { MessageBox.Show("Please connect to a system first.", "No Connection!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            _printers = new PrintersService(_sysConnector.Scope, _sysConnector.Options);
            listPrinters.DataSource = new BindingList<string>(_printers.GetPrinterNames());
        }

        private void btnUninstallPrinter_Click(object sender, EventArgs e)
        {
            var printerName = listPrinters.SelectedItem.ToString();
            var isRemoved = _printers.UninstallPrinter(printerName);
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
