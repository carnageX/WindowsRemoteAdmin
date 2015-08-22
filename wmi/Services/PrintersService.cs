using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wmi.Services.Interfaces;
using System.Management;
using System.Management.Instrumentation;
using wmi.Models;

namespace wmi.Services
{
    public class PrintersService : IPrintersService
    {
        private ManagementScope _scope { get; set; }
        private ConnectionOptions _options { get; set; }

        public PrintersService(ManagementScope scope, ConnectionOptions options)
        {
            _scope = scope;
            _options = options;

            _scope.Connect();
        }

        public List<PrinterInfo> GetPrinters()
        {
            var printerNames = new List<PrinterInfo>();
            var printers = GetAllPrinters();
            foreach (var printer in printers)
            {
                printerNames.Add(
                    new PrinterInfo
                    {
                        Name = String.Format("{0}", printer["Name"])
                    }
                );
            }
            return printerNames;
        }

        public ManagementObjectCollection GetAllPrinters()
        {
            var query = new ObjectQuery("SELECT Name FROM Win32_Printer");
            var searcher = new ManagementObjectSearcher(_scope, query);
            return searcher.Get();
        }

        public ManagementObject GetPrinterObject(string printerName)
        {
            var query = new ObjectQuery(String.Format("SELECT Name FROM Win32_Printer where Name='{0}'", printerName));
            var searcher = new ManagementObjectSearcher(_scope, query);
            var printer = searcher.Get().Cast<ManagementObject>().FirstOrDefault();
            return printer;
        }

        public bool UninstallPrinter(string printerName)
        {
            var printer = GetPrinterObject(printerName);
            printer.Delete();
            return true;
        }
    }
}
