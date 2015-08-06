using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Management.Instrumentation;

namespace wmi.Services.Interfaces
{
    public interface IServicesService
    {
        List<string> GetServicesNameList();
        ManagementObjectCollection GetAllServices();
        ManagementObject GetServiceObject(string serviceName);
        List<ManagementObject> GetServiceObjects(params string[] serviceNames);
        bool StartService(string serviceName);
        Dictionary<string, bool> StartServices(params string[] serviceNames);
        bool StopService(string serviceName);
        Dictionary<string, bool> StopServices(params string[] serviceNames);
        string GetServiceStatus(string serviceName);
    }
}
