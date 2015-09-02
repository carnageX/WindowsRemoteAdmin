using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wmi.Services.Interfaces
{
    public interface IExportService
    {
        List<DataTable> GetSystemInfo();
        DataTable GetServicesInfo();
        DataTable GetSoftwareInfo();
        DataTable GetPrintersInfo();
        DataTable GetDrivesInfo();
        DataTable GetLocalAccountsInfo();
    }
}
