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
    /// 报废单新增
    /// </summary>
    public partial class frmRejectOrderAdd : frmBase
    {
        RejectOrderManage RejectOrderManage = new RejectOrderManage();
        MaterialManage MaterialManage = new MaterialManage();
        DataSet ds = new DataSet();
        public frmRejectOrderAdd()
        {
            InitializeComponent();
        }

        //权限判断
        public void SetRight()
        {

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "RejectOrderSave", "Save") == false)
            {
                btnAdd.Enabled = false;
                tsbSave.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "RejectOrderCheck", "Check") == false)
            {
                tsbCheck.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "RejectOrderUnCheck", "UnCheck") == false)
            {
                tsbUnCheck.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "RejectOrderCheck2", "Check2") == false)
            {
                tsbCheck2.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "RejectOrderUnCheck2", "UnCheck2") == false)
            {
                tsbUnCheck2.Enabled = false;
            }


            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "RejectOrderPrint", "Print") == false)
            {
                tsbPrint.Enabled= false;
            }
        }


        //新增
        public void AddBill()
        {
            txtRejectOrderID.Text = GetAutoId("RejectOrder");
            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            txtRejectOrderGuid.Text = Guid.NewGuid().ToString();


            gridControl1.DataSource = IniBindTable();
            SetRight();

            this.ShowDialog();

        }

        //编辑
        public void EditBill(string RejectOrderGuid)
        {
            txtRejectOrderGuid.Text = RejectOrderGuid;
            DataTable dtl = RejectOrderManage.GetRejectOrderByRejectOrderGuid(RejectOrderGuid);

            txtRejectOrderID.Text = dtl.Rows[0]["RejectOrderID"].ToString();
            dtpRejectOrderDate.Text = DateTime.Parse(dtl.Rows[0]["RejectOrderDate"].ToString()).ToString("yyyy-MM-dd");

            txtProducePerson.Text = dtl.Rows[0]["ProducePersonName"].ToString();
            txtProducePerson.Tag = dtl.Rows[0]["ProducePerson"].ToString();

            txtQualityPerson.Text = dtl.Rows[0]["QualityPersonName"].ToString();
            txtQualityPerson.Tag = dtl.Rows[0]["QualityPerson"].ToString();


            txtStockPerson.Text = dtl.Rows[0]["StockPersonName"].ToString();
            txtStockPerson.Tag = dtl.Rows[0]["StockPerson"].ToString();

            txtStoragePerson.Text = dtl.Rows[0]["StoragePersonName"].ToString();
            txtStoragePerson.Tag = dtl.Rows[0]["StoragePerson"].ToString();


            txtProjectPerson.Text = dtl.Rows[0]["ProjectPersonName"].ToString();
            txtProjectPerson.Tag = dtl.Rows[0]["ProjectPerson"].ToString();


            txtClientOrderID.Text = dtl.Rows[0]["ClientOrderID"].ToString();

            txtProductType.Text = dtl.Rows[0]["ProductType"].ToString();

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

            txtRejectStorage.Tag = dtl.Rows[0]["RejectStorage"].ToString();
            txtRejectStorage.Text = dtl.Rows[0]["RejectStorageName"].ToString();


            if (dtl.Rows[0]["CheckDate"].ToString().Contains("1900-01-01") == false)
            {
                txtCheckDate.Text = dtl.Rows[0]["CheckDate"].ToString();
            }
            else
            {
                txtCheckDate.Text = "";
            }


            txtCheckGuid2.Tag = dtl.Rows[0]["CheckGuid2"].ToString();
            txtCheckGuid2.Text = dtl.Rows[0]["CheckName2"].ToString();

            if (dtl.Rows[0]["CheckDate2"].ToString().Contains("1900-01-01") == false)
            {
                txtCheckDate2.Text = dtl.Rows[0]["CheckDate2"].ToString();
            }
            else
            {
                txtCheckDate2.Text = "";
            }


            //判断是否已经二级审核
            if (txtCheckGuid2.Text.Trim() != "")
            {
                tsbSave.Enabled = false;

                tsbCheck.Enabled = false;
                tsbUnCheck.Enabled = false;

                tsbCheck2.Enabled = false;
                tsbUnCheck2.Enabled = true;


            }
            else
            {   //是否一级审核
                if (txtCheckGuid.Text.Trim() != "")
                {
                    tsbSave.Enabled = false;

                    tsbCheck.Enabled = false;
                    tsbUnCheck.Enabled = true;

                    tsbCheck2.Enabled = true;
                    tsbUnCheck2.Enabled = false;

                }
                else
                {
                    tsbSave.Enabled = true;

                    tsbCheck.Enabled = true;
                    tsbUnCheck.Enabled = false;

                    tsbCheck2.Enabled = false;
                    tsbUnCheck2.Enabled = false;


                }
            }
            


            //加载明细
            DataTable dtl2 = new DataTable();
            dtl2 = RejectOrderManage.GetRejectOrderDetail(RejectOrderGuid);
            gridControl1.DataSource = dtl2;



            //用于打印
            DataTable dtl3 = base.GetDataTable((DataView)gridView1.DataSource);
            ds.Tables.Clear();
            ds.Tables.Add(dtl3.Copy());
            ds.Tables[0].TableName = "RejectOrderDetail";


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
            DataColumn _datacol7 = new DataColumn("Remark");

            _dt.Columns.Add(_datacol1);
            _dt.Columns.Add(_datacol2);
            _dt.Columns.Add(_datacol3);
            _dt.Columns.Add(_datacol4);
            _dt.Columns.Add(_datacol5);
            _dt.Columns.Add(_datacol6);
            _dt.Columns.Add(_datacol7);


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

         
            if (dtpRejectOrderDate.Text == "")
            {
                this.ShowAlertMessage("必须输入开单日期!");
                return;
            }

            if (gridView1.RowCount <= 0)
            {
                this.ShowAlertMessage("必须增加明细数据!");
                return;
            }

            if (txtRejectStorage.Text.Trim() == "")
            {
                this.ShowAlertMessage("必须输入报废仓库!");
                return;
            }



            //if (bm.IsExistBillID(txtBillID.Text) == true && this.Tag.ToString() == "add")
            //{
            //    this.ShowAlertMessage("订单号已经存在，请重新输入!");
            //    return;
            //}


            RejectOrder RejectOrder = new RejectOrder();
            RejectOrder.RejectOrderGuid = txtRejectOrderGuid.Text;
            RejectOrder.RejectOrderID = txtRejectOrderID.Text;
            RejectOrder.RejectOrderDate = DateTime.Parse(dtpRejectOrderDate.Text);
            if (txtProjectPerson.Tag!= null)
            {
                RejectOrder.ProjectPerson = txtProjectPerson.Tag.ToString();
            }
            if (txtQualityPerson.Tag != null)
            {
                RejectOrder.QualityPerson = txtQualityPerson.Tag.ToString();
            }
            if (txtStockPerson.Tag!= null)
            {
                RejectOrder.StockPerson = txtStockPerson.Tag.ToString();
            }
            if (txtStoragePerson.Tag != null)
            {
                RejectOrder.StoragePerson = txtStoragePerson.Tag.ToString();
            }
            if (txtProducePerson.Tag!= null)
            {
                RejectOrder.ProducePerson = txtProducePerson.Tag.ToString();
            }

            RejectOrder.ProductType = txtProductType.Text;

            RejectOrder.ClientOrderID = txtClientOrderID.Text;

            RejectOrder.Remark = txtRemark.Text;

            RejectOrder.CreateGuid = txtCreateGuid.Tag.ToString();
            RejectOrder.CreateDate = DateTime.Now;
            RejectOrder.CheckGuid = "";
            RejectOrder.CheckDate = DateTime.Parse("1900-01-01");
            RejectOrder.CheckGuid2 = "";
            RejectOrder.CheckDate2 = DateTime.Parse("1900-01-01");
            if (txtRejectStorage.Tag != null)
            {
                RejectOrder.RejectStorage = txtRejectStorage.Tag.ToString();
            }




            List<RejectOrderDetail> list = new List<RejectOrderDetail>();
            RejectOrderDetail RejectOrderDetail = new RejectOrderDetail();
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRowView dr = (DataRowView)(gridView1.GetRow(i));

                RejectOrderDetail = new RejectOrderDetail();
                RejectOrderDetail.RejectOrderGuid = txtRejectOrderGuid.Text;
                RejectOrderDetail.MaterialGuID = dr["MaterialGuID"].ToString();
                if (dr["MaterialSum"].ToString().Trim() != "")
                {
                    RejectOrderDetail.MaterialSum = decimal.Parse(dr["MaterialSum"].ToString());
                }
                else
                {
                    RejectOrderDetail.MaterialSum = 0;
                }

                RejectOrderDetail.Remark = dr["Remark"].ToString();
                RejectOrderDetail.SortID = i;
                list.Add(RejectOrderDetail);
            }



            //保存
            RejectOrderManage.SaveBill(RejectOrder, list);

            tsbCheck.Enabled = true;
            tsbUnCheck.Enabled = false;

            SetRight();


            //写日志
            SysLog.AddOperateLog(SysParams.UserName, "报废单保存", "保存", SysParams.UserName + "用户保存报废单,唯一号:" +txtRejectOrderGuid.Text + ",销售出库单号:" +txtRejectOrderID.Text);

            //用于打印
            DataTable dtl3 = base.GetDataTable((DataView)gridView1.DataSource);
            ds.Tables.Clear();
            ds.Tables.Add(dtl3.Copy());
            ds.Tables[0].TableName = "RejectOrderDetail";


            this.Tag = "edit";
            this.ShowMessage("保存成功");

            frmRejectOrder.frmrejectorder.LoadData();
        }



        private void tsbCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定审核该报废单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                RejectOrderManage.CheckBill(txtRejectOrderGuid.Text, 1);

                //设置为：已审核
                //SetControlEnable(1);

                txtCheckDate.Text = DateTime.Now.ToString();
                txtCheckGuid.Tag = SysParams.UserID;
                txtCheckGuid.Text = SysParams.UserName;


                tsbCheck.Enabled = false;
                tsbUnCheck.Enabled = true;


                tsbCheck2.Enabled = true;
                tsbUnCheck2.Enabled = false;



                tsbSave.Enabled = false;

                SetRight();


                //写日志
                SysLog.AddOperateLog(SysParams.UserName, "报废单审核", "审核", SysParams.UserName + "用户审核报废单,唯一号:" + txtRejectOrderGuid.Text + ",销售出库单号:" + txtRejectOrderID.Text);

                frmRejectOrder.frmrejectorder.LoadData();
            }
        }

        private void tsbUnCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定反审该报废单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                RejectOrderManage.CheckBill(txtRejectOrderGuid.Text, 0);

                //设置为：已审核
                //SetControlEnable(1);
                txtCheckDate.Text = "";
                txtCheckGuid.Tag = "";
                txtCheckGuid.Text = "";


                tsbCheck.Enabled = true;
                tsbUnCheck.Enabled = false;

                tsbCheck2.Enabled = false;
                tsbUnCheck2.Enabled = false;

               

                tsbSave.Enabled = true;

                SetRight();


                //写日志
                SysLog.AddOperateLog(SysParams.UserName, "报废单反审", "反审", SysParams.UserName + "用户审核报废单,唯一号:" + txtRejectOrderGuid.Text + ",销售出库单号:" + txtRejectOrderID.Text);

                frmRejectOrder.frmrejectorder.LoadData();
            }
        }


        private void tsbCheck2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定二级审该报废单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                RejectOrderManage.CheckBill2(txtRejectOrderGuid.Text, 1);

                //设置为：已审核
                //SetControlEnable(1);

                txtCheckDate2.Text = DateTime.Now.ToString();
                txtCheckGuid2.Tag = SysParams.UserID;
                txtCheckGuid2.Text = SysParams.UserName;

                tsbCheck.Enabled = false;
                tsbUnCheck.Enabled = false;

                tsbCheck2.Enabled = false;
                tsbUnCheck2.Enabled = true;

                tsbSave.Enabled = false;

                SetRight();


                //写日志
                SysLog.AddOperateLog(SysParams.UserName, "报废单二级审该", "二级审该", SysParams.UserName + "用户二级审该报废单,唯一号:" + txtRejectOrderGuid.Text + ",报废单单号:" + txtRejectOrderID.Text);

                frmRejectOrder.frmrejectorder.LoadData();
            }
        }

        private void tsbUnCheck2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定二级反审报废单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                RejectOrderManage.CheckBill2(txtRejectOrderGuid.Text, 0);

                //设置为：已审核
                //SetControlEnable(1);

                txtCheckDate2.Text = "";
                txtCheckGuid2.Tag = "";
                txtCheckGuid2.Text = "";

                tsbCheck.Enabled = false;
                tsbUnCheck.Enabled = true;

                tsbCheck2.Enabled = true;
                tsbUnCheck2.Enabled = false;

                tsbSave.Enabled = false;

                SetRight();

                //写日志
                SysLog.AddOperateLog(SysParams.UserName, "报废单二级反审", "二级反审", SysParams.UserName + "用户二级反审报废单,唯一号:" + txtRejectOrderGuid.Text + ",报废单单号:" + txtRejectOrderID.Text);

                frmRejectOrder.frmrejectorder.LoadData();
            }
        }

        //添加
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtRejectOrderID.Text = GetAutoId("RejectOrder");
            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            txtRejectOrderGuid.Text = Guid.NewGuid().ToString();

            txtStoragePerson.Tag = "";
            txtStoragePerson.Text = "";

            txtQualityPerson.Tag = "";
            txtQualityPerson.Text = "";

            txtProducePerson.Tag = "";
            txtProducePerson.Text = "";

            txtProjectPerson.Tag = "";
            txtProjectPerson.Text = "";

            txtStockPerson.Tag = "";
            txtStockPerson.Text = "";

            txtProductType.Text = "";

            txtClientOrderID.Text = "";

            txtRemark.Text = "";
            gridControl1.DataSource = IniBindTable();

            tsbSave.Enabled = true;
            tsbCheck.Enabled = false;
            tsbUnCheck.Enabled = false;

            tsbCheck2.Enabled = false;
            tsbUnCheck2.Enabled = false;

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

                    }




                }

            }
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

        private void btnSelectProjectPerson_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(1);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                   txtProjectPerson.Text= ""; //名称
                   txtProjectPerson.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtProjectPerson.Text = arrValue[1]; //名称
                        txtProjectPerson.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        private void btnSelectStockPerson_Click(object sender, EventArgs e)
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

        private void btnSelectProducePerson_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(1);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtProducePerson.Text = ""; //名称
                    txtProducePerson.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtProducePerson.Text = arrValue[1]; //名称
                        txtProducePerson.Tag = arrValue[0];  //Guid
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

        private void tsbPrint_Click(object sender, EventArgs e)
        {
              if (ds.Tables.Count <= 0)
            {
                this.ShowAlertMessage("请保存数据后再打印!");
                return;
            }

            //打印入库单
            XtraReportRejectOrder XtraReportRejectOrder = new XtraReportRejectOrder(ds,txtRejectOrderID.Text,dtpRejectOrderDate.Text,txtProductType.Text,txtClientOrderID.Text,
                                            txtStoragePerson.Text,txtQualityPerson.Text,txtProjectPerson.Text,txtStockPerson.Text,txtProducePerson.Text,txtRemark.Text,txtCreateGuid.Text ,txtCreateDate.Text, txtCheckGuid.Text, txtCheckDate.Text, txtCheckGuid2.Text, txtCheckDate2.Text);
            XtraReportRejectOrder.ShowPreview();
        
        }

        /// <summary>
        /// 报废仓库选择
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
                    txtRejectStorage.Text = ""; //名称
                    txtRejectStorage.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');


                    if (arrValue.Length > 0)
                    {
                        txtRejectStorage.Text = arrValue[1]; //名称
                        txtRejectStorage.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

       

    }
}