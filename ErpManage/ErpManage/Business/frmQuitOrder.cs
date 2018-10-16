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
    /// ���ϵ�
    /// 
    /// </summary>
    public partial class frmQuitOrder : frmBase
    {
         QuitOrderManage QuitOrderManage = new QuitOrderManage();
         public static frmQuitOrder frmquitorder;
      
        public frmQuitOrder()
        {
            InitializeComponent();
            frmquitorder = this;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        { 
            

            frmQuitOrderAdd frmQuitOrderAdd = new frmQuitOrderAdd();
            frmQuitOrderAdd.AddBill();
        }

        public void LoadData()
        {
            DataTable dtl = new DataTable();
            dtl = QuitOrderManage.GetQuitOrderBySQL(GetWhereSQL());

            gridControl1.DataSource = dtl;


        }

     
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmQuitOrderAdd frmQuitOrderAdd = new frmQuitOrderAdd();
                frmQuitOrderAdd.EditBill(guid);
            }
        }

     

        private void frmQuitOrder_Load(object sender, EventArgs e)
        {
            LoadData();


            //Ȩ���ж�
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "QuitOrderDelete", "Delete") == false)
            {
                btnDelete.Enabled = false;
            }
        }

        private void tsbedit_Click(object sender, EventArgs e)
        {

            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmQuitOrderAdd frmQuitOrderAdd = new frmQuitOrderAdd();
                frmQuitOrderAdd.EditBill(guid);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                DataRowView dr = (DataRowView)(gridView1.GetFocusedRow());


                if (MessageBox.Show("ȷ��ɾ�������ݣ�", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    QuitOrderManage QuitOrderManage = new QuitOrderManage();
                    dr = (DataRowView)(gridView1.GetFocusedRow());
                    if (QuitOrderManage.GetIsCheck(dr["QuitOrderGuid"].ToString()) == false)
                    {
                        QuitOrderManage.DeleteBill(dr["QuitOrderGuid"].ToString());



                        //д��־
                        SysLog.AddOperateLog(SysParams.UserName, "���ϵ�ɾ��", "ɾ��", SysParams.UserName + "�û�ɾ�������ϵ�,���ϵ�Ψһ��:" + dr["QuitOrderGuid"].ToString() + ",���ϵ�����:" + dr["QuitOrderID"].ToString());

                        gridView1.DeleteSelectedRows();

                        this.ShowMessage("ɾ���ɹ�!");
                    }
                    else
                    {
                        this.ShowAlertMessage("�˵�������ˣ�������ɾ��!");
                    }
                }


            }
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public string GetWhereSQL()
        {
            string strsql = "  where  1=1 ";
            if (txtQuitOrderID.Text.Trim() != "")
            {
                strsql = strsql + " and QuitOrderID='" + txtQuitOrderID.Text.Replace("'", "''") + "'";
            }

            if (dtpQuitOrderBeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and QuitOrderDate>='" + dtpQuitOrderBeginDate.Text.Trim() + " 00:00:00'";
            }

            if (dtpQuitOrderEndDate.Text.Trim() != "")
            {
                strsql = strsql + " and QuitOrderDate<='" + dtpQuitOrderEndDate.Text.Trim() + " 23:59:59'";
            }


            if (txtDeliverGoodsPerson.Text.Trim() != "")
            {
                strsql = strsql + " and DeliverGoodsPerson='" + txtDeliverGoodsPerson.Text.Replace("'", "''") + "'";
            }

            if (chkCheck.Checked == true)
            {
                strsql = strsql + " and CheckGuid<>'' ";
            }

            if (chkCheck2.Checked == true)
            {
                strsql = strsql + " and CheckGuid2<>'' ";
            }

            if (txtOutStorage.Text.Trim() != "")
            {
                strsql = strsql + " and OutStorage='" + txtOutStorage.Tag.ToString() + "'";
            }


            return strsql;

        }

        private void btnQty_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        //���ϲֿ�
        private void btnSelectOutStorage_Click(object sender, EventArgs e)
        {
            frmSelectBasicData frmSelectBasicData = new frmSelectBasicData();
            frmSelectBasicData.ShowSelectBasicDataFrm(5);
            if (frmSelectBasicData.Tag != null)
            {
                if (frmSelectBasicData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtOutStorage.Text = ""; //����
                    txtOutStorage.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');


                    if (arrValue.Length > 0)
                    {
                        txtOutStorage.Text = arrValue[1]; //����
                        txtOutStorage.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

    }
}



