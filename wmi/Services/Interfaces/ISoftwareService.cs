using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Management.Instrumentation;

namespace wmi.Services.Interfaces
{
    public interface ISoftwareService
    {
        List<string> GetAllSoftwareNames();
        ManagementObject GetSoftwareObject(string softwareName);
        bool UninstallSoftware(string softwareName);
    }
}
