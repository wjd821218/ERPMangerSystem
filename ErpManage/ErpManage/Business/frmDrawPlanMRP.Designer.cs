namespace ErpManage
{
    partial class frmDrawPlanMRP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDrawPlanMRP));
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tsbsave = new System.Windows.Forms.ToolStripButton();
            this.txtMaterialMRPPlanGuid = new System.Windows.Forms.TextBox();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnJS = new System.Windows.Forms.Button();
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
            this.gridMaterialGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.btnDelDetail = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDeleteCalcMaterial = new System.Windows.Forms.Button();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridMaterialGuidDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialIDDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialNameDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUnitDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSpecDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BeginDate = new DevExpress.XtraEditors.DateEdit();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.txtMRPPlanID = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginDate.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(125, 82);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(393, 21);
            this.txtRemark.TabIndex = 161;
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(78, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 160;
            this.label11.Text = "备注：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 158;
            this.label9.Text = "计算日期：";
            // 
            // tsbsave
            // 
            this.tsbsave.Image = ((System.Drawing.Image)(resources.GetObject("tsbsave.Image")));
            this.tsbsave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbsave.Name = "tsbsave";
            this.tsbsave.Size = new System.Drawing.Size(49, 22);
            this.tsbsave.Text = "保存";
            // 
            // txtMaterialMRPPlanGuid
            // 
            this.txtMaterialMRPPlanGuid.Location = new System.Drawing.Point(570, 28);
            this.txtMaterialMRPPlanGuid.Name = "txtMaterialMRPPlanGuid";
            this.txtMaterialMRPPlanGuid.Size = new System.Drawing.Size(23, 21);
            this.txtMaterialMRPPlanGuid.TabIndex = 162;
            this.txtMaterialMRPPlanGuid.Visible = false;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "数量";
            this.gridColumn11.FieldName = "OnlySum";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(49, 22);
            this.btnAdd.Text = "添加";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 126);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 534);
            this.tabControl1.TabIndex = 163;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnJS);
            this.tabPage1.Controls.Add(this.btnClientOrderSelect);
            this.tabPage1.Controls.Add(this.gridControl1);
            this.tabPage1.Controls.Add(this.btnDelDetail);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "客户订单";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnJS
            // 
            this.btnJS.Location = new System.Drawing.Point(214, 15);
            this.btnJS.Name = "btnJS";
            this.btnJS.Size = new System.Drawing.Size(98, 25);
            this.btnJS.TabIndex = 152;
            this.btnJS.Text = "计算";
            this.btnJS.UseVisualStyleBackColor = true;
            // 
            // btnClientOrderSelect
            // 
            this.btnClientOrderSelect.Location = new System.Drawing.Point(8, 15);
            this.btnClientOrderSelect.Name = "btnClientOrderSelect";
            this.btnClientOrderSelect.Size = new System.Drawing.Size(96, 24);
            this.btnClientOrderSelect.TabIndex = 0;
            this.btnClientOrderSelect.Text = "客户订单选择";
            this.btnClientOrderSelect.UseVisualStyleBackColor = true;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 45);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemSpinEdit1});
            this.gridControl1.Size = new System.Drawing.Size(764, 458);
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
            this.gridYCMaterialSum.FieldName = "YCMaterialSum";
            this.gridYCMaterialSum.Name = "gridYCMaterialSum";
            this.gridYCMaterialSum.Visible = true;
            this.gridYCMaterialSum.VisibleIndex = 6;
            this.gridYCMaterialSum.Width = 73;
            // 
            // gridMaterialGuid
            // 
            this.gridMaterialGuid.Caption = "MaterialGuid";
            this.gridMaterialGuid.FieldName = "MaterialGuid";
            this.gridMaterialGuid.Name = "gridMaterialGuid";
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
            // btnDelDetail
            // 
            this.btnDelDetail.Location = new System.Drawing.Point(120, 15);
            this.btnDelDetail.Name = "btnDelDetail";
            this.btnDelDetail.Size = new System.Drawing.Size(75, 25);
            this.btnDelDetail.TabIndex = 151;
            this.btnDelDetail.Text = "删除明细";
            this.btnDelDetail.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDeleteCalcMaterial);
            this.tabPage2.Controls.Add(this.gridControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 509);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "生产领料计划";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCalcMaterial
            // 
            this.btnDeleteCalcMaterial.Location = new System.Drawing.Point(6, 3);
            this.btnDeleteCalcMaterial.Name = "btnDeleteCalcMaterial";
            this.btnDeleteCalcMaterial.Size = new System.Drawing.Size(75, 25);
            this.btnDeleteCalcMaterial.TabIndex = 152;
            this.btnDeleteCalcMaterial.Text = "删除明细";
            this.btnDeleteCalcMaterial.UseVisualStyleBackColor = true;
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(3, 32);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(756, 474);
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
            this.gridColumn11});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridMaterialGuidDetail
            // 
            this.gridMaterialGuidDetail.Caption = "MaterialGuid";
            this.gridMaterialGuidDetail.FieldName = "MaterialGuid";
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
            // BeginDate
            // 
            this.BeginDate.EditValue = null;
            this.BeginDate.Location = new System.Drawing.Point(378, 52);
            this.BeginDate.Name = "BeginDate";
            this.BeginDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.BeginDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BeginDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.BeginDate.Size = new System.Drawing.Size(140, 21);
            this.BeginDate.TabIndex = 159;
            // 
            // exit
            // 
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(49, 22);
            this.exit.Text = "退出";
            // 
            // txtMRPPlanID
            // 
            this.txtMRPPlanID.BackColor = System.Drawing.Color.White;
            this.txtMRPPlanID.Location = new System.Drawing.Point(125, 52);
            this.txtMRPPlanID.Name = "txtMRPPlanID";
            this.txtMRPPlanID.ReadOnly = true;
            this.txtMRPPlanID.Size = new System.Drawing.Size(146, 21);
            this.txtMRPPlanID.TabIndex = 157;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.tsbsave,
            this.btnDelete,
            this.toolStripSeparator1,
            this.exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(776, 25);
            this.toolStrip1.TabIndex = 155;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 12);
            this.label5.TabIndex = 156;
            this.label5.Text = "生产领料计划单号：";
            // 
            // frmDrawPlanMRP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 661);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMaterialMRPPlanGuid);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BeginDate);
            this.Controls.Add(this.txtMRPPlanID);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label5);
            this.Name = "frmDrawPlanMRP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "生产领料计划";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginDate.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripButton tsbsave;
        private System.Windows.Forms.TextBox txtMaterialMRPPlanGuid;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnJS;
        private System.Windows.Forms.Button btnClientOrderSelect;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridClientOrderDetailGuid;
        private DevExpress.XtraGrid.Columns.GridColumn gridClientOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn gridClientOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialID;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialName;
        private DevExpress.XtraGrid.Columns.GridColumn gridSpec;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialSum;
        private DevExpress.XtraGrid.Columns.GridColumn gridYCMaterialSum;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialGuid;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private System.Windows.Forms.Button btnDelDetail;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDeleteCalcMaterial;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialGuidDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialIDDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialNameDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridUnitDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridSpecDetail;
        private DevExpress.XtraEditors.DateEdit BeginDate;
        private System.Windows.Forms.ToolStripButton exit;
        private System.Windows.Forms.TextBox txtMRPPlanID;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label5;



    }
}