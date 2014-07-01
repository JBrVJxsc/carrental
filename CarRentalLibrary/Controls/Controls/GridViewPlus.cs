using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace CarRentalLibrary.Controls.Controls
{
    public partial class GridViewPlus : GridView
    {
        public GridViewPlus()
        {
            InitializeComponent();
        }

        public event CellDoubleClickHandle CellDoubleClick;

        private void GridViewPlus_DoubleClick(object sender, System.EventArgs e)
        {
            Point point = GridControl.PointToClient(Control.MousePosition);
            GridHitInfo gridHitInfo = CalcHitInfo(point);
            if (gridHitInfo.InRow || gridHitInfo.InRowCell)
            {
                if (CellDoubleClick != null)
                {
                    CellDoubleClick(this, gridHitInfo);
                }
            }
        }
    }

    public delegate void CellDoubleClickHandle(object sender, GridHitInfo gridHitInfo);
}
