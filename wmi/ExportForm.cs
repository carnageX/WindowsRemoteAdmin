using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wmi
{
    public partial class ExportForm : Form
    {
        private enum ExportOptions
        {
            SystemInfo,
            Services,
            Software,
            Printers,
            Drives,
            LocalAccounts
        }

        

        public ExportForm()
        {
            InitializeComponent();
        }

        private void ExportForm_Load(object sender, EventArgs e)
        {
            ((ListBox)this.checkedListBoxExport).DataSource = new List<string>()
            {
                ExportOptions.SystemInfo.ToString(), ExportOptions.Services.ToString(),
                ExportOptions.Software.ToString(), ExportOptions.Printers.ToString(),
                ExportOptions.Drives.ToString(), ExportOptions.LocalAccounts.ToString()
            };

            SetMultiFileControlState(false);
        }

        private void SetMultiFileControlState(bool isEnabled)
        {
            this.txtInputList.Enabled = isEnabled;
            this.btnExportBrowse.Enabled = isEnabled;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbMultiMode_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rbMultiMode.Checked)
            {
                SetMultiFileControlState(true);
            }
            else
            {
                SetMultiFileControlState(false);
            }
        }
    }
}
