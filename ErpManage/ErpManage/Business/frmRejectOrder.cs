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
    /// ���ϵ��鿴
    /// 
    /// </summary>
    public partial class frmRejectOrder : frmBase
    {
        RejectOrderManage RejectOrderManage = new RejectOrderManage();
        public static frmRejectOrder frmrejectorder;
        public frmRejectOrder()
        {
            InitializeComponent();
            frmrejectorder = this;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          
            frmRejectOrderAdd frmRejectOrderAdd = new frmRejectOrderAdd();
            frmRejectOrderAdd.AddBill();
        }

        public void LoadData()
        {
            DataTable dtl = new DataTable();
            dtl = RejectOrderManage.GetRejectOrderBySQL(GetWhereSQL());

            gridControl1.DataSource = dtl;


        }


        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmRejectOrderAdd frmRejectOrderAdd = new frmRejectOrderAdd();
                frmRejectOrderAdd.EditBill(guid);
            }
        }



        private void frmRejectOrder_Load(object sender, EventArgs e)
        {
            LoadData();


            //Ȩ���ж�
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "RejectOrderDelete", "Delete") == false)
            {
                btnDelete.Enabled = false;
            }
        }

        private void tsbedit_Click(object sender, EventArgs e)
        {

            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmRejectOrderAdd frmRejectOrderAdd = new frmRejectOrderAdd();
                frmRejectOrderAdd.EditBill(guid);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            if (gridView1.RowCount > 0)
            {
                DataRowView dr = (DataRowView)(gridView1.GetFocusedRow());


                if (MessageBox.Show("ȷ��ɾ�������ݣ�", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    RejectOrderManage RejectOrderManage = new RejectOrderManage();
                    dr = (DataRowView)(gridView1.GetFocusedRow());
                    if (RejectOrderManage.GetIsCheck(dr["RejectOrderGuid"].ToString()) == false)
                    {

                        RejectOrderManage.DeleteBill(dr["RejectOrderGuid"].ToString());

                      


                        //д��־
                        SysLog.AddOperateLog(SysParams.UserName, "���ϵ�ɾ��", "ɾ��", SysParams.UserName + "�û�ɾ���˱��ϵ�,���ϵ�Ψһ��:" + dr["RejectOrderGuid"].ToString() + ",���ϵ�����:" + dr["RejectOrderID"].ToString());


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

        private void btnQty_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public string GetWhereSQL()
        {
            string strsql = "  where  1=1 ";
            if (txtRejectOrderID.Text.Trim() != "")
            {
                strsql = strsql + " and RejectOrderID='" + txtRejectOrderID.Text.Replace("'", "''") + "'";
            }

            if (dtpRejectOrderBeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and RejectOrderDate>='" + dtpRejectOrderBeginDate.Text.Trim() + " 00:00:00'";
            }

            if (dtpRejectOrderEndDate.Text.Trim() != "")
            {
                strsql = strsql + " and RejectOrderDate<='" + dtpRejectOrderEndDate.Text.Trim() + " 23:59:59'";
            }


            if (txtClientOrderID.Text.Trim()!= "")
            {
                strsql = strsql + " and ClientOrderID='" + txtClientOrderID.Text.Replace("'", "''") + "'";
            }

            if (txtProductType.Text.Trim() != "")
            {
                strsql = strsql + " and ProductType='" + txtProductType.Text.Replace("'", "''") + "'";
            }

            if (chkCheck.Checked == true)
            {
                strsql = strsql + " and CheckGuid<>'' ";
            }

            if (chkCheck2.Checked == true)
            {
                strsql = strsql + " and CheckGuid2<>'' ";
            }


            if (txtRejectStorage.Text.Trim() != "")
            {
                strsql = strsql + " and RejectStorage='" + txtRejectStorage.Tag.ToString() + "'";
            }



            return strsql;

        }

        /// <summary>
        /// ���ϲֿ�ѡ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectRejectStorage_Click(object sender, EventArgs e)
        {
            frmSelectBasicData frmSelectBasicData = new frmSelectBasicData();
            frmSelectBasicData.ShowSelectBasicDataFrm(5);
            if (frmSelectBasicData.Tag != null)
            {
                if (frmSelectBasicData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtRejectStorage.Text = ""; //����
                    txtRejectStorage.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');


                    if (arrValue.Length > 0)
                    {
                        txtRejectStorage.Text = arrValue[1]; //����
                        txtRejectStorage.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }
    }
}


