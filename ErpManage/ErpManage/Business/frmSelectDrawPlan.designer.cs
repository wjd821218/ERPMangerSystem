namespace ErpManage.Business
{
    partial class frmSelectDrawPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectDrawPlan));
            this.txtDrawPlanID = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EndDate = new DevExpress.XtraEditors.DateEdit();
            this.BeginDate = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQry = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridDrawPlanID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridDrawPlanDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridDrawPlanGuid = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridMaterialGuidDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialIDDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialNameDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUnitDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSpecDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialSumDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridStorageSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMaterialClassSelect = new System.Windows.Forms.Button();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSelectGuid = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
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
            // txtDrawPlanID
            // 
            this.txtDrawPlanID.Location = new System.Drawing.Point(112, 22);
            this.txtDrawPlanID.Name = "txtDrawPlanID";
            this.txtDrawPlanID.Size = new System.Drawing.Size(102, 21);
            this.txtDrawPlanID.TabIndex = 59;
            this.txtDrawPlanID.TextChanged += new System.EventHandler(this.txtQryValue_TextChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(595, 20);
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
            this.label2.Text = "生产领料计划单号：";
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
            this.btnQry.Location = new System.Drawing.Point(512, 20);
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
            this.gridControl1.Location = new System.Drawing.Point(3, 58);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemSpinEdit1,
            this.repositoryItemCheckEdit2});
            this.gridControl1.Size = new System.Drawing.Size(696, 137);
            this.gridControl1.TabIndex = 142;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick_1);
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridDrawPlanID,
            this.gridDrawPlanDate,
            this.gridRemark,
            this.gridDrawPlanGuid});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            // 
            // gridDrawPlanID
            // 
            this.gridDrawPlanID.Caption = "生产领料计划单号";
            this.gridDrawPlanID.FieldName = "DrawPlanID";
            this.gridDrawPlanID.Name = "gridDrawPlanID";
            this.gridDrawPlanID.OptionsColumn.AllowEdit = false;
            this.gridDrawPlanID.Visible = true;
            this.gridDrawPlanID.VisibleIndex = 0;
            this.gridDrawPlanID.Width = 137;
            // 
            // gridDrawPlanDate
            // 
            this.gridDrawPlanDate.Caption = "计算日期";
            this.gridDrawPlanDate.FieldName = "DrawPlanDate";
            this.gridDrawPlanDate.Name = "gridDrawPlanDate";
            this.gridDrawPlanDate.OptionsColumn.AllowEdit = false;
            this.gridDrawPlanDate.Visible = true;
            this.gridDrawPlanDate.VisibleIndex = 1;
            this.gridDrawPlanDate.Width = 101;
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
            // gridDrawPlanGuid
            // 
            this.gridDrawPlanGuid.Caption = "DrawPlanGuid";
            this.gridDrawPlanGuid.FieldName = "DrawPlanGuid";
            this.gridDrawPlanGuid.Name = "gridDrawPlanGuid";
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
            this.gridControl2.Location = new System.Drawing.Point(3, 220);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit4,
            this.repositoryItemSpinEdit2,
            this.repositoryItemCheckEdit3});
            this.gridControl2.Size = new System.Drawing.Size(696, 148);
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
            this.label4.Location = new System.Drawing.Point(2, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 144;
            this.label4.Text = "生产领料计划明细：";
            // 
            // gridControl3
            // 
            this.gridControl3.Location = new System.Drawing.Point(3, 410);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(696, 319);
            this.gridControl3.TabIndex = 145;
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
            this.gridStorageSum});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridMaterialGuidDetail
            // 
            this.gridMaterialGuidDetail.Caption = "MaterialGuID";
            this.gridMaterialGuidDetail.FieldName = "MaterialGuID";
            this.gridMaterialGuidDetail.Name = "gridMaterialGuidDetail";
            // 
            // gridMaterialIDDetail
            // 
            this.gridMaterialIDDetail.Caption = "物料号";
            this.gridMaterialIDDetail.FieldName = "MaterialID";
            this.gridMaterialIDDetail.Name = "gridMaterialIDDetail";
            this.gridMaterialIDDetail.Visible = true;
            this.gridMaterialIDDetail.VisibleIndex = 0;
            // 
            // gridMaterialNameDetail
            // 
            this.gridMaterialNameDetail.Caption = "物料名称";
            this.gridMaterialNameDetail.FieldName = "MaterialName";
            this.gridMaterialNameDetail.Name = "gridMaterialNameDetail";
            this.gridMaterialNameDetail.Visible = true;
            this.gridMaterialNameDetail.VisibleIndex = 1;
            // 
            // gridUnitDetail
            // 
            this.gridUnitDetail.Caption = "单位";
            this.gridUnitDetail.FieldName = "Unit";
            this.gridUnitDetail.Name = "gridUnitDetail";
            this.gridUnitDetail.Visible = true;
            this.gridUnitDetail.VisibleIndex = 2;
            // 
            // gridSpecDetail
            // 
            this.gridSpecDetail.Caption = "规格";
            this.gridSpecDetail.FieldName = "Spec";
            this.gridSpecDetail.Name = "gridSpecDetail";
            this.gridSpecDetail.Visible = true;
            this.gridSpecDetail.VisibleIndex = 3;
            // 
            // gridMaterialSumDetail
            // 
            this.gridMaterialSumDetail.Caption = "领料数量";
            this.gridMaterialSumDetail.DisplayFormat.FormatString = "0.###";
            this.gridMaterialSumDetail.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridMaterialSumDetail.FieldName = "RequirementSum";
            this.gridMaterialSumDetail.Name = "gridMaterialSumDetail";
            this.gridMaterialSumDetail.Visible = true;
            this.gridMaterialSumDetail.VisibleIndex = 4;
            // 
            // gridStorageSum
            // 
            this.gridStorageSum.Caption = "库存量";
            this.gridStorageSum.DisplayFormat.FormatString = "0.###";
            this.gridStorageSum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridStorageSum.FieldName = "StorageSum";
            this.gridStorageSum.Name = "gridStorageSum";
            this.gridStorageSum.Visible = true;
            this.gridStorageSum.VisibleIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 12);
            this.label5.TabIndex = 146;
            this.label5.Text = "生产领料明细列表：";
            // 
            // btnMaterialClassSelect
            // 
            this.btnMaterialClassSelect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaterialClassSelect.BackgroundImage")));
            this.btnMaterialClassSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMaterialClassSelect.Location = new System.Drawing.Point(291, 382);
            this.btnMaterialClassSelect.Name = "btnMaterialClassSelect";
            this.btnMaterialClassSelect.Size = new System.Drawing.Size(25, 22);
            this.btnMaterialClassSelect.TabIndex = 149;
            this.btnMaterialClassSelect.UseVisualStyleBackColor = true;
            this.btnMaterialClassSelect.Click += new System.EventHandler(this.btnMaterialClassSelect_Click);
            // 
            // txtClass
            // 
            this.txtClass.BackColor = System.Drawing.Color.White;
            this.txtClass.Location = new System.Drawing.Point(178, 383);
            this.txtClass.Name = "txtClass";
            this.txtClass.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(112, 21);
            this.txtClass.TabIndex = 148;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 147;
            this.label6.Text = "物料分类";
            // 
            // txtSelectGuid
            // 
            this.txtSelectGuid.Location = new System.Drawing.Point(649, 383);
            this.txtSelectGuid.Name = "txtSelectGuid";
            this.txtSelectGuid.Size = new System.Drawing.Size(46, 21);
            this.txtSelectGuid.TabIndex = 150;
            this.txtSelectGuid.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(322, 381);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(45, 23);
            this.btnClear.TabIndex = 151;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmSelectDrawPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 730);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtSelectGuid);
            this.Controls.Add(this.btnMaterialClassSelect);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gridControl3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDrawPlanID);
            this.Controls.Add(this.btnQry);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.BeginDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectDrawPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "从生产领料计划选择";
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

        private System.Windows.Forms.TextBox txtDrawPlanID;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit EndDate;
        private DevExpress.XtraEditors.DateEdit BeginDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQry;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridDrawPlanDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridDrawPlanID;
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
        private DevExpress.XtraGrid.Columns.GridColumn gridDrawPlanGuid;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialGuidDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialIDDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialNameDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridUnitDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridSpecDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialSumDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridStorageSum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMaterialClassSelect;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSelectGuid;
        private System.Windows.Forms.Button btnClear;
    }
}