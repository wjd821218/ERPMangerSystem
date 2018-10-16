using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using ErpManageLibrary;

namespace ErpManage.Business
{
    /// <summary>
    /// 付款单从采购入库单中选择------已经不用 2010-8-27
    /// </summary>
    public partial class frmSelectStockInOrder2 : frmBase
    {

        PaymentOrderManage PaymentOrderManage = new PaymentOrderManage();
        public frmSelectStockInOrder2()
        {
            InitializeComponent();
        }

        private void frmSelectProduct_Load(object sender, EventArgs e)
        {
            LoadDetailData();
        }


        //载入数据
        private void LoadDetailData()
        {
            DataTable dtl = PaymentOrderManage.sp_GetSelectStockInOrder("");
            this.gridControl2.DataSource = dtl;

        }

        private void tsbExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel文件|*.XLS|所有文件|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string filename = saveFileDialog1.FileName;
                gridView2.ExportToXls(filename);

                this.ShowMessage("导出成功");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void repositoryItemCheckEdit1_QueryCheckStateByValue(object sender, DevExpress.XtraEditors.Controls.QueryCheckStateByValueEventArgs e)
        {
            string val = "";
            if (e.Value != null)
            {
                val = e.Value.ToString();
            }
            else
            {
                val = "True";//默认为选中 
            }
            switch (val)
            {
                case "True":
                    e.CheckState = CheckState.Checked;
                    break;
                case "False":
                    e.CheckState = CheckState.Unchecked;
                    break;
                case "Yes":
                    goto case "True";
                case "No":
                    goto case "False";
                case "1":
                    goto case "True";
                case "0":
                    goto case "False";
                default:
                    e.CheckState = CheckState.Checked;
                    break;
            }
            e.Handled = true; 
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            List<SelectStockInOrder> alt = new List<SelectStockInOrder>();
            if (gridView2.RowCount > 0)
            {
                SelectStockInOrder SelectStockInOrder = new SelectStockInOrder();
                //采购入库单
                for (int i = 0; i < gridView2.RowCount; i++)
                {
                    if (gridView2.GetRowCellValue(i, gridCheckBox).ToString() == "True")
                    {
                        SelectStockInOrder = new SelectStockInOrder();

                        SelectStockInOrder.StockInOrderID = gridView2.GetRowCellValue(i, gridStockInOrderID).ToString();
                        SelectStockInOrder.StockInOrderDate = DateTime.Parse(gridView2.GetRowCellValue(i, gridStockInOrderDate).ToString());
                        SelectStockInOrder.MaterialSum = decimal.Parse(gridView2.GetRowCellValue(i, gridMaterialSum).ToString());
                        SelectStockInOrder.TotalMoney = decimal.Parse(gridView2.GetRowCellValue(i, gridTotalMoney).ToString());

                        alt.Add(SelectStockInOrder);
                    }

                }

                if (alt.Count <= 0)
                {
                    //请选择记录
                    ShowMessage("请选择采购入库单数据！");
                    return;
                }

                this.Tag = alt;
                this.Close();
            }
        }
    }
}