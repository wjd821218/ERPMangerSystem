namespace ErpManage
{
    partial class frmFileFFCountReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFileFFCountReport));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelectDownDept = new System.Windows.Forms.Button();
            this.txtDownDept = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSelectFileApplyPerson = new System.Windows.Forms.Button();
            this.txtFileApplyPerson = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtControlType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtFileID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFileClass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQry = new System.Windows.Forms.Button();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridFileID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridFileTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridVersionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridFileApplyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridPersonName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridDeptName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridFileApplyDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelectDownDept);
            this.groupBox1.Controls.Add(this.txtDownDept);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnSelectFileApplyPerson);
            this.groupBox1.Controls.Add(this.txtFileApplyPerson);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtControlType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.txtFileID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFileName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFileClass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnQry);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1204, 99);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // btnSelectDownDept
            // 
            this.btnSelectDownDept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectDownDept.BackgroundImage")));
            this.btnSelectDownDept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectDownDept.Location = new System.Drawing.Point(817, 22);
            this.btnSelectDownDept.Name = "btnSelectDownDept";
            this.btnSelectDownDept.Size = new System.Drawing.Size(25, 22);
            this.btnSelectDownDept.TabIndex = 244;
            this.btnSelectDownDept.UseVisualStyleBackColor = true;
            this.btnSelectDownDept.Click += new System.EventHandler(this.btnSelectDownDept_Click);
            // 
            // txtDownDept
            // 
            this.txtDownDept.BackColor = System.Drawing.Color.White;
            this.txtDownDept.Location = new System.Drawing.Point(716, 23);
            this.txtDownDept.Name = "txtDownDept";
            this.txtDownDept.ReadOnly = true;
            this.txtDownDept.Size = new System.Drawing.Size(102, 21);
            this.txtDownDept.TabIndex = 243;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(645, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 242;
            this.label12.Text = "申请部门：";
            // 
            // btnSelectFileApplyPerson
            // 
            this.btnSelectFileApplyPerson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectFileApplyPerson.BackgroundImage")));
            this.btnSelectFileApplyPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectFileApplyPerson.Location = new System.Drawing.Point(632, 59);
            this.btnSelectFileApplyPerson.Name = "btnSelectFileApplyPerson";
            this.btnSelectFileApplyPerson.Size = new System.Drawing.Size(25, 22);
            this.btnSelectFileApplyPerson.TabIndex = 241;
            this.btnSelectFileApplyPerson.UseVisualStyleBackColor = true;
            this.btnSelectFileApplyPerson.Click += new System.EventHandler(this.btnSelectFileApplyPerson_Click);
            // 
            // txtFileApplyPerson
            // 
            this.txtFileApplyPerson.BackColor = System.Drawing.Color.White;
            this.txtFileApplyPerson.Location = new System.Drawing.Point(520, 60);
            this.txtFileApplyPerson.Name = "txtFileApplyPerson";
            this.txtFileApplyPerson.ReadOnly = true;
            this.txtFileApplyPerson.Size = new System.Drawing.Size(115, 21);
            this.txtFileApplyPerson.TabIndex = 240;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 239;
            this.label6.Text = "申请人：";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1048, 45);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 124;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(955, 45);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.TabIndex = 123;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(112, 60);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(112, 21);
            this.txtProductName.TabIndex = 121;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 122;
            this.label9.Text = "产品名称";
            // 
            // txtControlType
            // 
            this.txtControlType.BackColor = System.Drawing.Color.White;
            this.txtControlType.Location = new System.Drawing.Point(332, 60);
            this.txtControlType.Name = "txtControlType";
            this.txtControlType.ReadOnly = true;
            this.txtControlType.Size = new System.Drawing.Size(116, 21);
            this.txtControlType.TabIndex = 119;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 120;
            this.label4.Text = "受控类别";
            // 
            // btnSelect
            // 
            this.btnSelect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelect.BackgroundImage")));
            this.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelect.Location = new System.Drawing.Point(221, 20);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(25, 22);
            this.btnSelect.TabIndex = 118;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtFileID
            // 
            this.txtFileID.Location = new System.Drawing.Point(333, 20);
            this.txtFileID.MaxLength = 50;
            this.txtFileID.Name = "txtFileID";
            this.txtFileID.Size = new System.Drawing.Size(115, 21);
            this.txtFileID.TabIndex = 115;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 117;
            this.label3.Text = "文件编号";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(520, 21);
            this.txtFileName.MaxLength = 100;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(115, 21);
            this.txtFileName.TabIndex = 116;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 114;
            this.label2.Text = "文件名称";
            // 
            // txtFileClass
            // 
            this.txtFileClass.BackColor = System.Drawing.Color.White;
            this.txtFileClass.Location = new System.Drawing.Point(112, 20);
            this.txtFileClass.Name = "txtFileClass";
            this.txtFileClass.ReadOnly = true;
            this.txtFileClass.Size = new System.Drawing.Size(112, 21);
            this.txtFileClass.TabIndex = 113;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 112;
            this.label1.Text = "文件类别";
            // 
            // btnQry
            // 
            this.btnQry.Location = new System.Drawing.Point(856, 45);
            this.btnQry.Name = "btnQry";
            this.btnQry.Size = new System.Drawing.Size(75, 30);
            this.btnQry.TabIndex = 92;
            this.btnQry.Text = "查询";
            this.btnQry.UseVisualStyleBackColor = true;
            this.btnQry.Click += new System.EventHandler(this.btnQry_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 124);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.gridControl2.Size = new System.Drawing.Size(1204, 387);
            this.gridControl2.TabIndex = 88;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.FocusedRow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView2.Appearance.GroupFooter.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Appearance.SelectedRow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridFileID,
            this.gridFileName,
            this.gridFileTypeName,
            this.gridProductName,
            this.gridVersionID,
            this.gridFileApplyID,
            this.gridPersonName,
            this.gridDeptName,
            this.gridFileApplyDate});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.AllowCellMerge = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView2.CellMerge += new DevExpress.XtraGrid.Views.Grid.CellMergeEventHandler(this.gridView2_CellMerge);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "FileGuID";
            this.gridColumn2.FieldName = "FileGuID";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridFileID
            // 
            this.gridFileID.Caption = "文件编号";
            this.gridFileID.FieldName = "FileID";
            this.gridFileID.MinWidth = 162;
            this.gridFileID.Name = "gridFileID";
            this.gridFileID.OptionsColumn.AllowEdit = false;
            this.gridFileID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
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
            this.gridFileName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.gridFileName.Visible = true;
            this.gridFileName.VisibleIndex = 0;
            this.gridFileName.Width = 171;
            // 
            // gridFileTypeName
            // 
            this.gridFileTypeName.Caption = "文件类别";
            this.gridFileTypeName.FieldName = "FileTypeName";
            this.gridFileTypeName.MinWidth = 113;
            this.gridFileTypeName.Name = "gridFileTypeName";
            this.gridFileTypeName.OptionsColumn.AllowEdit = false;
            this.gridFileTypeName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.gridFileTypeName.Visible = true;
            this.gridFileTypeName.VisibleIndex = 2;
            this.gridFileTypeName.Width = 113;
            // 
            // gridProductName
            // 
            this.gridProductName.Caption = "产品名称";
            this.gridProductName.FieldName = "ProductName";
            this.gridProductName.MinWidth = 113;
            this.gridProductName.Name = "gridProductName";
            this.gridProductName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.gridProductName.Visible = true;
            this.gridProductName.VisibleIndex = 3;
            this.gridProductName.Width = 139;
            // 
            // gridVersionID
            // 
            this.gridVersionID.Caption = "版本";
            this.gridVersionID.FieldName = "VersionID";
            this.gridVersionID.MinWidth = 70;
            this.gridVersionID.Name = "gridVersionID";
            this.gridVersionID.OptionsColumn.AllowEdit = false;
            this.gridVersionID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.gridVersionID.Visible = true;
            this.gridVersionID.VisibleIndex = 4;
            this.gridVersionID.Width = 70;
            // 
            // gridFileApplyID
            // 
            this.gridFileApplyID.Caption = "申请单号";
            this.gridFileApplyID.FieldName = "FileApplyID";
            this.gridFileApplyID.MinWidth = 75;
            this.gridFileApplyID.Name = "gridFileApplyID";
            this.gridFileApplyID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridFileApplyID.Visible = true;
            this.gridFileApplyID.VisibleIndex = 5;
            // 
            // gridPersonName
            // 
            this.gridPersonName.Caption = "申请人";
            this.gridPersonName.FieldName = "PersonName";
            this.gridPersonName.MinWidth = 52;
            this.gridPersonName.Name = "gridPersonName";
            this.gridPersonName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridPersonName.Visible = true;
            this.gridPersonName.VisibleIndex = 6;
            this.gridPersonName.Width = 52;
            // 
            // gridDeptName
            // 
            this.gridDeptName.Caption = "申请部门";
            this.gridDeptName.FieldName = "DeptName";
            this.gridDeptName.MinWidth = 67;
            this.gridDeptName.Name = "gridDeptName";
            this.gridDeptName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridDeptName.Visible = true;
            this.gridDeptName.VisibleIndex = 7;
            this.gridDeptName.Width = 67;
            // 
            // gridFileApplyDate
            // 
            this.gridFileApplyDate.Caption = "申请日期";
            this.gridFileApplyDate.FieldName = "FileApplyDate";
            this.gridFileApplyDate.MinWidth = 77;
            this.gridFileApplyDate.Name = "gridFileApplyDate";
            this.gridFileApplyDate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridFileApplyDate.Visible = true;
            this.gridFileApplyDate.VisibleIndex = 8;
            this.gridFileApplyDate.Width = 77;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExport,
            this.exit,
            this.tsbPrint,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1204, 25);
            this.toolStrip1.TabIndex = 141;
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
            // exit
            // 
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(49, 22);
            this.exit.Text = "退出";
            this.exit.Click += new System.EventHandler(this.exit_Click_1);
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
            // frmFileFFCountReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 511);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmFileFFCountReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件资料发放统计报表";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQry;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridFileID;
        private DevExpress.XtraGrid.Columns.GridColumn gridFileName;
        private DevExpress.XtraGrid.Columns.GridColumn gridFileTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn gridProductName;
        private DevExpress.XtraGrid.Columns.GridColumn gridVersionID;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridPersonName;
        private DevExpress.XtraGrid.Columns.GridColumn gridFileApplyDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridDeptName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton exit;
        private DevExpress.XtraGrid.Columns.GridColumn gridFileApplyID;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtFileID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFileClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtControlType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSelectFileApplyPerson;
        private System.Windows.Forms.TextBox txtFileApplyPerson;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSelectDownDept;
        private System.Windows.Forms.TextBox txtDownDept;
        private System.Windows.Forms.Label label12;
    }
}