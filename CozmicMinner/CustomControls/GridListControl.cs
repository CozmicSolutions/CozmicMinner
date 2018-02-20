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
    using DevExpress.XtraGrid;
    using DevExpress.XtraGrid.Columns;
    using DevExpress.XtraGrid.Views.Grid;

    public partial class GridListControl : DevExpress.XtraEditors.XtraUserControl
    {
        public GridControl Grid => this.gridControl;

        public GridView View => this.gridView;

        public GridListControl()
        {
            InitializeComponent();
        }

        public void HideGridColumns(List<string> columnToHide, bool allowEdit)
        {
            foreach (GridColumn col in this.gridView.Columns)
            {
                if (columnToHide.Contains(col.FieldName)) col.VisibleIndex = -1;
                col.OptionsColumn.AllowEdit = allowEdit;
                col.BestFit();
            }
        }

        public void SetGridColumns(bool allowEdit)
        {
            foreach (GridColumn col in this.gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = allowEdit;
                col.BestFit();
            }
        }

        public void FillGrid<T>(List<T> dataList , bool allowEdit = false)
        {
            this.gridControl.DataSource = null;
            this.gridControl.DataSource = dataList;
            this.SetGridColumns(allowEdit);
        }
    }
}
