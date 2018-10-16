using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;

namespace ErpManage.Business
{
    /// <summary>
    /// �ɹ������鿴
    /// </summary>
    public partial class frmStockOrder : frmBase
    {
        public static frmStockOrder frmstockorder;
        StockOrderManage StockOrderManage = new StockOrderManage();
        public frmStockOrder()
        {
            frmstockorder = this;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            frmStockOrderAdd frmStockOrderAdd = new frmStockOrderAdd();
            frmStockOrderAdd.AddBill();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStockOrder_Load(object sender, EventArgs e)
        {
            LoadData();

            //Ȩ���ж�
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "StockOrderDelete", "Delete") == false)
            {
                btnDelete.Enabled = false;
            }

        }

        public void LoadData()
        {
            DataTable dtl = new DataTable();
            dtl = StockOrderManage.GetStockOrderBySQL_CN(GetWhereSQL());

            gridControl1.DataSource = dtl;

        
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmStockOrderAdd frmStockOrderAdd = new frmStockOrderAdd();
                frmStockOrderAdd.EditBill(guid);
            }
        }

        private void tsbedit_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmStockOrderAdd frmStockOrderAdd = new frmStockOrderAdd();
                frmStockOrderAdd.EditBill(guid);
            }
        }

        //--------------------------------------

        //�жϽ�ɾ���ĵ����Ƿ����б�ĵ�������
        public List<YJOrderDelete> IsYJOrderDelete(string StockOrderGuID)
        {
            List<YJOrderDelete> lst = new List<YJOrderDelete>();
            YJOrderDelete YJOrderDelete = new YJOrderDelete();


            StockOrderManage StockOrderManage = new StockOrderManage();
            DataTable dtl = StockOrderManage.GetStockOrderIDAndPaymentOrderID(StockOrderGuID);

            for (int i = 0; i < dtl.Rows.Count; i++)
            {
                string strOrderID = dtl.Rows[i]["StockInOrderID"].ToString();
                YJOrderDelete = new YJOrderDelete();
                YJOrderDelete.OrderID = strOrderID;
                YJOrderDelete.OrderName = "�ɹ���ⵥ";
                lst.Add(YJOrderDelete);
            }
            return lst;
        }

        //--------------------------------------------------



        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (gridView1.RowCount > 0)
            {
                DataRowView dr = (DataRowView)(gridView1.GetFocusedRow());


                if (MessageBox.Show("ȷ��ɾ�������ݣ�", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                  
                    if (StockOrderManage.GetIsCheck(dr["StockOrderGuid"].ToString()) == false)
                    {
                        //-----------------------------------------------------
                        MaterialManage MaterialManage = new MaterialManage();
                        if (MaterialManage.OrderDeleteAlert() == true)
                        {
                            //���س������õĵ���
                            List<YJOrderDelete> lst = IsYJOrderDelete(dr["StockOrderGuid"].ToString());
                            if (lst.Count > 0)
                            {
                                frmShowYJOrderDelete frmShowYJOrderDelete = new frmShowYJOrderDelete();
                                frmShowYJOrderDelete.ShowFillData(lst);
                                return;
                            }
                        }
                        //---------------------------------------------------------


                        StockOrderManage.DeleteBill(dr["StockOrderGuid"].ToString());


                        //д��־
                        SysLog.AddOperateLog(SysParams.UserName, "�ɹ�����ɾ��", "ɾ��", SysParams.UserName + "�û�ɾ���˲ɹ�����,����Ψһ��:" + dr["StockOrderGuid"].ToString());

                        gridView1.DeleteSelectedRows();

                        this.ShowMessage("ɾ���ɹ�!");
                    }
                    else
                    {
                        this.ShowMessage("�˵����Ѿ���˻�ᵥ,����ɾ��!");
                    }


                }
            }
           
            
        }

        public string GetWhereSQL()
        {
            string strsql = "  where  1=1 ";
            if (txtStockOrderID.Text.Trim() != "")
            {
                strsql = strsql + " and StockOrderID='" + txtStockOrderID.Text.Replace("'", "''") + "'";
            }

            if (StockOrderBeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and StockOrderDate>='" + StockOrderBeginDate.Text.Trim() + " 00:00:00'";
            }

            if (StockOrderEndDate.Text.Trim() != "")
            {
                strsql = strsql + " and StockOrderDate<='" + StockOrderEndDate.Text.Trim() + " 23:59:59'";
            }

            if (txtSupplier.Tag != null)
            {
                if (txtSupplier.Tag.ToString() != "")
                {
                    strsql = strsql + " and SupplierGuid='" + txtSupplier.Tag.ToString() + "'";
                }
            }

            if (chkCheck.Checked == true)
            {
                strsql = strsql + " and CheckGuid<>'' ";
            }

            if (chkEnd.Checked == true)
            {
                strsql = strsql + " and EndGuid<>'' ";
            }


            return strsql;

        }

        private void btnQty_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSelectSupplier_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(3);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtSupplier.Text = ""; //����
                    txtSupplier.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtSupplier.Text = arrValue[1]; //����
                        txtSupplier.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }
    }
     
}