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

namespace WindowsFrom_Test.Forms
{
    using DevExpress.XtraCharts;

    public partial class ChartControl : DevExpress.XtraEditors.XtraUserControl
    {
        public ChartControl()
        {
            InitializeComponent();
          
            this.ChartCustomControl.Series.AddRange();
        }
    }
}
