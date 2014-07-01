using CarRentalLibrary.Controls.Controls;
namespace CarRentalLibrary.Controls.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barMain = new DevExpress.XtraBars.Bar();
            this.barBtnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSearch = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnExit = new DevExpress.XtraBars.BarButtonItem();
            this.barStatus = new DevExpress.XtraBars.Bar();
            this.barLbSearch = new DevExpress.XtraBars.BarStaticItem();
            this.barTxtSearch = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barBtnCloseSearch = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.lendBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet = new CarRentalLibrary.DbDataSet();
            this.gridView = new CarRentalLibrary.Controls.Controls.GridViewPlus();
            this.colPersonName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCarNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLendDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBackDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsBack = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lendTableAdapter = new CarRentalLibrary.DbDataSetTableAdapters.LendTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.AllowCustomization = false;
            this.barManager.AllowMoveBarOnToolbar = false;
            this.barManager.AllowQuickCustomization = false;
            this.barManager.AllowShowToolbarsPopup = false;
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barMain,
            this.barStatus});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Images = this.imageCollection;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnPrint,
            this.barBtnAdd,
            this.barBtnExit,
            this.barBtnSearch,
            this.barLbSearch,
            this.barTxtSearch,
            this.barBtnCloseSearch});
            this.barManager.MainMenu = this.barMain;
            this.barManager.MaxItemId = 20;
            this.barManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit});
            this.barManager.StatusBar = this.barStatus;
            // 
            // barMain
            // 
            this.barMain.BarName = "Main menu";
            this.barMain.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.barMain.DockCol = 0;
            this.barMain.DockRow = 0;
            this.barMain.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barMain.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnPrint, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnSearch, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnExit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barMain.OptionsBar.AllowQuickCustomization = false;
            this.barMain.OptionsBar.DisableCustomization = true;
            this.barMain.OptionsBar.DrawDragBorder = false;
            this.barMain.OptionsBar.MultiLine = true;
            this.barMain.OptionsBar.UseWholeRow = true;
            this.barMain.Text = "Main menu";
            // 
            // barBtnAdd
            // 
            this.barBtnAdd.Caption = "新建";
            this.barBtnAdd.Id = 3;
            this.barBtnAdd.ImageIndex = 3;
            this.barBtnAdd.Name = "barBtnAdd";
            this.barBtnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAdd_ItemClick);
            // 
            // barBtnPrint
            // 
            this.barBtnPrint.Caption = "打印";
            this.barBtnPrint.Id = 2;
            this.barBtnPrint.ImageIndex = 2;
            this.barBtnPrint.Name = "barBtnPrint";
            this.barBtnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPrint_ItemClick);
            // 
            // barBtnSearch
            // 
            this.barBtnSearch.Caption = "查找";
            this.barBtnSearch.Id = 7;
            this.barBtnSearch.ImageIndex = 5;
            this.barBtnSearch.Name = "barBtnSearch";
            this.barBtnSearch.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSearch_ItemClick);
            // 
            // barBtnExit
            // 
            this.barBtnExit.Caption = "退出";
            this.barBtnExit.Id = 6;
            this.barBtnExit.ImageIndex = 4;
            this.barBtnExit.Name = "barBtnExit";
            this.barBtnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnExit_ItemClick);
            // 
            // barStatus
            // 
            this.barStatus.BarName = "Status bar";
            this.barStatus.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.barStatus.DockCol = 0;
            this.barStatus.DockRow = 0;
            this.barStatus.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.barStatus.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barLbSearch),
            new DevExpress.XtraBars.LinkPersistInfo(this.barTxtSearch),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnCloseSearch)});
            this.barStatus.OptionsBar.AllowQuickCustomization = false;
            this.barStatus.OptionsBar.DrawDragBorder = false;
            this.barStatus.OptionsBar.UseWholeRow = true;
            this.barStatus.Text = "Status bar";
            this.barStatus.Visible = false;
            // 
            // barLbSearch
            // 
            this.barLbSearch.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.barLbSearch.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barLbSearch.Caption = "  查找：";
            this.barLbSearch.Id = 10;
            this.barLbSearch.Name = "barLbSearch";
            this.barLbSearch.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barTxtSearch
            // 
            this.barTxtSearch.Edit = this.repositoryItemTextEdit;
            this.barTxtSearch.Id = 12;
            this.barTxtSearch.Name = "barTxtSearch";
            this.barTxtSearch.Width = 220;
            // 
            // repositoryItemTextEdit
            // 
            this.repositoryItemTextEdit.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.repositoryItemTextEdit.Appearance.Options.UseFont = true;
            this.repositoryItemTextEdit.Name = "repositoryItemTextEdit";
            this.repositoryItemTextEdit.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.repositoryItemTextEdit_EditValueChanging);
            // 
            // barBtnCloseSearch
            // 
            this.barBtnCloseSearch.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barBtnCloseSearch.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.barBtnCloseSearch.Caption = " x ";
            this.barBtnCloseSearch.Id = 14;
            this.barBtnCloseSearch.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Postponed;
            this.barBtnCloseSearch.Name = "barBtnCloseSearch";
            this.barBtnCloseSearch.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCloseSearch_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(957, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 599);
            this.barDockControlBottom.Size = new System.Drawing.Size(957, 29);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 559);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(957, 40);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 559);
            // 
            // imageCollection
            // 
            this.imageCollection.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "Back.png");
            this.imageCollection.Images.SetKeyName(1, "Lend.png");
            this.imageCollection.Images.SetKeyName(2, "Print.png");
            this.imageCollection.Images.SetKeyName(3, "Add.png");
            this.imageCollection.Images.SetKeyName(4, "Exit.png");
            this.imageCollection.Images.SetKeyName(5, "Search.png");
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.lendBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 40);
            this.gridControl.MainView = this.gridView;
            this.gridControl.MenuManager = this.barManager;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(957, 559);
            this.gridControl.TabIndex = 4;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // lendBindingSource
            // 
            this.lendBindingSource.DataMember = "Lend";
            this.lendBindingSource.DataSource = this.dbDataSet;
            this.lendBindingSource.Sort = "LendDate Desc";
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "DbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPersonName,
            this.colPersonID,
            this.colPersonPhone,
            this.colCarNumber,
            this.colLendDate,
            this.colBackDate,
            this.colIsBack});
            this.gridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridView.OptionsCustomization.AllowColumnMoving = false;
            this.gridView.OptionsCustomization.AllowColumnResizing = false;
            this.gridView.OptionsCustomization.AllowFilter = false;
            this.gridView.OptionsHint.ShowCellHints = false;
            this.gridView.OptionsHint.ShowColumnHeaderHints = false;
            this.gridView.OptionsHint.ShowFooterHints = false;
            this.gridView.OptionsMenu.EnableColumnMenu = false;
            this.gridView.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.CellDoubleClick += new CarRentalLibrary.Controls.Controls.CellDoubleClickHandle(this.gridView_CellDoubleClick);
            // 
            // colPersonName
            // 
            this.colPersonName.AppearanceHeader.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colPersonName.AppearanceHeader.Options.UseFont = true;
            this.colPersonName.Caption = "姓名";
            this.colPersonName.FieldName = "PersonName";
            this.colPersonName.Name = "colPersonName";
            this.colPersonName.Visible = true;
            this.colPersonName.VisibleIndex = 0;
            // 
            // colPersonID
            // 
            this.colPersonID.AppearanceHeader.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colPersonID.AppearanceHeader.Options.UseFont = true;
            this.colPersonID.Caption = "身份证";
            this.colPersonID.FieldName = "PersonID";
            this.colPersonID.Name = "colPersonID";
            this.colPersonID.Visible = true;
            this.colPersonID.VisibleIndex = 1;
            // 
            // colPersonPhone
            // 
            this.colPersonPhone.AppearanceHeader.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colPersonPhone.AppearanceHeader.Options.UseFont = true;
            this.colPersonPhone.Caption = "电话";
            this.colPersonPhone.FieldName = "PersonPhone";
            this.colPersonPhone.Name = "colPersonPhone";
            this.colPersonPhone.Visible = true;
            this.colPersonPhone.VisibleIndex = 2;
            // 
            // colCarNumber
            // 
            this.colCarNumber.AppearanceHeader.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colCarNumber.AppearanceHeader.Options.UseFont = true;
            this.colCarNumber.Caption = "车牌号";
            this.colCarNumber.FieldName = "CarNumber";
            this.colCarNumber.Name = "colCarNumber";
            this.colCarNumber.Visible = true;
            this.colCarNumber.VisibleIndex = 3;
            // 
            // colLendDate
            // 
            this.colLendDate.AppearanceHeader.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colLendDate.AppearanceHeader.Options.UseFont = true;
            this.colLendDate.Caption = "租车日期";
            this.colLendDate.FieldName = "LendDate";
            this.colLendDate.Name = "colLendDate";
            this.colLendDate.Visible = true;
            this.colLendDate.VisibleIndex = 4;
            // 
            // colBackDate
            // 
            this.colBackDate.AppearanceHeader.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colBackDate.AppearanceHeader.Options.UseFont = true;
            this.colBackDate.Caption = "还车日期";
            this.colBackDate.FieldName = "BackDate";
            this.colBackDate.Name = "colBackDate";
            this.colBackDate.Visible = true;
            this.colBackDate.VisibleIndex = 5;
            // 
            // colIsBack
            // 
            this.colIsBack.AppearanceHeader.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colIsBack.AppearanceHeader.Options.UseFont = true;
            this.colIsBack.Caption = "已归还";
            this.colIsBack.FieldName = "IsBack";
            this.colIsBack.Name = "colIsBack";
            this.colIsBack.Visible = true;
            this.colIsBack.VisibleIndex = 6;
            // 
            // lendTableAdapter
            // 
            this.lendTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 628);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "汽车租赁管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar barMain;
        private DevExpress.XtraBars.Bar barStatus;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraBars.BarButtonItem barBtnPrint;
        private DevExpress.XtraBars.BarButtonItem barBtnAdd;
        private DevExpress.XtraBars.BarButtonItem barBtnExit;
        private DevExpress.XtraBars.BarButtonItem barBtnSearch;
        private DevExpress.XtraGrid.GridControl gridControl;
        private GridViewPlus gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonName;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonID;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colCarNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colLendDate;
        private DevExpress.XtraGrid.Columns.GridColumn colBackDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIsBack;
        private DbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource lendBindingSource;
        private DbDataSetTableAdapters.LendTableAdapter lendTableAdapter;
        private DevExpress.XtraBars.BarStaticItem barLbSearch;
        private DevExpress.XtraBars.BarEditItem barTxtSearch;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit;
        private DevExpress.XtraBars.BarButtonItem barBtnCloseSearch;
    }
}