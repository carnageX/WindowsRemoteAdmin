using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Management.Instrumentation;
using wmi.Models;

namespace wmi
{
    public class SystemConnector
    {
        public ManagementScope Scope { get; set; }
        public ConnectionOptions Options { get; set; }

        public SystemConnector(string computerName, ConnectionOptions options = null)
        {
                if (options == null) { Options = new ConnectionOptions(); }
                else { Options = options; }
                Scope = new ManagementScope(String.Format(@"\\{0}\root\cimv2", computerName), options);
            
        }
    }
}
