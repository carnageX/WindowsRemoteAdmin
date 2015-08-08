using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wmi.Models
{
    public class DriveInfo
    {
        public string Model { get; set; }
        public string Partitions { get; set; }
        public string DeviceId { get; set; }
        public string SizeInBytes { get; set; }
        public string Caption { get; set; }
    }
}
