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
    /// 从领料单从生产领料计划选择
    /// </summary>
    public partial class frmSelectDrawPlan : frmBase
    {
        DrawPlanManage DrawPlanManage = new DrawPlanManage();

        public frmSelectDrawPlan()
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
            DataTable dtl = DrawPlanManage.GetDrawPlanBySQL_Select(GetWhereSQL());
            this.gridControl1.DataSource = dtl;

        }


        //载入数据
        private void LoadDetailData(string DrawPlanGuid)
        {
            DataTable dtl = DrawPlanManage.GetDrawPlanDetailByDrawPlanGuid_Select(DrawPlanGuid);
            this.gridControl2.DataSource = dtl;

        }


        //选择
        private void btnSelect_Click(object sender, EventArgs e)
        {
           

            List<String> alt = new List<String>();
            if (gridView1.RowCount > 0)
            {
                int intRow = gridView1.GetSelectedRows()[0];
              
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row["DrawPlanGuID"].ToString();
                txtSelectGuid.Text = guid;
                alt.Add(guid);
                if (txtClass.Text.Trim() != "")
                {
                    alt.Add(txtClass.Tag.ToString());
                }
                else
                {
                    alt.Add("");
                }
                    
                if (alt.Count <= 0)
                {
                    //请选择记录
                    ShowMessage("请选择生产领料计划数据！");
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
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row["DrawPlanGuID"].ToString();
                txtSelectGuid.Text = guid;
                LoadDetailData(guid);

                //绑定物料需求数据
                BindMaterialData(guid);
            }
        }

        private void gridControl1_DoubleClick_1(object sender, EventArgs e)
        {
            List<String> alt = new List<String>();
            if (gridView1.RowCount > 0)
            {
                int intRow = gridView1.GetSelectedRows()[0];

                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row["DrawPlanGuID"].ToString();
                txtSelectGuid.Text = guid;
                alt.Add(guid);
                if (txtClass.Text.Trim() != "")
                {
                    alt.Add(txtClass.Tag.ToString());
                }
                else
                {
                    alt.Add("");
                }


                if (alt.Count <= 0)
                {
                    //请选择记录
                    ShowMessage("请选择生产领料计划数据！");
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
            if (txtDrawPlanID.Text.Trim() != "")
            {
                strsql = strsql + " and DrawPlanID='" + txtDrawPlanID.Text.Replace("'", "''") + "'";
            }

            if (BeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and DrawPlanDate>='" + BeginDate.Text.Trim() + " 00:00:00'";
            }

            if (EndDate.Text.Trim() != "")
            {
                strsql = strsql + " and DrawPlanDate<='" + EndDate.Text.Trim() + " 23:59:59'";
            }

            return strsql;

        }

        //选择物料分类查询
        private void btnMaterialClassSelect_Click(object sender, EventArgs e)
        {
            frmSelectType frmSelectType = new frmSelectType();
            frmSelectType.InValue = 0;
            frmSelectType.ShowDialog();

            if (frmSelectType.Tag != null)
            {
                SelectMaterialType SelectMaterialType = frmSelectType.Tag as SelectMaterialType;

                txtClass.Text = SelectMaterialType.MaterialTypeName;
                txtClass.Tag = SelectMaterialType.MaterialTypeID;

                //绑定物料明细数据
                BindMaterialData(txtSelectGuid.Text);
            }
         
        }

        //绑定物料明细数据
        public void BindMaterialData(string DrawPlanGuid)
        {
            //加载计算物料数据
            DataTable dtl3 = new DataTable();
            if (txtClass.Text.Trim() == "")
            {
                dtl3 = DrawPlanManage.GetDrawPlanCalcSumByDrawPlanGuid(DrawPlanGuid);
            }
            else
            {
                dtl3 = DrawPlanManage.GetDrawPlanCalcSumByDrawPlanGuid(DrawPlanGuid,txtClass.Tag.ToString());
            }
            gridControl3.DataSource = dtl3;

        
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClass.Text = "";
            txtClass.Tag = "";
        }
       

       


       
    }
}