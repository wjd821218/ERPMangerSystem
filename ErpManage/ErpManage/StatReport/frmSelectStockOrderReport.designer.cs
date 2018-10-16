namespace ErpManage.Business
{
    partial class frmSelectStockOrderReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectStockOrderReport));
            this.txtStockOrderID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EndDate = new DevExpress.XtraEditors.DateEdit();
            this.BeginDate = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQry = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridMaterialGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridStockOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSupplierName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridStockOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridStorageSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCanInSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridArriveDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridStockOrderDetailGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemSpinEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.chkEnd = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.EndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStockOrderID
            // 
            this.txtStockOrderID.Location = new System.Drawing.Point(82, 21);
            this.txtStockOrderID.Name = "txtStockOrderID";
            this.txtStockOrderID.Size = new System.Drawing.Size(102, 21);
            this.txtStockOrderID.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 60;
            this.label2.Text = "采购订单号：";
            // 
            // EndDate
            // 
            this.EndDate.EditValue = null;
            this.EndDate.Location = new System.Drawing.Point(402, 21);
            this.EndDate.Name = "EndDate";
            this.EndDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.EndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.EndDate.Size = new System.Drawing.Size(95, 21);
            this.EndDate.TabIndex = 134;
            // 
            // BeginDate
            // 
            this.BeginDate.EditValue = null;
            this.BeginDate.Location = new System.Drawing.Point(259, 21);
            this.BeginDate.Name = "BeginDate";
            this.BeginDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.BeginDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BeginDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.BeginDate.Size = new System.Drawing.Size(97, 21);
            this.BeginDate.TabIndex = 133;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 132;
            this.label1.Text = "下单日期";
            // 
            // btnQry
            // 
            this.btnQry.Location = new System.Drawing.Point(661, 19);
            this.btnQry.Name = "btnQry";
            this.btnQry.Size = new System.Drawing.Size(81, 23);
            this.btnQry.TabIndex = 138;
            this.btnQry.Text = "查询";
            this.btnQry.UseVisualStyleBackColor = true;
            this.btnQry.Click += new System.EventHandler(this.btnQry_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 141;
            this.label3.Text = "---->";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridControl2.Location = new System.Drawing.Point(0, 92);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalcEdit1,
            this.repositoryItemPopupContainerEdit1,
            this.repositoryItemSpinEdit1,
            this.repositoryItemSpinEdit2,
            this.repositoryItemSpinEdit3,
            this.repositoryItemCheckEdit1});
            this.gridControl2.Size = new System.Drawing.Size(925, 427);
            this.gridControl2.TabIndex = 145;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.FocusedRow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView2.Appearance.GroupFooter.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Appearance.RowSeparator.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.RowSeparator.Options.UseFont = true;
            this.gridView2.Appearance.SelectedRow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView2.Appearance.VertLine.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.VertLine.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridMaterialGuid,
            this.gridStockOrderID,
            this.gridSupplierName,
            this.gridStockOrderDate,
            this.gridMaterialID,
            this.gridMaterialName,
            this.gridSpec,
            this.gridUnit,
            this.gridMaterialSum,
            this.gridStorageSum,
            this.gridCanInSum,
            this.gridArriveDate,
            this.gridStockOrderDetailGuid});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.AllowCellMerge = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.CellMerge += new DevExpress.XtraGrid.Views.Grid.CellMergeEventHandler(this.gridView1_CellMerge);
            // 
            // gridMaterialGuid
            // 
            this.gridMaterialGuid.Caption = "MaterialGuid";
            this.gridMaterialGuid.FieldName = "MaterialGuID";
            this.gridMaterialGuid.Name = "gridMaterialGuid";
            this.gridMaterialGuid.OptionsColumn.AllowEdit = false;
            // 
            // gridStockOrderID
            // 
            this.gridStockOrderID.Caption = "采购订单号";
            this.gridStockOrderID.FieldName = "StockOrderID";
            this.gridStockOrderID.Name = "gridStockOrderID";
            this.gridStockOrderID.OptionsColumn.AllowEdit = false;
            this.gridStockOrderID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.gridStockOrderID.Visible = true;
            this.gridStockOrderID.VisibleIndex = 0;
            this.gridStockOrderID.Width = 94;
            // 
            // gridSupplierName
            // 
            this.gridSupplierName.Caption = "供应商";
            this.gridSupplierName.FieldName = "SupplierName";
            this.gridSupplierName.Name = "gridSupplierName";
            this.gridSupplierName.OptionsColumn.AllowEdit = false;
            this.gridSupplierName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.gridSupplierName.Visible = true;
            this.gridSupplierName.VisibleIndex = 1;
            this.gridSupplierName.Width = 69;
            // 
            // gridStockOrderDate
            // 
            this.gridStockOrderDate.Caption = "开单日期";
            this.gridStockOrderDate.FieldName = "StockOrderDate";
            this.gridStockOrderDate.Name = "gridStockOrderDate";
            this.gridStockOrderDate.OptionsColumn.AllowEdit = false;
            this.gridStockOrderDate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.gridStockOrderDate.Visible = true;
            this.gridStockOrderDate.VisibleIndex = 2;
            this.gridStockOrderDate.Width = 69;
            // 
            // gridMaterialID
            // 
            this.gridMaterialID.Caption = "物料编号";
            this.gridMaterialID.FieldName = "MaterialID";
            this.gridMaterialID.Name = "gridMaterialID";
            this.gridMaterialID.OptionsColumn.AllowEdit = false;
            this.gridMaterialID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridMaterialID.Visible = true;
            this.gridMaterialID.VisibleIndex = 3;
            this.gridMaterialID.Width = 110;
            // 
            // gridMaterialName
            // 
            this.gridMaterialName.Caption = "物料名称";
            this.gridMaterialName.FieldName = "MaterialName";
            this.gridMaterialName.Name = "gridMaterialName";
            this.gridMaterialName.OptionsColumn.AllowEdit = false;
            this.gridMaterialName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridMaterialName.Visible = true;
            this.gridMaterialName.VisibleIndex = 4;
            this.gridMaterialName.Width = 119;
            // 
            // gridSpec
            // 
            this.gridSpec.Caption = "规格";
            this.gridSpec.FieldName = "Spec";
            this.gridSpec.Name = "gridSpec";
            this.gridSpec.OptionsColumn.AllowEdit = false;
            this.gridSpec.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridSpec.Visible = true;
            this.gridSpec.VisibleIndex = 5;
            this.gridSpec.Width = 52;
            // 
            // gridUnit
            // 
            this.gridUnit.Caption = "单位";
            this.gridUnit.FieldName = "Unit";
            this.gridUnit.Name = "gridUnit";
            this.gridUnit.OptionsColumn.AllowEdit = false;
            this.gridUnit.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridUnit.Visible = true;
            this.gridUnit.VisibleIndex = 6;
            this.gridUnit.Width = 58;
            // 
            // gridMaterialSum
            // 
            this.gridMaterialSum.Caption = "订单数量";
            this.gridMaterialSum.ColumnEdit = this.repositoryItemSpinEdit2;
            this.gridMaterialSum.FieldName = "MaterialSum";
            this.gridMaterialSum.MinWidth = 85;
            this.gridMaterialSum.Name = "gridMaterialSum";
            this.gridMaterialSum.OptionsColumn.AllowEdit = false;
            this.gridMaterialSum.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridMaterialSum.Visible = true;
            this.gridMaterialSum.VisibleIndex = 7;
            this.gridMaterialSum.Width = 85;
            // 
            // repositoryItemSpinEdit2
            // 
            this.repositoryItemSpinEdit2.AutoHeight = false;
            this.repositoryItemSpinEdit2.DisplayFormat.FormatString = "0.###";
            this.repositoryItemSpinEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit2.EditFormat.FormatString = "0.###";
            this.repositoryItemSpinEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit2.HideSelection = false;
            this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
            // 
            // gridStorageSum
            // 
            this.gridStorageSum.Caption = "已入数量";
            this.gridStorageSum.DisplayFormat.FormatString = "0.###";
            this.gridStorageSum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridStorageSum.FieldName = "StorageSum";
            this.gridStorageSum.MinWidth = 85;
            this.gridStorageSum.Name = "gridStorageSum";
            this.gridStorageSum.OptionsColumn.AllowEdit = false;
            this.gridStorageSum.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridStorageSum.Visible = true;
            this.gridStorageSum.VisibleIndex = 8;
            this.gridStorageSum.Width = 85;
            // 
            // gridCanInSum
            // 
            this.gridCanInSum.Caption = "可入数量";
            this.gridCanInSum.DisplayFormat.FormatString = "0.###";
            this.gridCanInSum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridCanInSum.FieldName = "CanInSum";
            this.gridCanInSum.MinWidth = 85;
            this.gridCanInSum.Name = "gridCanInSum";
            this.gridCanInSum.OptionsColumn.AllowEdit = false;
            this.gridCanInSum.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridCanInSum.Visible = true;
            this.gridCanInSum.VisibleIndex = 9;
            this.gridCanInSum.Width = 85;
            // 
            // gridArriveDate
            // 
            this.gridArriveDate.Caption = "到货时间";
            this.gridArriveDate.FieldName = "ArriveDate";
            this.gridArriveDate.Name = "gridArriveDate";
            this.gridArriveDate.OptionsColumn.AllowEdit = false;
            this.gridArriveDate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridArriveDate.Visible = true;
            this.gridArriveDate.VisibleIndex = 10;
            this.gridArriveDate.Width = 78;
            // 
            // gridStockOrderDetailGuid
            // 
            this.gridStockOrderDetailGuid.Caption = "StockOrderDetailGuid";
            this.gridStockOrderDetailGuid.FieldName = "StockOrderDetailGuid";
            this.gridStockOrderDetailGuid.Name = "gridStockOrderDetailGuid";
            this.gridStockOrderDetailGuid.OptionsColumn.AllowEdit = false;
            this.gridStockOrderDetailGuid.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            this.repositoryItemCalcEdit1.ShowPopupShadow = false;
            this.repositoryItemCalcEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // repositoryItemPopupContainerEdit1
            // 
            this.repositoryItemPopupContainerEdit1.AutoHeight = false;
            this.repositoryItemPopupContainerEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPopupContainerEdit1.Name = "repositoryItemPopupContainerEdit1";
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.DisplayFormat.FormatString = "0.###";
            this.repositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.EditFormat.FormatString = "0.###";
            this.repositoryItemSpinEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.HideSelection = false;
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // repositoryItemSpinEdit3
            // 
            this.repositoryItemSpinEdit3.AutoHeight = false;
            this.repositoryItemSpinEdit3.DisplayFormat.FormatString = "0.######";
            this.repositoryItemSpinEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit3.EditFormat.FormatString = "0.######";
            this.repositoryItemSpinEdit3.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit3.Name = "repositoryItemSpinEdit3";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.RadioGroupIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkEnd);
            this.panel1.Controls.Add(this.txtStockOrderID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnQry);
            this.panel1.Controls.Add(this.BeginDate);
            this.panel1.Controls.Add(this.EndDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 67);
            this.panel1.TabIndex = 146;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExport,
            this.tsbPrint,
            this.toolStripSeparator2,
            this.exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(925, 25);
            this.toolStrip1.TabIndex = 148;
            this.toolStrip1.Text = "toolStrip1";
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
            // tsbPrint
            // 
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(49, 22);
            this.tsbPrint.Text = "打印";
            this.tsbPrint.Click += new System.EventHandler(this.tsbPrint_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // exit
            // 
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(49, 22);
            this.exit.Text = "退出";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // chkEnd
            // 
            this.chkEnd.AutoSize = true;
            this.chkEnd.Location = new System.Drawing.Point(525, 26);
            this.chkEnd.Name = "chkEnd";
            this.chkEnd.Size = new System.Drawing.Size(60, 16);
            this.chkEnd.TabIndex = 142;
            this.chkEnd.Text = "已结单";
            this.chkEnd.UseVisualStyleBackColor = true;
            // 
            // frmSelectStockOrderReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 519);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmSelectStockOrderReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "采购订单执行情况报表";
            this.Load += new System.EventHandler(this.frmSelectProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStockOrderID;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit EndDate;
        private DevExpress.XtraEditors.DateEdit BeginDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQry;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialGuid;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialID;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialName;
        private DevExpress.XtraGrid.Columns.GridColumn gridSpec;
        private DevExpress.XtraGrid.Columns.GridColumn gridUnit;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialSum;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridArriveDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridStockOrderDetailGuid;
        private DevExpress.XtraGrid.Columns.GridColumn gridStorageSum;
        private DevExpress.XtraGrid.Columns.GridColumn gridCanInSum;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Columns.GridColumn gridStockOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn gridSupplierName;
        private DevExpress.XtraGrid.Columns.GridColumn gridStockOrderDate;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton exit;
        private System.Windows.Forms.CheckBox chkEnd;
    }
}