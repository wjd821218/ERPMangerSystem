using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ErpManage
{
    /// <summary>
    /// 文件资料申请统计报表
    /// </summary>
    public partial class frmFileApplyCountReport : frmBase
    {
        public frmFileApplyCountReport()
        {
            InitializeComponent();

            IniControl_CN();
        }

        #region 控件汉化
        /// <summary>
        /// 将控件汉化
        /// </summary>
        public void IniControl_CN()
        {
            DevExpress.XtraPrinting.Localization.PreviewLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraPrintingLocalizationCHS();


        }
        #endregion

      
        private void exit_Click(object sender, EventArgs e)
        {

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

        private void exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}