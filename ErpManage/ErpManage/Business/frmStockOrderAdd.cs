using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;
using ErpManage.Business;
using ErpManage.PrintReport;
using DevExpress.Data;

namespace ErpManage.Business
{
    /// <summary>
    /// 采购订单
    /// 
    /// 修改1:2010-8-12 增加退出时，如果数据没有保存则提示
    /// </summary>
    public partial class frmStockOrderAdd : frmBase
    {
        MaterialManage MaterialManage = new MaterialManage();
        StockOrderManage StockOrderManage = new StockOrderManage();
        ClientOrderManage ClientOrderManage = new ClientOrderManage();
        MaterialMRPPlanManage MaterialMRPPlanManage = new MaterialMRPPlanManage();
        DataSet ds = new DataSet();
        bool IsSave = false;  //是否已保存
        public frmStockOrderAdd()
        {
            InitializeComponent();
        }

        //权限判断
        public void SetRight()
        {

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "StockOrderSave", "Save") == false)
            {
                btnAdd.Enabled = false;
                tsbSave.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "StockOrderCheck", "Check") == false)
            {
                tsbCheck.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "StockOrderUnCheck", "UnCheck") == false)
            {
                tsbUnCheck.Enabled = false;
            }

         

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "StockOrderEnd", "End") == false)
            {
                tsbEnd.Enabled = false;
            }


            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "StockOrderPrint", "Print") == false)
            {
               tsbPrint.Enabled = false;
            }

        }

        //初始经表格
        private DataTable IniBindTable()
        {
            DataTable _dt = new DataTable();
            DataColumn _datacol1 = new DataColumn("StockOrderDetailGuid");
            DataColumn _datacol2 = new DataColumn("StockOrderID");
            DataColumn _datacol3 = new DataColumn("StockOrderDate");
            DataColumn _datacol4 = new DataColumn("MaterialGuID");
            DataColumn _datacol5 = new DataColumn("MaterialID");
            DataColumn _datacol6 = new DataColumn("MaterialName");
            DataColumn _datacol7 = new DataColumn("Spec");
            DataColumn _datacol8 = new DataColumn("Unit");
            DataColumn _datacol9 = new DataColumn("Price");
            DataColumn _datacol10 = new DataColumn("MaterialSum");
            DataColumn _datacol11 = new DataColumn("MaterialTotalMoney");
            DataColumn _datacol12 = new DataColumn("ArriveDate");


            _dt.Columns.Add(_datacol1);
            _dt.Columns.Add(_datacol2);
            _dt.Columns.Add(_datacol3);
            _dt.Columns.Add(_datacol4);
            _dt.Columns.Add(_datacol5);
            _dt.Columns.Add(_datacol6);
            _dt.Columns.Add(_datacol7);
            _dt.Columns.Add(_datacol8);
            _dt.Columns.Add(_datacol9);
            _dt.Columns.Add(_datacol10);
            _dt.Columns.Add(_datacol11);
            _dt.Columns.Add(_datacol12);



            return _dt;
        }


         //新增
        public void AddBill()
        {
            IsSave = false;

            txtStockOrderID.Text = GetAutoId("StockOrder");
            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            txtStockOrderGuid.Text = Guid.NewGuid().ToString();

            gridControl1.DataSource = IniBindTable();

            

            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "IsDisplayPrice", "IsDisplayPrice") == false)
            {
                gridView1.Columns["Price"].Visible = false;
                gridView1.Columns["MaterialTotalMoney"].Visible = false;
            }


            tsbSave.Enabled = true;
            tsbCheck.Enabled = false;
            tsbUnCheck.Enabled = false;
            tsbEnd.Enabled = false;


            SetRight();
         


            this.ShowDialog();
        
        }

        //编辑
        public void EditBill(string StockOrderGuid)
        {
            IsSave = false;

            txtStockOrderGuid.Text = StockOrderGuid;

            DataTable dtl = StockOrderManage.GetStockOrderByStockOrderGuid(StockOrderGuid);

            txtStockOrderGuid.Text = StockOrderGuid;
            txtStockOrderID.Text = dtl.Rows[0]["StockOrderID"].ToString();
            dtpStockOrderDate.Text = DateTime.Parse(dtl.Rows[0]["StockOrderDate"].ToString()).ToString("yyyy-MM-dd");
            txtSupplier.Text = dtl.Rows[0]["SupplierName"].ToString();
            txtSupplier.Tag = dtl.Rows[0]["SupplierGuid"].ToString();
            txtLinkman.Text = dtl.Rows[0]["Linkman"].ToString();
            txtTelephone.Text = dtl.Rows[0]["Telephone"].ToString();
            txtFax.Text = dtl.Rows[0]["Fax"].ToString();
            txtMALinkman.Text = dtl.Rows[0]["MALinkman"].ToString();
            txtMATelephone.Text = dtl.Rows[0]["MATelephone"].ToString();
            txtMAFax.Text = dtl.Rows[0]["MAFax"].ToString();
            txtRemark.Text = dtl.Rows[0]["Remark"].ToString();

            txtCreateGuid.Tag = dtl.Rows[0]["CreateGuid"].ToString();
            txtCreateGuid.Text = dtl.Rows[0]["CreateName"].ToString();
            if (dtl.Rows[0]["CreateDate"].ToString().Contains("1900-01-01") == false)
            {
                txtCreateDate.Text = dtl.Rows[0]["CreateDate"].ToString();
            }
            else
            {
                txtCreateDate.Text = "";
            }


            txtCheckGuid.Tag = dtl.Rows[0]["CheckGuid"].ToString();
            txtCheckGuid.Text = dtl.Rows[0]["CheckName"].ToString();

            if (dtl.Rows[0]["CheckDate"].ToString().Contains("1900-01-01") == false)
            {
                txtCheckDate.Text = dtl.Rows[0]["CheckDate"].ToString();
            }
            else
            {
                txtCheckDate.Text = "";
            }


            txtEndGuid.Tag = dtl.Rows[0]["EndGuid"].ToString();
            txtEndGuid.Text = dtl.Rows[0]["EndName"].ToString();

            if (dtl.Rows[0]["EndDate"].ToString().Contains("1900-01-01") == false)
            {
                txtEndDate.Text = dtl.Rows[0]["EndDate"].ToString();
            }
            else
            {
                txtEndDate.Text = "";
            }

               //判断是否已经结单,结单后不能进行任何修改
            if (txtEndGuid.Text.Trim() != "")
            {
                tsbSave.Enabled = false;

                tsbCheck.Enabled = false;
                tsbUnCheck.Enabled = false;

                if (txtCheckGuid.Text.Trim() != "")
                {
                    tsbEnd.Enabled = false;
                }
                else
                {
                    tsbEnd.Enabled = true;
                }
            }
            else
            {
                //判断是否已经审核
                if (txtCheckGuid.Text.Trim() != "")
                {
                    tsbCheck.Enabled = false;
                    tsbUnCheck.Enabled = true;
                    tsbSave.Enabled = false;

                    tsbEnd.Enabled = true;
                }
                else
                {
                    tsbCheck.Enabled = true;
                    tsbUnCheck.Enabled = false;
                    tsbSave.Enabled = true;

                    tsbEnd.Enabled = false;
                }
            }


            //加载明细
            DataTable dtl2 = new DataTable();
            dtl2 = StockOrderManage.GetStockOrderDetail(StockOrderGuid);
            gridControl1.DataSource = dtl2;
            


            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "IsDisplayPrice", "IsDisplayPrice") == false)
            {
                gridView1.Columns["Price"].Visible = false;
                gridView1.Columns["MaterialTotalMoney"].Visible = false;
            }

            SetRight();


            //用于打印
            DataTable dtl3 = base.GetDataTable((DataView)gridView1.DataSource);
            ds.Tables.Clear();
            ds.Tables.Add(dtl3.Copy());
            ds.Tables[0].TableName = "StockOrderDetail";

            // 增加空白行
            SetNewRow(ds);
          

            this.ShowDialog();
        }

        /// <summary>
        /// 增加空白行
        /// </summary>
        /// <param name="ds"></param>
        private void SetNewRow(DataSet ds)
        {
            //每页9行，如果某页不满9行则补满9行.
            int j = 9 - ds.Tables["StockOrderDetail"].Rows.Count % 9;
            if (j > 0 && j!=9)
            {
                for (int i = 0; i < j; i++)
                {
                    DataRow row = ds.Tables[0].NewRow();
                    for (int k = 0; k < row.ItemArray.Length; k++)
                    {
                        row[k] = DBNull.Value;

                    }

                    ds.Tables[0].Rows.Add(row);
                }

            }
        
        }


        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //选择供应商
        private void btnSelect_Click(object sender, EventArgs e)
        {
           
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(3);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtSupplier.Text = ""; //名称
                    txtSupplier.Tag = "";  //Guid

                    txtLinkman.Text = "";
                    txtTelephone.Text = "";
                    txtFax.Text = "";
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtSupplier.Text = arrValue[1]; //名称
                        txtSupplier.Tag = arrValue[0];  //Guid

                        //根据此供应商自动填充此供应商的联系人，联系电话及传真
                        SupplierManage SupplierManage = new SupplierManage();
                        DataTable dtl = SupplierManage.GetSupplierData_CN(txtSupplier.Tag.ToString());
                        if (dtl.Rows.Count > 0)
                        {
                            txtLinkman.Text = dtl.Rows[0]["LinkMan"].ToString();
                            txtTelephone.Text = dtl.Rows[0]["Telephone"].ToString();
                            txtFax.Text = dtl.Rows[0]["Fax"].ToString();

                        }

                    }
                }
            }
        }

        //增加明细
        private void btnAddDetail_Click(object sender, EventArgs e)
        {
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
                        gridView1.AddNewRow();
                        gridView1.SetFocusedRowCellValue(gridMaterialGuid, material.MaterialGuID);
                        gridView1.SetFocusedRowCellValue(gridMaterialID, material.MaterialID);
                        gridView1.SetFocusedRowCellValue(gridMaterialName, material.MaterialName);
                        gridView1.SetFocusedRowCellValue(gridUnit, base.GetBasicDataNameByID(material.Unit));
                        gridView1.SetFocusedRowCellValue(gridSpec, base.GetBasicDataNameByID(material.Spec));
                        gridView1.SetFocusedRowCellValue(gridPrice, material.Price.ToString("g0"));
                        
                    }

                  


                }

            }

        }

        //删除明细
        private void btnDelDetail_Click(object sender, EventArgs e)
        {
            gridView1.DeleteSelectedRows();

        }

        /// <summary>
        /// 保存数据：
        /// </summary>
        /// <param name="flag">1:则是点退出时的调用保存，0：则是点击保存</param>
        private bool SaveData(int flag )
        {
            txtRemark.Focus();
            gridView1.UpdateCurrentRow();

            if (txtSupplier.Text.Trim() == "")
            {
                this.ShowAlertMessage("必须输入供应商!");
                return false;
            }

            if (dtpStockOrderDate.Text == "")
            {
                this.ShowAlertMessage("必须输入下单日期!");
                return false;
            }

            if (gridView1.RowCount <= 0)
            {
                this.ShowAlertMessage("必须增加明细数据!");
                return false;
            }

            //if (bm.IsExistBillID(txtBillID.Text) == true && this.Tag.ToString() == "add")
            //{
            //    this.ShowAlertMessage("订单号已经存在，请重新输入!");
            //    return;
            //}


            StockOrder StockOrder = new StockOrder();
            StockOrder.StockOrderGuid = txtStockOrderGuid.Text;
            StockOrder.StockOrderID = txtStockOrderID.Text;
            StockOrder.StockOrderDate = DateTime.Parse(dtpStockOrderDate.Text);
            if (txtSupplier.Tag != null)
            {
                StockOrder.SupplierGuid = txtSupplier.Tag.ToString();
            }
            StockOrder.Linkman = txtLinkman.Text;
            StockOrder.Telephone = txtTelephone.Text;
            StockOrder.Fax = txtFax.Text;
            StockOrder.MALinkman = txtMALinkman.Text;
            StockOrder.MATelephone = txtMATelephone.Text;
            StockOrder.MAFax = txtMAFax.Text;
            StockOrder.Remark = txtRemark.Text;

            StockOrder.CreateGuid = txtCreateGuid.Tag.ToString();
            StockOrder.CreateDate = DateTime.Now;
            StockOrder.CheckGuid = "";
            StockOrder.CheckDate = DateTime.Parse("1900-01-01");
            StockOrder.EndGuid = "";
            StockOrder.EndDate = DateTime.Parse("1900-01-01");



            List<StockOrderDetail> list = new List<StockOrderDetail>();
            StockOrderDetail StockOrderDetail = new StockOrderDetail();
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRowView dr = (DataRowView)(gridView1.GetRow(i));

                StockOrderDetail = new StockOrderDetail();
                StockOrderDetail.StockOrderGuid = StockOrder.StockOrderGuid;
                StockOrderDetail.MaterialGuID = dr["MaterialGuID"].ToString();
                if (dr["MaterialSum"].ToString().Trim() != "")
                {
                    StockOrderDetail.MaterialSum = decimal.Parse(dr["MaterialSum"].ToString());
                }
                else
                {
                    StockOrderDetail.MaterialSum = 0;
                }

                if (dr["Price"].ToString().Trim() != "")
                {
                    StockOrderDetail.MaterialPrice = decimal.Parse(dr["Price"].ToString());
                }
                else
                {
                    StockOrderDetail.MaterialPrice = 0;
                }


                if (dr["MaterialTotalMoney"].ToString().Trim() != "")
                {
                    StockOrderDetail.MaterialTotalMoney = decimal.Parse(dr["MaterialTotalMoney"].ToString());
                }
                else
                {
                    StockOrderDetail.MaterialTotalMoney = 0;
                }

                StockOrderDetail.ArriveDate = dr["ArriveDate"].ToString(); //gridView1.GetRowCellValue(i, gridProductGuid).ToString();
                list.Add(StockOrderDetail);

            }



            //保存
            StockOrderManage.SaveBill(StockOrder, list);

            tsbCheck.Enabled = true;
            tsbUnCheck.Enabled = false;

            SetRight();

            //写日志
            SysLog.AddOperateLog(SysParams.UserName, "采购订单保存", "保存", SysParams.UserName + "用户保存了采购订单,订单唯一号:" + txtStockOrderGuid.Text + ",采购订单号:" + txtStockOrderID.Text);



            DataTable dtl = base.GetDataTable((DataView)gridView1.DataSource);
            ds.Tables.Clear();
            ds.Tables.Add(dtl.Copy());
            ds.Tables[0].TableName = "StockOrderDetail";


            // 增加空白行
            SetNewRow(ds);

            this.Tag = "edit";

            //已保存
            IsSave = true;

            //点击保存时才出现提示，如果是点退出时系统提示是否保存调用此保存不给出保存成功提示
            if (flag == 0)
            {
                this.ShowMessage("保存成功");
            }

            frmStockOrder.frmstockorder.LoadData();

            return true;
        
        }


        //保存采购订单
        private void tsbSave_Click(object sender, EventArgs e)
        {
            SaveData(0);
        }

        private void btnSelectPlan_Click(object sender, EventArgs e)
        {
            frmSelectMRPPlan frmSelectMRPPlan = new frmSelectMRPPlan();
            frmSelectMRPPlan.ShowDialog();


            if (frmSelectMRPPlan.Tag != null)
            {
                //得到选中的物料需求计划物料数据信息
                List<String> list = new List<string>();
                list = (List<String>)frmSelectMRPPlan.Tag;


               //得到客户订单的明细数据,组件sql
                if (list.Count > 0)
                {
                    DataTable dtl1 = new DataTable();
                    if (list[1].Trim() != "")
                    {
                        dtl1=MaterialMRPPlanManage.GetMRPPlanCalcDataByPlanGuid(list[0], list[1]);
                    }
                    else
                    {
                        dtl1=MaterialMRPPlanManage.GetMRPPlanCalcDataByPlanGuid(list[0]);
                    }


                    DataView dv = dtl1.DefaultView;
                    dv.Sort = "MaterialID Asc";
                    DataTable dtl = dv.ToTable();


                    //填充数据     
                    for (int j = 0; j < dtl.Rows.Count; j++)
                    {
                       
                        //将选择的客户订单的数据加载过来
                        //填充数据
                        if (decimal.Parse(dtl.Rows[j]["OnlySum"].ToString()) > 0)
                        {
                            gridView1.AddNewRow();
                            gridView1.SetFocusedRowCellValue(gridMaterialGuid, dtl.Rows[j]["MaterialGuid"].ToString());
                            gridView1.SetFocusedRowCellValue(gridMaterialID, dtl.Rows[j]["MaterialID"].ToString());
                            gridView1.SetFocusedRowCellValue(gridMaterialName, dtl.Rows[j]["MaterialName"].ToString());
                            gridView1.SetFocusedRowCellValue(gridUnit, base.GetBasicDataNameByID(dtl.Rows[j]["Unit"].ToString()));
                            gridView1.SetFocusedRowCellValue(gridSpec, base.GetBasicDataNameByID(dtl.Rows[j]["Spec"].ToString()));
                            gridView1.SetFocusedRowCellValue(gridPrice, dtl.Rows[j]["Price"].ToString());
                            gridView1.SetFocusedRowCellValue(gridMaterialSum, dtl.Rows[j]["OnlySum"].ToString());
                            gridView1.SetFocusedRowCellValue(gridMaterialTotalMoney, decimal.Parse(dtl.Rows[j]["Price"].ToString()) * decimal.Parse(dtl.Rows[j]["OnlySum"].ToString()));
                        }
                        
                    }
                }
            }


            //给物料编号列排序
            //gridMaterialID.SortOrder = ColumnSortOrder.Ascending;
        }


        private void tsbCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定审核该采购订单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                StockOrderManage.CheckBill(txtStockOrderGuid.Text, 1);

                //设置为：已审核
                //SetControlEnable(1);

                txtCheckDate.Text = DateTime.Now.ToString();
                txtCheckGuid.Tag = SysParams.UserID;
                txtCheckGuid.Text = SysParams.UserName;


                tsbCheck.Enabled = false;
                tsbUnCheck.Enabled = true;

                tsbEnd.Enabled = true;

                tsbSave.Enabled = false;

                SetRight();

                //写日志
                SysLog.AddOperateLog(SysParams.UserName, "采购订单审核", "审核", SysParams.UserName + "用户审核了采购订单,订单唯一号:" + txtStockOrderGuid.Text + ",采购订单号:" + txtStockOrderID.Text);

                frmStockOrder.frmstockorder.LoadData();
            }
        }

        private void tsbUnCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定反审该采购订单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                StockOrderManage.CheckBill(txtStockOrderGuid.Text, 0);

                //设置为：已审核
                //SetControlEnable(1);

                txtCheckDate.Text = "";
                txtCheckGuid.Tag = "";
                txtCheckGuid.Text = "";


                tsbCheck.Enabled = true;
                tsbUnCheck.Enabled = false;

                tsbEnd.Enabled = false;

                tsbSave.Enabled = true;

                SetRight();

                //写日志
                SysLog.AddOperateLog(SysParams.UserName, "采购订单反审", "反审", SysParams.UserName + "用户反审了采购订单,订单唯一号:" + txtStockOrderGuid.Text + ",采购订单号:" + txtStockOrderID.Text);

                frmStockOrder.frmstockorder.LoadData();
            }
        }

        private void tsbEnd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定对采购订单结单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                //更新审核状态
                StockOrderManage.EndBill(txtStockOrderGuid.Text);

                //设置为：已审核
                //SetControlEnable(1)

                txtEndDate.Text = DateTime.Now.ToString();
                txtEndGuid.Tag = SysParams.UserID;
                txtEndGuid.Text = SysParams.UserName;

                tsbCheck.Enabled = false;
                tsbUnCheck.Enabled = false;

                tsbSave.Enabled = false;
                tsbEnd.Enabled = false;

                SetRight();

                //写日志
                SysLog.AddOperateLog(SysParams.UserName, "采购订单结单", "结单", SysParams.UserName + "用户结单了采购订单,订单唯一号:" + txtStockOrderGuid.Text + ",采购订单号:" + txtStockOrderID.Text);

                frmStockOrder.frmstockorder.LoadData();
            }
        }

        private void repositoryItemSpinEdit1_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Name != "gridMaterialGuid" && e.Column.Name != "gridMaterialID" && e.Column.Name != "gridMaterialName" && e.Column.Name != "gridSpec"
              && e.Column.Name != "gridUnit" && e.Column.Name != "gridArriveDate" && e.Column.Name != "gridMaterialTotalMoney"
               )
            {

                decimal number = 0;
                decimal price = 0;
                if (gridView1.GetFocusedRowCellValue("Price").ToString() != "")
                {
                    price = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("Price").ToString());
                }
                if (gridView1.GetFocusedRowCellValue("MaterialSum").ToString() != "")
                {
                    number = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("MaterialSum").ToString());
                }

                decimal total = price * number;
                total = decimal.Parse(total.ToString("0.0000"));
                gridView1.SetFocusedRowCellValue(gridMaterialTotalMoney, total);
                //gridView1.SetRowCellValue(e.RowHandle, gridTotal, total);

            }
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            IsSave = false;

            txtStockOrderID.Text = GetAutoId("StockOrder");
            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            txtStockOrderGuid.Text = Guid.NewGuid().ToString();

            dtpStockOrderDate.Text = "";

            txtSupplier.Text = "";
            txtSupplier.Tag = "";

            txtLinkman.Text = "";
            txtTelephone.Text = "";
            txtFax.Text = "";
            txtRemark.Text = "";


            gridControl1.DataSource = IniBindTable();

            tsbSave.Enabled = true;
            tsbCheck.Enabled = false;
            tsbUnCheck.Enabled = false;
            tsbEnd.Enabled = false;

            ds.Tables.Clear();
           
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            if (ds.Tables.Count <= 0)
            {
                this.ShowAlertMessage("请保存数据后再打印!");
                return;
            }
            bool IsDisplayPrice=rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "IsDisplayPrice", "IsDisplayPrice");

            

            //打印入库单
            XtraReportStockOrder XtraReportStockOrder = new XtraReportStockOrder(ds,txtSupplier.Text ,txtStockOrderID.Text, dtpStockOrderDate.Text,
                                                             txtLinkman.Text, txtTelephone.Text, txtFax.Text, txtRemark.Text, txtCreateGuid.Text, txtCreateDate.Text, txtCheckGuid.Text, txtCheckDate.Text, IsDisplayPrice
                                                             ,txtMALinkman.Text,txtMATelephone.Text,txtMAFax.Text
                                                            
                                                           
                                                             );
            XtraReportStockOrder.ShowPreview();
        }

        private void frmStockOrderAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            //退出时如果数据没有保存，则给出提示是否保存,另外条件是要没审核的单据才提示，审核过后就不提示直接退出
            if (IsSave == false && txtCheckGuid.Text.Trim() == "")
            {

                if (MessageBox.Show(this, "采购订单数据尚未保存，是否保存后退出？", "EMRP系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //保存单据
                    if (SaveData(1) == false)
                    {
                        e.Cancel = true;
                    }
                   
                }
               
            }

        }
       
      
    }
}