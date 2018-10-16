namespace ErpManage.FileManage
{
    partial class frmFileRightGroupSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFileRightGroupSet));
            this.label2 = new System.Windows.Forms.Label();
            this.chklstGroup = new System.Windows.Forms.CheckedListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsBtnExit = new System.Windows.Forms.ToolStripButton();
            this.chkAllGroup = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQryValue = new System.Windows.Forms.TextBox();
            this.cboQry = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, -91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 75;
            this.label2.Text = "权限组列表";
            // 
            // chklstGroup
            // 
            this.chklstGroup.FormattingEnabled = true;
            this.chklstGroup.Location = new System.Drawing.Point(0, 66);
            this.chklstGroup.Name = "chklstGroup";
            this.chklstGroup.Size = new System.Drawing.Size(158, 404);
            this.chklstGroup.TabIndex = 74;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSave,
            this.tsBtnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(745, 25);
            this.toolStrip1.TabIndex = 73;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnSave
            // 
            this.tsbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSave.Image")));
            this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSave.Name = "tsbtnSave";
            this.tsbtnSave.Size = new System.Drawing.Size(49, 22);
            this.tsbtnSave.Text = "保存";
            // 
            // tsBtnExit
            // 
            this.tsBtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnExit.Image")));
            this.tsBtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnExit.Name = "tsBtnExit";
            this.tsBtnExit.Size = new System.Drawing.Size(49, 22);
            this.tsBtnExit.Text = "退出";
            // 
            // chkAllGroup
            // 
            this.chkAllGroup.AutoSize = true;
            this.chkAllGroup.Location = new System.Drawing.Point(110, 44);
            this.chkAllGroup.Name = "chkAllGroup";
            this.chkAllGroup.Size = new System.Drawing.Size(48, 16);
            this.chkAllGroup.TabIndex = 77;
            this.chkAllGroup.Text = "全选";
            this.chkAllGroup.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 76;
            this.label1.Text = "权限组列表";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(164, 66);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(569, 392);
            this.gridControl1.TabIndex = 78;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 79;
            this.button1.Text = "选择文件";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 83;
            this.label3.Text = "值为";
            // 
            // txtQryValue
            // 
            this.txtQryValue.Location = new System.Drawing.Point(330, 38);
            this.txtQryValue.Name = "txtQryValue";
            this.txtQryValue.Size = new System.Drawing.Size(102, 21);
            this.txtQryValue.TabIndex = 82;
            // 
            // cboQry
            // 
            this.cboQry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQry.FormattingEnabled = true;
            this.cboQry.Items.AddRange(new object[] {
            "文件编号",
            "文件名称",
            "产品名称",
            "版本号"});
            this.cboQry.Location = new System.Drawing.Point(201, 39);
            this.cboQry.Name = "cboQry";
            this.cboQry.Size = new System.Drawing.Size(88, 20);
            this.cboQry.TabIndex = 81;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 80;
            this.label4.Text = "查询";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(579, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 84;
            this.button2.Text = "删除文件";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmFileRightGroupSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 470);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQryValue);
            this.Controls.Add(this.cboQry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.chkAllGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chklstGroup);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmFileRightGroupSet";
            this.Text = "文件权限设置";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox chklstGroup;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.ToolStripButton tsBtnExit;
        private System.Windows.Forms.CheckBox chkAllGroup;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQryValue;
        private System.Windows.Forms.ComboBox cboQry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}