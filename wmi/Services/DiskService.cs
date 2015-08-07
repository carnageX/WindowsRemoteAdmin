using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wmi.Services.Interfaces;
using System.Management;
using System.Management.Instrumentation;

namespace wmi.Services
{
    public class DiskService : IDiskService
    {
        private ManagementScope _scope { get; set; }
        private ConnectionOptions _options { get; set; }

        public DiskService(ManagementScope scope, ConnectionOptions options)
        {
            _scope = scope;
            _options = options;

            _scope.Connect();
        }

        public List<string> GetDiskModel()
        {
            var diskModel = new List<string>();
            var disks = GetAllDisks();
            foreach (var disk in disks)
            {
                diskModel.Add(disk["Model"].ToString());
            }
            return diskModel;
        }

        public ManagementObjectCollection GetAllDisks()
        {
            var query = new ObjectQuery("SELECT Model FROM Win32_DiskDrive");
            var searcher = new ManagementObjectSearcher(_scope, query);
            return searcher.Get();
        }

        public ManagementObject GetDiskObject(string diskModel)
        {
            var query = new ObjectQuery(String.Format("SELECT Model FROM Win32_DiskDrive where Model='{0}'", diskModel));
            var searcher = new ManagementObjectSearcher(_scope, query);
            var disk = searcher.Get().Cast<ManagementObject>().FirstOrDefault();
            return disk;
        }

//        public bool UninstallPrinter(string printerName)
//        {
//            var printer = GetDiskObject(printerName);
//            printer.Delete();
//            return true;
//        }
    }
}
