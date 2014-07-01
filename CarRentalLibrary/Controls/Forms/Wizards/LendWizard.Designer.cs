namespace CarRentalLibrary.Controls.Forms.Wizards
{
    partial class LendWizard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LendWizard));
            this.wizardControl = new DevExpress.XtraWizard.WizardControl();
            this.completionWizardPage = new DevExpress.XtraWizard.CompletionWizardPage();
            this.welcomeWizardPage = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.dtBackDate = new DevExpress.XtraEditors.DateEdit();
            this.dtLendDate = new DevExpress.XtraEditors.DateEdit();
            this.txtCarNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtPersonPhone = new DevExpress.XtraEditors.TextEdit();
            this.txtPersonID = new DevExpress.XtraEditors.TextEdit();
            this.txtPersonName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lbPersonName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbPersonID = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbPersonPhone = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbCarNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbLendDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbBackDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl)).BeginInit();
            this.wizardControl.SuspendLayout();
            this.welcomeWizardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBackDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBackDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLendDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLendDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbPersonName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbPersonID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbPersonPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbCarNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbLendDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbBackDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControl
            // 
            this.wizardControl.CancelText = "取消";
            this.wizardControl.Controls.Add(this.completionWizardPage);
            this.wizardControl.Controls.Add(this.welcomeWizardPage);
            this.wizardControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl.FinishText = "&完成";
            this.wizardControl.Location = new System.Drawing.Point(0, 0);
            this.wizardControl.MinimumSize = new System.Drawing.Size(117, 117);
            this.wizardControl.Name = "wizardControl";
            this.wizardControl.NextText = "&提交";
            this.wizardControl.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage,
            this.completionWizardPage});
            this.wizardControl.PreviousText = "< &上一步";
            this.wizardControl.Size = new System.Drawing.Size(687, 411);
            this.wizardControl.Text = "上一步";
            this.wizardControl.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
            this.wizardControl.NextClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wizardControl_NextClick);
            // 
            // completionWizardPage
            // 
            this.completionWizardPage.Name = "completionWizardPage";
            this.completionWizardPage.Size = new System.Drawing.Size(627, 249);
            // 
            // welcomeWizardPage
            // 
            this.welcomeWizardPage.AllowNext = false;
            this.welcomeWizardPage.Controls.Add(this.layoutControl);
            this.welcomeWizardPage.IntroductionText = global::CarRentalLibrary.Properties.Resources.SQL_Insert_LendObject;
            this.welcomeWizardPage.Name = "welcomeWizardPage";
            this.welcomeWizardPage.ProceedText = global::CarRentalLibrary.Properties.Resources.SQL_Insert_LendObject;
            this.welcomeWizardPage.Size = new System.Drawing.Size(627, 249);
            this.welcomeWizardPage.Text = "输入租赁信息";
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.dtBackDate);
            this.layoutControl.Controls.Add(this.dtLendDate);
            this.layoutControl.Controls.Add(this.txtCarNumber);
            this.layoutControl.Controls.Add(this.txtPersonPhone);
            this.layoutControl.Controls.Add(this.txtPersonID);
            this.layoutControl.Controls.Add(this.txtPersonName);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.layoutControlGroup1;
            this.layoutControl.Size = new System.Drawing.Size(627, 249);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl1";
            // 
            // dtBackDate
            // 
            this.dtBackDate.EditValue = null;
            this.dtBackDate.Location = new System.Drawing.Point(86, 162);
            this.dtBackDate.Name = "dtBackDate";
            this.dtBackDate.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBackDate.Properties.Appearance.Options.UseFont = true;
            this.dtBackDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBackDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtBackDate.Size = new System.Drawing.Size(529, 26);
            this.dtBackDate.StyleController = this.layoutControl;
            this.dtBackDate.TabIndex = 9;
            this.dtBackDate.TextChanged += new System.EventHandler(this.TextControl_TextChanged);
            // 
            // dtLendDate
            // 
            this.dtLendDate.EditValue = null;
            this.dtLendDate.Location = new System.Drawing.Point(86, 132);
            this.dtLendDate.Name = "dtLendDate";
            this.dtLendDate.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtLendDate.Properties.Appearance.Options.UseFont = true;
            this.dtLendDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtLendDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtLendDate.Size = new System.Drawing.Size(529, 26);
            this.dtLendDate.StyleController = this.layoutControl;
            this.dtLendDate.TabIndex = 8;
            this.dtLendDate.TextChanged += new System.EventHandler(this.TextControl_TextChanged);
            // 
            // txtCarNumber
            // 
            this.txtCarNumber.EditValue = "蒙G";
            this.txtCarNumber.Location = new System.Drawing.Point(86, 102);
            this.txtCarNumber.Name = "txtCarNumber";
            this.txtCarNumber.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarNumber.Properties.Appearance.Options.UseFont = true;
            this.txtCarNumber.Size = new System.Drawing.Size(529, 26);
            this.txtCarNumber.StyleController = this.layoutControl;
            this.txtCarNumber.TabIndex = 7;
            this.txtCarNumber.TextChanged += new System.EventHandler(this.TextControl_TextChanged);
            // 
            // txtPersonPhone
            // 
            this.txtPersonPhone.Location = new System.Drawing.Point(86, 72);
            this.txtPersonPhone.Name = "txtPersonPhone";
            this.txtPersonPhone.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonPhone.Properties.Appearance.Options.UseFont = true;
            this.txtPersonPhone.Size = new System.Drawing.Size(529, 26);
            this.txtPersonPhone.StyleController = this.layoutControl;
            this.txtPersonPhone.TabIndex = 6;
            this.txtPersonPhone.TextChanged += new System.EventHandler(this.TextControl_TextChanged);
            // 
            // txtPersonID
            // 
            this.txtPersonID.Location = new System.Drawing.Point(86, 42);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonID.Properties.Appearance.Options.UseFont = true;
            this.txtPersonID.Size = new System.Drawing.Size(529, 26);
            this.txtPersonID.StyleController = this.layoutControl;
            this.txtPersonID.TabIndex = 5;
            this.txtPersonID.TextChanged += new System.EventHandler(this.TextControl_TextChanged);
            // 
            // txtPersonName
            // 
            this.txtPersonName.EnterMoveNextControl = true;
            this.txtPersonName.Location = new System.Drawing.Point(86, 12);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPersonName.Properties.Appearance.Options.UseFont = true;
            this.txtPersonName.Size = new System.Drawing.Size(529, 26);
            this.txtPersonName.StyleController = this.layoutControl;
            this.txtPersonName.TabIndex = 4;
            this.txtPersonName.TextChanged += new System.EventHandler(this.TextControl_TextChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lbPersonName,
            this.lbPersonID,
            this.lbPersonPhone,
            this.lbCarNumber,
            this.lbLendDate,
            this.lbBackDate});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(627, 249);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lbPersonName
            // 
            this.lbPersonName.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPersonName.AppearanceItemCaption.Options.UseFont = true;
            this.lbPersonName.Control = this.txtPersonName;
            this.lbPersonName.CustomizationFormText = "姓名：";
            this.lbPersonName.Location = new System.Drawing.Point(0, 0);
            this.lbPersonName.Name = "lbPersonName";
            this.lbPersonName.Size = new System.Drawing.Size(607, 30);
            this.lbPersonName.Text = "姓名：";
            this.lbPersonName.TextSize = new System.Drawing.Size(70, 20);
            // 
            // lbPersonID
            // 
            this.lbPersonID.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonID.AppearanceItemCaption.Options.UseFont = true;
            this.lbPersonID.Control = this.txtPersonID;
            this.lbPersonID.CustomizationFormText = "身份证：";
            this.lbPersonID.Location = new System.Drawing.Point(0, 30);
            this.lbPersonID.Name = "lbPersonID";
            this.lbPersonID.Size = new System.Drawing.Size(607, 30);
            this.lbPersonID.Text = "身份证：";
            this.lbPersonID.TextSize = new System.Drawing.Size(70, 20);
            // 
            // lbPersonPhone
            // 
            this.lbPersonPhone.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonPhone.AppearanceItemCaption.Options.UseFont = true;
            this.lbPersonPhone.Control = this.txtPersonPhone;
            this.lbPersonPhone.CustomizationFormText = "电话：";
            this.lbPersonPhone.Location = new System.Drawing.Point(0, 60);
            this.lbPersonPhone.Name = "lbPersonPhone";
            this.lbPersonPhone.Size = new System.Drawing.Size(607, 30);
            this.lbPersonPhone.Text = "电话：";
            this.lbPersonPhone.TextSize = new System.Drawing.Size(70, 20);
            // 
            // lbCarNumber
            // 
            this.lbCarNumber.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCarNumber.AppearanceItemCaption.Options.UseFont = true;
            this.lbCarNumber.Control = this.txtCarNumber;
            this.lbCarNumber.CustomizationFormText = "车牌号：";
            this.lbCarNumber.Location = new System.Drawing.Point(0, 90);
            this.lbCarNumber.Name = "lbCarNumber";
            this.lbCarNumber.Size = new System.Drawing.Size(607, 30);
            this.lbCarNumber.Text = "车牌号：";
            this.lbCarNumber.TextSize = new System.Drawing.Size(70, 20);
            // 
            // lbLendDate
            // 
            this.lbLendDate.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLendDate.AppearanceItemCaption.Options.UseFont = true;
            this.lbLendDate.Control = this.dtLendDate;
            this.lbLendDate.CustomizationFormText = "租车日期：";
            this.lbLendDate.Location = new System.Drawing.Point(0, 120);
            this.lbLendDate.Name = "lbLendDate";
            this.lbLendDate.Size = new System.Drawing.Size(607, 30);
            this.lbLendDate.Text = "租车日期：";
            this.lbLendDate.TextSize = new System.Drawing.Size(70, 20);
            // 
            // lbBackDate
            // 
            this.lbBackDate.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBackDate.AppearanceItemCaption.Options.UseFont = true;
            this.lbBackDate.Control = this.dtBackDate;
            this.lbBackDate.CustomizationFormText = "还车日期：";
            this.lbBackDate.Location = new System.Drawing.Point(0, 150);
            this.lbBackDate.Name = "lbBackDate";
            this.lbBackDate.Size = new System.Drawing.Size(607, 79);
            this.lbBackDate.Text = "还车日期：";
            this.lbBackDate.TextSize = new System.Drawing.Size(70, 20);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.txtPersonName;
            this.layoutControlItem1.CustomizationFormText = "姓名：";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "lbPersonName";
            this.layoutControlItem1.Size = new System.Drawing.Size(796, 30);
            this.layoutControlItem1.Text = "姓名：";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(56, 20);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.txtPersonName;
            this.layoutControlItem2.CustomizationFormText = "姓名：";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "lbPersonName";
            this.layoutControlItem2.Size = new System.Drawing.Size(796, 30);
            this.layoutControlItem2.Text = "姓名：";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(56, 20);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // LendWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 411);
            this.Controls.Add(this.wizardControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LendWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "租车";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl)).EndInit();
            this.wizardControl.ResumeLayout(false);
            this.welcomeWizardPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtBackDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBackDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLendDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLendDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbPersonName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbPersonID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbPersonPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbCarNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbLendDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbBackDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage;
        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtPersonName;
        private DevExpress.XtraLayout.LayoutControlItem lbPersonName;
        private DevExpress.XtraEditors.TextEdit txtPersonID;
        private DevExpress.XtraLayout.LayoutControlItem lbPersonID;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit txtPersonPhone;
        private DevExpress.XtraLayout.LayoutControlItem lbPersonPhone;
        private DevExpress.XtraEditors.TextEdit txtCarNumber;
        private DevExpress.XtraLayout.LayoutControlItem lbCarNumber;
        private DevExpress.XtraEditors.DateEdit dtLendDate;
        private DevExpress.XtraLayout.LayoutControlItem lbLendDate;
        private DevExpress.XtraEditors.DateEdit dtBackDate;
        private DevExpress.XtraLayout.LayoutControlItem lbBackDate;
    }
}