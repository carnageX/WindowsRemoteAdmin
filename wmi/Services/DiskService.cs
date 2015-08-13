using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wmi.Models;
using wmi.Services.Interfaces;
using wmi.Services;
using System.Management;
using System.Management.Instrumentation;

namespace wmi.Services
{
    public class DiskService : IDiskService
    {
        private ManagementScope _scope { get; set; }
        private ConnectionOptions _options { get; set; }

        public DiskService(ManagementScope scope, ConnectionOptions options)
        {
            _scope = scope;
            _options = options;

            _scope.Connect();
        }

        public DiskInfo GetDiskInfo(string diskId)
        {
            var disks = new List<DiskInfo>();
            var query = new ObjectQuery(String.Format("SELECT DeviceID, Name, FreeSpace, Size, Volume FROM Win32_LogicalDisk WHERE DeviceID = {0}", diskId));
            var searcher = new ManagementObjectSearcher(_scope, query);
            var diskCollection = searcher.Get();

            foreach(var disk in diskCollection)
            {
                disks.Add
                (
                    new DiskInfo()
                    {
                        DiskId = disk["DeviceID"].ToString(),
                        DiskName = disk["Name"].ToString(),
                        FreeSpaceInBytes = disk["FreeSpace"].ToString(),
                        SizeInBytes = disk["Size"].ToString(),
                        Volume = disk["Volume"].ToString()
                    }
                );
            }
            return disks.FirstOrDefault();
        }

        public DriveInfo GetDriveInfo(string driveId)
        {
            var drives = new List<DriveInfo>();
            var query = new ObjectQuery(String.Format(""));
            var searcher = new ManagementObjectSearcher(_scope, query);
            var driveCollection = searcher.Get();

            foreach(var drive in driveCollection)
            {
                drives.Add
                (
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
            return drives.FirstOrDefault();
        }
    }
}
