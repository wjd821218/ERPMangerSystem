namespace ErpManage
{
    partial class frmSelectMaterial2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectMaterial2));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridMaterialGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCheckBox = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridMaterialId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridClassId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridgg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridunit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridstate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBomQry = new System.Windows.Forms.Button();
            this.btnStorageView = new System.Windows.Forms.Button();
            this.cboSelect = new System.Windows.Forms.ComboBox();
            this.txtQryValue = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnQry = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(160, 73);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(540, 361);
            this.gridControl1.TabIndex = 62;
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
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridMaterialGuid,
            this.gridCheckBox,
            this.gridMaterialId,
            this.gridMaterialName,
            this.gridClassId,
            this.gridgg,
            this.gridunit,
            this.gridstate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // gridMaterialGuid
            // 
            this.gridMaterialGuid.Caption = "MaterialGuid";
            this.gridMaterialGuid.FieldName = "MaterialGuid";
            this.gridMaterialGuid.Name = "gridMaterialGuid";
            // 
            // gridCheckBox
            // 
            this.gridCheckBox.Caption = "选择";
            this.gridCheckBox.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridCheckBox.FieldName = "selectvalue";
            this.gridCheckBox.Name = "gridCheckBox";
            this.gridCheckBox.Visible = true;
            this.gridCheckBox.VisibleIndex = 0;
            this.gridCheckBox.Width = 45;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.QueryCheckStateByValue += new DevExpress.XtraEditors.Controls.QueryCheckStateByValueEventHandler(this.repositoryItemCheckEdit1_QueryCheckStateByValue);
            // 
            // gridMaterialId
            // 
            this.gridMaterialId.Caption = "物料编号";
            this.gridMaterialId.FieldName = "物料编号";
            this.gridMaterialId.Name = "gridMaterialId";
            this.gridMaterialId.OptionsColumn.AllowEdit = false;
            this.gridMaterialId.Visible = true;
            this.gridMaterialId.VisibleIndex = 1;
            this.gridMaterialId.Width = 99;
            // 
            // gridMaterialName
            // 
            this.gridMaterialName.Caption = "物料名称";
            this.gridMaterialName.FieldName = "物料名称";
            this.gridMaterialName.Name = "gridMaterialName";
            this.gridMaterialName.OptionsColumn.AllowEdit = false;
            this.gridMaterialName.Visible = true;
            this.gridMaterialName.VisibleIndex = 2;
            this.gridMaterialName.Width = 105;
            // 
            // gridClassId
            // 
            this.gridClassId.Caption = "分类";
            this.gridClassId.FieldName = "分类";
            this.gridClassId.Name = "gridClassId";
            this.gridClassId.OptionsColumn.AllowEdit = false;
            this.gridClassId.Visible = true;
            this.gridClassId.VisibleIndex = 3;
            this.gridClassId.Width = 68;
            // 
            // gridgg
            // 
            this.gridgg.Caption = "规格";
            this.gridgg.FieldName = "规格";
            this.gridgg.Name = "gridgg";
            this.gridgg.OptionsColumn.AllowEdit = false;
            this.gridgg.Visible = true;
            this.gridgg.VisibleIndex = 4;
            this.gridgg.Width = 53;
            // 
            // gridunit
            // 
            this.gridunit.Caption = "单价";
            this.gridunit.FieldName = "单价";
            this.gridunit.Name = "gridunit";
            this.gridunit.OptionsColumn.AllowEdit = false;
            this.gridunit.Visible = true;
            this.gridunit.VisibleIndex = 5;
            this.gridunit.Width = 53;
            // 
            // gridstate
            // 
            this.gridstate.Caption = "状态";
            this.gridstate.FieldName = "状态";
            this.gridstate.Name = "gridstate";
            this.gridstate.OptionsColumn.AllowEdit = false;
            this.gridstate.Visible = true;
            this.gridstate.VisibleIndex = 6;
            this.gridstate.Width = 80;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 73);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(160, 361);
            this.treeView1.TabIndex = 63;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(700, 25);
            this.toolStrip1.TabIndex = 64;
            this.toolStrip1.Text = "toolStrip1";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBomQry);
            this.groupBox1.Controls.Add(this.btnStorageView);
            this.groupBox1.Controls.Add(this.cboSelect);
            this.groupBox1.Controls.Add(this.txtQryValue);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnQry);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 48);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            // 
            // btnBomQry
            // 
            this.btnBomQry.Location = new System.Drawing.Point(404, 15);
            this.btnBomQry.Name = "btnBomQry";
            this.btnBomQry.Size = new System.Drawing.Size(81, 23);
            this.btnBomQry.TabIndex = 156;
            this.btnBomQry.Text = "BOM查询";
            this.btnBomQry.UseVisualStyleBackColor = true;
            this.btnBomQry.Click += new System.EventHandler(this.btnBomQry_Click);
            // 
            // btnStorageView
            // 
            this.btnStorageView.Location = new System.Drawing.Point(613, 14);
            this.btnStorageView.Name = "btnStorageView";
            this.btnStorageView.Size = new System.Drawing.Size(75, 25);
            this.btnStorageView.TabIndex = 155;
            this.btnStorageView.Text = "库存相关";
            this.btnStorageView.UseVisualStyleBackColor = true;
            this.btnStorageView.Click += new System.EventHandler(this.btnStorageView_Click);
            // 
            // cboSelect
            // 
            this.cboSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelect.FormattingEnabled = true;
            this.cboSelect.Items.AddRange(new object[] {
            "物料编号",
            "物料名称",
            "客户编号",
            "图号"});
            this.cboSelect.Location = new System.Drawing.Point(60, 16);
            this.cboSelect.Name = "cboSelect";
            this.cboSelect.Size = new System.Drawing.Size(100, 20);
            this.cboSelect.TabIndex = 78;
            // 
            // txtQryValue
            // 
            this.txtQryValue.Location = new System.Drawing.Point(167, 16);
            this.txtQryValue.Name = "txtQryValue";
            this.txtQryValue.Size = new System.Drawing.Size(127, 21);
            this.txtQryValue.TabIndex = 77;
            this.txtQryValue.TextChanged += new System.EventHandler(this.txtQryValue_TextChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(499, 15);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(81, 23);
            this.btnSelect.TabIndex = 74;
            this.btnSelect.Text = "选定";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 76;
            this.label3.Text = "查找";
            // 
            // btnQry
            // 
            this.btnQry.Location = new System.Drawing.Point(311, 15);
            this.btnQry.Name = "btnQry";
            this.btnQry.Size = new System.Drawing.Size(81, 23);
            this.btnQry.TabIndex = 75;
            this.btnQry.Text = "查询";
            this.btnQry.UseVisualStyleBackColor = true;
            this.btnQry.Click += new System.EventHandler(this.btnQry_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "star.png");
            // 
            // frmSelectMaterial2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 434);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmSelectMaterial2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择物料";
            this.Load += new System.EventHandler(this.frmSelectMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialGuid;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialId;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialName;
        private DevExpress.XtraGrid.Columns.GridColumn gridClassId;
        private DevExpress.XtraGrid.Columns.GridColumn gridgg;
        private DevExpress.XtraGrid.Columns.GridColumn gridunit;
        private DevExpress.XtraGrid.Columns.GridColumn gridstate;
        private DevExpress.XtraGrid.Columns.GridColumn gridCheckBox;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        public  System.Windows.Forms.TextBox txtQryValue;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQry;
        private System.Windows.Forms.ComboBox cboSelect;
        private System.Windows.Forms.Button btnStorageView;
        private System.Windows.Forms.Button btnBomQry;
    }
}