namespace ErpManage.Business
{
    partial class frmSelectMRPPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectMRPPlan));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.txtMaterialMRPPlanID = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EndDate = new DevExpress.XtraEditors.DateEdit();
            this.BeginDate = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQry = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridMaterialMRPPlanID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialMRPPlanDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialMRPPlanGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelectSupplier = new System.Windows.Forms.Button();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridMaterialGuidDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialIDDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialNameDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUnitDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSpecDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialSumDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridStorageSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridStorageMaterialSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridOnlySum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtSelectGuid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaterialMRPPlanID
            // 
            this.txtMaterialMRPPlanID.Location = new System.Drawing.Point(112, 22);
            this.txtMaterialMRPPlanID.Name = "txtMaterialMRPPlanID";
            this.txtMaterialMRPPlanID.Size = new System.Drawing.Size(102, 21);
            this.txtMaterialMRPPlanID.TabIndex = 59;
            this.txtMaterialMRPPlanID.TextChanged += new System.EventHandler(this.txtQryValue_TextChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(628, 20);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(70, 23);
            this.btnSelect.TabIndex = 61;
            this.btnSelect.Text = "选定";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 60;
            this.label2.Text = "物料需求计划单号：";
            // 
            // EndDate
            // 
            this.EndDate.EditValue = null;
            this.EndDate.Location = new System.Drawing.Point(411, 22);
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
            this.BeginDate.Location = new System.Drawing.Point(270, 22);
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
            this.label1.Location = new System.Drawing.Point(216, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 132;
            this.label1.Text = "计算日期";
            // 
            // btnQry
            // 
            this.btnQry.Location = new System.Drawing.Point(535, 20);
            this.btnQry.Name = "btnQry";
            this.btnQry.Size = new System.Drawing.Size(69, 23);
            this.btnQry.TabIndex = 138;
            this.btnQry.Text = "查询";
            this.btnQry.UseVisualStyleBackColor = true;
            this.btnQry.Click += new System.EventHandler(this.btnQry_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 141;
            this.label3.Text = "---->";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 61);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemSpinEdit1,
            this.repositoryItemCheckEdit2});
            this.gridControl1.Size = new System.Drawing.Size(832, 136);
            this.gridControl1.TabIndex = 142;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick_1);
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridMaterialMRPPlanID,
            this.gridMaterialMRPPlanDate,
            this.gridRemark,
            this.gridMaterialMRPPlanGuid});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            // 
            // gridMaterialMRPPlanID
            // 
            this.gridMaterialMRPPlanID.Caption = "物料需求计划单号";
            this.gridMaterialMRPPlanID.FieldName = "MaterialMRPPlanID";
            this.gridMaterialMRPPlanID.Name = "gridMaterialMRPPlanID";
            this.gridMaterialMRPPlanID.OptionsColumn.AllowEdit = false;
            this.gridMaterialMRPPlanID.Visible = true;
            this.gridMaterialMRPPlanID.VisibleIndex = 0;
            this.gridMaterialMRPPlanID.Width = 137;
            // 
            // gridMaterialMRPPlanDate
            // 
            this.gridMaterialMRPPlanDate.Caption = "计算日期";
            this.gridMaterialMRPPlanDate.FieldName = "MaterialMRPPlanDate";
            this.gridMaterialMRPPlanDate.Name = "gridMaterialMRPPlanDate";
            this.gridMaterialMRPPlanDate.OptionsColumn.AllowEdit = false;
            this.gridMaterialMRPPlanDate.Visible = true;
            this.gridMaterialMRPPlanDate.VisibleIndex = 1;
            this.gridMaterialMRPPlanDate.Width = 101;
            // 
            // gridRemark
            // 
            this.gridRemark.Caption = "备注";
            this.gridRemark.FieldName = "Remark";
            this.gridRemark.Name = "gridRemark";
            this.gridRemark.OptionsColumn.AllowEdit = false;
            this.gridRemark.Visible = true;
            this.gridRemark.VisibleIndex = 2;
            this.gridRemark.Width = 349;
            // 
            // gridMaterialMRPPlanGuid
            // 
            this.gridMaterialMRPPlanGuid.Caption = "MaterialMRPPlanGuid";
            this.gridMaterialMRPPlanGuid.FieldName = "MaterialMRPPlanGuid";
            this.gridMaterialMRPPlanGuid.Name = "gridMaterialMRPPlanGuid";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit1.DisplayFormat.FormatString = "0.###";
            this.repositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.EditFormat.FormatString = "0.###";
            this.repositoryItemSpinEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            this.repositoryItemSpinEdit1.ReadOnly = true;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.RadioGroupIndex = 1;
            this.repositoryItemCheckEdit2.QueryCheckStateByValue += new DevExpress.XtraEditors.Controls.QueryCheckStateByValueEventHandler(this.repositoryItemCheckEdit1_QueryCheckStateByValue);
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(3, 215);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit4,
            this.repositoryItemSpinEdit2,
            this.repositoryItemCheckEdit3});
            this.gridControl2.Size = new System.Drawing.Size(832, 121);
            this.gridControl2.TabIndex = 143;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "物料编号";
            this.gridColumn5.FieldName = "MaterialID";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            this.gridColumn5.Width = 115;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "物料名称";
            this.gridColumn6.FieldName = "MaterialName";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 110;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "规格";
            this.gridColumn7.FieldName = "Spec";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            this.gridColumn7.Width = 63;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "客户订单数量";
            this.gridColumn8.DisplayFormat.FormatString = "0.###";
            this.gridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn8.FieldName = "MaterialSum";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 3;
            this.gridColumn8.Width = 89;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "预测数量";
            this.gridColumn9.DisplayFormat.FormatString = "0.###";
            this.gridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn9.FieldName = "YCMaterialSum";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 4;
            this.gridColumn9.Width = 92;
            // 
            // repositoryItemCheckEdit4
            // 
            this.repositoryItemCheckEdit4.AutoHeight = false;
            this.repositoryItemCheckEdit4.Name = "repositoryItemCheckEdit4";
            // 
            // repositoryItemSpinEdit2
            // 
            this.repositoryItemSpinEdit2.AutoHeight = false;
            this.repositoryItemSpinEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit2.DisplayFormat.FormatString = "0.###";
            this.repositoryItemSpinEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit2.EditFormat.FormatString = "0.###";
            this.repositoryItemSpinEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
            this.repositoryItemSpinEdit2.ReadOnly = true;
            // 
            // repositoryItemCheckEdit3
            // 
            this.repositoryItemCheckEdit3.AutoHeight = false;
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 144;
            this.label4.Text = "物料需求计划明细：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 146;
            this.label5.Text = "物料明细列表：";
            // 
            // btnSelectSupplier
            // 
            this.btnSelectSupplier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectSupplier.BackgroundImage")));
            this.btnSelectSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectSupplier.Location = new System.Drawing.Point(340, 352);
            this.btnSelectSupplier.Name = "btnSelectSupplier";
            this.btnSelectSupplier.Size = new System.Drawing.Size(27, 24);
            this.btnSelectSupplier.TabIndex = 149;
            this.btnSelectSupplier.UseVisualStyleBackColor = true;
            this.btnSelectSupplier.Click += new System.EventHandler(this.btnSelectSupplier_Click);
            // 
            // txtSupplier
            // 
            this.txtSupplier.BackColor = System.Drawing.Color.White;
            this.txtSupplier.Location = new System.Drawing.Point(159, 354);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.ReadOnly = true;
            this.txtSupplier.Size = new System.Drawing.Size(186, 21);
            this.txtSupplier.TabIndex = 148;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(105, 358);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 147;
            this.label13.Text = "供应商：";
            // 
            // gridControl3
            // 
            gridLevelNode1.RelationName = "Level1";
            this.gridControl3.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl3.Location = new System.Drawing.Point(3, 382);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(832, 291);
            this.gridControl3.TabIndex = 150;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridMaterialGuidDetail,
            this.gridMaterialIDDetail,
            this.gridMaterialNameDetail,
            this.gridUnitDetail,
            this.gridSpecDetail,
            this.gridMaterialSumDetail,
            this.gridStorageSum,
            this.gridStorageMaterialSum,
            this.gridOnlySum});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
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
            this.gridOnlySum.OptionsColumn.AllowEdit = false;
            this.gridOnlySum.Visible = true;
            this.gridOnlySum.VisibleIndex = 7;
            this.gridOnlySum.Width = 119;
            // 
            // txtSelectGuid
            // 
            this.txtSelectGuid.Location = new System.Drawing.Point(804, 349);
            this.txtSelectGuid.Name = "txtSelectGuid";
            this.txtSelectGuid.Size = new System.Drawing.Size(31, 21);
            this.txtSelectGuid.TabIndex = 151;
            this.txtSelectGuid.Visible = false;
            // 
            // frmSelectMRPPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 675);
            this.Controls.Add(this.txtSelectGuid);
            this.Controls.Add(this.gridControl3);
            this.Controls.Add(this.btnSelectSupplier);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaterialMRPPlanID);
            this.Controls.Add(this.btnQry);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.BeginDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectMRPPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "从物料需求计划选择";
            this.Load += new System.EventHandler(this.frmSelectProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaterialMRPPlanID;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit EndDate;
        private DevExpress.XtraEditors.DateEdit BeginDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQry;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialMRPPlanDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialMRPPlanID;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit4;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridRemark;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialMRPPlanGuid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelectSupplier;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialGuidDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialIDDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialNameDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridUnitDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridSpecDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialSumDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridStorageSum;
        private DevExpress.XtraGrid.Columns.GridColumn gridStorageMaterialSum;
        private DevExpress.XtraGrid.Columns.GridColumn gridOnlySum;
        private System.Windows.Forms.TextBox txtSelectGuid;
    }
}