using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Management.Instrumentation;

namespace wmi
{
    public partial class Form1 : Form
    {
        string computerName;
        string software;
        
        
        public Form1()
        {
            InitializeComponent();
        }




      private void Form1_Load(object sender, EventArgs e)
        {
            

            }

 

        private void cmbHdd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void StartApp()
        {

            {

                //            string computerName;
//                computerName = "fidca01";
                
                computerName = compName.Text;
 


                // Build an options object for the remote connection 
                // if you plan to connect to the remote 
                // computer with a different user name 
                // and password than the one you are currently using. 
                // This example uses the default values. 

                ConnectionOptions options =
                    new ConnectionOptions();

                // Make a connection to a remote computer. 
                // Replace the "FullComputerName" section of the
                // string "\\\\FullComputerName\\root\\cimv2" with
                // the full computer name or IP address of the 
                // remote computer.
                ManagementScope scope =
                    new ManagementScope(
                        "\\\\" + computerName + "\\root\\cimv2", options);

                //                "\\\\172.24.101.30\\root\\cimv2", options);
                scope.Connect();

                //Query system for Operating System information
                ObjectQuery query = new ObjectQuery(
                    "SELECT * FROM Win32_OperatingSystem");
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher(scope, query);

                ManagementObjectCollection queryCollection = searcher.Get();
                foreach (ManagementObject m in queryCollection)
                {
                    // Display the remote computer information

                    lblCNam.Text = "Hostname: " + m["csname"].ToString();
                    lblWinDir.Text = "Win Dir: " + m["WindowsDirectory"].ToString();
                    lblCap.Text =  m["Caption"].ToString();
                    lblMan.Text = "Manufacturer: " + m["Manufacturer"].ToString();
                    lblVer.Text = "Version: " + m["Version"].ToString();
                    lblRproc.Text = m["NumberOfProcesses"].ToString();
                    lblArch.Text = m["OSArchitecture"].ToString();
                    lblRam.Text = m["TotalVisibleMemorySize"].ToString() + " bytes (" + Math.Round((((double)Convert.ToDouble(m["TotalVisibleMemorySize"]) / 1024) / 1024), 2) + " GB)";


                    //Console.WriteLine("Computer Name : {0}",
                    //    m["csname"]);
                    //Console.WriteLine("Windows Directory : {0}",
                    //    m["WindowsDirectory"]);
                    //Console.WriteLine("Operating System: {0}",
                    //    m["Caption"]);
                    //Console.WriteLine("Version: {0}", m["Version"]);
                    //Console.WriteLine("Manufacturer : {0}",
                    //    m["Manufacturer"]);
                }
                    
                
                    //Connection credentials to the remote computer – not needed if the logged in account has access
                    ConnectionOptions oConn = new ConnectionOptions();
                    //oConn.Username = "JohnDoe";
                    //oConn.Password = "JohnsPass";

                    System.Management.ManagementScope oMs = new System.Management.ManagementScope("\\\\" + computerName + "\\root\\cimv2", oConn);    

                    //get Fixed disk stats
                    System.Management.ObjectQuery oQuery = new System.Management.ObjectQuery("select FreeSpace,Size,Name from Win32_LogicalDisk where DriveType=3");

                    //Execute the query 
                    ManagementObjectSearcher oSearcher = new ManagementObjectSearcher(oMs,oQuery);

                    //Get the results
                    ManagementObjectCollection oReturnCollection = oSearcher.Get();   
         
                    //loop through found drives and write out info
                    foreach( ManagementObject oReturn in oReturnCollection )
                        {
                        lblType.Text =  oReturn["Name"].ToString();
                        lblModel.Text =  oReturn["Size"].ToString() + " bytes (" + Math.Round(((((double)Convert.ToDouble(oReturn["Size"]) / 1024) / 1024) / 1024), 2) + " GB)";
                        lblSerial.Text =  oReturn["FreeSpace"].ToString() + " bytes (" + Math.Round(((((double)Convert.ToDouble(oReturn["FreeSpace"]) / 1024) / 1024) / 1024), 2) + " GB)";
                        
                        
                        // Disk name
                        //Console.WriteLine("Name : " + oReturn["Name"].ToString());
                        // Free Space in bytes
                        //Console.WriteLine("FreeSpace: " + oReturn["FreeSpace"].ToString());
                        // Size in bytes
                        //Console.WriteLine("Size: " + oReturn["Size"].ToString());
                        }

                    ConnectionOptions connection = new ConnectionOptions();
                    //connection.Username = userNameBox.Text;
                    //connection.Password = passwordBox.Text;
                    //connection.Authority = "ntlmdomain:ficont.finneycounty.org";

                    ManagementScope scopeAdm = new ManagementScope(
                        "\\\\" + computerName + "\\root\\cimv2", connection);
                    scopeAdm.Connect();

                    ObjectQuery queryAdm = new ObjectQuery(
                        "SELECT AdminPasswordStatus,UserName FROM Win32_ComputerSystem");

                    ManagementObjectSearcher searcherAdm =
                        new ManagementObjectSearcher(scopeAdm, queryAdm);

                    foreach (ManagementObject queryObjAdm in searcherAdm.Get())
                    {


                  //      lblAdmSts.Text = queryObjAdm["AdminPasswordStatus"].ToString();
                       
                        try
                         {
                             lblUser.Text = queryObjAdm["UserName"].ToString();
                         }
                             catch { }            
                  //      if (lblAdmSts.Equals (0)) 
                        if (queryObjAdm["AdminPasswordStatus"].ToString() == "0") 
                        {
                            lblAdmSts.Text = "Disabled".ToString(); 
                        }
                        else if (queryObjAdm["AdminPasswordStatus"].ToString() == "1")
                        {
                            lblAdmSts.Text = "Enabled".ToString();
                        }
                        else if (queryObjAdm["AdminPasswordStatus"].ToString() == "2")
                        {
                            lblAdmSts.Text = "Not Implemented".ToString();
                        }
                        else if (queryObjAdm["AdminPasswordStatus"].ToString() == "3")
                        {
                            lblAdmSts.Text = "Unknown".ToString();
                        }



                        //Console.WriteLine("-----------------------------------");
                        //Console.WriteLine("Win32_ComputerSystem instance");
                        //Console.WriteLine("-----------------------------------");
                        //Console.WriteLine("AdminPasswordStatus: {0}", queryObjAdm["AdminPasswordStatus"]);
                    }



                //          Get all the disk drives from WMI that match the Model name selected in the ComboBox

                //          lblType.Text = "-";

                //            ManagementObjectSearcher mosDisks = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive WHERE Model = '" + cmbHdd.SelectedItem + "'");

                //          Loop through the drives retrieved, although it should normally be only one loop going on here

                //foreach (ManagementObject moDisk in mosDisks.Get())
                //{

                //    //               Set all the fields to the appropriate values
                //    try
                //    {
                //        lblType.Text = moDisk["name"].ToString();
                //    }
                //    catch { }
                //    lblModel.Text = "Model: " + moDisk["Model"].ToString();

                //    lblSerial.Text = "Serial: " + moDisk["SerialNumber"].ToString();

                //    lblInterface.Text = "Interface: " + moDisk["InterfaceType"].ToString();

                //    //               The capacity in gigabytes is easily calculated

                //    lblCapacity.Text = "Capacity: " + moDisk["Size"].ToString() + " bytes (" + Math.Round(((((double)Convert.ToDouble(moDisk["Size"]) / 1024) / 1024) / 1024), 2) + " GB)";

                //    lblPartitions.Text = "Partitions: " + moDisk["Partitions"].ToString();



                //    //                lblCompName.Text = computerName.ToString();


                //}


            }
        
    
 

        }



        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                StartApp();
            }
            catch { }

        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                lstServices.Items.Clear();
                ConnectionOptions connServ = new ConnectionOptions();
                //conn.Impersonation = ImpersonationLevel.Impersonate;
                //conn.Username = txtUsername.Text;
                //conn.Password = txtPassword.Text;
                ManagementScope theScope = new ManagementScope("\\\\" + computerName + "\\root\\cimv2", connServ);
                ManagementObjectSearcher servSearcher = new ManagementObjectSearcher(theScope, new ObjectQuery("SELECT * FROM Win32_Service"));

                foreach (ManagementObject servObj in servSearcher.Get())
                {
                    lstServices.Items.Add(servObj["Caption"]);
                }
            }
            catch { }
        }
        

    

//this block gets software
        private void btnSoftware_Click(object sender, EventArgs e)
        {
            try
            {
                lstSoftware.Items.Clear();
                ConnectionOptions connProd = new ConnectionOptions();
                //connection.Username = userNameBox.Text;
                //connection.Password = passwordBox.Text;
                //connection.Authority = "ntlmdomain:ficont.finneycounty.org";

                ManagementScope scopeProd = new ManagementScope(
                    "\\\\" + computerName + "\\root\\cimv2", connProd);
                scopeProd.Connect();

                ObjectQuery queryProd = new ObjectQuery(
                    "SELECT Name FROM Win32_Product");

                ManagementObjectSearcher searcherProd =
                    new ManagementObjectSearcher(scopeProd, queryProd);

                foreach (ManagementObject queryObjProd in searcherProd.Get())
                {
                    //txtProd.Text = queryObjProd["Name"] + "\r\n".ToString ();
                    //txtProd.Text += queryObjProd["Name"].ToString() + Environment.NewLine;

                    //Console.WriteLine("-----------------------------------");
                    //Console.WriteLine("Win32_Product instance");
                    //Console.WriteLine("-----------------------------------");
                    //Console.WriteLine("Name: {0}", queryObjProd["Name"]);
                }

                foreach (ManagementObject servObjSoft in searcherProd.Get())
                {
                    try
                    {
                        lstSoftware.Items.Add(servObjSoft["Name"]);
                    }
                    catch { }

                }
            }
            catch { }

        }

        private void btnUnin_Click(object sender, EventArgs e)
        {
            try
            {
                ManagementObjectCollection softwareObj = fetchSoftwareObject(lstSoftware.SelectedItem.ToString());
                foreach (ManagementObject Name in softwareObj)
                {
                    try
                    {

                        object hr = Name.InvokeMethod("Uninstall", null);
                        lstSoftware.ClearSelected();
                        //return (bool)hr;
                    }
                    catch (Exception ex)
                    {
                        //this program may not have a name property, so an exception will be thrown
                    }


                }
            }
            catch { }
        
        }


        public ManagementObjectCollection fetchSoftwareObject(string software)
        {
            ConnectionOptions conn = new ConnectionOptions();
//            conn.Impersonation = ImpersonationLevel.Impersonate;
//            conn.Username = txtUsername.Text;
//            conn.Password = txtPassword.Text;
            ManagementScope theScope = new ManagementScope("\\\\" + computerName + "\\root\\cimv2", conn);
            ManagementObjectSearcher softwareSearcher = new ManagementObjectSearcher(theScope, new ObjectQuery("SELECT Name FROM Win32_Product where Caption='" + software + "'"));

            return softwareSearcher.Get();     // Returns the service where caption == listbox  selected item     
        }




//this block for services
        public ManagementObjectCollection fetchServiceObject(string service)
        {
            ConnectionOptions conn = new ConnectionOptions();
            //conn.Impersonation = ImpersonationLevel.Impersonate;
            //conn.Username = txtUsername.Text;
            //conn.Password = txtPassword.Text;
            ManagementScope theScope = new ManagementScope("\\\\" + computerName + "\\root\\cimv2", conn);
            ManagementObjectSearcher serviceSearcher = new ManagementObjectSearcher(theScope, new ObjectQuery("SELECT * FROM Win32_Service where Caption='" + service + "'"));

            return serviceSearcher.Get();     // Returns the service where caption == listbox  selected item     
        }     
  
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                ManagementObjectCollection serviceObjs = fetchServiceObject(lstServices.SelectedItem.ToString());
                foreach (ManagementObject service in serviceObjs)
                {
                    if (service["Started"].Equals(false))
                    {
                        service.InvokeMethod("StartService", null);
                        lblState.Text = "Started";
                    }
                }
            }
            catch { }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                ManagementObjectCollection serviceObjs = fetchServiceObject(lstServices.SelectedItem.ToString());
                foreach (ManagementObject service in serviceObjs)
                {
                    if (service["Started"].Equals(true))
                    {
                        service.InvokeMethod("StopService", null);
                        lblState.Text = "Stopped";
                    }
                }
            }
            catch { }
        }

        private void lstServices_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                ManagementObjectCollection serviceobjs = fetchServiceObject(lstServices.SelectedItem.ToString());
                foreach (ManagementObject service in serviceobjs)
                {
                    if (service["started"].Equals(true))
                    {
                        lblState.Text = "Started";
                    }
                    else
                    {
                        lblState.Text = "Stopped";
                    }
                }
            }
            catch { }
        }

        private void txtProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAbt_Click(object sender, EventArgs e)
        {
            new AboutBox1().ShowDialog();
        }

        private void btnPrinters_Click(object sender, EventArgs e)
        {
            try
            {
                lstPrinters.Items.Clear();
                ConnectionOptions connPrint = new ConnectionOptions();
                //connection.Username = userNameBox.Text;
                //connection.Password = passwordBox.Text;
                //connection.Authority = "ntlmdomain:ficont.finneycounty.org";

                ManagementScope scopePrint = new ManagementScope(
                    "\\\\" + computerName + "\\root\\cimv2", connPrint);
                scopePrint.Connect();

                ObjectQuery queryPrint = new ObjectQuery(
                    "SELECT Name FROM Win32_Printer");

                ManagementObjectSearcher searcherPrint =
                    new ManagementObjectSearcher(scopePrint, queryPrint);

//                foreach (ManagementObject queryObjPrint in searcherPrint.Get())
//                {
                    //txtProd.Text = queryObjPrint["Name"] + "\r\n".ToString ();
                    //txtProd.Text += queryObjPrint["Name"].ToString() + Environment.NewLine;
                    //Console.WriteLine("-----------------------------------");
                    //Console.WriteLine("Win32_Product instance");
                    //Console.WriteLine("-----------------------------------");
                    //Console.WriteLine("Name: {0}", queryObjPrint["Name"]);
//                }

                foreach (ManagementObject servObjPrint in searcherPrint.Get())
                {
                    try
                    {
                        lstPrinters.Items.Add(servObjPrint["Name"]);
                    }
                    catch { }

                }
            }
            catch { }

        }

        private void btnUnprnt_Click(object sender, EventArgs e)
        {
            try
            {
                ManagementObjectCollection printerObj = fetchPrinterObject(lstPrinters.SelectedItem.ToString());
                foreach (ManagementObject NameP in printerObj)
                {
                    
                    try
                    {
//                       lstPrinters.ClearSelected();
                         NameP.Delete();
                         lstPrinters.Items.Clear(); 
                         ConnectionOptions connPrint = new ConnectionOptions();
                         ManagementScope scopePrint = new ManagementScope(
                         "\\\\" + computerName + "\\root\\cimv2", connPrint);
                         scopePrint.Connect();

                         ObjectQuery queryPrint = new ObjectQuery(
                         "SELECT Name FROM Win32_Printer");

                         ManagementObjectSearcher searcherPrint =
                         new ManagementObjectSearcher(scopePrint, queryPrint);

 
                foreach (ManagementObject servObjPrint in searcherPrint.Get())
                {
                    try
                    {
                        lstPrinters.Items.Add(servObjPrint["Name"]);
                    }
                    catch { }
                }
//                       string printerName = NameP["Name"].ToString().ToLower();
//                       if (printerName.Equals(printerName.ToLower()))
//                       {
//                           
//                          NameP.Delete();
//                       }
                         //return (bool)hr;
                    }
                    catch { }
                }
               
            }
            catch { }
        }
        public ManagementObjectCollection fetchPrinterObject(string Printer)
        {
            ConnectionOptions conn = new ConnectionOptions();
            //            conn.Impersonation = ImpersonationLevel.Impersonate;
            //            conn.Username = txtUsername.Text;
            //            conn.Password = txtPassword.Text;
            ManagementScope thePScope = new ManagementScope("\\\\" + computerName + "\\root\\cimv2", conn);
            ManagementObjectSearcher printerSearcher = new ManagementObjectSearcher(thePScope, new ObjectQuery("SELECT * FROM Win32_Printer where Caption='" + Printer + "'"));

            return printerSearcher.Get();     // Returns the service where caption == listbox  selected item     
        }
        
        
  //      private void button1_Click(object sender, EventArgs e)
  //      {
  //      }
//    }
//}
//        private void cmbHdd_SelectedIndexChanged(object sender, EventArgs e)
//        {
            //lblType.Text = "-";
            //lblModel.Text = "-";
//            ManagementObjectSearcher mosDisk = new ManagementObjectSearcher("Select * From Win32_DiskDrive Where Model='" + cmbHdd.SelectedItem + "'");

            //foreach (ManagementObject moDisk in mosDisk.Get())
            //{
            //    try
            //    {
            //        lblType.Text = moDisk["name"].ToString();
            //    }
            //    catch { }
            //    try
            //    {
            //        lblModel.Text = moDisk["Model"].ToString();
            //    }
            //    catch { }
            //}
//        }




    }
}