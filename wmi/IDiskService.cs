
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Management.Instrumentation;

namespace wmi.Disk.Interfaces
{
    public interface IDiskService
    {
        List<string> GetDiskModel();
        ManagementObjectCollection GetAllDisks();
        ManagementObject GetPrinterObject(string diskModel);
//        bool UninstallPrinter(string printerName);
    }
}
