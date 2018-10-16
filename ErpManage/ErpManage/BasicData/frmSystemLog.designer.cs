namespace ErpManage
{
    partial class frmSystemLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSystemLog));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsBtnExit = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtOperateModule = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnQry = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.endDate = new DevExpress.XtraEditors.DateEdit();
            this.BeginDate = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNoSelectAll = new System.Windows.Forms.Button();
            this.btnSelectALL = new System.Windows.Forms.Button();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridCheckBox = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridOperateUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridOperateModule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridOperateType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridOperateContent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridOperateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExport,
            this.toolStripButton1,
            this.tsBtnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(741, 25);
            this.toolStrip1.TabIndex = 67;
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
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton1.Text = "删除";
            this.toolStripButton1.Click += new System.EventHandler(this.tsBtnDel_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 71;
            this.label1.Text = "操作人";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(84, 14);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(137, 21);
            this.txtUserID.TabIndex = 72;
            // 
            // txtOperateModule
            // 
            this.txtOperateModule.Location = new System.Drawing.Point(307, 14);
            this.txtOperateModule.Name = "txtOperateModule";
            this.txtOperateModule.Size = new System.Drawing.Size(137, 21);
            this.txtOperateModule.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 74;
            this.label3.Text = "操作模块";
            // 
            // btnQry
            // 
            this.btnQry.Location = new System.Drawing.Point(478, 30);
            this.btnQry.Name = "btnQry";
            this.btnQry.Size = new System.Drawing.Size(91, 23);
            this.btnQry.TabIndex = 79;
            this.btnQry.Text = "查询";
            this.btnQry.UseVisualStyleBackColor = true;
            this.btnQry.Click += new System.EventHandler(this.btnQry_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 139;
            this.label6.Text = "---->";
            // 
            // endDate
            // 
            this.endDate.EditValue = null;
            this.endDate.Location = new System.Drawing.Point(307, 47);
            this.endDate.Name = "endDate";
            this.endDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.endDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.endDate.Size = new System.Drawing.Size(137, 21);
            this.endDate.TabIndex = 138;
            // 
            // BeginDate
            // 
            this.BeginDate.EditValue = null;
            this.BeginDate.Location = new System.Drawing.Point(84, 47);
            this.BeginDate.Name = "BeginDate";
            this.BeginDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.BeginDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BeginDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.BeginDate.Size = new System.Drawing.Size(137, 21);
            this.BeginDate.TabIndex = 137;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 136;
            this.label2.Text = "操作日期";
            // 
            // btnNoSelectAll
            // 
            this.btnNoSelectAll.Location = new System.Drawing.Point(84, 86);
            this.btnNoSelectAll.Name = "btnNoSelectAll";
            this.btnNoSelectAll.Size = new System.Drawing.Size(65, 23);
            this.btnNoSelectAll.TabIndex = 147;
            this.btnNoSelectAll.Text = "取消全选";
            this.btnNoSelectAll.UseVisualStyleBackColor = true;
            this.btnNoSelectAll.Click += new System.EventHandler(this.btnNoSelectAll_Click);
            // 
            // btnSelectALL
            // 
            this.btnSelectALL.Location = new System.Drawing.Point(11, 86);
            this.btnSelectALL.Name = "btnSelectALL";
            this.btnSelectALL.Size = new System.Drawing.Size(67, 23);
            this.btnSelectALL.TabIndex = 146;
            this.btnSelectALL.Text = "全选";
            this.btnSelectALL.UseVisualStyleBackColor = true;
            this.btnSelectALL.Click += new System.EventHandler(this.btnSelectALL_Click);
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
            this.gridView1.Appearance.RowSeparator.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.RowSeparator.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Appearance.VertLine.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.VertLine.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridCheckBox,
            this.gridOperateUser,
            this.gridOperateModule,
            this.gridOperateType,
            this.gridOperateContent,
            this.gridOperateDate,
            this.gridGuid});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridCheckBox
            // 
            this.gridCheckBox.Caption = "选择";
            this.gridCheckBox.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridCheckBox.FieldName = "selectvalue";
            this.gridCheckBox.MinWidth = 45;
            this.gridCheckBox.Name = "gridCheckBox";
            this.gridCheckBox.Visible = true;
            this.gridCheckBox.VisibleIndex = 0;
            this.gridCheckBox.Width = 69;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.RadioGroupIndex = 0;
            this.repositoryItemCheckEdit1.QueryCheckStateByValue += new DevExpress.XtraEditors.Controls.QueryCheckStateByValueEventHandler(this.repositoryItemCheckEdit1_QueryCheckStateByValue);
            // 
            // gridOperateUser
            // 
            this.gridOperateUser.Caption = "操作人";
            this.gridOperateUser.FieldName = "OperateUser";
            this.gridOperateUser.MinWidth = 87;
            this.gridOperateUser.Name = "gridOperateUser";
            this.gridOperateUser.OptionsColumn.AllowEdit = false;
            this.gridOperateUser.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.gridOperateUser.Visible = true;
            this.gridOperateUser.VisibleIndex = 1;
            this.gridOperateUser.Width = 106;
            // 
            // gridOperateModule
            // 
            this.gridOperateModule.Caption = "操作模块";
            this.gridOperateModule.FieldName = "OperateModule";
            this.gridOperateModule.MinWidth = 75;
            this.gridOperateModule.Name = "gridOperateModule";
            this.gridOperateModule.OptionsColumn.AllowEdit = false;
            this.gridOperateModule.Visible = true;
            this.gridOperateModule.VisibleIndex = 2;
            // 
            // gridOperateType
            // 
            this.gridOperateType.Caption = "操作类型";
            this.gridOperateType.FieldName = "OperateType";
            this.gridOperateType.Name = "gridOperateType";
            this.gridOperateType.OptionsColumn.AllowEdit = false;
            this.gridOperateType.Visible = true;
            this.gridOperateType.VisibleIndex = 3;
            this.gridOperateType.Width = 54;
            // 
            // gridOperateContent
            // 
            this.gridOperateContent.AppearanceCell.BackColor = System.Drawing.Color.OldLace;
            this.gridOperateContent.AppearanceCell.Options.UseBackColor = true;
            this.gridOperateContent.Caption = "操作内容";
            this.gridOperateContent.FieldName = "OperateContent";
            this.gridOperateContent.MinWidth = 70;
            this.gridOperateContent.Name = "gridOperateContent";
            this.gridOperateContent.Visible = true;
            this.gridOperateContent.VisibleIndex = 4;
            this.gridOperateContent.Width = 70;
            // 
            // gridOperateDate
            // 
            this.gridOperateDate.Caption = "操作日期";
            this.gridOperateDate.FieldName = "OperateDate";
            this.gridOperateDate.Name = "gridOperateDate";
            this.gridOperateDate.Visible = true;
            this.gridOperateDate.VisibleIndex = 5;
            this.gridOperateDate.Width = 118;
            // 
            // gridGuid
            // 
            this.gridGuid.Caption = "gridGuid";
            this.gridGuid.FieldName = "NoID";
            this.gridGuid.Name = "gridGuid";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridControl1.Location = new System.Drawing.Point(0, 149);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(741, 403);
            this.gridControl1.TabIndex = 148;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtUserID);
            this.panel1.Controls.Add(this.btnNoSelectAll);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSelectALL);
            this.panel1.Controls.Add(this.txtOperateModule);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnQry);
            this.panel1.Controls.Add(this.endDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BeginDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 124);
            this.panel1.TabIndex = 149;
            // 
            // frmSystemLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 552);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSystemLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统操作日志";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtOperateModule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQry;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.DateEdit endDate;
        private DevExpress.XtraEditors.DateEdit BeginDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button btnNoSelectAll;
        private System.Windows.Forms.Button btnSelectALL;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridCheckBox;
        private DevExpress.XtraGrid.Columns.GridColumn gridOperateUser;
        private DevExpress.XtraGrid.Columns.GridColumn gridOperateModule;
        private DevExpress.XtraGrid.Columns.GridColumn gridOperateType;
        private DevExpress.XtraGrid.Columns.GridColumn gridOperateContent;
        private DevExpress.XtraGrid.Columns.GridColumn gridOperateDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridGuid;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.Panel panel1;
    }
}