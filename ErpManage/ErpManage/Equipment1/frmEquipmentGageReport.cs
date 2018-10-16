using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;

namespace ErpManage
{
    public partial class frmEquipmentGageReport :frmBase
    {
        public frmEquipmentGageReport()
        {
            InitializeComponent();
        }

        private void frmEquipmentGageReport_Load(object sender, EventArgs e)
        {
            EquipmentManage EquipmentManage = new EquipmentManage();
            gridControl1.DataSource = EquipmentManage.GetEquipmentDataByEquipmentType("2");
        }

        private void tsbExport_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel文件|*.XLS|所有文件|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string filename = saveFileDialog1.FileName;
                gridView1.ExportToXls(filename);

                this.ShowMessage("导出成功");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}