using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace wmi.Models
{
    public class LocalAccountInfo
    {
        public string AccountType { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
        public string Disabled { get; set; }
        public string Domain { get; set; }
        public string FullName { get; set; }
        public string InstallDate { get; set; }
        public string LocalAccount { get; set; }
        public string Lockout { get; set; }
        public string Name { get; set; }
        public string PasswordChangeable { get; set; }
        public string PasswordExpires { get; set; }
        public string PasswordRequired { get; set; }
        public string SID { get; set; }
        public string SIDType { get; set; }
        public string Status { get; set; }
    }
}
