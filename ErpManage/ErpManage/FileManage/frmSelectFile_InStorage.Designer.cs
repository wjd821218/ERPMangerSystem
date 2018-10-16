namespace ErpManage
{
    partial class frmSelectFile_InStorage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectFile_InStorage));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridFileGuID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCheckBox = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridFileID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridFileType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridPublishDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridVersionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridWriteDept = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridstate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridIsStorage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnQry = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQryValue = new System.Windows.Forms.TextBox();
            this.cboQry = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(179, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(554, 385);
            this.gridControl1.TabIndex = 71;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridFileGuID,
            this.gridCheckBox,
            this.gridFileID,
            this.gridFileName,
            this.gridFileType,
            this.gridProductName,
            this.gridPublishDate,
            this.gridVersionID,
            this.gridControlType,
            this.gridWriteDept,
            this.gridstate,
            this.gridIsStorage});
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
            // gridCheckBox
            // 
            this.gridCheckBox.Caption = "选择";
            this.gridCheckBox.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridCheckBox.FieldName = "selectvalue";
            this.gridCheckBox.Name = "gridCheckBox";
            this.gridCheckBox.Visible = true;
            this.gridCheckBox.VisibleIndex = 0;
            this.gridCheckBox.Width = 34;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.QueryCheckStateByValue += new DevExpress.XtraEditors.Controls.QueryCheckStateByValueEventHandler(this.repositoryItemCheckEdit1_QueryCheckStateByValue);
            // 
            // gridFileID
            // 
            this.gridFileID.Caption = "文件编号";
            this.gridFileID.FieldName = "文件编号";
            this.gridFileID.Name = "gridFileID";
            this.gridFileID.OptionsColumn.AllowEdit = false;
            this.gridFileID.Visible = true;
            this.gridFileID.VisibleIndex = 1;
            this.gridFileID.Width = 74;
            // 
            // gridFileName
            // 
            this.gridFileName.Caption = "文件名称";
            this.gridFileName.FieldName = "文件名称";
            this.gridFileName.Name = "gridFileName";
            this.gridFileName.OptionsColumn.AllowEdit = false;
            this.gridFileName.Visible = true;
            this.gridFileName.VisibleIndex = 2;
            this.gridFileName.Width = 78;
            // 
            // gridFileType
            // 
            this.gridFileType.Caption = "文件类别";
            this.gridFileType.FieldName = "文件类别";
            this.gridFileType.Name = "gridFileType";
            this.gridFileType.OptionsColumn.AllowEdit = false;
            this.gridFileType.Visible = true;
            this.gridFileType.VisibleIndex = 3;
            this.gridFileType.Width = 60;
            // 
            // gridProductName
            // 
            this.gridProductName.Caption = "产品名称";
            this.gridProductName.FieldName = "产品名称";
            this.gridProductName.Name = "gridProductName";
            this.gridProductName.Visible = true;
            this.gridProductName.VisibleIndex = 6;
            this.gridProductName.Width = 48;
            // 
            // gridPublishDate
            // 
            this.gridPublishDate.Caption = "发布日期";
            this.gridPublishDate.FieldName = "发布日期";
            this.gridPublishDate.Name = "gridPublishDate";
            this.gridPublishDate.OptionsColumn.AllowEdit = false;
            this.gridPublishDate.Visible = true;
            this.gridPublishDate.VisibleIndex = 4;
            this.gridPublishDate.Width = 57;
            // 
            // gridVersionID
            // 
            this.gridVersionID.Caption = "版本";
            this.gridVersionID.FieldName = "版本";
            this.gridVersionID.Name = "gridVersionID";
            this.gridVersionID.OptionsColumn.AllowEdit = false;
            this.gridVersionID.Visible = true;
            this.gridVersionID.VisibleIndex = 5;
            this.gridVersionID.Width = 33;
            // 
            // gridControlType
            // 
            this.gridControlType.Caption = "受控类别";
            this.gridControlType.FieldName = "受控类别";
            this.gridControlType.Name = "gridControlType";
            this.gridControlType.Visible = true;
            this.gridControlType.VisibleIndex = 7;
            this.gridControlType.Width = 48;
            // 
            // gridWriteDept
            // 
            this.gridWriteDept.Caption = "编写部门";
            this.gridWriteDept.FieldName = "编写部门";
            this.gridWriteDept.Name = "gridWriteDept";
            this.gridWriteDept.Visible = true;
            this.gridWriteDept.VisibleIndex = 8;
            this.gridWriteDept.Width = 48;
            // 
            // gridstate
            // 
            this.gridstate.Caption = "状态";
            this.gridstate.FieldName = "状态";
            this.gridstate.Name = "gridstate";
            this.gridstate.OptionsColumn.AllowEdit = false;
            this.gridstate.Visible = true;
            this.gridstate.VisibleIndex = 9;
            this.gridstate.Width = 71;
            // 
            // gridIsStorage
            // 
            this.gridIsStorage.Caption = "是否入库";
            this.gridIsStorage.FieldName = "IsStorage";
            this.gridIsStorage.Name = "gridIsStorage";
            this.gridIsStorage.Visible = true;
            this.gridIsStorage.VisibleIndex = 10;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(413, 15);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(81, 23);
            this.btnSelect.TabIndex = 74;
            this.btnSelect.Text = "选定";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
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
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 48);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(179, 385);
            this.treeView1.TabIndex = 72;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtQryValue);
            this.groupBox1.Controls.Add(this.cboQry);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkAll);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.btnQry);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 48);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 84;
            this.label2.Text = "值为";
            // 
            // txtQryValue
            // 
            this.txtQryValue.Location = new System.Drawing.Point(183, 16);
            this.txtQryValue.Name = "txtQryValue";
            this.txtQryValue.Size = new System.Drawing.Size(110, 21);
            this.txtQryValue.TabIndex = 83;
            this.txtQryValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQryValue_KeyPress);
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
            this.cboQry.Location = new System.Drawing.Point(43, 15);
            this.cboQry.Name = "cboQry";
            this.cboQry.Size = new System.Drawing.Size(101, 20);
            this.cboQry.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 81;
            this.label1.Text = "查询";
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(502, 19);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(48, 16);
            this.chkAll.TabIndex = 80;
            this.chkAll.Text = "全选";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.Click += new System.EventHandler(this.chkAll_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(653, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 23);
            this.button1.TabIndex = 79;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "star.png");
            // 
            // frmSelectFile_InStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 433);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSelectFile_InStorage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择文件";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSelectFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridFileGuID;
        private DevExpress.XtraGrid.Columns.GridColumn gridCheckBox;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridFileID;
        private DevExpress.XtraGrid.Columns.GridColumn gridFileName;
        private DevExpress.XtraGrid.Columns.GridColumn gridFileType;
        private DevExpress.XtraGrid.Columns.GridColumn gridProductName;
        private DevExpress.XtraGrid.Columns.GridColumn gridPublishDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridVersionID;
        private DevExpress.XtraGrid.Columns.GridColumn gridControlType;
        private DevExpress.XtraGrid.Columns.GridColumn gridstate;
        private DevExpress.XtraGrid.Columns.GridColumn gridWriteDept;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnQry;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkAll;
        private DevExpress.XtraGrid.Columns.GridColumn gridIsStorage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQryValue;
        private System.Windows.Forms.ComboBox cboQry;
        private System.Windows.Forms.Label label1;
    }
}