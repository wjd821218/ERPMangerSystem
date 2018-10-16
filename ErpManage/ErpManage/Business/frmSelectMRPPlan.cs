using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using ErpManageLibrary;
using DevExpress.Data;

namespace ErpManage.Business
{
    /// <summary>
    /// �ɹ���������������ƻ���ѡ��
    /// 
    /// �޸����ڣ�2010-5-18 ����������ϸ�б������ӶԹ�Ӧ�̵Ĳ�ѯ
    /// </summary>
    public partial class frmSelectMRPPlan : frmBase
    {
        MaterialMRPPlanManage MaterialMRPPlanManage = new MaterialMRPPlanManage();

        public frmSelectMRPPlan()
        {
            InitializeComponent();
        }

        private void frmSelectProduct_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        //��������
        private void LoadData()
        {
            DataTable dtl = MaterialMRPPlanManage.GetMRPPlanBySQL_EN(GetWhereSQL());
            this.gridControl1.DataSource = dtl;

        }


        //��������
        private void LoadDetailData(string MaterialMRPPlanGuid)
        {
            DataTable dtl = MaterialMRPPlanManage.GetMRPPlanDetailByBomPlanGuid(MaterialMRPPlanGuid);
            this.gridControl2.DataSource = dtl;

        }


        //ѡ��
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (txtSupplier.Text.Trim() == "")
            {
                this.ShowAlertMessage("��ѡ��Ӧ��!");
                return;
            }


            List<String> alt = new List<String>();
            if (gridView1.RowCount > 0)
            {
                int intRow = gridView1.GetSelectedRows()[0];
              
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row["MaterialMRPPlanGuID"].ToString();
                alt.Add(guid); //��������ƻ���
                if (txtSupplier.Text.Trim() != "")
                {
                    alt.Add(txtSupplier.Tag.ToString()); //��Ӧ�̺�
                }
                else
                {
                    alt.Add("");  //��Ӧ�̺�
                }
                    
                if (alt.Count <= 0)
                {
                    //��ѡ���¼
                    ShowMessage("��ѡ����������ƻ����ݣ�");
                    return;
                }

                this.Tag = alt;
                this.Close();
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            //if (gridView1.RowCount > 0)
            //{
            //    //int intRow = gridView1.GetSelectedRows()[0];
            //    string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();
            //    this.Tag = guid;

            //    this.Close();
            //}
        }

     

        private void txtQryValue_TextChanged(object sender, EventArgs e)
        {
            //string strsql = "";

            //if (txtQryValue.Text.Trim() !="")
            //{
            //    strsql = " where ProductName like '" + txtQryValue.Text.Trim().Replace("'", "''") + "%'";
            //}
            //DataTable dtl = ProductManage.GetSelectProductData_CN(strsql);
            //this.gridControl1.DataSource = dtl;

            //gridView1.Columns[0].Visible = false;

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
                val = "True";//Ĭ��Ϊѡ�� 
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

        private void gridView1_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
           // if ((this.gridView1.GetDataRow(e.RowHandle1)["BillID"].ToString() != this.gridView1.GetDataRow(e.RowHandle2)["BillID"].ToString())
           //  || (this.gridView1.GetDataRow(e.RowHandle1)["BillDate"].ToString() != this.gridView1.GetDataRow(e.RowHandle2)["BillDate"].ToString()))
           //     e.Handled = true;
        }

      

       
        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
          
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                int intRow = gridView1.GetSelectedRows()[0];
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row["MaterialMRPPlanGuID"].ToString();
                txtSelectGuid.Text = guid;
                LoadDetailData(txtSelectGuid.Text);


                //��������ϸ�б�����
                BindMaterialData(guid);

            }
        }

        private void gridControl1_DoubleClick_1(object sender, EventArgs e)
        {
            if (txtSupplier.Text.Trim() == "")
            {
                this.ShowAlertMessage("��ѡ��Ӧ��!");
                return;
            }


            List<String> alt = new List<String>();
            if (gridView1.RowCount > 0)
            {
                int intRow = gridView1.GetSelectedRows()[0];

                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row["MaterialMRPPlanGuID"].ToString();
                txtSelectGuid.Text = guid;
                alt.Add(guid);

                if (alt.Count <= 0)
                {
                    //��ѡ���¼
                    ShowMessage("��ѡ����������ƻ����ݣ�");
                    return;
                }

                this.Tag = alt;
                this.Close();
            }
        }

        private void btnQry_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        public string GetWhereSQL()
        {
            string strsql = "  where 1=1  ";
            if (txtMaterialMRPPlanID.Text.Trim() != "")
            {
                strsql = strsql + " and MaterialMRPPlanID='" + txtMaterialMRPPlanID.Text.Replace("'", "''") + "'";
            }

            if (BeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and MaterialMRPPlanDate>='" + BeginDate.Text.Trim() + " 00:00:00'";
            }

            if (EndDate.Text.Trim() != "")
            {
                strsql = strsql + " and MaterialMRPPlanDate<='" + EndDate.Text.Trim() + " 23:59:59'";
            }

            return strsql;

        }

        //ѡ��Ӧ��
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

                        //��������ϸ�б�����
                        BindMaterialData(txtSelectGuid.Text);

                    }
                }
            }
        }


        private void BindMaterialData(string guid)
        {

            //����������ϸ�б�����
            MaterialMRPPlanManage MaterialMRPPlanManage = new MaterialMRPPlanManage();
            DataTable dtl3 = new DataTable();
            if (txtSupplier.Text.Trim() != "")
            {
                dtl3 = MaterialMRPPlanManage.GetMRPPlanCalcSumByBomPlanGuid(guid, txtSupplier.Tag.ToString());
            }
            else
            {
                dtl3 = MaterialMRPPlanManage.GetMRPPlanCalcSumByBomPlanGuid(guid);
            }


            gridControl3.DataSource = dtl3;

            //�����ϱ��������
            gridMaterialIDDetail.SortOrder = ColumnSortOrder.Ascending;
        
        
        }




       
    }
}