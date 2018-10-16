using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManage.Business;
using ErpManageLibrary;
using DevExpress.Data;

namespace ErpManage
{
    public partial class frmBomMRPAdd :frmBase
    {
        ClientOrderManage ClientOrderManage = new ClientOrderManage();
        public frmBomMRPAdd()
        {
            InitializeComponent();
        }

        //权限判断
        public void SetRight()
        {

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "StockPlanSave", "Save") == false)
            {
                btnAdd.Enabled = false;
                tsbsave.Enabled = false;
            }

        }

        //新增
        public void Add()
        {
            txtMRPPlanID.Text = GetAutoId("MRPPlan");
            txtMaterialMRPPlanGuid.Text = Guid.NewGuid().ToString();
            gridControl1.DataSource = IniBindTable();

            BeginDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

            SetRight();
            this.ShowDialog();
        }


        //编辑
        public void Edit(string MaterialMRPPlanGuid)
        {
            txtMaterialMRPPlanGuid.Text = MaterialMRPPlanGuid;

            MaterialMRPPlanManage MaterialMRPPlanManage = new MaterialMRPPlanManage();
            DataTable dtl = MaterialMRPPlanManage.GetMRPPlanByBomPlanGuid(MaterialMRPPlanGuid);
            //加载主数据
            if (dtl.Rows.Count > 0)
            {
                txtMRPPlanID.Text = dtl.Rows[0]["MaterialMRPPlanID"].ToString();

                BeginDate.Text = DateTime.Parse(dtl.Rows[0]["MaterialMRPPlanDate"].ToString()).ToString("yyyy-MM-dd");
                txtRemark.Text= dtl.Rows[0]["Remark"].ToString();
            }

            //加载明细数据
            DataTable dtl2 = new DataTable();
            dtl2 = MaterialMRPPlanManage.GetMRPPlanDetailByBomPlanGuid(MaterialMRPPlanGuid);
            gridControl1.DataSource = dtl2;



            //加载计算物料数据
            DataTable dtl3 = new DataTable();
            dtl3 = MaterialMRPPlanManage.GetMRPPlanCalcSumByBomPlanGuid(MaterialMRPPlanGuid);
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
            DataColumn _datacol8 = new DataColumn("OnlySum");
           
            _dt.Columns.Add(_datacol1);
            _dt.Columns.Add(_datacol2);
            _dt.Columns.Add(_datacol3);
            _dt.Columns.Add(_datacol4);
            _dt.Columns.Add(_datacol5);
            _dt.Columns.Add(_datacol6);
            _dt.Columns.Add(_datacol7);
            _dt.Columns.Add(_datacol8);
          

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
                        gridView1.SetFocusedRowCellValue(gridMaterialGuid, dtl.Rows[j]["MaterialGuID"].ToString());
                       
                    
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
            gridView2.UpdateCurrentRow();


            MaterialMRPPlanManage MaterialMRPPlanManage = new MaterialMRPPlanManage();

            if (gridView1.RowCount > 0)
            {
                //主表数据
                MaterialMRPPlan MaterialMRPPlan = new MaterialMRPPlan();
                MaterialMRPPlan.MaterialMRPPlanGuid = txtMaterialMRPPlanGuid.Text;
                MaterialMRPPlan.MaterialMRPPlanID = txtMRPPlanID.Text;
                MaterialMRPPlan.Remark = txtRemark.Text;
                MaterialMRPPlan.MaterialMRPPlanDate = DateTime.Parse(BeginDate.Text);
                MaterialMRPPlan.CreateGuid = SysParams.UserID;
                MaterialMRPPlan.CreateDate = DateTime.Now;

                //明细表数据
                MaterialMRPPlanDetail MaterialMRPPlanDetail = new MaterialMRPPlanDetail();
                List<MaterialMRPPlanDetail> list = new List<MaterialMRPPlanDetail>();
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    DataRowView dr = (DataRowView)(gridView1.GetRow(i));

                    MaterialMRPPlanDetail = new MaterialMRPPlanDetail();
                    MaterialMRPPlanDetail.NoID = Guid.NewGuid().ToString();
                    MaterialMRPPlanDetail.ClientOrderid = dr["ClientOrderID"].ToString();
                    MaterialMRPPlanDetail.ClientOrderDetailGuid = dr["ClientOrderDetailGuid"].ToString();
                    MaterialMRPPlanDetail.MaterialMRPPlanGuid = txtMaterialMRPPlanGuid.Text;
                    MaterialMRPPlanDetail.MaterialGuid = dr["MaterialGuID"].ToString();
                    if (dr["MaterialSum"].ToString().Trim() != "")
                    {
                        MaterialMRPPlanDetail.MaterialSum = decimal.Parse(dr["MaterialSum"].ToString());
                    }
                    else
                    {
                        MaterialMRPPlanDetail.MaterialSum = 0;
                    }

                    if (dr["YCMaterialSum"].ToString().Trim() != "")
                    {
                        MaterialMRPPlanDetail.YCMaterialSum = decimal.Parse(dr["YCMaterialSum"].ToString());
                    }
                    else
                    {
                        MaterialMRPPlanDetail.YCMaterialSum = 0;
                    }

                    list.Add(MaterialMRPPlanDetail);

                }

                //物料需求数据-明细
                MaterialMRPPlanCalcSumDetail MaterialMRPPlanCalcSumDetail = new MaterialMRPPlanCalcSumDetail();
                List<MaterialMRPPlanCalcSumDetail> list2 = new List<MaterialMRPPlanCalcSumDetail>();
                 for (int i = 0; i < gridView2.RowCount; i++)
                {
                    DataRowView dr = (DataRowView)(gridView2.GetRow(i));

                    MaterialMRPPlanCalcSumDetail = new MaterialMRPPlanCalcSumDetail();
                    MaterialMRPPlanCalcSumDetail.NoID = Guid.NewGuid().ToString();
                    MaterialMRPPlanCalcSumDetail.MaterialMRPPlanGuid = txtMaterialMRPPlanGuid.Text;
                    MaterialMRPPlanCalcSumDetail.MaterialGuid = dr["MaterialGuID"].ToString();
                 
                    if (dr["RequirementSum"].ToString().Trim() != "")
                    {
                        MaterialMRPPlanCalcSumDetail.MaterialRequirementSum = decimal.Parse(dr["RequirementSum"].ToString());
                    }
                    else
                    {
                        MaterialMRPPlanCalcSumDetail.MaterialRequirementSum = 0;
                    }
                     //-----注意:此处暂时没为0,等库存算出来了需要更新此处代码.
                    MaterialMRPPlanCalcSumDetail.MaterialStockInSum = decimal.Parse(dr["OnlySum"].ToString());
                    MaterialMRPPlanCalcSumDetail.MaterialStockSum = decimal.Parse(dr["StorageSum"].ToString());
                 

                    list2.Add(MaterialMRPPlanCalcSumDetail);

                }

                MaterialMRPPlanManage.SaveBill(MaterialMRPPlan, list, list2);

                frmBomMRP.frmbommrp.LoadData();

                //写日志
                SysLog.AddOperateLog(SysParams.UserName, "物料需求计划保存", "保存", SysParams.UserName + "用户保存了物料需求计划,物料需求计划唯一号:" + txtMaterialMRPPlanGuid.Text+",物料需求计划单号："+txtMRPPlanID.Text);


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

                MaterialMRPPlanManage MaterialMRPPlanManage = new MaterialMRPPlanManage();
                MaterialBOMManage MaterialBOMManage = new MaterialBOMManage();
                bool IsExistBom = false;
                bool IsExistNoBom = false;
                //string strMaterialID = "";
                //string strMaterialName = "";
                //检查此客户订单产品是否已经BOM初始化子件情况了
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    DataRowView dr = (DataRowView)(gridView1.GetRow(i));

                    if (dr != null)
                    {
                        if (MaterialBOMManage.IsExistBOMByMaterialGuid(dr["MaterialGuID"].ToString()) == false)
                        {
                            IsExistNoBom = true;
                            //strMaterialID = dr["MaterialID"].ToString();
                            //strMaterialName = dr["MaterialName"].ToString();
                           
                        }
                        else
                        {
                            IsExistBom = true;
                        }


                        if (IsExistBom == true && IsExistNoBom==true)
                        {
                            this.Cursor = Cursors.Arrow;
                            this.ShowMessage("有BOM与无BOM的物料不能放在一起进行物料需求计算，请分开后再计算物料需求!");
                            return;
                        }

                    }
                }


                if (IsExistBom == true )
                {
                    //全是BOM的料件计算

                    //删除临时表中待计算的料件
                    MaterialMRPPlanManage.DeleteSelectMaterial(txtMaterialMRPPlanGuid.Text);

                    //先将选择的物料插入到临时表中,参与计算
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        DataRowView dr = (DataRowView)(gridView1.GetRow(i));

                        if (dr != null)
                        {
                            string strMaterialMRPPlanGuID = txtMaterialMRPPlanGuid.Text;
                            string strMaterialGuid = dr["MaterialGuID"].ToString();
                            decimal decMaterialSum = 0;
                            if (dr["YCMaterialSum"].ToString().Trim() != "")
                            {
                                decMaterialSum = decimal.Parse(dr["YCMaterialSum"].ToString());
                            }

                            MaterialMRPPlanManage.InsertIntoSelectMaterial(strMaterialMRPPlanGuID, strMaterialGuid, decMaterialSum);

                        }
                    }



                    //第一步:将产品折成最后的子件,子件数量
                    MaterialMRPPlanManage.CalcMaterialBomPlan2(txtMaterialMRPPlanGuid.Text);


                    //将半成品与成品折成料件后，得出最后需要采购的料件，最后再反算出库存
                    DataTable dtl = MaterialMRPPlanManage.sp_Calc(txtMaterialMRPPlanGuid.Text);

                    gridControl2.DataSource = dtl;

                    tabControl1.SelectedIndex = 1;
                }
                else
                { 
                   //全是非BOM的料件计算
                    //删除临时表中待计算的料件
                    MaterialMRPPlanManage.DeleteSelectMaterial(txtMaterialMRPPlanGuid.Text);

                    //先将选择的物料插入到临时表中,参与计算
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        DataRowView dr = (DataRowView)(gridView1.GetRow(i));

                        if (dr != null)
                        {
                            string strMaterialMRPPlanGuID = txtMaterialMRPPlanGuid.Text;
                            string strMaterialGuid = dr["MaterialGuID"].ToString();
                            decimal decMaterialSum = 0;
                            if (dr["YCMaterialSum"].ToString().Trim() != "")
                            {
                                decMaterialSum = decimal.Parse(dr["YCMaterialSum"].ToString());
                            }

                            MaterialMRPPlanManage.InsertIntoSelectMaterial(strMaterialMRPPlanGuID, strMaterialGuid, decMaterialSum);

                        }
                    }


                    //将半成品与成品折成料件后，得出最后需要采购的料件，最后再反算出库存
                    DataTable dtl = MaterialMRPPlanManage.sp_Calc_NoBOM(txtMaterialMRPPlanGuid.Text);

                    gridControl2.DataSource = dtl;

                    tabControl1.SelectedIndex = 1;

                    //按物料编号排序
                    gridMaterialIDDetail.SortOrder=  ColumnSortOrder.Ascending;


                }

                this.Cursor = Cursors.Arrow;
            }
            catch (Exception err)
            {

                this.ShowMessage("计算出错,信息:"+err.Message);
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
            txtMRPPlanID.Text = GetAutoId("MRPPlan");
            txtMaterialMRPPlanGuid.Text = Guid.NewGuid().ToString();
            
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

        //增加明细
        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            MaterialManage MaterialManage = new MaterialManage();
            frmSelectMaterial frmSelectMaterial = new frmSelectMaterial();
            frmSelectMaterial.ShowDialog();

            if (frmSelectMaterial.Tag != null)
            {
                //取出选择的料件Guid
                List<string> lstGuid = frmSelectMaterial.Tag as List<string>;


                //选择的品名填充
                if (lstGuid.Count > 0)
                {
                    //得到料件的信息
                    for (int i = 0; i < lstGuid.Count; i++)
                    {
                        Material material = new Material();
                        material = MaterialManage.GetMaterialByGuid(lstGuid[i]);

                        //填充数据
                        gridView2.AddNewRow();
                        gridView2.SetFocusedRowCellValue(gridMaterialGuidDetail, material.MaterialGuID);
                        gridView2.SetFocusedRowCellValue(gridMaterialIDDetail, material.MaterialID);
                        gridView2.SetFocusedRowCellValue(gridMaterialNameDetail, material.MaterialName);
                        gridView2.SetFocusedRowCellValue(gridUnitDetail, base.GetBasicDataNameByID(material.Unit));
                        gridView2.SetFocusedRowCellValue(gridSpecDetail, base.GetBasicDataNameByID(material.Spec));
                        gridView2.SetFocusedRowCellValue(gridMaterialSumDetail, 0);
                        gridView2.SetFocusedRowCellValue(gridStorageSum, 0);
                        gridView2.SetFocusedRowCellValue(gridStorageMaterialSum, 0);
                        gridView2.SetFocusedRowCellValue(gridOnlySum, 0);

                    }

                }

            }
        }
    }
}