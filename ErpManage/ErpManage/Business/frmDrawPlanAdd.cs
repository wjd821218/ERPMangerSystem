using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManage.Business;
using ErpManageLibrary;

namespace ErpManage.Business
{
    /// <summary>
    /// 生产领料计划
    /// 
    ///修改1   修改时间：2010-7-12  增加对BOM层级的领料
    /// </summary>
    public partial class frmDrawPlanAdd :frmBase
    {
        ClientOrderManage ClientOrderManage = new ClientOrderManage();
        public frmDrawPlanAdd()
        {
            InitializeComponent();
        }

        //权限判断
        public void SetRight()
        {

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "DrawPlanSave", "Save") == false)
            {
                btnAdd.Enabled = false;
                tsbsave.Enabled = false;
            }

        }

        //新增
        public void Add()
        {
            txtDrawPlanID.Text = GetAutoId("DrawPlan");
            txtDrawPlanGuid.Text = Guid.NewGuid().ToString();
            gridControl1.DataSource = IniBindTable();

            BeginDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        
         
            SetRight();

            this.ShowDialog();
        }


        //编辑
        public void Edit(string DrawPlanGuid)
        {
            txtDrawPlanGuid.Text = DrawPlanGuid;

            DrawPlanManage DrawPlanManage = new DrawPlanManage();
            DataTable dtl = DrawPlanManage.GetDrawPlanByDrawPlanGuid(DrawPlanGuid);
            //加载主数据
            if (dtl.Rows.Count > 0)
            {
                txtDrawPlanID.Text = dtl.Rows[0]["DrawPlanID"].ToString();

                BeginDate.Text = DateTime.Parse(dtl.Rows[0]["DrawPlanDate"].ToString()).ToString("yyyy-MM-dd");
                txtRemark.Text= dtl.Rows[0]["Remark"].ToString();
            }

            //加载明细数据
            DataTable dtl2 = new DataTable();
            dtl2 = DrawPlanManage.GetDrawPlanDetailByDrawPlanGuid(DrawPlanGuid);
            gridControl1.DataSource = dtl2;



            //加载计算物料数据
            DataTable dtl3 = new DataTable();
            dtl3 = DrawPlanManage.GetDrawPlanCalcSumByDrawPlanGuid(DrawPlanGuid);
            gridControl2.DataSource = dtl3;

            SetRight();

            this.ShowDialog();
        
        }


        //初始经表格
        private DataTable IniBindTable()
        {
            DataTable _dt = new DataTable();
            DataColumn _datacol1 = new DataColumn("ClientOrderDetailGuid");
            DataColumn _datacol2 = new DataColumn("ClientOrderID");
            DataColumn _datacol3 = new DataColumn("ClientOrderDate");
            DataColumn _datacol4 = new DataColumn("MaterialID");
            DataColumn _datacol5 = new DataColumn("MaterialName");
            DataColumn _datacol6 = new DataColumn("Spec");
            DataColumn _datacol7 = new DataColumn("MaterialSum");
            DataColumn _datacol8 = new DataColumn("YCMaterialSum");
            DataColumn _datacol9 = new DataColumn("MaterialGuID");
    

            _dt.Columns.Add(_datacol1);
            _dt.Columns.Add(_datacol2);
            _dt.Columns.Add(_datacol3);
            _dt.Columns.Add(_datacol4);
            _dt.Columns.Add(_datacol5);
            _dt.Columns.Add(_datacol6);
            _dt.Columns.Add(_datacol7);
            _dt.Columns.Add(_datacol8);
            _dt.Columns.Add(_datacol9);

            return _dt;
        }

        //初始经表格
        private DataTable IniBindTable2()
        {
            DataTable _dt = new DataTable();
            DataColumn _datacol1 = new DataColumn("MaterialGuID");
            DataColumn _datacol2 = new DataColumn("MaterialID");
            DataColumn _datacol3 = new DataColumn("MaterialName");
            DataColumn _datacol4 = new DataColumn("Unit");
            DataColumn _datacol5 = new DataColumn("Spec");
            DataColumn _datacol6 = new DataColumn("RequirementSum");
            DataColumn _datacol7 = new DataColumn("StorageSum");
   
            _dt.Columns.Add(_datacol1);
            _dt.Columns.Add(_datacol2);
            _dt.Columns.Add(_datacol3);
            _dt.Columns.Add(_datacol4);
            _dt.Columns.Add(_datacol5);
            _dt.Columns.Add(_datacol6);
            _dt.Columns.Add(_datacol7);
      
            return _dt;
        }




        private void btnClientOrderSelect_Click(object sender, EventArgs e)
        {
            frmSelectClientOrder frmSelectClientOrder = new frmSelectClientOrder();
            frmSelectClientOrder.ShowDialog();


            if (frmSelectClientOrder.Tag != null)
            {
                //得到选中的客户订单的明细项
                List<String> list = new List<string>();
                list = (List<String>)frmSelectClientOrder.Tag;


                //得到客户订单的明细数据,组件sql
                string strsql = " where 1=2 ";
                for (int j = 0; j < list.Count; j++)
                {
                    strsql = strsql + " or ClientOrderDetailGuid='" + list[j] + "'";
                }
              

                if (list.Count > 0)
                {

                    DataTable dtl = ClientOrderManage.GetClientOrderBySQL(strsql);

                    //填充数据     
                    for (int j = 0; j < dtl.Rows.Count; j++)
                    {
                        //将选择的客户订单的数据加载过来
                        gridView1.AddNewRow();
                        gridView1.SetFocusedRowCellValue(gridClientOrderDetailGuid, dtl.Rows[j]["ClientOrderDetailGuid"].ToString());
                        gridView1.SetFocusedRowCellValue(gridClientOrderID, dtl.Rows[j]["ClientOrderID"].ToString());
                        gridView1.SetFocusedRowCellValue(gridClientOrderDate, dtl.Rows[j]["ClientOrderDate2"].ToString());
                        gridView1.SetFocusedRowCellValue(gridMaterialID, dtl.Rows[j]["MaterialID"].ToString());
                        gridView1.SetFocusedRowCellValue(gridMaterialName, dtl.Rows[j]["MaterialName"].ToString());
                        gridView1.SetFocusedRowCellValue(gridSpec, dtl.Rows[j]["Spec"].ToString());
                        gridView1.SetFocusedRowCellValue(gridMaterialSum, decimal.Parse(dtl.Rows[j]["MaterialSum"].ToString()).ToString("g0"));
                        gridView1.SetFocusedRowCellValue(gridYCMaterialSum, decimal.Parse(dtl.Rows[j]["MaterialSum"].ToString()).ToString("g0"));
                        gridView1.SetFocusedRowCellValue(gridMaterialGuID, dtl.Rows[j]["MaterialGuID"].ToString());
                       
                    
                    }
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //保存
        private void tsbsave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            if (BeginDate.Text.Trim() == "")
            {
                this.ShowMessage("请输入计算日期!");
                return;
            }

            txtRemark.Focus();
            gridView1.UpdateCurrentRow();

            DrawPlanManage DrawPlanManage = new DrawPlanManage();

            if (gridView1.RowCount > 0)
            {
                //主表数据
                DrawPlan DrawPlan = new DrawPlan();
                DrawPlan.DrawPlanGuid = txtDrawPlanGuid.Text;
                DrawPlan.DrawPlanID = txtDrawPlanID.Text;
                DrawPlan.Remark = txtRemark.Text;
                DrawPlan.DrawPlanDate = DateTime.Parse(BeginDate.Text);
                DrawPlan.CreateGuid = SysParams.UserID;
                DrawPlan.CreateDate = DateTime.Now;

                //明细表数据
                DrawPlanDetail DrawPlanDetail = new DrawPlanDetail();
                List<DrawPlanDetail> list = new List<DrawPlanDetail>();
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    DataRowView dr = (DataRowView)(gridView1.GetRow(i));

                    DrawPlanDetail = new DrawPlanDetail();
                    DrawPlanDetail.NoID = Guid.NewGuid().ToString();
                    DrawPlanDetail.ClientOrderid = dr["ClientOrderID"].ToString();
                    DrawPlanDetail.ClientOrderDetailGuid = dr["ClientOrderDetailGuid"].ToString();
                    DrawPlanDetail.DrawPlanGuid = txtDrawPlanGuid.Text;
                    DrawPlanDetail.MaterialGuid = dr["MaterialGuID"].ToString();
                    if (dr["MaterialSum"].ToString().Trim() != "")
                    {
                        DrawPlanDetail.MaterialSum = decimal.Parse(dr["MaterialSum"].ToString());
                    }
                    else
                    {
                        DrawPlanDetail.MaterialSum = 0;
                    }

                    if (dr["YCMaterialSum"].ToString().Trim() != "")
                    {
                        DrawPlanDetail.YCMaterialSum = decimal.Parse(dr["YCMaterialSum"].ToString());
                    }
                    else
                    {
                        DrawPlanDetail.YCMaterialSum = 0;
                    }

                    list.Add(DrawPlanDetail);

                }

                //物料需求数据-明细
                DrawPlanCalcSumDetail DrawPlanCalcSumDetail = new DrawPlanCalcSumDetail();
                List<DrawPlanCalcSumDetail> list2 = new List<DrawPlanCalcSumDetail>();
                 for (int i = 0; i < gridView2.RowCount; i++)
                {
                    DataRowView dr = (DataRowView)(gridView2.GetRow(i));

                    DrawPlanCalcSumDetail = new DrawPlanCalcSumDetail();
                    DrawPlanCalcSumDetail.NoID = Guid.NewGuid().ToString();
                    DrawPlanCalcSumDetail.DrawPlanGuid = txtDrawPlanGuid.Text;
                    DrawPlanCalcSumDetail.MaterialGuid = dr["MaterialGuID"].ToString();
                 
                    if (dr["RequirementSum"].ToString().Trim() != "")
                    {
                        DrawPlanCalcSumDetail.MaterialRequirementSum = decimal.Parse(dr["RequirementSum"].ToString());
                    }
                    else
                    {
                        DrawPlanCalcSumDetail.MaterialRequirementSum = 0;
                    }
                     //-----注意:此处暂时没为0,等库存算出来了需要更新此处代码.
                    DrawPlanCalcSumDetail.MaterialStockSum = decimal.Parse(dr["StorageSum"].ToString());
                 

                    list2.Add(DrawPlanCalcSumDetail);

                }

                DrawPlanManage.SaveBill(DrawPlan, list, list2);


                //写日志
                SysLog.AddOperateLog(SysParams.UserName, "生产领料计划单保存", "保存", SysParams.UserName + "用户保存生产领料计划单,唯一号:" + txtDrawPlanGuid.Text + "生产领料计划单号:" + txtDrawPlanID.Text);


                frmDrawPlan.frmdrawplan.LoadData();

                this.ShowMessage("保存成功!");

            }
            else
            {
                this.ShowMessage("请选择客户订单!");
               
            }
        
        }

        //计算物料需求
        private void btnJS_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                txtRemark.Focus();
                gridView1.UpdateCurrentRow();

                DrawPlanManage DrawPlanManage = new DrawPlanManage();
                MaterialBOMManage MaterialBOMManage = new MaterialBOMManage();
                bool IsExist = false;
                string strMaterialID = "";
                string strMaterialName = "";
                //检查此客户订单产品是否已经BOM初始化子件情况了
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    DataRowView dr = (DataRowView)(gridView1.GetRow(i));

                    if (dr != null)
                    {
                        if (MaterialBOMManage.IsExistBOMByMaterialGuid(dr["MaterialGuID"].ToString()) == false)
                        {
                            IsExist = true;
                            strMaterialID = dr["MaterialID"].ToString();
                            strMaterialName = dr["MaterialName"].ToString();
                            break;
                        }
                    }
                }

                if (IsExist == true)
                {
                    this.ShowMessage("物料编号:" + strMaterialID + ",名称:" + strMaterialName + " 的料件没有BOM,无法计算!");
                    return;
                }



                //删除临时表中待计算的料件
                DrawPlanManage.DeleteSelectMaterial(txtDrawPlanGuid.Text);

                //先将选择的物料插入到临时表中,参与计算

                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    DataRowView dr = (DataRowView)(gridView1.GetRow(i));

                    if (dr != null)
                    {
                        string strDrawPlanGuID = txtDrawPlanGuid.Text;
                        string strMaterialGuid = dr["MaterialGuID"].ToString();
                        decimal decMaterialSum = 0;
                        if (dr["YCMaterialSum"].ToString().Trim() != "")
                        {
                            decMaterialSum = decimal.Parse(dr["YCMaterialSum"].ToString());
                        }

                        DrawPlanManage.InsertIntoSelectMaterial(strDrawPlanGuID, strMaterialGuid, decMaterialSum);

                    }
                }

                //开始计算
                DataTable dtl = DrawPlanManage.CalcMaterialDrawPlan(txtDrawPlanGuid.Text);

                gridControl2.DataSource = dtl;

                tabControl1.SelectedIndex = 1;

                this.Cursor = Cursors.Arrow;
            }
            catch (Exception err)
            {
                this.ShowMessage("计算出错,信息:" + err.Message);
                this.Cursor = Cursors.Arrow;
            }
        }

        private void btnDelDetail_Click(object sender, EventArgs e)
        {
            gridView1.DeleteSelectedRows();
        }

        private void btnDeleteCalcMaterial_Click(object sender, EventArgs e)
        {
            gridView2.DeleteSelectedRows();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtDrawPlanID.Text = GetAutoId("DrawPlan");
            txtDrawPlanGuid.Text = Guid.NewGuid().ToString();
            
            BeginDate.Text ="";
            txtRemark.Text = "";
            gridControl1.DataSource=IniBindTable();
            gridControl2.DataSource = IniBindTable2();

            
        }

        private void repositoryItemSpinEdit1_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }


        private void btnStorageView_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                //int intRow = gridView1.GetSelectedRows()[0];
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row["MaterialGuID"].ToString();
                frmGetMaterialStorageSum frmGetMaterialStorageSum = new frmGetMaterialStorageSum();
                frmGetMaterialStorageSum.LoadData(guid);
                frmGetMaterialStorageSum.Show(this);

            }

        }

        private void btnStock2_Click(object sender, EventArgs e)
        {
            if (gridView2.RowCount > 0)
            {
                //int intRow = gridView1.GetSelectedRows()[0];
                string guid = ((DataRowView)(gridView2.GetFocusedRow())).Row["MaterialGuID"].ToString();
                frmGetMaterialStorageSum frmGetMaterialStorageSum = new frmGetMaterialStorageSum();
                frmGetMaterialStorageSum.LoadData(guid);
                frmGetMaterialStorageSum.Show(this);

            }
        }

        private void tsbExport_Click(object sender, EventArgs e)
        {
            //网格直接打印
            //  ReportCenter rc = new ReportCenter(gridControl2, "物料需求明细", "");
            //  rc.Preview();



            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel文件|*.XLS|所有文件|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string filename = saveFileDialog1.FileName;
                gridView2.ExportToXls(filename);

                this.ShowMessage("导出成功");
            }
        }

        //组件的领料计划
        private void btnZJ_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                txtRemark.Focus();
                gridView1.UpdateCurrentRow();

                DrawPlanManage DrawPlanManage = new DrawPlanManage();
                MaterialBOMManage MaterialBOMManage = new MaterialBOMManage();
                bool IsExist = false;
                string strMaterialID = "";
                string strMaterialName = "";
                //检查此客户订单产品是否已经BOM初始化子件情况了
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    DataRowView dr = (DataRowView)(gridView1.GetRow(i));

                    if (dr != null)
                    {
                        if (MaterialBOMManage.IsExistBOMByMaterialGuid(dr["MaterialGuID"].ToString()) == false)
                        {
                            IsExist = true;
                            strMaterialID = dr["MaterialID"].ToString();
                            strMaterialName = dr["MaterialName"].ToString();
                            break;
                        }
                    }
                }

                if (IsExist == true)
                {
                    this.ShowMessage("物料编号:" + strMaterialID + ",名称:" + strMaterialName + " 的料件没有BOM,无法计算!");
                    return;
                }



                //删除临时表中待计算的料件
                DrawPlanManage.DeleteSelectMaterial(txtDrawPlanGuid.Text);

                //先将选择的物料插入到临时表中,参与计算

                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    DataRowView dr = (DataRowView)(gridView1.GetRow(i));

                    if (dr != null)
                    {
                        string strDrawPlanGuID = txtDrawPlanGuid.Text;
                        string strMaterialGuid = dr["MaterialGuID"].ToString();
                        decimal decMaterialSum = 0;
                        if (dr["YCMaterialSum"].ToString().Trim() != "")
                        {
                            decMaterialSum = decimal.Parse(dr["YCMaterialSum"].ToString());
                        }

                        DrawPlanManage.InsertIntoSelectMaterial(strDrawPlanGuID, strMaterialGuid, decMaterialSum);

                    }
                }

                //开始计算
                DataTable dtl = DrawPlanManage.CalcMaterialDrawPlan2(txtDrawPlanGuid.Text);

                gridControl2.DataSource = dtl;

                tabControl1.SelectedIndex = 1;

                this.Cursor = Cursors.Arrow;
            }
            catch (Exception err)
            {
                this.ShowMessage("计算出错,信息:" + err.Message);
                this.Cursor = Cursors.Arrow;
            }
        }


        //修改1  增加对BOM层级的领料
        private void btnLevelDrawPlan_Click(object sender, EventArgs e)
        {
            if (cboLevel.Text.Trim() == "")
            {
                this.ShowMessage("请选择层级！");
                cboLevel.Focus();
                return;
            }


            try
            {
                this.Cursor = Cursors.WaitCursor;
                txtRemark.Focus();
                gridView1.UpdateCurrentRow();

                DrawPlanManage DrawPlanManage = new DrawPlanManage();
                MaterialBOMManage MaterialBOMManage = new MaterialBOMManage();
                bool IsExist = false;
                string strMaterialID = "";
                string strMaterialName = "";
                //检查此客户订单产品是否已经BOM初始化子件情况了
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    DataRowView dr = (DataRowView)(gridView1.GetRow(i));

                    if (dr != null)
                    {
                        if (MaterialBOMManage.IsExistBOMByMaterialGuid(dr["MaterialGuID"].ToString()) == false)
                        {
                            IsExist = true;
                            strMaterialID = dr["MaterialID"].ToString();
                            strMaterialName = dr["MaterialName"].ToString();
                            break;
                        }
                    }
                }

                if (IsExist == true)
                {
                    this.ShowMessage("物料编号:" + strMaterialID + ",名称:" + strMaterialName + " 的料件没有BOM,无法计算!");
                    return;
                }


                


                //删除临时表中待计算的料件
                DrawPlanManage.DeleteSelectMaterial(txtDrawPlanGuid.Text);

                //先将选择的物料插入到临时表中,参与计算

                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    DataRowView dr = (DataRowView)(gridView1.GetRow(i));

                    if (dr != null)
                    {
                        string strDrawPlanGuID = txtDrawPlanGuid.Text;
                        string strMaterialGuid = dr["MaterialGuID"].ToString();
                        decimal decMaterialSum = 0;
                        if (dr["YCMaterialSum"].ToString().Trim() != "")
                        {
                            decMaterialSum = decimal.Parse(dr["YCMaterialSum"].ToString());
                        }

                        DrawPlanManage.InsertIntoSelectMaterial(strDrawPlanGuID, strMaterialGuid, decMaterialSum);

                    }
                }

                //开始计算
                DataTable dtl = DrawPlanManage.CalcMaterialDrawPlan3(txtDrawPlanGuid.Text,cboLevel.Text.Trim());

                gridControl2.DataSource = dtl;

                tabControl1.SelectedIndex = 1;

                this.Cursor = Cursors.Arrow;
            }
            catch (Exception err)
            {
                this.ShowMessage("计算出错,信息:" + err.Message);
                this.Cursor = Cursors.Arrow;
            }
        }

        private void repositoryItemSpinEdit2_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }
    }
}