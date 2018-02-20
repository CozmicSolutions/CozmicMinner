using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CozmicAPI.Tests
{
    using CozmicMinner.Classes;
    using CozmicMinner.CustomControls;

    using DevExpress.DashboardCommon;

    public partial class WebBrowserForm_Test : DevExpress.XtraEditors.XtraForm
    {
        public WebBrowserForm_Test()
        {
            this.InitializeComponent();
            var ctl = new WebBrowserControl();
            this.MainPanel.Controls.Add(ctl);
            ctl.Navigate("www.google.com");

        }

        private void dashboardViewer1_Load(object sender, EventArgs e)
        {
          

        }
    }
}