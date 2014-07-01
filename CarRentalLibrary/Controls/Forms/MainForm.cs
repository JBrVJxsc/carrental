using System;
using System.Data;
using System.Windows.Forms;
using CarRentalLibrary.Classes.Managers;
using CarRentalLibrary.Classes.Objects;
using CarRentalLibrary.Controls.Forms.Wizards;
using CarRentalLoader.Class.Managers;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace CarRentalLibrary.Controls.Forms
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private CommunicationManager communicationManager = new CommunicationManager();
        private XmlManager<BackObject> backObjectXmlManager = new XmlManager<BackObject>();

        protected override void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);
            lendTableAdapter.Fill(dbDataSet.Lend);
        }

        private void barBtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LendWizard lendWizard = new LendWizard(lendTableAdapter, dbDataSet);
            DialogResult dr = lendWizard.ShowDialog();
            if (dr == DialogResult.OK)
            {

            }
        }

        private void barBtnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridView.ShowPrintPreview();
        }

        private void barBtnSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!barStatus.Visible)
            {
                barStatus.Visible = true;
            }
            barTxtSearch.Links[0].Focus();
        }

        private void barBtnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void barBtnCloseSearch_ItemClick(object sender, ItemClickEventArgs e)
        {
            barStatus.Visible = false;
        }

        private void repositoryItemTextEdit_EditValueChanging(object sender, ChangingEventArgs e)
        {
            string filter = e.NewValue.ToString();
            lendBindingSource.Filter = "PersonName LIKE '%" + filter + "%'"
                + " OR " + "PersonID LIKE '%" + filter + "%'"
                + " OR " + "PersonPhone LIKE '%" + filter + "%'"
                + " OR " + "CarNumber LIKE '%" + filter + "%'";
        }

        private void gridView_CellDoubleClick(object sender, GridHitInfo gridHitInfo)
        {
            DataRow dataRow = gridView.GetFocusedDataRow();
            if ((bool)dataRow["IsBack"])
            {
                return;
            }
            DialogResult dr = XtraMessageBox.Show("是否将 "+dataRow["PersonName"].ToString()+" 所租车辆的状态更新为“已归还”？\n更新后不可更改，请谨慎操作。", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.Yes)
            {
                return;
            }
            int i = 0;
            BackObject backObject = new BackObject();
            backObject.LendID = dataRow["LendID"].ToString();
            backObject.Lender = dataRow["Lender"].ToString();
            backObject.BackDate = DateTime.Now;
            if (!communicationManager.SendMessage("[Back]" + backObject.LendID, backObjectXmlManager.SerializeToString(backObject)))
            {
                XtraMessageBox.Show("与服务器同步出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            i = DataBaseManager.GlobalDataBaseManager.UpdateLendIsBack(lendTableAdapter, dbDataSet, dataRow);
            if (i < 0)
            {
                return;
            }
            i = DataBaseManager.GlobalDataBaseManager.InsertBackObject(backObject);
            if (i < 0)
            {
                return;
            }
            if (i >= 0)
            {
                XtraMessageBox.Show("更新记录成功。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
