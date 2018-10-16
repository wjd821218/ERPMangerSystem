namespace ErpManage.Business
{
    partial class frmStockInOrderAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockInOrderAdd));
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
            this.txtStockInOrderID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridStockOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridDeliverySum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridStorageSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridStockOrderGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridStockOrderDetailGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialGuID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.repositoryItemSpinEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.btnDelDetail = new System.Windows.Forms.Button();
            this.txtSupplierGuid = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSelectSupplier = new System.Windows.Forms.Button();
            this.btnSelectStockOrder = new System.Windows.Forms.Button();
            this.btnSelectStorageEmp = new System.Windows.Forms.Button();
            this.txtStoragePerson = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectStockEmp = new System.Windows.Forms.Button();
            this.txtStockPerson = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSelectInStorage = new System.Windows.Forms.Button();
            this.txtInStorage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStockInOrderGuid = new System.Windows.Forms.TextBox();
            this.dtpStockInOrderDate = new DevExpress.XtraEditors.DateEdit();
            this.txtCheckDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCheckGuid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCreateDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCreateGuid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnStorageView = new System.Windows.Forms.Button();
            this.txtBatchNO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStockInOrderDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStockInOrderDate.Properties)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(766, 25);
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
            this.label5.Location = new System.Drawing.Point(243, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 52;
            this.label5.Text = "采购入库单号：";
            // 
            // txtStockInOrderID
            // 
            this.txtStockInOrderID.BackColor = System.Drawing.Color.White;
            this.txtStockInOrderID.Location = new System.Drawing.Point(332, 45);
            this.txtStockInOrderID.Name = "txtStockInOrderID";
            this.txtStockInOrderID.ReadOnly = true;
            this.txtStockInOrderID.Size = new System.Drawing.Size(121, 21);
            this.txtStockInOrderID.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(464, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 60;
            this.label9.Text = "开单日期：";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(331, 107);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(323, 21);
            this.txtRemark.TabIndex = 65;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(278, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 64;
            this.label11.Text = "备注：";
            // 
            // gridControl1
            // 
            this.gridControl1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridControl1.Location = new System.Drawing.Point(12, 181);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalcEdit1,
            this.repositoryItemPopupContainerEdit1,
            this.repositoryItemSpinEdit1,
            this.repositoryItemSpinEdit2,
            this.repositoryItemSpinEdit3});
            this.gridControl1.Size = new System.Drawing.Size(754, 297);
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
            this.gridStockOrderID,
            this.gridMaterialID,
            this.gridMaterialName,
            this.gridSpec,
            this.gridUnit,
            this.gridMaterialSum,
            this.gridDeliverySum,
            this.gridStorageSum,
            this.gridRemark,
            this.gridStockOrderGuid,
            this.gridStockOrderDetailGuid,
            this.gridMaterialGuID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridStockOrderID
            // 
            this.gridStockOrderID.Caption = "采购订单号";
            this.gridStockOrderID.FieldName = "StockOrderID";
            this.gridStockOrderID.Name = "gridStockOrderID";
            this.gridStockOrderID.OptionsColumn.AllowEdit = false;
            this.gridStockOrderID.Visible = true;
            this.gridStockOrderID.VisibleIndex = 0;
            this.gridStockOrderID.Width = 99;
            // 
            // gridMaterialID
            // 
            this.gridMaterialID.Caption = "物料编号";
            this.gridMaterialID.FieldName = "MaterialID";
            this.gridMaterialID.Name = "gridMaterialID";
            this.gridMaterialID.OptionsColumn.AllowEdit = false;
            this.gridMaterialID.Visible = true;
            this.gridMaterialID.VisibleIndex = 1;
            this.gridMaterialID.Width = 119;
            // 
            // gridMaterialName
            // 
            this.gridMaterialName.Caption = "物料名称";
            this.gridMaterialName.FieldName = "MaterialName";
            this.gridMaterialName.Name = "gridMaterialName";
            this.gridMaterialName.OptionsColumn.AllowEdit = false;
            this.gridMaterialName.Visible = true;
            this.gridMaterialName.VisibleIndex = 2;
            this.gridMaterialName.Width = 106;
            // 
            // gridSpec
            // 
            this.gridSpec.Caption = "规格";
            this.gridSpec.FieldName = "Spec";
            this.gridSpec.Name = "gridSpec";
            this.gridSpec.OptionsColumn.AllowEdit = false;
            this.gridSpec.Visible = true;
            this.gridSpec.VisibleIndex = 3;
            this.gridSpec.Width = 61;
            // 
            // gridUnit
            // 
            this.gridUnit.Caption = "单位";
            this.gridUnit.FieldName = "Unit";
            this.gridUnit.Name = "gridUnit";
            this.gridUnit.OptionsColumn.AllowEdit = false;
            this.gridUnit.Visible = true;
            this.gridUnit.VisibleIndex = 4;
            this.gridUnit.Width = 61;
            // 
            // gridMaterialSum
            // 
            this.gridMaterialSum.Caption = "订单数量";
            this.gridMaterialSum.ColumnEdit = this.repositoryItemSpinEdit2;
            this.gridMaterialSum.FieldName = "MaterialSum";
            this.gridMaterialSum.Name = "gridMaterialSum";
            this.gridMaterialSum.OptionsColumn.AllowEdit = false;
            this.gridMaterialSum.Visible = true;
            this.gridMaterialSum.VisibleIndex = 5;
            this.gridMaterialSum.Width = 76;
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
            // gridDeliverySum
            // 
            this.gridDeliverySum.Caption = "交货数量";
            this.gridDeliverySum.ColumnEdit = this.repositoryItemSpinEdit1;
            this.gridDeliverySum.FieldName = "DeliverySum";
            this.gridDeliverySum.Name = "gridDeliverySum";
            this.gridDeliverySum.Visible = true;
            this.gridDeliverySum.VisibleIndex = 6;
            this.gridDeliverySum.Width = 71;
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
            this.repositoryItemSpinEdit1.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.repositoryItemSpinEdit1_Spin);
            // 
            // gridStorageSum
            // 
            this.gridStorageSum.Caption = "实收数量";
            this.gridStorageSum.ColumnEdit = this.repositoryItemSpinEdit1;
            this.gridStorageSum.FieldName = "StorageSum";
            this.gridStorageSum.Name = "gridStorageSum";
            this.gridStorageSum.Visible = true;
            this.gridStorageSum.VisibleIndex = 7;
            this.gridStorageSum.Width = 69;
            // 
            // gridRemark
            // 
            this.gridRemark.Caption = "备注";
            this.gridRemark.FieldName = "Remark";
            this.gridRemark.Name = "gridRemark";
            this.gridRemark.Visible = true;
            this.gridRemark.VisibleIndex = 8;
            this.gridRemark.Width = 71;
            // 
            // gridStockOrderGuid
            // 
            this.gridStockOrderGuid.Caption = "StockOrderGuid";
            this.gridStockOrderGuid.FieldName = "StockOrderGuid";
            this.gridStockOrderGuid.Name = "gridStockOrderGuid";
            // 
            // gridStockOrderDetailGuid
            // 
            this.gridStockOrderDetailGuid.Caption = "StockOrderDetailGuid";
            this.gridStockOrderDetailGuid.FieldName = "StockOrderDetailGuid";
            this.gridStockOrderDetailGuid.Name = "gridStockOrderDetailGuid";
            // 
            // gridMaterialGuID
            // 
            this.gridMaterialGuID.Caption = "MaterialGuid";
            this.gridMaterialGuID.FieldName = "MaterialGuID";
            this.gridMaterialGuID.Name = "gridMaterialGuID";
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
            this.btnDelDetail.Location = new System.Drawing.Point(141, 150);
            this.btnDelDetail.Name = "btnDelDetail";
            this.btnDelDetail.Size = new System.Drawing.Size(75, 25);
            this.btnDelDetail.TabIndex = 79;
            this.btnDelDetail.Text = "删除明细";
            this.btnDelDetail.UseVisualStyleBackColor = true;
            this.btnDelDetail.Click += new System.EventHandler(this.btnDelDetail_Click);
            // 
            // txtSupplierGuid
            // 
            this.txtSupplierGuid.BackColor = System.Drawing.Color.White;
            this.txtSupplierGuid.Location = new System.Drawing.Point(78, 44);
            this.txtSupplierGuid.Name = "txtSupplierGuid";
            this.txtSupplierGuid.ReadOnly = true;
            this.txtSupplierGuid.Size = new System.Drawing.Size(138, 21);
            this.txtSupplierGuid.TabIndex = 81;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 80;
            this.label13.Text = "供应商：";
            // 
            // btnSelectSupplier
            // 
            this.btnSelectSupplier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectSupplier.BackgroundImage")));
            this.btnSelectSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectSupplier.Location = new System.Drawing.Point(214, 42);
            this.btnSelectSupplier.Name = "btnSelectSupplier";
            this.btnSelectSupplier.Size = new System.Drawing.Size(25, 22);
            this.btnSelectSupplier.TabIndex = 82;
            this.btnSelectSupplier.UseVisualStyleBackColor = true;
            this.btnSelectSupplier.Click += new System.EventHandler(this.btnSelectSupplier_Click);
            // 
            // btnSelectStockOrder
            // 
            this.btnSelectStockOrder.Location = new System.Drawing.Point(12, 150);
            this.btnSelectStockOrder.Name = "btnSelectStockOrder";
            this.btnSelectStockOrder.Size = new System.Drawing.Size(118, 25);
            this.btnSelectStockOrder.TabIndex = 87;
            this.btnSelectStockOrder.Text = "从采购订单选择";
            this.btnSelectStockOrder.UseVisualStyleBackColor = true;
            this.btnSelectStockOrder.Click += new System.EventHandler(this.btnSelectStockOrder_Click);
            // 
            // btnSelectStorageEmp
            // 
            this.btnSelectStorageEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectStorageEmp.BackgroundImage")));
            this.btnSelectStorageEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectStorageEmp.Location = new System.Drawing.Point(449, 75);
            this.btnSelectStorageEmp.Name = "btnSelectStorageEmp";
            this.btnSelectStorageEmp.Size = new System.Drawing.Size(25, 22);
            this.btnSelectStorageEmp.TabIndex = 90;
            this.btnSelectStorageEmp.UseVisualStyleBackColor = true;
            this.btnSelectStorageEmp.Click += new System.EventHandler(this.btnSelectStorageEmp_Click);
            // 
            // txtStoragePerson
            // 
            this.txtStoragePerson.BackColor = System.Drawing.Color.White;
            this.txtStoragePerson.Location = new System.Drawing.Point(331, 77);
            this.txtStoragePerson.Name = "txtStoragePerson";
            this.txtStoragePerson.ReadOnly = true;
            this.txtStoragePerson.Size = new System.Drawing.Size(122, 21);
            this.txtStoragePerson.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 88;
            this.label2.Text = "仓管员：";
            // 
            // btnSelectStockEmp
            // 
            this.btnSelectStockEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectStockEmp.BackgroundImage")));
            this.btnSelectStockEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectStockEmp.Location = new System.Drawing.Point(650, 75);
            this.btnSelectStockEmp.Name = "btnSelectStockEmp";
            this.btnSelectStockEmp.Size = new System.Drawing.Size(25, 22);
            this.btnSelectStockEmp.TabIndex = 93;
            this.btnSelectStockEmp.UseVisualStyleBackColor = true;
            this.btnSelectStockEmp.Click += new System.EventHandler(this.btnSelectStockEmp_Click);
            // 
            // txtStockPerson
            // 
            this.txtStockPerson.BackColor = System.Drawing.Color.White;
            this.txtStockPerson.Location = new System.Drawing.Point(533, 75);
            this.txtStockPerson.Name = "txtStockPerson";
            this.txtStockPerson.ReadOnly = true;
            this.txtStockPerson.Size = new System.Drawing.Size(121, 21);
            this.txtStockPerson.TabIndex = 92;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(480, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 91;
            this.label6.Text = "采购员：";
            // 
            // btnSelectInStorage
            // 
            this.btnSelectInStorage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectInStorage.BackgroundImage")));
            this.btnSelectInStorage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectInStorage.Location = new System.Drawing.Point(215, 75);
            this.btnSelectInStorage.Name = "btnSelectInStorage";
            this.btnSelectInStorage.Size = new System.Drawing.Size(25, 22);
            this.btnSelectInStorage.TabIndex = 96;
            this.btnSelectInStorage.UseVisualStyleBackColor = true;
            this.btnSelectInStorage.Click += new System.EventHandler(this.btnSelectInStorage_Click);
            // 
            // txtInStorage
            // 
            this.txtInStorage.BackColor = System.Drawing.Color.White;
            this.txtInStorage.Location = new System.Drawing.Point(78, 76);
            this.txtInStorage.Name = "txtInStorage";
            this.txtInStorage.ReadOnly = true;
            this.txtInStorage.Size = new System.Drawing.Size(138, 21);
            this.txtInStorage.TabIndex = 95;
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
            // txtStockInOrderGuid
            // 
            this.txtStockInOrderGuid.Location = new System.Drawing.Point(664, 28);
            this.txtStockInOrderGuid.Name = "txtStockInOrderGuid";
            this.txtStockInOrderGuid.Size = new System.Drawing.Size(47, 21);
            this.txtStockInOrderGuid.TabIndex = 97;
            this.txtStockInOrderGuid.Visible = false;
            // 
            // dtpStockInOrderDate
            // 
            this.dtpStockInOrderDate.EditValue = null;
            this.dtpStockInOrderDate.Location = new System.Drawing.Point(532, 46);
            this.dtpStockInOrderDate.Name = "dtpStockInOrderDate";
            this.dtpStockInOrderDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dtpStockInOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpStockInOrderDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpStockInOrderDate.Size = new System.Drawing.Size(122, 21);
            this.dtpStockInOrderDate.TabIndex = 144;
            // 
            // txtCheckDate
            // 
            this.txtCheckDate.BackColor = System.Drawing.Color.White;
            this.txtCheckDate.Location = new System.Drawing.Point(595, 499);
            this.txtCheckDate.Name = "txtCheckDate";
            this.txtCheckDate.ReadOnly = true;
            this.txtCheckDate.Size = new System.Drawing.Size(126, 21);
            this.txtCheckDate.TabIndex = 164;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 504);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 163;
            this.label4.Text = "审核时间：";
            // 
            // txtCheckGuid
            // 
            this.txtCheckGuid.BackColor = System.Drawing.Color.White;
            this.txtCheckGuid.Location = new System.Drawing.Point(430, 498);
            this.txtCheckGuid.Name = "txtCheckGuid";
            this.txtCheckGuid.ReadOnly = true;
            this.txtCheckGuid.Size = new System.Drawing.Size(99, 21);
            this.txtCheckGuid.TabIndex = 162;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(380, 504);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 161;
            this.label10.Text = "审核人：";
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.BackColor = System.Drawing.Color.White;
            this.txtCreateDate.Location = new System.Drawing.Point(245, 498);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.ReadOnly = true;
            this.txtCreateDate.Size = new System.Drawing.Size(127, 21);
            this.txtCreateDate.TabIndex = 160;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 504);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 159;
            this.label3.Text = "制单时间：";
            // 
            // txtCreateGuid
            // 
            this.txtCreateGuid.BackColor = System.Drawing.Color.White;
            this.txtCreateGuid.Location = new System.Drawing.Point(76, 498);
            this.txtCreateGuid.Name = "txtCreateGuid";
            this.txtCreateGuid.ReadOnly = true;
            this.txtCreateGuid.Size = new System.Drawing.Size(95, 21);
            this.txtCreateGuid.TabIndex = 158;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 501);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 157;
            this.label8.Text = "制单人：";
            // 
            // btnStorageView
            // 
            this.btnStorageView.Location = new System.Drawing.Point(236, 150);
            this.btnStorageView.Name = "btnStorageView";
            this.btnStorageView.Size = new System.Drawing.Size(75, 25);
            this.btnStorageView.TabIndex = 182;
            this.btnStorageView.Text = "库存相关";
            this.btnStorageView.UseVisualStyleBackColor = true;
            this.btnStorageView.Click += new System.EventHandler(this.btnStorageView_Click);
            // 
            // txtBatchNO
            // 
            this.txtBatchNO.Location = new System.Drawing.Point(78, 107);
            this.txtBatchNO.Name = "txtBatchNO";
            this.txtBatchNO.Size = new System.Drawing.Size(138, 21);
            this.txtBatchNO.TabIndex = 184;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 183;
            this.label1.Text = "批号：";
            // 
            // frmStockInOrderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 531);
            this.Controls.Add(this.txtBatchNO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStorageView);
            this.Controls.Add(this.txtCheckDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCheckGuid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCreateDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCreateGuid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpStockInOrderDate);
            this.Controls.Add(this.txtStockInOrderGuid);
            this.Controls.Add(this.btnSelectInStorage);
            this.Controls.Add(this.txtInStorage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSelectStockEmp);
            this.Controls.Add(this.txtStockPerson);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSelectStorageEmp);
            this.Controls.Add(this.txtStoragePerson);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectStockOrder);
            this.Controls.Add(this.btnSelectSupplier);
            this.Controls.Add(this.txtSupplierGuid);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnDelDetail);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtStockInOrderID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStockInOrderAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "采购入库单";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStockInOrderDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStockInOrderDate.Properties)).EndInit();
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
        private System.Windows.Forms.TextBox txtStockInOrderID;
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
        private System.Windows.Forms.TextBox txtSupplierGuid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSelectSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn gridUnit;
        private System.Windows.Forms.Button btnSelectStockOrder;
        private System.Windows.Forms.Button btnSelectStorageEmp;
        private System.Windows.Forms.TextBox txtStoragePerson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectStockEmp;
        private System.Windows.Forms.TextBox txtStockPerson;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.Columns.GridColumn gridDeliverySum;
        private DevExpress.XtraGrid.Columns.GridColumn gridStorageSum;
        private DevExpress.XtraGrid.Columns.GridColumn gridStockOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn gridRemark;
        private System.Windows.Forms.Button btnSelectInStorage;
        private System.Windows.Forms.TextBox txtInStorage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStockInOrderGuid;
        private DevExpress.XtraEditors.DateEdit dtpStockInOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridStockOrderGuid;
        private DevExpress.XtraGrid.Columns.GridColumn gridStockOrderDetailGuid;
        private System.Windows.Forms.TextBox txtCheckDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCheckGuid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCreateDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCreateGuid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.Button btnStorageView;
        private System.Windows.Forms.TextBox txtBatchNO;
        private System.Windows.Forms.Label label1;
    }
}