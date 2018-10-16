namespace ErpManage
{
    partial class frmEmployeeAdd
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
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtGuid = new System.Windows.Forms.TextBox();
            this.txtCardID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldept = new System.Windows.Forms.Label();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboDept = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkIsEnable = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(306, 25);
            this.txtEmpName.MaxLength = 50;
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(154, 21);
            this.txtEmpName.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "员工名称";
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(306, 58);
            this.txtSex.MaxLength = 10;
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(155, 21);
            this.txtSex.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "性别";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(92, 61);
            this.txtTelephone.MaxLength = 50;
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(154, 21);
            this.txtTelephone.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 25;
            this.label7.Text = "联系电话";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(92, 131);
            this.txtAddress.MaxLength = 90;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(370, 21);
            this.txtAddress.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 27;
            this.label4.Text = "地址";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(390, 196);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 26);
            this.btnExit.TabIndex = 37;
            this.btnExit.Text = "取消(&Q)";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(279, 197);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 26);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "确定(&S)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label15.Location = new System.Drawing.Point(-166, 177);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(923, 12);
            this.label15.TabIndex = 35;
            this.label15.Text = "_________________________________________________________________________________" +
                "________________________________________________________________________";
            // 
            // txtGuid
            // 
            this.txtGuid.Location = new System.Drawing.Point(497, 217);
            this.txtGuid.Name = "txtGuid";
            this.txtGuid.Size = new System.Drawing.Size(29, 21);
            this.txtGuid.TabIndex = 38;
            this.txtGuid.Visible = false;
            // 
            // txtCardID
            // 
            this.txtCardID.Location = new System.Drawing.Point(307, 97);
            this.txtCardID.MaxLength = 50;
            this.txtCardID.Name = "txtCardID";
            this.txtCardID.Size = new System.Drawing.Size(154, 21);
            this.txtCardID.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 39;
            this.label1.Text = "身份证号";
            // 
            // lbldept
            // 
            this.lbldept.AutoSize = true;
            this.lbldept.Location = new System.Drawing.Point(26, 101);
            this.lbldept.Name = "lbldept";
            this.lbldept.Size = new System.Drawing.Size(53, 12);
            this.lbldept.TabIndex = 41;
            this.lbldept.Text = "所在部门";
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(92, 25);
            this.txtEmpId.MaxLength = 50;
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(154, 21);
            this.txtEmpId.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 43;
            this.label5.Text = "员工编号";
            // 
            // cboDept
            // 
            this.cboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Location = new System.Drawing.Point(92, 97);
            this.cboDept.MaxLength = 50;
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(154, 20);
            this.cboDept.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 46;
            this.label6.Text = "是否可用";
            // 
            // chkIsEnable
            // 
            this.chkIsEnable.AutoSize = true;
            this.chkIsEnable.Location = new System.Drawing.Point(92, 165);
            this.chkIsEnable.Name = "chkIsEnable";
            this.chkIsEnable.Size = new System.Drawing.Size(15, 14);
            this.chkIsEnable.TabIndex = 47;
            this.chkIsEnable.UseVisualStyleBackColor = true;
            // 
            // frmEmployeeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 246);
            this.Controls.Add(this.chkIsEnable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboDept);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbldept);
            this.Controls.Add(this.txtCardID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGuid);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmployeeAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工添加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtGuid;
        private System.Windows.Forms.TextBox txtCardID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldept;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboDept;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkIsEnable;
    }
}