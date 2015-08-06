using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wmi.Models;

namespace wmi.Services.Interfaces
{
    public interface ISystemInfoService
    {
        List<SystemInfo> GetSystemInfo();
        void GetBaseSystemInfo(List<SystemInfo> systemInfoCollection);
    }
}
