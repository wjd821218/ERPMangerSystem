namespace ErpManage
{
    partial class frmRightGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRightGroup));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsBtnExit = new System.Windows.Forms.ToolStripButton();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridGroup = new DevExpress.XtraGrid.GridControl();
            this.gridVProGroup = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridGroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVProGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSave,
            this.tsBtnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(249, 25);
            this.toolStrip1.TabIndex = 68;
            this.toolStrip1.Text = "toolStrip1";
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
            // tsBtnExit
            // 
            this.tsBtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnExit.Image")));
            this.tsBtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnExit.Name = "tsBtnExit";
            this.tsBtnExit.Size = new System.Drawing.Size(49, 22);
            this.tsBtnExit.Text = "退出";
            this.tsBtnExit.Click += new System.EventHandler(this.tsBtnExit_Click);
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(41, 47);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(154, 21);
            this.txtGroupName.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 70;
            this.label1.Text = "组名";
            // 
            // gridGroup
            // 
            this.gridGroup.Location = new System.Drawing.Point(8, 88);
            this.gridGroup.MainView = this.gridVProGroup;
            this.gridGroup.Name = "gridGroup";
            this.gridGroup.Size = new System.Drawing.Size(237, 251);
            this.gridGroup.TabIndex = 79;
            this.gridGroup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVProGroup});
            // 
            // gridVProGroup
            // 
            this.gridVProGroup.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridGroupName});
            this.gridVProGroup.GridControl = this.gridGroup;
            this.gridVProGroup.Name = "gridVProGroup";
            this.gridVProGroup.OptionsCustomization.AllowFilter = false;
            this.gridVProGroup.OptionsCustomization.AllowGroup = false;
            this.gridVProGroup.OptionsCustomization.AllowSort = false;
            this.gridVProGroup.OptionsView.ShowGroupPanel = false;
            // 
            // gridGroupName
            // 
            this.gridGroupName.Caption = "组名";
            this.gridGroupName.FieldName = "GroupName";
            this.gridGroupName.Name = "gridGroupName";
            this.gridGroupName.Visible = true;
            this.gridGroupName.VisibleIndex = 0;
            // 
            // frmRightGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 341);
            this.Controls.Add(this.gridGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmRightGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "权限组新增";
            this.Load += new System.EventHandler(this.frmRightGroup_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVProGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.ToolStripButton tsBtnExit;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridGroup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVProGroup;
        private DevExpress.XtraGrid.Columns.GridColumn gridGroupName;
    }
}