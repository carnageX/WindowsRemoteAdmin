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
            var selectList = "AccountType, Disabled, FullName, LocalAccount, Name, PasswordChangeable, PasswordExpires, PasswordRequired, SID, Status";
            if (query == null) { query = new ObjectQuery(String.Format("SELECT {0} FROM Win32_UserAccount WHERE LocalAccount = True", selectList)); }
            var searcher = new ManagementObjectSearcher(_scope, query);
            var accountCollection = searcher.Get();

            foreach(var account in accountCollection)
            {
                accounts.Add
                (
                    new LocalAccountInfo()
                    {
                        AccountType = (account["AccountType"] != null) ? account["AccountType"].ToString() : String.Empty,
                        //Caption = (account["Caption"] != null) ? account["Caption"].ToString() : String.Empty,
                        //Description = (account["Description"] != null) ? account["Description"].ToString() : String.Empty,
                        Disabled = (account["Disabled"] != null) ? account["Disabled"].ToString() : String.Empty,
                        //Domain = (account["Domain"] != null) ? account["Domain"].ToString() : String.Empty,
                        FullName = (account["FullName"] != null) ? account["FullName"].ToString() : String.Empty,
                        //InstallDate = (account["InstallDate"] != null) ? account["InstallDate"].ToString() : String.Empty,
                        LocalAccount = (account["LocalAccount"] != null) ? account["LocalAccount"].ToString() : String.Empty,
                        //Lockout = (account["Lockout"] != null) ? account["Lockout"].ToString() : String.Empty,
                        Name = (account["Name"] != null) ? account["Name"].ToString() : String.Empty,
                        PasswordChangeable = (account["PasswordChangeable"] != null) ? account["PasswordChangeable"].ToString() : String.Empty,
                        PasswordExpires = (account["PasswordExpires"] != null) ? account["PasswordExpires"].ToString() : String.Empty,
                        PasswordRequired = (account["PasswordRequired"] != null) ? account["PasswordRequired"].ToString() : String.Empty,
                        SID = (account["SID"] != null) ? account["SID"].ToString() : String.Empty,
                        //SIDType = (account["SIDType"] != null) ? account["SIDType"].ToString() : String.Empty,
                        Status = (account["Status"] != null) ? account["Status"].ToString() : String.Empty
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
