namespace ErpManage.Business
{
    partial class frmRemoveBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemoveBill));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridRemoveBillGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridRemoveBillID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridRemoveBillDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridDepotOut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridDepotIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridHandlePerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCheckName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkCheck = new System.Windows.Forms.CheckBox();
            this.btnSelectTransactorPerson = new System.Windows.Forms.Button();
            this.txtHandlePerson = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnQty = new System.Windows.Forms.Button();
            this.dtpRemoveBillEndDate = new DevExpress.XtraEditors.DateEdit();
            this.dtpRemoveBillBeginDate = new DevExpress.XtraEditors.DateEdit();
            this.txtRemoveBillID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbedit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.gridCheckName2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRemoveBillEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRemoveBillEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRemoveBillBeginDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRemoveBillBeginDate.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 114);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(756, 466);
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
            this.gridRemoveBillGuid,
            this.gridRemoveBillID,
            this.gridRemoveBillDate,
            this.gridDepotOut,
            this.gridDepotIn,
            this.gridHandlePerson,
            this.gridCheckName,
            this.gridCheckName2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridRemoveBillGuid
            // 
            this.gridRemoveBillGuid.Caption = "ConsignGuid";
            this.gridRemoveBillGuid.FieldName = "ConsignGuid";
            this.gridRemoveBillGuid.Name = "gridRemoveBillGuid";
            // 
            // gridRemoveBillID
            // 
            this.gridRemoveBillID.Caption = "调拨单号";
            this.gridRemoveBillID.FieldName = "RemoveBillID";
            this.gridRemoveBillID.Name = "gridRemoveBillID";
            this.gridRemoveBillID.Visible = true;
            this.gridRemoveBillID.VisibleIndex = 0;
            this.gridRemoveBillID.Width = 103;
            // 
            // gridRemoveBillDate
            // 
            this.gridRemoveBillDate.Caption = "开单日期";
            this.gridRemoveBillDate.FieldName = "RemoveBillDate";
            this.gridRemoveBillDate.Name = "gridRemoveBillDate";
            this.gridRemoveBillDate.Visible = true;
            this.gridRemoveBillDate.VisibleIndex = 1;
            this.gridRemoveBillDate.Width = 84;
            // 
            // gridDepotOut
            // 
            this.gridDepotOut.Caption = "调出仓库";
            this.gridDepotOut.FieldName = "DepotOutName";
            this.gridDepotOut.Name = "gridDepotOut";
            this.gridDepotOut.Visible = true;
            this.gridDepotOut.VisibleIndex = 2;
            this.gridDepotOut.Width = 80;
            // 
            // gridDepotIn
            // 
            this.gridDepotIn.Caption = "调入仓库";
            this.gridDepotIn.FieldName = "DepotInName";
            this.gridDepotIn.Name = "gridDepotIn";
            this.gridDepotIn.Visible = true;
            this.gridDepotIn.VisibleIndex = 3;
            this.gridDepotIn.Width = 102;
            // 
            // gridHandlePerson
            // 
            this.gridHandlePerson.Caption = "调拨人";
            this.gridHandlePerson.FieldName = "HandlePersonName";
            this.gridHandlePerson.Name = "gridHandlePerson";
            this.gridHandlePerson.Visible = true;
            this.gridHandlePerson.VisibleIndex = 4;
            this.gridHandlePerson.Width = 128;
            // 
            // gridCheckName
            // 
            this.gridCheckName.Caption = "审核人";
            this.gridCheckName.FieldName = "CheckName";
            this.gridCheckName.Name = "gridCheckName";
            this.gridCheckName.Visible = true;
            this.gridCheckName.VisibleIndex = 5;
            this.gridCheckName.Width = 128;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkCheck);
            this.panel1.Controls.Add(this.btnSelectTransactorPerson);
            this.panel1.Controls.Add(this.txtHandlePerson);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnQty);
            this.panel1.Controls.Add(this.dtpRemoveBillEndDate);
            this.panel1.Controls.Add(this.dtpRemoveBillBeginDate);
            this.panel1.Controls.Add(this.txtRemoveBillID);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 89);
            this.panel1.TabIndex = 117;
            // 
            // chkCheck
            // 
            this.chkCheck.AutoSize = true;
            this.chkCheck.Location = new System.Drawing.Point(295, 49);
            this.chkCheck.Name = "chkCheck";
            this.chkCheck.Size = new System.Drawing.Size(48, 16);
            this.chkCheck.TabIndex = 155;
            this.chkCheck.Text = "审核";
            this.chkCheck.UseVisualStyleBackColor = true;
            // 
            // btnSelectTransactorPerson
            // 
            this.btnSelectTransactorPerson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectTransactorPerson.BackgroundImage")));
            this.btnSelectTransactorPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectTransactorPerson.Location = new System.Drawing.Point(211, 49);
            this.btnSelectTransactorPerson.Name = "btnSelectTransactorPerson";
            this.btnSelectTransactorPerson.Size = new System.Drawing.Size(25, 22);
            this.btnSelectTransactorPerson.TabIndex = 150;
            this.btnSelectTransactorPerson.UseVisualStyleBackColor = true;
            this.btnSelectTransactorPerson.Click += new System.EventHandler(this.btnSelectTransactorPerson_Click);
            // 
            // txtHandlePerson
            // 
            this.txtHandlePerson.BackColor = System.Drawing.Color.White;
            this.txtHandlePerson.Location = new System.Drawing.Point(83, 50);
            this.txtHandlePerson.Name = "txtHandlePerson";
            this.txtHandlePerson.ReadOnly = true;
            this.txtHandlePerson.Size = new System.Drawing.Size(130, 21);
            this.txtHandlePerson.TabIndex = 149;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 148;
            this.label5.Text = "调拨人";
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
            this.btnQty.Location = new System.Drawing.Point(645, 37);
            this.btnQty.Name = "btnQty";
            this.btnQty.Size = new System.Drawing.Size(86, 28);
            this.btnQty.TabIndex = 133;
            this.btnQty.Text = "查询";
            this.btnQty.UseVisualStyleBackColor = true;
            this.btnQty.Click += new System.EventHandler(this.btnQty_Click);
            // 
            // dtpRemoveBillEndDate
            // 
            this.dtpRemoveBillEndDate.EditValue = null;
            this.dtpRemoveBillEndDate.Location = new System.Drawing.Point(494, 15);
            this.dtpRemoveBillEndDate.Name = "dtpRemoveBillEndDate";
            this.dtpRemoveBillEndDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dtpRemoveBillEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpRemoveBillEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpRemoveBillEndDate.Size = new System.Drawing.Size(128, 21);
            this.dtpRemoveBillEndDate.TabIndex = 130;
            // 
            // dtpRemoveBillBeginDate
            // 
            this.dtpRemoveBillBeginDate.EditValue = null;
            this.dtpRemoveBillBeginDate.Location = new System.Drawing.Point(295, 16);
            this.dtpRemoveBillBeginDate.Name = "dtpRemoveBillBeginDate";
            this.dtpRemoveBillBeginDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dtpRemoveBillBeginDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpRemoveBillBeginDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpRemoveBillBeginDate.Size = new System.Drawing.Size(122, 21);
            this.dtpRemoveBillBeginDate.TabIndex = 129;
            // 
            // txtRemoveBillID
            // 
            this.txtRemoveBillID.Location = new System.Drawing.Point(82, 17);
            this.txtRemoveBillID.Name = "txtRemoveBillID";
            this.txtRemoveBillID.Size = new System.Drawing.Size(130, 21);
            this.txtRemoveBillID.TabIndex = 125;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 124;
            this.label8.Text = "调拨单号";
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
            this.toolStrip1.Size = new System.Drawing.Size(756, 25);
            this.toolStrip1.TabIndex = 115;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 22);
            this.btnAdd.Text = "添加调拨单";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tsbedit
            // 
            this.tsbedit.Image = ((System.Drawing.Image)(resources.GetObject("tsbedit.Image")));
            this.tsbedit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbedit.Name = "tsbedit";
            this.tsbedit.Size = new System.Drawing.Size(85, 22);
            this.tsbedit.Text = "编辑调拨单";
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
            // gridCheckName2
            // 
            this.gridCheckName2.Caption = "二审核人";
            this.gridCheckName2.FieldName = "CheckName2";
            this.gridCheckName2.Name = "gridCheckName2";
            this.gridCheckName2.Visible = true;
            this.gridCheckName2.VisibleIndex = 6;
            this.gridCheckName2.Width = 110;
            // 
            // frmRemoveBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 580);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmRemoveBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "调拨单";
            this.Load += new System.EventHandler(this.frmRemoveBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRemoveBillEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRemoveBillEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRemoveBillBeginDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRemoveBillBeginDate.Properties)).EndInit();
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
        private DevExpress.XtraEditors.DateEdit dtpRemoveBillEndDate;
        private DevExpress.XtraEditors.DateEdit dtpRemoveBillBeginDate;
        private System.Windows.Forms.TextBox txtRemoveBillID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton tsbedit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton exit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectTransactorPerson;
        private System.Windows.Forms.TextBox txtHandlePerson;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Columns.GridColumn gridRemoveBillGuid;
        private DevExpress.XtraGrid.Columns.GridColumn gridRemoveBillID;
        private DevExpress.XtraGrid.Columns.GridColumn gridRemoveBillDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridDepotOut;
        private DevExpress.XtraGrid.Columns.GridColumn gridDepotIn;
        private DevExpress.XtraGrid.Columns.GridColumn gridHandlePerson;
        private System.Windows.Forms.CheckBox chkCheck;
        private DevExpress.XtraGrid.Columns.GridColumn gridCheckName;
        private DevExpress.XtraGrid.Columns.GridColumn gridCheckName2;
    }
}