namespace ReportDesign
{
    partial class frmReportDesign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportDesign));
            this.btnOpenDesign = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSelectOpenRepx = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnOpenDesign
            // 
            this.btnOpenDesign.Location = new System.Drawing.Point(138, 87);
            this.btnOpenDesign.Name = "btnOpenDesign";
            this.btnOpenDesign.Size = new System.Drawing.Size(93, 23);
            this.btnOpenDesign.TabIndex = 0;
            this.btnOpenDesign.Text = "报表设计";
            this.btnOpenDesign.UseVisualStyleBackColor = true;
            this.btnOpenDesign.Click += new System.EventHandler(this.btnOpenDesign_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择报表源文件";
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.White;
            this.txtPath.Location = new System.Drawing.Point(107, 25);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(336, 21);
            this.txtPath.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(273, 87);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSelectOpenRepx
            // 
            this.btnSelectOpenRepx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectOpenRepx.BackgroundImage")));
            this.btnSelectOpenRepx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectOpenRepx.Location = new System.Drawing.Point(443, 24);
            this.btnSelectOpenRepx.Name = "btnSelectOpenRepx";
            this.btnSelectOpenRepx.Size = new System.Drawing.Size(25, 22);
            this.btnSelectOpenRepx.TabIndex = 69;
            this.btnSelectOpenRepx.UseVisualStyleBackColor = true;
            this.btnSelectOpenRepx.Click += new System.EventHandler(this.btnSelectOpenRepx_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmReportDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 147);
            this.Controls.Add(this.btnSelectOpenRepx);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenDesign);
            this.Name = "frmReportDesign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "报表设计";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenDesign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSelectOpenRepx;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

