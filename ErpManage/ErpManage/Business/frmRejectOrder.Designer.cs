namespace ErpManage.Business
{
    partial class frmRejectOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRejectOrder));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridRejectOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridProductType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridClientOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridRejectOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridStoragePerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridQualityPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridProjectPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridStockPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridRejectOrderGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCheckName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCheckName2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelectRejectStorage = new System.Windows.Forms.Button();
            this.txtRejectStorage = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.chkCheck2 = new System.Windows.Forms.CheckBox();
            this.chkCheck = new System.Windows.Forms.CheckBox();
            this.txtClientOrderID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtProductType = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnQty = new System.Windows.Forms.Button();
            this.dtpRejectOrderEndDate = new DevExpress.XtraEditors.DateEdit();
            this.dtpRejectOrderBeginDate = new DevExpress.XtraEditors.DateEdit();
            this.txtRejectOrderID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbedit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.gridRejectStorage = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRejectOrderEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRejectOrderEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRejectOrderBeginDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRejectOrderBeginDate.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 115);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(822, 465);
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
            this.gridRejectOrderID,
            this.gridProductType,
            this.gridClientOrderID,
            this.gridRejectOrderDate,
            this.gridRejectStorage,
            this.gridStoragePerson,
            this.gridQualityPerson,
            this.gridProjectPerson,
            this.gridStockPerson,
            this.gridRejectOrderGuid,
            this.gridCheckName,
            this.gridCheckName2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridRejectOrderID
            // 
            this.gridRejectOrderID.Caption = "报废单号";
            this.gridRejectOrderID.FieldName = "RejectOrderID";
            this.gridRejectOrderID.Name = "gridRejectOrderID";
            this.gridRejectOrderID.Visible = true;
            this.gridRejectOrderID.VisibleIndex = 0;
            // 
            // gridProductType
            // 
            this.gridProductType.Caption = "产品型号";
            this.gridProductType.FieldName = "ProductType";
            this.gridProductType.Name = "gridProductType";
            this.gridProductType.Visible = true;
            this.gridProductType.VisibleIndex = 1;
            // 
            // gridClientOrderID
            // 
            this.gridClientOrderID.Caption = "客户订单号";
            this.gridClientOrderID.FieldName = "ClientOrderID";
            this.gridClientOrderID.Name = "gridClientOrderID";
            this.gridClientOrderID.Visible = true;
            this.gridClientOrderID.VisibleIndex = 2;
            // 
            // gridRejectOrderDate
            // 
            this.gridRejectOrderDate.Caption = "开单日期";
            this.gridRejectOrderDate.FieldName = "RejectOrderDate";
            this.gridRejectOrderDate.Name = "gridRejectOrderDate";
            this.gridRejectOrderDate.Visible = true;
            this.gridRejectOrderDate.VisibleIndex = 3;
            // 
            // gridStoragePerson
            // 
            this.gridStoragePerson.Caption = "仓管员";
            this.gridStoragePerson.FieldName = "StoragePersonName";
            this.gridStoragePerson.Name = "gridStoragePerson";
            this.gridStoragePerson.Visible = true;
            this.gridStoragePerson.VisibleIndex = 5;
            // 
            // gridQualityPerson
            // 
            this.gridQualityPerson.Caption = "质检员";
            this.gridQualityPerson.FieldName = "QualityPersonName";
            this.gridQualityPerson.Name = "gridQualityPerson";
            this.gridQualityPerson.Visible = true;
            this.gridQualityPerson.VisibleIndex = 6;
            // 
            // gridProjectPerson
            // 
            this.gridProjectPerson.Caption = "工程员";
            this.gridProjectPerson.FieldName = "ProjectPersonName";
            this.gridProjectPerson.Name = "gridProjectPerson";
            this.gridProjectPerson.Visible = true;
            this.gridProjectPerson.VisibleIndex = 7;
            // 
            // gridStockPerson
            // 
            this.gridStockPerson.Caption = "采购员";
            this.gridStockPerson.FieldName = "StockPersonName";
            this.gridStockPerson.Name = "gridStockPerson";
            this.gridStockPerson.Visible = true;
            this.gridStockPerson.VisibleIndex = 8;
            // 
            // gridRejectOrderGuid
            // 
            this.gridRejectOrderGuid.Caption = "RejectOrderGuid";
            this.gridRejectOrderGuid.FieldName = "RejectOrderGuid";
            this.gridRejectOrderGuid.Name = "gridRejectOrderGuid";
            // 
            // gridCheckName
            // 
            this.gridCheckName.Caption = "审核人";
            this.gridCheckName.FieldName = "CheckName";
            this.gridCheckName.Name = "gridCheckName";
            this.gridCheckName.Visible = true;
            this.gridCheckName.VisibleIndex = 9;
            // 
            // gridCheckName2
            // 
            this.gridCheckName2.Caption = "二审核人";
            this.gridCheckName2.FieldName = "CheckName2";
            this.gridCheckName2.Name = "gridCheckName2";
            this.gridCheckName2.Visible = true;
            this.gridCheckName2.VisibleIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSelectRejectStorage);
            this.panel1.Controls.Add(this.txtRejectStorage);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.chkCheck2);
            this.panel1.Controls.Add(this.chkCheck);
            this.panel1.Controls.Add(this.txtClientOrderID);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtProductType);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnQty);
            this.panel1.Controls.Add(this.dtpRejectOrderEndDate);
            this.panel1.Controls.Add(this.dtpRejectOrderBeginDate);
            this.panel1.Controls.Add(this.txtRejectOrderID);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 90);
            this.panel1.TabIndex = 117;
            // 
            // btnSelectRejectStorage
            // 
            this.btnSelectRejectStorage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectRejectStorage.BackgroundImage")));
            this.btnSelectRejectStorage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectRejectStorage.Location = new System.Drawing.Point(186, 53);
            this.btnSelectRejectStorage.Name = "btnSelectRejectStorage";
            this.btnSelectRejectStorage.Size = new System.Drawing.Size(25, 22);
            this.btnSelectRejectStorage.TabIndex = 196;
            this.btnSelectRejectStorage.UseVisualStyleBackColor = true;
            this.btnSelectRejectStorage.Click += new System.EventHandler(this.btnSelectRejectStorage_Click);
            // 
            // txtRejectStorage
            // 
            this.txtRejectStorage.BackColor = System.Drawing.Color.White;
            this.txtRejectStorage.Location = new System.Drawing.Point(70, 53);
            this.txtRejectStorage.Name = "txtRejectStorage";
            this.txtRejectStorage.ReadOnly = true;
            this.txtRejectStorage.Size = new System.Drawing.Size(120, 21);
            this.txtRejectStorage.TabIndex = 195;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 194;
            this.label17.Text = "报废仓库：";
            // 
            // chkCheck2
            // 
            this.chkCheck2.AutoSize = true;
            this.chkCheck2.Location = new System.Drawing.Point(682, 56);
            this.chkCheck2.Name = "chkCheck2";
            this.chkCheck2.Size = new System.Drawing.Size(72, 16);
            this.chkCheck2.TabIndex = 160;
            this.chkCheck2.Text = "二级审核";
            this.chkCheck2.UseVisualStyleBackColor = true;
            // 
            // chkCheck
            // 
            this.chkCheck.AutoSize = true;
            this.chkCheck.Location = new System.Drawing.Point(628, 56);
            this.chkCheck.Name = "chkCheck";
            this.chkCheck.Size = new System.Drawing.Size(48, 16);
            this.chkCheck.TabIndex = 159;
            this.chkCheck.Text = "审核";
            this.chkCheck.UseVisualStyleBackColor = true;
            // 
            // txtClientOrderID
            // 
            this.txtClientOrderID.Location = new System.Drawing.Point(292, 52);
            this.txtClientOrderID.Name = "txtClientOrderID";
            this.txtClientOrderID.Size = new System.Drawing.Size(125, 21);
            this.txtClientOrderID.TabIndex = 139;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(219, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 138;
            this.label14.Text = "客户订单号：";
            // 
            // txtProductType
            // 
            this.txtProductType.Location = new System.Drawing.Point(494, 52);
            this.txtProductType.Name = "txtProductType";
            this.txtProductType.Size = new System.Drawing.Size(128, 21);
            this.txtProductType.TabIndex = 137;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(426, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 136;
            this.label13.Text = "产品型号：";
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
            this.btnQty.Location = new System.Drawing.Point(668, 17);
            this.btnQty.Name = "btnQty";
            this.btnQty.Size = new System.Drawing.Size(98, 28);
            this.btnQty.TabIndex = 133;
            this.btnQty.Text = "查询";
            this.btnQty.UseVisualStyleBackColor = true;
            this.btnQty.Click += new System.EventHandler(this.btnQty_Click);
            // 
            // dtpRejectOrderEndDate
            // 
            this.dtpRejectOrderEndDate.EditValue = null;
            this.dtpRejectOrderEndDate.Location = new System.Drawing.Point(494, 15);
            this.dtpRejectOrderEndDate.Name = "dtpRejectOrderEndDate";
            this.dtpRejectOrderEndDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dtpRejectOrderEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpRejectOrderEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpRejectOrderEndDate.Size = new System.Drawing.Size(128, 21);
            this.dtpRejectOrderEndDate.TabIndex = 130;
            // 
            // dtpRejectOrderBeginDate
            // 
            this.dtpRejectOrderBeginDate.EditValue = null;
            this.dtpRejectOrderBeginDate.Location = new System.Drawing.Point(289, 15);
            this.dtpRejectOrderBeginDate.Name = "dtpRejectOrderBeginDate";
            this.dtpRejectOrderBeginDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dtpRejectOrderBeginDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpRejectOrderBeginDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpRejectOrderBeginDate.Size = new System.Drawing.Size(128, 21);
            this.dtpRejectOrderBeginDate.TabIndex = 129;
            // 
            // txtRejectOrderID
            // 
            this.txtRejectOrderID.Location = new System.Drawing.Point(70, 17);
            this.txtRejectOrderID.Name = "txtRejectOrderID";
            this.txtRejectOrderID.Size = new System.Drawing.Size(120, 21);
            this.txtRejectOrderID.TabIndex = 125;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 124;
            this.label8.Text = "报废单号";
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
            this.btnAdd.Size = new System.Drawing.Size(85, 22);
            this.btnAdd.Text = "添加报废单";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tsbedit
            // 
            this.tsbedit.Image = ((System.Drawing.Image)(resources.GetObject("tsbedit.Image")));
            this.tsbedit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbedit.Name = "tsbedit";
            this.tsbedit.Size = new System.Drawing.Size(85, 22);
            this.tsbedit.Text = "编辑报废单";
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
            this.exit.Click += new System.EventHandler(this.exit_Click_1);
            // 
            // gridRejectStorage
            // 
            this.gridRejectStorage.Caption = "报废仓库";
            this.gridRejectStorage.FieldName = "RejectStorageName";
            this.gridRejectStorage.Name = "gridRejectStorage";
            this.gridRejectStorage.OptionsColumn.AllowEdit = false;
            this.gridRejectStorage.Visible = true;
            this.gridRejectStorage.VisibleIndex = 4;
            // 
            // frmRejectOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 580);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmRejectOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "报废单";
            this.Load += new System.EventHandler(this.frmRejectOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRejectOrderEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRejectOrderEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRejectOrderBeginDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRejectOrderBeginDate.Properties)).EndInit();
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
        private DevExpress.XtraEditors.DateEdit dtpRejectOrderEndDate;
        private DevExpress.XtraEditors.DateEdit dtpRejectOrderBeginDate;
        private System.Windows.Forms.TextBox txtRejectOrderID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton tsbedit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton exit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn gridProductType;
        private DevExpress.XtraGrid.Columns.GridColumn gridClientOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn gridRejectOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridStoragePerson;
        private DevExpress.XtraGrid.Columns.GridColumn gridQualityPerson;
        private DevExpress.XtraGrid.Columns.GridColumn gridProjectPerson;
        private DevExpress.XtraGrid.Columns.GridColumn gridRejectOrderGuid;
        private DevExpress.XtraGrid.Columns.GridColumn gridStockPerson;
        private System.Windows.Forms.TextBox txtClientOrderID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtProductType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkCheck2;
        private System.Windows.Forms.CheckBox chkCheck;
        private DevExpress.XtraGrid.Columns.GridColumn gridRejectOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn gridCheckName;
        private DevExpress.XtraGrid.Columns.GridColumn gridCheckName2;
        private System.Windows.Forms.Button btnSelectRejectStorage;
        private System.Windows.Forms.TextBox txtRejectStorage;
        private System.Windows.Forms.Label label17;
        private DevExpress.XtraGrid.Columns.GridColumn gridRejectStorage;
    }
}