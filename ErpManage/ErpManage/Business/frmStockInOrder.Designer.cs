namespace ErpManage.Business
{
    partial class frmStockInOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockInOrder));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridStockInOrderGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridStockInOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridStockInOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSupplierGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridStockPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridStoragePerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridBatchNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCreateName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBatchNO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkCheck = new System.Windows.Forms.CheckBox();
            this.btnSelectInStorage = new System.Windows.Forms.Button();
            this.txtInStorage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSelectStoragePerson = new System.Windows.Forms.Button();
            this.txtStoragePerson = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelectSupplier = new System.Windows.Forms.Button();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnQty = new System.Windows.Forms.Button();
            this.dtpStockInOrderEndDate = new DevExpress.XtraEditors.DateEdit();
            this.dtpStockInOrderBeginDate = new DevExpress.XtraEditors.DateEdit();
            this.txtStockInOrderID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbedit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.gridCheckName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStockInOrderEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStockInOrderEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStockInOrderBeginDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStockInOrderBeginDate.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 127);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(822, 453);
            this.gridControl1.TabIndex = 116;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
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
            this.gridStockInOrderGuid,
            this.gridStockInOrderID,
            this.gridStockInOrderDate,
            this.gridSupplierGuid,
            this.gridStockPerson,
            this.gridStoragePerson,
            this.gridBatchNO,
            this.gridCreateName,
            this.gridCreateDate,
            this.gridCheckName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridStockInOrderGuid
            // 
            this.gridStockInOrderGuid.Caption = "StockInOrderGuid";
            this.gridStockInOrderGuid.FieldName = "StockInOrderGuid";
            this.gridStockInOrderGuid.Name = "gridStockInOrderGuid";
            // 
            // gridStockInOrderID
            // 
            this.gridStockInOrderID.Caption = "采购入库单号";
            this.gridStockInOrderID.FieldName = "StockInOrderID";
            this.gridStockInOrderID.Name = "gridStockInOrderID";
            this.gridStockInOrderID.Visible = true;
            this.gridStockInOrderID.VisibleIndex = 0;
            this.gridStockInOrderID.Width = 114;
            // 
            // gridStockInOrderDate
            // 
            this.gridStockInOrderDate.Caption = "开单日期";
            this.gridStockInOrderDate.FieldName = "StockInOrderDate";
            this.gridStockInOrderDate.Name = "gridStockInOrderDate";
            this.gridStockInOrderDate.Visible = true;
            this.gridStockInOrderDate.VisibleIndex = 1;
            this.gridStockInOrderDate.Width = 79;
            // 
            // gridSupplierGuid
            // 
            this.gridSupplierGuid.Caption = "供应商";
            this.gridSupplierGuid.FieldName = "SupplierName";
            this.gridSupplierGuid.Name = "gridSupplierGuid";
            this.gridSupplierGuid.Visible = true;
            this.gridSupplierGuid.VisibleIndex = 2;
            this.gridSupplierGuid.Width = 194;
            // 
            // gridStockPerson
            // 
            this.gridStockPerson.Caption = "采购员";
            this.gridStockPerson.FieldName = "StockPersonName";
            this.gridStockPerson.Name = "gridStockPerson";
            this.gridStockPerson.Visible = true;
            this.gridStockPerson.VisibleIndex = 3;
            this.gridStockPerson.Width = 101;
            // 
            // gridStoragePerson
            // 
            this.gridStoragePerson.Caption = "仓管员";
            this.gridStoragePerson.FieldName = "StoragePersonName";
            this.gridStoragePerson.Name = "gridStoragePerson";
            this.gridStoragePerson.Visible = true;
            this.gridStoragePerson.VisibleIndex = 4;
            this.gridStoragePerson.Width = 101;
            // 
            // gridBatchNO
            // 
            this.gridBatchNO.Caption = "批号";
            this.gridBatchNO.FieldName = "BatchNO";
            this.gridBatchNO.Name = "gridBatchNO";
            this.gridBatchNO.Visible = true;
            this.gridBatchNO.VisibleIndex = 5;
            // 
            // gridCreateName
            // 
            this.gridCreateName.Caption = "制单人";
            this.gridCreateName.FieldName = "CreateName";
            this.gridCreateName.Name = "gridCreateName";
            this.gridCreateName.Visible = true;
            this.gridCreateName.VisibleIndex = 6;
            this.gridCreateName.Width = 101;
            // 
            // gridCreateDate
            // 
            this.gridCreateDate.Caption = "制单日期";
            this.gridCreateDate.FieldName = "CreateDate";
            this.gridCreateDate.Name = "gridCreateDate";
            this.gridCreateDate.Visible = true;
            this.gridCreateDate.VisibleIndex = 7;
            this.gridCreateDate.Width = 111;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBatchNO);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.chkCheck);
            this.panel1.Controls.Add(this.btnSelectInStorage);
            this.panel1.Controls.Add(this.txtInStorage);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnSelectStoragePerson);
            this.panel1.Controls.Add(this.txtStoragePerson);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnSelectSupplier);
            this.panel1.Controls.Add(this.txtSupplier);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnQty);
            this.panel1.Controls.Add(this.dtpStockInOrderEndDate);
            this.panel1.Controls.Add(this.dtpStockInOrderBeginDate);
            this.panel1.Controls.Add(this.txtStockInOrderID);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 102);
            this.panel1.TabIndex = 117;
            // 
            // txtBatchNO
            // 
            this.txtBatchNO.Location = new System.Drawing.Point(82, 75);
            this.txtBatchNO.Name = "txtBatchNO";
            this.txtBatchNO.Size = new System.Drawing.Size(130, 21);
            this.txtBatchNO.TabIndex = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 199;
            this.label2.Text = "批号";
            // 
            // chkCheck
            // 
            this.chkCheck.AutoSize = true;
            this.chkCheck.Location = new System.Drawing.Point(685, 53);
            this.chkCheck.Name = "chkCheck";
            this.chkCheck.Size = new System.Drawing.Size(48, 16);
            this.chkCheck.TabIndex = 198;
            this.chkCheck.Text = "审核";
            this.chkCheck.UseVisualStyleBackColor = true;
            // 
            // btnSelectInStorage
            // 
            this.btnSelectInStorage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectInStorage.BackgroundImage")));
            this.btnSelectInStorage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectInStorage.Location = new System.Drawing.Point(642, 47);
            this.btnSelectInStorage.Name = "btnSelectInStorage";
            this.btnSelectInStorage.Size = new System.Drawing.Size(25, 22);
            this.btnSelectInStorage.TabIndex = 197;
            this.btnSelectInStorage.UseVisualStyleBackColor = true;
            this.btnSelectInStorage.Click += new System.EventHandler(this.btnSelectInStorage_Click);
            // 
            // txtInStorage
            // 
            this.txtInStorage.BackColor = System.Drawing.Color.White;
            this.txtInStorage.Location = new System.Drawing.Point(516, 48);
            this.txtInStorage.Name = "txtInStorage";
            this.txtInStorage.ReadOnly = true;
            this.txtInStorage.Size = new System.Drawing.Size(130, 21);
            this.txtInStorage.TabIndex = 196;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 195;
            this.label7.Text = "收货仓库：";
            // 
            // btnSelectStoragePerson
            // 
            this.btnSelectStoragePerson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectStoragePerson.BackgroundImage")));
            this.btnSelectStoragePerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectStoragePerson.Location = new System.Drawing.Point(417, 47);
            this.btnSelectStoragePerson.Name = "btnSelectStoragePerson";
            this.btnSelectStoragePerson.Size = new System.Drawing.Size(25, 22);
            this.btnSelectStoragePerson.TabIndex = 150;
            this.btnSelectStoragePerson.UseVisualStyleBackColor = true;
            this.btnSelectStoragePerson.Click += new System.EventHandler(this.btnSelectStoragePerson_Click);
            // 
            // txtStoragePerson
            // 
            this.txtStoragePerson.BackColor = System.Drawing.Color.White;
            this.txtStoragePerson.Location = new System.Drawing.Point(289, 48);
            this.txtStoragePerson.Name = "txtStoragePerson";
            this.txtStoragePerson.ReadOnly = true;
            this.txtStoragePerson.Size = new System.Drawing.Size(130, 21);
            this.txtStoragePerson.TabIndex = 149;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 148;
            this.label5.Text = "仓管员";
            // 
            // btnSelectSupplier
            // 
            this.btnSelectSupplier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectSupplier.BackgroundImage")));
            this.btnSelectSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectSupplier.Location = new System.Drawing.Point(210, 47);
            this.btnSelectSupplier.Name = "btnSelectSupplier";
            this.btnSelectSupplier.Size = new System.Drawing.Size(25, 22);
            this.btnSelectSupplier.TabIndex = 144;
            this.btnSelectSupplier.UseVisualStyleBackColor = true;
            this.btnSelectSupplier.Click += new System.EventHandler(this.btnSelectSupplier_Click);
            // 
            // txtSupplier
            // 
            this.txtSupplier.BackColor = System.Drawing.Color.White;
            this.txtSupplier.Location = new System.Drawing.Point(82, 47);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.ReadOnly = true;
            this.txtSupplier.Size = new System.Drawing.Size(130, 21);
            this.txtSupplier.TabIndex = 140;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 135;
            this.label6.Text = "---->";
            // 
            // btnQty
            // 
            this.btnQty.Location = new System.Drawing.Point(724, 14);
            this.btnQty.Name = "btnQty";
            this.btnQty.Size = new System.Drawing.Size(86, 28);
            this.btnQty.TabIndex = 133;
            this.btnQty.Text = "查询";
            this.btnQty.UseVisualStyleBackColor = true;
            this.btnQty.Click += new System.EventHandler(this.btnQty_Click);
            // 
            // dtpStockInOrderEndDate
            // 
            this.dtpStockInOrderEndDate.EditValue = null;
            this.dtpStockInOrderEndDate.Location = new System.Drawing.Point(516, 14);
            this.dtpStockInOrderEndDate.Name = "dtpStockInOrderEndDate";
            this.dtpStockInOrderEndDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dtpStockInOrderEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpStockInOrderEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpStockInOrderEndDate.Size = new System.Drawing.Size(128, 21);
            this.dtpStockInOrderEndDate.TabIndex = 130;
            // 
            // dtpStockInOrderBeginDate
            // 
            this.dtpStockInOrderBeginDate.EditValue = null;
            this.dtpStockInOrderBeginDate.Location = new System.Drawing.Point(289, 15);
            this.dtpStockInOrderBeginDate.Name = "dtpStockInOrderBeginDate";
            this.dtpStockInOrderBeginDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dtpStockInOrderBeginDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpStockInOrderBeginDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpStockInOrderBeginDate.Size = new System.Drawing.Size(128, 21);
            this.dtpStockInOrderBeginDate.TabIndex = 129;
            // 
            // txtStockInOrderID
            // 
            this.txtStockInOrderID.Location = new System.Drawing.Point(82, 17);
            this.txtStockInOrderID.Name = "txtStockInOrderID";
            this.txtStockInOrderID.Size = new System.Drawing.Size(130, 21);
            this.txtStockInOrderID.TabIndex = 125;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 124;
            this.label8.Text = "采购入库单号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 120;
            this.label4.Text = "供应商";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 114;
            this.label1.Text = "开单日期";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.tsbedit,
            this.btnDelete,
            this.toolStripSeparator1,
            this.exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(822, 25);
            this.toolStrip1.TabIndex = 115;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 22);
            this.btnAdd.Text = "添加采购入库单";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tsbedit
            // 
            this.tsbedit.Image = ((System.Drawing.Image)(resources.GetObject("tsbedit.Image")));
            this.tsbedit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbedit.Name = "tsbedit";
            this.tsbedit.Size = new System.Drawing.Size(109, 22);
            this.tsbedit.Text = "编辑采购入库单";
            this.tsbedit.Click += new System.EventHandler(this.tsbedit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(49, 22);
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            // gridCheckName
            // 
            this.gridCheckName.Caption = "审核人";
            this.gridCheckName.FieldName = "CheckName";
            this.gridCheckName.Name = "gridCheckName";
            this.gridCheckName.Visible = true;
            this.gridCheckName.VisibleIndex = 8;
            // 
            // frmStockInOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 580);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmStockInOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "采购入库单";
            this.Load += new System.EventHandler(this.frmStockInOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStockInOrderEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStockInOrderEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStockInOrderBeginDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStockInOrderBeginDate.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQty;
        private DevExpress.XtraEditors.DateEdit dtpStockInOrderEndDate;
        private DevExpress.XtraEditors.DateEdit dtpStockInOrderBeginDate;
        private System.Windows.Forms.TextBox txtStockInOrderID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton tsbedit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton exit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Button btnSelectSupplier;
        private System.Windows.Forms.Button btnSelectStoragePerson;
        private System.Windows.Forms.TextBox txtStoragePerson;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Columns.GridColumn gridStockInOrderGuid;
        private DevExpress.XtraGrid.Columns.GridColumn gridStockInOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn gridStockInOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridSupplierGuid;
        private DevExpress.XtraGrid.Columns.GridColumn gridStockPerson;
        private DevExpress.XtraGrid.Columns.GridColumn gridStoragePerson;
        private DevExpress.XtraGrid.Columns.GridColumn gridCreateName;
        private DevExpress.XtraGrid.Columns.GridColumn gridCreateDate;
        private System.Windows.Forms.Button btnSelectInStorage;
        private System.Windows.Forms.TextBox txtInStorage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkCheck;
        private DevExpress.XtraGrid.Columns.GridColumn gridBatchNO;
        private System.Windows.Forms.TextBox txtBatchNO;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn gridCheckName;
    }
}