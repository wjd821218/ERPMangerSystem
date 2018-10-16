namespace ErpManage
{
    partial class frmChangeBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeBill));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridChangeBillGuID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridChangeBillID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridChangeBillDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridChangePersonName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridFileID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridOldVersionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridNewVersionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCheckName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbedit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpChangeBillDateEnd = new DevExpress.XtraEditors.DateEdit();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSelectFileID = new System.Windows.Forms.Button();
            this.txtFileID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtChangeBillID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpChangeBillDateBegin = new DevExpress.XtraEditors.DateEdit();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpChangeBillDateEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpChangeBillDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpChangeBillDateBegin.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpChangeBillDateBegin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 115);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(890, 382);
            this.gridControl1.TabIndex = 72;
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
            this.gridChangeBillGuID,
            this.gridChangeBillID,
            this.gridChangeBillDate,
            this.gridChangePersonName,
            this.gridFileID,
            this.gridFileName,
            this.gridOldVersionID,
            this.gridNewVersionID,
            this.gridRemark,
            this.gridCheckName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // gridChangeBillGuID
            // 
            this.gridChangeBillGuID.Caption = "ChangeBillGuID";
            this.gridChangeBillGuID.FieldName = "ChangeBillGuID";
            this.gridChangeBillGuID.Name = "gridChangeBillGuID";
            // 
            // gridChangeBillID
            // 
            this.gridChangeBillID.Caption = "工程更改单号";
            this.gridChangeBillID.FieldName = "ChangeBillID";
            this.gridChangeBillID.Name = "gridChangeBillID";
            this.gridChangeBillID.OptionsColumn.AllowEdit = false;
            this.gridChangeBillID.Visible = true;
            this.gridChangeBillID.VisibleIndex = 0;
            this.gridChangeBillID.Width = 74;
            // 
            // gridChangeBillDate
            // 
            this.gridChangeBillDate.Caption = "开单日期";
            this.gridChangeBillDate.FieldName = "ChangeBillDate";
            this.gridChangeBillDate.Name = "gridChangeBillDate";
            this.gridChangeBillDate.OptionsColumn.AllowEdit = false;
            this.gridChangeBillDate.Visible = true;
            this.gridChangeBillDate.VisibleIndex = 1;
            this.gridChangeBillDate.Width = 57;
            // 
            // gridChangePersonName
            // 
            this.gridChangePersonName.Caption = "更改人";
            this.gridChangePersonName.FieldName = "ChangePersonName";
            this.gridChangePersonName.Name = "gridChangePersonName";
            this.gridChangePersonName.Visible = true;
            this.gridChangePersonName.VisibleIndex = 2;
            // 
            // gridFileID
            // 
            this.gridFileID.Caption = "文件编号";
            this.gridFileID.FieldName = "FileID";
            this.gridFileID.Name = "gridFileID";
            this.gridFileID.Visible = true;
            this.gridFileID.VisibleIndex = 3;
            // 
            // gridFileName
            // 
            this.gridFileName.Caption = "文件名称";
            this.gridFileName.FieldName = "FileName";
            this.gridFileName.Name = "gridFileName";
            this.gridFileName.Visible = true;
            this.gridFileName.VisibleIndex = 4;
            // 
            // gridOldVersionID
            // 
            this.gridOldVersionID.Caption = "老版本";
            this.gridOldVersionID.FieldName = "OldVersionID";
            this.gridOldVersionID.Name = "gridOldVersionID";
            this.gridOldVersionID.Visible = true;
            this.gridOldVersionID.VisibleIndex = 5;
            // 
            // gridNewVersionID
            // 
            this.gridNewVersionID.Caption = "新版本";
            this.gridNewVersionID.FieldName = "NewVersionID";
            this.gridNewVersionID.Name = "gridNewVersionID";
            this.gridNewVersionID.Visible = true;
            this.gridNewVersionID.VisibleIndex = 6;
            // 
            // gridRemark
            // 
            this.gridRemark.Caption = "备注";
            this.gridRemark.FieldName = "Remark";
            this.gridRemark.Name = "gridRemark";
            this.gridRemark.OptionsColumn.AllowEdit = false;
            this.gridRemark.Visible = true;
            this.gridRemark.VisibleIndex = 7;
            this.gridRemark.Width = 33;
            // 
            // gridCheckName
            // 
            this.gridCheckName.Caption = "审核人";
            this.gridCheckName.FieldName = "CheckName";
            this.gridCheckName.Name = "gridCheckName";
            this.gridCheckName.Visible = true;
            this.gridCheckName.VisibleIndex = 8;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.tsbedit,
            this.btnDelete,
            this.toolStripSeparator1,
            this.exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(890, 25);
            this.toolStrip1.TabIndex = 116;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 22);
            this.btnAdd.Text = "添加工程更改单";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tsbedit
            // 
            this.tsbedit.Image = ((System.Drawing.Image)(resources.GetObject("tsbedit.Image")));
            this.tsbedit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbedit.Name = "tsbedit";
            this.tsbedit.Size = new System.Drawing.Size(109, 22);
            this.tsbedit.Text = "编辑工程更改单";
            this.tsbedit.Click += new System.EventHandler(this.tsbedit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(49, 22);
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.chkCheck);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpChangeBillDateEnd);
            this.panel1.Controls.Add(this.txtFileName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnSelectFileID);
            this.panel1.Controls.Add(this.txtFileID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtChangeBillID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtpChangeBillDateBegin);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 90);
            this.panel1.TabIndex = 117;
            // 
            // chkCheck
            // 
            this.chkCheck.AutoSize = true;
            this.chkCheck.Location = new System.Drawing.Point(541, 58);
            this.chkCheck.Name = "chkCheck";
            this.chkCheck.Size = new System.Drawing.Size(48, 16);
            this.chkCheck.TabIndex = 255;
            this.chkCheck.Text = "审核";
            this.chkCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 254;
            this.label1.Text = "-->";
            // 
            // dtpChangeBillDateEnd
            // 
            this.dtpChangeBillDateEnd.EditValue = null;
            this.dtpChangeBillDateEnd.Location = new System.Drawing.Point(541, 22);
            this.dtpChangeBillDateEnd.Name = "dtpChangeBillDateEnd";
            this.dtpChangeBillDateEnd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dtpChangeBillDateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpChangeBillDateEnd.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpChangeBillDateEnd.Size = new System.Drawing.Size(138, 21);
            this.dtpChangeBillDateEnd.TabIndex = 253;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(345, 59);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(139, 21);
            this.txtFileName.TabIndex = 252;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 251;
            this.label6.Text = "文件名称：";
            // 
            // btnSelectFileID
            // 
            this.btnSelectFileID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectFileID.BackgroundImage")));
            this.btnSelectFileID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectFileID.Location = new System.Drawing.Point(227, 58);
            this.btnSelectFileID.Name = "btnSelectFileID";
            this.btnSelectFileID.Size = new System.Drawing.Size(25, 22);
            this.btnSelectFileID.TabIndex = 250;
            this.btnSelectFileID.UseVisualStyleBackColor = true;
            this.btnSelectFileID.Click += new System.EventHandler(this.btnSelectFileID_Click);
            // 
            // txtFileID
            // 
            this.txtFileID.BackColor = System.Drawing.Color.White;
            this.txtFileID.Location = new System.Drawing.Point(108, 59);
            this.txtFileID.Name = "txtFileID";
            this.txtFileID.ReadOnly = true;
            this.txtFileID.Size = new System.Drawing.Size(122, 21);
            this.txtFileID.TabIndex = 249;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 248;
            this.label2.Text = "文件编号：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(274, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 246;
            this.label9.Text = "开单日期：";
            // 
            // txtChangeBillID
            // 
            this.txtChangeBillID.BackColor = System.Drawing.Color.White;
            this.txtChangeBillID.Location = new System.Drawing.Point(108, 25);
            this.txtChangeBillID.Name = "txtChangeBillID";
            this.txtChangeBillID.Size = new System.Drawing.Size(138, 21);
            this.txtChangeBillID.TabIndex = 245;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 244;
            this.label5.Text = "工程更改编号：";
            // 
            // dtpChangeBillDateBegin
            // 
            this.dtpChangeBillDateBegin.EditValue = null;
            this.dtpChangeBillDateBegin.Location = new System.Drawing.Point(343, 23);
            this.dtpChangeBillDateBegin.Name = "dtpChangeBillDateBegin";
            this.dtpChangeBillDateBegin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dtpChangeBillDateBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpChangeBillDateBegin.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpChangeBillDateBegin.Size = new System.Drawing.Size(138, 21);
            this.dtpChangeBillDateBegin.TabIndex = 247;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(718, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 106;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnQry_Click);
            // 
            // frmChangeBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 497);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmChangeBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "工程更改单";
            this.Load += new System.EventHandler(this.frmChangeBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpChangeBillDateEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpChangeBillDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpChangeBillDateBegin.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpChangeBillDateBegin.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridChangeBillGuID;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridChangeBillID;
        private DevExpress.XtraGrid.Columns.GridColumn gridChangeBillDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridRemark;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton tsbedit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.Columns.GridColumn gridCheckName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dtpChangeBillDateEnd;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSelectFileID;
        private System.Windows.Forms.TextBox txtFileID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtChangeBillID;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.DateEdit dtpChangeBillDateBegin;
        private DevExpress.XtraGrid.Columns.GridColumn gridChangePersonName;
        private DevExpress.XtraGrid.Columns.GridColumn gridFileID;
        private DevExpress.XtraGrid.Columns.GridColumn gridFileName;
        private System.Windows.Forms.CheckBox chkCheck;
        private DevExpress.XtraGrid.Columns.GridColumn gridOldVersionID;
        private DevExpress.XtraGrid.Columns.GridColumn gridNewVersionID;


    }
}