﻿namespace ErpManage
{
    partial class frmBomMRPAdd
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBomMRPAdd));
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.btnClientOrderSelect = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridClientOrderDetailGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridClientOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridClientOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridYCMaterialSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridMaterialGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridMaterialGuidDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialIDDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialNameDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUnitDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSpecDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialSumDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridStorageSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridStorageMaterialSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridOnlySum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbsave = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.BeginDate = new DevExpress.XtraEditors.DateEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMRPPlanID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDelDetail = new System.Windows.Forms.Button();
            this.txtMaterialMRPPlanGuid = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStorageView = new System.Windows.Forms.Button();
            this.btnJS = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddMaterial = new System.Windows.Forms.Button();
            this.btnStock2 = new System.Windows.Forms.Button();
            this.btnDeleteCalcMaterial = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BeginDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginDate.Properties)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // btnClientOrderSelect
            // 
            this.btnClientOrderSelect.Location = new System.Drawing.Point(12, 15);
            this.btnClientOrderSelect.Name = "btnClientOrderSelect";
            this.btnClientOrderSelect.Size = new System.Drawing.Size(96, 24);
            this.btnClientOrderSelect.TabIndex = 0;
            this.btnClientOrderSelect.Text = "客户订单选择";
            this.btnClientOrderSelect.UseVisualStyleBackColor = true;
            this.btnClientOrderSelect.Click += new System.EventHandler(this.btnClientOrderSelect_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 57);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemSpinEdit1});
            this.gridControl1.Size = new System.Drawing.Size(768, 398);
            this.gridControl1.TabIndex = 57;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridClientOrderDetailGuid,
            this.gridClientOrderID,
            this.gridClientOrderDate,
            this.gridMaterialID,
            this.gridMaterialName,
            this.gridSpec,
            this.gridMaterialSum,
            this.gridYCMaterialSum,
            this.gridMaterialGuid});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridClientOrderDetailGuid
            // 
            this.gridClientOrderDetailGuid.Caption = "ClientOrderDetailGuid";
            this.gridClientOrderDetailGuid.FieldName = "ClientOrderDetailGuid";
            this.gridClientOrderDetailGuid.Name = "gridClientOrderDetailGuid";
            this.gridClientOrderDetailGuid.Width = 66;
            // 
            // gridClientOrderID
            // 
            this.gridClientOrderID.Caption = "客户订单编号";
            this.gridClientOrderID.FieldName = "ClientOrderID";
            this.gridClientOrderID.Name = "gridClientOrderID";
            this.gridClientOrderID.OptionsColumn.AllowEdit = false;
            this.gridClientOrderID.Visible = true;
            this.gridClientOrderID.VisibleIndex = 0;
            this.gridClientOrderID.Width = 103;
            // 
            // gridClientOrderDate
            // 
            this.gridClientOrderDate.Caption = "下单日期";
            this.gridClientOrderDate.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.gridClientOrderDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridClientOrderDate.FieldName = "ClientOrderDate";
            this.gridClientOrderDate.Name = "gridClientOrderDate";
            this.gridClientOrderDate.OptionsColumn.AllowEdit = false;
            this.gridClientOrderDate.Visible = true;
            this.gridClientOrderDate.VisibleIndex = 1;
            this.gridClientOrderDate.Width = 83;
            // 
            // gridMaterialID
            // 
            this.gridMaterialID.Caption = "物料编号";
            this.gridMaterialID.FieldName = "MaterialID";
            this.gridMaterialID.Name = "gridMaterialID";
            this.gridMaterialID.OptionsColumn.AllowEdit = false;
            this.gridMaterialID.Visible = true;
            this.gridMaterialID.VisibleIndex = 2;
            this.gridMaterialID.Width = 120;
            // 
            // gridMaterialName
            // 
            this.gridMaterialName.Caption = "物料名称";
            this.gridMaterialName.FieldName = "MaterialName";
            this.gridMaterialName.Name = "gridMaterialName";
            this.gridMaterialName.OptionsColumn.AllowEdit = false;
            this.gridMaterialName.Visible = true;
            this.gridMaterialName.VisibleIndex = 3;
            this.gridMaterialName.Width = 114;
            // 
            // gridSpec
            // 
            this.gridSpec.Caption = "规格";
            this.gridSpec.FieldName = "Spec";
            this.gridSpec.Name = "gridSpec";
            this.gridSpec.OptionsColumn.AllowEdit = false;
            this.gridSpec.Visible = true;
            this.gridSpec.VisibleIndex = 4;
            this.gridSpec.Width = 67;
            // 
            // gridMaterialSum
            // 
            this.gridMaterialSum.Caption = "客户订单数量";
            this.gridMaterialSum.DisplayFormat.FormatString = "0.###";
            this.gridMaterialSum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridMaterialSum.FieldName = "MaterialSum";
            this.gridMaterialSum.Name = "gridMaterialSum";
            this.gridMaterialSum.OptionsColumn.AllowEdit = false;
            this.gridMaterialSum.Visible = true;
            this.gridMaterialSum.VisibleIndex = 5;
            this.gridMaterialSum.Width = 93;
            // 
            // gridYCMaterialSum
            // 
            this.gridYCMaterialSum.Caption = "预测数量";
            this.gridYCMaterialSum.ColumnEdit = this.repositoryItemSpinEdit1;
            this.gridYCMaterialSum.FieldName = "YCMaterialSum";
            this.gridYCMaterialSum.Name = "gridYCMaterialSum";
            this.gridYCMaterialSum.Visible = true;
            this.gridYCMaterialSum.VisibleIndex = 6;
            this.gridYCMaterialSum.Width = 73;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.DisplayFormat.FormatString = "0.######";
            this.repositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.EditFormat.FormatString = "0.######";
            this.repositoryItemSpinEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.HideSelection = false;
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            this.repositoryItemSpinEdit1.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.repositoryItemSpinEdit1_Spin);
            // 
            // gridMaterialGuid
            // 
            this.gridMaterialGuid.Caption = "MaterialGuid";
            this.gridMaterialGuid.FieldName = "MaterialGuID";
            this.gridMaterialGuid.Name = "gridMaterialGuid";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl2.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl2.Location = new System.Drawing.Point(3, 51);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(768, 404);
            this.gridControl2.TabIndex = 64;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridMaterialGuidDetail,
            this.gridMaterialIDDetail,
            this.gridMaterialNameDetail,
            this.gridUnitDetail,
            this.gridSpecDetail,
            this.gridMaterialSumDetail,
            this.gridStorageSum,
            this.gridStorageMaterialSum,
            this.gridOnlySum});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridMaterialGuidDetail
            // 
            this.gridMaterialGuidDetail.Caption = "MaterialGuID";
            this.gridMaterialGuidDetail.FieldName = "MaterialGuID";
            this.gridMaterialGuidDetail.Name = "gridMaterialGuidDetail";
            this.gridMaterialGuidDetail.OptionsColumn.AllowEdit = false;
            // 
            // gridMaterialIDDetail
            // 
            this.gridMaterialIDDetail.Caption = "物料号";
            this.gridMaterialIDDetail.FieldName = "MaterialID";
            this.gridMaterialIDDetail.Name = "gridMaterialIDDetail";
            this.gridMaterialIDDetail.OptionsColumn.AllowEdit = false;
            this.gridMaterialIDDetail.Visible = true;
            this.gridMaterialIDDetail.VisibleIndex = 0;
            this.gridMaterialIDDetail.Width = 96;
            // 
            // gridMaterialNameDetail
            // 
            this.gridMaterialNameDetail.Caption = "物料名称";
            this.gridMaterialNameDetail.FieldName = "MaterialName";
            this.gridMaterialNameDetail.Name = "gridMaterialNameDetail";
            this.gridMaterialNameDetail.OptionsColumn.AllowEdit = false;
            this.gridMaterialNameDetail.Visible = true;
            this.gridMaterialNameDetail.VisibleIndex = 1;
            this.gridMaterialNameDetail.Width = 96;
            // 
            // gridUnitDetail
            // 
            this.gridUnitDetail.Caption = "单位";
            this.gridUnitDetail.FieldName = "Unit";
            this.gridUnitDetail.Name = "gridUnitDetail";
            this.gridUnitDetail.OptionsColumn.AllowEdit = false;
            this.gridUnitDetail.Visible = true;
            this.gridUnitDetail.VisibleIndex = 2;
            this.gridUnitDetail.Width = 96;
            // 
            // gridSpecDetail
            // 
            this.gridSpecDetail.Caption = "规格";
            this.gridSpecDetail.FieldName = "Spec";
            this.gridSpecDetail.Name = "gridSpecDetail";
            this.gridSpecDetail.OptionsColumn.AllowEdit = false;
            this.gridSpecDetail.Visible = true;
            this.gridSpecDetail.VisibleIndex = 3;
            this.gridSpecDetail.Width = 96;
            // 
            // gridMaterialSumDetail
            // 
            this.gridMaterialSumDetail.Caption = "毛需求量";
            this.gridMaterialSumDetail.DisplayFormat.FormatString = "0.###";
            this.gridMaterialSumDetail.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridMaterialSumDetail.FieldName = "RequirementSum";
            this.gridMaterialSumDetail.Name = "gridMaterialSumDetail";
            this.gridMaterialSumDetail.OptionsColumn.AllowEdit = false;
            this.gridMaterialSumDetail.Visible = true;
            this.gridMaterialSumDetail.VisibleIndex = 4;
            this.gridMaterialSumDetail.Width = 94;
            // 
            // gridStorageSum
            // 
            this.gridStorageSum.Caption = "折算量";
            this.gridStorageSum.DisplayFormat.FormatString = "0.###";
            this.gridStorageSum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridStorageSum.FieldName = "StorageSum";
            this.gridStorageSum.Name = "gridStorageSum";
            this.gridStorageSum.OptionsColumn.AllowEdit = false;
            this.gridStorageSum.Visible = true;
            this.gridStorageSum.VisibleIndex = 5;
            this.gridStorageSum.Width = 76;
            // 
            // gridStorageMaterialSum
            // 
            this.gridStorageMaterialSum.Caption = "库存量";
            this.gridStorageMaterialSum.DisplayFormat.FormatString = "0.###";
            this.gridStorageMaterialSum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridStorageMaterialSum.FieldName = "StorageMaterialSum";
            this.gridStorageMaterialSum.Name = "gridStorageMaterialSum";
            this.gridStorageMaterialSum.OptionsColumn.AllowEdit = false;
            this.gridStorageMaterialSum.Visible = true;
            this.gridStorageMaterialSum.VisibleIndex = 6;
            this.gridStorageMaterialSum.Width = 74;
            // 
            // gridOnlySum
            // 
            this.gridOnlySum.Caption = "净需求量(采购量)";
            this.gridOnlySum.DisplayFormat.FormatString = "0.###";
            this.gridOnlySum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridOnlySum.FieldName = "OnlySum";
            this.gridOnlySum.Name = "gridOnlySum";
            this.gridOnlySum.Visible = true;
            this.gridOnlySum.VisibleIndex = 7;
            this.gridOnlySum.Width = 119;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.tsbsave,
            this.btnDelete,
            this.tsbExport,
            this.toolStripSeparator1,
            this.exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(782, 25);
            this.toolStrip1.TabIndex = 59;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(49, 22);
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tsbsave
            // 
            this.tsbsave.Image = ((System.Drawing.Image)(resources.GetObject("tsbsave.Image")));
            this.tsbsave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbsave.Name = "tsbsave";
            this.tsbsave.Size = new System.Drawing.Size(49, 22);
            this.tsbsave.Text = "保存";
            this.tsbsave.Click += new System.EventHandler(this.tsbsave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(49, 22);
            this.btnDelete.Text = "删除";
            this.btnDelete.Visible = false;
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // BeginDate
            // 
            this.BeginDate.EditValue = null;
            this.BeginDate.Location = new System.Drawing.Point(375, 19);
            this.BeginDate.Name = "BeginDate";
            this.BeginDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.BeginDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BeginDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.BeginDate.Size = new System.Drawing.Size(122, 21);
            this.BeginDate.TabIndex = 147;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(304, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 146;
            this.label9.Text = "计算日期：";
            // 
            // txtMRPPlanID
            // 
            this.txtMRPPlanID.BackColor = System.Drawing.Color.White;
            this.txtMRPPlanID.Location = new System.Drawing.Point(122, 19);
            this.txtMRPPlanID.Name = "txtMRPPlanID";
            this.txtMRPPlanID.ReadOnly = true;
            this.txtMRPPlanID.Size = new System.Drawing.Size(132, 21);
            this.txtMRPPlanID.TabIndex = 145;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 12);
            this.label5.TabIndex = 144;
            this.label5.Text = "物料需求计划单号：";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(122, 49);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(379, 21);
            this.txtRemark.TabIndex = 149;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(75, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 148;
            this.label11.Text = "备注：";
            // 
            // btnDelDetail
            // 
            this.btnDelDetail.Location = new System.Drawing.Point(124, 15);
            this.btnDelDetail.Name = "btnDelDetail";
            this.btnDelDetail.Size = new System.Drawing.Size(75, 25);
            this.btnDelDetail.TabIndex = 151;
            this.btnDelDetail.Text = "删除明细";
            this.btnDelDetail.UseVisualStyleBackColor = true;
            this.btnDelDetail.Click += new System.EventHandler(this.btnDelDetail_Click);
            // 
            // txtMaterialMRPPlanGuid
            // 
            this.txtMaterialMRPPlanGuid.Location = new System.Drawing.Point(630, 7);
            this.txtMaterialMRPPlanGuid.Name = "txtMaterialMRPPlanGuid";
            this.txtMaterialMRPPlanGuid.Size = new System.Drawing.Size(41, 21);
            this.txtMaterialMRPPlanGuid.TabIndex = 153;
            this.txtMaterialMRPPlanGuid.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 119);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 483);
            this.tabControl1.TabIndex = 154;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridControl1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 458);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "客户订单";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClientOrderSelect);
            this.panel2.Controls.Add(this.btnStorageView);
            this.panel2.Controls.Add(this.btnDelDetail);
            this.panel2.Controls.Add(this.btnJS);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(768, 54);
            this.panel2.TabIndex = 156;
            // 
            // btnStorageView
            // 
            this.btnStorageView.Location = new System.Drawing.Point(345, 14);
            this.btnStorageView.Name = "btnStorageView";
            this.btnStorageView.Size = new System.Drawing.Size(91, 25);
            this.btnStorageView.TabIndex = 155;
            this.btnStorageView.Text = "库存相关";
            this.btnStorageView.UseVisualStyleBackColor = true;
            this.btnStorageView.Click += new System.EventHandler(this.btnStorageView_Click);
            // 
            // btnJS
            // 
            this.btnJS.Location = new System.Drawing.Point(218, 15);
            this.btnJS.Name = "btnJS";
            this.btnJS.Size = new System.Drawing.Size(98, 25);
            this.btnJS.TabIndex = 152;
            this.btnJS.Text = "计算";
            this.btnJS.UseVisualStyleBackColor = true;
            this.btnJS.Click += new System.EventHandler(this.btnJS_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridControl2);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(774, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "物料需求";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddMaterial);
            this.panel3.Controls.Add(this.btnStock2);
            this.panel3.Controls.Add(this.btnDeleteCalcMaterial);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(768, 48);
            this.panel3.TabIndex = 153;
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.Location = new System.Drawing.Point(23, 12);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(86, 23);
            this.btnAddMaterial.TabIndex = 157;
            this.btnAddMaterial.Text = "增加明细";
            this.btnAddMaterial.UseVisualStyleBackColor = true;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            // 
            // btnStock2
            // 
            this.btnStock2.Location = new System.Drawing.Point(232, 12);
            this.btnStock2.Name = "btnStock2";
            this.btnStock2.Size = new System.Drawing.Size(91, 25);
            this.btnStock2.TabIndex = 156;
            this.btnStock2.Text = "库存相关";
            this.btnStock2.UseVisualStyleBackColor = true;
            this.btnStock2.Click += new System.EventHandler(this.btnStock2_Click);
            // 
            // btnDeleteCalcMaterial
            // 
            this.btnDeleteCalcMaterial.Location = new System.Drawing.Point(135, 12);
            this.btnDeleteCalcMaterial.Name = "btnDeleteCalcMaterial";
            this.btnDeleteCalcMaterial.Size = new System.Drawing.Size(75, 25);
            this.btnDeleteCalcMaterial.TabIndex = 152;
            this.btnDeleteCalcMaterial.Text = "删除明细";
            this.btnDeleteCalcMaterial.UseVisualStyleBackColor = true;
            this.btnDeleteCalcMaterial.Click += new System.EventHandler(this.btnDeleteCalcMaterial_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMRPPlanID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMaterialMRPPlanGuid);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtRemark);
            this.panel1.Controls.Add(this.BeginDate);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 94);
            this.panel1.TabIndex = 155;
            // 
            // frmBomMRPAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 602);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmBomMRPAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物料需求计划MRP";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BeginDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginDate.Properties)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClientOrderSelect;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridClientOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridClientOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialID;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialName;
        private DevExpress.XtraGrid.Columns.GridColumn gridSpec;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialSum;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialGuidDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialIDDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialNameDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridUnitDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridSpecDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialSumDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridStorageSum;
        private DevExpress.XtraGrid.Columns.GridColumn gridOnlySum;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton tsbsave;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton exit;
        private DevExpress.XtraEditors.DateEdit BeginDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMRPPlanID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDelDetail;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridClientOrderDetailGuid;
        private DevExpress.XtraGrid.Columns.GridColumn gridYCMaterialSum;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private System.Windows.Forms.TextBox txtMaterialMRPPlanGuid;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnJS;
        private System.Windows.Forms.Button btnDeleteCalcMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialGuid;
        private System.Windows.Forms.Button btnStorageView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnStock2;
        private DevExpress.XtraGrid.Columns.GridColumn gridStorageMaterialSum;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.Button btnAddMaterial;
    }
}