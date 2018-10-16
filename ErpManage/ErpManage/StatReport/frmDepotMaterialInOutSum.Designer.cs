namespace ErpManage.StatReport
{
    partial class frmDepotMaterialInOutSum
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepotMaterialInOutSum));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridMaterialID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridMaterialName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridSpec = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand16 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedSupplierName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand8 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridQCOnlySum = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand9 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridQCOnlyMoney = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand10 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBQInOnlySum = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand11 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBQInOnlyMoney = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand12 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBQOutOnlySum = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand13 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBQOutOnlyMoney = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand7 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand14 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridJCOnlySum = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand15 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridJCOnlyMoney = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.txtGuid = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkView2 = new System.Windows.Forms.CheckBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chkView = new System.Windows.Forms.CheckBox();
            this.txtMaterialName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectStorage = new System.Windows.Forms.Button();
            this.txtStorage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelectMaterialGuid = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBeginDate = new DevExpress.XtraEditors.DateEdit();
            this.txtMaterialGuid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSelectMaterialType = new System.Windows.Forms.Button();
            this.txtMaterialType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEndDate = new DevExpress.XtraEditors.DateEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.btnQty = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBeginDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBeginDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 128);
            this.gridControl1.MainView = this.bandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1031, 430);
            this.gridControl1.TabIndex = 55;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.DarkGray;
            this.bandedGridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.DarkGray;
            this.bandedGridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DimGray;
            this.bandedGridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.bandedGridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.bandedGridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkGray;
            this.bandedGridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkGray;
            this.bandedGridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Gainsboro;
            this.bandedGridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.bandedGridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.bandedGridView1.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.bandedGridView1.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.bandedGridView1.Appearance.Empty.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.bandedGridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Gray;
            this.bandedGridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Gray;
            this.bandedGridView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.bandedGridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.Gray;
            this.bandedGridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.bandedGridView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.FilterPanel.Options.UseForeColor = true;
            this.bandedGridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Black;
            this.bandedGridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("宋体", 9F);
            this.bandedGridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.bandedGridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.bandedGridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.bandedGridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bandedGridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.DarkGray;
            this.bandedGridView1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.bandedGridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.bandedGridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.bandedGridView1.Appearance.GroupButton.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.GroupButton.Options.UseBorderColor = true;
            this.bandedGridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.Silver;
            this.bandedGridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Silver;
            this.bandedGridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("宋体", 9F);
            this.bandedGridView1.Appearance.GroupFooter.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.bandedGridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.bandedGridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.DimGray;
            this.bandedGridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.bandedGridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.bandedGridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.Silver;
            this.bandedGridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.bandedGridView1.Appearance.GroupRow.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.GroupRow.Options.UseFont = true;
            this.bandedGridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.DarkGray;
            this.bandedGridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.DarkGray;
            this.bandedGridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("宋体", 9F);
            this.bandedGridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.bandedGridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.bandedGridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray;
            this.bandedGridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.LightGray;
            this.bandedGridView1.Appearance.HorzLine.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.OddRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bandedGridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.Preview.BackColor = System.Drawing.Color.Gainsboro;
            this.bandedGridView1.Appearance.Preview.ForeColor = System.Drawing.Color.DimGray;
            this.bandedGridView1.Appearance.Preview.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.Preview.Options.UseForeColor = true;
            this.bandedGridView1.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.bandedGridView1.Appearance.Row.Font = new System.Drawing.Font("宋体", 9F);
            this.bandedGridView1.Appearance.Row.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.Row.Options.UseFont = true;
            this.bandedGridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.DimGray;
            this.bandedGridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.DimGray;
            this.bandedGridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("宋体", 9F);
            this.bandedGridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.bandedGridView1.Appearance.VertLine.BackColor = System.Drawing.Color.LightGray;
            this.bandedGridView1.Appearance.VertLine.Options.UseBackColor = true;
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand16,
            this.gridBand4,
            this.gridBand5,
            this.gridBand6,
            this.gridBand7});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.gridMaterialID,
            this.gridMaterialName,
            this.gridSpec,
            this.gridQCOnlySum,
            this.gridQCOnlyMoney,
            this.gridBQInOnlySum,
            this.gridBQInOnlyMoney,
            this.gridBQOutOnlySum,
            this.gridBQOutOnlyMoney,
            this.gridJCOnlySum,
            this.gridJCOnlyMoney,
            this.bandedSupplierName});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsBehavior.Editable = false;
            this.bandedGridView1.OptionsCustomization.AllowChangeColumnParent = true;
            this.bandedGridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.bandedGridView1.OptionsView.EnableAppearanceOddRow = true;
            this.bandedGridView1.OptionsView.ShowColumnHeaders = false;
            this.bandedGridView1.OptionsView.ShowFooter = true;
            this.bandedGridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "物料编号";
            this.gridBand1.Columns.Add(this.gridMaterialID);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.OptionsBand.FixedWidth = true;
            this.gridBand1.RowCount = 2;
            this.gridBand1.Width = 122;
            // 
            // gridMaterialID
            // 
            this.gridMaterialID.Caption = "物料编号";
            this.gridMaterialID.FieldName = "MaterialID";
            this.gridMaterialID.MinWidth = 122;
            this.gridMaterialID.Name = "gridMaterialID";
            this.gridMaterialID.OptionsColumn.AllowEdit = false;
            this.gridMaterialID.Visible = true;
            this.gridMaterialID.Width = 122;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "物料名称";
            this.gridBand2.Columns.Add(this.gridMaterialName);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.OptionsBand.FixedWidth = true;
            this.gridBand2.Width = 147;
            // 
            // gridMaterialName
            // 
            this.gridMaterialName.Caption = "物料名称";
            this.gridMaterialName.FieldName = "MaterialName";
            this.gridMaterialName.MinWidth = 147;
            this.gridMaterialName.Name = "gridMaterialName";
            this.gridMaterialName.OptionsColumn.AllowEdit = false;
            this.gridMaterialName.Visible = true;
            this.gridMaterialName.Width = 147;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "规格";
            this.gridBand3.Columns.Add(this.gridSpec);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.OptionsBand.FixedWidth = true;
            this.gridBand3.Width = 95;
            // 
            // gridSpec
            // 
            this.gridSpec.Caption = "规格";
            this.gridSpec.FieldName = "SpecName";
            this.gridSpec.MinWidth = 95;
            this.gridSpec.Name = "gridSpec";
            this.gridSpec.OptionsColumn.AllowEdit = false;
            this.gridSpec.Visible = true;
            this.gridSpec.Width = 95;
            // 
            // gridBand16
            // 
            this.gridBand16.Caption = "供应商";
            this.gridBand16.Columns.Add(this.bandedSupplierName);
            this.gridBand16.Name = "gridBand16";
            this.gridBand16.Width = 150;
            // 
            // bandedSupplierName
            // 
            this.bandedSupplierName.Caption = "供应商";
            this.bandedSupplierName.FieldName = "SupplierName";
            this.bandedSupplierName.MinWidth = 150;
            this.bandedSupplierName.Name = "bandedSupplierName";
            this.bandedSupplierName.Visible = true;
            this.bandedSupplierName.Width = 150;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "期初结存";
            this.gridBand4.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand8,
            this.gridBand9});
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.Width = 156;
            // 
            // gridBand8
            // 
            this.gridBand8.Caption = "数量";
            this.gridBand8.Columns.Add(this.gridQCOnlySum);
            this.gridBand8.Name = "gridBand8";
            this.gridBand8.Width = 78;
            // 
            // gridQCOnlySum
            // 
            this.gridQCOnlySum.Caption = "数量1";
            this.gridQCOnlySum.DisplayFormat.FormatString = "0.######";
            this.gridQCOnlySum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridQCOnlySum.FieldName = "QCOnlySum";
            this.gridQCOnlySum.MinWidth = 78;
            this.gridQCOnlySum.Name = "gridQCOnlySum";
            this.gridQCOnlySum.OptionsColumn.AllowEdit = false;
            this.gridQCOnlySum.SummaryItem.DisplayFormat = "{0:n2}";
            this.gridQCOnlySum.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridQCOnlySum.Visible = true;
            this.gridQCOnlySum.Width = 78;
            // 
            // gridBand9
            // 
            this.gridBand9.Caption = "金额(不含税)";
            this.gridBand9.Columns.Add(this.gridQCOnlyMoney);
            this.gridBand9.Name = "gridBand9";
            this.gridBand9.Width = 78;
            // 
            // gridQCOnlyMoney
            // 
            this.gridQCOnlyMoney.Caption = "金额1";
            this.gridQCOnlyMoney.DisplayFormat.FormatString = "0.######";
            this.gridQCOnlyMoney.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridQCOnlyMoney.FieldName = "QCOnlyMoney";
            this.gridQCOnlyMoney.MinWidth = 78;
            this.gridQCOnlyMoney.Name = "gridQCOnlyMoney";
            this.gridQCOnlyMoney.OptionsColumn.AllowEdit = false;
            this.gridQCOnlyMoney.SummaryItem.DisplayFormat = "{0:n2}";
            this.gridQCOnlyMoney.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridQCOnlyMoney.Visible = true;
            this.gridQCOnlyMoney.Width = 78;
            // 
            // gridBand5
            // 
            this.gridBand5.Caption = "本期收入";
            this.gridBand5.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand10,
            this.gridBand11});
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.Width = 156;
            // 
            // gridBand10
            // 
            this.gridBand10.Caption = "数量";
            this.gridBand10.Columns.Add(this.gridBQInOnlySum);
            this.gridBand10.Name = "gridBand10";
            this.gridBand10.Width = 78;
            // 
            // gridBQInOnlySum
            // 
            this.gridBQInOnlySum.Caption = "数量2";
            this.gridBQInOnlySum.DisplayFormat.FormatString = "0.######";
            this.gridBQInOnlySum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridBQInOnlySum.FieldName = "BQInOnlySum";
            this.gridBQInOnlySum.MinWidth = 78;
            this.gridBQInOnlySum.Name = "gridBQInOnlySum";
            this.gridBQInOnlySum.OptionsColumn.AllowEdit = false;
            this.gridBQInOnlySum.SummaryItem.DisplayFormat = "{0:n2}";
            this.gridBQInOnlySum.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridBQInOnlySum.Visible = true;
            this.gridBQInOnlySum.Width = 78;
            // 
            // gridBand11
            // 
            this.gridBand11.Caption = "金额(不含税)";
            this.gridBand11.Columns.Add(this.gridBQInOnlyMoney);
            this.gridBand11.Name = "gridBand11";
            this.gridBand11.Width = 78;
            // 
            // gridBQInOnlyMoney
            // 
            this.gridBQInOnlyMoney.Caption = "金额2";
            this.gridBQInOnlyMoney.DisplayFormat.FormatString = "0.######";
            this.gridBQInOnlyMoney.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridBQInOnlyMoney.FieldName = "BQInOnlyMoney";
            this.gridBQInOnlyMoney.MinWidth = 78;
            this.gridBQInOnlyMoney.Name = "gridBQInOnlyMoney";
            this.gridBQInOnlyMoney.OptionsColumn.AllowEdit = false;
            this.gridBQInOnlyMoney.SummaryItem.DisplayFormat = "{0:n2}";
            this.gridBQInOnlyMoney.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridBQInOnlyMoney.Visible = true;
            this.gridBQInOnlyMoney.Width = 78;
            // 
            // gridBand6
            // 
            this.gridBand6.Caption = "本期发出";
            this.gridBand6.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand12,
            this.gridBand13});
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.Width = 138;
            // 
            // gridBand12
            // 
            this.gridBand12.Caption = "数量";
            this.gridBand12.Columns.Add(this.gridBQOutOnlySum);
            this.gridBand12.Name = "gridBand12";
            this.gridBand12.Width = 78;
            // 
            // gridBQOutOnlySum
            // 
            this.gridBQOutOnlySum.Caption = "数量3";
            this.gridBQOutOnlySum.DisplayFormat.FormatString = "0.######";
            this.gridBQOutOnlySum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridBQOutOnlySum.FieldName = "BQOutOnlySum";
            this.gridBQOutOnlySum.MinWidth = 78;
            this.gridBQOutOnlySum.Name = "gridBQOutOnlySum";
            this.gridBQOutOnlySum.OptionsColumn.AllowEdit = false;
            this.gridBQOutOnlySum.SummaryItem.DisplayFormat = "{0:n2}";
            this.gridBQOutOnlySum.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridBQOutOnlySum.Visible = true;
            this.gridBQOutOnlySum.Width = 78;
            // 
            // gridBand13
            // 
            this.gridBand13.Caption = "金额(不含税)";
            this.gridBand13.Columns.Add(this.gridBQOutOnlyMoney);
            this.gridBand13.Name = "gridBand13";
            this.gridBand13.Width = 60;
            // 
            // gridBQOutOnlyMoney
            // 
            this.gridBQOutOnlyMoney.Caption = "金额3";
            this.gridBQOutOnlyMoney.DisplayFormat.FormatString = "0.######";
            this.gridBQOutOnlyMoney.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridBQOutOnlyMoney.FieldName = "BQOutOnlyMoney";
            this.gridBQOutOnlyMoney.MinWidth = 60;
            this.gridBQOutOnlyMoney.Name = "gridBQOutOnlyMoney";
            this.gridBQOutOnlyMoney.OptionsColumn.AllowEdit = false;
            this.gridBQOutOnlyMoney.SummaryItem.DisplayFormat = "{0:n2}";
            this.gridBQOutOnlyMoney.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridBQOutOnlyMoney.Visible = true;
            this.gridBQOutOnlyMoney.Width = 60;
            // 
            // gridBand7
            // 
            this.gridBand7.Caption = "期末结存";
            this.gridBand7.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand14,
            this.gridBand15});
            this.gridBand7.Name = "gridBand7";
            this.gridBand7.Width = 110;
            // 
            // gridBand14
            // 
            this.gridBand14.Caption = "数量";
            this.gridBand14.Columns.Add(this.gridJCOnlySum);
            this.gridBand14.Name = "gridBand14";
            this.gridBand14.Width = 53;
            // 
            // gridJCOnlySum
            // 
            this.gridJCOnlySum.Caption = "数量4";
            this.gridJCOnlySum.DisplayFormat.FormatString = "0.######";
            this.gridJCOnlySum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridJCOnlySum.FieldName = "JCOnlySum";
            this.gridJCOnlySum.MinWidth = 53;
            this.gridJCOnlySum.Name = "gridJCOnlySum";
            this.gridJCOnlySum.OptionsColumn.AllowEdit = false;
            this.gridJCOnlySum.SummaryItem.DisplayFormat = "{0:n2}";
            this.gridJCOnlySum.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridJCOnlySum.Visible = true;
            this.gridJCOnlySum.Width = 53;
            // 
            // gridBand15
            // 
            this.gridBand15.Caption = "金额(不含税)";
            this.gridBand15.Columns.Add(this.gridJCOnlyMoney);
            this.gridBand15.Name = "gridBand15";
            this.gridBand15.Width = 57;
            // 
            // gridJCOnlyMoney
            // 
            this.gridJCOnlyMoney.Caption = "金额4";
            this.gridJCOnlyMoney.DisplayFormat.FormatString = "0.######";
            this.gridJCOnlyMoney.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridJCOnlyMoney.FieldName = "JCOnlyMoney";
            this.gridJCOnlyMoney.MinWidth = 57;
            this.gridJCOnlyMoney.Name = "gridJCOnlyMoney";
            this.gridJCOnlyMoney.OptionsColumn.AllowEdit = false;
            this.gridJCOnlyMoney.SummaryItem.DisplayFormat = "{0:n2}";
            this.gridJCOnlyMoney.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridJCOnlyMoney.Visible = true;
            this.gridJCOnlyMoney.Width = 57;
            // 
            // txtGuid
            // 
            this.txtGuid.Location = new System.Drawing.Point(725, 28);
            this.txtGuid.Name = "txtGuid";
            this.txtGuid.Size = new System.Drawing.Size(36, 21);
            this.txtGuid.TabIndex = 56;
            this.txtGuid.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkView2);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.txtSupplier);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.chkView);
            this.panel1.Controls.Add(this.txtMaterialName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSelectStorage);
            this.panel1.Controls.Add(this.txtStorage);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnSelectMaterialGuid);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpBeginDate);
            this.panel1.Controls.Add(this.txtMaterialGuid);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnSelectMaterialType);
            this.panel1.Controls.Add(this.txtMaterialType);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpEndDate);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnQty);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 128);
            this.panel1.TabIndex = 114;
            // 
            // chkView2
            // 
            this.chkView2.AutoSize = true;
            this.chkView2.Location = new System.Drawing.Point(555, 104);
            this.chkView2.Name = "chkView2";
            this.chkView2.Size = new System.Drawing.Size(198, 16);
            this.chkView2.TabIndex = 180;
            this.chkView2.Text = "期初、进出、结存都为0的不显示";
            this.chkView2.UseVisualStyleBackColor = true;
            this.chkView2.CheckedChanged += new System.EventHandler(this.chkView2_CheckedChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelect.BackgroundImage")));
            this.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelect.Location = new System.Drawing.Point(198, 97);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(27, 24);
            this.btnSelect.TabIndex = 179;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtSupplier
            // 
            this.txtSupplier.BackColor = System.Drawing.Color.White;
            this.txtSupplier.Location = new System.Drawing.Point(85, 99);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.ReadOnly = true;
            this.txtSupplier.Size = new System.Drawing.Size(116, 21);
            this.txtSupplier.TabIndex = 178;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 177;
            this.label13.Text = "供应商";
            // 
            // chkView
            // 
            this.chkView.AutoSize = true;
            this.chkView.Location = new System.Drawing.Point(435, 104);
            this.chkView.Name = "chkView";
            this.chkView.Size = new System.Drawing.Size(114, 16);
            this.chkView.TabIndex = 168;
            this.chkView.Text = "进出都为0的显示";
            this.chkView.UseVisualStyleBackColor = true;
            this.chkView.CheckedChanged += new System.EventHandler(this.chkView_CheckedChanged);
            // 
            // txtMaterialName
            // 
            this.txtMaterialName.BackColor = System.Drawing.Color.White;
            this.txtMaterialName.Location = new System.Drawing.Point(291, 72);
            this.txtMaterialName.Name = "txtMaterialName";
            this.txtMaterialName.ReadOnly = true;
            this.txtMaterialName.Size = new System.Drawing.Size(110, 21);
            this.txtMaterialName.TabIndex = 166;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 167;
            this.label2.Text = "物料名称";
            // 
            // btnSelectStorage
            // 
            this.btnSelectStorage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectStorage.BackgroundImage")));
            this.btnSelectStorage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectStorage.Location = new System.Drawing.Point(197, 37);
            this.btnSelectStorage.Name = "btnSelectStorage";
            this.btnSelectStorage.Size = new System.Drawing.Size(25, 22);
            this.btnSelectStorage.TabIndex = 165;
            this.btnSelectStorage.UseVisualStyleBackColor = true;
            this.btnSelectStorage.Click += new System.EventHandler(this.btnSelectStorage_Click);
            // 
            // txtStorage
            // 
            this.txtStorage.BackColor = System.Drawing.Color.White;
            this.txtStorage.Location = new System.Drawing.Point(85, 38);
            this.txtStorage.Name = "txtStorage";
            this.txtStorage.ReadOnly = true;
            this.txtStorage.Size = new System.Drawing.Size(116, 21);
            this.txtStorage.TabIndex = 163;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 164;
            this.label5.Text = "仓库名称";
            // 
            // btnSelectMaterialGuid
            // 
            this.btnSelectMaterialGuid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectMaterialGuid.BackgroundImage")));
            this.btnSelectMaterialGuid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectMaterialGuid.Location = new System.Drawing.Point(197, 69);
            this.btnSelectMaterialGuid.Name = "btnSelectMaterialGuid";
            this.btnSelectMaterialGuid.Size = new System.Drawing.Size(25, 22);
            this.btnSelectMaterialGuid.TabIndex = 162;
            this.btnSelectMaterialGuid.UseVisualStyleBackColor = true;
            this.btnSelectMaterialGuid.Click += new System.EventHandler(this.btnSelectMaterialGuid_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 161;
            this.label3.Text = "开始日期";
            // 
            // dtpBeginDate
            // 
            this.dtpBeginDate.EditValue = null;
            this.dtpBeginDate.Location = new System.Drawing.Point(291, 38);
            this.dtpBeginDate.Name = "dtpBeginDate";
            this.dtpBeginDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dtpBeginDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpBeginDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpBeginDate.Size = new System.Drawing.Size(110, 21);
            this.dtpBeginDate.TabIndex = 160;
            // 
            // txtMaterialGuid
            // 
            this.txtMaterialGuid.BackColor = System.Drawing.Color.White;
            this.txtMaterialGuid.Location = new System.Drawing.Point(85, 70);
            this.txtMaterialGuid.Name = "txtMaterialGuid";
            this.txtMaterialGuid.ReadOnly = true;
            this.txtMaterialGuid.Size = new System.Drawing.Size(116, 21);
            this.txtMaterialGuid.TabIndex = 158;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 159;
            this.label7.Text = "物料编号";
            // 
            // btnSelectMaterialType
            // 
            this.btnSelectMaterialType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectMaterialType.BackgroundImage")));
            this.btnSelectMaterialType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectMaterialType.Location = new System.Drawing.Point(594, 68);
            this.btnSelectMaterialType.Name = "btnSelectMaterialType";
            this.btnSelectMaterialType.Size = new System.Drawing.Size(25, 22);
            this.btnSelectMaterialType.TabIndex = 154;
            this.btnSelectMaterialType.UseVisualStyleBackColor = true;
            this.btnSelectMaterialType.Click += new System.EventHandler(this.btnSelectMaterialType_Click);
            // 
            // txtMaterialType
            // 
            this.txtMaterialType.BackColor = System.Drawing.Color.White;
            this.txtMaterialType.Location = new System.Drawing.Point(490, 69);
            this.txtMaterialType.Name = "txtMaterialType";
            this.txtMaterialType.ReadOnly = true;
            this.txtMaterialType.Size = new System.Drawing.Size(105, 21);
            this.txtMaterialType.TabIndex = 152;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 153;
            this.label4.Text = "货品分类";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 148;
            this.label1.Text = "-->";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.EditValue = null;
            this.dtpEndDate.Location = new System.Drawing.Point(490, 38);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dtpEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpEndDate.Size = new System.Drawing.Size(130, 21);
            this.dtpEndDate.TabIndex = 147;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(756, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 26);
            this.button1.TabIndex = 135;
            this.button1.Text = "重置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnQty
            // 
            this.btnQty.Location = new System.Drawing.Point(648, 55);
            this.btnQty.Name = "btnQty";
            this.btnQty.Size = new System.Drawing.Size(83, 26);
            this.btnQty.TabIndex = 133;
            this.btnQty.Text = "查询";
            this.btnQty.UseVisualStyleBackColor = true;
            this.btnQty.Click += new System.EventHandler(this.btnQty_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-204, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 131;
            this.label6.Text = "开始日期";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPrint,
            this.tsbExport,
            this.exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1031, 25);
            this.toolStrip1.TabIndex = 151;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbPrint
            // 
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(49, 22);
            this.tsbPrint.Text = "打印";
            this.tsbPrint.Click += new System.EventHandler(this.tsbPrint_Click);
            // 
            // tsbExport
            // 
            this.tsbExport.Image = ((System.Drawing.Image)(resources.GetObject("tsbExport.Image")));
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(79, 22);
            this.tsbExport.Text = "导出EXCEL";
            this.tsbExport.Click += new System.EventHandler(this.tsbExport_Click);
            // 
            // exit
            // 
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(49, 22);
            this.exit.Text = "退出";
            this.exit.Click += new System.EventHandler(this.exit_Click_1);
            // 
            // frmDepotMaterialInOutSum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 558);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtGuid);
            this.Name = "frmDepotMaterialInOutSum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "收发存汇总表";
            this.Load += new System.EventHandler(this.frmBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBeginDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBeginDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.TextBox txtGuid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dtpEndDate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridMaterialID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridMaterialName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridSpec;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridQCOnlySum;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridQCOnlyMoney;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridBQInOnlySum;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridBQInOnlyMoney;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridBQOutOnlySum;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridBQOutOnlyMoney;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridJCOnlySum;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridJCOnlyMoney;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand8;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand9;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand10;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand11;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand12;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand13;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand7;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand14;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand15;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.ToolStripButton exit;
        private System.Windows.Forms.Button btnSelectMaterialType;
        private System.Windows.Forms.TextBox txtMaterialType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaterialName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectStorage;
        private System.Windows.Forms.TextBox txtStorage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelectMaterialGuid;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit dtpBeginDate;
        private System.Windows.Forms.TextBox txtMaterialGuid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkView;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand16;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedSupplierName;
        private System.Windows.Forms.CheckBox chkView2;
    }
}