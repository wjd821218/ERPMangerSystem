namespace ErpManage
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblProductClass;

        private System.Windows.Forms.TextBox txtProductClass;

        private System.Windows.Forms.Label lblWorkEfficiency;

        private System.Windows.Forms.TextBox txtWorkEfficiency;

        private System.Windows.Forms.Label lblEquipmentStuff;

        private System.Windows.Forms.TextBox txtEquipmentStuff;

        private System.Windows.Forms.Label lblEquipmentFormal;

        private System.Windows.Forms.TextBox txtEquipmentFormal;

        private System.Windows.Forms.Label lblFrockSource;

        private System.Windows.Forms.TextBox txtFrockSource; 

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
            this.lblProductClass = new System.Windows.Forms.Label();
            this.txtProductClass = new System.Windows.Forms.TextBox();
            this.lblWorkEfficiency = new System.Windows.Forms.Label();
            this.txtWorkEfficiency = new System.Windows.Forms.TextBox();
            this.lblEquipmentStuff = new System.Windows.Forms.Label();
            this.txtEquipmentStuff = new System.Windows.Forms.TextBox();
            this.lblEquipmentFormal = new System.Windows.Forms.Label();
            this.txtEquipmentFormal = new System.Windows.Forms.TextBox();
            this.lblFrockSource = new System.Windows.Forms.Label();
            this.txtFrockSource = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblProductClass
            // 
            this.lblProductClass.AutoSize = true;
            this.lblProductClass.Location = new System.Drawing.Point(15, 39);
            this.lblProductClass.Name = "lblProductClass";
            this.lblProductClass.Size = new System.Drawing.Size(53, 12);
            this.lblProductClass.TabIndex = 5;
            this.lblProductClass.Text = "产品类别";
            // 
            // txtProductClass
            // 
            this.txtProductClass.Location = new System.Drawing.Point(90, 39);
            this.txtProductClass.Name = "txtProductClass";
            this.txtProductClass.Size = new System.Drawing.Size(150, 21);
            this.txtProductClass.TabIndex = 6;
            // 
            // lblWorkEfficiency
            // 
            this.lblWorkEfficiency.AutoSize = true;
            this.lblWorkEfficiency.Location = new System.Drawing.Point(15, 80);
            this.lblWorkEfficiency.Name = "lblWorkEfficiency";
            this.lblWorkEfficiency.Size = new System.Drawing.Size(29, 12);
            this.lblWorkEfficiency.TabIndex = 7;
            this.lblWorkEfficiency.Text = "工位";
            // 
            // txtWorkEfficiency
            // 
            this.txtWorkEfficiency.Location = new System.Drawing.Point(90, 80);
            this.txtWorkEfficiency.Name = "txtWorkEfficiency";
            this.txtWorkEfficiency.Size = new System.Drawing.Size(150, 21);
            this.txtWorkEfficiency.TabIndex = 8;
            // 
            // lblEquipmentStuff
            // 
            this.lblEquipmentStuff.AutoSize = true;
            this.lblEquipmentStuff.Location = new System.Drawing.Point(265, 80);
            this.lblEquipmentStuff.Name = "lblEquipmentStuff";
            this.lblEquipmentStuff.Size = new System.Drawing.Size(29, 12);
            this.lblEquipmentStuff.TabIndex = 9;
            this.lblEquipmentStuff.Text = "材料";
            // 
            // txtEquipmentStuff
            // 
            this.txtEquipmentStuff.Location = new System.Drawing.Point(340, 80);
            this.txtEquipmentStuff.Name = "txtEquipmentStuff";
            this.txtEquipmentStuff.Size = new System.Drawing.Size(150, 21);
            this.txtEquipmentStuff.TabIndex = 10;
            // 
            // lblEquipmentFormal
            // 
            this.lblEquipmentFormal.AutoSize = true;
            this.lblEquipmentFormal.Location = new System.Drawing.Point(500, 80);
            this.lblEquipmentFormal.Name = "lblEquipmentFormal";
            this.lblEquipmentFormal.Size = new System.Drawing.Size(53, 12);
            this.lblEquipmentFormal.TabIndex = 11;
            this.lblEquipmentFormal.Text = "外形尺寸";
            // 
            // txtEquipmentFormal
            // 
            this.txtEquipmentFormal.Location = new System.Drawing.Point(575, 80);
            this.txtEquipmentFormal.Name = "txtEquipmentFormal";
            this.txtEquipmentFormal.Size = new System.Drawing.Size(150, 21);
            this.txtEquipmentFormal.TabIndex = 12;
            // 
            // lblFrockSource
            // 
            this.lblFrockSource.AutoSize = true;
            this.lblFrockSource.Location = new System.Drawing.Point(15, 120);
            this.lblFrockSource.Name = "lblFrockSource";
            this.lblFrockSource.Size = new System.Drawing.Size(53, 12);
            this.lblFrockSource.TabIndex = 13;
            this.lblFrockSource.Text = "工装来源";
            // 
            // txtFrockSource
            // 
            this.txtFrockSource.Location = new System.Drawing.Point(90, 120);
            this.txtFrockSource.Name = "txtFrockSource";
            this.txtFrockSource.Size = new System.Drawing.Size(150, 21);
            this.txtFrockSource.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 410);
            this.Controls.Add(this.lblProductClass);
            this.Controls.Add(this.txtProductClass);
            this.Controls.Add(this.lblWorkEfficiency);
            this.Controls.Add(this.txtWorkEfficiency);
            this.Controls.Add(this.lblEquipmentStuff);
            this.Controls.Add(this.txtEquipmentStuff);
            this.Controls.Add(this.lblEquipmentFormal);
            this.Controls.Add(this.txtEquipmentFormal);
            this.Controls.Add(this.lblFrockSource);
            this.Controls.Add(this.txtFrockSource);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}