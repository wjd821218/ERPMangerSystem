using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ErpManage.StatReport
{
    /// <summary>
    ///成品入库单明细报表
    /// </summary>
    public partial class frmHalfGoodsDetailReport2 : frmBase
    {
        public frmHalfGoodsDetailReport2()
        {
            InitializeComponent();
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
    }
}