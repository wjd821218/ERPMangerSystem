namespace ErpManage
{
    partial class frmFileDetailReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFileDetailReport));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridFileGuID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridFileID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridFileType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridPublishDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridVersionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridWriteDept = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtEndDate = new DevExpress.XtraEditors.DateEdit();
            this.dtBeginDate = new DevExpress.XtraEditors.DateEdit();
            this.btnSelectControlType = new System.Windows.Forms.Button();
            this.txtControlType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtFileID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFileClass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnQry = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBeginDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBeginDate.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 125);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1162, 447);
            this.gridControl1.TabIndex = 84;
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
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridFileGuID,
            this.gridFileID,
            this.gridFileName,
            this.gridFileType,
            this.gridProductName,
            this.gridPublishDate,
            this.gridVersionID,
            this.gridControlType,
            this.gridWriteDept});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // gridFileGuID
            // 
            this.gridFileGuID.Caption = "FileGuID";
            this.gridFileGuID.FieldName = "FileGuID";
            this.gridFileGuID.Name = "gridFileGuID";
            // 
            // gridFileID
            // 
            this.gridFileID.Caption = "文件编号";
            this.gridFileID.FieldName = "FileID";
            this.gridFileID.MinWidth = 162;
            this.gridFileID.Name = "gridFileID";
            this.gridFileID.OptionsColumn.AllowEdit = false;
            this.gridFileID.Visible = true;
            this.gridFileID.VisibleIndex = 1;
            this.gridFileID.Width = 162;
            // 
            // gridFileName
            // 
            this.gridFileName.Caption = "文件名称";
            this.gridFileName.FieldName = "FileName";
            this.gridFileName.MinWidth = 171;
            this.gridFileName.Name = "gridFileName";
            this.gridFileName.OptionsColumn.AllowEdit = false;
            this.gridFileName.Visible = true;
            this.gridFileName.VisibleIndex = 0;
            this.gridFileName.Width = 171;
            // 
            // gridFileType
            // 
            this.gridFileType.Caption = "文件类别";
            this.gridFileType.FieldName = "FileTypeName";
            this.gridFileType.MinWidth = 113;
            this.gridFileType.Name = "gridFileType";
            this.gridFileType.OptionsColumn.AllowEdit = false;
            this.gridFileType.Visible = true;
            this.gridFileType.VisibleIndex = 3;
            this.gridFileType.Width = 113;
            // 
            // gridProductName
            // 
            this.gridProductName.Caption = "产品名称";
            this.gridProductName.FieldName = "ProductName";
            this.gridProductName.MinWidth = 139;
            this.gridProductName.Name = "gridProductName";
            this.gridProductName.Visible = true;
            this.gridProductName.VisibleIndex = 6;
            this.gridProductName.Width = 139;
            // 
            // gridPublishDate
            // 
            this.gridPublishDate.Caption = "发布日期";
            this.gridPublishDate.FieldName = "PublishDate";
            this.gridPublishDate.MinWidth = 97;
            this.gridPublishDate.Name = "gridPublishDate";
            this.gridPublishDate.OptionsColumn.AllowEdit = false;
            this.gridPublishDate.Visible = true;
            this.gridPublishDate.VisibleIndex = 5;
            this.gridPublishDate.Width = 97;
            // 
            // gridVersionID
            // 
            this.gridVersionID.Caption = "版本";
            this.gridVersionID.FieldName = "VersionID";
            this.gridVersionID.MinWidth = 62;
            this.gridVersionID.Name = "gridVersionID";
            this.gridVersionID.OptionsColumn.AllowEdit = false;
            this.gridVersionID.Visible = true;
            this.gridVersionID.VisibleIndex = 2;
            this.gridVersionID.Width = 62;
            // 
            // gridControlType
            // 
            this.gridControlType.Caption = "受控类别";
            this.gridControlType.FieldName = "ControlTypeName";
            this.gridControlType.MinWidth = 78;
            this.gridControlType.Name = "gridControlType";
            this.gridControlType.Visible = true;
            this.gridControlType.VisibleIndex = 4;
            this.gridControlType.Width = 78;
            // 
            // gridWriteDept
            // 
            this.gridWriteDept.Caption = "编写部门";
            this.gridWriteDept.FieldName = "WriteDeptName";
            this.gridWriteDept.MinWidth = 161;
            this.gridWriteDept.Name = "gridWriteDept";
            this.gridWriteDept.Visible = true;
            this.gridWriteDept.VisibleIndex = 7;
            this.gridWriteDept.Width = 161;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtEndDate);
            this.groupBox1.Controls.Add(this.dtBeginDate);
            this.groupBox1.Controls.Add(this.btnSelectControlType);
            this.groupBox1.Controls.Add(this.txtControlType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.txtFileID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFileName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFileClass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnQry);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1162, 100);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(958, 25);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.TabIndex = 115;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(81, 55);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(112, 21);
            this.txtProductName.TabIndex = 113;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 114;
            this.label9.Text = "产品名称";
            // 
            // dtEndDate
            // 
            this.dtEndDate.EditValue = null;
            this.dtEndDate.Location = new System.Drawing.Point(488, 55);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtEndDate.Size = new System.Drawing.Size(116, 21);
            this.dtEndDate.TabIndex = 112;
            // 
            // dtBeginDate
            // 
            this.dtBeginDate.EditValue = null;
            this.dtBeginDate.Location = new System.Drawing.Point(301, 55);
            this.dtBeginDate.Name = "dtBeginDate";
            this.dtBeginDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBeginDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtBeginDate.Size = new System.Drawing.Size(116, 21);
            this.dtBeginDate.TabIndex = 111;
            // 
            // btnSelectControlType
            // 
            this.btnSelectControlType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectControlType.BackgroundImage")));
            this.btnSelectControlType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectControlType.Location = new System.Drawing.Point(789, 21);
            this.btnSelectControlType.Name = "btnSelectControlType";
            this.btnSelectControlType.Size = new System.Drawing.Size(25, 22);
            this.btnSelectControlType.TabIndex = 110;
            this.btnSelectControlType.UseVisualStyleBackColor = true;
            this.btnSelectControlType.Click += new System.EventHandler(this.btnSelectSpec_Click);
            // 
            // txtControlType
            // 
            this.txtControlType.BackColor = System.Drawing.Color.White;
            this.txtControlType.Location = new System.Drawing.Point(676, 22);
            this.txtControlType.Name = "txtControlType";
            this.txtControlType.ReadOnly = true;
            this.txtControlType.Size = new System.Drawing.Size(116, 21);
            this.txtControlType.TabIndex = 107;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(618, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 108;
            this.label4.Text = "受控类别";
            // 
            // btnSelect
            // 
            this.btnSelect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelect.BackgroundImage")));
            this.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelect.Location = new System.Drawing.Point(190, 18);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(25, 22);
            this.btnSelect.TabIndex = 106;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtFileID
            // 
            this.txtFileID.Location = new System.Drawing.Point(302, 18);
            this.txtFileID.MaxLength = 50;
            this.txtFileID.Name = "txtFileID";
            this.txtFileID.Size = new System.Drawing.Size(115, 21);
            this.txtFileID.TabIndex = 103;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 105;
            this.label3.Text = "文件编号";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(489, 19);
            this.txtFileName.MaxLength = 100;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(115, 21);
            this.txtFileName.TabIndex = 104;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 102;
            this.label2.Text = "文件名称";
            // 
            // txtFileClass
            // 
            this.txtFileClass.BackColor = System.Drawing.Color.White;
            this.txtFileClass.Location = new System.Drawing.Point(81, 18);
            this.txtFileClass.Name = "txtFileClass";
            this.txtFileClass.ReadOnly = true;
            this.txtFileClass.Size = new System.Drawing.Size(112, 21);
            this.txtFileClass.TabIndex = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 100;
            this.label1.Text = "文件类别";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 88;
            this.label6.Text = "发布日期";
            // 
            // btnQry
            // 
            this.btnQry.Location = new System.Drawing.Point(856, 25);
            this.btnQry.Name = "btnQry";
            this.btnQry.Size = new System.Drawing.Size(75, 30);
            this.btnQry.TabIndex = 92;
            this.btnQry.Text = "查询";
            this.btnQry.UseVisualStyleBackColor = true;
            this.btnQry.Click += new System.EventHandler(this.btnQry_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 89;
            this.label7.Text = "--->";
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
            this.toolStrip1.Size = new System.Drawing.Size(1162, 25);
            this.toolStrip1.TabIndex = 142;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
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
            this.tsbPrint.Visible = false;
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
            this.exit.Click += new System.EventHandler(this.exit_Click_2);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1058, 25);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 125;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmFileDetailReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 572);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmFileDetailReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件资料一览报表";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBeginDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBeginDate.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridFileGuID;
        private DevExpress.XtraGrid.Columns.GridColumn gridFileID;
        private DevExpress.XtraGrid.Columns.GridColumn gridFileName;
        private DevExpress.XtraGrid.Columns.GridColumn gridFileType;
        private DevExpress.XtraGrid.Columns.GridColumn gridProductName;
        private DevExpress.XtraGrid.Columns.GridColumn gridPublishDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridVersionID;
        private DevExpress.XtraGrid.Columns.GridColumn gridControlType;
        private DevExpress.XtraGrid.Columns.GridColumn gridWriteDept;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnQry;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton exit;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtFileID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFileClass;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dtEndDate;
        private DevExpress.XtraEditors.DateEdit dtBeginDate;
        private System.Windows.Forms.Button btnSelectControlType;
        private System.Windows.Forms.TextBox txtControlType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}