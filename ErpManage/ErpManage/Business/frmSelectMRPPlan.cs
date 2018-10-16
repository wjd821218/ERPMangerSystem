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
    /// 采购订单从物料需求计划中选择
    /// 
    /// 修改日期：2010-5-18 增加物料明细列表，并增加对供应商的查询
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

        //载入数据
        private void LoadData()
        {
            DataTable dtl = MaterialMRPPlanManage.GetMRPPlanBySQL_EN(GetWhereSQL());
            this.gridControl1.DataSource = dtl;

        }


        //载入数据
        private void LoadDetailData(string MaterialMRPPlanGuid)
        {
            DataTable dtl = MaterialMRPPlanManage.GetMRPPlanDetailByBomPlanGuid(MaterialMRPPlanGuid);
            this.gridControl2.DataSource = dtl;

        }


        //选择
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (txtSupplier.Text.Trim() == "")
            {
                this.ShowAlertMessage("请选择供应商!");
                return;
            }


            List<String> alt = new List<String>();
            if (gridView1.RowCount > 0)
            {
                int intRow = gridView1.GetSelectedRows()[0];
              
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row["MaterialMRPPlanGuID"].ToString();
                alt.Add(guid); //物料需求计划号
                if (txtSupplier.Text.Trim() != "")
                {
                    alt.Add(txtSupplier.Tag.ToString()); //供应商号
                }
                else
                {
                    alt.Add("");  //供应商号
                }
                    
                if (alt.Count <= 0)
                {
                    //请选择记录
                    ShowMessage("请选择物料需求计划数据！");
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


                //绑定物料明细列表数据
                BindMaterialData(guid);

            }
        }

        private void gridControl1_DoubleClick_1(object sender, EventArgs e)
        {
            if (txtSupplier.Text.Trim() == "")
            {
                this.ShowAlertMessage("请选择供应商!");
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
                    //请选择记录
                    ShowMessage("请选择物料需求计划数据！");
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

        //选择供应商
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

                        //绑定物料明细列表数据
                        BindMaterialData(txtSelectGuid.Text);

                    }
                }
            }
        }


        private void BindMaterialData(string guid)
        {

            //加载物料明细列表数据
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

            //给物料编号列排序
            gridMaterialIDDetail.SortOrder = ColumnSortOrder.Ascending;
        
        
        }




       
    }
}