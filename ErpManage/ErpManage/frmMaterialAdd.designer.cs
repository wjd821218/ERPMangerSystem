namespace ErpManage
{
    partial class frmMaterialAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaterialAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaterialName = new System.Windows.Forms.TextBox();
            this.txtMaterialId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSafeStockSum = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtGuid = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.btnSelectSpec = new System.Windows.Forms.Button();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.chkStop = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCalculateMethod = new System.Windows.Forms.TextBox();
            this.btnSelectCalculateMethod = new System.Windows.Forms.Button();
            this.btnSelectUnit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPicID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSelectSupplier = new System.Windows.Forms.Button();
            this.txtSupplierGuid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "物料分类";
            // 
            // txtClass
            // 
            this.txtClass.BackColor = System.Drawing.Color.White;
            this.txtClass.Location = new System.Drawing.Point(73, 31);
            this.txtClass.Name = "txtClass";
            this.txtClass.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(112, 21);
            this.txtClass.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "物料名称";
            // 
            // txtMaterialName
            // 
            this.txtMaterialName.Location = new System.Drawing.Point(472, 32);
            this.txtMaterialName.MaxLength = 100;
            this.txtMaterialName.Name = "txtMaterialName";
            this.txtMaterialName.Size = new System.Drawing.Size(129, 21);
            this.txtMaterialName.TabIndex = 3;
            // 
            // txtMaterialId
            // 
            this.txtMaterialId.Location = new System.Drawing.Point(274, 31);
            this.txtMaterialId.MaxLength = 50;
            this.txtMaterialId.Name = "txtMaterialId";
            this.txtMaterialId.Size = new System.Drawing.Size(112, 21);
            this.txtMaterialId.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "物料编号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "规格";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "单位";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "计价方法";
            this.label7.Visible = false;
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(179, 255);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(17, 21);
            this.txtPlace.TabIndex = 15;
            this.txtPlace.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(152, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "货位";
            this.label8.Visible = false;
            // 
            // txtSafeStockSum
            // 
            this.txtSafeStockSum.Location = new System.Drawing.Point(248, 255);
            this.txtSafeStockSum.Name = "txtSafeStockSum";
            this.txtSafeStockSum.Size = new System.Drawing.Size(26, 21);
            this.txtSafeStockSum.TabIndex = 23;
            this.txtSafeStockSum.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(199, 261);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 22;
            this.label13.Text = "安全库存";
            this.label13.Visible = false;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(73, 150);
            this.txtRemark.MaxLength = 150;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(313, 21);
            this.txtRemark.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 153);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 26;
            this.label14.Text = "备注";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label15.Location = new System.Drawing.Point(-4, 199);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(923, 12);
            this.label15.TabIndex = 29;
            this.label15.Text = "_________________________________________________________________________________" +
                "________________________________________________________________________";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(402, 244);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 26);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "确定(&S)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(514, 244);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 26);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "取消(&Q)";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtGuid
            // 
            this.txtGuid.Location = new System.Drawing.Point(321, 276);
            this.txtGuid.Name = "txtGuid";
            this.txtGuid.Size = new System.Drawing.Size(271, 21);
            this.txtGuid.TabIndex = 32;
            this.txtGuid.Visible = false;
            // 
            // btnSelect
            // 
            this.btnSelect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelect.BackgroundImage")));
            this.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelect.Location = new System.Drawing.Point(186, 30);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(25, 22);
            this.btnSelect.TabIndex = 33;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtSpec
            // 
            this.txtSpec.BackColor = System.Drawing.Color.White;
            this.txtSpec.Location = new System.Drawing.Point(73, 69);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.ReadOnly = true;
            this.txtSpec.Size = new System.Drawing.Size(112, 21);
            this.txtSpec.TabIndex = 34;
            // 
            // btnSelectSpec
            // 
            this.btnSelectSpec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectSpec.BackgroundImage")));
            this.btnSelectSpec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectSpec.Location = new System.Drawing.Point(185, 68);
            this.btnSelectSpec.Name = "btnSelectSpec";
            this.btnSelectSpec.Size = new System.Drawing.Size(25, 22);
            this.btnSelectSpec.TabIndex = 35;
            this.btnSelectSpec.UseVisualStyleBackColor = true;
            this.btnSelectSpec.Click += new System.EventHandler(this.btnSelectSpec_Click);
            // 
            // txtUnit
            // 
            this.txtUnit.BackColor = System.Drawing.Color.White;
            this.txtUnit.Location = new System.Drawing.Point(274, 70);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(112, 21);
            this.txtUnit.TabIndex = 36;
            // 
            // chkStop
            // 
            this.chkStop.AutoSize = true;
            this.chkStop.Location = new System.Drawing.Point(472, 153);
            this.chkStop.Name = "chkStop";
            this.chkStop.Size = new System.Drawing.Size(15, 14);
            this.chkStop.TabIndex = 37;
            this.chkStop.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 38;
            this.label6.Text = "是否停用";
            // 
            // txtCalculateMethod
            // 
            this.txtCalculateMethod.BackColor = System.Drawing.Color.White;
            this.txtCalculateMethod.Location = new System.Drawing.Point(90, 255);
            this.txtCalculateMethod.Name = "txtCalculateMethod";
            this.txtCalculateMethod.ReadOnly = true;
            this.txtCalculateMethod.Size = new System.Drawing.Size(27, 21);
            this.txtCalculateMethod.TabIndex = 39;
            this.txtCalculateMethod.Visible = false;
            // 
            // btnSelectCalculateMethod
            // 
            this.btnSelectCalculateMethod.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectCalculateMethod.BackgroundImage")));
            this.btnSelectCalculateMethod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectCalculateMethod.Location = new System.Drawing.Point(116, 253);
            this.btnSelectCalculateMethod.Name = "btnSelectCalculateMethod";
            this.btnSelectCalculateMethod.Size = new System.Drawing.Size(25, 22);
            this.btnSelectCalculateMethod.TabIndex = 40;
            this.btnSelectCalculateMethod.UseVisualStyleBackColor = true;
            this.btnSelectCalculateMethod.Visible = false;
            this.btnSelectCalculateMethod.Click += new System.EventHandler(this.btnSelectCalculateMethod_Click);
            // 
            // btnSelectUnit
            // 
            this.btnSelectUnit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectUnit.BackgroundImage")));
            this.btnSelectUnit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectUnit.Location = new System.Drawing.Point(384, 69);
            this.btnSelectUnit.Name = "btnSelectUnit";
            this.btnSelectUnit.Size = new System.Drawing.Size(25, 22);
            this.btnSelectUnit.TabIndex = 42;
            this.btnSelectUnit.UseVisualStyleBackColor = true;
            this.btnSelectUnit.Click += new System.EventHandler(this.btnSelectUnit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(287, 244);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 26);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "新增(&S)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(472, 71);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(129, 21);
            this.txtPrice.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(430, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 44;
            this.label9.Text = "单价";
            // 
            // txtPicID
            // 
            this.txtPicID.Location = new System.Drawing.Point(72, 108);
            this.txtPicID.MaxLength = 100;
            this.txtPicID.Name = "txtPicID";
            this.txtPicID.Size = new System.Drawing.Size(113, 21);
            this.txtPicID.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 46;
            this.label10.Text = "图号";
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(274, 108);
            this.txtClientID.MaxLength = 100;
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(112, 21);
            this.txtClientID.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(215, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 48;
            this.label11.Text = "客户编号";
            // 
            // btnSelectSupplier
            // 
            this.btnSelectSupplier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectSupplier.BackgroundImage")));
            this.btnSelectSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectSupplier.Location = new System.Drawing.Point(601, 106);
            this.btnSelectSupplier.Name = "btnSelectSupplier";
            this.btnSelectSupplier.Size = new System.Drawing.Size(25, 22);
            this.btnSelectSupplier.TabIndex = 52;
            this.btnSelectSupplier.UseVisualStyleBackColor = true;
            this.btnSelectSupplier.Click += new System.EventHandler(this.btnSelectSupplier_Click);
            // 
            // txtSupplierGuid
            // 
            this.txtSupplierGuid.BackColor = System.Drawing.Color.White;
            this.txtSupplierGuid.Location = new System.Drawing.Point(472, 108);
            this.txtSupplierGuid.Name = "txtSupplierGuid";
            this.txtSupplierGuid.ReadOnly = true;
            this.txtSupplierGuid.Size = new System.Drawing.Size(129, 21);
            this.txtSupplierGuid.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(423, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 50;
            this.label12.Text = "供应商";
            // 
            // frmMaterialAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 297);
            this.Controls.Add(this.btnSelectSupplier);
            this.Controls.Add(this.txtSupplierGuid);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPicID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSelectUnit);
            this.Controls.Add(this.btnSelectCalculateMethod);
            this.Controls.Add(this.txtCalculateMethod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkStop);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.btnSelectSpec);
            this.Controls.Add(this.txtSpec);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtGuid);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtSafeStockSum);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaterialId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaterialName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMaterialAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物料添加";
            this.Load += new System.EventHandler(this.frmMaterialAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaterialName;
        private System.Windows.Forms.TextBox txtMaterialId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSafeStockSum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtGuid;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtSpec;
        private System.Windows.Forms.Button btnSelectSpec;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.CheckBox chkStop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCalculateMethod;
        private System.Windows.Forms.Button btnSelectCalculateMethod;
        private System.Windows.Forms.Button btnSelectUnit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPicID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSelectSupplier;
        private System.Windows.Forms.TextBox txtSupplierGuid;
        private System.Windows.Forms.Label label12;
    }
}