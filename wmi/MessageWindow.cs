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
    public partial class MessageWindow : Form
    {
        public string WindowTitle { get; set; }
        public string Message { get; set; }
        public List<string> Details { get; set; }
        public Exception Exception { get; set; }

        private string _newLine = System.Environment.NewLine;

        public MessageWindow(string windowTitle, Exception ex)
        {
            InitializeComponent();

            this.Exception = ex;
            this.WindowTitle = windowTitle;
            if (this.Exception != null)
            {
                Message = this.Exception.Message;
                Details = new List<string>();
                if (this.Exception.InnerException != null) 
                { Details.Add(String.Format("Inner Exception: {0}{1}", _newLine, this.Exception.InnerException.Message)); }
                if (this.Exception.Source != null)
                { Details.Add(String.Format("{0}{0}Source: {0}{1}", _newLine, this.Exception.Source)); }
                if (this.Exception.StackTrace != null)
                { Details.Add(String.Format("{0}{0}StackTrace: {0}{1}", _newLine, this.Exception.StackTrace)); }
            }
            InitMessageWindow();
        }

        public MessageWindow(string windowTitle, string message, List<string> details)
        {
            InitializeComponent();
            this.WindowTitle = windowTitle;
            this.Message = message;
            this.Details = details;
        }

        private void InitMessageWindow()
        {
            this.Text = WindowTitle;
            this.Height = 171;

            txtMessage.Text = this.Message;
            txtDetails.Text = String.Join(_newLine, this.Details);
        }

        private void linkDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Height = 389;
        }
    }
}
