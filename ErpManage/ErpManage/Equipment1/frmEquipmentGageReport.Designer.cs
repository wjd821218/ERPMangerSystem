namespace ErpManage
{
    partial class frmEquipmentGageReport
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;

        private DevExpress.XtraGrid.Columns.GridColumn gridGageSpec;
        private DevExpress.XtraGrid.Columns.GridColumn gridLeaveFactoryID;
        private DevExpress.XtraGrid.Columns.GridColumn gridScaleArea;
        private DevExpress.XtraGrid.Columns.GridColumn gridScalePrecision;
        private DevExpress.XtraGrid.Columns.GridColumn gridManageLevel;
        private DevExpress.XtraGrid.Columns.GridColumn gridCheckType;
        private DevExpress.XtraGrid.Columns.GridColumn gridCheckCycle;
        private DevExpress.XtraGrid.Columns.GridColumn gridCheckUnit;
        private DevExpress.XtraGrid.Columns.GridColumn gridAppraisalRecord;
        private DevExpress.XtraGrid.Columns.GridColumn gridEquipmentID;
        private DevExpress.XtraGrid.Columns.GridColumn gridEquipmentName;
        private DevExpress.XtraGrid.Columns.GridColumn gridUsePerson;
        private DevExpress.XtraGrid.Columns.GridColumn gridSavePlace;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEquipmentGageReport));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.gridGageSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridLeaveFactoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridScaleArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridScalePrecision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridManageLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCheckType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCheckCycle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCheckUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAppraisalRecord = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridEquipmentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridEquipmentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUsePerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSavePlace = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridEquipmentState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(850, 25);
            this.toolStrip1.TabIndex = 143;
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
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // gridGageSpec
            // 
            this.gridGageSpec.Caption = "规格型号";
            this.gridGageSpec.FieldName = "GageSpec";
            this.gridGageSpec.Name = "gridGageSpec";
            this.gridGageSpec.OptionsColumn.AllowEdit = false;
            this.gridGageSpec.Visible = true;
            this.gridGageSpec.VisibleIndex = 1;
            // 
            // gridLeaveFactoryID
            // 
            this.gridLeaveFactoryID.Caption = "出厂编号";
            this.gridLeaveFactoryID.FieldName = "LeaveFactoryID";
            this.gridLeaveFactoryID.Name = "gridLeaveFactoryID";
            this.gridLeaveFactoryID.OptionsColumn.AllowEdit = false;
            this.gridLeaveFactoryID.Visible = true;
            this.gridLeaveFactoryID.VisibleIndex = 3;
            // 
            // gridScaleArea
            // 
            this.gridScaleArea.Caption = "测量范围";
            this.gridScaleArea.FieldName = "ScaleArea";
            this.gridScaleArea.Name = "gridScaleArea";
            this.gridScaleArea.OptionsColumn.AllowEdit = false;
            this.gridScaleArea.Visible = true;
            this.gridScaleArea.VisibleIndex = 5;
            // 
            // gridScalePrecision
            // 
            this.gridScalePrecision.Caption = "精度";
            this.gridScalePrecision.FieldName = "ScalePrecision";
            this.gridScalePrecision.Name = "gridScalePrecision";
            this.gridScalePrecision.OptionsColumn.AllowEdit = false;
            this.gridScalePrecision.Visible = true;
            this.gridScalePrecision.VisibleIndex = 7;
            // 
            // gridManageLevel
            // 
            this.gridManageLevel.Caption = "管理级别";
            this.gridManageLevel.FieldName = "ManageLevel";
            this.gridManageLevel.Name = "gridManageLevel";
            this.gridManageLevel.OptionsColumn.AllowEdit = false;
            this.gridManageLevel.Visible = true;
            this.gridManageLevel.VisibleIndex = 8;
            // 
            // gridCheckType
            // 
            this.gridCheckType.Caption = "检定方式";
            this.gridCheckType.FieldName = "CheckType";
            this.gridCheckType.Name = "gridCheckType";
            this.gridCheckType.OptionsColumn.AllowEdit = false;
            this.gridCheckType.Visible = true;
            this.gridCheckType.VisibleIndex = 9;
            // 
            // gridCheckCycle
            // 
            this.gridCheckCycle.Caption = "校准周期";
            this.gridCheckCycle.FieldName = "CheckCycle";
            this.gridCheckCycle.Name = "gridCheckCycle";
            this.gridCheckCycle.OptionsColumn.AllowEdit = false;
            this.gridCheckCycle.Visible = true;
            this.gridCheckCycle.VisibleIndex = 10;
            // 
            // gridCheckUnit
            // 
            this.gridCheckUnit.Caption = "校准单位";
            this.gridCheckUnit.FieldName = "CheckUnit";
            this.gridCheckUnit.Name = "gridCheckUnit";
            this.gridCheckUnit.OptionsColumn.AllowEdit = false;
            this.gridCheckUnit.Visible = true;
            this.gridCheckUnit.VisibleIndex = 11;
            // 
            // gridAppraisalRecord
            // 
            this.gridAppraisalRecord.Caption = "鉴定记录";
            this.gridAppraisalRecord.FieldName = "AppraisalRecord";
            this.gridAppraisalRecord.Name = "gridAppraisalRecord";
            this.gridAppraisalRecord.OptionsColumn.AllowEdit = false;
            this.gridAppraisalRecord.Visible = true;
            this.gridAppraisalRecord.VisibleIndex = 12;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.HideSelection = false;
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridControl1.Location = new System.Drawing.Point(0, 25);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1});
            this.gridControl1.Size = new System.Drawing.Size(850, 488);
            this.gridControl1.TabIndex = 77;
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
            this.gridView1.Appearance.RowSeparator.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.RowSeparator.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Appearance.VertLine.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.VertLine.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridEquipmentID,
            this.gridEquipmentName,
            this.gridUsePerson,
            this.gridSavePlace,
            this.gridGageSpec,
            this.gridLeaveFactoryID,
            this.gridScaleArea,
            this.gridScalePrecision,
            this.gridManageLevel,
            this.gridCheckType,
            this.gridCheckCycle,
            this.gridCheckUnit,
            this.gridAppraisalRecord,
            this.gridEquipmentState});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridEquipmentID
            // 
            this.gridEquipmentID.Caption = "编号";
            this.gridEquipmentID.FieldName = "EquipmentID";
            this.gridEquipmentID.Name = "gridEquipmentID";
            this.gridEquipmentID.Visible = true;
            this.gridEquipmentID.VisibleIndex = 0;
            // 
            // gridEquipmentName
            // 
            this.gridEquipmentName.Caption = "名称";
            this.gridEquipmentName.FieldName = "EquipmentName";
            this.gridEquipmentName.Name = "gridEquipmentName";
            this.gridEquipmentName.Visible = true;
            this.gridEquipmentName.VisibleIndex = 2;
            // 
            // gridUsePerson
            // 
            this.gridUsePerson.Caption = "使用人";
            this.gridUsePerson.FieldName = "UsePerson";
            this.gridUsePerson.Name = "gridUsePerson";
            this.gridUsePerson.Visible = true;
            this.gridUsePerson.VisibleIndex = 4;
            // 
            // gridSavePlace
            // 
            this.gridSavePlace.Caption = "存放地点";
            this.gridSavePlace.FieldName = "SavePlace";
            this.gridSavePlace.Name = "gridSavePlace";
            this.gridSavePlace.Visible = true;
            this.gridSavePlace.VisibleIndex = 6;
            // 
            // gridEquipmentState
            // 
            this.gridEquipmentState.Caption = "状态";
            this.gridEquipmentState.FieldName = "EquipmentStateName";
            this.gridEquipmentState.Name = "gridEquipmentState";
            this.gridEquipmentState.Visible = true;
            this.gridEquipmentState.VisibleIndex = 13;
            // 
            // frmEquipmentGageReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 513);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmEquipmentGageReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "计量器一览表";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEquipmentGageReport_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton exit;
        private DevExpress.XtraGrid.Columns.GridColumn gridEquipmentState;
    }
}