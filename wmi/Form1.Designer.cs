namespace wmi
//{
//    partial class Form1
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.label1 = new System.Windows.Forms.Label();
//            this.cmbHdd = new System.Windows.Forms.ComboBox();
//            this.label3 = new System.Windows.Forms.Label();
//            this.lblTracksPerCylinder = new System.Windows.Forms.Label();
//            this.lblSectorPerTrack = new System.Windows.Forms.Label();
//            this.label32 = new System.Windows.Forms.Label();
//            this.label31 = new System.Windows.Forms.Label();
//            this.lblTracks = new System.Windows.Forms.Label();
//            this.label17 = new System.Windows.Forms.Label();
//            this.label2 = new System.Windows.Forms.Label();
//            this.label16 = new System.Windows.Forms.Label();
//            this.lblHeads = new System.Windows.Forms.Label();
//            this.label4 = new System.Windows.Forms.Label();
//            this.label5 = new System.Windows.Forms.Label();
//            this.label6 = new System.Windows.Forms.Label();
//            this.lblBytesPerSector = new System.Windows.Forms.Label();
//            this.label7 = new System.Windows.Forms.Label();
//            this.lblSectors = new System.Windows.Forms.Label();
//            this.label8 = new System.Windows.Forms.Label();
//            this.lblFirmware = new System.Windows.Forms.Label();
//            this.label9 = new System.Windows.Forms.Label();
//            this.lblCylinders = new System.Windows.Forms.Label();
//            this.label10 = new System.Windows.Forms.Label();
//            this.lblSignature = new System.Windows.Forms.Label();
//            this.label12 = new System.Windows.Forms.Label();
//            this.lblPartitions = new System.Windows.Forms.Label();
//            this.label13 = new System.Windows.Forms.Label();
//            this.lblCapacity = new System.Windows.Forms.Label();
//            this.label14 = new System.Windows.Forms.Label();
//            this.lblInterface = new System.Windows.Forms.Label();
//            this.label15 = new System.Windows.Forms.Label();
//            this.lblSerial = new System.Windows.Forms.Label();
//            this.label11 = new System.Windows.Forms.Label();
//            this.lblModel = new System.Windows.Forms.Label();
//            this.label18 = new System.Windows.Forms.Label();
//            this.lblType = new System.Windows.Forms.Label();
//            this.label19 = new System.Windows.Forms.Label();
//            this.label20 = new System.Windows.Forms.Label();
//            this.label21 = new System.Windows.Forms.Label();
//            this.label30 = new System.Windows.Forms.Label();
//            this.label22 = new System.Windows.Forms.Label();
//            this.label29 = new System.Windows.Forms.Label();
//            this.label23 = new System.Windows.Forms.Label();
//            this.label28 = new System.Windows.Forms.Label();
//            this.label24 = new System.Windows.Forms.Label();
//            this.label26 = new System.Windows.Forms.Label();
//            this.label25 = new System.Windows.Forms.Label();
//            this.SuspendLayout();
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.Location = new System.Drawing.Point(174, 9);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(79, 13);
//            this.label1.TabIndex = 0;
//            this.label1.Text = "select the drive";
//            // 
//            // cmbHdd
//            // 
//            this.cmbHdd.FormattingEnabled = true;
//            this.cmbHdd.Location = new System.Drawing.Point(67, 25);
//            this.cmbHdd.Name = "cmbHdd";
//            this.cmbHdd.Size = new System.Drawing.Size(372, 21);
//            this.cmbHdd.TabIndex = 1;
//            // 
//            // label3
//            // 
//            this.label3.AutoSize = true;
//            this.label3.Location = new System.Drawing.Point(118, 247);
//            this.label3.Name = "label3";
//            this.label3.Size = new System.Drawing.Size(50, 13);
//            this.label3.TabIndex = 110;
//            this.label3.Text = "Partitions";
//            // 
//            // lblTracksPerCylinder
//            // 
//            this.lblTracksPerCylinder.AutoSize = true;
//            this.lblTracksPerCylinder.Location = new System.Drawing.Point(239, 466);
//            this.lblTracksPerCylinder.Name = "lblTracksPerCylinder";
//            this.lblTracksPerCylinder.Size = new System.Drawing.Size(10, 13);
//            this.lblTracksPerCylinder.TabIndex = 151;
//            this.lblTracksPerCylinder.Text = "-";
//            // 
//            // lblSectorPerTrack
//            // 
//            this.lblSectorPerTrack.AutoSize = true;
//            this.lblSectorPerTrack.Location = new System.Drawing.Point(239, 443);
//            this.lblSectorPerTrack.Name = "lblSectorPerTrack";
//            this.lblSectorPerTrack.Size = new System.Drawing.Size(10, 13);
//            this.lblSectorPerTrack.TabIndex = 150;
//            this.lblSectorPerTrack.Text = "-";
//            // 
//            // label32
//            // 
//            this.label32.AutoSize = true;
//            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label32.Location = new System.Drawing.Point(222, 443);
//            this.label32.Name = "label32";
//            this.label32.Size = new System.Drawing.Size(11, 13);
//            this.label32.TabIndex = 138;
//            this.label32.Text = ":";
//            // 
//            // label31
//            // 
//            this.label31.AutoSize = true;
//            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label31.Location = new System.Drawing.Point(222, 466);
//            this.label31.Name = "label31";
//            this.label31.Size = new System.Drawing.Size(11, 13);
//            this.label31.TabIndex = 137;
//            this.label31.Text = ":";
//            // 
//            // lblTracks
//            // 
//            this.lblTracks.AutoSize = true;
//            this.lblTracks.Location = new System.Drawing.Point(382, 366);
//            this.lblTracks.Name = "lblTracks";
//            this.lblTracks.Size = new System.Drawing.Size(10, 13);
//            this.lblTracks.TabIndex = 153;
//            this.lblTracks.Text = "-";
//            // 
//            // label17
//            // 
//            this.label17.AutoSize = true;
//            this.label17.Location = new System.Drawing.Point(117, 443);
//            this.label17.Name = "label17";
//            this.label17.Size = new System.Drawing.Size(93, 13);
//            this.label17.TabIndex = 123;
//            this.label17.Text = "Sectors Per Track";
//            // 
//            // label2
//            // 
//            this.label2.AutoSize = true;
//            this.label2.Location = new System.Drawing.Point(118, 126);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(31, 13);
//            this.label2.TabIndex = 109;
//            this.label2.Text = "Type";
//            // 
//            // label16
//            // 
//            this.label16.AutoSize = true;
//            this.label16.Location = new System.Drawing.Point(117, 466);
//            this.label16.Name = "label16";
//            this.label16.Size = new System.Drawing.Size(99, 13);
//            this.label16.TabIndex = 122;
//            this.label16.Text = "Tracks Per Cylinder";
//            // 
//            // lblHeads
//            // 
//            this.lblHeads.AutoSize = true;
//            this.lblHeads.Location = new System.Drawing.Point(382, 343);
//            this.lblHeads.Name = "lblHeads";
//            this.lblHeads.Size = new System.Drawing.Size(10, 13);
//            this.lblHeads.TabIndex = 152;
//            this.lblHeads.Text = "-";
//            // 
//            // label4
//            // 
//            this.label4.AutoSize = true;
//            this.label4.Location = new System.Drawing.Point(118, 223);
//            this.label4.Name = "label4";
//            this.label4.Size = new System.Drawing.Size(48, 13);
//            this.label4.TabIndex = 111;
//            this.label4.Text = "Capacity";
//            // 
//            // label5
//            // 
//            this.label5.AutoSize = true;
//            this.label5.Location = new System.Drawing.Point(118, 198);
//            this.label5.Name = "label5";
//            this.label5.Size = new System.Drawing.Size(49, 13);
//            this.label5.TabIndex = 112;
//            this.label5.Text = "Interface";
//            // 
//            // label6
//            // 
//            this.label6.AutoSize = true;
//            this.label6.Location = new System.Drawing.Point(118, 175);
//            this.label6.Name = "label6";
//            this.label6.Size = new System.Drawing.Size(43, 13);
//            this.label6.TabIndex = 113;
//            this.label6.Text = "Serial #";
//            // 
//            // lblBytesPerSector
//            // 
//            this.lblBytesPerSector.AutoSize = true;
//            this.lblBytesPerSector.Location = new System.Drawing.Point(239, 414);
//            this.lblBytesPerSector.Name = "lblBytesPerSector";
//            this.lblBytesPerSector.Size = new System.Drawing.Size(10, 13);
//            this.lblBytesPerSector.TabIndex = 149;
//            this.lblBytesPerSector.Text = "-";
//            // 
//            // label7
//            // 
//            this.label7.AutoSize = true;
//            this.label7.Location = new System.Drawing.Point(118, 150);
//            this.label7.Name = "label7";
//            this.label7.Size = new System.Drawing.Size(36, 13);
//            this.label7.TabIndex = 114;
//            this.label7.Text = "Model";
//            // 
//            // lblSectors
//            // 
//            this.lblSectors.AutoSize = true;
//            this.lblSectors.Location = new System.Drawing.Point(193, 367);
//            this.lblSectors.Name = "lblSectors";
//            this.lblSectors.Size = new System.Drawing.Size(10, 13);
//            this.lblSectors.TabIndex = 148;
//            this.lblSectors.Text = "-";
//            // 
//            // label8
//            // 
//            this.label8.AutoSize = true;
//            this.label8.Location = new System.Drawing.Point(117, 343);
//            this.label8.Name = "label8";
//            this.label8.Size = new System.Drawing.Size(49, 13);
//            this.label8.TabIndex = 115;
//            this.label8.Text = "Cylinders";
//            // 
//            // lblFirmware
//            // 
//            this.lblFirmware.AutoSize = true;
//            this.lblFirmware.Location = new System.Drawing.Point(193, 292);
//            this.lblFirmware.Name = "lblFirmware";
//            this.lblFirmware.Size = new System.Drawing.Size(10, 13);
//            this.lblFirmware.TabIndex = 147;
//            this.lblFirmware.Text = "-";
//            // 
//            // label9
//            // 
//            this.label9.AutoSize = true;
//            this.label9.Location = new System.Drawing.Point(118, 291);
//            this.label9.Name = "label9";
//            this.label9.Size = new System.Drawing.Size(49, 13);
//            this.label9.TabIndex = 116;
//            this.label9.Text = "Firmware";
//            // 
//            // lblCylinders
//            // 
//            this.lblCylinders.AutoSize = true;
//            this.lblCylinders.Location = new System.Drawing.Point(193, 343);
//            this.lblCylinders.Name = "lblCylinders";
//            this.lblCylinders.Size = new System.Drawing.Size(10, 13);
//            this.lblCylinders.TabIndex = 146;
//            this.lblCylinders.Text = "-";
//            // 
//            // label10
//            // 
//            this.label10.AutoSize = true;
//            this.label10.Location = new System.Drawing.Point(118, 269);
//            this.label10.Name = "label10";
//            this.label10.Size = new System.Drawing.Size(52, 13);
//            this.label10.TabIndex = 117;
//            this.label10.Text = "Signature";
//            // 
//            // lblSignature
//            // 
//            this.lblSignature.AutoSize = true;
//            this.lblSignature.Location = new System.Drawing.Point(193, 270);
//            this.lblSignature.Name = "lblSignature";
//            this.lblSignature.Size = new System.Drawing.Size(10, 13);
//            this.lblSignature.TabIndex = 145;
//            this.lblSignature.Text = "-";
//            // 
//            // label12
//            // 
//            this.label12.AutoSize = true;
//            this.label12.Location = new System.Drawing.Point(117, 414);
//            this.label12.Name = "label12";
//            this.label12.Size = new System.Drawing.Size(86, 13);
//            this.label12.TabIndex = 118;
//            this.label12.Text = "Bytes Per Sector";
//            // 
//            // lblPartitions
//            // 
//            this.lblPartitions.AutoSize = true;
//            this.lblPartitions.Location = new System.Drawing.Point(193, 248);
//            this.lblPartitions.Name = "lblPartitions";
//            this.lblPartitions.Size = new System.Drawing.Size(10, 13);
//            this.lblPartitions.TabIndex = 144;
//            this.lblPartitions.Text = "-";
//            // 
//            // label13
//            // 
//            this.label13.AutoSize = true;
//            this.label13.Location = new System.Drawing.Point(117, 366);
//            this.label13.Name = "label13";
//            this.label13.Size = new System.Drawing.Size(43, 13);
//            this.label13.TabIndex = 119;
//            this.label13.Text = "Sectors";
//            // 
//            // lblCapacity
//            // 
//            this.lblCapacity.AutoSize = true;
//            this.lblCapacity.Location = new System.Drawing.Point(193, 224);
//            this.lblCapacity.Name = "lblCapacity";
//            this.lblCapacity.Size = new System.Drawing.Size(10, 13);
//            this.lblCapacity.TabIndex = 143;
//            this.lblCapacity.Text = "-";
//            // 
//            // label14
//            // 
//            this.label14.AutoSize = true;
//            this.label14.Location = new System.Drawing.Point(321, 343);
//            this.label14.Name = "label14";
//            this.label14.Size = new System.Drawing.Size(38, 13);
//            this.label14.TabIndex = 120;
//            this.label14.Text = "Heads";
//            // 
//            // lblInterface
//            // 
//            this.lblInterface.AutoSize = true;
//            this.lblInterface.Location = new System.Drawing.Point(193, 199);
//            this.lblInterface.Name = "lblInterface";
//            this.lblInterface.Size = new System.Drawing.Size(10, 13);
//            this.lblInterface.TabIndex = 142;
//            this.lblInterface.Text = "-";
//            // 
//            // label15
//            // 
//            this.label15.AutoSize = true;
//            this.label15.Location = new System.Drawing.Point(321, 366);
//            this.label15.Name = "label15";
//            this.label15.Size = new System.Drawing.Size(40, 13);
//            this.label15.TabIndex = 121;
//            this.label15.Text = "Tracks";
//            // 
//            // lblSerial
//            // 
//            this.lblSerial.AutoSize = true;
//            this.lblSerial.Location = new System.Drawing.Point(193, 176);
//            this.lblSerial.Name = "lblSerial";
//            this.lblSerial.Size = new System.Drawing.Size(10, 13);
//            this.lblSerial.TabIndex = 141;
//            this.lblSerial.Text = "-";
//            // 
//            // label11
//            // 
//            this.label11.AutoSize = true;
//            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label11.Location = new System.Drawing.Point(173, 247);
//            this.label11.Name = "label11";
//            this.label11.Size = new System.Drawing.Size(11, 13);
//            this.label11.TabIndex = 124;
//            this.label11.Text = ":";
//            // 
//            // lblModel
//            // 
//            this.lblModel.AutoSize = true;
//            this.lblModel.Location = new System.Drawing.Point(193, 151);
//            this.lblModel.Name = "lblModel";
//            this.lblModel.Size = new System.Drawing.Size(10, 13);
//            this.lblModel.TabIndex = 140;
//            this.lblModel.Text = "-";
//            // 
//            // label18
//            // 
//            this.label18.AutoSize = true;
//            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label18.Location = new System.Drawing.Point(172, 223);
//            this.label18.Name = "label18";
//            this.label18.Size = new System.Drawing.Size(11, 13);
//            this.label18.TabIndex = 125;
//            this.label18.Text = ":";
//            // 
//            // lblType
//            // 
//            this.lblType.AutoSize = true;
//            this.lblType.Location = new System.Drawing.Point(193, 127);
//            this.lblType.Name = "lblType";
//            this.lblType.Size = new System.Drawing.Size(10, 13);
//            this.lblType.TabIndex = 139;
//            this.lblType.Text = "-";
//            // 
//            // label19
//            // 
//            this.label19.AutoSize = true;
//            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label19.Location = new System.Drawing.Point(172, 198);
//            this.label19.Name = "label19";
//            this.label19.Size = new System.Drawing.Size(11, 13);
//            this.label19.TabIndex = 126;
//            this.label19.Text = ":";
//            // 
//            // label20
//            // 
//            this.label20.AutoSize = true;
//            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label20.Location = new System.Drawing.Point(173, 175);
//            this.label20.Name = "label20";
//            this.label20.Size = new System.Drawing.Size(11, 13);
//            this.label20.TabIndex = 127;
//            this.label20.Text = ":";
//            // 
//            // label21
//            // 
//            this.label21.AutoSize = true;
//            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label21.Location = new System.Drawing.Point(173, 269);
//            this.label21.Name = "label21";
//            this.label21.Size = new System.Drawing.Size(11, 13);
//            this.label21.TabIndex = 128;
//            this.label21.Text = ":";
//            // 
//            // label30
//            // 
//            this.label30.AutoSize = true;
//            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label30.Location = new System.Drawing.Point(222, 414);
//            this.label30.Name = "label30";
//            this.label30.Size = new System.Drawing.Size(11, 13);
//            this.label30.TabIndex = 136;
//            this.label30.Text = ":";
//            // 
//            // label22
//            // 
//            this.label22.AutoSize = true;
//            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label22.Location = new System.Drawing.Point(173, 291);
//            this.label22.Name = "label22";
//            this.label22.Size = new System.Drawing.Size(11, 13);
//            this.label22.TabIndex = 129;
//            this.label22.Text = ":";
//            // 
//            // label29
//            // 
//            this.label29.AutoSize = true;
//            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label29.Location = new System.Drawing.Point(365, 343);
//            this.label29.Name = "label29";
//            this.label29.Size = new System.Drawing.Size(11, 13);
//            this.label29.TabIndex = 135;
//            this.label29.Text = ":";
//            // 
//            // label23
//            // 
//            this.label23.AutoSize = true;
//            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label23.Location = new System.Drawing.Point(173, 343);
//            this.label23.Name = "label23";
//            this.label23.Size = new System.Drawing.Size(11, 13);
//            this.label23.TabIndex = 130;
//            this.label23.Text = ":";
//            // 
//            // label28
//            // 
//            this.label28.AutoSize = true;
//            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label28.Location = new System.Drawing.Point(365, 366);
//            this.label28.Name = "label28";
//            this.label28.Size = new System.Drawing.Size(11, 13);
//            this.label28.TabIndex = 134;
//            this.label28.Text = ":";
//            // 
//            // label24
//            // 
//            this.label24.AutoSize = true;
//            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label24.Location = new System.Drawing.Point(172, 126);
//            this.label24.Name = "label24";
//            this.label24.Size = new System.Drawing.Size(11, 13);
//            this.label24.TabIndex = 131;
//            this.label24.Text = ":";
//            // 
//            // label26
//            // 
//            this.label26.AutoSize = true;
//            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label26.Location = new System.Drawing.Point(172, 366);
//            this.label26.Name = "label26";
//            this.label26.Size = new System.Drawing.Size(11, 13);
//            this.label26.TabIndex = 133;
//            this.label26.Text = ":";
//            // 
//            // label25
//            // 
//            this.label25.AutoSize = true;
//            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label25.Location = new System.Drawing.Point(172, 150);
//            this.label25.Name = "label25";
//            this.label25.Size = new System.Drawing.Size(11, 13);
//            this.label25.TabIndex = 132;
//            this.label25.Text = ":";
//            // 
//            // Form1
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(508, 605);
//            this.Controls.Add(this.label3);
//            this.Controls.Add(this.lblTracksPerCylinder);
//            this.Controls.Add(this.lblSectorPerTrack);
//            this.Controls.Add(this.label32);
//            this.Controls.Add(this.label31);
//            this.Controls.Add(this.lblTracks);
//            this.Controls.Add(this.label17);
//            this.Controls.Add(this.label2);
//            this.Controls.Add(this.label16);
//            this.Controls.Add(this.lblHeads);
//            this.Controls.Add(this.label4);
//            this.Controls.Add(this.label5);
//            this.Controls.Add(this.label6);
//            this.Controls.Add(this.lblBytesPerSector);
//            this.Controls.Add(this.label7);
//            this.Controls.Add(this.lblSectors);
//            this.Controls.Add(this.label8);
//            this.Controls.Add(this.lblFirmware);
//            this.Controls.Add(this.label9);
//            this.Controls.Add(this.lblCylinders);
//            this.Controls.Add(this.label10);
//            this.Controls.Add(this.lblSignature);
//            this.Controls.Add(this.label12);
//            this.Controls.Add(this.lblPartitions);
//            this.Controls.Add(this.label13);
//            this.Controls.Add(this.lblCapacity);
//            this.Controls.Add(this.label14);
//            this.Controls.Add(this.lblInterface);
//            this.Controls.Add(this.label15);
//            this.Controls.Add(this.lblSerial);
//            this.Controls.Add(this.label11);
//            this.Controls.Add(this.lblModel);
//            this.Controls.Add(this.label18);
//            this.Controls.Add(this.lblType);
//            this.Controls.Add(this.label19);
//            this.Controls.Add(this.label20);
//            this.Controls.Add(this.label21);
//            this.Controls.Add(this.label30);
//            this.Controls.Add(this.label22);
//            this.Controls.Add(this.label29);
//            this.Controls.Add(this.label23);
//            this.Controls.Add(this.label28);
//            this.Controls.Add(this.label24);
//            this.Controls.Add(this.label26);
//            this.Controls.Add(this.label25);
//            this.Controls.Add(this.cmbHdd);
//            this.Controls.Add(this.label1);
//            this.Name = "Form1";
//            this.Text = "Form1";
//            this.Load += new System.EventHandler(this.Form1_Load);
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.ComboBox cmbHdd;
//        private System.Windows.Forms.Label label3;
//        private System.Windows.Forms.Label lblTracksPerCylinder;
//        private System.Windows.Forms.Label lblSectorPerTrack;
//        private System.Windows.Forms.Label label32;
//        private System.Windows.Forms.Label label31;
//        private System.Windows.Forms.Label lblTracks;
//        private System.Windows.Forms.Label label17;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.Label label16;
//        private System.Windows.Forms.Label lblHeads;
//        private System.Windows.Forms.Label label4;
//        private System.Windows.Forms.Label label5;
//        private System.Windows.Forms.Label label6;
//        private System.Windows.Forms.Label lblBytesPerSector;
//        private System.Windows.Forms.Label label7;
//        private System.Windows.Forms.Label lblSectors;
//        private System.Windows.Forms.Label label8;
//        private System.Windows.Forms.Label lblFirmware;
//        private System.Windows.Forms.Label label9;
//        private System.Windows.Forms.Label lblCylinders;
//        private System.Windows.Forms.Label label10;
//        private System.Windows.Forms.Label lblSignature;
//        private System.Windows.Forms.Label label12;
//        private System.Windows.Forms.Label lblPartitions;
//        private System.Windows.Forms.Label label13;
//        private System.Windows.Forms.Label lblCapacity;
//        private System.Windows.Forms.Label label14;
//        private System.Windows.Forms.Label lblInterface;
//        private System.Windows.Forms.Label label15;
//        private System.Windows.Forms.Label lblSerial;
//        private System.Windows.Forms.Label label11;
//        private System.Windows.Forms.Label lblModel;
//        private System.Windows.Forms.Label label18;
//        private System.Windows.Forms.Label lblType;
//        private System.Windows.Forms.Label label19;
//        private System.Windows.Forms.Label label20;
//        private System.Windows.Forms.Label label21;
//        private System.Windows.Forms.Label label30;
//        private System.Windows.Forms.Label label22;
//        private System.Windows.Forms.Label label29;
//        private System.Windows.Forms.Label label23;
//        private System.Windows.Forms.Label label28;
//        private System.Windows.Forms.Label label24;
//        private System.Windows.Forms.Label label26;
//        private System.Windows.Forms.Label label25;
//    }
//}
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblRam = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblArch = new System.Windows.Forms.Label();
            this.lblRproc = new System.Windows.Forms.Label();
            this.lblSerial = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblAdmSts = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.compName = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblCNam = new System.Windows.Forms.Label();
            this.lblWinDir = new System.Windows.Forms.Label();
            this.lblCap = new System.Windows.Forms.Label();
            this.lblMan = new System.Windows.Forms.Label();
            this.lblVer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lstServices = new System.Windows.Forms.ListBox();
            this.btnSoftware = new System.Windows.Forms.Button();
            this.btnUnin = new System.Windows.Forms.Button();
            this.lstSoftware = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAbt = new System.Windows.Forms.Button();
            this.lstPrinters = new System.Windows.Forms.ListBox();
            this.btnPrinters = new System.Windows.Forms.Button();
            this.btnUnprnt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Current User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Disk Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Arch Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "Processes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "Free";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 69;
            this.label7.Text = "Size";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 72;
            this.label10.Text = "RAM";
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.Location = new System.Drawing.Point(143, 235);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(10, 13);
            this.lblRam.TabIndex = 100;
            this.lblRam.Text = "-";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(143, 213);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(10, 13);
            this.lblUser.TabIndex = 99;
            this.lblUser.Text = "-";
            // 
            // lblArch
            // 
            this.lblArch.AutoSize = true;
            this.lblArch.Location = new System.Drawing.Point(143, 164);
            this.lblArch.Name = "lblArch";
            this.lblArch.Size = new System.Drawing.Size(10, 13);
            this.lblArch.TabIndex = 98;
            this.lblArch.Text = "-";
            // 
            // lblRproc
            // 
            this.lblRproc.AutoSize = true;
            this.lblRproc.Location = new System.Drawing.Point(143, 188);
            this.lblRproc.Name = "lblRproc";
            this.lblRproc.Size = new System.Drawing.Size(10, 13);
            this.lblRproc.TabIndex = 97;
            this.lblRproc.Text = "-";
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Location = new System.Drawing.Point(143, 141);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(10, 13);
            this.lblSerial.TabIndex = 96;
            this.lblSerial.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(123, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 13);
            this.label11.TabIndex = 79;
            this.label11.Text = ":";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(143, 116);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(10, 13);
            this.lblModel.TabIndex = 95;
            this.lblModel.Text = "-";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(122, 188);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(11, 13);
            this.label18.TabIndex = 80;
            this.label18.Text = ":";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(143, 92);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(10, 13);
            this.lblType.TabIndex = 94;
            this.lblType.Text = "-";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(122, 163);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(11, 13);
            this.label19.TabIndex = 81;
            this.label19.Text = ":";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(123, 140);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(11, 13);
            this.label20.TabIndex = 82;
            this.label20.Text = ":";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(123, 234);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(11, 13);
            this.label21.TabIndex = 83;
            this.label21.Text = ":";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(122, 91);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(11, 13);
            this.label24.TabIndex = 86;
            this.label24.Text = ":";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(122, 115);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(11, 13);
            this.label25.TabIndex = 87;
            this.label25.Text = ":";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(42, 69);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(69, 13);
            this.label27.TabIndex = 109;
            this.label27.Text = "Admin Status";
            // 
            // lblAdmSts
            // 
            this.lblAdmSts.AutoSize = true;
            this.lblAdmSts.Location = new System.Drawing.Point(143, 69);
            this.lblAdmSts.Name = "lblAdmSts";
            this.lblAdmSts.Size = new System.Drawing.Size(10, 13);
            this.lblAdmSts.TabIndex = 111;
            this.lblAdmSts.Text = "-";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(159, 18);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(11, 13);
            this.label34.TabIndex = 110;
            this.label34.Text = ":";
            // 
            // compName
            // 
            this.compName.Location = new System.Drawing.Point(176, 15);
            this.compName.Name = "compName";
            this.compName.Size = new System.Drawing.Size(151, 20);
            this.compName.TabIndex = 112;
            this.compName.Text = "127.0.0.1";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(42, 18);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(105, 13);
            this.label33.TabIndex = 113;
            this.label33.Text = "Enter PC Name or IP";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(333, 12);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 114;
            this.btnGo.Text = "Connect";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblCNam
            // 
            this.lblCNam.AutoSize = true;
            this.lblCNam.Location = new System.Drawing.Point(330, 92);
            this.lblCNam.Name = "lblCNam";
            this.lblCNam.Size = new System.Drawing.Size(10, 13);
            this.lblCNam.TabIndex = 115;
            this.lblCNam.Text = "-";
            // 
            // lblWinDir
            // 
            this.lblWinDir.AutoSize = true;
            this.lblWinDir.Location = new System.Drawing.Point(330, 69);
            this.lblWinDir.Name = "lblWinDir";
            this.lblWinDir.Size = new System.Drawing.Size(10, 13);
            this.lblWinDir.TabIndex = 116;
            this.lblWinDir.Text = "-";
            // 
            // lblCap
            // 
            this.lblCap.AutoSize = true;
            this.lblCap.Location = new System.Drawing.Point(330, 116);
            this.lblCap.Name = "lblCap";
            this.lblCap.Size = new System.Drawing.Size(10, 13);
            this.lblCap.TabIndex = 117;
            this.lblCap.Text = "-";
            // 
            // lblMan
            // 
            this.lblMan.AutoSize = true;
            this.lblMan.Location = new System.Drawing.Point(330, 164);
            this.lblMan.Name = "lblMan";
            this.lblMan.Size = new System.Drawing.Size(10, 13);
            this.lblMan.TabIndex = 118;
            this.lblMan.Text = "-";
            // 
            // lblVer
            // 
            this.lblVer.AutoSize = true;
            this.lblVer.Location = new System.Drawing.Point(330, 141);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(10, 13);
            this.lblVer.TabIndex = 119;
            this.lblVer.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 13);
            this.label1.TabIndex = 121;
            this.label1.Text = "Installed Software (this will take a few minutes to populate)";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(518, 191);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 123;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(599, 191);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 124;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnGet
            // 
            this.btnGet.AutoSize = true;
            this.btnGet.Location = new System.Drawing.Point(888, 191);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(78, 23);
            this.btnGet.TabIndex = 125;
            this.btnGet.Text = "Get Services";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(712, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 126;
            this.label8.Text = "State:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(755, 196);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(10, 13);
            this.lblState.TabIndex = 127;
            this.lblState.Text = "-";
            // 
            // lstServices
            // 
            this.lstServices.FormattingEnabled = true;
            this.lstServices.Location = new System.Drawing.Point(518, 12);
            this.lstServices.Name = "lstServices";
            this.lstServices.Size = new System.Drawing.Size(448, 173);
            this.lstServices.TabIndex = 128;
            this.lstServices.SelectedIndexChanged += new System.EventHandler(this.lstServices_SelectedIndexChanged_1);
            // 
            // btnSoftware
            // 
            this.btnSoftware.AutoSize = true;
            this.btnSoftware.Location = new System.Drawing.Point(488, 306);
            this.btnSoftware.Name = "btnSoftware";
            this.btnSoftware.Size = new System.Drawing.Size(79, 23);
            this.btnSoftware.TabIndex = 129;
            this.btnSoftware.Text = "Get Software";
            this.btnSoftware.UseVisualStyleBackColor = true;
            this.btnSoftware.Click += new System.EventHandler(this.btnSoftware_Click);
            // 
            // btnUnin
            // 
            this.btnUnin.Location = new System.Drawing.Point(488, 335);
            this.btnUnin.Name = "btnUnin";
            this.btnUnin.Size = new System.Drawing.Size(79, 23);
            this.btnUnin.TabIndex = 130;
            this.btnUnin.Text = "Uninstall";
            this.btnUnin.UseVisualStyleBackColor = true;
            this.btnUnin.Click += new System.EventHandler(this.btnUnin_Click);
            // 
            // lstSoftware
            // 
            this.lstSoftware.FormattingEnabled = true;
            this.lstSoftware.Location = new System.Drawing.Point(45, 306);
            this.lstSoftware.Name = "lstSoftware";
            this.lstSoftware.Size = new System.Drawing.Size(434, 160);
            this.lstSoftware.TabIndex = 132;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(485, 388);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(211, 78);
            this.label12.TabIndex = 133;
            this.label12.Text = resources.GetString("label12.Text");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(123, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 13);
            this.label13.TabIndex = 134;
            this.label13.Text = ":";
            // 
            // btnAbt
            // 
            this.btnAbt.Location = new System.Drawing.Point(333, 230);
            this.btnAbt.Name = "btnAbt";
            this.btnAbt.Size = new System.Drawing.Size(75, 23);
            this.btnAbt.TabIndex = 135;
            this.btnAbt.Text = "About";
            this.btnAbt.UseVisualStyleBackColor = true;
            this.btnAbt.Click += new System.EventHandler(this.btnAbt_Click);
            // 
            // lstPrinters
            // 
            this.lstPrinters.FormattingEnabled = true;
            this.lstPrinters.Location = new System.Drawing.Point(715, 306);
            this.lstPrinters.Name = "lstPrinters";
            this.lstPrinters.Size = new System.Drawing.Size(396, 160);
            this.lstPrinters.TabIndex = 136;
            // 
            // btnPrinters
            // 
            this.btnPrinters.Location = new System.Drawing.Point(634, 306);
            this.btnPrinters.Name = "btnPrinters";
            this.btnPrinters.Size = new System.Drawing.Size(75, 23);
            this.btnPrinters.TabIndex = 137;
            this.btnPrinters.Text = "Get Printers";
            this.btnPrinters.UseVisualStyleBackColor = true;
            this.btnPrinters.Click += new System.EventHandler(this.btnPrinters_Click);
            // 
            // btnUnprnt
            // 
            this.btnUnprnt.Location = new System.Drawing.Point(634, 335);
            this.btnUnprnt.Name = "btnUnprnt";
            this.btnUnprnt.Size = new System.Drawing.Size(75, 23);
            this.btnUnprnt.TabIndex = 138;
            this.btnUnprnt.Text = "Uninstall";
            this.btnUnprnt.UseVisualStyleBackColor = true;
            this.btnUnprnt.Click += new System.EventHandler(this.btnUnprnt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 478);
            this.Controls.Add(this.btnUnprnt);
            this.Controls.Add(this.btnPrinters);
            this.Controls.Add(this.lstPrinters);
            this.Controls.Add(this.btnAbt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lstSoftware);
            this.Controls.Add(this.btnUnin);
            this.Controls.Add(this.btnSoftware);
            this.Controls.Add(this.lstServices);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVer);
            this.Controls.Add(this.lblMan);
            this.Controls.Add(this.lblCap);
            this.Controls.Add(this.lblWinDir);
            this.Controls.Add(this.lblCNam);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.compName);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.lblAdmSts);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblRam);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblArch);
            this.Controls.Add(this.lblRproc);
            this.Controls.Add(this.lblSerial);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Remote Administration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblArch;
        private System.Windows.Forms.Label lblRproc;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblAdmSts;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox compName;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblCNam;
        private System.Windows.Forms.Label lblWinDir;
        private System.Windows.Forms.Label lblCap;
        private System.Windows.Forms.Label lblMan;
        private System.Windows.Forms.Label lblVer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ListBox lstServices;
        private System.Windows.Forms.Button btnSoftware;
        private System.Windows.Forms.Button btnUnin;
        private System.Windows.Forms.ListBox lstSoftware;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAbt;
        private System.Windows.Forms.ListBox lstPrinters;
        private System.Windows.Forms.Button btnPrinters;
        private System.Windows.Forms.Button btnUnprnt;
    }
}

