using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wmi.Services.Interfaces;
using wmi.Models;
using System.Management;
using System.Management.Instrumentation;

namespace wmi.Services.Interfaces
{
    public class ServicesService : IServicesService
    {
        private ManagementScope _scope { get; set; }
        private ConnectionOptions _options { get; set; }

        public ServicesService(ManagementScope scope, ConnectionOptions options)
        {
            _scope = scope;
            _options = options;

            _scope.Connect();
        }

        public List<string> GetServicesNameList()
        {
            var serviceNames = new List<string>();
            var services = GetAllServices();
            foreach(var service in services)
            {
                serviceNames.Add(service.Caption);
            }
            return serviceNames;
        }

        public List<ServiceInfo> GetAllServices()
        {
            var servicesList = new List<ServiceInfo>();
            var query = new ObjectQuery("SELECT Caption,State FROM Win32_Service");
            var searcher = new ManagementObjectSearcher(_scope, query);
            var services = searcher.Get();
            foreach (var s in services)
            {
                servicesList.Add(
                    new ServiceInfo()
                    {
                        Caption = String.Format("{0}", s["Caption"]),
                        State = String.Format("{0}", s["State"])
                    }
                );
            }
            return servicesList;
        }

        public ManagementObject GetServiceObject(string serviceName)
        {
            var query = new ObjectQuery(String.Format("SELECT * FROM Win32_Service where Caption='{0}'", serviceName));
            var searcher = new ManagementObjectSearcher(_scope, query);
            var service = searcher.Get().Cast<ManagementObject>().FirstOrDefault();
            return service;
        }

        public List<ManagementObject> GetServiceObjects(params string[] serviceNames)
        {
            var services = new List<ManagementObject>();
            foreach(var service in serviceNames)
            {
                services.Add(GetServiceObject(service));
            }
            return services;
        }

        public bool StartService(string serviceName)
        {
            bool isStarted = false;

            var service = GetServiceObject(serviceName);
            if(service["Started"].Equals(false))
            {
                service.InvokeMethod("StartService", null);
                isStarted = true;
            }

            return isStarted;
        }

        public Dictionary<string, bool> StartServices(params string[] serviceNames)
        {
            var results = new Dictionary<string, bool>();
            foreach(var service in serviceNames)
            {
                results.Add(service, StartService(service));
            }
            return results;
        }

        public bool StopService(string serviceName)
        {
            bool isStopped = false;

            var service = GetServiceObject(serviceName);
            if (service["Started"].Equals(true))
            {
                service.InvokeMethod("StopService", null);
                isStopped = true;
            }

            return isStopped;
        }

        public Dictionary<string, bool> StopServices(params string[] serviceNames)
        {
            var results = new Dictionary<string, bool>();
            foreach (var service in serviceNames)
            {
                results.Add(service, StopService(service));
            }
            return results;
        }

        public string GetServiceStatus(string serviceName)
        {
            var service = GetServiceObject(serviceName);
            if (service["Started"].Equals(true))
                return "Started";
            else
                return "Stopped";
        }
    }
}
