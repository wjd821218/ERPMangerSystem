namespace ErpManage
{
    partial class frmBOM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBOM));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridMaterialGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridMaterialGuidDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialIDDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialNameDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUnitDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSpecDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaterialSumDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChildMaterialID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFatherMaterialID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "CONTACTL.ICO");
            this.imageList1.Images.SetKeyName(1, "ACTIVITL.ICO");
            this.imageList1.Images.SetKeyName(2, "DOCL.ICO");
            this.imageList1.Images.SetKeyName(3, "DOCS.ICO");
            this.imageList1.Images.SetKeyName(4, "RESENDL.ICO");
            this.imageList1.Images.SetKeyName(5, "TASKL.ICO");
            this.imageList1.Images.SetKeyName(6, "delete.png");
            this.imageList1.Images.SetKeyName(7, "page_edit.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnDelete,
            this.exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(843, 25);
            this.toolStrip1.TabIndex = 47;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(49, 22);
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(49, 22);
            this.btnEdit.Text = "修改";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            // exit
            // 
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(49, 22);
            this.exit.Text = "退出";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "lj.ico");
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl1.Location = new System.Drawing.Point(0, 71);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(387, 571);
            this.gridControl1.TabIndex = 55;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridMaterialGuid,
            this.gridMaterialID,
            this.gridMaterialName,
            this.gridUnit,
            this.gridSpec});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridMaterialGuid
            // 
            this.gridMaterialGuid.Caption = "gridColumn1";
            this.gridMaterialGuid.FieldName = "MaterialGuid";
            this.gridMaterialGuid.Name = "gridMaterialGuid";
            // 
            // gridMaterialID
            // 
            this.gridMaterialID.Caption = "物料号";
            this.gridMaterialID.FieldName = "MaterialID";
            this.gridMaterialID.MinWidth = 100;
            this.gridMaterialID.Name = "gridMaterialID";
            this.gridMaterialID.Visible = true;
            this.gridMaterialID.VisibleIndex = 0;
            this.gridMaterialID.Width = 121;
            // 
            // gridMaterialName
            // 
            this.gridMaterialName.Caption = "物料名称";
            this.gridMaterialName.FieldName = "MaterialName";
            this.gridMaterialName.MinWidth = 100;
            this.gridMaterialName.Name = "gridMaterialName";
            this.gridMaterialName.Visible = true;
            this.gridMaterialName.VisibleIndex = 1;
            this.gridMaterialName.Width = 119;
            // 
            // gridUnit
            // 
            this.gridUnit.Caption = "单位";
            this.gridUnit.FieldName = "Unit";
            this.gridUnit.Name = "gridUnit";
            this.gridUnit.Visible = true;
            this.gridUnit.VisibleIndex = 2;
            this.gridUnit.Width = 62;
            // 
            // gridSpec
            // 
            this.gridSpec.Caption = "规格";
            this.gridSpec.FieldName = "Spec";
            this.gridSpec.Name = "gridSpec";
            this.gridSpec.Visible = true;
            this.gridSpec.VisibleIndex = 3;
            this.gridSpec.Width = 64;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(387, 71);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(456, 571);
            this.gridControl2.TabIndex = 56;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridMaterialGuidDetail,
            this.gridMaterialIDDetail,
            this.gridMaterialNameDetail,
            this.gridUnitDetail,
            this.gridSpecDetail,
            this.gridMaterialSumDetail});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridMaterialGuidDetail
            // 
            this.gridMaterialGuidDetail.Caption = "MaterialGuid";
            this.gridMaterialGuidDetail.FieldName = "MaterialGuid";
            this.gridMaterialGuidDetail.Name = "gridMaterialGuidDetail";
            // 
            // gridMaterialIDDetail
            // 
            this.gridMaterialIDDetail.Caption = "物料号";
            this.gridMaterialIDDetail.FieldName = "MaterialID";
            this.gridMaterialIDDetail.MinWidth = 100;
            this.gridMaterialIDDetail.Name = "gridMaterialIDDetail";
            this.gridMaterialIDDetail.Visible = true;
            this.gridMaterialIDDetail.VisibleIndex = 0;
            this.gridMaterialIDDetail.Width = 100;
            // 
            // gridMaterialNameDetail
            // 
            this.gridMaterialNameDetail.Caption = "物料名称";
            this.gridMaterialNameDetail.FieldName = "MaterialName";
            this.gridMaterialNameDetail.MinWidth = 100;
            this.gridMaterialNameDetail.Name = "gridMaterialNameDetail";
            this.gridMaterialNameDetail.Visible = true;
            this.gridMaterialNameDetail.VisibleIndex = 1;
            this.gridMaterialNameDetail.Width = 100;
            // 
            // gridUnitDetail
            // 
            this.gridUnitDetail.Caption = "单位";
            this.gridUnitDetail.FieldName = "Unit";
            this.gridUnitDetail.Name = "gridUnitDetail";
            this.gridUnitDetail.Visible = true;
            this.gridUnitDetail.VisibleIndex = 2;
            // 
            // gridSpecDetail
            // 
            this.gridSpecDetail.Caption = "规格";
            this.gridSpecDetail.FieldName = "Spec";
            this.gridSpecDetail.Name = "gridSpecDetail";
            this.gridSpecDetail.Visible = true;
            this.gridSpecDetail.VisibleIndex = 3;
            // 
            // gridMaterialSumDetail
            // 
            this.gridMaterialSumDetail.Caption = "数量";
            this.gridMaterialSumDetail.FieldName = "MaterialSum";
            this.gridMaterialSumDetail.Name = "gridMaterialSumDetail";
            this.gridMaterialSumDetail.Visible = true;
            this.gridMaterialSumDetail.VisibleIndex = 4;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(658, -57);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 57;
            this.treeView1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtChildMaterialID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtFatherMaterialID);
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 46);
            this.panel1.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(654, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 61;
            this.label4.Text = "物料编号定位";
            // 
            // txtChildMaterialID
            // 
            this.txtChildMaterialID.Location = new System.Drawing.Point(737, 19);
            this.txtChildMaterialID.Name = "txtChildMaterialID";
            this.txtChildMaterialID.Size = new System.Drawing.Size(103, 21);
            this.txtChildMaterialID.TabIndex = 60;
            this.txtChildMaterialID.TextChanged += new System.EventHandler(this.txtChildMaterialID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 59;
            this.label3.Text = "物料编号定位";
            // 
            // txtFatherMaterialID
            // 
            this.txtFatherMaterialID.Location = new System.Drawing.Point(273, 22);
            this.txtFatherMaterialID.Name = "txtFatherMaterialID";
            this.txtFatherMaterialID.Size = new System.Drawing.Size(114, 21);
            this.txtFatherMaterialID.TabIndex = 58;
            this.txtFatherMaterialID.TextChanged += new System.EventHandler(this.txtFatherMaterialID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "物料子件列表";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "物料(母件)列表";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmBOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 642);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmBOM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物料清单BOM维护";
            this.Load += new System.EventHandler(this.frmStorageClass_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton exit;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialGuid;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialID;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialName;
        private DevExpress.XtraGrid.Columns.GridColumn gridUnit;
        private DevExpress.XtraGrid.Columns.GridColumn gridSpec;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialGuidDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialIDDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialNameDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridUnitDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridSpecDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaterialSumDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFatherMaterialID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChildMaterialID;
    }
}