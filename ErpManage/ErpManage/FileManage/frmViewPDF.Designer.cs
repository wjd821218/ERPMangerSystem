namespace ErpManage
{
    partial class frmViewPDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewPDF));
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rdo200 = new System.Windows.Forms.RadioButton();
            this.rdo150 = new System.Windows.Forms.RadioButton();
            this.rdo100 = new System.Windows.Forms.RadioButton();
            this.rdo75 = new System.Windows.Forms.RadioButton();
            this.rdo50 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(0, 48);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(889, 564);
            this.axAcroPDF1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSet);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.txtFilePath);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.rdo200);
            this.panel1.Controls.Add(this.rdo150);
            this.panel1.Controls.Add(this.rdo100);
            this.panel1.Controls.Add(this.rdo75);
            this.panel1.Controls.Add(this.rdo50);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 48);
            this.panel1.TabIndex = 1;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(470, 16);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(13, 21);
            this.txtFilePath.TabIndex = 7;
            this.txtFilePath.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(500, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdo200
            // 
            this.rdo200.AutoSize = true;
            this.rdo200.Location = new System.Drawing.Point(247, 16);
            this.rdo200.Name = "rdo200";
            this.rdo200.Size = new System.Drawing.Size(47, 16);
            this.rdo200.TabIndex = 5;
            this.rdo200.Text = "200%";
            this.rdo200.UseVisualStyleBackColor = true;
            this.rdo200.Click += new System.EventHandler(this.rdo200_Click);
            // 
            // rdo150
            // 
            this.rdo150.AutoSize = true;
            this.rdo150.Location = new System.Drawing.Point(197, 16);
            this.rdo150.Name = "rdo150";
            this.rdo150.Size = new System.Drawing.Size(47, 16);
            this.rdo150.TabIndex = 4;
            this.rdo150.Text = "150%";
            this.rdo150.UseVisualStyleBackColor = true;
            this.rdo150.Click += new System.EventHandler(this.rdo150_Click);
            // 
            // rdo100
            // 
            this.rdo100.AutoSize = true;
            this.rdo100.Checked = true;
            this.rdo100.Location = new System.Drawing.Point(143, 16);
            this.rdo100.Name = "rdo100";
            this.rdo100.Size = new System.Drawing.Size(47, 16);
            this.rdo100.TabIndex = 3;
            this.rdo100.TabStop = true;
            this.rdo100.Text = "100%";
            this.rdo100.UseVisualStyleBackColor = true;
            this.rdo100.Click += new System.EventHandler(this.rdo100_Click);
            // 
            // rdo75
            // 
            this.rdo75.AutoSize = true;
            this.rdo75.Location = new System.Drawing.Point(94, 16);
            this.rdo75.Name = "rdo75";
            this.rdo75.Size = new System.Drawing.Size(41, 16);
            this.rdo75.TabIndex = 2;
            this.rdo75.Text = "75%";
            this.rdo75.UseVisualStyleBackColor = true;
            this.rdo75.Click += new System.EventHandler(this.rdo75_Click);
            // 
            // rdo50
            // 
            this.rdo50.AutoSize = true;
            this.rdo50.Location = new System.Drawing.Point(47, 16);
            this.rdo50.Name = "rdo50";
            this.rdo50.Size = new System.Drawing.Size(41, 16);
            this.rdo50.TabIndex = 1;
            this.rdo50.Text = "50%";
            this.rdo50.UseVisualStyleBackColor = true;
            this.rdo50.CheckedChanged += new System.EventHandler(this.rdo50_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "缩放";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(352, 14);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 21);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "缩放";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(415, 13);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(45, 23);
            this.btnSet.TabIndex = 10;
            this.btnSet.Text = "设置";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // frmViewPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 612);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.panel1);
            this.Name = "frmViewPDF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "显示PDF文件";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmViewPDF_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdo200;
        private System.Windows.Forms.RadioButton rdo150;
        private System.Windows.Forms.RadioButton rdo100;
        private System.Windows.Forms.RadioButton rdo75;
        private System.Windows.Forms.RadioButton rdo50;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnSet;
    }
}