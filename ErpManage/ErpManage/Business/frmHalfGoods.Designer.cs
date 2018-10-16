namespace ErpManage.Business
{
    partial class frmHalfGoods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHalfGoods));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridHalfGoodsGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridHalfGoodsID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridHalfGoodsDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridIncomeDepot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridPlant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTransactorPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSatrapPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridQualityPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridDepotPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCheckName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBatchNO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelectIncomeDepot = new System.Windows.Forms.Button();
            this.txtIncomeDepot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkCheck = new System.Windows.Forms.CheckBox();
            this.btnSelectDepotPerson = new System.Windows.Forms.Button();
            this.txtDepotPerson = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSelectTransactorPerson = new System.Windows.Forms.Button();
            this.txtTransactorPerson = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpHalfGoodsEndDate = new DevExpress.XtraEditors.DateEdit();
            this.dtpHalfGoodsBeginDate = new DevExpress.XtraEditors.DateEdit();
            this.txtHalfGoodsID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQty = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbedit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.gridBatchNo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpHalfGoodsEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpHalfGoodsEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpHalfGoodsBeginDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpHalfGoodsBeginDate.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 138);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(822, 442);
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
            this.gridHalfGoodsGuid,
            this.gridHalfGoodsID,
            this.gridHalfGoodsDate,
            this.gridIncomeDepot,
            this.gridPlant,
            this.gridTransactorPerson,
            this.gridSatrapPerson,
            this.gridQualityPerson,
            this.gridDepotPerson,
            this.gridCheckName,
            this.gridBatchNo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridHalfGoodsGuid
            // 
            this.gridHalfGoodsGuid.Caption = "HalfGoodsGuid";
            this.gridHalfGoodsGuid.FieldName = "HalfGoodsGuid";
            this.gridHalfGoodsGuid.Name = "gridHalfGoodsGuid";
            // 
            // gridHalfGoodsID
            // 
            this.gridHalfGoodsID.Caption = "半成品入库单号";
            this.gridHalfGoodsID.FieldName = "HalfGoodsID";
            this.gridHalfGoodsID.Name = "gridHalfGoodsID";
            this.gridHalfGoodsID.Visible = true;
            this.gridHalfGoodsID.VisibleIndex = 0;
            this.gridHalfGoodsID.Width = 106;
            // 
            // gridHalfGoodsDate
            // 
            this.gridHalfGoodsDate.Caption = "开单日期";
            this.gridHalfGoodsDate.FieldName = "HalfGoodsDate";
            this.gridHalfGoodsDate.Name = "gridHalfGoodsDate";
            this.gridHalfGoodsDate.Visible = true;
            this.gridHalfGoodsDate.VisibleIndex = 1;
            this.gridHalfGoodsDate.Width = 99;
            // 
            // gridIncomeDepot
            // 
            this.gridIncomeDepot.Caption = "收货仓库";
            this.gridIncomeDepot.FieldName = "IncomeDepotName";
            this.gridIncomeDepot.Name = "gridIncomeDepot";
            this.gridIncomeDepot.Visible = true;
            this.gridIncomeDepot.VisibleIndex = 2;
            this.gridIncomeDepot.Width = 99;
            // 
            // gridPlant
            // 
            this.gridPlant.Caption = "车间";
            this.gridPlant.FieldName = "PlantName";
            this.gridPlant.Name = "gridPlant";
            this.gridPlant.Visible = true;
            this.gridPlant.VisibleIndex = 3;
            this.gridPlant.Width = 99;
            // 
            // gridTransactorPerson
            // 
            this.gridTransactorPerson.Caption = "经办人";
            this.gridTransactorPerson.FieldName = "TransactorPersonName";
            this.gridTransactorPerson.Name = "gridTransactorPerson";
            this.gridTransactorPerson.Visible = true;
            this.gridTransactorPerson.VisibleIndex = 4;
            this.gridTransactorPerson.Width = 99;
            // 
            // gridSatrapPerson
            // 
            this.gridSatrapPerson.Caption = "主管";
            this.gridSatrapPerson.FieldName = "SatrapPersonName";
            this.gridSatrapPerson.Name = "gridSatrapPerson";
            this.gridSatrapPerson.Visible = true;
            this.gridSatrapPerson.VisibleIndex = 5;
            this.gridSatrapPerson.Width = 99;
            // 
            // gridQualityPerson
            // 
            this.gridQualityPerson.Caption = "品管";
            this.gridQualityPerson.FieldName = "QualityPersonName";
            this.gridQualityPerson.Name = "gridQualityPerson";
            this.gridQualityPerson.Visible = true;
            this.gridQualityPerson.VisibleIndex = 6;
            this.gridQualityPerson.Width = 99;
            // 
            // gridDepotPerson
            // 
            this.gridDepotPerson.Caption = "仓管";
            this.gridDepotPerson.FieldName = "DepotPersonName";
            this.gridDepotPerson.Name = "gridDepotPerson";
            this.gridDepotPerson.Visible = true;
            this.gridDepotPerson.VisibleIndex = 7;
            this.gridDepotPerson.Width = 101;
            // 
            // gridCheckName
            // 
            this.gridCheckName.Caption = "审核人";
            this.gridCheckName.FieldName = "CheckName";
            this.gridCheckName.Name = "gridCheckName";
            this.gridCheckName.Visible = true;
            this.gridCheckName.VisibleIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBatchNO);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnSelectIncomeDepot);
            this.panel1.Controls.Add(this.txtIncomeDepot);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.chkCheck);
            this.panel1.Controls.Add(this.btnSelectDepotPerson);
            this.panel1.Controls.Add(this.txtDepotPerson);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btnSelectTransactorPerson);
            this.panel1.Controls.Add(this.txtTransactorPerson);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpHalfGoodsEndDate);
            this.panel1.Controls.Add(this.dtpHalfGoodsBeginDate);
            this.panel1.Controls.Add(this.txtHalfGoodsID);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnQty);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 113);
            this.panel1.TabIndex = 117;
            // 
            // txtBatchNO
            // 
            this.txtBatchNO.Location = new System.Drawing.Point(83, 86);
            this.txtBatchNO.Name = "txtBatchNO";
            this.txtBatchNO.Size = new System.Drawing.Size(130, 21);
            this.txtBatchNO.TabIndex = 206;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 205;
            this.label4.Text = "批号：";
            // 
            // btnSelectIncomeDepot
            // 
            this.btnSelectIncomeDepot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectIncomeDepot.BackgroundImage")));
            this.btnSelectIncomeDepot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectIncomeDepot.Location = new System.Drawing.Point(640, 52);
            this.btnSelectIncomeDepot.Name = "btnSelectIncomeDepot";
            this.btnSelectIncomeDepot.Size = new System.Drawing.Size(25, 22);
            this.btnSelectIncomeDepot.TabIndex = 179;
            this.btnSelectIncomeDepot.UseVisualStyleBackColor = true;
            this.btnSelectIncomeDepot.Click += new System.EventHandler(this.btnSelectIncomeDepot_Click);
            // 
            // txtIncomeDepot
            // 
            this.txtIncomeDepot.BackColor = System.Drawing.Color.White;
            this.txtIncomeDepot.Location = new System.Drawing.Point(514, 53);
            this.txtIncomeDepot.Name = "txtIncomeDepot";
            this.txtIncomeDepot.ReadOnly = true;
            this.txtIncomeDepot.Size = new System.Drawing.Size(131, 21);
            this.txtIncomeDepot.TabIndex = 178;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 177;
            this.label7.Text = "收货仓库：";
            // 
            // chkCheck
            // 
            this.chkCheck.AutoSize = true;
            this.chkCheck.Location = new System.Drawing.Point(686, 58);
            this.chkCheck.Name = "chkCheck";
            this.chkCheck.Size = new System.Drawing.Size(48, 16);
            this.chkCheck.TabIndex = 176;
            this.chkCheck.Text = "审核";
            this.chkCheck.UseVisualStyleBackColor = true;
            // 
            // btnSelectDepotPerson
            // 
            this.btnSelectDepotPerson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectDepotPerson.BackgroundImage")));
            this.btnSelectDepotPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectDepotPerson.Location = new System.Drawing.Point(416, 51);
            this.btnSelectDepotPerson.Name = "btnSelectDepotPerson";
            this.btnSelectDepotPerson.Size = new System.Drawing.Size(25, 22);
            this.btnSelectDepotPerson.TabIndex = 175;
            this.btnSelectDepotPerson.UseVisualStyleBackColor = true;
            this.btnSelectDepotPerson.Click += new System.EventHandler(this.btnSelectDepotPerson_Click);
            // 
            // txtDepotPerson
            // 
            this.txtDepotPerson.BackColor = System.Drawing.Color.White;
            this.txtDepotPerson.Location = new System.Drawing.Point(290, 52);
            this.txtDepotPerson.Name = "txtDepotPerson";
            this.txtDepotPerson.ReadOnly = true;
            this.txtDepotPerson.Size = new System.Drawing.Size(128, 21);
            this.txtDepotPerson.TabIndex = 174;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(236, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 173;
            this.label12.Text = "仓管员：";
            // 
            // btnSelectTransactorPerson
            // 
            this.btnSelectTransactorPerson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectTransactorPerson.BackgroundImage")));
            this.btnSelectTransactorPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectTransactorPerson.Location = new System.Drawing.Point(210, 52);
            this.btnSelectTransactorPerson.Name = "btnSelectTransactorPerson";
            this.btnSelectTransactorPerson.Size = new System.Drawing.Size(25, 22);
            this.btnSelectTransactorPerson.TabIndex = 172;
            this.btnSelectTransactorPerson.UseVisualStyleBackColor = true;
            this.btnSelectTransactorPerson.Click += new System.EventHandler(this.btnSelectTransactorPerson_Click);
            // 
            // txtTransactorPerson
            // 
            this.txtTransactorPerson.BackColor = System.Drawing.Color.White;
            this.txtTransactorPerson.Location = new System.Drawing.Point(83, 53);
            this.txtTransactorPerson.Name = "txtTransactorPerson";
            this.txtTransactorPerson.ReadOnly = true;
            this.txtTransactorPerson.Size = new System.Drawing.Size(130, 21);
            this.txtTransactorPerson.TabIndex = 171;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 170;
            this.label2.Text = "经办人：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 169;
            this.label6.Text = "---->";
            // 
            // dtpHalfGoodsEndDate
            // 
            this.dtpHalfGoodsEndDate.EditValue = null;
            this.dtpHalfGoodsEndDate.Location = new System.Drawing.Point(514, 16);
            this.dtpHalfGoodsEndDate.Name = "dtpHalfGoodsEndDate";
            this.dtpHalfGoodsEndDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dtpHalfGoodsEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpHalfGoodsEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpHalfGoodsEndDate.Size = new System.Drawing.Size(128, 21);
            this.dtpHalfGoodsEndDate.TabIndex = 168;
            // 
            // dtpHalfGoodsBeginDate
            // 
            this.dtpHalfGoodsBeginDate.EditValue = null;
            this.dtpHalfGoodsBeginDate.Location = new System.Drawing.Point(290, 16);
            this.dtpHalfGoodsBeginDate.Name = "dtpHalfGoodsBeginDate";
            this.dtpHalfGoodsBeginDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dtpHalfGoodsBeginDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpHalfGoodsBeginDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpHalfGoodsBeginDate.Size = new System.Drawing.Size(128, 21);
            this.dtpHalfGoodsBeginDate.TabIndex = 167;
            // 
            // txtHalfGoodsID
            // 
            this.txtHalfGoodsID.Location = new System.Drawing.Point(83, 18);
            this.txtHalfGoodsID.Name = "txtHalfGoodsID";
            this.txtHalfGoodsID.Size = new System.Drawing.Size(130, 21);
            this.txtHalfGoodsID.TabIndex = 166;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 165;
            this.label8.Text = "出库单号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 164;
            this.label1.Text = "开单日期";
            // 
            // btnQty
            // 
            this.btnQty.Location = new System.Drawing.Point(706, 19);
            this.btnQty.Name = "btnQty";
            this.btnQty.Size = new System.Drawing.Size(86, 28);
            this.btnQty.TabIndex = 133;
            this.btnQty.Text = "查询";
            this.btnQty.UseVisualStyleBackColor = true;
            this.btnQty.Click += new System.EventHandler(this.btnQty_Click);
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
            this.btnAdd.Text = "添加入库单";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tsbedit
            // 
            this.tsbedit.Image = ((System.Drawing.Image)(resources.GetObject("tsbedit.Image")));
            this.tsbedit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbedit.Name = "tsbedit";
            this.tsbedit.Size = new System.Drawing.Size(85, 22);
            this.tsbedit.Text = "编辑入库单";
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
            // gridBatchNo
            // 
            this.gridBatchNo.Caption = "批号";
            this.gridBatchNo.FieldName = "BatchNo";
            this.gridBatchNo.Name = "gridBatchNo";
            this.gridBatchNo.OptionsColumn.AllowEdit = false;
            this.gridBatchNo.Visible = true;
            this.gridBatchNo.VisibleIndex = 9;
            // 
            // frmHalfGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 580);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmHalfGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "半成品入库单";
            this.Load += new System.EventHandler(this.frmHalfGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpHalfGoodsEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpHalfGoodsEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpHalfGoodsBeginDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpHalfGoodsBeginDate.Properties)).EndInit();
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton tsbedit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton exit;
        private DevExpress.XtraGrid.Columns.GridColumn gridHalfGoodsGuid;
        private DevExpress.XtraGrid.Columns.GridColumn gridHalfGoodsID;
        private DevExpress.XtraGrid.Columns.GridColumn gridHalfGoodsDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridIncomeDepot;
        private DevExpress.XtraGrid.Columns.GridColumn gridPlant;
        private DevExpress.XtraGrid.Columns.GridColumn gridTransactorPerson;
        private DevExpress.XtraGrid.Columns.GridColumn gridSatrapPerson;
        private DevExpress.XtraGrid.Columns.GridColumn gridQualityPerson;
        private DevExpress.XtraGrid.Columns.GridColumn gridDepotPerson;
        private System.Windows.Forms.CheckBox chkCheck;
        private System.Windows.Forms.Button btnSelectDepotPerson;
        private System.Windows.Forms.TextBox txtDepotPerson;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSelectTransactorPerson;
        private System.Windows.Forms.TextBox txtTransactorPerson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.DateEdit dtpHalfGoodsEndDate;
        private DevExpress.XtraEditors.DateEdit dtpHalfGoodsBeginDate;
        private System.Windows.Forms.TextBox txtHalfGoodsID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectIncomeDepot;
        private System.Windows.Forms.TextBox txtIncomeDepot;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraGrid.Columns.GridColumn gridCheckName;
        private System.Windows.Forms.TextBox txtBatchNO;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.Columns.GridColumn gridBatchNo;
    }
}