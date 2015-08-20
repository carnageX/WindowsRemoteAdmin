namespace wmi
{
    partial class ExportForm
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
            this.checkedListBoxExport = new System.Windows.Forms.CheckedListBox();
            this.groupExportFields = new System.Windows.Forms.GroupBox();
            this.groupExportMode = new System.Windows.Forms.GroupBox();
            this.btnExportBrowse = new System.Windows.Forms.Button();
            this.txtInputList = new System.Windows.Forms.TextBox();
            this.rbMultiMode = new System.Windows.Forms.RadioButton();
            this.rbSingleMode = new System.Windows.Forms.RadioButton();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.openFileExport = new System.Windows.Forms.OpenFileDialog();
            this.saveFileExport = new System.Windows.Forms.SaveFileDialog();
            this.groupExportFields.SuspendLayout();
            this.groupExportMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBoxExport
            // 
            this.checkedListBoxExport.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBoxExport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxExport.CheckOnClick = true;
            this.checkedListBoxExport.FormattingEnabled = true;
            this.checkedListBoxExport.Location = new System.Drawing.Point(6, 19);
            this.checkedListBoxExport.Name = "checkedListBoxExport";
            this.checkedListBoxExport.Size = new System.Drawing.Size(329, 105);
            this.checkedListBoxExport.TabIndex = 0;
            // 
            // groupExportFields
            // 
            this.groupExportFields.Controls.Add(this.checkedListBoxExport);
            this.groupExportFields.Location = new System.Drawing.Point(12, 114);
            this.groupExportFields.Name = "groupExportFields";
            this.groupExportFields.Size = new System.Drawing.Size(341, 132);
            this.groupExportFields.TabIndex = 1;
            this.groupExportFields.TabStop = false;
            this.groupExportFields.Text = "Fields";
            // 
            // groupExportMode
            // 
            this.groupExportMode.Controls.Add(this.btnExportBrowse);
            this.groupExportMode.Controls.Add(this.txtInputList);
            this.groupExportMode.Controls.Add(this.rbMultiMode);
            this.groupExportMode.Controls.Add(this.rbSingleMode);
            this.groupExportMode.Location = new System.Drawing.Point(12, 12);
            this.groupExportMode.Name = "groupExportMode";
            this.groupExportMode.Size = new System.Drawing.Size(341, 96);
            this.groupExportMode.TabIndex = 2;
            this.groupExportMode.TabStop = false;
            this.groupExportMode.Text = "Mode";
            // 
            // btnExportBrowse
            // 
            this.btnExportBrowse.Location = new System.Drawing.Point(260, 64);
            this.btnExportBrowse.Name = "btnExportBrowse";
            this.btnExportBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnExportBrowse.TabIndex = 3;
            this.btnExportBrowse.Text = "Browse...";
            this.btnExportBrowse.UseVisualStyleBackColor = true;
            this.btnExportBrowse.Click += new System.EventHandler(this.btnExportBrowse_Click);
            // 
            // txtInputList
            // 
            this.txtInputList.Location = new System.Drawing.Point(7, 66);
            this.txtInputList.Name = "txtInputList";
            this.txtInputList.Size = new System.Drawing.Size(247, 20);
            this.txtInputList.TabIndex = 2;
            // 
            // rbMultiMode
            // 
            this.rbMultiMode.AutoSize = true;
            this.rbMultiMode.Location = new System.Drawing.Point(6, 42);
            this.rbMultiMode.Name = "rbMultiMode";
            this.rbMultiMode.Size = new System.Drawing.Size(148, 17);
            this.rbMultiMode.TabIndex = 1;
            this.rbMultiMode.TabStop = true;
            this.rbMultiMode.Text = "Multiple Systems From File";
            this.rbMultiMode.UseVisualStyleBackColor = true;
            this.rbMultiMode.CheckedChanged += new System.EventHandler(this.rbMultiMode_CheckedChanged);
            // 
            // rbSingleMode
            // 
            this.rbSingleMode.AutoSize = true;
            this.rbSingleMode.Location = new System.Drawing.Point(6, 19);
            this.rbSingleMode.Name = "rbSingleMode";
            this.rbSingleMode.Size = new System.Drawing.Size(193, 17);
            this.rbSingleMode.TabIndex = 0;
            this.rbSingleMode.TabStop = true;
            this.rbSingleMode.Text = "Single System (Existing Connection)";
            this.rbSingleMode.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(197, 254);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export...";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(278, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // openFileExport
            // 
            this.openFileExport.FileName = "openFileDialog1";
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 289);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.groupExportMode);
            this.Controls.Add(this.groupExportFields);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ExportForm";
            this.Load += new System.EventHandler(this.ExportForm_Load);
            this.groupExportFields.ResumeLayout(false);
            this.groupExportMode.ResumeLayout(false);
            this.groupExportMode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxExport;
        private System.Windows.Forms.GroupBox groupExportFields;
        private System.Windows.Forms.GroupBox groupExportMode;
        private System.Windows.Forms.Button btnExportBrowse;
        private System.Windows.Forms.TextBox txtInputList;
        private System.Windows.Forms.RadioButton rbMultiMode;
        private System.Windows.Forms.RadioButton rbSingleMode;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.OpenFileDialog openFileExport;
        private System.Windows.Forms.SaveFileDialog saveFileExport;
    }
}