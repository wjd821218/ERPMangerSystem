namespace ErpManage.StatReport
{
    partial class frmClientOrderReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientOrderReport));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpEncasementEndDate = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpEncasementBeginDate = new DevExpress.XtraEditors.DateEdit();
            this.txtCheckBatchID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtContractID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClientOrderID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpClientOrderEndDate = new DevExpress.XtraEditors.DateEdit();
            this.dtpClientOrderBeginDate = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQry = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridMaterialID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemSpinEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.cboOrderType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEncasementEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEncasementEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEncasementBeginDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEncasementBeginDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpClientOrderEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpClientOrderEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpClientOrderBeginDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpClientOrderBeginDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(731, 25);
            this.toolStrip1.TabIndex = 140;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.cboOrderType);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpEncasementEndDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpEncasementBeginDate);
            this.panel1.Controls.Add(this.txtCheckBatchID);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtContractID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtClientOrderID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpClientOrderEndDate);
            this.panel1.Controls.Add(this.dtpClientOrderBeginDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnQry);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 124);
            this.panel1.TabIndex = 142;
            // 
            // dtpEncasementEndDate
            // 
            this.dtpEncasementEndDate.EditValue = null;
            this.dtpEncasementEndDate.Location = new System.Drawing.Point(459, 53);
            this.dtpEncasementEndDate.Name = "dtpEncasementEndDate";
            this.dtpEncasementEndDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dtpEncasementEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpEncasementEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpEncasementEndDate.Size = new System.Drawing.Size(104, 21);
            this.dtpEncasementEndDate.TabIndex = 171;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 170;
            this.label3.Text = "--->";
            // 
            // dtpEncasementBeginDate
            // 
            this.dtpEncasementBeginDate.EditValue = null;
            this.dtpEncasementBeginDate.Location = new System.Drawing.Point(268, 53);
            this.dtpEncasementBeginDate.Name = "dtpEncasementBeginDate";
            this.dtpEncasementBeginDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dtpEncasementBeginDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpEncasementBeginDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpEncasementBeginDate.Size = new System.Drawing.Size(121, 21);
            this.dtpEncasementBeginDate.TabIndex = 169;
            // 
            // txtCheckBatchID
            // 
            this.txtCheckBatchID.Location = new System.Drawing.Point(81, 84);
            this.txtCheckBatchID.Name = "txtCheckBatchID";
            this.txtCheckBatchID.Size = new System.Drawing.Size(121, 21);
            this.txtCheckBatchID.TabIndex = 168;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 167;
            this.label9.Text = "商检批号：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 166;
            this.label8.Text = "装箱日期：";
            // 
            // txtContractID
            // 
            this.txtContractID.Location = new System.Drawing.Point(81, 51);
            this.txtContractID.Name = "txtContractID";
            this.txtContractID.Size = new System.Drawing.Size(121, 21);
            this.txtContractID.TabIndex = 165;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 164;
            this.label2.Text = "合同号：";
            // 
            // txtClientOrderID
            // 
            this.txtClientOrderID.BackColor = System.Drawing.Color.White;
            this.txtClientOrderID.Location = new System.Drawing.Point(81, 19);
            this.txtClientOrderID.Name = "txtClientOrderID";
            this.txtClientOrderID.Size = new System.Drawing.Size(121, 21);
            this.txtClientOrderID.TabIndex = 163;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 162;
            this.label5.Text = "客户订单号：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 161;
            this.label6.Text = "--->";
            // 
            // dtpClientOrderEndDate
            // 
            this.dtpClientOrderEndDate.EditValue = null;
            this.dtpClientOrderEndDate.Location = new System.Drawing.Point(459, 19);
            this.dtpClientOrderEndDate.Name = "dtpClientOrderEndDate";
            this.dtpClientOrderEndDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dtpClientOrderEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpClientOrderEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpClientOrderEndDate.Size = new System.Drawing.Size(104, 21);
            this.dtpClientOrderEndDate.TabIndex = 160;
            // 
            // dtpClientOrderBeginDate
            // 
            this.dtpClientOrderBeginDate.EditValue = null;
            this.dtpClientOrderBeginDate.Location = new System.Drawing.Point(267, 19);
            this.dtpClientOrderBeginDate.Name = "dtpClientOrderBeginDate";
            this.dtpClientOrderBeginDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dtpClientOrderBeginDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpClientOrderBeginDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpClientOrderBeginDate.Size = new System.Drawing.Size(122, 21);
            this.dtpClientOrderBeginDate.TabIndex = 159;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 158;
            this.label1.Text = "开单日期";
            // 
            // btnQry
            // 
            this.btnQry.Location = new System.Drawing.Point(590, 45);
            this.btnQry.Name = "btnQry";
            this.btnQry.Size = new System.Drawing.Size(81, 23);
            this.btnQry.TabIndex = 145;
            this.btnQry.Text = "查询";
            this.btnQry.UseVisualStyleBackColor = true;
            this.btnQry.Click += new System.EventHandler(this.btnQry_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridControl1.Location = new System.Drawing.Point(0, 149);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalcEdit1,
            this.repositoryItemPopupContainerEdit1,
            this.repositoryItemSpinEdit1,
            this.repositoryItemSpinEdit2,
            this.repositoryItemSpinEdit3,
            this.repositoryItemTextEdit1,
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(731, 357);
            this.gridControl1.TabIndex = 144;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.RowSeparator.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.RowSeparator.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Appearance.VertLine.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.VertLine.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridMaterialID,
            this.gridMaterialName,
            this.gridSpec,
            this.gridUnit,
            this.gridMaterialSum});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.AllowCellMerge = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridMaterialID
            // 
            this.gridMaterialID.Caption = "物料编号";
            this.gridMaterialID.FieldName = "MaterialID";
            this.gridMaterialID.Name = "gridMaterialID";
            this.gridMaterialID.OptionsColumn.AllowEdit = false;
            this.gridMaterialID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridMaterialID.Visible = true;
            this.gridMaterialID.VisibleIndex = 0;
            this.gridMaterialID.Width = 94;
            // 
            // gridMaterialName
            // 
            this.gridMaterialName.Caption = "物料名称";
            this.gridMaterialName.FieldName = "MaterialName";
            this.gridMaterialName.Name = "gridMaterialName";
            this.gridMaterialName.OptionsColumn.AllowEdit = false;
            this.gridMaterialName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridMaterialName.Visible = true;
            this.gridMaterialName.VisibleIndex = 1;
            this.gridMaterialName.Width = 102;
            // 
            // gridSpec
            // 
            this.gridSpec.Caption = "规格型号";
            this.gridSpec.FieldName = "Spec";
            this.gridSpec.Name = "gridSpec";
            this.gridSpec.OptionsColumn.AllowEdit = false;
            this.gridSpec.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridSpec.Visible = true;
            this.gridSpec.VisibleIndex = 2;
            this.gridSpec.Width = 77;
            // 
            // gridUnit
            // 
            this.gridUnit.Caption = "单位";
            this.gridUnit.FieldName = "Unit";
            this.gridUnit.Name = "gridUnit";
            this.gridUnit.OptionsColumn.AllowEdit = false;
            this.gridUnit.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridUnit.Visible = true;
            this.gridUnit.VisibleIndex = 3;
            this.gridUnit.Width = 68;
            // 
            // gridMaterialSum
            // 
            this.gridMaterialSum.Caption = "数量";
            this.gridMaterialSum.FieldName = "MaterialSum";
            this.gridMaterialSum.Name = "gridMaterialSum";
            this.gridMaterialSum.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridMaterialSum.Visible = true;
            this.gridMaterialSum.VisibleIndex = 4;
            this.gridMaterialSum.Width = 68;
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
            this.repositoryItemSpinEdit1.DisplayFormat.FormatString = "######";
            this.repositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.EditFormat.FormatString = "######";
            this.repositoryItemSpinEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.HideSelection = false;
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            this.repositoryItemSpinEdit1.ReadOnly = true;
            // 
            // repositoryItemSpinEdit2
            // 
            this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
            // 
            // repositoryItemSpinEdit3
            // 
            this.repositoryItemSpinEdit3.Name = "repositoryItemSpinEdit3";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatString = "######";
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit1.EditFormat.FormatString = "######";
            this.repositoryItemTextEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.repositoryItemCheckEdit1.AppearanceReadOnly.Options.UseBorderColor = true;
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.RadioGroupIndex = 0;
            // 
            // cboOrderType
            // 
            this.cboOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderType.FormattingEnabled = true;
            this.cboOrderType.Items.AddRange(new object[] {
            "客户订单",
            "内部订单",
            ""});
            this.cboOrderType.Location = new System.Drawing.Point(267, 84);
            this.cboOrderType.Name = "cboOrderType";
            this.cboOrderType.Size = new System.Drawing.Size(122, 20);
            this.cboOrderType.TabIndex = 173;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 172;
            this.label4.Text = "订单类别：";
            // 
            // frmClientOrderReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 506);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmClientOrderReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客户订单统计报表";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEncasementEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEncasementEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEncasementBeginDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEncasementBeginDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpClientOrderEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpClientOrderEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpClientOrderBeginDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpClientOrderBeginDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQry;
        private DevExpress.XtraEditors.DateEdit dtpEncasementEndDate;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit dtpEncasementBeginDate;
        private System.Windows.Forms.TextBox txtCheckBatchID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtContractID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClientOrderID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.DateEdit dtpClientOrderEndDate;
        private DevExpress.XtraEditors.DateEdit dtpClientOrderBeginDate;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialID;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialName;
        private DevExpress.XtraGrid.Columns.GridColumn gridSpec;
        private DevExpress.XtraGrid.Columns.GridColumn gridUnit;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialSum;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.ComboBox cboOrderType;
        private System.Windows.Forms.Label label4;
    }
}