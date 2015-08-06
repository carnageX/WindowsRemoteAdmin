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
    public class SoftwareService : ISoftwareService
    {
        private ManagementScope _scope { get; set; }
        private ConnectionOptions _options { get; set; }

        public SoftwareService(ManagementScope scope, ConnectionOptions options)
        {
            _scope = scope;
            _options = options;

            _scope.Connect();
        }

        public List<string> GetAllSoftwareNames()
        {
            var softwareList = new List<string>();
            var query = new ObjectQuery("SELECT Name FROM Win32_Product");
            var searcher = new ManagementObjectSearcher(_scope, query);
            var softwares = searcher.Get();
            foreach(var s in softwares)
            {
                softwareList.Add(s["Name"].ToString());
            }
            return softwareList;
        }

        public ManagementObject GetSoftwareObject(string softwareName)
        {
            var query = new ObjectQuery(String.Format("SELECT * FROM Win32_Product where Caption='{0}'", softwareName));
            var searcher = new ManagementObjectSearcher(_scope, query);
            var software = searcher.Get().Cast<ManagementObject>().FirstOrDefault();
            return software;
        }

        public bool UninstallSoftware(string softwareName)
        {
            var softwareObject = GetSoftwareObject(softwareName);
            softwareObject.InvokeMethod("Uninstall", null);
            return true;
        }
    }
}
