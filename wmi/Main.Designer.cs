namespace wmi
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblComputerConn = new System.Windows.Forms.Label();
            this.txtCompName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSysInfo = new System.Windows.Forms.TabPage();
            this.lblVer = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblCaption = new System.Windows.Forms.Label();
            this.lblWinDir = new System.Windows.Forms.Label();
            this.lblComputerName = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblAdminStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblRam = new System.Windows.Forms.Label();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.lblArch = new System.Windows.Forms.Label();
            this.lblProcCount = new System.Windows.Forms.Label();
            this.lblDiskFree = new System.Windows.Forms.Label();
            this.lblDiskSize = new System.Windows.Forms.Label();
            this.lblDiskName = new System.Windows.Forms.Label();
            this.tabServices = new System.Windows.Forms.TabPage();
            this.lblServiceStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listServices = new System.Windows.Forms.ListBox();
            this.btnServiceStop = new System.Windows.Forms.Button();
            this.btnServiceStart = new System.Windows.Forms.Button();
            this.btnGetServices = new System.Windows.Forms.Button();
            this.tabSoftware = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listSoftware = new System.Windows.Forms.ListBox();
            this.btnSoftwareUninstall = new System.Windows.Forms.Button();
            this.btnGetSoftware = new System.Windows.Forms.Button();
            this.tabPrinters = new System.Windows.Forms.TabPage();
            this.btnUninstallPrinter = new System.Windows.Forms.Button();
            this.btnGetPrinters = new System.Windows.Forms.Button();
            this.listPrinters = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabSysInfo.SuspendLayout();
            this.tabServices.SuspendLayout();
            this.tabSoftware.SuspendLayout();
            this.tabPrinters.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(280, 36);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 117;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblComputerConn
            // 
            this.lblComputerConn.AutoSize = true;
            this.lblComputerConn.Location = new System.Drawing.Point(12, 41);
            this.lblComputerConn.Name = "lblComputerConn";
            this.lblComputerConn.Size = new System.Drawing.Size(105, 13);
            this.lblComputerConn.TabIndex = 116;
            this.lblComputerConn.Text = "Enter PC Name or IP";
            // 
            // txtCompName
            // 
            this.txtCompName.Location = new System.Drawing.Point(123, 38);
            this.txtCompName.Name = "txtCompName";
            this.txtCompName.Size = new System.Drawing.Size(151, 20);
            this.txtCompName.TabIndex = 115;
            this.txtCompName.Text = "127.0.0.1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(627, 24);
            this.menuStrip1.TabIndex = 118;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabSysInfo);
            this.tabControl.Controls.Add(this.tabServices);
            this.tabControl.Controls.Add(this.tabSoftware);
            this.tabControl.Controls.Add(this.tabPrinters);
            this.tabControl.Location = new System.Drawing.Point(12, 65);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(603, 369);
            this.tabControl.TabIndex = 119;
            // 
            // tabSysInfo
            // 
            this.tabSysInfo.BackColor = System.Drawing.SystemColors.Control;
            this.tabSysInfo.Controls.Add(this.lblVer);
            this.tabSysInfo.Controls.Add(this.lblManufacturer);
            this.tabSysInfo.Controls.Add(this.lblCaption);
            this.tabSysInfo.Controls.Add(this.lblWinDir);
            this.tabSysInfo.Controls.Add(this.lblComputerName);
            this.tabSysInfo.Controls.Add(this.label27);
            this.tabSysInfo.Controls.Add(this.lblAdminStatus);
            this.tabSysInfo.Controls.Add(this.label3);
            this.tabSysInfo.Controls.Add(this.label2);
            this.tabSysInfo.Controls.Add(this.label4);
            this.tabSysInfo.Controls.Add(this.label5);
            this.tabSysInfo.Controls.Add(this.label6);
            this.tabSysInfo.Controls.Add(this.label7);
            this.tabSysInfo.Controls.Add(this.label10);
            this.tabSysInfo.Controls.Add(this.lblRam);
            this.tabSysInfo.Controls.Add(this.lblCurrentUser);
            this.tabSysInfo.Controls.Add(this.lblArch);
            this.tabSysInfo.Controls.Add(this.lblProcCount);
            this.tabSysInfo.Controls.Add(this.lblDiskFree);
            this.tabSysInfo.Controls.Add(this.lblDiskSize);
            this.tabSysInfo.Controls.Add(this.lblDiskName);
            this.tabSysInfo.Location = new System.Drawing.Point(4, 22);
            this.tabSysInfo.Name = "tabSysInfo";
            this.tabSysInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabSysInfo.Size = new System.Drawing.Size(595, 343);
            this.tabSysInfo.TabIndex = 0;
            this.tabSysInfo.Text = "System Info";
            // 
            // lblVer
            // 
            this.lblVer.AutoSize = true;
            this.lblVer.Location = new System.Drawing.Point(16, 283);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(10, 13);
            this.lblVer.TabIndex = 132;
            this.lblVer.Text = "-";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(16, 306);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(10, 13);
            this.lblManufacturer.TabIndex = 131;
            this.lblManufacturer.Text = "-";
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Location = new System.Drawing.Point(16, 258);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(10, 13);
            this.lblCaption.TabIndex = 130;
            this.lblCaption.Text = "-";
            // 
            // lblWinDir
            // 
            this.lblWinDir.AutoSize = true;
            this.lblWinDir.Location = new System.Drawing.Point(16, 211);
            this.lblWinDir.Name = "lblWinDir";
            this.lblWinDir.Size = new System.Drawing.Size(10, 13);
            this.lblWinDir.TabIndex = 129;
            this.lblWinDir.Text = "-";
            // 
            // lblComputerName
            // 
            this.lblComputerName.AutoSize = true;
            this.lblComputerName.Location = new System.Drawing.Point(16, 234);
            this.lblComputerName.Name = "lblComputerName";
            this.lblComputerName.Size = new System.Drawing.Size(10, 13);
            this.lblComputerName.TabIndex = 128;
            this.lblComputerName.Text = "-";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(16, 13);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(69, 13);
            this.label27.TabIndex = 126;
            this.label27.Text = "Admin Status";
            // 
            // lblAdminStatus
            // 
            this.lblAdminStatus.AutoSize = true;
            this.lblAdminStatus.Location = new System.Drawing.Point(117, 13);
            this.lblAdminStatus.Name = "lblAdminStatus";
            this.lblAdminStatus.Size = new System.Drawing.Size(10, 13);
            this.lblAdminStatus.TabIndex = 127;
            this.lblAdminStatus.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 113;
            this.label3.Text = "Current User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 112;
            this.label2.Text = "Disk Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 114;
            this.label4.Text = "Arch Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 115;
            this.label5.Text = "Processes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 116;
            this.label6.Text = "Free";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 117;
            this.label7.Text = "Size";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 118;
            this.label10.Text = "RAM";
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.Location = new System.Drawing.Point(117, 180);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(10, 13);
            this.lblRam.TabIndex = 125;
            this.lblRam.Text = "-";
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Location = new System.Drawing.Point(117, 158);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(10, 13);
            this.lblCurrentUser.TabIndex = 124;
            this.lblCurrentUser.Text = "-";
            // 
            // lblArch
            // 
            this.lblArch.AutoSize = true;
            this.lblArch.Location = new System.Drawing.Point(117, 109);
            this.lblArch.Name = "lblArch";
            this.lblArch.Size = new System.Drawing.Size(10, 13);
            this.lblArch.TabIndex = 123;
            this.lblArch.Text = "-";
            // 
            // lblProcCount
            // 
            this.lblProcCount.AutoSize = true;
            this.lblProcCount.Location = new System.Drawing.Point(117, 133);
            this.lblProcCount.Name = "lblProcCount";
            this.lblProcCount.Size = new System.Drawing.Size(10, 13);
            this.lblProcCount.TabIndex = 122;
            this.lblProcCount.Text = "-";
            // 
            // lblDiskFree
            // 
            this.lblDiskFree.AutoSize = true;
            this.lblDiskFree.Location = new System.Drawing.Point(117, 86);
            this.lblDiskFree.Name = "lblDiskFree";
            this.lblDiskFree.Size = new System.Drawing.Size(10, 13);
            this.lblDiskFree.TabIndex = 121;
            this.lblDiskFree.Text = "-";
            // 
            // lblDiskSize
            // 
            this.lblDiskSize.AutoSize = true;
            this.lblDiskSize.Location = new System.Drawing.Point(117, 61);
            this.lblDiskSize.Name = "lblDiskSize";
            this.lblDiskSize.Size = new System.Drawing.Size(10, 13);
            this.lblDiskSize.TabIndex = 120;
            this.lblDiskSize.Text = "-";
            // 
            // lblDiskName
            // 
            this.lblDiskName.AutoSize = true;
            this.lblDiskName.Location = new System.Drawing.Point(117, 36);
            this.lblDiskName.Name = "lblDiskName";
            this.lblDiskName.Size = new System.Drawing.Size(10, 13);
            this.lblDiskName.TabIndex = 119;
            this.lblDiskName.Text = "-";
            // 
            // tabServices
            // 
            this.tabServices.BackColor = System.Drawing.SystemColors.Control;
            this.tabServices.Controls.Add(this.lblServiceStatus);
            this.tabServices.Controls.Add(this.label1);
            this.tabServices.Controls.Add(this.listServices);
            this.tabServices.Controls.Add(this.btnServiceStop);
            this.tabServices.Controls.Add(this.btnServiceStart);
            this.tabServices.Controls.Add(this.btnGetServices);
            this.tabServices.Location = new System.Drawing.Point(4, 22);
            this.tabServices.Name = "tabServices";
            this.tabServices.Padding = new System.Windows.Forms.Padding(3);
            this.tabServices.Size = new System.Drawing.Size(595, 343);
            this.tabServices.TabIndex = 1;
            this.tabServices.Text = "Services";
            // 
            // lblServiceStatus
            // 
            this.lblServiceStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblServiceStatus.AutoSize = true;
            this.lblServiceStatus.Location = new System.Drawing.Point(251, 319);
            this.lblServiceStatus.Name = "lblServiceStatus";
            this.lblServiceStatus.Size = new System.Drawing.Size(10, 13);
            this.lblServiceStatus.TabIndex = 5;
            this.lblServiceStatus.Text = "-";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status: ";
            // 
            // listServices
            // 
            this.listServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listServices.FormattingEnabled = true;
            this.listServices.Location = new System.Drawing.Point(6, 35);
            this.listServices.Name = "listServices";
            this.listServices.Size = new System.Drawing.Size(583, 264);
            this.listServices.Sorted = true;
            this.listServices.TabIndex = 3;
            this.listServices.SelectedIndexChanged += new System.EventHandler(this.listServices_SelectedIndexChanged);
            // 
            // btnServiceStop
            // 
            this.btnServiceStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnServiceStop.Location = new System.Drawing.Point(87, 314);
            this.btnServiceStop.Name = "btnServiceStop";
            this.btnServiceStop.Size = new System.Drawing.Size(75, 23);
            this.btnServiceStop.TabIndex = 2;
            this.btnServiceStop.Text = "Stop";
            this.btnServiceStop.UseVisualStyleBackColor = true;
            this.btnServiceStop.Click += new System.EventHandler(this.btnServiceStop_Click);
            // 
            // btnServiceStart
            // 
            this.btnServiceStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnServiceStart.Location = new System.Drawing.Point(6, 314);
            this.btnServiceStart.Name = "btnServiceStart";
            this.btnServiceStart.Size = new System.Drawing.Size(75, 23);
            this.btnServiceStart.TabIndex = 1;
            this.btnServiceStart.Text = "Start";
            this.btnServiceStart.UseVisualStyleBackColor = true;
            this.btnServiceStart.Click += new System.EventHandler(this.btnServiceStart_Click);
            // 
            // btnGetServices
            // 
            this.btnGetServices.Location = new System.Drawing.Point(6, 6);
            this.btnGetServices.Name = "btnGetServices";
            this.btnGetServices.Size = new System.Drawing.Size(95, 23);
            this.btnGetServices.TabIndex = 0;
            this.btnGetServices.Text = "Get Services";
            this.btnGetServices.UseVisualStyleBackColor = true;
            this.btnGetServices.Click += new System.EventHandler(this.btnGetServices_Click);
            // 
            // tabSoftware
            // 
            this.tabSoftware.BackColor = System.Drawing.SystemColors.Control;
            this.tabSoftware.Controls.Add(this.textBox1);
            this.tabSoftware.Controls.Add(this.listSoftware);
            this.tabSoftware.Controls.Add(this.btnSoftwareUninstall);
            this.tabSoftware.Controls.Add(this.btnGetSoftware);
            this.tabSoftware.Location = new System.Drawing.Point(4, 22);
            this.tabSoftware.Name = "tabSoftware";
            this.tabSoftware.Padding = new System.Windows.Forms.Padding(3);
            this.tabSoftware.Size = new System.Drawing.Size(595, 343);
            this.tabSoftware.TabIndex = 2;
            this.tabSoftware.Text = "Software";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Location = new System.Drawing.Point(87, 290);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(502, 47);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // listSoftware
            // 
            this.listSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listSoftware.FormattingEnabled = true;
            this.listSoftware.Location = new System.Drawing.Point(3, 35);
            this.listSoftware.Name = "listSoftware";
            this.listSoftware.Size = new System.Drawing.Size(586, 251);
            this.listSoftware.Sorted = true;
            this.listSoftware.TabIndex = 2;
            // 
            // btnSoftwareUninstall
            // 
            this.btnSoftwareUninstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSoftwareUninstall.Location = new System.Drawing.Point(6, 301);
            this.btnSoftwareUninstall.Name = "btnSoftwareUninstall";
            this.btnSoftwareUninstall.Size = new System.Drawing.Size(75, 23);
            this.btnSoftwareUninstall.TabIndex = 1;
            this.btnSoftwareUninstall.Text = "Uninstall";
            this.btnSoftwareUninstall.UseVisualStyleBackColor = true;
            this.btnSoftwareUninstall.Click += new System.EventHandler(this.btnSoftwareUninstall_Click);
            // 
            // btnGetSoftware
            // 
            this.btnGetSoftware.Location = new System.Drawing.Point(6, 6);
            this.btnGetSoftware.Name = "btnGetSoftware";
            this.btnGetSoftware.Size = new System.Drawing.Size(95, 23);
            this.btnGetSoftware.TabIndex = 0;
            this.btnGetSoftware.Text = "Get Software";
            this.btnGetSoftware.UseVisualStyleBackColor = true;
            this.btnGetSoftware.Click += new System.EventHandler(this.btnGetSoftware_Click);
            // 
            // tabPrinters
            // 
            this.tabPrinters.BackColor = System.Drawing.SystemColors.Control;
            this.tabPrinters.Controls.Add(this.btnUninstallPrinter);
            this.tabPrinters.Controls.Add(this.btnGetPrinters);
            this.tabPrinters.Controls.Add(this.listPrinters);
            this.tabPrinters.Location = new System.Drawing.Point(4, 22);
            this.tabPrinters.Name = "tabPrinters";
            this.tabPrinters.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrinters.Size = new System.Drawing.Size(595, 343);
            this.tabPrinters.TabIndex = 3;
            this.tabPrinters.Text = "Printers";
            // 
            // btnUninstallPrinter
            // 
            this.btnUninstallPrinter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUninstallPrinter.Location = new System.Drawing.Point(6, 314);
            this.btnUninstallPrinter.Name = "btnUninstallPrinter";
            this.btnUninstallPrinter.Size = new System.Drawing.Size(75, 23);
            this.btnUninstallPrinter.TabIndex = 2;
            this.btnUninstallPrinter.Text = "Uninstall";
            this.btnUninstallPrinter.UseVisualStyleBackColor = true;
            this.btnUninstallPrinter.Click += new System.EventHandler(this.btnUninstallPrinter_Click);
            // 
            // btnGetPrinters
            // 
            this.btnGetPrinters.Location = new System.Drawing.Point(6, 6);
            this.btnGetPrinters.Name = "btnGetPrinters";
            this.btnGetPrinters.Size = new System.Drawing.Size(85, 23);
            this.btnGetPrinters.TabIndex = 1;
            this.btnGetPrinters.Text = "Get Printers";
            this.btnGetPrinters.UseVisualStyleBackColor = true;
            this.btnGetPrinters.Click += new System.EventHandler(this.btnGetPrinters_Click);
            // 
            // listPrinters
            // 
            this.listPrinters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listPrinters.FormattingEnabled = true;
            this.listPrinters.Location = new System.Drawing.Point(6, 35);
            this.listPrinters.Name = "listPrinters";
            this.listPrinters.Size = new System.Drawing.Size(583, 264);
            this.listPrinters.Sorted = true;
            this.listPrinters.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 446);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblComputerConn);
            this.Controls.Add(this.txtCompName);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(643, 485);
            this.Name = "Main";
            this.Text = "Remote Administration";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabSysInfo.ResumeLayout(false);
            this.tabSysInfo.PerformLayout();
            this.tabServices.ResumeLayout(false);
            this.tabServices.PerformLayout();
            this.tabSoftware.ResumeLayout(false);
            this.tabSoftware.PerformLayout();
            this.tabPrinters.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblComputerConn;
        private System.Windows.Forms.TextBox txtCompName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSysInfo;
        private System.Windows.Forms.TabPage tabServices;
        private System.Windows.Forms.TabPage tabSoftware;
        private System.Windows.Forms.TabPage tabPrinters;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblAdminStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Label lblArch;
        private System.Windows.Forms.Label lblProcCount;
        private System.Windows.Forms.Label lblDiskFree;
        private System.Windows.Forms.Label lblDiskSize;
        private System.Windows.Forms.Label lblDiskName;
        private System.Windows.Forms.Label lblVer;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Label lblWinDir;
        private System.Windows.Forms.Label lblComputerName;
        private System.Windows.Forms.Button btnGetServices;
        private System.Windows.Forms.Button btnServiceStart;
        private System.Windows.Forms.ListBox listServices;
        private System.Windows.Forms.Button btnServiceStop;
        private System.Windows.Forms.Label lblServiceStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetSoftware;
        private System.Windows.Forms.Button btnSoftwareUninstall;
        private System.Windows.Forms.ListBox listSoftware;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listPrinters;
        private System.Windows.Forms.Button btnGetPrinters;
        private System.Windows.Forms.Button btnUninstallPrinter;
    }
}