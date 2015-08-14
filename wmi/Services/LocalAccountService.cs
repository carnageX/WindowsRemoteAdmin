using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using wmi.Models;

namespace wmi.Services.Interfaces
{
    public class LocalAccountService : ILocalAccountService
    {
        private ManagementScope _scope { get; set; }
        private ConnectionOptions _options { get; set; }

        public LocalAccountService(ManagementScope scope, ConnectionOptions options)
        {
            _scope = scope;
            _options = options;

            _scope.Connect();
        }

        public List<LocalAccountInfo> GetAllLocalAccounts(ObjectQuery query = null)
        {
            var accounts = new List<LocalAccountInfo>();
            var selectList = "AccountType, Disabled, Caption, LocalAccount, Name, PasswordChangeable, PasswordExpires, PasswordRequired, SID, Status, Lockout";
            if (query == null) { query = new ObjectQuery(String.Format("SELECT {0} FROM Win32_UserAccount WHERE LocalAccount = True", selectList)); }
            var searcher = new ManagementObjectSearcher(_scope, query);
            var accountCollection = searcher.Get();

            foreach(var account in accountCollection)
            {
                accounts.Add
                (
                    new LocalAccountInfo()
                    {
                        AccountType = String.Format("{0}", account["AccountType"]),
                        Caption = String.Format("{0}", account["Caption"]),
                        //Description = String.Format("{0}", account["Description"]),
                        Disabled = String.Format("{0}", account["Disabled"]),
                        //Domain = String.Format("{0}", account["Domain"]),
                        //FullName = String.Format("{0}", account["FullName"]), 
                        //InstallDate = String.Format("{0}", account["InstallDate"]),
                        LocalAccount = String.Format("{0}", account["LocalAccount"]),
                        Lockout = String.Format("{0}", account["Lockout"]),
                        Name = String.Format("{0}", account["Name"]),
                        PasswordChangeable = String.Format("{0}", account["PasswordChangeable"]),
                        PasswordExpires = String.Format("{0}", account["PasswordExpires"]),
                        PasswordRequired = String.Format("{0}", account["PasswordRequired"]),
                        SID = String.Format("{0}", account["SID"]),
                        //SIDType = String.Format("{0}", account["SIDType"]),
                        Status = String.Format("{0}", account["Status"])
                    }
                );
            }
            return accounts;
        }

        public LocalAccountInfo GetLocalAccountInfoBySID(string sid)
        {
            var query = new ObjectQuery(String.Format("SELECT * FROM Win32_UserAccount WHERE SID = {0}", sid));
            return GetAllLocalAccounts(query).FirstOrDefault();
        }
    }
}
