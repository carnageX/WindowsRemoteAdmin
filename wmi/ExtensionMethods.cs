using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wmi.Models;
using System.Management;
using System.Management.Instrumentation;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace wmi
{
    public static class ExtensionMethods
    {
        public static List<DiskInfo> GetDiskInfo(this SystemInfo systemInfo, ManagementScope scope)
        {
            var disks = new List<DiskInfo>();
            var query = new ObjectQuery("SELECT FreeSpace,Size,Name,VolumeName,DeviceID FROM Win32_LogicalDisk WHERE DriveType=3");
            var searcher = new ManagementObjectSearcher(scope, query);
            var diskCollection = searcher.Get();

            foreach (var disk in diskCollection)
            {
                disks.Add(
                    new DiskInfo()
                    {
                        DiskId = disk["DeviceID"].ToString(),
                        DiskName = disk["Name"].ToString(),
                        SizeInBytes = disk["Size"].ToString(),
                        FreeSpaceInBytes = disk["FreeSpace"].ToString(),
                        Volume = disk["VolumeName"].ToString()
                    }
                );
            }
            return disks;
        }

        public static List<DriveInfo> GetDriveInfo(this SystemInfo systemInfo, ManagementScope scope)
        {
            var driveList = new List<DriveInfo>();
            var query = new ObjectQuery("SELECT Caption, DeviceID, Model, Partitions, Size FROM Win32_DiskDrive");
            var searcher = new ManagementObjectSearcher(scope, query);
            var drives = searcher.Get();

            foreach(var drive in drives)
            {
                driveList.Add(
                    new DriveInfo()
                    {
                        Caption = drive["Caption"].ToString(),
                        DeviceId = drive["DeviceID"].ToString(),
                        Model = drive["Model"].ToString(),
                        Partitions = drive["Partitions"].ToString(),
                        SizeInBytes = drive["Size"].ToString()
                    }
                );
            }
            return driveList;
        }

        public static List<AdminPasswordStatus> GetAdminPasswordStatus(this SystemInfo systemInfo, ManagementScope scope)
        {
            var statuses = new List<AdminPasswordStatus>();
            var query = new ObjectQuery("SELECT AdminPasswordStatus,UserName FROM Win32_ComputerSystem");
            var searcher = new ManagementObjectSearcher(scope, query);
            var statusCollection = searcher.Get();
            foreach (var status in statusCollection)
            {
                var passwordStatus = String.Empty;
                if (status["AdminPasswordStatus"] == null) { passwordStatus = "null"; }
                else if (status["AdminPasswordStatus"].ToString() == "0") { passwordStatus = "Disabled"; }
                else if (status["AdminPasswordStatus"].ToString() == "1") { passwordStatus = "Enabled"; }
                else if (status["AdminPasswordStatus"].ToString() == "2") { passwordStatus = "Not Implemented"; }
                else if (status["AdminPasswordStatus"].ToString() == "3") { passwordStatus = "Unknown"; }
                else { passwordStatus = "Unknown"; }

                string username;
                if (status["UserName"] != null) { username = status["UserName"].ToString(); }
                else { username = "null"; }

                statuses.Add(
                    new AdminPasswordStatus()
                    {
                        Status = passwordStatus,
                        Username = username
                    }
                );
            }
            return statuses;
        }
    }

    public static class TextBoxWatermarkExtensionMethod
    {
        private const uint ECM_FIRST = 0x1500;
        private const uint EM_SETCUEBANNER = ECM_FIRST + 1;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        public static void SetWatermark(this TextBox textBox, string watermarkText)
        {
            SendMessage(textBox.Handle, EM_SETCUEBANNER, 0, watermarkText);
        }
    }
}
