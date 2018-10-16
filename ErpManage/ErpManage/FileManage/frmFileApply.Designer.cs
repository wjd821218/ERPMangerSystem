namespace ErpManage
{
    partial class frmFileApply
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFileApply));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridFileApplyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridFileApplyDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridFileApplyType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridFileApplyPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridFileApplyDept = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCheckName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridFileApplyGuID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbedit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkCheck = new System.Windows.Forms.CheckBox();
            this.btnSelectFileApplyDept = new System.Windows.Forms.Button();
            this.txtFileApplyDept = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectFileApplyPerson = new System.Windows.Forms.Button();
            this.txtFileApplyPerson = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboFileApplyType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQry = new System.Windows.Forms.Button();
            this.deFileApplyEndDate = new DevExpress.XtraEditors.DateEdit();
            this.deFileApplyBeginDate = new DevExpress.XtraEditors.DateEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFileApplyID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deFileApplyEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFileApplyEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFileApplyBeginDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFileApplyBeginDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 126);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(986, 407);
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
            this.gridFileApplyID,
            this.gridFileApplyDate,
            this.gridFileApplyType,
            this.gridFileApplyPerson,
            this.gridFileApplyDept,
            this.gridRemark,
            this.gridCheckName,
            this.gridFileApplyGuID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // gridFileApplyID
            // 
            this.gridFileApplyID.Caption = "申请单号";
            this.gridFileApplyID.FieldName = "FileApplyID";
            this.gridFileApplyID.Name = "gridFileApplyID";
            this.gridFileApplyID.OptionsColumn.AllowEdit = false;
            this.gridFileApplyID.Visible = true;
            this.gridFileApplyID.VisibleIndex = 0;
            this.gridFileApplyID.Width = 104;
            // 
            // gridFileApplyDate
            // 
            this.gridFileApplyDate.Caption = "申请日期";
            this.gridFileApplyDate.FieldName = "FileApplyDate";
            this.gridFileApplyDate.Name = "gridFileApplyDate";
            this.gridFileApplyDate.OptionsColumn.AllowEdit = false;
            this.gridFileApplyDate.Visible = true;
            this.gridFileApplyDate.VisibleIndex = 1;
            this.gridFileApplyDate.Width = 111;
            // 
            // gridFileApplyType
            // 
            this.gridFileApplyType.Caption = "申请类别(员工/部门)";
            this.gridFileApplyType.FieldName = "FileApplyTypeName";
            this.gridFileApplyType.Name = "gridFileApplyType";
            this.gridFileApplyType.OptionsColumn.AllowEdit = false;
            this.gridFileApplyType.Visible = true;
            this.gridFileApplyType.VisibleIndex = 2;
            this.gridFileApplyType.Width = 153;
            // 
            // gridFileApplyPerson
            // 
            this.gridFileApplyPerson.Caption = "申请人";
            this.gridFileApplyPerson.FieldName = "FileApplyPerson";
            this.gridFileApplyPerson.Name = "gridFileApplyPerson";
            this.gridFileApplyPerson.OptionsColumn.AllowEdit = false;
            this.gridFileApplyPerson.Visible = true;
            this.gridFileApplyPerson.VisibleIndex = 3;
            this.gridFileApplyPerson.Width = 101;
            // 
            // gridFileApplyDept
            // 
            this.gridFileApplyDept.Caption = "申请部门";
            this.gridFileApplyDept.FieldName = "FileApplyDeptName";
            this.gridFileApplyDept.Name = "gridFileApplyDept";
            this.gridFileApplyDept.Visible = true;
            this.gridFileApplyDept.VisibleIndex = 4;
            this.gridFileApplyDept.Width = 96;
            // 
            // gridRemark
            // 
            this.gridRemark.Caption = "备注";
            this.gridRemark.FieldName = "Remark";
            this.gridRemark.Name = "gridRemark";
            this.gridRemark.OptionsColumn.AllowEdit = false;
            this.gridRemark.Visible = true;
            this.gridRemark.VisibleIndex = 5;
            this.gridRemark.Width = 91;
            // 
            // gridCheckName
            // 
            this.gridCheckName.Caption = "审核人";
            this.gridCheckName.FieldName = "CheckName";
            this.gridCheckName.Name = "gridCheckName";
            this.gridCheckName.Visible = true;
            this.gridCheckName.VisibleIndex = 6;
            this.gridCheckName.Width = 224;
            // 
            // gridFileApplyGuID
            // 
            this.gridFileApplyGuID.Caption = "gridColumn1";
            this.gridFileApplyGuID.FieldName = "FileApplyGuID";
            this.gridFileApplyGuID.Name = "gridFileApplyGuID";
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
            this.toolStrip1.Size = new System.Drawing.Size(986, 25);
            this.toolStrip1.TabIndex = 116;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 22);
            this.btnAdd.Text = "添加申请单";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tsbedit
            // 
            this.tsbedit.Image = ((System.Drawing.Image)(resources.GetObject("tsbedit.Image")));
            this.tsbedit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbedit.Name = "tsbedit";
            this.tsbedit.Size = new System.Drawing.Size(85, 22);
            this.tsbedit.Text = "编辑申请单";
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
            this.panel1.Controls.Add(this.btnSelectFileApplyDept);
            this.panel1.Controls.Add(this.txtFileApplyDept);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSelectFileApplyPerson);
            this.panel1.Controls.Add(this.txtFileApplyPerson);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cboFileApplyType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnQry);
            this.panel1.Controls.Add(this.deFileApplyEndDate);
            this.panel1.Controls.Add(this.deFileApplyBeginDate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtFileApplyID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 101);
            this.panel1.TabIndex = 117;
            // 
            // chkCheck
            // 
            this.chkCheck.AutoSize = true;
            this.chkCheck.Location = new System.Drawing.Point(683, 63);
            this.chkCheck.Name = "chkCheck";
            this.chkCheck.Size = new System.Drawing.Size(48, 16);
            this.chkCheck.TabIndex = 248;
            this.chkCheck.Text = "审核";
            this.chkCheck.UseVisualStyleBackColor = true;
            // 
            // btnSelectFileApplyDept
            // 
            this.btnSelectFileApplyDept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectFileApplyDept.BackgroundImage")));
            this.btnSelectFileApplyDept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectFileApplyDept.Location = new System.Drawing.Point(412, 58);
            this.btnSelectFileApplyDept.Name = "btnSelectFileApplyDept";
            this.btnSelectFileApplyDept.Size = new System.Drawing.Size(25, 22);
            this.btnSelectFileApplyDept.TabIndex = 247;
            this.btnSelectFileApplyDept.UseVisualStyleBackColor = true;
            this.btnSelectFileApplyDept.Click += new System.EventHandler(this.btnSelectFileApplyDept_Click);
            // 
            // txtFileApplyDept
            // 
            this.txtFileApplyDept.BackColor = System.Drawing.Color.White;
            this.txtFileApplyDept.Location = new System.Drawing.Point(274, 59);
            this.txtFileApplyDept.Name = "txtFileApplyDept";
            this.txtFileApplyDept.ReadOnly = true;
            this.txtFileApplyDept.Size = new System.Drawing.Size(138, 21);
            this.txtFileApplyDept.TabIndex = 246;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 245;
            this.label2.Text = "申请部门：";
            // 
            // btnSelectFileApplyPerson
            // 
            this.btnSelectFileApplyPerson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectFileApplyPerson.BackgroundImage")));
            this.btnSelectFileApplyPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectFileApplyPerson.Location = new System.Drawing.Point(631, 57);
            this.btnSelectFileApplyPerson.Name = "btnSelectFileApplyPerson";
            this.btnSelectFileApplyPerson.Size = new System.Drawing.Size(25, 22);
            this.btnSelectFileApplyPerson.TabIndex = 244;
            this.btnSelectFileApplyPerson.UseVisualStyleBackColor = true;
            this.btnSelectFileApplyPerson.Click += new System.EventHandler(this.btnSelectFileApplyPerson_Click);
            // 
            // txtFileApplyPerson
            // 
            this.txtFileApplyPerson.BackColor = System.Drawing.Color.White;
            this.txtFileApplyPerson.Location = new System.Drawing.Point(518, 58);
            this.txtFileApplyPerson.Name = "txtFileApplyPerson";
            this.txtFileApplyPerson.ReadOnly = true;
            this.txtFileApplyPerson.Size = new System.Drawing.Size(115, 21);
            this.txtFileApplyPerson.TabIndex = 243;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 242;
            this.label4.Text = "申请人：";
            // 
            // cboFileApplyType
            // 
            this.cboFileApplyType.FormattingEnabled = true;
            this.cboFileApplyType.Items.AddRange(new object[] {
            "",
            "员工",
            "部门"});
            this.cboFileApplyType.Location = new System.Drawing.Point(74, 58);
            this.cboFileApplyType.Name = "cboFileApplyType";
            this.cboFileApplyType.Size = new System.Drawing.Size(112, 20);
            this.cboFileApplyType.TabIndex = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 107;
            this.label1.Text = "申请类别";
            // 
            // btnQry
            // 
            this.btnQry.Location = new System.Drawing.Point(739, 28);
            this.btnQry.Name = "btnQry";
            this.btnQry.Size = new System.Drawing.Size(68, 30);
            this.btnQry.TabIndex = 106;
            this.btnQry.Text = "查询";
            this.btnQry.UseVisualStyleBackColor = true;
            this.btnQry.Click += new System.EventHandler(this.btnQry_Click);
            // 
            // deFileApplyEndDate
            // 
            this.deFileApplyEndDate.EditValue = null;
            this.deFileApplyEndDate.Location = new System.Drawing.Point(518, 25);
            this.deFileApplyEndDate.Name = "deFileApplyEndDate";
            this.deFileApplyEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFileApplyEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFileApplyEndDate.Size = new System.Drawing.Size(115, 21);
            this.deFileApplyEndDate.TabIndex = 105;
            // 
            // deFileApplyBeginDate
            // 
            this.deFileApplyBeginDate.EditValue = null;
            this.deFileApplyBeginDate.Location = new System.Drawing.Point(273, 23);
            this.deFileApplyBeginDate.Name = "deFileApplyBeginDate";
            this.deFileApplyBeginDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFileApplyBeginDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFileApplyBeginDate.Size = new System.Drawing.Size(139, 21);
            this.deFileApplyBeginDate.TabIndex = 104;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(459, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 103;
            this.label7.Text = "--->";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 102;
            this.label6.Text = "申请日期";
            // 
            // txtFileApplyID
            // 
            this.txtFileApplyID.Location = new System.Drawing.Point(74, 23);
            this.txtFileApplyID.MaxLength = 50;
            this.txtFileApplyID.Name = "txtFileApplyID";
            this.txtFileApplyID.Size = new System.Drawing.Size(112, 21);
            this.txtFileApplyID.TabIndex = 97;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 96;
            this.label3.Text = "申请单号";
            // 
            // frmFileApply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 533);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmFileApply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件查阅申请";
            this.Load += new System.EventHandler(this.frmFileApply_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deFileApplyEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFileApplyEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFileApplyBeginDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFileApplyBeginDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridFileApplyID;
        private DevExpress.XtraGrid.Columns.GridColumn gridFileApplyDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridFileApplyPerson;
        private DevExpress.XtraGrid.Columns.GridColumn gridFileApplyDept;
        private DevExpress.XtraGrid.Columns.GridColumn gridFileApplyType;
        private DevExpress.XtraGrid.Columns.GridColumn gridRemark;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton tsbedit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQry;
        private DevExpress.XtraEditors.DateEdit deFileApplyEndDate;
        private DevExpress.XtraEditors.DateEdit deFileApplyBeginDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFileApplyID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboFileApplyType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectFileApplyDept;
        private System.Windows.Forms.TextBox txtFileApplyDept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectFileApplyPerson;
        private System.Windows.Forms.TextBox txtFileApplyPerson;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.Columns.GridColumn gridCheckName;
        private DevExpress.XtraGrid.Columns.GridColumn gridFileApplyGuID;
        private System.Windows.Forms.CheckBox chkCheck;


    }
}