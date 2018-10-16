namespace ErpManage
{
    partial class frmEquipmentDieReport
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridDieType;
        private DevExpress.XtraGrid.Columns.GridColumn gridProductType;
        private DevExpress.XtraGrid.Columns.GridColumn gridLife;
        private DevExpress.XtraGrid.Columns.GridColumn gridEnergy;
        private DevExpress.XtraGrid.Columns.GridColumn gridPartName;
        private DevExpress.XtraGrid.Columns.GridColumn gridPartID;
        private DevExpress.XtraGrid.Columns.GridColumn gridExteriorSize;
        private DevExpress.XtraGrid.Columns.GridColumn gridDatum;
        private DevExpress.XtraGrid.Columns.GridColumn gridDieSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridAperture;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEquipmentDieReport));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.gridDieType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridProductType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridLife = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridEnergy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridPartName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridPartID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridExteriorSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridDatum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridDieSource = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAperture = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.toolStrip1.Size = new System.Drawing.Size(949, 25);
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
            // gridDieType
            // 
            this.gridDieType.Caption = "模具类别";
            this.gridDieType.FieldName = "DieType";
            this.gridDieType.Name = "gridDieType";
            this.gridDieType.OptionsColumn.AllowEdit = false;
            this.gridDieType.Visible = true;
            this.gridDieType.VisibleIndex = 4;
            this.gridDieType.Width = 82;
            // 
            // gridProductType
            // 
            this.gridProductType.Caption = "产品类别";
            this.gridProductType.FieldName = "ProductType";
            this.gridProductType.Name = "gridProductType";
            this.gridProductType.OptionsColumn.AllowEdit = false;
            this.gridProductType.Visible = true;
            this.gridProductType.VisibleIndex = 5;
            this.gridProductType.Width = 82;
            // 
            // gridLife
            // 
            this.gridLife.Caption = "寿命";
            this.gridLife.FieldName = "Life";
            this.gridLife.Name = "gridLife";
            this.gridLife.OptionsColumn.AllowEdit = false;
            this.gridLife.Visible = true;
            this.gridLife.VisibleIndex = 6;
            this.gridLife.Width = 82;
            // 
            // gridEnergy
            // 
            this.gridEnergy.Caption = "产能";
            this.gridEnergy.FieldName = "Energy";
            this.gridEnergy.Name = "gridEnergy";
            this.gridEnergy.OptionsColumn.AllowEdit = false;
            this.gridEnergy.Visible = true;
            this.gridEnergy.VisibleIndex = 7;
            this.gridEnergy.Width = 82;
            // 
            // gridPartName
            // 
            this.gridPartName.Caption = "零件名称";
            this.gridPartName.FieldName = "PartName";
            this.gridPartName.Name = "gridPartName";
            this.gridPartName.OptionsColumn.AllowEdit = false;
            this.gridPartName.Visible = true;
            this.gridPartName.VisibleIndex = 8;
            this.gridPartName.Width = 82;
            // 
            // gridPartID
            // 
            this.gridPartID.Caption = "零件物料编号";
            this.gridPartID.FieldName = "PartID";
            this.gridPartID.Name = "gridPartID";
            this.gridPartID.OptionsColumn.AllowEdit = false;
            this.gridPartID.Visible = true;
            this.gridPartID.VisibleIndex = 9;
            this.gridPartID.Width = 82;
            // 
            // gridExteriorSize
            // 
            this.gridExteriorSize.Caption = "外型尺寸（mm)";
            this.gridExteriorSize.FieldName = "ExteriorSize";
            this.gridExteriorSize.Name = "gridExteriorSize";
            this.gridExteriorSize.OptionsColumn.AllowEdit = false;
            this.gridExteriorSize.Visible = true;
            this.gridExteriorSize.VisibleIndex = 10;
            this.gridExteriorSize.Width = 82;
            // 
            // gridDatum
            // 
            this.gridDatum.Caption = "材料";
            this.gridDatum.FieldName = "Datum";
            this.gridDatum.Name = "gridDatum";
            this.gridDatum.OptionsColumn.AllowEdit = false;
            this.gridDatum.Visible = true;
            this.gridDatum.VisibleIndex = 11;
            this.gridDatum.Width = 82;
            // 
            // gridDieSource
            // 
            this.gridDieSource.Caption = "模具来源";
            this.gridDieSource.FieldName = "DieSource";
            this.gridDieSource.Name = "gridDieSource";
            this.gridDieSource.OptionsColumn.AllowEdit = false;
            this.gridDieSource.Visible = true;
            this.gridDieSource.VisibleIndex = 12;
            this.gridDieSource.Width = 82;
            // 
            // gridAperture
            // 
            this.gridAperture.Caption = "模穴";
            this.gridAperture.FieldName = "Aperture";
            this.gridAperture.Name = "gridAperture";
            this.gridAperture.OptionsColumn.AllowEdit = false;
            this.gridAperture.Visible = true;
            this.gridAperture.VisibleIndex = 13;
            this.gridAperture.Width = 86;
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
            this.gridControl1.Size = new System.Drawing.Size(949, 588);
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
            this.gridDieType,
            this.gridProductType,
            this.gridLife,
            this.gridEnergy,
            this.gridPartName,
            this.gridPartID,
            this.gridExteriorSize,
            this.gridDatum,
            this.gridDieSource,
            this.gridAperture,
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
            this.gridEquipmentName.VisibleIndex = 1;
            // 
            // gridUsePerson
            // 
            this.gridUsePerson.Caption = "使用人";
            this.gridUsePerson.FieldName = "UsePerson";
            this.gridUsePerson.Name = "gridUsePerson";
            this.gridUsePerson.Visible = true;
            this.gridUsePerson.VisibleIndex = 2;
            // 
            // gridSavePlace
            // 
            this.gridSavePlace.Caption = "存放地点";
            this.gridSavePlace.FieldName = "SavePlace";
            this.gridSavePlace.Name = "gridSavePlace";
            this.gridSavePlace.Visible = true;
            this.gridSavePlace.VisibleIndex = 3;
            // 
            // gridEquipmentState
            // 
            this.gridEquipmentState.Caption = "状态";
            this.gridEquipmentState.FieldName = "EquipmentStateName";
            this.gridEquipmentState.Name = "gridEquipmentState";
            this.gridEquipmentState.Visible = true;
            this.gridEquipmentState.VisibleIndex = 14;
            // 
            // frmEquipmentDieReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 613);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmEquipmentDieReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "模具一览报表";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEquipmentDie_Load);
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
        private DevExpress.XtraGrid.Columns.GridColumn gridEquipmentID;
        private DevExpress.XtraGrid.Columns.GridColumn gridEquipmentName;
        private DevExpress.XtraGrid.Columns.GridColumn gridUsePerson;
        private DevExpress.XtraGrid.Columns.GridColumn gridSavePlace;
        private DevExpress.XtraGrid.Columns.GridColumn gridEquipmentState;
    }
}