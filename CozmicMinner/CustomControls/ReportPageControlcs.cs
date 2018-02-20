using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CozmicMinner.CustomControls
{
    using DevExpress.XtraBars.Navigation;

    public partial class ReportPageControlcs : DevExpress.XtraEditors.XtraUserControl
    {
   
       
        public ReportPageControlcs()
        {
            InitializeComponent();
        }

        TabNavigationPage CreatePage(string name)
        {
            var reportPage = this.tabPanel.Pages.FirstOrDefault(x => x.Name.Equals("tpg" + name, StringComparison.CurrentCultureIgnoreCase)) as TabNavigationPage;

            if (reportPage != null) return reportPage;

            reportPage = new TabNavigationPage
            {
                Name = "tpg" + name.Replace(" ",""),
                Caption = name

            };

            this.tabPanel.Pages.Add(reportPage);
          
            return reportPage;
        }

        public void CreateReport<T>(string name , List<T> data)
        {
            GridListControl gridList = new GridListControl();
            this.CreatePage(name).Controls.Add(gridList);
            gridList.FillGrid(data);
        }
    }
}
