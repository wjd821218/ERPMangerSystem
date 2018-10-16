using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace ReportDesign
{
    public partial class frmReportDesign : Form
    {
        public frmReportDesign()
        {
            InitializeComponent();
        }

        private void btnSelectOpenRepx_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Filter = "报表文件|*.Repx|所有文件|*.*";

            //选择上报文件目录
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = OpenFileDialog.FileName;
            }
        }

        private void btnOpenDesign_Click(object sender, EventArgs e)
        {
            if (txtPath.Text.Trim() == "")
            {
                MessageBox.Show("请选择报表文件!");
                return;
            }

            XtraReport report = new XtraReport();
            report.LoadLayout(txtPath.Text);
            report.CreateDocument();
            report.ShowDesigner();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}