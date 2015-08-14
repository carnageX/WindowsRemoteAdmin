using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wmi.Services.Interfaces;
using wmi.Models;
using System.Management;
using System.Management.Instrumentation;

namespace wmi.Services
{
    public class SystemInfoService : ISystemInfoService
    {
        private ManagementScope _scope { get; set; }
        private ConnectionOptions _options { get; set; }

        public SystemInfoService(ManagementScope scope, ConnectionOptions options)
        {
            _scope = scope;
            _options = options;

            _scope.Connect();
        }
        
        public List<SystemInfo> GetSystemInfo()
        {
            var systemInfoCollection = new List<SystemInfo>();
            GetBaseSystemInfo(systemInfoCollection);
            foreach (var item in systemInfoCollection)
            {
                item.Disks = item.GetDiskInfo(_scope);
                item.Drives = item.GetDriveInfo(_scope);
                item.AdminPasswordStatuses = item.GetAdminPasswordStatus(_scope);
            }

            return systemInfoCollection;
        }

        public void GetBaseSystemInfo(List<SystemInfo> systemInfoCollection)
        {
            var fields = "CSName, WindowsDirectory, Caption, Manufacturer, Version, NumberOfProcesses, OSType, OSArchitecture, TotalVisibleMemorySize, CSDVersion";
            var query = new ObjectQuery(String.Format("SELECT {0} FROM Win32_OperatingSystem", fields));
            var searcher = new ManagementObjectSearcher(_scope, query);
            var queryCollection = searcher.Get();
            foreach (var item in queryCollection)
            {
                systemInfoCollection.Add(
                    new SystemInfo()
                    {
                        HostName = String.Format("{0}", item["CSName"]),
                        WinDir = String.Format("{0}", item["WindowsDirectory"]),
                        Caption = String.Format("{0}", item["Caption"]),
                        Manufacturer = String.Format("{0}", item["Manufacturer"]),
                        Version = String.Format("{0}", item["Version"]),
                        ProcessCount = String.Format("{0}", item["NumberOfProcesses"]),
                        OSType = String.Format("{0}", item["OSType"]),
                        OSArchitecture = String.Format("{0}", item["OSArchitecture"]),
                        MemoryInBytes = String.Format("{0}", item["TotalVisibleMemorySize"]),
                        ServicePack = String.Format("{0}", item["CSDVersion"])
                    }
                );
            }
        }
    }
}
