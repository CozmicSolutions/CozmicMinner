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

namespace WindowsFrom_Test.Forms
{
    using CozmicMinner.Classes;

    using DevExpress.XtraCharts;

    public partial class BaseLayoutForm : DevExpress.XtraEditors.XtraForm
    {
        Series SalesbySecorSeries
        {
            get { return chartSalesbySecor.Series[0]; }
        }
        public BaseLayoutForm()
        {
            InitializeComponent();
            SalesbySecorSeries.DataSource = ApiQuery.GetBlocksHistory();

        }
    }
}