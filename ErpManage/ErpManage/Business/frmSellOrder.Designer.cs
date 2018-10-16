namespace ErpManage.Business
{
    partial class frmSellOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSellOrder));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridSellOrderGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridgridSellOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSellOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridOutStorage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridStoragePerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridQualityPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCreateGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCheckName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCheckName2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkCheck2 = new System.Windows.Forms.CheckBox();
            this.chkCheck = new System.Windows.Forms.CheckBox();
            this.btnSelectOutStorage = new System.Windows.Forms.Button();
            this.txtOutStorage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSelectQualityPerson = new System.Windows.Forms.Button();
            this.txtQualityPerson = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectStoragePerson = new System.Windows.Forms.Button();
            this.txtStoragePerson = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectClient = new System.Windows.Forms.Button();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnQty = new System.Windows.Forms.Button();
            this.dtpSellOrderEndDate = new DevExpress.XtraEditors.DateEdit();
            this.dtpSellOrderBeginDate = new DevExpress.XtraEditors.DateEdit();
            this.txtSellOrderID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbedit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.gridShipping = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSellOrderEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSellOrderEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSellOrderBeginDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSellOrderBeginDate.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 144);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(822, 436);
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
            this.gridSellOrderGuid,
            this.gridgridSellOrderID,
            this.gridSellOrderDate,
            this.gridClient,
            this.gridOutStorage,
            this.gridStoragePerson,
            this.gridQualityPerson,
            this.gridShipping,
            this.gridCreateGuid,
            this.gridCreateDate,
            this.gridCheckName,
            this.gridCheckName2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridSellOrderGuid
            // 
            this.gridSellOrderGuid.Caption = "SellOrderGuid";
            this.gridSellOrderGuid.FieldName = "SellOrderGuid";
            this.gridSellOrderGuid.Name = "gridSellOrderGuid";
            // 
            // gridgridSellOrderID
            // 
            this.gridgridSellOrderID.Caption = "销售出库单号";
            this.gridgridSellOrderID.FieldName = "SellOrderID";
            this.gridgridSellOrderID.Name = "gridgridSellOrderID";
            this.gridgridSellOrderID.Visible = true;
            this.gridgridSellOrderID.VisibleIndex = 0;
            // 
            // gridSellOrderDate
            // 
            this.gridSellOrderDate.Caption = "开单日期";
            this.gridSellOrderDate.FieldName = "SellOrderDate";
            this.gridSellOrderDate.Name = "gridSellOrderDate";
            this.gridSellOrderDate.Visible = true;
            this.gridSellOrderDate.VisibleIndex = 1;
            // 
            // gridClient
            // 
            this.gridClient.Caption = "客户名称";
            this.gridClient.FieldName = "ClientName";
            this.gridClient.Name = "gridClient";
            this.gridClient.Visible = true;
            this.gridClient.VisibleIndex = 2;
            // 
            // gridOutStorage
            // 
            this.gridOutStorage.Caption = "出货仓库";
            this.gridOutStorage.FieldName = "OutStorageName";
            this.gridOutStorage.Name = "gridOutStorage";
            this.gridOutStorage.Visible = true;
            this.gridOutStorage.VisibleIndex = 3;
            // 
            // gridStoragePerson
            // 
            this.gridStoragePerson.Caption = "仓管员";
            this.gridStoragePerson.FieldName = "StoragePersonName";
            this.gridStoragePerson.Name = "gridStoragePerson";
            this.gridStoragePerson.Visible = true;
            this.gridStoragePerson.VisibleIndex = 4;
            // 
            // gridQualityPerson
            // 
            this.gridQualityPerson.Caption = "质检员";
            this.gridQualityPerson.FieldName = "QualityPersonName";
            this.gridQualityPerson.Name = "gridQualityPerson";
            this.gridQualityPerson.Visible = true;
            this.gridQualityPerson.VisibleIndex = 5;
            // 
            // gridCreateGuid
            // 
            this.gridCreateGuid.Caption = "制单人";
            this.gridCreateGuid.FieldName = "CreateName";
            this.gridCreateGuid.Name = "gridCreateGuid";
            this.gridCreateGuid.Visible = true;
            this.gridCreateGuid.VisibleIndex = 7;
            // 
            // gridCreateDate
            // 
            this.gridCreateDate.Caption = "制单日期";
            this.gridCreateDate.FieldName = "CreateDate";
            this.gridCreateDate.Name = "gridCreateDate";
            this.gridCreateDate.Visible = true;
            this.gridCreateDate.VisibleIndex = 8;
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
            this.panel1.Controls.Add(this.chkCheck2);
            this.panel1.Controls.Add(this.chkCheck);
            this.panel1.Controls.Add(this.btnSelectOutStorage);
            this.panel1.Controls.Add(this.txtOutStorage);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnSelectQualityPerson);
            this.panel1.Controls.Add(this.txtQualityPerson);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSelectStoragePerson);
            this.panel1.Controls.Add(this.txtStoragePerson);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSelectClient);
            this.panel1.Controls.Add(this.txtClient);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnQty);
            this.panel1.Controls.Add(this.dtpSellOrderEndDate);
            this.panel1.Controls.Add(this.dtpSellOrderBeginDate);
            this.panel1.Controls.Add(this.txtSellOrderID);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 119);
            this.panel1.TabIndex = 117;
            // 
            // chkCheck2
            // 
            this.chkCheck2.AutoSize = true;
            this.chkCheck2.Location = new System.Drawing.Point(369, 86);
            this.chkCheck2.Name = "chkCheck2";
            this.chkCheck2.Size = new System.Drawing.Size(72, 16);
            this.chkCheck2.TabIndex = 171;
            this.chkCheck2.Text = "二级审核";
            this.chkCheck2.UseVisualStyleBackColor = true;
            // 
            // chkCheck
            // 
            this.chkCheck.AutoSize = true;
            this.chkCheck.Location = new System.Drawing.Point(304, 86);
            this.chkCheck.Name = "chkCheck";
            this.chkCheck.Size = new System.Drawing.Size(48, 16);
            this.chkCheck.TabIndex = 170;
            this.chkCheck.Text = "审核";
            this.chkCheck.UseVisualStyleBackColor = true;
            // 
            // btnSelectOutStorage
            // 
            this.btnSelectOutStorage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectOutStorage.BackgroundImage")));
            this.btnSelectOutStorage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectOutStorage.Location = new System.Drawing.Point(219, 80);
            this.btnSelectOutStorage.Name = "btnSelectOutStorage";
            this.btnSelectOutStorage.Size = new System.Drawing.Size(25, 22);
            this.btnSelectOutStorage.TabIndex = 147;
            this.btnSelectOutStorage.UseVisualStyleBackColor = true;
            this.btnSelectOutStorage.Click += new System.EventHandler(this.btnSelectOutStorage_Click);
            // 
            // txtOutStorage
            // 
            this.txtOutStorage.BackColor = System.Drawing.Color.White;
            this.txtOutStorage.Location = new System.Drawing.Point(82, 81);
            this.txtOutStorage.Name = "txtOutStorage";
            this.txtOutStorage.ReadOnly = true;
            this.txtOutStorage.Size = new System.Drawing.Size(138, 21);
            this.txtOutStorage.TabIndex = 146;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 145;
            this.label7.Text = "出货仓库：";
            // 
            // btnSelectQualityPerson
            // 
            this.btnSelectQualityPerson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectQualityPerson.BackgroundImage")));
            this.btnSelectQualityPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectQualityPerson.Location = new System.Drawing.Point(633, 49);
            this.btnSelectQualityPerson.Name = "btnSelectQualityPerson";
            this.btnSelectQualityPerson.Size = new System.Drawing.Size(25, 22);
            this.btnSelectQualityPerson.TabIndex = 144;
            this.btnSelectQualityPerson.UseVisualStyleBackColor = true;
            this.btnSelectQualityPerson.Click += new System.EventHandler(this.btnSelectQualityPerson_Click);
            // 
            // txtQualityPerson
            // 
            this.txtQualityPerson.BackColor = System.Drawing.Color.White;
            this.txtQualityPerson.Location = new System.Drawing.Point(508, 50);
            this.txtQualityPerson.Name = "txtQualityPerson";
            this.txtQualityPerson.ReadOnly = true;
            this.txtQualityPerson.Size = new System.Drawing.Size(128, 21);
            this.txtQualityPerson.TabIndex = 143;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 142;
            this.label2.Text = "质检员：";
            // 
            // btnSelectStoragePerson
            // 
            this.btnSelectStoragePerson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectStoragePerson.BackgroundImage")));
            this.btnSelectStoragePerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectStoragePerson.Location = new System.Drawing.Point(429, 49);
            this.btnSelectStoragePerson.Name = "btnSelectStoragePerson";
            this.btnSelectStoragePerson.Size = new System.Drawing.Size(25, 22);
            this.btnSelectStoragePerson.TabIndex = 141;
            this.btnSelectStoragePerson.UseVisualStyleBackColor = true;
            this.btnSelectStoragePerson.Click += new System.EventHandler(this.btnSelectStoragePerson_Click);
            // 
            // txtStoragePerson
            // 
            this.txtStoragePerson.BackColor = System.Drawing.Color.White;
            this.txtStoragePerson.Location = new System.Drawing.Point(304, 50);
            this.txtStoragePerson.Name = "txtStoragePerson";
            this.txtStoragePerson.ReadOnly = true;
            this.txtStoragePerson.Size = new System.Drawing.Size(128, 21);
            this.txtStoragePerson.TabIndex = 140;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 139;
            this.label3.Text = "仓管员：";
            // 
            // btnSelectClient
            // 
            this.btnSelectClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectClient.BackgroundImage")));
            this.btnSelectClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectClient.Location = new System.Drawing.Point(218, 48);
            this.btnSelectClient.Name = "btnSelectClient";
            this.btnSelectClient.Size = new System.Drawing.Size(25, 22);
            this.btnSelectClient.TabIndex = 138;
            this.btnSelectClient.UseVisualStyleBackColor = true;
            this.btnSelectClient.Click += new System.EventHandler(this.btnSelectClient_Click);
            // 
            // txtClient
            // 
            this.txtClient.BackColor = System.Drawing.Color.White;
            this.txtClient.Location = new System.Drawing.Point(82, 49);
            this.txtClient.Name = "txtClient";
            this.txtClient.ReadOnly = true;
            this.txtClient.Size = new System.Drawing.Size(138, 21);
            this.txtClient.TabIndex = 137;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 136;
            this.label13.Text = "客户名称：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(442, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 135;
            this.label6.Text = "---->";
            // 
            // btnQty
            // 
            this.btnQty.Location = new System.Drawing.Point(679, 38);
            this.btnQty.Name = "btnQty";
            this.btnQty.Size = new System.Drawing.Size(86, 28);
            this.btnQty.TabIndex = 133;
            this.btnQty.Text = "查询";
            this.btnQty.UseVisualStyleBackColor = true;
            this.btnQty.Click += new System.EventHandler(this.btnQty_Click);
            // 
            // dtpSellOrderEndDate
            // 
            this.dtpSellOrderEndDate.EditValue = null;
            this.dtpSellOrderEndDate.Location = new System.Drawing.Point(508, 15);
            this.dtpSellOrderEndDate.Name = "dtpSellOrderEndDate";
            this.dtpSellOrderEndDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dtpSellOrderEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpSellOrderEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpSellOrderEndDate.Size = new System.Drawing.Size(128, 21);
            this.dtpSellOrderEndDate.TabIndex = 130;
            // 
            // dtpSellOrderBeginDate
            // 
            this.dtpSellOrderBeginDate.EditValue = null;
            this.dtpSellOrderBeginDate.Location = new System.Drawing.Point(304, 15);
            this.dtpSellOrderBeginDate.Name = "dtpSellOrderBeginDate";
            this.dtpSellOrderBeginDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dtpSellOrderBeginDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpSellOrderBeginDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpSellOrderBeginDate.Size = new System.Drawing.Size(128, 21);
            this.dtpSellOrderBeginDate.TabIndex = 129;
            // 
            // txtSellOrderID
            // 
            this.txtSellOrderID.Location = new System.Drawing.Point(82, 17);
            this.txtSellOrderID.Name = "txtSellOrderID";
            this.txtSellOrderID.Size = new System.Drawing.Size(138, 21);
            this.txtSellOrderID.TabIndex = 125;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 124;
            this.label8.Text = "销售出库单号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 20);
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
            this.btnAdd.Text = "添加销售出库单";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tsbedit
            // 
            this.tsbedit.Image = ((System.Drawing.Image)(resources.GetObject("tsbedit.Image")));
            this.tsbedit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbedit.Name = "tsbedit";
            this.tsbedit.Size = new System.Drawing.Size(109, 22);
            this.tsbedit.Text = "编辑销售出库单";
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
            // gridShipping
            // 
            this.gridShipping.Caption = "装运";
            this.gridShipping.FieldName = "Shipping";
            this.gridShipping.Name = "gridShipping";
            this.gridShipping.Visible = true;
            this.gridShipping.VisibleIndex = 6;
            // 
            // frmSellOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 580);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmSellOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "销售出库单";
            this.Load += new System.EventHandler(this.frmSellOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSellOrderEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSellOrderEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSellOrderBeginDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSellOrderBeginDate.Properties)).EndInit();
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
        private DevExpress.XtraEditors.DateEdit dtpSellOrderEndDate;
        private DevExpress.XtraEditors.DateEdit dtpSellOrderBeginDate;
        private System.Windows.Forms.TextBox txtSellOrderID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton tsbedit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton exit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn gridSellOrderGuid;
        private DevExpress.XtraGrid.Columns.GridColumn gridgridSellOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn gridSellOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridClient;
        private DevExpress.XtraGrid.Columns.GridColumn gridOutStorage;
        private DevExpress.XtraGrid.Columns.GridColumn gridStoragePerson;
        private DevExpress.XtraGrid.Columns.GridColumn gridQualityPerson;
        private DevExpress.XtraGrid.Columns.GridColumn gridCreateGuid;
        private DevExpress.XtraGrid.Columns.GridColumn gridCreateDate;
        private System.Windows.Forms.Button btnSelectOutStorage;
        private System.Windows.Forms.TextBox txtOutStorage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSelectQualityPerson;
        private System.Windows.Forms.TextBox txtQualityPerson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectStoragePerson;
        private System.Windows.Forms.TextBox txtStoragePerson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelectClient;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkCheck;
        private System.Windows.Forms.CheckBox chkCheck2;
        private DevExpress.XtraGrid.Columns.GridColumn gridCheckName;
        private DevExpress.XtraGrid.Columns.GridColumn gridCheckName2;
        private DevExpress.XtraGrid.Columns.GridColumn gridShipping;
    }
}