using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wmi.Models
{
    public class DiskInfo
    {
        public string DiskId { get; set; }
        public string DiskName { get; set; }
        public string Volume { get; set; }
        public string SizeInBytes { get; set; }
        public string SizeInGB
        {
            get
            {
                return Math.Round((((double)Convert.ToDouble(SizeInBytes) / 1024) / 1024 / 1024), 2).ToString("N");
            }
        }
        public string FreeSpaceInBytes { get; set; }
        public string FreeSpaceInGB
        {
            get
            {
                return Math.Round((((double)Convert.ToDouble(FreeSpaceInBytes) / 1024) / 1024 / 1024), 2).ToString("N");
            }
        }
    }
}
