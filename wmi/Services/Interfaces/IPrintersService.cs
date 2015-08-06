using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Management.Instrumentation;

namespace wmi.Services.Interfaces
{
    public interface IPrintersService
    {
        List<string> GetPrinterNames();
        ManagementObjectCollection GetAllPrinters();
        ManagementObject GetPrinterObject(string printerName);
        bool UninstallPrinter(string printerName);
    }
}
