using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DevExpress.XtraEditors;

namespace CozmicMinner.CustomControls
{
    public partial class WebBrowserControl : DevExpress.XtraEditors.XtraUserControl
    {
        public WebBrowserControl()
        {
            InitializeComponent();
            InitializeWebBrowser();
            this.txtAddress.Text = "https://coincap.io/";
        }

        void InitializeWebBrowser()
        {
            this.webBrowser.Navigating += this.WebBrowserOnNavigating;
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.DocumentCompleted += this.WebBrowserOnDocumentCompleted;
            //this.webBrowser.Navigated += this.WebBrowser_Navigated;
        }

        public void Navigate(string url)
        {
            this.webBrowser.Navigate(url);
        }

        private void WebBrowserOnDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs webBrowserDocumentCompletedEventArgs)
        {
            this.SetStatusBarValues("Ready", 100);
        }

        private void WebBrowserOnNavigating(object sender, WebBrowserNavigatingEventArgs webBrowserNavigatingEventArgs)
        {
            this.SetStatusBarValues("Loading", 30);
        }

        private void SetStatusBarValues(string text , int progress)
        {
            this.lblStatus.Text = text;
            this.progressbarStatus.Step = progress;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtAddress.Text)) return;
            Navigate(this.txtAddress.Text);
        }
    }
}
