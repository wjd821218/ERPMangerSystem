namespace ErpManage.Business
{
    partial class frmSelectClientOrder2
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
            this.txtClientOrderID = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EndDate = new DevExpress.XtraEditors.DateEdit();
            this.BeginDate = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQry = new System.Windows.Forms.Button();
            this.btnSelectALL = new System.Windows.Forms.Button();
            this.btnNoSelectAll = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridClientOrderGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridClientOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridClientOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridEncasementDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridContractID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCheckBatchID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridDownDeptName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridReceiveDeptName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridMaterialGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCheckBox = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridMaterialID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridOutStorageSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCanOutSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridClientOrderDetailGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemSpinEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.cboOrderType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClientOrderID
            // 
            this.txtClientOrderID.Location = new System.Drawing.Point(85, 22);
            this.txtClientOrderID.Name = "txtClientOrderID";
            this.txtClientOrderID.Size = new System.Drawing.Size(102, 21);
            this.txtClientOrderID.TabIndex = 59;
            this.txtClientOrderID.TextChanged += new System.EventHandler(this.txtQryValue_TextChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(728, 19);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(69, 23);
            this.btnSelect.TabIndex = 61;
            this.btnSelect.Text = "选定";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 60;
            this.label2.Text = "客户订单号：";
            // 
            // EndDate
            // 
            this.EndDate.EditValue = null;
            this.EndDate.Location = new System.Drawing.Point(379, 22);
            this.EndDate.Name = "EndDate";
            this.EndDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.EndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.EndDate.Size = new System.Drawing.Size(86, 21);
            this.EndDate.TabIndex = 134;
            // 
            // BeginDate
            // 
            this.BeginDate.EditValue = null;
            this.BeginDate.Location = new System.Drawing.Point(250, 22);
            this.BeginDate.Name = "BeginDate";
            this.BeginDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.BeginDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BeginDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.BeginDate.Size = new System.Drawing.Size(93, 21);
            this.BeginDate.TabIndex = 133;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 132;
            this.label1.Text = "下单日期";
            // 
            // btnQry
            // 
            this.btnQry.Location = new System.Drawing.Point(640, 20);
            this.btnQry.Name = "btnQry";
            this.btnQry.Size = new System.Drawing.Size(72, 23);
            this.btnQry.TabIndex = 138;
            this.btnQry.Text = "查询";
            this.btnQry.UseVisualStyleBackColor = true;
            this.btnQry.Click += new System.EventHandler(this.btnQry_Click);
            // 
            // btnSelectALL
            // 
            this.btnSelectALL.Location = new System.Drawing.Point(97, 236);
            this.btnSelectALL.Name = "btnSelectALL";
            this.btnSelectALL.Size = new System.Drawing.Size(67, 20);
            this.btnSelectALL.TabIndex = 139;
            this.btnSelectALL.Text = "全选";
            this.btnSelectALL.UseVisualStyleBackColor = true;
            this.btnSelectALL.Click += new System.EventHandler(this.btnSelectALL_Click);
            // 
            // btnNoSelectAll
            // 
            this.btnNoSelectAll.Location = new System.Drawing.Point(172, 236);
            this.btnNoSelectAll.Name = "btnNoSelectAll";
            this.btnNoSelectAll.Size = new System.Drawing.Size(65, 20);
            this.btnNoSelectAll.TabIndex = 140;
            this.btnNoSelectAll.Text = "取消全选";
            this.btnNoSelectAll.UseVisualStyleBackColor = true;
            this.btnNoSelectAll.Click += new System.EventHandler(this.btnNoSelectAll_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 141;
            this.label3.Text = "---->";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 143;
            this.label4.Text = "客户订单明细：";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(4, 49);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(822, 177);
            this.gridControl1.TabIndex = 144;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView1.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Empty.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridView1.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridView1.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.gridView1.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gridView1.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.gridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Navy;
            this.gridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.gridView1.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F);
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView1.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.gridView1.Appearance.Preview.Options.UseBackColor = true;
            this.gridView1.Appearance.Preview.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridClientOrderGuid,
            this.gridClientOrderID,
            this.gridClientOrderDate,
            this.gridEncasementDate,
            this.gridContractID,
            this.gridCheckBatchID,
            this.gridDownDeptName,
            this.gridReceiveDeptName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridClientOrderGuid
            // 
            this.gridClientOrderGuid.Caption = "ClientOrderGuid";
            this.gridClientOrderGuid.FieldName = "ClientOrderGuid";
            this.gridClientOrderGuid.Name = "gridClientOrderGuid";
            this.gridClientOrderGuid.OptionsColumn.AllowEdit = false;
            // 
            // gridClientOrderID
            // 
            this.gridClientOrderID.Caption = "客户订单号";
            this.gridClientOrderID.FieldName = "ClientOrderID";
            this.gridClientOrderID.Name = "gridClientOrderID";
            this.gridClientOrderID.OptionsColumn.AllowEdit = false;
            this.gridClientOrderID.Visible = true;
            this.gridClientOrderID.VisibleIndex = 0;
            this.gridClientOrderID.Width = 100;
            // 
            // gridClientOrderDate
            // 
            this.gridClientOrderDate.Caption = "下单日期";
            this.gridClientOrderDate.FieldName = "ClientOrderDate";
            this.gridClientOrderDate.Name = "gridClientOrderDate";
            this.gridClientOrderDate.OptionsColumn.AllowEdit = false;
            this.gridClientOrderDate.Visible = true;
            this.gridClientOrderDate.VisibleIndex = 1;
            this.gridClientOrderDate.Width = 85;
            // 
            // gridEncasementDate
            // 
            this.gridEncasementDate.Caption = "装箱日期";
            this.gridEncasementDate.FieldName = "EncasementDate";
            this.gridEncasementDate.Name = "gridEncasementDate";
            this.gridEncasementDate.OptionsColumn.AllowEdit = false;
            this.gridEncasementDate.Visible = true;
            this.gridEncasementDate.VisibleIndex = 2;
            this.gridEncasementDate.Width = 85;
            // 
            // gridContractID
            // 
            this.gridContractID.Caption = "合同号";
            this.gridContractID.FieldName = "ContractID";
            this.gridContractID.Name = "gridContractID";
            this.gridContractID.OptionsColumn.AllowEdit = false;
            this.gridContractID.Visible = true;
            this.gridContractID.VisibleIndex = 3;
            this.gridContractID.Width = 85;
            // 
            // gridCheckBatchID
            // 
            this.gridCheckBatchID.Caption = "商检批号";
            this.gridCheckBatchID.FieldName = "CheckBatchID";
            this.gridCheckBatchID.Name = "gridCheckBatchID";
            this.gridCheckBatchID.OptionsColumn.AllowEdit = false;
            this.gridCheckBatchID.Visible = true;
            this.gridCheckBatchID.VisibleIndex = 4;
            this.gridCheckBatchID.Width = 85;
            // 
            // gridDownDeptName
            // 
            this.gridDownDeptName.Caption = "下单部门";
            this.gridDownDeptName.FieldName = "DownDeptName";
            this.gridDownDeptName.Name = "gridDownDeptName";
            this.gridDownDeptName.OptionsColumn.AllowEdit = false;
            this.gridDownDeptName.Visible = true;
            this.gridDownDeptName.VisibleIndex = 5;
            // 
            // gridReceiveDeptName
            // 
            this.gridReceiveDeptName.Caption = "收单部门";
            this.gridReceiveDeptName.FieldName = "ReceiveDeptName";
            this.gridReceiveDeptName.Name = "gridReceiveDeptName";
            this.gridReceiveDeptName.OptionsColumn.AllowEdit = false;
            this.gridReceiveDeptName.Visible = true;
            this.gridReceiveDeptName.VisibleIndex = 6;
            // 
            // gridControl2
            // 
            this.gridControl2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridControl2.Location = new System.Drawing.Point(4, 262);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalcEdit1,
            this.repositoryItemPopupContainerEdit1,
            this.repositoryItemSpinEdit1,
            this.repositoryItemSpinEdit2,
            this.repositoryItemSpinEdit3,
            this.repositoryItemCheckEdit1});
            this.gridControl2.Size = new System.Drawing.Size(830, 257);
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
            this.gridCheckBox,
            this.gridMaterialID,
            this.gridMaterialName,
            this.gridSpec,
            this.gridUnit,
            this.gridPrice,
            this.gridMaterialSum,
            this.gridOutStorageSum,
            this.gridCanOutSum,
            this.gridClientOrderDetailGuid});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridMaterialGuid
            // 
            this.gridMaterialGuid.Caption = "MaterialGuid";
            this.gridMaterialGuid.FieldName = "MaterialGuID";
            this.gridMaterialGuid.Name = "gridMaterialGuid";
            this.gridMaterialGuid.OptionsColumn.AllowEdit = false;
            // 
            // gridCheckBox
            // 
            this.gridCheckBox.Caption = "选择";
            this.gridCheckBox.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridCheckBox.FieldName = "selectvalue";
            this.gridCheckBox.Name = "gridCheckBox";
            this.gridCheckBox.Visible = true;
            this.gridCheckBox.VisibleIndex = 0;
            this.gridCheckBox.Width = 53;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.RadioGroupIndex = 0;
            this.repositoryItemCheckEdit1.QueryCheckStateByValue += new DevExpress.XtraEditors.Controls.QueryCheckStateByValueEventHandler(this.repositoryItemCheckEdit1_QueryCheckStateByValue);
            // 
            // gridMaterialID
            // 
            this.gridMaterialID.Caption = "物料编号";
            this.gridMaterialID.FieldName = "MaterialID";
            this.gridMaterialID.Name = "gridMaterialID";
            this.gridMaterialID.OptionsColumn.AllowEdit = false;
            this.gridMaterialID.Visible = true;
            this.gridMaterialID.VisibleIndex = 1;
            this.gridMaterialID.Width = 109;
            // 
            // gridMaterialName
            // 
            this.gridMaterialName.Caption = "物料名称";
            this.gridMaterialName.FieldName = "MaterialName";
            this.gridMaterialName.Name = "gridMaterialName";
            this.gridMaterialName.OptionsColumn.AllowEdit = false;
            this.gridMaterialName.Visible = true;
            this.gridMaterialName.VisibleIndex = 2;
            this.gridMaterialName.Width = 110;
            // 
            // gridSpec
            // 
            this.gridSpec.Caption = "规格";
            this.gridSpec.FieldName = "Spec";
            this.gridSpec.Name = "gridSpec";
            this.gridSpec.OptionsColumn.AllowEdit = false;
            this.gridSpec.Visible = true;
            this.gridSpec.VisibleIndex = 3;
            this.gridSpec.Width = 63;
            // 
            // gridUnit
            // 
            this.gridUnit.Caption = "单位";
            this.gridUnit.FieldName = "Unit";
            this.gridUnit.Name = "gridUnit";
            this.gridUnit.OptionsColumn.AllowEdit = false;
            this.gridUnit.Visible = true;
            this.gridUnit.VisibleIndex = 4;
            this.gridUnit.Width = 51;
            // 
            // gridPrice
            // 
            this.gridPrice.Caption = "单价";
            this.gridPrice.DisplayFormat.FormatString = "0.###";
            this.gridPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridPrice.FieldName = "Price";
            this.gridPrice.Name = "gridPrice";
            this.gridPrice.OptionsColumn.AllowEdit = false;
            this.gridPrice.Visible = true;
            this.gridPrice.VisibleIndex = 5;
            // 
            // gridMaterialSum
            // 
            this.gridMaterialSum.Caption = "客户订单数量";
            this.gridMaterialSum.ColumnEdit = this.repositoryItemSpinEdit2;
            this.gridMaterialSum.FieldName = "MaterialSum";
            this.gridMaterialSum.Name = "gridMaterialSum";
            this.gridMaterialSum.OptionsColumn.AllowEdit = false;
            this.gridMaterialSum.Visible = true;
            this.gridMaterialSum.VisibleIndex = 6;
            this.gridMaterialSum.Width = 105;
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
            // gridOutStorageSum
            // 
            this.gridOutStorageSum.Caption = "已出数量";
            this.gridOutStorageSum.DisplayFormat.FormatString = "0.###";
            this.gridOutStorageSum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridOutStorageSum.FieldName = "OutStorageSum";
            this.gridOutStorageSum.Name = "gridOutStorageSum";
            this.gridOutStorageSum.OptionsColumn.AllowEdit = false;
            this.gridOutStorageSum.Visible = true;
            this.gridOutStorageSum.VisibleIndex = 7;
            this.gridOutStorageSum.Width = 76;
            // 
            // gridCanOutSum
            // 
            this.gridCanOutSum.Caption = "可出数量";
            this.gridCanOutSum.DisplayFormat.FormatString = "0.###";
            this.gridCanOutSum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridCanOutSum.FieldName = "CanOutSum";
            this.gridCanOutSum.Name = "gridCanOutSum";
            this.gridCanOutSum.OptionsColumn.AllowEdit = false;
            this.gridCanOutSum.Visible = true;
            this.gridCanOutSum.VisibleIndex = 8;
            this.gridCanOutSum.Width = 99;
            // 
            // gridClientOrderDetailGuid
            // 
            this.gridClientOrderDetailGuid.Caption = "ClientOrderDetailGuid";
            this.gridClientOrderDetailGuid.FieldName = "ClientOrderDetailGuid";
            this.gridClientOrderDetailGuid.Name = "gridClientOrderDetailGuid";
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
            // cboOrderType
            // 
            this.cboOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderType.FormattingEnabled = true;
            this.cboOrderType.Items.AddRange(new object[] {
            "客户订单",
            "内部订单",
            ""});
            this.cboOrderType.Location = new System.Drawing.Point(528, 22);
            this.cboOrderType.Name = "cboOrderType";
            this.cboOrderType.Size = new System.Drawing.Size(92, 20);
            this.cboOrderType.TabIndex = 162;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 161;
            this.label5.Text = "订单类别";
            // 
            // frmSelectClientOrder2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 520);
            this.Controls.Add(this.cboOrderType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClientOrderID);
            this.Controls.Add(this.btnNoSelectAll);
            this.Controls.Add(this.btnSelectALL);
            this.Controls.Add(this.btnQry);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.BeginDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectClientOrder2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "从客户订单选择";
            this.Load += new System.EventHandler(this.frmSelectProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClientOrderID;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit EndDate;
        private DevExpress.XtraEditors.DateEdit BeginDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQry;
        private System.Windows.Forms.Button btnSelectALL;
        private System.Windows.Forms.Button btnNoSelectAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridClientOrderGuid;
        private DevExpress.XtraGrid.Columns.GridColumn gridClientOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn gridClientOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridEncasementDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridContractID;
        private DevExpress.XtraGrid.Columns.GridColumn gridCheckBatchID;
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
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn gridCheckBox;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridClientOrderDetailGuid;
        private DevExpress.XtraGrid.Columns.GridColumn gridOutStorageSum;
        private DevExpress.XtraGrid.Columns.GridColumn gridCanOutSum;
        private DevExpress.XtraGrid.Columns.GridColumn gridDownDeptName;
        private DevExpress.XtraGrid.Columns.GridColumn gridReceiveDeptName;
        private DevExpress.XtraGrid.Columns.GridColumn gridPrice;
        private System.Windows.Forms.ComboBox cboOrderType;
        private System.Windows.Forms.Label label5;
    }
}