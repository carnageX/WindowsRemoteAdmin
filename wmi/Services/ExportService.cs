using ExportToExcel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using wmi.Services.Interfaces;

namespace wmi.Services
{
    public class ExportService : IExportService
    {
        private ManagementScope _scope { get; set; }
        private ConnectionOptions _options { get; set; }

        private IServicesService _services;
        private ISoftwareService _applications;
        private IPrintersService _printers;
        private ISystemInfoService _sysInfo;
        private IDiskService _disk;
        private ILocalAccountService _localAccounts;

        public ExportService(ManagementScope scope, ConnectionOptions options)
        {
            _scope = scope;
            _options = options;

            _scope.Connect();
        }

        public List<DataTable> GetSystemInfo()
        {
            List<DataTable> dtList = new List<DataTable>();
            DataTable dtTemp = new DataTable();
            _sysInfo = new SystemInfoService(_scope, _options);
            var sysInfo = _sysInfo.GetSystemInfo().FirstOrDefault();

            dtList.Add(ExtensionMethods.ConvertToDataTable(sysInfo, "System Info"));
            dtList[0].Columns.Remove("Disks");
            dtList[0].Columns.Remove("Drives");
            dtList[0].Columns.Remove("CompSystem");
            dtList.Add(CreateExcelFile.ListToDataTable(sysInfo.Disks, "Disks"));
            dtList.Add(CreateExcelFile.ListToDataTable(sysInfo.CompSystem, "Computer System"));

            return dtList;
        }

        public DataTable GetServicesInfo()
        {
            _services = new ServicesService(_scope, _options);
            var serviceNamesList = _services.GetAllServices();
            return CreateExcelFile.ListToDataTable(serviceNamesList, "Services");
        }

        public DataTable GetSoftwareInfo()
        {
            _applications = new SoftwareService(_scope, _options);
            var softwareNamesList = _applications.GetAllSoftware();
            var dt = CreateExcelFile.ListToDataTable(softwareNamesList, "Software");
            DataView dv = dt.DefaultView;
            dv.Sort = "Name asc";
            return dv.ToTable();
        }

        public DataTable GetPrintersInfo()
        {
            _printers = new PrintersService(_scope, _options);
            var printerNamesList = _printers.GetPrinters();
            return CreateExcelFile.ListToDataTable(printerNamesList, "Printers");
        }

        public DataTable GetDrivesInfo()
        {
            var sysInfo = _sysInfo.GetSystemInfo().FirstOrDefault();
            return CreateExcelFile.ListToDataTable(sysInfo.Drives, "Drives");
        }

        public DataTable GetLocalAccountsInfo()
        {
            _localAccounts = new LocalAccountService(_scope, _options);
            var localAccountsList = _localAccounts.GetAllLocalAccounts();
            return CreateExcelFile.ListToDataTable(localAccountsList, "Local Accounts");
        }
    }
}
