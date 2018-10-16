namespace ErpManage
{
    partial class frmBasicDataAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBasicDataAdd));
            this.gridSelect = new DevExpress.XtraGrid.GridControl();
            this.gridVProGroup = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridUnitName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDel = new System.Windows.Forms.ToolStripButton();
            this.tsBtnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.listSelect = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVProGroup)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridSelect
            // 
            this.gridSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSelect.Location = new System.Drawing.Point(0, 21);
            this.gridSelect.MainView = this.gridVProGroup;
            this.gridSelect.Name = "gridSelect";
            this.gridSelect.Size = new System.Drawing.Size(318, 364);
            this.gridSelect.TabIndex = 88;
            this.gridSelect.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVProGroup});
            // 
            // gridVProGroup
            // 
            this.gridVProGroup.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.gridVProGroup.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridUnitName});
            this.gridVProGroup.GridControl = this.gridSelect;
            this.gridVProGroup.Name = "gridVProGroup";
            this.gridVProGroup.OptionsBehavior.Editable = false;
            this.gridVProGroup.OptionsCustomization.AllowFilter = false;
            this.gridVProGroup.OptionsCustomization.AllowGroup = false;
            this.gridVProGroup.OptionsCustomization.AllowSort = false;
            this.gridVProGroup.OptionsView.ShowGroupPanel = false;
            this.gridVProGroup.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            // 
            // gridUnitName
            // 
            this.gridUnitName.Caption = "选项内容";
            this.gridUnitName.FieldName = "UnitName";
            this.gridUnitName.Name = "gridUnitName";
            this.gridUnitName.Visible = true;
            this.gridUnitName.VisibleIndex = 0;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(84, 12);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(125, 21);
            this.txtValue.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 84;
            this.label3.Text = "输入选项值";
            // 
            // tsbtnSave
            // 
            this.tsbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSave.Image")));
            this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSave.Name = "tsbtnSave";
            this.tsbtnSave.Size = new System.Drawing.Size(49, 22);
            this.tsbtnSave.Text = "保存";
            this.tsbtnSave.Click += new System.EventHandler(this.tsbtnSave_Click);
            // 
            // tsBtnDel
            // 
            this.tsBtnDel.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnDel.Image")));
            this.tsBtnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDel.Name = "tsBtnDel";
            this.tsBtnDel.Size = new System.Drawing.Size(49, 22);
            this.tsBtnDel.Text = "删除";
            this.tsBtnDel.Click += new System.EventHandler(this.tsBtnDel_Click);
            // 
            // tsBtnExit
            // 
            this.tsBtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnExit.Image")));
            this.tsBtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnExit.Name = "tsBtnExit";
            this.tsBtnExit.Size = new System.Drawing.Size(49, 22);
            this.tsBtnExit.Text = "退出";
            this.tsBtnExit.Click += new System.EventHandler(this.tsBtnExit_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSave,
            this.tsBtnDel,
            this.tsBtnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(518, 25);
            this.toolStrip1.TabIndex = 79;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // listSelect
            // 
            this.listSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSelect.FormattingEnabled = true;
            this.listSelect.ItemHeight = 12;
            this.listSelect.Items.AddRange(new object[] {
            "单位",
            "币种",
            "结算方式",
            "车间",
            "仓库",
            "规格",
            "计价方法",
            "财务科目",
            "模具类别",
            "产品类别"});
            this.listSelect.Location = new System.Drawing.Point(0, 21);
            this.listSelect.Name = "listSelect";
            this.listSelect.Size = new System.Drawing.Size(200, 364);
            this.listSelect.TabIndex = 90;
            this.listSelect.SelectedIndexChanged += new System.EventHandler(this.listSelect_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 91;
            this.label2.Text = "选项类型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 92;
            this.label4.Text = "选项值";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtValue);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 41);
            this.panel1.TabIndex = 93;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listSelect);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 385);
            this.panel2.TabIndex = 94;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 21);
            this.panel4.TabIndex = 92;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridSelect);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 385);
            this.panel3.TabIndex = 95;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(318, 21);
            this.panel5.TabIndex = 96;
            // 
            // frmBasicDataAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 451);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmBasicDataAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "辅助数据维护";
            ((System.ComponentModel.ISupportInitialize)(this.gridSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVProGroup)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridSelect;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVProGroup;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.ToolStripButton tsBtnDel;
        private System.Windows.Forms.ToolStripButton tsBtnExit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraGrid.Columns.GridColumn gridUnitName;
        private System.Windows.Forms.ListBox listSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;

    }
}