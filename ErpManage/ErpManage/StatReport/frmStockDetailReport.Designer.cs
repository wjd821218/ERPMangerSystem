namespace ErpManage.StatReport
{
    partial class frmStockDetailReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockDetailReport));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridBillGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridBillDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridBillID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridFlagName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridInQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridOutQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridDepotQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridFlag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemSpinEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaterialName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelectStorage = new System.Windows.Forms.Button();
            this.txtStorage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelectMaterialGuid = new System.Windows.Forms.Button();
            this.btnQry = new System.Windows.Forms.Button();
            this.txtMaterialGuid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.toolStrip1.Size = new System.Drawing.Size(689, 25);
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
            this.gridControl1.Location = new System.Drawing.Point(0, 108);
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
            this.gridControl1.Size = new System.Drawing.Size(689, 396);
            this.gridControl1.TabIndex = 141;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
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
            this.gridBillGuid,
            this.gridBillDate,
            this.gridBillID,
            this.gridFlagName,
            this.gridInQty,
            this.gridOutQty,
            this.gridDepotQty,
            this.gridFlag});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridBillGuid
            // 
            this.gridBillGuid.Caption = "BillGuid";
            this.gridBillGuid.FieldName = "BillGuid";
            this.gridBillGuid.Name = "gridBillGuid";
            this.gridBillGuid.OptionsColumn.AllowEdit = false;
            this.gridBillGuid.Width = 147;
            // 
            // gridBillDate
            // 
            this.gridBillDate.Caption = "开单日期";
            this.gridBillDate.FieldName = "BillDate";
            this.gridBillDate.Name = "gridBillDate";
            this.gridBillDate.OptionsColumn.AllowEdit = false;
            this.gridBillDate.Visible = true;
            this.gridBillDate.VisibleIndex = 0;
            this.gridBillDate.Width = 90;
            // 
            // gridBillID
            // 
            this.gridBillID.Caption = "单据编号";
            this.gridBillID.FieldName = "BillID";
            this.gridBillID.Name = "gridBillID";
            this.gridBillID.Visible = true;
            this.gridBillID.VisibleIndex = 1;
            this.gridBillID.Width = 111;
            // 
            // gridFlagName
            // 
            this.gridFlagName.Caption = "单据名称";
            this.gridFlagName.FieldName = "FlagName";
            this.gridFlagName.Name = "gridFlagName";
            this.gridFlagName.OptionsColumn.AllowEdit = false;
            this.gridFlagName.Visible = true;
            this.gridFlagName.VisibleIndex = 2;
            this.gridFlagName.Width = 94;
            // 
            // gridInQty
            // 
            this.gridInQty.Caption = "收入数量";
            this.gridInQty.DisplayFormat.FormatString = "0.###";
            this.gridInQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridInQty.FieldName = "InQty";
            this.gridInQty.Name = "gridInQty";
            this.gridInQty.OptionsColumn.AllowEdit = false;
            this.gridInQty.Visible = true;
            this.gridInQty.VisibleIndex = 3;
            this.gridInQty.Width = 70;
            // 
            // gridOutQty
            // 
            this.gridOutQty.Caption = "发出数量";
            this.gridOutQty.DisplayFormat.FormatString = "0.###";
            this.gridOutQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridOutQty.FieldName = "OutQty";
            this.gridOutQty.Name = "gridOutQty";
            this.gridOutQty.OptionsColumn.AllowEdit = false;
            this.gridOutQty.Visible = true;
            this.gridOutQty.VisibleIndex = 4;
            this.gridOutQty.Width = 114;
            // 
            // gridDepotQty
            // 
            this.gridDepotQty.Caption = "结存数量";
            this.gridDepotQty.DisplayFormat.FormatString = "0.###";
            this.gridDepotQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridDepotQty.FieldName = "DepotQty";
            this.gridDepotQty.Name = "gridDepotQty";
            this.gridDepotQty.OptionsColumn.AllowEdit = false;
            this.gridDepotQty.Visible = true;
            this.gridDepotQty.VisibleIndex = 5;
            this.gridDepotQty.Width = 189;
            // 
            // gridFlag
            // 
            this.gridFlag.Caption = "Flag";
            this.gridFlag.FieldName = "Flag";
            this.gridFlag.Name = "gridFlag";
            this.gridFlag.OptionsColumn.AllowEdit = false;
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
            this.panel1.Controls.Add(this.txtMaterialName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnSelectStorage);
            this.panel1.Controls.Add(this.txtStorage);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnSelectMaterialGuid);
            this.panel1.Controls.Add(this.btnQry);
            this.panel1.Controls.Add(this.txtMaterialGuid);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 83);
            this.panel1.TabIndex = 142;
            // 
            // txtMaterialName
            // 
            this.txtMaterialName.BackColor = System.Drawing.Color.White;
            this.txtMaterialName.Location = new System.Drawing.Point(469, 29);
            this.txtMaterialName.Name = "txtMaterialName";
            this.txtMaterialName.ReadOnly = true;
            this.txtMaterialName.Size = new System.Drawing.Size(110, 21);
            this.txtMaterialName.TabIndex = 156;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 157;
            this.label4.Text = "物料名称";
            // 
            // btnSelectStorage
            // 
            this.btnSelectStorage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectStorage.BackgroundImage")));
            this.btnSelectStorage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectStorage.Location = new System.Drawing.Point(177, 28);
            this.btnSelectStorage.Name = "btnSelectStorage";
            this.btnSelectStorage.Size = new System.Drawing.Size(25, 22);
            this.btnSelectStorage.TabIndex = 155;
            this.btnSelectStorage.UseVisualStyleBackColor = true;
            this.btnSelectStorage.Click += new System.EventHandler(this.btnSelectStorage_Click);
            // 
            // txtStorage
            // 
            this.txtStorage.BackColor = System.Drawing.Color.White;
            this.txtStorage.Location = new System.Drawing.Point(65, 29);
            this.txtStorage.Name = "txtStorage";
            this.txtStorage.ReadOnly = true;
            this.txtStorage.Size = new System.Drawing.Size(116, 21);
            this.txtStorage.TabIndex = 153;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 154;
            this.label5.Text = "仓库名称";
            // 
            // btnSelectMaterialGuid
            // 
            this.btnSelectMaterialGuid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectMaterialGuid.BackgroundImage")));
            this.btnSelectMaterialGuid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectMaterialGuid.Location = new System.Drawing.Point(378, 28);
            this.btnSelectMaterialGuid.Name = "btnSelectMaterialGuid";
            this.btnSelectMaterialGuid.Size = new System.Drawing.Size(25, 22);
            this.btnSelectMaterialGuid.TabIndex = 146;
            this.btnSelectMaterialGuid.UseVisualStyleBackColor = true;
            this.btnSelectMaterialGuid.Click += new System.EventHandler(this.btnSelectMaterialGuid_Click);
            // 
            // btnQry
            // 
            this.btnQry.Location = new System.Drawing.Point(602, 28);
            this.btnQry.Name = "btnQry";
            this.btnQry.Size = new System.Drawing.Size(71, 23);
            this.btnQry.TabIndex = 145;
            this.btnQry.Text = "查询";
            this.btnQry.UseVisualStyleBackColor = true;
            this.btnQry.Click += new System.EventHandler(this.btnQry_Click);
            // 
            // txtMaterialGuid
            // 
            this.txtMaterialGuid.BackColor = System.Drawing.Color.White;
            this.txtMaterialGuid.Location = new System.Drawing.Point(266, 29);
            this.txtMaterialGuid.Name = "txtMaterialGuid";
            this.txtMaterialGuid.ReadOnly = true;
            this.txtMaterialGuid.Size = new System.Drawing.Size(116, 21);
            this.txtMaterialGuid.TabIndex = 139;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 140;
            this.label2.Text = "物料编号";
            // 
            // frmStockDetailReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 504);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmStockDetailReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "库存明细报表";
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
        private DevExpress.XtraGrid.Columns.GridColumn gridBillGuid;
        private DevExpress.XtraGrid.Columns.GridColumn gridBillDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridFlagName;
        private DevExpress.XtraGrid.Columns.GridColumn gridInQty;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQry;
        private System.Windows.Forms.TextBox txtMaterialGuid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectMaterialGuid;
        private System.Windows.Forms.Button btnSelectStorage;
        private System.Windows.Forms.TextBox txtStorage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaterialName;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.Columns.GridColumn gridOutQty;
        private DevExpress.XtraGrid.Columns.GridColumn gridDepotQty;
        private DevExpress.XtraGrid.Columns.GridColumn gridFlag;
        private DevExpress.XtraGrid.Columns.GridColumn gridBillID;
    }
}