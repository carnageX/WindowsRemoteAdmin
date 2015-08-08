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
        public string FreeSpaceInBytes { get; set; }
    }
}
