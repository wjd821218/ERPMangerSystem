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
    /// �ͻ�����
    /// </summary>
    public partial class frmClientOrder :frmBase
    {
        public static frmClientOrder frmclientorder;
        public frmClientOrder()
        {
            frmclientorder = this;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           

            frmClientOrderAdd frmClientOrderAdd = new frmClientOrderAdd();
            frmClientOrderAdd.AddBill();
        }

        private void frmClientOrder_Load(object sender, EventArgs e)
        {
            LoadData();


            //Ȩ���ж�
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ClientOrderDelete", "Delete") == false)
            {
                btnDelete.Enabled = false; 
            }


          
        }

        public void LoadData()
        { 
           ClientOrderManage ClientOrderManage=new ClientOrderManage();
           DataTable dtl = ClientOrderManage.GetClientOrder(GetWhereSQL());
           gridControl1.DataSource = dtl;

           gridView1.Columns[0].Visible = false;
           gridView1.Columns[1].MinWidth = 100;
        
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmClientOrderAdd frmClientOrderAdd = new frmClientOrderAdd();
                frmClientOrderAdd.EditBill(guid);
            }
        }

        private void tsbedit_Click(object sender, EventArgs e)
        {

            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmClientOrderAdd frmClientOrderAdd = new frmClientOrderAdd();
                frmClientOrderAdd.EditBill(guid);
            }
        }


        //--------------------------------------

        //�жϽ�ɾ���ĵ����Ƿ����б�ĵ�������
        public List<YJOrderDelete> IsYJOrderDelete(string ClientOrderGuID)
        {
            List<YJOrderDelete> lst = new List<YJOrderDelete>();
            YJOrderDelete YJOrderDelete = new YJOrderDelete();


            ClientOrderManage ClientOrderManage = new ClientOrderManage();
            DataTable dtl = ClientOrderManage.GetSellOrderID(ClientOrderGuID);

            for (int i = 0; i < dtl.Rows.Count; i++)
            {
                string strOrderID = dtl.Rows[i]["SellOrderID"].ToString();
                YJOrderDelete = new YJOrderDelete();
                YJOrderDelete.OrderID = strOrderID;
                YJOrderDelete.OrderName = "���۶���";
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
                    ClientOrderManage ClientOrderManage = new ClientOrderManage();
                    dr = (DataRowView)(gridView1.GetFocusedRow());

                    if (ClientOrderManage.GetIsCheck(dr["ClientOrderGuid"].ToString()) == false)
                    {

                        //-----------------------------------------------------
                        MaterialManage MaterialManage = new MaterialManage();
                        if (MaterialManage.OrderDeleteAlert() == true)
                        {
                            //���س������õĵ���
                            List<YJOrderDelete> lst = IsYJOrderDelete(dr["ClientOrderGuid"].ToString());
                            if (lst.Count > 0)
                            {
                                frmShowYJOrderDelete frmShowYJOrderDelete = new frmShowYJOrderDelete();
                                frmShowYJOrderDelete.ShowFillData(lst);
                                return;
                            }
                        }
                        //---------------------------------------------------------


                        ClientOrderManage.DeleteBill(dr["ClientOrderGuid"].ToString());
                      

                        //д��־
                        SysLog.AddOperateLog(SysParams.UserName, "�ͻ�����ɾ��", "ɾ��", SysParams.UserName + "�û�ɾ���˿ͻ�����,����Ψһ��:" + dr["ClientOrderGuid"].ToString() );

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

        private void btnQty_Click(object sender, EventArgs e)
        {
            LoadData();

        }


        public string  GetWhereSQL()
        {
            string strsql = " where 1=1 ";
            if (txtClientOrderID.Text.Trim() != "")
            {
                strsql = strsql + " and ClientOrderID='" + txtClientOrderID.Text.Replace("'", "''") + "'";
            }

            if (dtpClientOrderBeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and ClientOrderDate>='" + dtpClientOrderBeginDate.Text.Trim() + " 00:00:00'";
            }

            if (dtpClientOrderendDate.Text.Trim() != "")
            {
                strsql = strsql + " and ClientOrderDate<='" + dtpClientOrderendDate.Text.Trim() + " 23:59:59'";
            }

            if (txtContractID.Text.Trim() != "")
            {
                strsql = strsql + " and ContractID='" + txtContractID.Text.Replace("'", "''") + "'";
            }


            if (dtpEncasementBeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and EncasementDate>='" + dtpEncasementBeginDate.Text.Trim() + " 00:00:00'";
            }

            if (dtpEncasementEndDate.Text.Trim() != "")
            {
                strsql = strsql + " and EncasementDate<='" + dtpEncasementEndDate.Text.Trim() + " 23:59:59'";
            }

            if (chkCheck.Checked == true)
            {
                strsql = strsql + " and CheckGuid<>'' ";
            }

            if (chkCheck2.Checked == true)
            {
                strsql = strsql + " and CheckGuid2<>'' ";
            }

            if (chkEnd.Checked == true)
            {
                strsql = strsql + " and EndGuid<>'' ";
            }

            if (cboOrderType.Text.Trim() != "")
            {
                strsql = strsql + " and OrderType='" + cboOrderType.Text.Trim() + "' ";
            }

            return strsql;
        
        }
    }
}