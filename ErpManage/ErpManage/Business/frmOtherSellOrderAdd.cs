﻿using System;
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
    /// 其它出库单新增
    /// 
    /// 修改日期：2010-9-6  增加对数量超出库存的控制
    /// </summary>
    public partial class frmOtherSellOrderAdd :frmBase
    {
        MaterialManage MaterialManage = new MaterialManage();
        OtherSellOrderManage OtherSellOrderManage = new OtherSellOrderManage();
        DataSet ds = new DataSet();
        public frmOtherSellOrderAdd()
        {
            InitializeComponent();
        }

        //权限判断
        public void SetRight()
        {

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "OtherSellOrderSave", "Save") == false)
            {
                btnAdd.Enabled = false;
                tsbSave.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "OtherSellOrderCheck", "Check") == false)
            {
                tsbCheck.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "OtherSellOrderUnCheck", "UnCheck") == false)
            {
                tsbUnCheck.Enabled = false;
            }


            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "OtherSellOrderPrint", "Print") == false)
            {
                tsbPrint.Enabled = false;
            }

        }

        //新增
        public void AddBill()
        {
            txtOtherSellOrderID.Text = GetAutoId("OtherSellOrder");
            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            txtOtherSellOrderGuid.Text = Guid.NewGuid().ToString();


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
        public void EditBill(string OtherSellOrderGuid)
        {
            txtOtherSellOrderGuid.Text = OtherSellOrderGuid;
            DataTable dtl = OtherSellOrderManage.GetOtherSellOrderByOtherSellOrderGuid(OtherSellOrderGuid);

            txtOtherSellOrderID.Text = dtl.Rows[0]["OtherSellOrderID"].ToString();
            dtpOtherSellOrderDate.Text = DateTime.Parse(dtl.Rows[0]["OtherSellOrderDate"].ToString()).ToString("yyyy-MM-dd");

            txtClient.Text = dtl.Rows[0]["ClientName"].ToString();
            txtClient.Tag = dtl.Rows[0]["Client"].ToString();

            txtQualityPerson.Text = dtl.Rows[0]["QualityPersonName"].ToString();
            txtQualityPerson.Tag = dtl.Rows[0]["QualityPerson"].ToString();


            txtStoragePerson.Text = dtl.Rows[0]["StoragePersonName"].ToString();
            txtStoragePerson.Tag = dtl.Rows[0]["StoragePerson"].ToString();

            txtOutStorage.Text = dtl.Rows[0]["OutStorageName"].ToString();
            txtOutStorage.Tag = dtl.Rows[0]["OutStorage"].ToString();
  
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
            dtl2 = OtherSellOrderManage.GetOtherSellOrderDetail(OtherSellOrderGuid);
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
            ds.Tables[0].TableName = "OtherSellOrderDetail";

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


        //------------------------------------------------------------
        //判断当前需要出库的数量是否已经超过库存数量，如果超过则返回False
        public List<YJMaterialStorage> IsOverStorageNum()
        {
            List<YJMaterialStorage> lst = new List<YJMaterialStorage>();
            YJMaterialStorage YJMaterialStorage = new YJMaterialStorage();

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRowView dr = (DataRowView)(gridView1.GetRow(i));

                string strMaterialGuid = dr["MaterialGuID"].ToString();
                string strMaterialID = dr["MaterialID"].ToString();
                string strMaterialName = dr["MaterialName"].ToString();
                //得到当前料件在指定仓库中的数量
                DataTable dtl = MaterialManage.sp_GetOneStorageSumData(txtOutStorage.Tag.ToString(), strMaterialGuid);

                if (dtl.Rows.Count > 0)
                {
                    decimal decMaterialSum = 0;
                    //库存中有数量，当前数量与库存中的比较，如果当前数量大于库存中的数量，则给出提示
                    if (dr["MaterialSum"].ToString().Trim() != "")
                    {
                        decMaterialSum = decimal.Parse(dr["MaterialSum"].ToString());
                    }

                    decimal decStorageSum = decimal.Parse(dtl.Rows[0]["StorageSum"].ToString());

                    if (decMaterialSum > decStorageSum)
                    {
                        YJMaterialStorage = new YJMaterialStorage();
                        YJMaterialStorage.MaterialID = strMaterialID;
                        YJMaterialStorage.MaterialName = strMaterialName;
                        YJMaterialStorage.MaterialSum = decMaterialSum;
                        YJMaterialStorage.StorageSum = decStorageSum;
                        YJMaterialStorage.StorageName = txtOutStorage.Text;
                        lst.Add(YJMaterialStorage);

                    }

                }
            }
            return lst;

        }
        //---------------------------------------------------------





        private void tsbSave_Click(object sender, EventArgs e)
        {
            SaveData(1);
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="SaveType">1- 保存  2-保存并审核</param>
        private bool SaveData(int SaveType)
        {
            txtRemark.Focus();
            gridView1.UpdateCurrentRow();

            if (txtClient.Text == "")
            {
                this.ShowAlertMessage("必须输入客户!");
                return false ;
            }

            if (dtpOtherSellOrderDate.Text == "")
            {
                this.ShowAlertMessage("必须输入开单日期!");
                return false;
            }

            if (gridView1.RowCount <= 0)
            {
                this.ShowAlertMessage("必须增加明细数据!");
                return false;
            }

            if (txtOutStorage.Text.Trim() == "")
            {
                this.ShowAlertMessage("必须输入出货仓库!");
                return false; 
            }


            //-------------------------------------
            //是否开启数量超出库存预警
            if (MaterialManage.OverNumStorage(txtOutStorage.Tag.ToString()) == true)
            {
                List<YJMaterialStorage> lst = IsOverStorageNum();
                if (lst.Count > 0)
                {
                    frmShowYJMaterial frmShowYJMaterial = new frmShowYJMaterial();
                    frmShowYJMaterial.ShowFillData(lst);
                    return false;
                }
            }
            //---------------------------------------


            //if (bm.IsExistBillID(txtBillID.Text) == true && this.Tag.ToString() == "add")
            //{
            //    this.ShowAlertMessage("订单号已经存在，请重新输入!");
            //    return;
            //}


            OtherSellOrder OtherSellOrder = new OtherSellOrder();
            OtherSellOrder.OtherSellOrderGuid = txtOtherSellOrderGuid.Text;
            OtherSellOrder.OtherSellOrderID = txtOtherSellOrderID.Text;
            OtherSellOrder.OtherSellOrderDate = DateTime.Parse(dtpOtherSellOrderDate.Text);
            if (txtClient.Tag != null)
            {
                OtherSellOrder.Client = txtClient.Tag.ToString();
            }
            if (txtQualityPerson.Tag != null)
            {
                OtherSellOrder.QualityPerson = txtQualityPerson.Tag.ToString();
            }

            if (txtStoragePerson.Tag != null)
            {
                OtherSellOrder.StoragePerson = txtStoragePerson.Tag.ToString();
            }


            if (txtClient.Tag != null)
            {
                OtherSellOrder.Client = txtClient.Tag.ToString();
            }


            if (txtOutStorage.Tag != null)
            {
                OtherSellOrder.OutStorage = txtOutStorage.Tag.ToString();
            }

            OtherSellOrder.Remark = txtRemark.Text;

            OtherSellOrder.CreateGuid = txtCreateGuid.Tag.ToString();
            OtherSellOrder.CreateDate = DateTime.Now;
            OtherSellOrder.CheckGuid = "";
            OtherSellOrder.CheckDate = DateTime.Parse("1900-01-01");



            List<OtherSellOrderDetail> list = new List<OtherSellOrderDetail>();
            OtherSellOrderDetail OtherSellOrderDetail = new OtherSellOrderDetail();
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRowView dr = (DataRowView)(gridView1.GetRow(i));

                OtherSellOrderDetail = new OtherSellOrderDetail();
                OtherSellOrderDetail.OtherSellOrderGuid = txtOtherSellOrderGuid.Text;
                OtherSellOrderDetail.MaterialGuID = dr["MaterialGuID"].ToString();
                if (dr["MaterialSum"].ToString().Trim() != "")
                {
                    OtherSellOrderDetail.MaterialSum = decimal.Parse(dr["MaterialSum"].ToString());
                }
                else
                {
                    OtherSellOrderDetail.MaterialSum = 0;
                }

                if (dr["Price"].ToString().Trim() != "")
                {
                    OtherSellOrderDetail.Price = decimal.Parse(dr["Price"].ToString());
                }
                else
                {
                    OtherSellOrderDetail.Price = 0;
                }

                if (dr["MaterialMoney"].ToString().Trim() != "")
                {
                    OtherSellOrderDetail.MaterialMoney = decimal.Parse(dr["MaterialMoney"].ToString());
                }
                else
                {
                    OtherSellOrderDetail.MaterialMoney = 0;
                }
                OtherSellOrderDetail.Remark = dr["Remark"].ToString();

                OtherSellOrderDetail.SortID = i;

                list.Add(OtherSellOrderDetail);
            }



            //保存
            OtherSellOrderManage.SaveBill(OtherSellOrder, list);

            tsbCheck.Enabled = true;
            tsbUnCheck.Enabled = false;

            SetRight();

            //写日志
            SysLog.AddOperateLog(SysParams.UserName, "其它出库单保存", "保存", SysParams.UserName + "用户保存其它出库单,唯一号:" + txtOtherSellOrderGuid.Text + ",其它出库单号:" + txtOtherSellOrderID.Text);


            //用于打印
            DataTable dtl3 = base.GetDataTable((DataView)gridView1.DataSource);
            ds.Tables.Clear();
            ds.Tables.Add(dtl3.Copy());
            ds.Tables[0].TableName = "OtherSellOrderDetail";


            this.Tag = "edit";

            if (SaveType == 1)
            {
                this.ShowMessage("保存成功");
            }

            frmOtherSellOrder.frmOothersellorder.LoadData();

            return true;
        
        }

        private void tsbCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定审核该其它出库单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (SaveData(2) == false)
                {
                    return;
                }

                //更新审核状态
                OtherSellOrderManage.CheckBill(txtOtherSellOrderGuid.Text, 1);

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
                SysLog.AddOperateLog(SysParams.UserName, "其它出库单审核", "审核", SysParams.UserName + "用户审核其它出库单,唯一号:" + txtOtherSellOrderGuid.Text + ",其它出库单号:" + txtOtherSellOrderID.Text);

                frmOtherSellOrder.frmOothersellorder.LoadData();
            }
        }

        private void tsbUnCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定反审该其它出库单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                OtherSellOrderManage.CheckBill(txtOtherSellOrderGuid.Text, 0);

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
                SysLog.AddOperateLog(SysParams.UserName, "其它出库单反审", "反审", SysParams.UserName + "用户反审其它出库单,唯一号:" + txtOtherSellOrderGuid.Text + ",其它出库单号:" + txtOtherSellOrderID.Text);

                frmOtherSellOrder.frmOothersellorder.LoadData();
            }
        }

        //添加
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtOtherSellOrderID.Text = GetAutoId("OtherSellOrder");
            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            txtOtherSellOrderGuid.Text = Guid.NewGuid().ToString();


            txtOutStorage.Text = "";
            txtOutStorage.Tag = "";

            txtQualityPerson.Text = "";
            txtQualityPerson.Tag = "";

            txtStoragePerson.Text= "";
            txtStoragePerson.Tag = "";

            txtClient.Text= "";
            txtClient.Tag = "";

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
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(4);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                   txtClient.Text= ""; //名称
                   txtClient.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtClient.Text = arrValue[1]; //名称
                        txtClient.Tag = arrValue[0];  //Guid
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
                    txtOutStorage.Text = ""; //名称
                    txtOutStorage.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');


                    if (arrValue.Length > 0)
                    {
                        txtOutStorage.Text = arrValue[1]; //名称
                        txtOutStorage.Tag = arrValue[0];  //Guid
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

            //打印入库单
            XtraReportOtherSellOrder XtraReportOtherSellOrder = new XtraReportOtherSellOrder(ds, txtClient.Text, txtOtherSellOrderID.Text, dtpOtherSellOrderDate.Text,
                                                      txtOutStorage.Text, txtStoragePerson.Text, txtQualityPerson.Text,
                                                             txtRemark.Text, txtCreateGuid.Text, txtCreateDate.Text, txtCheckGuid.Text, txtCheckDate.Text, IsDisplayPrice);
            XtraReportOtherSellOrder.ShowPreview();
        }

        /// <summary>
        /// 显示某个物料的入库批次
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBatchNo_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                //int intRow = gridView1.GetSelectedRows()[0];
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row["MaterialGuID"].ToString();
                frmGetMaterialBatchNo frmGetMaterialBatchNo = new frmGetMaterialBatchNo();
                frmGetMaterialBatchNo.LoadData(guid);
                frmGetMaterialBatchNo.Show(this);

            }
        }

      
    }
}