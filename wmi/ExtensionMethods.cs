using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wmi.Models;
using System.Management;
using System.Management.Instrumentation;

namespace wmi
{
    public static class ExtensionMethods
    {
        public static List<DiskInfo> GetDiskInfo(this SystemInfo systemInfo, ManagementScope scope)
        {
            var disks = new List<DiskInfo>();
            var query = new ObjectQuery("SELECT FreeSpace,Size,Name FROM Win32_LogicalDisk WHERE DriveType=3");
            var searcher = new ManagementObjectSearcher(scope, query);
            var diskCollection = searcher.Get();
            foreach (var disk in diskCollection)
            {
                disks.Add(
                    new DiskInfo()
                    {
                        DiskName = disk["Name"].ToString(),
                        SizeInBytes = disk["Size"].ToString(),
                        FreeSpaceInBytes = disk["FreeSpace"].ToString()
                    }
                );
            }
            return disks;
        }

        public static List<AdminPasswordStatus> GetAdminPasswordStatus(this SystemInfo systemInfo, ManagementScope scope)
        {
            var statuses = new List<AdminPasswordStatus>();
            var query = new ObjectQuery("SELECT AdminPasswordStatus,UserName FROM Win32_ComputerSystem");
            var searcher = new ManagementObjectSearcher(scope, query);
            var statusCollection = searcher.Get();
            foreach (var status in statusCollection)
            {
                var passwordStatus = String.Empty;
                if (status["AdminPasswordStatus"].ToString() == "0") { passwordStatus = "Disabled"; }
                else if (status["AdminPasswordStatus"].ToString() == "1") { passwordStatus = "Enabled"; }
                else if (status["AdminPasswordStatus"].ToString() == "2") { passwordStatus = "Not Implemented"; }
                else if (status["AdminPasswordStatus"].ToString() == "3") { passwordStatus = "Unknown"; }

                statuses.Add(
                    new AdminPasswordStatus()
                    {
                        Status = passwordStatus,
                        Username = status["UserName"].ToString()
                    }
                );
            }
            return statuses;
        }
    }
}
