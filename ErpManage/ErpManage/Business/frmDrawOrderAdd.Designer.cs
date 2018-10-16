namespace ErpManage
{
    partial class frmDrawOrderAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDrawOrderAdd));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCheck = new System.Windows.Forms.ToolStripButton();
            this.tsbUnCheck = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDrawOrderID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridMaterialGuID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridConsumeSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridApplyMaterialSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemSpinEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.btnDelDetail = new System.Windows.Forms.Button();
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.txtDrawPerson = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSelectDrawPerson = new System.Windows.Forms.Button();
            this.btnSelectEmitPerson = new System.Windows.Forms.Button();
            this.txtEmitPerson = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSelectDrawPlan = new System.Windows.Forms.Button();
            this.btnSelectOutStorage = new System.Windows.Forms.Button();
            this.txtOutStorage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDrawOrderGuid = new System.Windows.Forms.TextBox();
            this.dtpDrawOrderDate = new DevExpress.XtraEditors.DateEdit();
            this.txtCheckDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCheckGuid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCreateDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCreateGuid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnStorageView = new System.Windows.Forms.Button();
            this.btnAddDetailByBom = new System.Windows.Forms.Button();
            this.btnBatchNo = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDrawOrderDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDrawOrderDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.tsbSave,
            this.btnDelete,
            this.toolStripSeparator2,
            this.tsbCheck,
            this.tsbUnCheck,
            this.toolStripSeparator1,
            this.tsbPrint,
            this.exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(711, 25);
            this.toolStrip1.TabIndex = 51;
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
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(49, 22);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbCheck
            // 
            this.tsbCheck.Image = ((System.Drawing.Image)(resources.GetObject("tsbCheck.Image")));
            this.tsbCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCheck.Name = "tsbCheck";
            this.tsbCheck.Size = new System.Drawing.Size(49, 22);
            this.tsbCheck.Text = "审核";
            this.tsbCheck.Click += new System.EventHandler(this.tsbCheck_Click);
            // 
            // tsbUnCheck
            // 
            this.tsbUnCheck.Image = ((System.Drawing.Image)(resources.GetObject("tsbUnCheck.Image")));
            this.tsbUnCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUnCheck.Name = "tsbUnCheck";
            this.tsbUnCheck.Size = new System.Drawing.Size(49, 22);
            this.tsbUnCheck.Text = "反审";
            this.tsbUnCheck.Click += new System.EventHandler(this.tsbUnCheck_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbPrint
            // 
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(49, 22);
            this.tsbPrint.Text = "打印";
            this.tsbPrint.ToolTipText = "打印";
            this.tsbPrint.Click += new System.EventHandler(this.tsbPrint_Click);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 52;
            this.label5.Text = "领料单号：";
            // 
            // txtDrawOrderID
            // 
            this.txtDrawOrderID.BackColor = System.Drawing.Color.White;
            this.txtDrawOrderID.Location = new System.Drawing.Point(326, 45);
            this.txtDrawOrderID.Name = "txtDrawOrderID";
            this.txtDrawOrderID.ReadOnly = true;
            this.txtDrawOrderID.Size = new System.Drawing.Size(121, 21);
            this.txtDrawOrderID.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(456, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 60;
            this.label9.Text = "开单日期：";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(84, 108);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(363, 21);
            this.txtRemark.TabIndex = 65;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 64;
            this.label11.Text = "备注：";
            // 
            // gridControl1
            // 
            this.gridControl1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridControl1.Location = new System.Drawing.Point(0, 182);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalcEdit1,
            this.repositoryItemPopupContainerEdit1,
            this.repositoryItemSpinEdit1,
            this.repositoryItemSpinEdit2,
            this.repositoryItemSpinEdit3});
            this.gridControl1.Size = new System.Drawing.Size(707, 296);
            this.gridControl1.TabIndex = 77;
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
            this.gridMaterialGuID,
            this.gridMaterialID,
            this.gridMaterialName,
            this.gridSpec,
            this.gridUnit,
            this.gridConsumeSum,
            this.gridApplyMaterialSum,
            this.gridMaterialSum});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridMaterialGuID
            // 
            this.gridMaterialGuID.Caption = "MaterialGuID";
            this.gridMaterialGuID.FieldName = "MaterialGuID";
            this.gridMaterialGuID.Name = "gridMaterialGuID";
            this.gridMaterialGuID.OptionsColumn.AllowEdit = false;
            // 
            // gridMaterialID
            // 
            this.gridMaterialID.Caption = "物料编号";
            this.gridMaterialID.FieldName = "MaterialID";
            this.gridMaterialID.Name = "gridMaterialID";
            this.gridMaterialID.OptionsColumn.AllowEdit = false;
            this.gridMaterialID.Visible = true;
            this.gridMaterialID.VisibleIndex = 0;
            // 
            // gridMaterialName
            // 
            this.gridMaterialName.Caption = "物料名称";
            this.gridMaterialName.FieldName = "MaterialName";
            this.gridMaterialName.Name = "gridMaterialName";
            this.gridMaterialName.OptionsColumn.AllowEdit = false;
            this.gridMaterialName.Visible = true;
            this.gridMaterialName.VisibleIndex = 1;
            // 
            // gridSpec
            // 
            this.gridSpec.Caption = "规格";
            this.gridSpec.FieldName = "Spec";
            this.gridSpec.Name = "gridSpec";
            this.gridSpec.OptionsColumn.AllowEdit = false;
            this.gridSpec.Visible = true;
            this.gridSpec.VisibleIndex = 2;
            // 
            // gridUnit
            // 
            this.gridUnit.Caption = "单位";
            this.gridUnit.FieldName = "Unit";
            this.gridUnit.Name = "gridUnit";
            this.gridUnit.OptionsColumn.AllowEdit = false;
            this.gridUnit.Visible = true;
            this.gridUnit.VisibleIndex = 3;
            // 
            // gridConsumeSum
            // 
            this.gridConsumeSum.AppearanceCell.Options.UseTextOptions = true;
            this.gridConsumeSum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridConsumeSum.Caption = "单耗";
            this.gridConsumeSum.ColumnEdit = this.repositoryItemSpinEdit2;
            this.gridConsumeSum.DisplayFormat.FormatString = "0.####";
            this.gridConsumeSum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridConsumeSum.FieldName = "ConsumeSum";
            this.gridConsumeSum.Name = "gridConsumeSum";
            this.gridConsumeSum.Visible = true;
            this.gridConsumeSum.VisibleIndex = 4;
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
            this.repositoryItemSpinEdit2.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.repositoryItemSpinEdit2_Spin);
            // 
            // gridApplyMaterialSum
            // 
            this.gridApplyMaterialSum.Caption = "请领数";
            this.gridApplyMaterialSum.ColumnEdit = this.repositoryItemSpinEdit2;
            this.gridApplyMaterialSum.DisplayFormat.FormatString = "0.###";
            this.gridApplyMaterialSum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridApplyMaterialSum.FieldName = "ApplyMaterialSum";
            this.gridApplyMaterialSum.Name = "gridApplyMaterialSum";
            this.gridApplyMaterialSum.Visible = true;
            this.gridApplyMaterialSum.VisibleIndex = 5;
            // 
            // gridMaterialSum
            // 
            this.gridMaterialSum.Caption = "实发数";
            this.gridMaterialSum.ColumnEdit = this.repositoryItemSpinEdit2;
            this.gridMaterialSum.FieldName = "MaterialSum";
            this.gridMaterialSum.Name = "gridMaterialSum";
            this.gridMaterialSum.Visible = true;
            this.gridMaterialSum.VisibleIndex = 6;
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
            this.repositoryItemSpinEdit1.DisplayFormat.FormatString = "0.######";
            this.repositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.EditFormat.FormatString = "0.######";
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
            // btnDelDetail
            // 
            this.btnDelDetail.Location = new System.Drawing.Point(379, 151);
            this.btnDelDetail.Name = "btnDelDetail";
            this.btnDelDetail.Size = new System.Drawing.Size(75, 25);
            this.btnDelDetail.TabIndex = 79;
            this.btnDelDetail.Text = "删除明细";
            this.btnDelDetail.UseVisualStyleBackColor = true;
            this.btnDelDetail.Click += new System.EventHandler(this.btnDelDetail_Click_1);
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Location = new System.Drawing.Point(137, 151);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(110, 25);
            this.btnAddDetail.TabIndex = 78;
            this.btnAddDetail.Text = "增加明细(按物料)";
            this.btnAddDetail.UseVisualStyleBackColor = true;
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // txtDrawPerson
            // 
            this.txtDrawPerson.BackColor = System.Drawing.Color.White;
            this.txtDrawPerson.Location = new System.Drawing.Point(86, 44);
            this.txtDrawPerson.Name = "txtDrawPerson";
            this.txtDrawPerson.ReadOnly = true;
            this.txtDrawPerson.Size = new System.Drawing.Size(138, 21);
            this.txtDrawPerson.TabIndex = 81;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 80;
            this.label13.Text = "领料人：";
            // 
            // btnSelectDrawPerson
            // 
            this.btnSelectDrawPerson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectDrawPerson.BackgroundImage")));
            this.btnSelectDrawPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectDrawPerson.Location = new System.Drawing.Point(223, 43);
            this.btnSelectDrawPerson.Name = "btnSelectDrawPerson";
            this.btnSelectDrawPerson.Size = new System.Drawing.Size(25, 22);
            this.btnSelectDrawPerson.TabIndex = 82;
            this.btnSelectDrawPerson.UseVisualStyleBackColor = true;
            this.btnSelectDrawPerson.Click += new System.EventHandler(this.btnSelectDrawPerson_Click);
            // 
            // btnSelectEmitPerson
            // 
            this.btnSelectEmitPerson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectEmitPerson.BackgroundImage")));
            this.btnSelectEmitPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectEmitPerson.Location = new System.Drawing.Point(222, 77);
            this.btnSelectEmitPerson.Name = "btnSelectEmitPerson";
            this.btnSelectEmitPerson.Size = new System.Drawing.Size(25, 22);
            this.btnSelectEmitPerson.TabIndex = 89;
            this.btnSelectEmitPerson.UseVisualStyleBackColor = true;
            this.btnSelectEmitPerson.Click += new System.EventHandler(this.btnSelectEmitPerson_Click);
            // 
            // txtEmitPerson
            // 
            this.txtEmitPerson.BackColor = System.Drawing.Color.White;
            this.txtEmitPerson.Location = new System.Drawing.Point(85, 78);
            this.txtEmitPerson.Name = "txtEmitPerson";
            this.txtEmitPerson.ReadOnly = true;
            this.txtEmitPerson.Size = new System.Drawing.Size(138, 21);
            this.txtEmitPerson.TabIndex = 88;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 87;
            this.label6.Text = "发料人：";
            // 
            // btnSelectDrawPlan
            // 
            this.btnSelectDrawPlan.Location = new System.Drawing.Point(12, 151);
            this.btnSelectDrawPlan.Name = "btnSelectDrawPlan";
            this.btnSelectDrawPlan.Size = new System.Drawing.Size(114, 25);
            this.btnSelectDrawPlan.TabIndex = 90;
            this.btnSelectDrawPlan.Text = "从领料计划选择";
            this.btnSelectDrawPlan.UseVisualStyleBackColor = true;
            this.btnSelectDrawPlan.Click += new System.EventHandler(this.btnSelectDrawPlan_Click_1);
            // 
            // btnSelectOutStorage
            // 
            this.btnSelectOutStorage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectOutStorage.BackgroundImage")));
            this.btnSelectOutStorage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectOutStorage.Location = new System.Drawing.Point(445, 79);
            this.btnSelectOutStorage.Name = "btnSelectOutStorage";
            this.btnSelectOutStorage.Size = new System.Drawing.Size(25, 22);
            this.btnSelectOutStorage.TabIndex = 93;
            this.btnSelectOutStorage.UseVisualStyleBackColor = true;
            this.btnSelectOutStorage.Click += new System.EventHandler(this.btnSelectOutStorage_Click);
            // 
            // txtOutStorage
            // 
            this.txtOutStorage.BackColor = System.Drawing.Color.White;
            this.txtOutStorage.Location = new System.Drawing.Point(326, 79);
            this.txtOutStorage.Name = "txtOutStorage";
            this.txtOutStorage.ReadOnly = true;
            this.txtOutStorage.Size = new System.Drawing.Size(121, 21);
            this.txtOutStorage.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 91;
            this.label2.Text = "领料仓库：";
            // 
            // txtDrawOrderGuid
            // 
            this.txtDrawOrderGuid.Location = new System.Drawing.Point(672, 28);
            this.txtDrawOrderGuid.Name = "txtDrawOrderGuid";
            this.txtDrawOrderGuid.Size = new System.Drawing.Size(27, 21);
            this.txtDrawOrderGuid.TabIndex = 94;
            this.txtDrawOrderGuid.Visible = false;
            // 
            // dtpDrawOrderDate
            // 
            this.dtpDrawOrderDate.EditValue = null;
            this.dtpDrawOrderDate.Location = new System.Drawing.Point(527, 44);
            this.dtpDrawOrderDate.Name = "dtpDrawOrderDate";
            this.dtpDrawOrderDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dtpDrawOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDrawOrderDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpDrawOrderDate.Size = new System.Drawing.Size(122, 21);
            this.dtpDrawOrderDate.TabIndex = 145;
            // 
            // txtCheckDate
            // 
            this.txtCheckDate.BackColor = System.Drawing.Color.White;
            this.txtCheckDate.Location = new System.Drawing.Point(574, 499);
            this.txtCheckDate.Name = "txtCheckDate";
            this.txtCheckDate.ReadOnly = true;
            this.txtCheckDate.Size = new System.Drawing.Size(126, 21);
            this.txtCheckDate.TabIndex = 172;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(514, 504);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 171;
            this.label4.Text = "审核时间：";
            // 
            // txtCheckGuid
            // 
            this.txtCheckGuid.BackColor = System.Drawing.Color.White;
            this.txtCheckGuid.Location = new System.Drawing.Point(409, 498);
            this.txtCheckGuid.Name = "txtCheckGuid";
            this.txtCheckGuid.ReadOnly = true;
            this.txtCheckGuid.Size = new System.Drawing.Size(99, 21);
            this.txtCheckGuid.TabIndex = 170;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(359, 504);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 169;
            this.label10.Text = "审核人：";
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.BackColor = System.Drawing.Color.White;
            this.txtCreateDate.Location = new System.Drawing.Point(224, 498);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.ReadOnly = true;
            this.txtCreateDate.Size = new System.Drawing.Size(127, 21);
            this.txtCreateDate.TabIndex = 168;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 504);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 167;
            this.label3.Text = "制单时间：";
            // 
            // txtCreateGuid
            // 
            this.txtCreateGuid.BackColor = System.Drawing.Color.White;
            this.txtCreateGuid.Location = new System.Drawing.Point(55, 498);
            this.txtCreateGuid.Name = "txtCreateGuid";
            this.txtCreateGuid.ReadOnly = true;
            this.txtCreateGuid.Size = new System.Drawing.Size(95, 21);
            this.txtCreateGuid.TabIndex = 166;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 501);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 165;
            this.label8.Text = "制单人：";
            // 
            // btnStorageView
            // 
            this.btnStorageView.Location = new System.Drawing.Point(471, 151);
            this.btnStorageView.Name = "btnStorageView";
            this.btnStorageView.Size = new System.Drawing.Size(75, 25);
            this.btnStorageView.TabIndex = 182;
            this.btnStorageView.Text = "库存相关";
            this.btnStorageView.UseVisualStyleBackColor = true;
            this.btnStorageView.Click += new System.EventHandler(this.btnStorageView_Click);
            // 
            // btnAddDetailByBom
            // 
            this.btnAddDetailByBom.Location = new System.Drawing.Point(255, 151);
            this.btnAddDetailByBom.Name = "btnAddDetailByBom";
            this.btnAddDetailByBom.Size = new System.Drawing.Size(112, 25);
            this.btnAddDetailByBom.TabIndex = 183;
            this.btnAddDetailByBom.Text = "增加明细(按BOM)";
            this.btnAddDetailByBom.UseVisualStyleBackColor = true;
            this.btnAddDetailByBom.Click += new System.EventHandler(this.btnAddDetailByBom_Click);
            // 
            // btnBatchNo
            // 
            this.btnBatchNo.Location = new System.Drawing.Point(563, 151);
            this.btnBatchNo.Name = "btnBatchNo";
            this.btnBatchNo.Size = new System.Drawing.Size(75, 25);
            this.btnBatchNo.TabIndex = 184;
            this.btnBatchNo.Text = "批次列表";
            this.btnBatchNo.UseVisualStyleBackColor = true;
            this.btnBatchNo.Click += new System.EventHandler(this.btnBatchNo_Click);
            // 
            // frmDrawOrderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 531);
            this.Controls.Add(this.btnBatchNo);
            this.Controls.Add(this.btnAddDetailByBom);
            this.Controls.Add(this.btnStorageView);
            this.Controls.Add(this.txtCheckDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCheckGuid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCreateDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCreateGuid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpDrawOrderDate);
            this.Controls.Add(this.txtDrawOrderGuid);
            this.Controls.Add(this.btnSelectOutStorage);
            this.Controls.Add(this.txtOutStorage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectDrawPlan);
            this.Controls.Add(this.btnSelectEmitPerson);
            this.Controls.Add(this.txtEmitPerson);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSelectDrawPerson);
            this.Controls.Add(this.txtDrawPerson);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnDelDetail);
            this.Controls.Add(this.btnAddDetail);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDrawOrderID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDrawOrderAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "领料单新增";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDrawOrderDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDrawOrderDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton exit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbCheck;
        private System.Windows.Forms.ToolStripButton tsbUnCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDrawOrderID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialName;
        private DevExpress.XtraGrid.Columns.GridColumn gridSpec;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialSum;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialGuID;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialID;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit1;
        private System.Windows.Forms.Button btnDelDetail;
        private System.Windows.Forms.Button btnAddDetail;
        private System.Windows.Forms.TextBox txtDrawPerson;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSelectDrawPerson;
        private DevExpress.XtraGrid.Columns.GridColumn gridUnit;
        private System.Windows.Forms.Button btnSelectEmitPerson;
        private System.Windows.Forms.TextBox txtEmitPerson;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSelectDrawPlan;
        private System.Windows.Forms.Button btnSelectOutStorage;
        private System.Windows.Forms.TextBox txtOutStorage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDrawOrderGuid;
        private DevExpress.XtraEditors.DateEdit dtpDrawOrderDate;
        private System.Windows.Forms.TextBox txtCheckDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCheckGuid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCreateDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCreateGuid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnStorageView;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private DevExpress.XtraGrid.Columns.GridColumn gridApplyMaterialSum;
        private DevExpress.XtraGrid.Columns.GridColumn gridConsumeSum;
        private System.Windows.Forms.Button btnAddDetailByBom;
        private System.Windows.Forms.Button btnBatchNo;
    }
}