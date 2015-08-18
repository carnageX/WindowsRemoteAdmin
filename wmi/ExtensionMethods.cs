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
            var criteria = "FreeSpace,Size,Name,VolumeName,DeviceID";
            var query = new ObjectQuery(String.Format("SELECT {0} FROM Win32_LogicalDisk WHERE DriveType=3", criteria));
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
            var criteria = "Caption, DeviceID, Model, Partitions, Size";
            var query = new ObjectQuery(String.Format("SELECT {0} FROM Win32_DiskDrive", criteria));
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

        public static List<ComputerSystem> GetComputerSystemInfo(this SystemInfo systemInfo, ManagementScope scope)
        {
            var infoList = new List<ComputerSystem>();
            var criteria = "AdminPasswordStatus,UserName,Manufacturer,Model";
            var query = new ObjectQuery(String.Format("SELECT {0} FROM Win32_ComputerSystem", criteria));
            var searcher = new ManagementObjectSearcher(scope, query);
            var infoCollection = searcher.Get();
            foreach (var item in infoCollection)
            {
                var passwordStatus = String.Empty;
                if (item["AdminPasswordStatus"] == null) { passwordStatus = "null"; }
                else if (item["AdminPasswordStatus"].ToString() == "0") { passwordStatus = "Disabled"; }
                else if (item["AdminPasswordStatus"].ToString() == "1") { passwordStatus = "Enabled"; }
                else if (item["AdminPasswordStatus"].ToString() == "2") { passwordStatus = "Not Implemented"; }
                else if (item["AdminPasswordStatus"].ToString() == "3") { passwordStatus = "Unknown"; }
                else { passwordStatus = "Unknown"; }

                var username = item["UserName"];

                infoList.Add(
                    new ComputerSystem()
                    {
                        PasswordStatus = passwordStatus,
                        Username = (username != null) ? username.ToString() : "None",
                        Manufacturer = String.Format("{0}", item["Manufacturer"]),
                        Model = String.Format("{0}", item["Model"])
                    }
                );
            }
            return infoList;
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
