namespace ErpManage
{
    partial class frmRight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRight));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.chklstUser = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chklstGroup = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkAllGroup = new System.Windows.Forms.CheckBox();
            this.chkAllUser = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton1,
            this.tsbtnSave,
            this.exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(477, 25);
            this.toolStrip1.TabIndex = 48;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(61, 22);
            this.toolStripButton2.Text = "组管理";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(85, 22);
            this.toolStripButton1.Text = "组权限管理";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            // exit
            // 
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(49, 22);
            this.exit.Text = "退出";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "仓库");
            this.imageList1.Images.SetKeyName(1, "text.png");
            this.imageList1.Images.SetKeyName(2, "group.png");
            this.imageList1.Images.SetKeyName(3, "group_edit.png");
            this.imageList1.Images.SetKeyName(4, "220.ico");
            this.imageList1.Images.SetKeyName(5, "174.ico");
            this.imageList1.Images.SetKeyName(6, "application_go.png");
            this.imageList1.Images.SetKeyName(7, "application_view_list.png");
            this.imageList1.Images.SetKeyName(8, "application_view_tile.png");
            this.imageList1.Images.SetKeyName(9, "book_go.png");
            this.imageList1.Images.SetKeyName(10, "building_edit.png");
            this.imageList1.Images.SetKeyName(11, "calendar.png");
            this.imageList1.Images.SetKeyName(12, "door_out.png");
            this.imageList1.Images.SetKeyName(13, "table_save.png");
            this.imageList1.Images.SetKeyName(14, "script_go.png");
            this.imageList1.Images.SetKeyName(15, "table_row_delete.png");
            this.imageList1.Images.SetKeyName(16, "zoom.png");
            this.imageList1.Images.SetKeyName(17, "calculator_add.png");
            this.imageList1.Images.SetKeyName(18, "calculator.png");
            this.imageList1.Images.SetKeyName(19, "50.png");
            this.imageList1.Images.SetKeyName(20, "Mac OS X Modern Icon 18.ico");
            this.imageList1.Images.SetKeyName(21, "Mac OS X Modern Icon 20.ico");
            this.imageList1.Images.SetKeyName(22, "open-folder.png");
            this.imageList1.Images.SetKeyName(23, "import.png");
            this.imageList1.Images.SetKeyName(24, "database_table.png");
            this.imageList1.Images.SetKeyName(25, "css_add.png");
            this.imageList1.Images.SetKeyName(26, "css_delete.png");
            // 
            // chklstUser
            // 
            this.chklstUser.FormattingEnabled = true;
            this.chklstUser.Location = new System.Drawing.Point(9, 72);
            this.chklstUser.Name = "chklstUser";
            this.chklstUser.Size = new System.Drawing.Size(192, 388);
            this.chklstUser.TabIndex = 49;
            this.chklstUser.SelectedIndexChanged += new System.EventHandler(this.chklstUser_SelectedIndexChanged);
            this.chklstUser.Click += new System.EventHandler(this.chklstUser_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 50;
            this.label1.Text = "操作员列表";
            // 
            // chklstGroup
            // 
            this.chklstGroup.FormattingEnabled = true;
            this.chklstGroup.Location = new System.Drawing.Point(202, 72);
            this.chklstGroup.Name = "chklstGroup";
            this.chklstGroup.Size = new System.Drawing.Size(263, 388);
            this.chklstGroup.TabIndex = 51;
            this.chklstGroup.Click += new System.EventHandler(this.chklstGroup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 52;
            this.label2.Text = "权限组列表";
            // 
            // chkAllGroup
            // 
            this.chkAllGroup.AutoSize = true;
            this.chkAllGroup.Location = new System.Drawing.Point(417, 53);
            this.chkAllGroup.Name = "chkAllGroup";
            this.chkAllGroup.Size = new System.Drawing.Size(48, 16);
            this.chkAllGroup.TabIndex = 53;
            this.chkAllGroup.Text = "全选";
            this.chkAllGroup.UseVisualStyleBackColor = true;
            this.chkAllGroup.Click += new System.EventHandler(this.chkAllGroup_Click);
            // 
            // chkAllUser
            // 
            this.chkAllUser.AutoSize = true;
            this.chkAllUser.Location = new System.Drawing.Point(143, 53);
            this.chkAllUser.Name = "chkAllUser";
            this.chkAllUser.Size = new System.Drawing.Size(48, 16);
            this.chkAllUser.TabIndex = 54;
            this.chkAllUser.Text = "全选";
            this.chkAllUser.UseVisualStyleBackColor = true;
            this.chkAllUser.Click += new System.EventHandler(this.chkAllUser_Click);
            // 
            // frmRight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 468);
            this.Controls.Add(this.chkAllUser);
            this.Controls.Add(this.chkAllGroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chklstGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chklstUser);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmRight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "操作员授权";
            this.Load += new System.EventHandler(this.frmRight_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton exit;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.CheckedListBox chklstUser;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chklstGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.CheckBox chkAllGroup;
        private System.Windows.Forms.CheckBox chkAllUser;
    }
}