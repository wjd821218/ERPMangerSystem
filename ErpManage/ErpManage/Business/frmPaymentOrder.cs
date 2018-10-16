using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;
using ErpManage.PrintReport;

namespace ErpManage.Business
{
    /// <summary>
    /// 付款单查看
    /// </summary>
    public partial class frmPaymentOrder :frmBase
    {
        PaymentOrderManage PaymentOrderManage = new PaymentOrderManage();
        public  static frmPaymentOrder frmpaymentorder;
        public frmPaymentOrder()
        {
            InitializeComponent();
            frmpaymentorder = this;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          


            frmPaymentOrderAdd frmPaymentOrderAdd = new frmPaymentOrderAdd();
            frmPaymentOrderAdd.AddBill();
        }


        private void frmPaymentOrder_Load(object sender, EventArgs e)
        {
            LoadData();

            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "PaymentOrderDelete", "Delete") == false)
            {
                btnDelete.Enabled = false;
            }

        }

        public void LoadData()
        {
            DataTable dtl = new DataTable();
            dtl = PaymentOrderManage.GetPaymentOrderBySQL(GetWhereSQL());

            gridControl1.DataSource = dtl;


        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[1].ToString();


                frmPaymentOrderAdd frmPaymentOrderAdd = new frmPaymentOrderAdd();
                frmPaymentOrderAdd.EditBill(guid);
            }
        }

        private void tsbedit_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmPaymentOrderAdd frmPaymentOrderAdd = new frmPaymentOrderAdd();
                frmPaymentOrderAdd.EditBill(guid);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (gridView1.RowCount > 0)
            {
                DataRowView dr = (DataRowView)(gridView1.GetFocusedRow());


                if (MessageBox.Show("确定删除该数据！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                   
                    dr = (DataRowView)(gridView1.GetFocusedRow());
                    if (PaymentOrderManage.GetIsCheck(dr["PaymentOrderGuid"].ToString()) == false)
                    {
                        PaymentOrderManage.DeleteBill(dr["PaymentOrderGuid"].ToString());

                      

                        //写日志
                        SysLog.AddOperateLog(SysParams.UserName, "付款单删除", "删除", SysParams.UserName + "用户删除了付款单,付款单唯一号:" + dr["PaymentOrderGuid"].ToString() + ",付款单单号:" + dr["PaymentOrderID"].ToString());
                        gridView1.DeleteSelectedRows();
                        this.ShowMessage("删除成功!");
                    }
                    else
                    {
                        this.ShowAlertMessage("此单据已审核，不可以删除!");
                    }
                }


            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectSupplier_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(3);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtSupplier.Text = ""; //名称
                    txtSupplier.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtSupplier.Text = arrValue[1]; //名称
                        txtSupplier.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        private void btnQty_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public string GetWhereSQL()
        {
            string strsql = "  where  1=1 ";
            if (txtPaymentOrderID.Text.Trim() != "")
            {
                strsql = strsql + " and PaymentOrderID='" + txtPaymentOrderID.Text.Replace("'", "''") + "'";
            }

            if (dtpPaymentOrderBeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and PaymentOrderDate>='" + dtpPaymentOrderBeginDate.Text.Trim() + " 00:00:00'";
            }

            if (dtpPaymentOrderEndDate.Text.Trim() != "")
            {
                strsql = strsql + " and PaymentOrderDate<='" + dtpPaymentOrderEndDate.Text.Trim() + " 23:59:59'";
            }


            if (chkCheck.Checked == true)
            {
                strsql = strsql + " and CheckGuid<>'' ";
            }

         


            return strsql;

        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            txtPaymentOrderID.Focus();
            gridView1.UpdateCurrentRow();
            txtPaymentOrderID.Focus();
            
            int rowcount = 0;
            string strGuid1="";
            string strGuid2="";
            

            if (gridView1.RowCount > 0)
            {
                //int intRow = gridView1.GetSelectedRows()[0];
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    if (gridView1.GetRowCellValue(i, gridSelect).ToString() == "True")
                    {
                        rowcount = rowcount + 1;
                    }

                }

                if (rowcount!=2)
                {
                   
                    ShowMessage("请选择两个付款单进行打印！");
                    return;
                }


                int j = 0;
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    
                    if (gridView1.GetRowCellValue(i, gridSelect).ToString() == "True")
                    {
                        if (j == 0)
                        {
                            strGuid1 = gridView1.GetRowCellValue(i, gridPaymentOrderGuid).ToString();

                            j = j + 1;
                        }
                        else
                        {
                            if (j == 1)
                            {
                                strGuid2 = gridView1.GetRowCellValue(i, gridPaymentOrderGuid).ToString();
                            }
                        }
                    }

                }

          
            }



            XtraReportPaymentOrderTwoPrint XtraReportPaymentOrderTwoPrint = new XtraReportPaymentOrderTwoPrint(strGuid1, strGuid2);
            XtraReportPaymentOrderTwoPrint.ShowPreview();
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



    }

}