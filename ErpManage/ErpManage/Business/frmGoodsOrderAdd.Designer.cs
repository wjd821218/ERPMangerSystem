namespace ErpManage.Business
{
    partial class frmGoodsOrderAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGoodsOrderAdd));
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
            this.txtGoodsOrderID = new System.Windows.Forms.TextBox();
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
            this.gridMaterialSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridDeterminant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemSpinEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.btnDelDetail = new System.Windows.Forms.Button();
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.txtPlant = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSelectPlant = new System.Windows.Forms.Button();
            this.btnSelectSatrapPerson = new System.Windows.Forms.Button();
            this.txtSatrapPerson = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectTransactorPerson = new System.Windows.Forms.Button();
            this.txtTransactorPerson = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSelectIncomeDepot = new System.Windows.Forms.Button();
            this.txtIncomeDepot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSelectQualityPerson = new System.Windows.Forms.Button();
            this.txtQualityPerson = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSelectDepotPerson = new System.Windows.Forms.Button();
            this.txtDepotPerson = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpGoodsOrderDate = new DevExpress.XtraEditors.DateEdit();
            this.txtGoodsOrderGuid = new System.Windows.Forms.TextBox();
            this.txtCheckDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCheckGuid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCreateDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCreateGuid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStorageView = new System.Windows.Forms.Button();
            this.txtBatchNO = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpGoodsOrderDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpGoodsOrderDate.Properties)).BeginInit();
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
            this.label5.Location = new System.Drawing.Point(10, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 52;
            this.label5.Text = "入库单号：";
            // 
            // txtGoodsOrderID
            // 
            this.txtGoodsOrderID.BackColor = System.Drawing.Color.White;
            this.txtGoodsOrderID.Location = new System.Drawing.Point(78, 45);
            this.txtGoodsOrderID.Name = "txtGoodsOrderID";
            this.txtGoodsOrderID.ReadOnly = true;
            this.txtGoodsOrderID.Size = new System.Drawing.Size(138, 21);
            this.txtGoodsOrderID.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(265, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 60;
            this.label9.Text = "开单日期：";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(532, 108);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(122, 21);
            this.txtRemark.TabIndex = 65;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(485, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 64;
            this.label11.Text = "备注：";
            // 
            // gridControl1
            // 
            this.gridControl1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridControl1.Location = new System.Drawing.Point(12, 197);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalcEdit1,
            this.repositoryItemPopupContainerEdit1,
            this.repositoryItemSpinEdit1,
            this.repositoryItemSpinEdit2,
            this.repositoryItemSpinEdit3});
            this.gridControl1.Size = new System.Drawing.Size(695, 297);
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
            this.gridMaterialSum,
            this.gridDeterminant});
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
            // gridMaterialSum
            // 
            this.gridMaterialSum.Caption = "入库数";
            this.gridMaterialSum.ColumnEdit = this.repositoryItemSpinEdit2;
            this.gridMaterialSum.FieldName = "MaterialSum";
            this.gridMaterialSum.Name = "gridMaterialSum";
            this.gridMaterialSum.Visible = true;
            this.gridMaterialSum.VisibleIndex = 4;
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
            // gridDeterminant
            // 
            this.gridDeterminant.Caption = "品质判定";
            this.gridDeterminant.FieldName = "Determinant";
            this.gridDeterminant.Name = "gridDeterminant";
            this.gridDeterminant.Visible = true;
            this.gridDeterminant.VisibleIndex = 5;
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
            this.btnDelDetail.Location = new System.Drawing.Point(98, 171);
            this.btnDelDetail.Name = "btnDelDetail";
            this.btnDelDetail.Size = new System.Drawing.Size(75, 25);
            this.btnDelDetail.TabIndex = 79;
            this.btnDelDetail.Text = "删除明细";
            this.btnDelDetail.UseVisualStyleBackColor = true;
            this.btnDelDetail.Click += new System.EventHandler(this.btnDelDetail_Click_1);
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Location = new System.Drawing.Point(12, 171);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(75, 25);
            this.btnAddDetail.TabIndex = 78;
            this.btnAddDetail.Text = "增加明细";
            this.btnAddDetail.UseVisualStyleBackColor = true;
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // txtPlant
            // 
            this.txtPlant.BackColor = System.Drawing.Color.White;
            this.txtPlant.Location = new System.Drawing.Point(532, 44);
            this.txtPlant.Name = "txtPlant";
            this.txtPlant.ReadOnly = true;
            this.txtPlant.Size = new System.Drawing.Size(122, 21);
            this.txtPlant.TabIndex = 81;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(478, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 80;
            this.label13.Text = "车间：";
            // 
            // btnSelectPlant
            // 
            this.btnSelectPlant.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectPlant.BackgroundImage")));
            this.btnSelectPlant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectPlant.Location = new System.Drawing.Point(651, 43);
            this.btnSelectPlant.Name = "btnSelectPlant";
            this.btnSelectPlant.Size = new System.Drawing.Size(25, 22);
            this.btnSelectPlant.TabIndex = 82;
            this.btnSelectPlant.UseVisualStyleBackColor = true;
            this.btnSelectPlant.Click += new System.EventHandler(this.btnSelectPlant_Click);
            // 
            // btnSelectSatrapPerson
            // 
            this.btnSelectSatrapPerson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectSatrapPerson.BackgroundImage")));
            this.btnSelectSatrapPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectSatrapPerson.Location = new System.Drawing.Point(651, 75);
            this.btnSelectSatrapPerson.Name = "btnSelectSatrapPerson";
            this.btnSelectSatrapPerson.Size = new System.Drawing.Size(25, 22);
            this.btnSelectSatrapPerson.TabIndex = 90;
            this.btnSelectSatrapPerson.UseVisualStyleBackColor = true;
            this.btnSelectSatrapPerson.Click += new System.EventHandler(this.btnSelectSatrapPerson_Click);
            // 
            // txtSatrapPerson
            // 
            this.txtSatrapPerson.BackColor = System.Drawing.Color.White;
            this.txtSatrapPerson.Location = new System.Drawing.Point(532, 76);
            this.txtSatrapPerson.Name = "txtSatrapPerson";
            this.txtSatrapPerson.ReadOnly = true;
            this.txtSatrapPerson.Size = new System.Drawing.Size(122, 21);
            this.txtSatrapPerson.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 88;
            this.label2.Text = "主管：";
            // 
            // btnSelectTransactorPerson
            // 
            this.btnSelectTransactorPerson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectTransactorPerson.BackgroundImage")));
            this.btnSelectTransactorPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectTransactorPerson.Location = new System.Drawing.Point(451, 76);
            this.btnSelectTransactorPerson.Name = "btnSelectTransactorPerson";
            this.btnSelectTransactorPerson.Size = new System.Drawing.Size(25, 22);
            this.btnSelectTransactorPerson.TabIndex = 93;
            this.btnSelectTransactorPerson.UseVisualStyleBackColor = true;
            this.btnSelectTransactorPerson.Click += new System.EventHandler(this.btnSelectTransactorPerson_Click);
            // 
            // txtTransactorPerson
            // 
            this.txtTransactorPerson.BackColor = System.Drawing.Color.White;
            this.txtTransactorPerson.Location = new System.Drawing.Point(332, 76);
            this.txtTransactorPerson.Name = "txtTransactorPerson";
            this.txtTransactorPerson.ReadOnly = true;
            this.txtTransactorPerson.Size = new System.Drawing.Size(121, 21);
            this.txtTransactorPerson.TabIndex = 92;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 91;
            this.label6.Text = "经办人：";
            // 
            // btnSelectIncomeDepot
            // 
            this.btnSelectIncomeDepot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectIncomeDepot.BackgroundImage")));
            this.btnSelectIncomeDepot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectIncomeDepot.Location = new System.Drawing.Point(215, 75);
            this.btnSelectIncomeDepot.Name = "btnSelectIncomeDepot";
            this.btnSelectIncomeDepot.Size = new System.Drawing.Size(25, 22);
            this.btnSelectIncomeDepot.TabIndex = 96;
            this.btnSelectIncomeDepot.UseVisualStyleBackColor = true;
            this.btnSelectIncomeDepot.Click += new System.EventHandler(this.btnSelectIncomeDepot_Click);
            // 
            // txtIncomeDepot
            // 
            this.txtIncomeDepot.BackColor = System.Drawing.Color.White;
            this.txtIncomeDepot.Location = new System.Drawing.Point(78, 76);
            this.txtIncomeDepot.Name = "txtIncomeDepot";
            this.txtIncomeDepot.ReadOnly = true;
            this.txtIncomeDepot.Size = new System.Drawing.Size(138, 21);
            this.txtIncomeDepot.TabIndex = 95;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 94;
            this.label7.Text = "收货仓库：";
            // 
            // btnSelectQualityPerson
            // 
            this.btnSelectQualityPerson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectQualityPerson.BackgroundImage")));
            this.btnSelectQualityPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectQualityPerson.Location = new System.Drawing.Point(215, 107);
            this.btnSelectQualityPerson.Name = "btnSelectQualityPerson";
            this.btnSelectQualityPerson.Size = new System.Drawing.Size(25, 22);
            this.btnSelectQualityPerson.TabIndex = 102;
            this.btnSelectQualityPerson.UseVisualStyleBackColor = true;
            this.btnSelectQualityPerson.Click += new System.EventHandler(this.btnSelectQualityPerson_Click);
            // 
            // txtQualityPerson
            // 
            this.txtQualityPerson.BackColor = System.Drawing.Color.White;
            this.txtQualityPerson.Location = new System.Drawing.Point(78, 108);
            this.txtQualityPerson.Name = "txtQualityPerson";
            this.txtQualityPerson.ReadOnly = true;
            this.txtQualityPerson.Size = new System.Drawing.Size(138, 21);
            this.txtQualityPerson.TabIndex = 101;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 100;
            this.label8.Text = "品质员：";
            // 
            // btnSelectDepotPerson
            // 
            this.btnSelectDepotPerson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectDepotPerson.BackgroundImage")));
            this.btnSelectDepotPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectDepotPerson.Location = new System.Drawing.Point(452, 107);
            this.btnSelectDepotPerson.Name = "btnSelectDepotPerson";
            this.btnSelectDepotPerson.Size = new System.Drawing.Size(25, 22);
            this.btnSelectDepotPerson.TabIndex = 99;
            this.btnSelectDepotPerson.UseVisualStyleBackColor = true;
            this.btnSelectDepotPerson.Click += new System.EventHandler(this.btnSelectDepotPerson_Click);
            // 
            // txtDepotPerson
            // 
            this.txtDepotPerson.BackColor = System.Drawing.Color.White;
            this.txtDepotPerson.Location = new System.Drawing.Point(332, 108);
            this.txtDepotPerson.Name = "txtDepotPerson";
            this.txtDepotPerson.ReadOnly = true;
            this.txtDepotPerson.Size = new System.Drawing.Size(122, 21);
            this.txtDepotPerson.TabIndex = 98;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(278, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 97;
            this.label12.Text = "仓管员：";
            // 
            // dtpGoodsOrderDate
            // 
            this.dtpGoodsOrderDate.EditValue = null;
            this.dtpGoodsOrderDate.Location = new System.Drawing.Point(332, 45);
            this.dtpGoodsOrderDate.Name = "dtpGoodsOrderDate";
            this.dtpGoodsOrderDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dtpGoodsOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpGoodsOrderDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpGoodsOrderDate.Size = new System.Drawing.Size(122, 21);
            this.dtpGoodsOrderDate.TabIndex = 146;
            // 
            // txtGoodsOrderGuid
            // 
            this.txtGoodsOrderGuid.BackColor = System.Drawing.Color.White;
            this.txtGoodsOrderGuid.Location = new System.Drawing.Point(678, 28);
            this.txtGoodsOrderGuid.Name = "txtGoodsOrderGuid";
            this.txtGoodsOrderGuid.ReadOnly = true;
            this.txtGoodsOrderGuid.Size = new System.Drawing.Size(29, 21);
            this.txtGoodsOrderGuid.TabIndex = 147;
            this.txtGoodsOrderGuid.Visible = false;
            // 
            // txtCheckDate
            // 
            this.txtCheckDate.BackColor = System.Drawing.Color.White;
            this.txtCheckDate.Location = new System.Drawing.Point(578, 515);
            this.txtCheckDate.Name = "txtCheckDate";
            this.txtCheckDate.ReadOnly = true;
            this.txtCheckDate.Size = new System.Drawing.Size(126, 21);
            this.txtCheckDate.TabIndex = 180;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 179;
            this.label4.Text = "审核时间：";
            // 
            // txtCheckGuid
            // 
            this.txtCheckGuid.BackColor = System.Drawing.Color.White;
            this.txtCheckGuid.Location = new System.Drawing.Point(413, 514);
            this.txtCheckGuid.Name = "txtCheckGuid";
            this.txtCheckGuid.ReadOnly = true;
            this.txtCheckGuid.Size = new System.Drawing.Size(99, 21);
            this.txtCheckGuid.TabIndex = 178;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(363, 520);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 177;
            this.label10.Text = "审核人：";
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.BackColor = System.Drawing.Color.White;
            this.txtCreateDate.Location = new System.Drawing.Point(228, 514);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.ReadOnly = true;
            this.txtCreateDate.Size = new System.Drawing.Size(127, 21);
            this.txtCreateDate.TabIndex = 176;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 175;
            this.label3.Text = "制单时间：";
            // 
            // txtCreateGuid
            // 
            this.txtCreateGuid.BackColor = System.Drawing.Color.White;
            this.txtCreateGuid.Location = new System.Drawing.Point(59, 514);
            this.txtCreateGuid.Name = "txtCreateGuid";
            this.txtCreateGuid.ReadOnly = true;
            this.txtCreateGuid.Size = new System.Drawing.Size(95, 21);
            this.txtCreateGuid.TabIndex = 174;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 517);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 173;
            this.label1.Text = "制单人：";
            // 
            // btnStorageView
            // 
            this.btnStorageView.Location = new System.Drawing.Point(191, 171);
            this.btnStorageView.Name = "btnStorageView";
            this.btnStorageView.Size = new System.Drawing.Size(75, 25);
            this.btnStorageView.TabIndex = 182;
            this.btnStorageView.Text = "库存相关";
            this.btnStorageView.UseVisualStyleBackColor = true;
            this.btnStorageView.Click += new System.EventHandler(this.btnStorageView_Click);
            // 
            // txtBatchNO
            // 
            this.txtBatchNO.Location = new System.Drawing.Point(78, 138);
            this.txtBatchNO.Name = "txtBatchNO";
            this.txtBatchNO.Size = new System.Drawing.Size(138, 21);
            this.txtBatchNO.TabIndex = 190;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(35, 145);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 189;
            this.label15.Text = "批号：";
            // 
            // frmGoodsOrderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 545);
            this.Controls.Add(this.txtBatchNO);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnStorageView);
            this.Controls.Add(this.txtCheckDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCheckGuid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCreateDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCreateGuid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGoodsOrderGuid);
            this.Controls.Add(this.dtpGoodsOrderDate);
            this.Controls.Add(this.btnSelectQualityPerson);
            this.Controls.Add(this.txtQualityPerson);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSelectDepotPerson);
            this.Controls.Add(this.txtDepotPerson);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnSelectIncomeDepot);
            this.Controls.Add(this.txtIncomeDepot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSelectTransactorPerson);
            this.Controls.Add(this.txtTransactorPerson);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSelectSatrapPerson);
            this.Controls.Add(this.txtSatrapPerson);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectPlant);
            this.Controls.Add(this.txtPlant);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnDelDetail);
            this.Controls.Add(this.btnAddDetail);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtGoodsOrderID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGoodsOrderAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成品入库单";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpGoodsOrderDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpGoodsOrderDate.Properties)).EndInit();
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
        private System.Windows.Forms.TextBox txtGoodsOrderID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialName;
        private DevExpress.XtraGrid.Columns.GridColumn gridSpec;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialGuID;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialID;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit1;
        private System.Windows.Forms.Button btnDelDetail;
        private System.Windows.Forms.Button btnAddDetail;
        private System.Windows.Forms.TextBox txtPlant;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSelectPlant;
        private DevExpress.XtraGrid.Columns.GridColumn gridUnit;
        private System.Windows.Forms.Button btnSelectSatrapPerson;
        private System.Windows.Forms.TextBox txtSatrapPerson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectTransactorPerson;
        private System.Windows.Forms.TextBox txtTransactorPerson;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialSum;
        private DevExpress.XtraGrid.Columns.GridColumn gridDeterminant;
        private System.Windows.Forms.Button btnSelectIncomeDepot;
        private System.Windows.Forms.TextBox txtIncomeDepot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSelectQualityPerson;
        private System.Windows.Forms.TextBox txtQualityPerson;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSelectDepotPerson;
        private System.Windows.Forms.TextBox txtDepotPerson;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.DateEdit dtpGoodsOrderDate;
        private System.Windows.Forms.TextBox txtGoodsOrderGuid;
        private System.Windows.Forms.TextBox txtCheckDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCheckGuid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCreateDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCreateGuid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.Button btnStorageView;
        private System.Windows.Forms.TextBox txtBatchNO;
        private System.Windows.Forms.Label label15;
    }
}