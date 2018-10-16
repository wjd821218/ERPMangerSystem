namespace ErpManage
{
    partial class frmClientOrderAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientOrderAdd));
            this.txtEmp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.btnSelectEmp = new System.Windows.Forms.Button();
            this.btnSelectDept = new System.Windows.Forms.Button();
            this.btnSelectClient = new System.Windows.Forms.Button();
            this.btnSelectSupplier = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmp
            // 
            this.txtEmp.Location = new System.Drawing.Point(98, 60);
            this.txtEmp.Name = "txtEmp";
            this.txtEmp.Size = new System.Drawing.Size(192, 21);
            this.txtEmp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "采购员";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "部门";
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(98, 102);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(192, 21);
            this.txtDept.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "客户";
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(98, 143);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(192, 21);
            this.txtClient.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "供应商";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(98, 182);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(192, 21);
            this.txtSupplier.TabIndex = 6;
            // 
            // btnSelectEmp
            // 
            this.btnSelectEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectEmp.BackgroundImage")));
            this.btnSelectEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectEmp.Location = new System.Drawing.Point(290, 60);
            this.btnSelectEmp.Name = "btnSelectEmp";
            this.btnSelectEmp.Size = new System.Drawing.Size(25, 22);
            this.btnSelectEmp.TabIndex = 34;
            this.btnSelectEmp.UseVisualStyleBackColor = true;
            this.btnSelectEmp.Click += new System.EventHandler(this.btnSelectEmp_Click);
            // 
            // btnSelectDept
            // 
            this.btnSelectDept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectDept.BackgroundImage")));
            this.btnSelectDept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectDept.Location = new System.Drawing.Point(290, 101);
            this.btnSelectDept.Name = "btnSelectDept";
            this.btnSelectDept.Size = new System.Drawing.Size(25, 22);
            this.btnSelectDept.TabIndex = 35;
            this.btnSelectDept.UseVisualStyleBackColor = true;
            this.btnSelectDept.Click += new System.EventHandler(this.btnSelectDept_Click);
            // 
            // btnSelectClient
            // 
            this.btnSelectClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectClient.BackgroundImage")));
            this.btnSelectClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectClient.Location = new System.Drawing.Point(290, 143);
            this.btnSelectClient.Name = "btnSelectClient";
            this.btnSelectClient.Size = new System.Drawing.Size(25, 22);
            this.btnSelectClient.TabIndex = 36;
            this.btnSelectClient.UseVisualStyleBackColor = true;
            this.btnSelectClient.Click += new System.EventHandler(this.btnSelectClient_Click);
            // 
            // btnSelectSupplier
            // 
            this.btnSelectSupplier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectSupplier.BackgroundImage")));
            this.btnSelectSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectSupplier.Location = new System.Drawing.Point(290, 180);
            this.btnSelectSupplier.Name = "btnSelectSupplier";
            this.btnSelectSupplier.Size = new System.Drawing.Size(25, 22);
            this.btnSelectSupplier.TabIndex = 37;
            this.btnSelectSupplier.UseVisualStyleBackColor = true;
            this.btnSelectSupplier.Click += new System.EventHandler(this.btnSelectSupplier_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmClientOrderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSelectSupplier);
            this.Controls.Add(this.btnSelectClient);
            this.Controls.Add(this.btnSelectDept);
            this.Controls.Add(this.btnSelectEmp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmp);
            this.Name = "frmClientOrderAdd";
            this.Text = "客户订单";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Button btnSelectEmp;
        private System.Windows.Forms.Button btnSelectDept;
        private System.Windows.Forms.Button btnSelectClient;
        private System.Windows.Forms.Button btnSelectSupplier;
        private System.Windows.Forms.Button button1;
    }
}