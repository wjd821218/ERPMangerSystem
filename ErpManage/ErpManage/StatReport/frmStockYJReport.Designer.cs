namespace ErpManage.StatReport
{
    partial class frmStockYJReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockYJReport));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridMaterialID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridStockYJDown = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridStockYJUp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridStorageSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemSpinEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelectIncomeDepot = new System.Windows.Forms.Button();
            this.txtIncomeDepot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBomQry = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtMaterialName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelectMaterialType = new System.Windows.Forms.Button();
            this.txtMaterialType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.btnAdd,
            this.tsbExport,
            this.toolStripSeparator2,
            this.exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(849, 25);
            this.toolStrip1.TabIndex = 140;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 22);
            this.btnAdd.Text = "编辑物料上下限";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.gridControl1.Location = new System.Drawing.Point(0, 113);
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
            this.gridControl1.Size = new System.Drawing.Size(849, 633);
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
            this.gridMaterialID,
            this.gridMaterialName,
            this.gridSpec,
            this.gridUnit,
            this.gridStockYJDown,
            this.gridStockYJUp,
            this.gridStorageSum});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            // 
            // gridMaterialID
            // 
            this.gridMaterialID.Caption = "物料编号";
            this.gridMaterialID.FieldName = "MaterialID";
            this.gridMaterialID.Name = "gridMaterialID";
            this.gridMaterialID.OptionsColumn.AllowEdit = false;
            this.gridMaterialID.Visible = true;
            this.gridMaterialID.VisibleIndex = 0;
            this.gridMaterialID.Width = 115;
            // 
            // gridMaterialName
            // 
            this.gridMaterialName.Caption = "物料名称";
            this.gridMaterialName.FieldName = "MaterialName";
            this.gridMaterialName.Name = "gridMaterialName";
            this.gridMaterialName.OptionsColumn.AllowEdit = false;
            this.gridMaterialName.Visible = true;
            this.gridMaterialName.VisibleIndex = 1;
            this.gridMaterialName.Width = 118;
            // 
            // gridSpec
            // 
            this.gridSpec.Caption = "规格型号";
            this.gridSpec.FieldName = "SpecName";
            this.gridSpec.Name = "gridSpec";
            this.gridSpec.OptionsColumn.AllowEdit = false;
            this.gridSpec.Visible = true;
            this.gridSpec.VisibleIndex = 2;
            this.gridSpec.Width = 77;
            // 
            // gridUnit
            // 
            this.gridUnit.Caption = "单位";
            this.gridUnit.FieldName = "UnitName";
            this.gridUnit.Name = "gridUnit";
            this.gridUnit.OptionsColumn.AllowEdit = false;
            this.gridUnit.Visible = true;
            this.gridUnit.VisibleIndex = 3;
            this.gridUnit.Width = 78;
            // 
            // gridStockYJDown
            // 
            this.gridStockYJDown.Caption = "下限";
            this.gridStockYJDown.DisplayFormat.FormatString = "0.###";
            this.gridStockYJDown.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridStockYJDown.FieldName = "StockYJDown";
            this.gridStockYJDown.Name = "gridStockYJDown";
            this.gridStockYJDown.OptionsColumn.AllowEdit = false;
            this.gridStockYJDown.Visible = true;
            this.gridStockYJDown.VisibleIndex = 4;
            // 
            // gridStockYJUp
            // 
            this.gridStockYJUp.Caption = "上限";
            this.gridStockYJUp.DisplayFormat.FormatString = "0.###";
            this.gridStockYJUp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridStockYJUp.FieldName = "StockYJUp";
            this.gridStockYJUp.Name = "gridStockYJUp";
            this.gridStockYJUp.Visible = true;
            this.gridStockYJUp.VisibleIndex = 5;
            // 
            // gridStorageSum
            // 
            this.gridStorageSum.Caption = "库存数量";
            this.gridStorageSum.DisplayFormat.FormatString = "0.###";
            this.gridStorageSum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridStorageSum.FieldName = "StorageSum";
            this.gridStorageSum.Name = "gridStorageSum";
            this.gridStorageSum.OptionsColumn.AllowEdit = false;
            this.gridStorageSum.Visible = true;
            this.gridStorageSum.VisibleIndex = 6;
            this.gridStorageSum.Width = 102;
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
            this.panel1.Controls.Add(this.btnSelectIncomeDepot);
            this.panel1.Controls.Add(this.txtIncomeDepot);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnBomQry);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.txtMaterialName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnSelectMaterialType);
            this.panel1.Controls.Add(this.txtMaterialType);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSelectMaterialGuid);
            this.panel1.Controls.Add(this.btnQry);
            this.panel1.Controls.Add(this.txtMaterialGuid);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 88);
            this.panel1.TabIndex = 142;
            // 
            // btnSelectIncomeDepot
            // 
            this.btnSelectIncomeDepot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectIncomeDepot.BackgroundImage")));
            this.btnSelectIncomeDepot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectIncomeDepot.Location = new System.Drawing.Point(178, 48);
            this.btnSelectIncomeDepot.Name = "btnSelectIncomeDepot";
            this.btnSelectIncomeDepot.Size = new System.Drawing.Size(25, 22);
            this.btnSelectIncomeDepot.TabIndex = 162;
            this.btnSelectIncomeDepot.UseVisualStyleBackColor = true;
            this.btnSelectIncomeDepot.Click += new System.EventHandler(this.btnSelectIncomeDepot_Click);
            // 
            // txtIncomeDepot
            // 
            this.txtIncomeDepot.BackColor = System.Drawing.Color.White;
            this.txtIncomeDepot.Location = new System.Drawing.Point(66, 49);
            this.txtIncomeDepot.Name = "txtIncomeDepot";
            this.txtIncomeDepot.ReadOnly = true;
            this.txtIncomeDepot.Size = new System.Drawing.Size(116, 21);
            this.txtIncomeDepot.TabIndex = 161;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 160;
            this.label7.Text = "仓库";
            // 
            // btnBomQry
            // 
            this.btnBomQry.Location = new System.Drawing.Point(513, 21);
            this.btnBomQry.Name = "btnBomQry";
            this.btnBomQry.Size = new System.Drawing.Size(66, 23);
            this.btnBomQry.TabIndex = 159;
            this.btnBomQry.Text = "BOM查询";
            this.btnBomQry.UseVisualStyleBackColor = true;
            this.btnBomQry.Click += new System.EventHandler(this.btnBomQry_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(598, 21);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(68, 23);
            this.btnClear.TabIndex = 158;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtMaterialName
            // 
            this.txtMaterialName.BackColor = System.Drawing.Color.White;
            this.txtMaterialName.Location = new System.Drawing.Point(265, 23);
            this.txtMaterialName.Name = "txtMaterialName";
            this.txtMaterialName.ReadOnly = true;
            this.txtMaterialName.Size = new System.Drawing.Size(110, 21);
            this.txtMaterialName.TabIndex = 156;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 157;
            this.label4.Text = "物料名称";
            // 
            // btnSelectMaterialType
            // 
            this.btnSelectMaterialType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectMaterialType.BackgroundImage")));
            this.btnSelectMaterialType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectMaterialType.Location = new System.Drawing.Point(812, 66);
            this.btnSelectMaterialType.Name = "btnSelectMaterialType";
            this.btnSelectMaterialType.Size = new System.Drawing.Size(25, 22);
            this.btnSelectMaterialType.TabIndex = 149;
            this.btnSelectMaterialType.UseVisualStyleBackColor = true;
            this.btnSelectMaterialType.Visible = false;
            this.btnSelectMaterialType.Click += new System.EventHandler(this.btnSelectMaterialType_Click);
            // 
            // txtMaterialType
            // 
            this.txtMaterialType.BackColor = System.Drawing.Color.White;
            this.txtMaterialType.Location = new System.Drawing.Point(700, 66);
            this.txtMaterialType.Name = "txtMaterialType";
            this.txtMaterialType.ReadOnly = true;
            this.txtMaterialType.Size = new System.Drawing.Size(116, 21);
            this.txtMaterialType.TabIndex = 147;
            this.txtMaterialType.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 148;
            this.label3.Text = "货品分类";
            this.label3.Visible = false;
            // 
            // btnSelectMaterialGuid
            // 
            this.btnSelectMaterialGuid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectMaterialGuid.BackgroundImage")));
            this.btnSelectMaterialGuid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectMaterialGuid.Location = new System.Drawing.Point(178, 20);
            this.btnSelectMaterialGuid.Name = "btnSelectMaterialGuid";
            this.btnSelectMaterialGuid.Size = new System.Drawing.Size(25, 22);
            this.btnSelectMaterialGuid.TabIndex = 146;
            this.btnSelectMaterialGuid.UseVisualStyleBackColor = true;
            this.btnSelectMaterialGuid.Click += new System.EventHandler(this.btnSelectMaterialGuid_Click);
            // 
            // btnQry
            // 
            this.btnQry.Location = new System.Drawing.Point(421, 22);
            this.btnQry.Name = "btnQry";
            this.btnQry.Size = new System.Drawing.Size(63, 23);
            this.btnQry.TabIndex = 145;
            this.btnQry.Text = "查询";
            this.btnQry.UseVisualStyleBackColor = true;
            this.btnQry.Click += new System.EventHandler(this.btnQry_Click);
            // 
            // txtMaterialGuid
            // 
            this.txtMaterialGuid.BackColor = System.Drawing.Color.White;
            this.txtMaterialGuid.Location = new System.Drawing.Point(66, 21);
            this.txtMaterialGuid.Name = "txtMaterialGuid";
            this.txtMaterialGuid.ReadOnly = true;
            this.txtMaterialGuid.Size = new System.Drawing.Size(116, 21);
            this.txtMaterialGuid.TabIndex = 139;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 140;
            this.label2.Text = "物料编号";
            // 
            // frmStockYJReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 746);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmStockYJReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "库存预警报表";
            this.Load += new System.EventHandler(this.frmStockReport_Load);
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton exit;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialID;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialName;
        private DevExpress.XtraGrid.Columns.GridColumn gridSpec;
        private DevExpress.XtraGrid.Columns.GridColumn gridUnit;
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
        private System.Windows.Forms.Button btnSelectMaterialType;
        private System.Windows.Forms.TextBox txtMaterialType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaterialName;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.Columns.GridColumn gridStorageSum;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.Button btnBomQry;
        private DevExpress.XtraGrid.Columns.GridColumn gridStockYJDown;
        private DevExpress.XtraGrid.Columns.GridColumn gridStockYJUp;
        private System.Windows.Forms.Button btnSelectIncomeDepot;
        private System.Windows.Forms.TextBox txtIncomeDepot;
        private System.Windows.Forms.Label label7;
    }
}