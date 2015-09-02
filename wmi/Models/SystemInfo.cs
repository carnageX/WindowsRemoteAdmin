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
        public string OSManufacturer { get; set; }
        public string Version { get; set; }
        public string ProcessCount { get; set; }
        public string OSType { get; set; }
        public string OSArchitecture { get; set; }
        public string MemoryInBytes { get; set; }
        public string MemoryInGB
        {
            get
            {
                return Math.Round((((double)Convert.ToDouble(MemoryInBytes) / 1024) / 1024), 2).ToString("N");
            }
        }
        public string ServicePack { get; set; }
        public List<DiskInfo> Disks { get; set; }
        public List<DriveInfo> Drives { get; set; }
        public List<ComputerSystem> CompSystem { get; set; }
    }
}
