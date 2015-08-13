using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wmi.Models
{
    public class SystemInfo
    {
        public string HostName { get; set; }
        public string WinDir { get; set; }
        public string Caption { get; set; }
        public string Manufacturer { get; set; }
        public string Version { get; set; }
        public string ProcessCount { get; set; }
        public string OSType { get; set; }
        public string OSArchitecture { get; set; }
        public string MemoryInBytes { get; set; }
        public string ServicePack { get; set; }
        public List<DiskInfo> Disks { get; set; }
        public List<DriveInfo> Drives { get; set; }
        public List<AdminPasswordStatus> AdminPasswordStatuses { get; set; }
    }
}
