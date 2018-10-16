using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;
using ErpManage.PrintReport;

namespace ErpManage.Business
{
    /// <summary>
    /// 采购入库单新增
    /// </summary>
    public partial class frmStockInOrderAdd :frmBase
    {
        MaterialManage MaterialManage = new MaterialManage();
        StockInOrderManage StockInOrderManage = new StockInOrderManage();
        StockOrderManage StockOrderManage = new StockOrderManage();
        DataSet ds = new DataSet();
        public frmStockInOrderAdd()
        {
            InitializeComponent();
        }

        //权限判断
        public void SetRight()
        {

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "StockInSave", "Save") == false)
            {
                btnAdd.Enabled = false;
                tsbSave.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "StockInCheck", "Check") == false)
            {
                tsbCheck.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "StockInUnCheck", "UnCheck") == false)
            {
                tsbUnCheck.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "StockInPrint", "Print") == false)
            {
              tsbPrint.Enabled= false;
            }


        }


        //新增
        public void AddBill()
        {
            txtStockInOrderID.Text = GetAutoId("StockInOrder");
            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            txtStockInOrderGuid.Text = Guid.NewGuid().ToString();


            gridControl1.DataSource=IniBindTable();

            tsbSave.Enabled = true;
            tsbCheck.Enabled = false;
            tsbUnCheck.Enabled = false;
         

            SetRight();

            this.ShowDialog();
        
        }

        //编辑
        public void EditBill(string StockInOrderGuid)
        {
            txtStockInOrderGuid.Text = StockInOrderGuid;
            DataTable dtl = StockInOrderManage.GetStockInOrderByStockInOrderGuid(StockInOrderGuid);

            txtStockInOrderID.Text = dtl.Rows[0]["StockInOrderID"].ToString();
            dtpStockInOrderDate.Text = DateTime.Parse(dtl.Rows[0]["StockInOrderDate"].ToString()).ToString("yyyy-MM-dd");

            txtSupplierGuid.Text = dtl.Rows[0]["SupplierName"].ToString();
            txtSupplierGuid.Tag = dtl.Rows[0]["SupplierGuid"].ToString();

            txtStockPerson.Text = dtl.Rows[0]["StockPersonName"].ToString();
            txtStockPerson.Tag = dtl.Rows[0]["StockPerson"].ToString();

            txtStoragePerson.Text = dtl.Rows[0]["StoragePersonName"].ToString();
            txtStoragePerson.Tag = dtl.Rows[0]["StoragePerson"].ToString();

            txtInStorage.Text = dtl.Rows[0]["InStorageName"].ToString();
            txtInStorage.Tag = dtl.Rows[0]["InStorage"].ToString();


            txtBatchNO.Text = dtl.Rows[0]["BatchNO"].ToString();

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

            //判断是否已经审核
            if (txtCheckGuid.Text.Trim() != "")
            {
                tsbCheck.Enabled = false;
                tsbUnCheck.Enabled = true;
                tsbSave.Enabled = false;
            }
            else
            {
                tsbCheck.Enabled = true;
                tsbUnCheck.Enabled = false;
                tsbSave.Enabled = true;
            }


            //加载明细
            DataTable dtl2 = new DataTable();
            dtl2 = StockInOrderManage.GetStockInOrderDetail(StockInOrderGuid);
            gridControl1.DataSource = dtl2;


            //用于打印
            DataTable dtl3 = base.GetDataTable((DataView)gridView1.DataSource);
            ds.Tables.Clear();
            ds.Tables.Add(dtl3.Copy());
            ds.Tables[0].TableName = "StockInOrderDetail";


            SetRight();

            this.ShowDialog();
        }
    

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //初始经表格
        private DataTable IniBindTable()
        {
            DataTable _dt = new DataTable();
            DataColumn _datacol1 = new DataColumn("StockOrderGuid");
            DataColumn _datacol2 = new DataColumn("StockOrderID");
            DataColumn _datacol3 = new DataColumn("StockOrderDetailGuid");
            DataColumn _datacol4 = new DataColumn("MaterialGuID");
            DataColumn _datacol5 = new DataColumn("MaterialID");
            DataColumn _datacol6 = new DataColumn("MaterialName");
            DataColumn _datacol7 = new DataColumn("Spec");
            DataColumn _datacol8 = new DataColumn("Unit");
            DataColumn _datacol9 = new DataColumn("MaterialSum");
            DataColumn _datacol10 = new DataColumn("DeliverySum");
            DataColumn _datacol11 = new DataColumn("StorageSum");
            DataColumn _datacol12 = new DataColumn("Remark");

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


        private void btnSelectStockOrder_Click(object sender, EventArgs e)
        {
            frmSelectStockOrder frmSelectStockOrder = new frmSelectStockOrder();
            frmSelectStockOrder.ShowDialog();

            if (frmSelectStockOrder.Tag != null)
            {
                //取出选择的料件Guid
                List<SelectStockOrderDetail> lstGuid = frmSelectStockOrder.Tag as List<SelectStockOrderDetail>;
                SelectStockOrderDetail SelectStockOrderDetail = new SelectStockOrderDetail();

                //选择的品名填充
                if (lstGuid.Count > 0)
                {
                 
                    //得到料件的信息
                    for (int i = 0; i < lstGuid.Count; i++)
                    {
                        SelectStockOrderDetail = lstGuid[i] as SelectStockOrderDetail;

                        //填充数据
                        gridView1.AddNewRow();
                        gridView1.SetFocusedRowCellValue(gridStockOrderGuid, SelectStockOrderDetail.StockOrderGuid);
                        gridView1.SetFocusedRowCellValue(gridStockOrderID, SelectStockOrderDetail.StockOrderID);
                        gridView1.SetFocusedRowCellValue(gridStockOrderDetailGuid, SelectStockOrderDetail.StockOrderDetailGuid);
                        gridView1.SetFocusedRowCellValue(gridMaterialGuID, SelectStockOrderDetail.MaterialGuID);
                        gridView1.SetFocusedRowCellValue(gridMaterialID, SelectStockOrderDetail.MaterialID);
                        gridView1.SetFocusedRowCellValue(gridMaterialName, SelectStockOrderDetail.MaterialName);
                        gridView1.SetFocusedRowCellValue(gridUnit, SelectStockOrderDetail.Unit);
                        gridView1.SetFocusedRowCellValue(gridSpec, SelectStockOrderDetail.Spec);
                        gridView1.SetFocusedRowCellValue(gridMaterialSum, SelectStockOrderDetail.MaterialSum.ToString("g0"));
                        gridView1.SetFocusedRowCellValue(gridStorageSum, SelectStockOrderDetail.CanInSum.ToString("g0"));

                    }




                }

            }
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
                    txtSupplierGuid.Text = ""; //名称
                    txtSupplierGuid.Tag = "";  //Guid
                }
                else
                {

                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtSupplierGuid.Text = arrValue[1]; //名称
                        txtSupplierGuid.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        //选择仓管员
        private void btnSelectStorageEmp_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(1);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtStoragePerson.Text = ""; //名称
                    txtStoragePerson.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtStoragePerson.Text = arrValue[1]; //名称
                        txtStoragePerson.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        //采购员
        private void btnSelectStockEmp_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(1);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtStockPerson.Text = ""; //名称
                    txtStockPerson.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtStockPerson.Text = arrValue[1]; //名称
                        txtStockPerson.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        //选择收货仓库
        private void btnSelectInStorage_Click(object sender, EventArgs e)
        {
            frmSelectBasicData frmSelectBasicData = new frmSelectBasicData();
            frmSelectBasicData.ShowSelectBasicDataFrm(5);
            if (frmSelectBasicData.Tag != null)
            {
                if (frmSelectBasicData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtInStorage.Text = ""; //名称
                    txtInStorage.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');


                    if (arrValue.Length > 0)
                    {
                        txtInStorage.Text = arrValue[1]; //名称
                        txtInStorage.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        private void btnDelDetail_Click(object sender, EventArgs e)
        {
            gridView1.DeleteSelectedRows();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            txtRemark.Focus();
            gridView1.UpdateCurrentRow();

            if (txtSupplierGuid.Text.Trim() == "")
            {
                this.ShowAlertMessage("必须输入供应商!");
                return;
            }

            if (dtpStockInOrderDate.Text == "")
            {
                this.ShowAlertMessage("必须输入开单日期!");
                return;
            }

            if (gridView1.RowCount <= 0)
            {
                this.ShowAlertMessage("必须增加明细数据!");
                return;
            }


            if (txtBatchNO.Text.Trim().Length != 8)
            {
                this.ShowAlertMessage("批号请输入8位日期型,例 yyyyMMdd[20110101]!");
                return;

            }
            else
            {
                string strDate = txtBatchNO.Text.Substring(0, 4) + "-" + txtBatchNO.Text.Substring(4, 2) + "-" + txtBatchNO.Text.Substring(6, 2);
                if (IsDate(strDate) != true)
                {
                    this.ShowAlertMessage("批号输入格式不对，应该为8位日期型,例 yyyyMMdd[20110101]!");
                    return;
                }
            }

           


            //if (bm.IsExistBillID(txtBillID.Text) == true && this.Tag.ToString() == "add")
            //{
            //    this.ShowAlertMessage("订单号已经存在，请重新输入!");
            //    return;
            //}


            StockInOrder StockInOrder = new StockInOrder();
            StockInOrder.StockInOrderGuid = txtStockInOrderGuid.Text;
            StockInOrder.StockInOrderID = txtStockInOrderID.Text;
            StockInOrder.StockInOrderDate = DateTime.Parse(dtpStockInOrderDate.Text);
            if (txtSupplierGuid.Tag != null)
            {
                StockInOrder.SupplierGuid = txtSupplierGuid.Tag.ToString();
            }
            if (txtInStorage.Tag != null)
            {
                StockInOrder.InStorage = txtInStorage.Tag.ToString();
            }
            if (txtStockPerson.Tag != null)
            {
                StockInOrder.StockPerson = txtStockPerson.Tag.ToString();
            }
            if (txtStoragePerson.Tag != null)
            {
                StockInOrder.StoragePerson = txtStoragePerson.Tag.ToString();
            }

            StockInOrder.BatchNO = txtBatchNO.Text;
            StockInOrder.Remark = txtRemark.Text;

            StockInOrder.CreateGuid = txtCreateGuid.Tag.ToString();
            StockInOrder.CreateDate = DateTime.Now;
            StockInOrder.CheckGuid = "";
            StockInOrder.CheckDate = DateTime.Parse("1900-01-01");
           



            List<StockInOrderDetail> list = new List<StockInOrderDetail>();
            StockInOrderDetail StockInOrderDetail = new StockInOrderDetail();
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRowView dr = (DataRowView)(gridView1.GetRow(i));

                StockInOrderDetail = new StockInOrderDetail();
                StockInOrderDetail.StockInOrderGuid = txtStockInOrderGuid.Text;
                StockInOrderDetail.StockOrderGuid = dr["StockOrderGuid"].ToString();
                StockInOrderDetail.StockOrderID = dr["StockOrderID"].ToString();
                StockInOrderDetail.StockOrderDetailGuid = dr["StockOrderDetailGuid"].ToString();
                StockInOrderDetail.MaterialGuID = dr["MaterialGuID"].ToString();
                if (dr["MaterialSum"].ToString().Trim() != "")
                {
                    StockInOrderDetail.MaterialSum = decimal.Parse(dr["MaterialSum"].ToString());
                }
                else
                {
                    StockInOrderDetail.MaterialSum = 0;
                }

                if (dr["DeliverySum"].ToString().Trim() != "")
                {
                    StockInOrderDetail.DeliverySum = decimal.Parse(dr["DeliverySum"].ToString());
                }
                else
                {
                    StockInOrderDetail.DeliverySum = 0;
                }


                if (dr["StorageSum"].ToString().Trim() != "")
                {
                    StockInOrderDetail.StorageSum = decimal.Parse(dr["StorageSum"].ToString());
                }
                else
                {
                    StockInOrderDetail.StorageSum = 0;
                }

                StockInOrderDetail.Remark = dr["Remark"].ToString(); //gridView1.GetRowCellValue(i, gridProductGuid).ToString();
                list.Add(StockInOrderDetail);

            }



            //保存
            StockInOrderManage.SaveBill(StockInOrder, list);

            tsbCheck.Enabled = true;
            tsbUnCheck.Enabled = false;

            SetRight();


            //写日志
            SysLog.AddOperateLog(SysParams.UserName, "采购入库单保存", "保存", SysParams.UserName + "用户保存了采购入库单,唯一号:" + txtStockInOrderGuid.Text + ",采购入库单号:" + txtStockInOrderID.Text);


            //用于打印
            DataTable dtl3 = base.GetDataTable((DataView)gridView1.DataSource);
            ds.Tables.Clear();
            ds.Tables.Add(dtl3.Copy());
            ds.Tables[0].TableName = "StockInOrderDetail";


            this.Tag = "edit";
            this.ShowMessage("保存成功");

            frmStockInOrder.frmstockinorder.LoadData();
        }



        private void tsbCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定审核该采购入库单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                StockInOrderManage.CheckBill(txtStockInOrderGuid.Text, 1);

                //设置为：已审核
                //SetControlEnable(1);

                txtCheckDate.Text = DateTime.Now.ToString();
                txtCheckGuid.Tag = SysParams.UserID;
                txtCheckGuid.Text = SysParams.UserName;


                tsbCheck.Enabled = false;
                tsbUnCheck.Enabled = true;

                tsbSave.Enabled = false;

                SetRight();


                //写日志
                SysLog.AddOperateLog(SysParams.UserName, "采购入库单审核", "审核", SysParams.UserName + "用户审核了采购入库单,唯一号:" + txtStockInOrderGuid.Text + ",采购入库单号:" + txtStockInOrderID.Text);

                frmStockInOrder.frmstockinorder.LoadData();
            }
        }

        private void tsbUnCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定反审该采购入库单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                StockInOrderManage.CheckBill(txtStockInOrderGuid.Text, 0);

                //设置为：已审核
                //SetControlEnable(1);

                txtCheckDate.Text = "";
                txtCheckGuid.Tag = "";
                txtCheckGuid.Text = "";


                tsbCheck.Enabled = true;
                tsbUnCheck.Enabled = false;

                tsbSave.Enabled = true;

                SetRight();

                //写日志
                SysLog.AddOperateLog(SysParams.UserName, "采购入库单反审", "反审", SysParams.UserName + "用户反审了采购入库单,唯一号:" + txtStockInOrderGuid.Text + ",采购入库单号:" + txtStockInOrderID.Text);

                frmStockInOrder.frmstockinorder.LoadData();
            }
        }

        //添加
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtStockInOrderID.Text = GetAutoId("StockInOrder");
            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            txtStockInOrderGuid.Text = Guid.NewGuid().ToString();

            txtSupplierGuid.Text = "";
            txtSupplierGuid.Tag = "";

            txtStockPerson.Text = "";
            txtStockPerson.Tag = "";

            txtStoragePerson.Text = "";
            txtStoragePerson.Tag = "";

            txtInStorage.Text = "";
            txtInStorage.Tag = "";

            dtpStockInOrderDate.Text = "";

            txtRemark.Text = "";
            gridControl1.DataSource = IniBindTable();

            tsbSave.Enabled = true;
            tsbCheck.Enabled = false;
            tsbUnCheck.Enabled = false;
           

            ds.Tables.Clear();
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

        private void repositoryItemSpinEdit1_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            if (ds.Tables.Count <= 0)
            {
                this.ShowAlertMessage("请保存数据后再打印!");
                return;
            }

            //打印入库单
            XtraReportStockInOrder XtraReportStockInOrder = new XtraReportStockInOrder(ds, txtSupplierGuid.Text, txtStockInOrderID.Text, dtpStockInOrderDate.Text,
                                                             txtInStorage.Text, txtStockPerson.Text, txtStoragePerson.Text,txtBatchNO.Text,txtRemark.Text, txtCreateGuid.Text, txtCreateDate.Text, txtCheckGuid.Text, txtCheckDate.Text);
            XtraReportStockInOrder.ShowPreview();
        }
    }
}