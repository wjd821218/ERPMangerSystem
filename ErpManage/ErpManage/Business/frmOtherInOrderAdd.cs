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
    /// 其它入库单新增
    /// </summary>
    public partial class frmOtherInOrderAdd :frmBase
    {
        MaterialManage MaterialManage = new MaterialManage();
        OtherInOrderManage OtherInOrderManage = new OtherInOrderManage();
        DataSet ds = new DataSet();
        public frmOtherInOrderAdd()
        {
            InitializeComponent();
        }

        //权限判断
        public void SetRight()
        {

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "OtherInOrderSave", "Save") == false)
            {
                btnAdd.Enabled = false;
                tsbSave.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "OtherInOrderCheck", "Check") == false)
            {
                tsbCheck.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "OtherInOrderUnCheck", "UnCheck") == false)
            {
                tsbUnCheck.Enabled = false;
            }


            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "OtherInOrderPrint", "Print") == false)
            {
                tsbPrint.Enabled = false;
            }

        }

        //新增
        public void AddBill()
        {
            txtOtherInOrderID.Text = GetAutoId("OtherInOrder");
            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            txtOtherInOrderGuid.Text = Guid.NewGuid().ToString();


            gridControl1.DataSource=IniBindTable();


            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "IsDisplayPrice", "IsDisplayPrice") == false)
            {
                gridView1.Columns["Price"].Visible = false;
                gridView1.Columns["MaterialMoney"].Visible = false;
            }

            tsbSave.Enabled = true;
            tsbCheck.Enabled = false;
            tsbUnCheck.Enabled = false;
        

            SetRight();
            this.ShowDialog();
        
        }

        //编辑
        public void EditBill(string OtherInOrderGuid)
        {
            txtOtherInOrderGuid.Text = OtherInOrderGuid;
            DataTable dtl = OtherInOrderManage.GetOtherInOrderByOtherInOrderGuid(OtherInOrderGuid);

            txtOtherInOrderID.Text = dtl.Rows[0]["OtherInOrderID"].ToString();
            dtpOtherInOrderDate.Text = DateTime.Parse(dtl.Rows[0]["OtherInOrderDate"].ToString()).ToString("yyyy-MM-dd");


            txtQualityPerson.Text = dtl.Rows[0]["QualityPersonName"].ToString();
            txtQualityPerson.Tag = dtl.Rows[0]["QualityPerson"].ToString();


            txtStoragePerson.Text = dtl.Rows[0]["StoragePersonName"].ToString();
            txtStoragePerson.Tag = dtl.Rows[0]["StoragePerson"].ToString();

            txtInStorage.Text = dtl.Rows[0]["InStorageName"].ToString();
            txtInStorage.Tag = dtl.Rows[0]["InStorage"].ToString();

            txtBatchNO.Text = dtl.Rows[0]["BatchNo"].ToString();
  
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
            dtl2 = OtherInOrderManage.GetOtherInOrderDetail(OtherInOrderGuid);
            gridControl1.DataSource = dtl2;


            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "IsDisplayPrice", "IsDisplayPrice") == false)
            {
                gridView1.Columns["Price"].Visible = false;
                gridView1.Columns["MaterialMoney"].Visible = false;
            }


            //用于打印
            DataTable dtl3 = base.GetDataTable((DataView)gridView1.DataSource);
            ds.Tables.Clear();
            ds.Tables.Add(dtl3.Copy());
            ds.Tables[0].TableName = "OtherInOrderDetail";

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
            DataColumn _datacol1 = new DataColumn("MaterialGuID");
            DataColumn _datacol2 = new DataColumn("MaterialID");
            DataColumn _datacol3 = new DataColumn("MaterialName");
            DataColumn _datacol4 = new DataColumn("Spec");
            DataColumn _datacol5 = new DataColumn("Unit");
            DataColumn _datacol6 = new DataColumn("MaterialSum");
            DataColumn _datacol7 = new DataColumn("MaterialMoney");
            DataColumn _datacol8 = new DataColumn("Price");
            DataColumn _datacol9 = new DataColumn("Remark");
        
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


      


        private void btnDelDetail_Click(object sender, EventArgs e)
        {
            gridView1.DeleteSelectedRows();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            txtRemark.Focus();
            gridView1.UpdateCurrentRow();

         
            if (dtpOtherInOrderDate.Text == "")
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


            OtherInOrder OtherInOrder = new OtherInOrder();
            OtherInOrder.OtherInOrderGuid = txtOtherInOrderGuid.Text;
            OtherInOrder.OtherInOrderID = txtOtherInOrderID.Text;
            OtherInOrder.OtherInOrderDate = DateTime.Parse(dtpOtherInOrderDate.Text);
          
            if (txtQualityPerson.Tag  != null)
            {
                OtherInOrder.QualityPerson = txtQualityPerson.Tag.ToString();
            }

            if (txtStoragePerson.Tag != null)
            {
                OtherInOrder.StoragePerson = txtStoragePerson.Tag.ToString();
            }

            if (txtInStorage.Tag!= null)
            {
                OtherInOrder.InStorage = txtInStorage.Tag.ToString();
            }

            OtherInOrder.BatchNo = txtBatchNO.Text;

            OtherInOrder.Remark = txtRemark.Text;

            OtherInOrder.CreateGuid = txtCreateGuid.Tag.ToString();
            OtherInOrder.CreateDate = DateTime.Now;
            OtherInOrder.CheckGuid = "";
            OtherInOrder.CheckDate = DateTime.Parse("1900-01-01");
           


            List<OtherInOrderDetail> list = new List<OtherInOrderDetail>();
            OtherInOrderDetail OtherInOrderDetail = new OtherInOrderDetail();
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRowView dr = (DataRowView)(gridView1.GetRow(i));

                OtherInOrderDetail = new OtherInOrderDetail();
                OtherInOrderDetail.OtherInOrderGuid = txtOtherInOrderGuid.Text;
                OtherInOrderDetail.MaterialGuID = dr["MaterialGuID"].ToString();
                if (dr["MaterialSum"].ToString().Trim() != "")
                {
                    OtherInOrderDetail.MaterialSum = decimal.Parse(dr["MaterialSum"].ToString());
                }
                else
                {
                    OtherInOrderDetail.MaterialSum = 0;
                }

                if (dr["Price"].ToString().Trim() != "")
                {
                    OtherInOrderDetail.Price = decimal.Parse(dr["Price"].ToString());
                }
                else
                {
                    OtherInOrderDetail.Price = 0;
                }

                if (dr["MaterialMoney"].ToString().Trim() != "")
                {
                    OtherInOrderDetail.MaterialMoney = decimal.Parse(dr["MaterialMoney"].ToString());
                }
                else
                {
                    OtherInOrderDetail.MaterialMoney = 0;
                }
                OtherInOrderDetail.Remark = dr["Remark"].ToString();

                OtherInOrderDetail.SortID = i;

                list.Add(OtherInOrderDetail);
            }



            //保存
            OtherInOrderManage.SaveBill(OtherInOrder, list);

            tsbCheck.Enabled = true;
            tsbUnCheck.Enabled = false;

            SetRight();

            //写日志
            SysLog.AddOperateLog(SysParams.UserName, "其它入库单保存", "保存", SysParams.UserName + "用户保存其它入库单,唯一号:" + txtOtherInOrderGuid.Text + ",其它入库单号:" + txtOtherInOrderID.Text);


            //用于打印
            DataTable dtl3 = base.GetDataTable((DataView)gridView1.DataSource);
            ds.Tables.Clear();
            ds.Tables.Add(dtl3.Copy());
            ds.Tables[0].TableName = "OtherInOrderDetail";


            this.Tag = "edit";
            this.ShowMessage("保存成功");

            frmOtherInOrder.frmotherinorder.LoadData();
        }



        private void tsbCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定审核该其它入库单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                OtherInOrderManage.CheckBill(txtOtherInOrderGuid.Text, 1);

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
                SysLog.AddOperateLog(SysParams.UserName, "其它入库单审核", "审核", SysParams.UserName + "用户审核其它入库单,唯一号:" + txtOtherInOrderGuid.Text + ",其它入库单号:" + txtOtherInOrderID.Text);

                frmOtherInOrder.frmotherinorder.LoadData();
            }
        }

        private void tsbUnCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定反审该其它入库单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                OtherInOrderManage.CheckBill(txtOtherInOrderGuid.Text, 0);

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
                SysLog.AddOperateLog(SysParams.UserName, "其它入库单反审", "反审", SysParams.UserName + "用户反审其它入库单,唯一号:" + txtOtherInOrderGuid.Text + ",其它入库单号:" + txtOtherInOrderID.Text);

                frmOtherInOrder.frmotherinorder.LoadData();
            }
        }

        //添加
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtOtherInOrderID.Text = GetAutoId("OtherInOrder");
            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            txtOtherInOrderGuid.Text = Guid.NewGuid().ToString();


            txtInStorage.Text = "";
            txtInStorage.Tag = "";

            txtQualityPerson.Text = "";
            txtQualityPerson.Tag = "";

            txtStoragePerson.Text= "";
            txtStoragePerson.Tag = "";

            txtRemark.Text = "";
            gridControl1.DataSource = IniBindTable();

            tsbSave.Enabled = true;
            tsbCheck.Enabled = false;
            tsbUnCheck.Enabled = false;

         

            ds.Tables.Clear();
        }

      
      

        private void btnDelDetail_Click_1(object sender, EventArgs e)
        {
            gridView1.DeleteSelectedRows();
        }

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
                        gridView1.SetFocusedRowCellValue(gridMaterialGuID, material.MaterialGuID);
                        gridView1.SetFocusedRowCellValue(gridMaterialID, material.MaterialID);
                        gridView1.SetFocusedRowCellValue(gridMaterialName, material.MaterialName);
                        gridView1.SetFocusedRowCellValue(gridUnit, base.GetBasicDataNameByID(material.Unit));
                        gridView1.SetFocusedRowCellValue(gridSpec, base.GetBasicDataNameByID(material.Spec));
                        gridView1.SetFocusedRowCellValue(gridPrice, material.Price.ToString("g0"));
                    }




                }

            }
        }

        private void btnSelectClient_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSelectStoragePerson_Click(object sender, EventArgs e)
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

        private void btnSelectQualityPerson_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(1);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtQualityPerson.Text = ""; //名称
                    txtQualityPerson.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtQualityPerson.Text = arrValue[1]; //名称
                        txtQualityPerson.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        private void btnSelectOutStorage_Click(object sender, EventArgs e)
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

        private void repositoryItemSpinEdit2_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Name != "gridMaterialGuID" && e.Column.Name != "gridMaterialID" &&  e.Column.Name != "gridMaterialName" && e.Column.Name != "gridSpec"
           && e.Column.Name != "gridUnit" && e.Column.Name != "gridRemark" && e.Column.Name != "gridMaterialMoney"
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
                total = decimal.Parse(total.ToString());
                gridView1.SetFocusedRowCellValue(gridMaterialMoney, total.ToString("g0"));
                //gridView1.SetRowCellValue(e.RowHandle, gridTotal, total);

            }
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {

            if (ds.Tables.Count <= 0)
            {
                this.ShowAlertMessage("请保存数据后再打印!");
                return;
            }

            bool IsDisplayPrice = rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "IsDisplayPrice", "IsDisplayPrice");

            //打印其它入库单
            XtraReportOtherInOrder XtraReportOtherInOrder = new XtraReportOtherInOrder(ds, txtOtherInOrderID.Text, dtpOtherInOrderDate.Text,
                                                      txtInStorage.Text, txtStoragePerson.Text, txtQualityPerson.Text,
                                                             txtBatchNO.Text, txtRemark.Text, txtCreateGuid.Text, txtCreateDate.Text, txtCheckGuid.Text, txtCheckDate.Text, IsDisplayPrice);
             XtraReportOtherInOrder.ShowPreview();
        }

      
    }
}