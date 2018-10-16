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
            OpenFileDialog.Filter = "�����ļ�|*.Repx|�����ļ�|*.*";

            //ѡ���ϱ��ļ�Ŀ¼
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = OpenFileDialog.FileName;
            }
        }

        private void btnOpenDesign_Click(object sender, EventArgs e)
        {
            if (txtPath.Text.Trim() == "")
            {
                MessageBox.Show("��ѡ�񱨱��ļ�!");
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