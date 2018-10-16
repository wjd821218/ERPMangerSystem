namespace ErpManage.StatReport
{
    partial class frmStockInOrderStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockInOrderStatus));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridStockInOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridStockInOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSupplierName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridInStorageName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridBatchNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridPaymentOrderStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridPaymentOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemSpinEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkEnd = new System.Windows.Forms.CheckBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtSupplierGuid = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpEndDate = new DevExpress.XtraEditors.DateEdit();
            this.dtpBeginDate = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStockInOrderID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQry = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBeginDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBeginDate.Properties)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(793, 25);
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
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridControl1.Location = new System.Drawing.Point(0, 124);
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
            this.gridControl1.Size = new System.Drawing.Size(793, 382);
            this.gridControl1.TabIndex = 141;
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
            this.gridStockInOrderID,
            this.gridStockInOrderDate,
            this.gridSupplierName,
            this.gridInStorageName,
            this.gridBatchNO,
            this.gridPaymentOrderStatus,
            this.gridPaymentOrderID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridStockInOrderID
            // 
            this.gridStockInOrderID.Caption = "采购入库单号";
            this.gridStockInOrderID.FieldName = "StockInOrderID";
            this.gridStockInOrderID.Name = "gridStockInOrderID";
            this.gridStockInOrderID.OptionsColumn.AllowEdit = false;
            this.gridStockInOrderID.OptionsColumn.AllowFocus = false;
            this.gridStockInOrderID.Visible = true;
            this.gridStockInOrderID.VisibleIndex = 0;
            this.gridStockInOrderID.Width = 116;
            // 
            // gridStockInOrderDate
            // 
            this.gridStockInOrderDate.Caption = "开单日期";
            this.gridStockInOrderDate.FieldName = "StockInOrderDate";
            this.gridStockInOrderDate.Name = "gridStockInOrderDate";
            this.gridStockInOrderDate.OptionsColumn.AllowEdit = false;
            this.gridStockInOrderDate.OptionsColumn.AllowFocus = false;
            this.gridStockInOrderDate.Visible = true;
            this.gridStockInOrderDate.VisibleIndex = 1;
            this.gridStockInOrderDate.Width = 98;
            // 
            // gridSupplierName
            // 
            this.gridSupplierName.Caption = "供应商";
            this.gridSupplierName.FieldName = "SupplierName";
            this.gridSupplierName.Name = "gridSupplierName";
            this.gridSupplierName.OptionsColumn.AllowEdit = false;
            this.gridSupplierName.OptionsColumn.AllowFocus = false;
            this.gridSupplierName.Visible = true;
            this.gridSupplierName.VisibleIndex = 2;
            this.gridSupplierName.Width = 189;
            // 
            // gridInStorageName
            // 
            this.gridInStorageName.Caption = "收货仓库";
            this.gridInStorageName.FieldName = "InStorageName";
            this.gridInStorageName.Name = "gridInStorageName";
            this.gridInStorageName.OptionsColumn.AllowEdit = false;
            this.gridInStorageName.OptionsColumn.AllowFocus = false;
            this.gridInStorageName.Visible = true;
            this.gridInStorageName.VisibleIndex = 3;
            this.gridInStorageName.Width = 93;
            // 
            // gridBatchNO
            // 
            this.gridBatchNO.Caption = "批号";
            this.gridBatchNO.FieldName = "BatchNO";
            this.gridBatchNO.Name = "gridBatchNO";
            this.gridBatchNO.OptionsColumn.AllowFocus = false;
            this.gridBatchNO.Visible = true;
            this.gridBatchNO.VisibleIndex = 4;
            this.gridBatchNO.Width = 73;
            // 
            // gridPaymentOrderStatus
            // 
            this.gridPaymentOrderStatus.Caption = "是否勾结";
            this.gridPaymentOrderStatus.FieldName = "PaymentOrderStatus";
            this.gridPaymentOrderStatus.Name = "gridPaymentOrderStatus";
            this.gridPaymentOrderStatus.OptionsColumn.AllowFocus = false;
            this.gridPaymentOrderStatus.Visible = true;
            this.gridPaymentOrderStatus.VisibleIndex = 5;
            this.gridPaymentOrderStatus.Width = 70;
            // 
            // gridPaymentOrderID
            // 
            this.gridPaymentOrderID.Caption = "关联付款单号";
            this.gridPaymentOrderID.FieldName = "PaymentOrderID";
            this.gridPaymentOrderID.Name = "gridPaymentOrderID";
            this.gridPaymentOrderID.OptionsColumn.AllowFocus = false;
            this.gridPaymentOrderID.Visible = true;
            this.gridPaymentOrderID.VisibleIndex = 6;
            this.gridPaymentOrderID.Width = 133;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.chkEnd);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.txtSupplierGuid);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpEndDate);
            this.panel1.Controls.Add(this.dtpBeginDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtStockInOrderID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnQry);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 99);
            this.panel1.TabIndex = 142;
            // 
            // chkEnd
            // 
            this.chkEnd.AutoSize = true;
            this.chkEnd.Location = new System.Drawing.Point(334, 54);
            this.chkEnd.Name = "chkEnd";
            this.chkEnd.Size = new System.Drawing.Size(60, 16);
            this.chkEnd.TabIndex = 184;
            this.chkEnd.Text = "已勾结";
            this.chkEnd.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelect.BackgroundImage")));
            this.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelect.Location = new System.Drawing.Point(237, 48);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(27, 24);
            this.btnSelect.TabIndex = 183;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtSupplierGuid
            // 
            this.txtSupplierGuid.BackColor = System.Drawing.Color.White;
            this.txtSupplierGuid.Location = new System.Drawing.Point(102, 50);
            this.txtSupplierGuid.Name = "txtSupplierGuid";
            this.txtSupplierGuid.ReadOnly = true;
            this.txtSupplierGuid.Size = new System.Drawing.Size(138, 21);
            this.txtSupplierGuid.TabIndex = 182;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 181;
            this.label13.Text = "供应商：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 180;
            this.label6.Text = "--->";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.EditValue = null;
            this.dtpEndDate.Location = new System.Drawing.Point(497, 18);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dtpEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpEndDate.Size = new System.Drawing.Size(104, 21);
            this.dtpEndDate.TabIndex = 179;
            // 
            // dtpBeginDate
            // 
            this.dtpBeginDate.EditValue = null;
            this.dtpBeginDate.Location = new System.Drawing.Point(334, 20);
            this.dtpBeginDate.Name = "dtpBeginDate";
            this.dtpBeginDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dtpBeginDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpBeginDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpBeginDate.Size = new System.Drawing.Size(122, 21);
            this.dtpBeginDate.TabIndex = 178;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 177;
            this.label2.Text = "开单日期";
            // 
            // txtStockInOrderID
            // 
            this.txtStockInOrderID.BackColor = System.Drawing.Color.White;
            this.txtStockInOrderID.Location = new System.Drawing.Point(102, 20);
            this.txtStockInOrderID.Name = "txtStockInOrderID";
            this.txtStockInOrderID.Size = new System.Drawing.Size(136, 21);
            this.txtStockInOrderID.TabIndex = 160;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 159;
            this.label1.Text = "采购入库单号";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(640, 54);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(71, 23);
            this.btnClear.TabIndex = 158;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnQry
            // 
            this.btnQry.Location = new System.Drawing.Point(640, 16);
            this.btnQry.Name = "btnQry";
            this.btnQry.Size = new System.Drawing.Size(71, 23);
            this.btnQry.TabIndex = 145;
            this.btnQry.Text = "查询";
            this.btnQry.UseVisualStyleBackColor = true;
            this.btnQry.Click += new System.EventHandler(this.btnQry_Click);
            // 
            // frmStockInOrderStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 506);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmStockInOrderStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "采购入库单开票报表";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBeginDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBeginDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton exit;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridStockInOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn gridStockInOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridSupplierName;
        private DevExpress.XtraGrid.Columns.GridColumn gridInStorageName;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQry;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtStockInOrderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtSupplierGuid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.DateEdit dtpEndDate;
        private DevExpress.XtraEditors.DateEdit dtpBeginDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkEnd;
        private DevExpress.XtraGrid.Columns.GridColumn gridBatchNO;
        private DevExpress.XtraGrid.Columns.GridColumn gridPaymentOrderStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gridPaymentOrderID;
    }
}