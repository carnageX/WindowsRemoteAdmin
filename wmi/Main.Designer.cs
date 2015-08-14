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
            this.lblServp = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listSoftware = new System.Windows.Forms.ListBox();
            this.btnSoftwareUninstall = new System.Windows.Forms.Button();
            this.btnGetSoftware = new System.Windows.Forms.Button();
            this.tabPrinters = new System.Windows.Forms.TabPage();
            this.btnUninstallPrinter = new System.Windows.Forms.Button();
            this.btnGetPrinters = new System.Windows.Forms.Button();
            this.listPrinters = new System.Windows.Forms.ListBox();
            this.tabDisks = new System.Windows.Forms.TabPage();
            this.lblDriveDeviceId = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDrivePartitionCount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblDriveModel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDriveSize = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGetDrives = new System.Windows.Forms.Button();
            this.listDrives = new System.Windows.Forms.ListBox();
            this.tabLocalAccounts = new System.Windows.Forms.TabPage();
            this.groupLocalAccountInfo = new System.Windows.Forms.GroupBox();
            this.lblAccountLockoutStatus = new System.Windows.Forms.Label();
            this.lblAccountPassRequired = new System.Windows.Forms.Label();
            this.lblAccountPassExpires = new System.Windows.Forms.Label();
            this.lblAccountPassChangeable = new System.Windows.Forms.Label();
            this.lblAccountPassDisabled = new System.Windows.Forms.Label();
            this.lblAccountCaption = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.listLocalAccounts = new System.Windows.Forms.ListBox();
            this.btnGetLocalAccounts = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabSysInfo.SuspendLayout();
            this.tabServices.SuspendLayout();
            this.tabSoftware.SuspendLayout();
            this.tabPrinters.SuspendLayout();
            this.tabDisks.SuspendLayout();
            this.tabLocalAccounts.SuspendLayout();
            this.groupLocalAccountInfo.SuspendLayout();
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
            this.tabControl.Controls.Add(this.tabDisks);
            this.tabControl.Controls.Add(this.tabLocalAccounts);
            this.tabControl.Location = new System.Drawing.Point(12, 80);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(603, 354);
            this.tabControl.TabIndex = 119;
            // 
            // tabSysInfo
            // 
            this.tabSysInfo.BackColor = System.Drawing.SystemColors.Control;
            this.tabSysInfo.Controls.Add(this.lblServp);
            this.tabSysInfo.Controls.Add(this.label15);
            this.tabSysInfo.Controls.Add(this.label26);
            this.tabSysInfo.Controls.Add(this.label25);
            this.tabSysInfo.Controls.Add(this.label24);
            this.tabSysInfo.Controls.Add(this.label23);
            this.tabSysInfo.Controls.Add(this.label21);
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
            this.tabSysInfo.Size = new System.Drawing.Size(595, 328);
            this.tabSysInfo.TabIndex = 0;
            this.tabSysInfo.Text = "System Info";
            // 
            // lblServp
            // 
            this.lblServp.AutoSize = true;
            this.lblServp.Location = new System.Drawing.Point(117, 259);
            this.lblServp.Name = "lblServp";
            this.lblServp.Size = new System.Drawing.Size(10, 13);
            this.lblServp.TabIndex = 140;
            this.lblServp.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 259);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 139;
            this.label15.Text = "Service Pack";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(16, 303);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(70, 13);
            this.label26.TabIndex = 138;
            this.label26.Text = "Manufacturer";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(16, 281);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(42, 13);
            this.label25.TabIndex = 137;
            this.label25.Text = "Version";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(16, 237);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(22, 13);
            this.label24.TabIndex = 136;
            this.label24.Text = "OS";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(16, 13);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 13);
            this.label23.TabIndex = 135;
            this.label23.Text = "Host Name";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(16, 215);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 13);
            this.label21.TabIndex = 134;
            this.label21.Text = "Windows Dir";
            // 
            // lblVer
            // 
            this.lblVer.AutoSize = true;
            this.lblVer.Location = new System.Drawing.Point(117, 281);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(10, 13);
            this.lblVer.TabIndex = 132;
            this.lblVer.Text = "-";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(117, 303);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(10, 13);
            this.lblManufacturer.TabIndex = 131;
            this.lblManufacturer.Text = "-";
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Location = new System.Drawing.Point(117, 237);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(10, 13);
            this.lblCaption.TabIndex = 130;
            this.lblCaption.Text = "-";
            // 
            // lblWinDir
            // 
            this.lblWinDir.AutoSize = true;
            this.lblWinDir.Location = new System.Drawing.Point(117, 215);
            this.lblWinDir.Name = "lblWinDir";
            this.lblWinDir.Size = new System.Drawing.Size(10, 13);
            this.lblWinDir.TabIndex = 129;
            this.lblWinDir.Text = "-";
            // 
            // lblComputerName
            // 
            this.lblComputerName.AutoSize = true;
            this.lblComputerName.Location = new System.Drawing.Point(117, 13);
            this.lblComputerName.Name = "lblComputerName";
            this.lblComputerName.Size = new System.Drawing.Size(10, 13);
            this.lblComputerName.TabIndex = 128;
            this.lblComputerName.Text = "-";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(16, 36);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(69, 13);
            this.label27.TabIndex = 126;
            this.label27.Text = "Admin Status";
            // 
            // lblAdminStatus
            // 
            this.lblAdminStatus.AutoSize = true;
            this.lblAdminStatus.Location = new System.Drawing.Point(117, 36);
            this.lblAdminStatus.Name = "lblAdminStatus";
            this.lblAdminStatus.Size = new System.Drawing.Size(10, 13);
            this.lblAdminStatus.TabIndex = 127;
            this.lblAdminStatus.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 113;
            this.label3.Text = "Current User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 112;
            this.label2.Text = "Disk Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 114;
            this.label4.Text = "Arch Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 115;
            this.label5.Text = "Processes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 116;
            this.label6.Text = "Free";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 117;
            this.label7.Text = "Size";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 118;
            this.label10.Text = "RAM";
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.Location = new System.Drawing.Point(117, 192);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(10, 13);
            this.lblRam.TabIndex = 125;
            this.lblRam.Text = "-";
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Location = new System.Drawing.Point(117, 169);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(10, 13);
            this.lblCurrentUser.TabIndex = 124;
            this.lblCurrentUser.Text = "-";
            // 
            // lblArch
            // 
            this.lblArch.AutoSize = true;
            this.lblArch.Location = new System.Drawing.Point(117, 124);
            this.lblArch.Name = "lblArch";
            this.lblArch.Size = new System.Drawing.Size(10, 13);
            this.lblArch.TabIndex = 123;
            this.lblArch.Text = "-";
            // 
            // lblProcCount
            // 
            this.lblProcCount.AutoSize = true;
            this.lblProcCount.Location = new System.Drawing.Point(117, 146);
            this.lblProcCount.Name = "lblProcCount";
            this.lblProcCount.Size = new System.Drawing.Size(10, 13);
            this.lblProcCount.TabIndex = 122;
            this.lblProcCount.Text = "-";
            // 
            // lblDiskFree
            // 
            this.lblDiskFree.AutoSize = true;
            this.lblDiskFree.Location = new System.Drawing.Point(117, 102);
            this.lblDiskFree.Name = "lblDiskFree";
            this.lblDiskFree.Size = new System.Drawing.Size(10, 13);
            this.lblDiskFree.TabIndex = 121;
            this.lblDiskFree.Text = "-";
            // 
            // lblDiskSize
            // 
            this.lblDiskSize.AutoSize = true;
            this.lblDiskSize.Location = new System.Drawing.Point(117, 80);
            this.lblDiskSize.Name = "lblDiskSize";
            this.lblDiskSize.Size = new System.Drawing.Size(10, 13);
            this.lblDiskSize.TabIndex = 120;
            this.lblDiskSize.Text = "-";
            // 
            // lblDiskName
            // 
            this.lblDiskName.AutoSize = true;
            this.lblDiskName.Location = new System.Drawing.Point(117, 58);
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
            this.tabServices.Size = new System.Drawing.Size(595, 328);
            this.tabServices.TabIndex = 1;
            this.tabServices.Text = "Services";
            // 
            // lblServiceStatus
            // 
            this.lblServiceStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblServiceStatus.AutoSize = true;
            this.lblServiceStatus.Location = new System.Drawing.Point(251, 304);
            this.lblServiceStatus.Name = "lblServiceStatus";
            this.lblServiceStatus.Size = new System.Drawing.Size(10, 13);
            this.lblServiceStatus.TabIndex = 5;
            this.lblServiceStatus.Text = "-";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 304);
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
            this.listServices.Size = new System.Drawing.Size(583, 251);
            this.listServices.Sorted = true;
            this.listServices.TabIndex = 3;
            this.listServices.SelectedIndexChanged += new System.EventHandler(this.listServices_SelectedIndexChanged);
            // 
            // btnServiceStop
            // 
            this.btnServiceStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnServiceStop.Location = new System.Drawing.Point(87, 299);
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
            this.btnServiceStart.Location = new System.Drawing.Point(6, 299);
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
            this.tabSoftware.Controls.Add(this.textBox2);
            this.tabSoftware.Controls.Add(this.textBox1);
            this.tabSoftware.Controls.Add(this.listSoftware);
            this.tabSoftware.Controls.Add(this.btnSoftwareUninstall);
            this.tabSoftware.Controls.Add(this.btnGetSoftware);
            this.tabSoftware.Location = new System.Drawing.Point(4, 22);
            this.tabSoftware.Name = "tabSoftware";
            this.tabSoftware.Padding = new System.Windows.Forms.Padding(3);
            this.tabSoftware.Size = new System.Drawing.Size(595, 328);
            this.tabSoftware.TabIndex = 2;
            this.tabSoftware.Text = "Software";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox2.ForeColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(107, 6);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(482, 33);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Note: This process may take several minutes to display installed software, and ma" +
    "y appear to be unresponsive. Please be patient.";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Location = new System.Drawing.Point(87, 281);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(502, 43);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // listSoftware
            // 
            this.listSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listSoftware.FormattingEnabled = true;
            this.listSoftware.Location = new System.Drawing.Point(3, 40);
            this.listSoftware.Name = "listSoftware";
            this.listSoftware.Size = new System.Drawing.Size(586, 238);
            this.listSoftware.Sorted = true;
            this.listSoftware.TabIndex = 2;
            // 
            // btnSoftwareUninstall
            // 
            this.btnSoftwareUninstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSoftwareUninstall.Location = new System.Drawing.Point(6, 299);
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
            this.tabPrinters.Size = new System.Drawing.Size(595, 328);
            this.tabPrinters.TabIndex = 3;
            this.tabPrinters.Text = "Printers";
            // 
            // btnUninstallPrinter
            // 
            this.btnUninstallPrinter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUninstallPrinter.Location = new System.Drawing.Point(6, 302);
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
            this.listPrinters.Size = new System.Drawing.Size(583, 251);
            this.listPrinters.Sorted = true;
            this.listPrinters.TabIndex = 0;
            // 
            // tabDisks
            // 
            this.tabDisks.BackColor = System.Drawing.SystemColors.Control;
            this.tabDisks.Controls.Add(this.lblDriveDeviceId);
            this.tabDisks.Controls.Add(this.label9);
            this.tabDisks.Controls.Add(this.lblDrivePartitionCount);
            this.tabDisks.Controls.Add(this.label13);
            this.tabDisks.Controls.Add(this.lblDriveModel);
            this.tabDisks.Controls.Add(this.label11);
            this.tabDisks.Controls.Add(this.lblDriveSize);
            this.tabDisks.Controls.Add(this.label8);
            this.tabDisks.Controls.Add(this.btnGetDrives);
            this.tabDisks.Controls.Add(this.listDrives);
            this.tabDisks.Location = new System.Drawing.Point(4, 22);
            this.tabDisks.Name = "tabDisks";
            this.tabDisks.Padding = new System.Windows.Forms.Padding(3);
            this.tabDisks.Size = new System.Drawing.Size(595, 328);
            this.tabDisks.TabIndex = 4;
            this.tabDisks.Text = "Drives";
            // 
            // lblDriveDeviceId
            // 
            this.lblDriveDeviceId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDriveDeviceId.AutoSize = true;
            this.lblDriveDeviceId.Location = new System.Drawing.Point(91, 313);
            this.lblDriveDeviceId.Name = "lblDriveDeviceId";
            this.lblDriveDeviceId.Size = new System.Drawing.Size(10, 13);
            this.lblDriveDeviceId.TabIndex = 10;
            this.lblDriveDeviceId.Text = "-";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Device ID: ";
            // 
            // lblDrivePartitionCount
            // 
            this.lblDrivePartitionCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDrivePartitionCount.AutoSize = true;
            this.lblDrivePartitionCount.Location = new System.Drawing.Point(91, 268);
            this.lblDrivePartitionCount.Name = "lblDrivePartitionCount";
            this.lblDrivePartitionCount.Size = new System.Drawing.Size(10, 13);
            this.lblDrivePartitionCount.TabIndex = 8;
            this.lblDrivePartitionCount.Text = "-";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 268);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Partition Count: ";
            // 
            // lblDriveModel
            // 
            this.lblDriveModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDriveModel.AutoSize = true;
            this.lblDriveModel.Location = new System.Drawing.Point(91, 246);
            this.lblDriveModel.Name = "lblDriveModel";
            this.lblDriveModel.Size = new System.Drawing.Size(10, 13);
            this.lblDriveModel.TabIndex = 6;
            this.lblDriveModel.Text = "-";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Model: ";
            // 
            // lblDriveSize
            // 
            this.lblDriveSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDriveSize.AutoSize = true;
            this.lblDriveSize.Location = new System.Drawing.Point(91, 291);
            this.lblDriveSize.Name = "lblDriveSize";
            this.lblDriveSize.Size = new System.Drawing.Size(10, 13);
            this.lblDriveSize.TabIndex = 4;
            this.lblDriveSize.Text = "-";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Size: ";
            // 
            // btnGetDrives
            // 
            this.btnGetDrives.Location = new System.Drawing.Point(6, 6);
            this.btnGetDrives.Name = "btnGetDrives";
            this.btnGetDrives.Size = new System.Drawing.Size(85, 23);
            this.btnGetDrives.TabIndex = 2;
            this.btnGetDrives.Text = "Get Drives";
            this.btnGetDrives.UseVisualStyleBackColor = true;
            this.btnGetDrives.Click += new System.EventHandler(this.btnGetDisks_Click);
            // 
            // listDrives
            // 
            this.listDrives.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listDrives.FormattingEnabled = true;
            this.listDrives.Location = new System.Drawing.Point(6, 35);
            this.listDrives.Name = "listDrives";
            this.listDrives.Size = new System.Drawing.Size(583, 199);
            this.listDrives.Sorted = true;
            this.listDrives.TabIndex = 1;
            this.listDrives.SelectedIndexChanged += new System.EventHandler(this.listDrives_SelectedIndexChanged);
            // 
            // tabLocalAccounts
            // 
            this.tabLocalAccounts.BackColor = System.Drawing.SystemColors.Control;
            this.tabLocalAccounts.Controls.Add(this.groupLocalAccountInfo);
            this.tabLocalAccounts.Controls.Add(this.listLocalAccounts);
            this.tabLocalAccounts.Controls.Add(this.btnGetLocalAccounts);
            this.tabLocalAccounts.Location = new System.Drawing.Point(4, 22);
            this.tabLocalAccounts.Name = "tabLocalAccounts";
            this.tabLocalAccounts.Padding = new System.Windows.Forms.Padding(3);
            this.tabLocalAccounts.Size = new System.Drawing.Size(595, 328);
            this.tabLocalAccounts.TabIndex = 5;
            this.tabLocalAccounts.Text = "Local Accounts";
            // 
            // groupLocalAccountInfo
            // 
            this.groupLocalAccountInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupLocalAccountInfo.Controls.Add(this.lblAccountLockoutStatus);
            this.groupLocalAccountInfo.Controls.Add(this.lblAccountPassRequired);
            this.groupLocalAccountInfo.Controls.Add(this.lblAccountPassExpires);
            this.groupLocalAccountInfo.Controls.Add(this.lblAccountPassChangeable);
            this.groupLocalAccountInfo.Controls.Add(this.lblAccountPassDisabled);
            this.groupLocalAccountInfo.Controls.Add(this.lblAccountCaption);
            this.groupLocalAccountInfo.Controls.Add(this.label20);
            this.groupLocalAccountInfo.Controls.Add(this.label19);
            this.groupLocalAccountInfo.Controls.Add(this.label18);
            this.groupLocalAccountInfo.Controls.Add(this.label17);
            this.groupLocalAccountInfo.Controls.Add(this.label22);
            this.groupLocalAccountInfo.Controls.Add(this.label16);
            this.groupLocalAccountInfo.Location = new System.Drawing.Point(6, 177);
            this.groupLocalAccountInfo.Name = "groupLocalAccountInfo";
            this.groupLocalAccountInfo.Size = new System.Drawing.Size(583, 145);
            this.groupLocalAccountInfo.TabIndex = 2;
            this.groupLocalAccountInfo.TabStop = false;
            this.groupLocalAccountInfo.Text = "Account Details";
            // 
            // lblAccountLockoutStatus
            // 
            this.lblAccountLockoutStatus.AutoSize = true;
            this.lblAccountLockoutStatus.Location = new System.Drawing.Point(125, 38);
            this.lblAccountLockoutStatus.Name = "lblAccountLockoutStatus";
            this.lblAccountLockoutStatus.Size = new System.Drawing.Size(10, 13);
            this.lblAccountLockoutStatus.TabIndex = 14;
            this.lblAccountLockoutStatus.Text = "-";
            // 
            // lblAccountPassRequired
            // 
            this.lblAccountPassRequired.AutoSize = true;
            this.lblAccountPassRequired.Location = new System.Drawing.Point(125, 129);
            this.lblAccountPassRequired.Name = "lblAccountPassRequired";
            this.lblAccountPassRequired.Size = new System.Drawing.Size(10, 13);
            this.lblAccountPassRequired.TabIndex = 13;
            this.lblAccountPassRequired.Text = "-";
            // 
            // lblAccountPassExpires
            // 
            this.lblAccountPassExpires.AutoSize = true;
            this.lblAccountPassExpires.Location = new System.Drawing.Point(125, 106);
            this.lblAccountPassExpires.Name = "lblAccountPassExpires";
            this.lblAccountPassExpires.Size = new System.Drawing.Size(10, 13);
            this.lblAccountPassExpires.TabIndex = 12;
            this.lblAccountPassExpires.Text = "-";
            // 
            // lblAccountPassChangeable
            // 
            this.lblAccountPassChangeable.AutoSize = true;
            this.lblAccountPassChangeable.Location = new System.Drawing.Point(125, 84);
            this.lblAccountPassChangeable.Name = "lblAccountPassChangeable";
            this.lblAccountPassChangeable.Size = new System.Drawing.Size(10, 13);
            this.lblAccountPassChangeable.TabIndex = 11;
            this.lblAccountPassChangeable.Text = "-";
            // 
            // lblAccountPassDisabled
            // 
            this.lblAccountPassDisabled.AutoSize = true;
            this.lblAccountPassDisabled.Location = new System.Drawing.Point(125, 62);
            this.lblAccountPassDisabled.Name = "lblAccountPassDisabled";
            this.lblAccountPassDisabled.Size = new System.Drawing.Size(10, 13);
            this.lblAccountPassDisabled.TabIndex = 10;
            this.lblAccountPassDisabled.Text = "-";
            // 
            // lblAccountCaption
            // 
            this.lblAccountCaption.AutoSize = true;
            this.lblAccountCaption.Location = new System.Drawing.Point(125, 16);
            this.lblAccountCaption.Name = "lblAccountCaption";
            this.lblAccountCaption.Size = new System.Drawing.Size(10, 13);
            this.lblAccountCaption.TabIndex = 9;
            this.lblAccountCaption.Text = "-";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 38);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "Lockout Status";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 129);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 13);
            this.label19.TabIndex = 7;
            this.label19.Text = "Password Required";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 106);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Password Expires";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 84);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "Password Changeable";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 62);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(97, 13);
            this.label22.TabIndex = 3;
            this.label22.Text = "Password Disabled";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Full Name";
            // 
            // listLocalAccounts
            // 
            this.listLocalAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listLocalAccounts.FormattingEnabled = true;
            this.listLocalAccounts.Location = new System.Drawing.Point(6, 39);
            this.listLocalAccounts.Name = "listLocalAccounts";
            this.listLocalAccounts.Size = new System.Drawing.Size(583, 134);
            this.listLocalAccounts.Sorted = true;
            this.listLocalAccounts.TabIndex = 1;
            this.listLocalAccounts.SelectedIndexChanged += new System.EventHandler(this.listLocalAccounts_SelectedIndexChanged);
            // 
            // btnGetLocalAccounts
            // 
            this.btnGetLocalAccounts.Location = new System.Drawing.Point(6, 6);
            this.btnGetLocalAccounts.Name = "btnGetLocalAccounts";
            this.btnGetLocalAccounts.Size = new System.Drawing.Size(139, 27);
            this.btnGetLocalAccounts.TabIndex = 0;
            this.btnGetLocalAccounts.Text = "Get Local Accounts";
            this.btnGetLocalAccounts.UseVisualStyleBackColor = true;
            this.btnGetLocalAccounts.Click += new System.EventHandler(this.btnGetLocalAccounts_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(447, 39);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(168, 20);
            this.txtUserName.TabIndex = 133;
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(447, 65);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(168, 20);
            this.txtPassword.TabIndex = 134;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(379, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 135;
            this.label12.Text = "Password";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(379, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 136;
            this.label14.Text = "User Name";
            // 
            // Main
            // 
            this.AcceptButton = this.btnConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 447);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
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
            this.tabDisks.ResumeLayout(false);
            this.tabDisks.PerformLayout();
            this.tabLocalAccounts.ResumeLayout(false);
            this.groupLocalAccountInfo.ResumeLayout(false);
            this.groupLocalAccountInfo.PerformLayout();
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
        private System.Windows.Forms.TabPage tabDisks;
        private System.Windows.Forms.Button btnGetDrives;
        private System.Windows.Forms.ListBox listDrives;
        private System.Windows.Forms.Label lblDriveSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDrivePartitionCount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblDriveModel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDriveDeviceId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabLocalAccounts;
        private System.Windows.Forms.GroupBox groupLocalAccountInfo;
        private System.Windows.Forms.ListBox listLocalAccounts;
        private System.Windows.Forms.Button btnGetLocalAccounts;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblAccountLockoutStatus;
        private System.Windows.Forms.Label lblAccountPassRequired;
        private System.Windows.Forms.Label lblAccountPassExpires;
        private System.Windows.Forms.Label lblAccountPassChangeable;
        private System.Windows.Forms.Label lblAccountPassDisabled;
        private System.Windows.Forms.Label lblAccountCaption;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblServp;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox2;
    }
}