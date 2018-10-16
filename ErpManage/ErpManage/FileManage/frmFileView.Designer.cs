namespace ErpManage
{
    partial class frmFileView
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFileView));
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridFileSourceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridFileDataAttachmentGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtControlType = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSelectFileControlType = new System.Windows.Forms.Button();
            this.txtVersionID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnQry = new System.Windows.Forms.Button();
            this.dePublishEndDate = new DevExpress.XtraEditors.DateEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.dePublishBeginDate = new DevExpress.XtraEditors.DateEdit();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFileID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dePublishEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePublishEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePublishBeginDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePublishBeginDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl2.Location = new System.Drawing.Point(170, 435);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1,
            this.repositoryItemButtonEdit1,
            this.repositoryItemButtonEdit2});
            this.gridControl2.Size = new System.Drawing.Size(866, 182);
            this.gridControl2.TabIndex = 60;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridFileSourceName,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridFileDataAttachmentGuid,
            this.gridColumn1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridFileSourceName
            // 
            this.gridFileSourceName.Caption = "文件名称";
            this.gridFileSourceName.FieldName = "FileSourceName";
            this.gridFileSourceName.Name = "gridFileSourceName";
            this.gridFileSourceName.Visible = true;
            this.gridFileSourceName.VisibleIndex = 0;
            this.gridFileSourceName.Width = 171;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "查看";
            this.gridColumn2.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 59;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            serializableAppearanceObject1.Options.UseTextOptions = true;
            serializableAppearanceObject1.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "查看", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1)});
            this.repositoryItemButtonEdit1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.Click += new System.EventHandler(this.repositoryItemButtonEdit1_Click);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "下载";
            this.gridColumn3.ColumnEdit = this.repositoryItemButtonEdit2;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 68;
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.Appearance.Options.UseTextOptions = true;
            this.repositoryItemButtonEdit2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.repositoryItemButtonEdit2.AutoHeight = false;
            this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "下载", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null)});
            this.repositoryItemButtonEdit2.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            this.repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit2.Click += new System.EventHandler(this.repositoryItemButtonEdit2_Click);
            // 
            // gridColumn4
            // 
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn4.OptionsColumn.ShowCaption = false;
            this.gridColumn4.OptionsColumn.ShowInCustomizationForm = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 517;
            // 
            // gridFileDataAttachmentGuid
            // 
            this.gridFileDataAttachmentGuid.Caption = "FileDataAttachmentGuid";
            this.gridFileDataAttachmentGuid.FieldName = "FileDataAttachmentGuid";
            this.gridFileDataAttachmentGuid.Name = "gridFileDataAttachmentGuid";
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 61;
            this.label1.Text = "文件附件列表";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(170, 403);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 32);
            this.panel2.TabIndex = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFilePath);
            this.groupBox1.Controls.Add(this.txtControlType);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnSelectFileControlType);
            this.groupBox1.Controls.Add(this.txtVersionID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnQry);
            this.groupBox1.Controls.Add(this.dePublishEndDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dePublishBeginDate);
            this.groupBox1.Controls.Add(this.txtFileName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFileID);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1036, 100);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(1007, 79);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(23, 21);
            this.txtFilePath.TabIndex = 85;
            this.txtFilePath.Visible = false;
            // 
            // txtControlType
            // 
            this.txtControlType.BackColor = System.Drawing.Color.White;
            this.txtControlType.Location = new System.Drawing.Point(489, 20);
            this.txtControlType.Name = "txtControlType";
            this.txtControlType.ReadOnly = true;
            this.txtControlType.Size = new System.Drawing.Size(112, 21);
            this.txtControlType.TabIndex = 97;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(433, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 99;
            this.label10.Text = "受控类别";
            // 
            // btnSelectFileControlType
            // 
            this.btnSelectFileControlType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectFileControlType.BackgroundImage")));
            this.btnSelectFileControlType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectFileControlType.Location = new System.Drawing.Point(600, 19);
            this.btnSelectFileControlType.Name = "btnSelectFileControlType";
            this.btnSelectFileControlType.Size = new System.Drawing.Size(25, 22);
            this.btnSelectFileControlType.TabIndex = 98;
            this.btnSelectFileControlType.UseVisualStyleBackColor = true;
            this.btnSelectFileControlType.Click += new System.EventHandler(this.btnSelectFileControlType_Click);
            // 
            // txtVersionID
            // 
            this.txtVersionID.BackColor = System.Drawing.Color.White;
            this.txtVersionID.Location = new System.Drawing.Point(694, 21);
            this.txtVersionID.Name = "txtVersionID";
            this.txtVersionID.Size = new System.Drawing.Size(112, 21);
            this.txtVersionID.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(659, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 96;
            this.label2.Text = "版本";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(949, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 93;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.btnQry.Location = new System.Drawing.Point(856, 28);
            this.btnQry.Name = "btnQry";
            this.btnQry.Size = new System.Drawing.Size(75, 30);
            this.btnQry.TabIndex = 92;
            this.btnQry.Text = "查询";
            this.btnQry.UseVisualStyleBackColor = true;
            this.btnQry.Click += new System.EventHandler(this.btnQry_Click);
            // 
            // dePublishEndDate
            // 
            this.dePublishEndDate.EditValue = null;
            this.dePublishEndDate.Location = new System.Drawing.Point(489, 55);
            this.dePublishEndDate.Name = "dePublishEndDate";
            this.dePublishEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dePublishEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dePublishEndDate.Size = new System.Drawing.Size(115, 21);
            this.dePublishEndDate.TabIndex = 91;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 80;
            this.label4.Text = "文件名称";
            // 
            // dePublishBeginDate
            // 
            this.dePublishBeginDate.EditValue = null;
            this.dePublishBeginDate.Location = new System.Drawing.Point(302, 57);
            this.dePublishBeginDate.Name = "dePublishBeginDate";
            this.dePublishBeginDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dePublishBeginDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dePublishBeginDate.Size = new System.Drawing.Size(115, 21);
            this.dePublishBeginDate.TabIndex = 90;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(302, 20);
            this.txtFileName.MaxLength = 100;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(115, 21);
            this.txtFileName.TabIndex = 81;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 82;
            this.label3.Text = "文件编号";
            // 
            // txtFileID
            // 
            this.txtFileID.Location = new System.Drawing.Point(104, 19);
            this.txtFileID.MaxLength = 50;
            this.txtFileID.Name = "txtFileID";
            this.txtFileID.Size = new System.Drawing.Size(112, 21);
            this.txtFileID.TabIndex = 83;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(104, 57);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(112, 21);
            this.txtProductName.TabIndex = 86;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 85;
            this.label9.Text = "产品名称";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(170, 100);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(866, 303);
            this.gridControl1.TabIndex = 83;
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
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
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
            this.gridFileID.FieldName = "文件编号";
            this.gridFileID.Name = "gridFileID";
            this.gridFileID.OptionsColumn.AllowEdit = false;
            this.gridFileID.Visible = true;
            this.gridFileID.VisibleIndex = 0;
            this.gridFileID.Width = 74;
            // 
            // gridFileName
            // 
            this.gridFileName.Caption = "文件名称";
            this.gridFileName.FieldName = "文件名称";
            this.gridFileName.Name = "gridFileName";
            this.gridFileName.OptionsColumn.AllowEdit = false;
            this.gridFileName.Visible = true;
            this.gridFileName.VisibleIndex = 1;
            this.gridFileName.Width = 78;
            // 
            // gridFileType
            // 
            this.gridFileType.Caption = "文件类别";
            this.gridFileType.FieldName = "文件类别";
            this.gridFileType.Name = "gridFileType";
            this.gridFileType.OptionsColumn.AllowEdit = false;
            this.gridFileType.Visible = true;
            this.gridFileType.VisibleIndex = 2;
            this.gridFileType.Width = 60;
            // 
            // gridProductName
            // 
            this.gridProductName.Caption = "产品名称";
            this.gridProductName.FieldName = "产品名称";
            this.gridProductName.Name = "gridProductName";
            this.gridProductName.Visible = true;
            this.gridProductName.VisibleIndex = 5;
            this.gridProductName.Width = 48;
            // 
            // gridPublishDate
            // 
            this.gridPublishDate.Caption = "发布日期";
            this.gridPublishDate.FieldName = "发布日期";
            this.gridPublishDate.Name = "gridPublishDate";
            this.gridPublishDate.OptionsColumn.AllowEdit = false;
            this.gridPublishDate.Visible = true;
            this.gridPublishDate.VisibleIndex = 3;
            this.gridPublishDate.Width = 57;
            // 
            // gridVersionID
            // 
            this.gridVersionID.Caption = "版本";
            this.gridVersionID.FieldName = "版本号";
            this.gridVersionID.Name = "gridVersionID";
            this.gridVersionID.OptionsColumn.AllowEdit = false;
            this.gridVersionID.Visible = true;
            this.gridVersionID.VisibleIndex = 4;
            this.gridVersionID.Width = 33;
            // 
            // gridControlType
            // 
            this.gridControlType.Caption = "受控类别";
            this.gridControlType.FieldName = "受控类别";
            this.gridControlType.Name = "gridControlType";
            this.gridControlType.Visible = true;
            this.gridControlType.VisibleIndex = 6;
            this.gridControlType.Width = 48;
            // 
            // gridWriteDept
            // 
            this.gridWriteDept.Caption = "编写部门";
            this.gridWriteDept.FieldName = "编写部门";
            this.gridWriteDept.Name = "gridWriteDept";
            this.gridWriteDept.Visible = true;
            this.gridWriteDept.VisibleIndex = 7;
            this.gridWriteDept.Width = 48;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(0, 100);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(170, 517);
            this.treeView1.TabIndex = 84;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "star.png");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "star.png");
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            // 
            // frmFileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 617);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmFileView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件查看";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFileView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dePublishEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePublishEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePublishBeginDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePublishBeginDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnQry;
        private DevExpress.XtraEditors.DateEdit dePublishEndDate;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.DateEdit dePublishBeginDate;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFileID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraGrid.Columns.GridColumn gridFileSourceName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridFileGuID;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridFileID;
        private DevExpress.XtraGrid.Columns.GridColumn gridFileName;
        private DevExpress.XtraGrid.Columns.GridColumn gridFileType;
        private DevExpress.XtraGrid.Columns.GridColumn gridProductName;
        private DevExpress.XtraGrid.Columns.GridColumn gridPublishDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridVersionID;
        private DevExpress.XtraGrid.Columns.GridColumn gridControlType;
        private DevExpress.XtraGrid.Columns.GridColumn gridWriteDept;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridFileDataAttachmentGuid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtControlType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSelectFileControlType;
        private System.Windows.Forms.TextBox txtVersionID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.TextBox txtFilePath;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}