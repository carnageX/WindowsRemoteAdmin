using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using wmi.Models;

namespace wmi.Services.Interfaces
{
    public interface ILocalAccountService
    {
        List<LocalAccountInfo> GetAllLocalAccounts(ObjectQuery query = null);
        LocalAccountInfo GetLocalAccountInfoBySID(string sid);
    }
}
