using System;
using System.Windows.Forms;
using CarRentalLibrary.Classes.Managers;
using CarRentalLibrary.Classes.Objects;
using CarRentalLibrary.DbDataSetTableAdapters;
using CarRentalLoader.Class.Managers;
using DevExpress.XtraEditors;

namespace CarRentalLibrary.Controls.Forms.Wizards
{
    public partial class LendWizard : BaseForm
    {
        public LendWizard(LendTableAdapter lendTableAdapter ,DbDataSet dbDataSet)
        {
            InitializeComponent();
            InitControls();
            InitUserCode();
            this.lendTableAdapter = lendTableAdapter;
            this.dbDataSet = dbDataSet;
        }

        private LendObject lendObject = new LendObject();
        private LendTableAdapter lendTableAdapter;
        private DbDataSet dbDataSet;
        private string userCode = string.Empty;
        private CommunicationManager communicationManager = new CommunicationManager();
        private XmlManager<LendObject> lendObjectXmlManager = new XmlManager<LendObject>();

        public LendObject LendObject
        {
            get
            {
                return lendObject;
            }
        }

        private void InitControls()
        {
            dtLendDate.DateTime = DateTime.Now;
            dtBackDate.DateTime = DateTime.Now;
        }

        private void InitUserCode()
        {
            userCode = UserCodeManager.GetUserCode();
        }

        private void FillLendObject()
        {
            lendObject.Lender = userCode;
            lendObject.PersonName = txtPersonName.Text;
            lendObject.PersonID = txtPersonID.Text;
            lendObject.PersonPhone = txtPersonPhone.Text;
            lendObject.CarNumber = txtCarNumber.Text;
            lendObject.LendDate = dtLendDate.DateTime;
            lendObject.BackDate = dtBackDate.DateTime;
        }

        private bool SaveLendObject()
        {
            int i = 0;
            if (!communicationManager.SendMessage("[Lend]" + lendObject.PersonID, lendObjectXmlManager.SerializeToString(lendObject)))
            {
                return false;
            }
            i = DataBaseManager.GlobalDataBaseManager.InsertLendObjectToDataTable(lendTableAdapter, dbDataSet, lendObject);
            if (i < 0)
            {
                return false;
            }
            return true;
        }

        private void TextControl_TextChanged(object sender, EventArgs e)
        {
            if (txtPersonName.Text.Trim() == string.Empty)
            {
                welcomeWizardPage.AllowNext = false;
            }
            else if (txtPersonID.Text.Trim() == string.Empty || txtPersonID.Text.Trim().Length != 15 && txtPersonID.Text.Trim().Length != 18 || !PersonIDManager.CheckIDCard(txtPersonID.Text))
            {
                welcomeWizardPage.AllowNext = false;
            }
            else if (txtPersonPhone.Text.Trim() == string.Empty)
            {
                welcomeWizardPage.AllowNext = false;
            }
            else if (txtCarNumber.Text.Trim() == string.Empty)
            {
                welcomeWizardPage.AllowNext = false;
            }
            else
            {
                welcomeWizardPage.AllowNext = true;
            }
            FillLendObject();
        }

        private void wizardControl_NextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            DialogResult dr = XtraMessageBox.Show("提交后不可更改，是否继续？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.Yes)
            {
                e.Handled = true;
                return;
            }
            if (!SaveLendObject())
            {
                e.Handled = true;
                XtraMessageBox.Show("提交失败。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                e.Handled = true;
                XtraMessageBox.Show("提交成功。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
