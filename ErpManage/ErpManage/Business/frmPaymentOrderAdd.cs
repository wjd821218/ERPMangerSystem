using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using ErpManage.Business;
using ErpManage.PrintReport;

namespace ErpManage
{
    /// <summary>
    /// 付款单新增
    /// 
    /// 修改日期：2010-5-17 增加开户行与银行帐号
    /// 
    /// 修改日期：2010-6-17 增加二级审核与二级反审
    /// </summary>
    public partial class frmPaymentOrderAdd : frmBase
    {
        PaymentOrderManage PaymentOrderManage = new PaymentOrderManage();
        DataSet ds = new DataSet();
        public frmPaymentOrderAdd()
        {
            InitializeComponent();
        }

        //权限判断
        public void SetRight()
        {

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "PaymentOrderSave", "Save") == false)
            {
                btnAdd.Enabled = false;
                tsbSave.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "PaymentOrderCheck", "Check") == false)
            {
                tsbCheck.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "PaymentOrderUnCheck", "UnCheck") == false)
            {
                tsbUnCheck.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "PaymentOrderCheck2", "Check2") == false)
            {
                tsbCheck2.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "PaymentOrderUnCheck2", "UnCheck2") == false)
            {
                tsbUnCheck2.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "PaymentOrderPrint", "Print") == false)
            {
                tsbPrint.Enabled = false;
            }

        }



        //新增
        public void AddBill()
        {
            txtPaymentOrderID.Text = GetAutoId("PaymentOrder");
            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            txtPaymentOrderGuid.Text = Guid.NewGuid().ToString();

            gridControl1.DataSource = IniBindTable1();

            gridControl2.DataSource = IniBindTable2();

            tsbSave.Enabled = true;
            tsbCheck.Enabled = false;
            tsbUnCheck.Enabled = false;
            tsbCheck2.Enabled = false;
            tsbUnCheck2.Enabled = false;

          

            SetRight();

            this.ShowDialog();

        }

         //编辑
        public void EditBill(string PaymentOrderGuid)
        {
            txtPaymentOrderGuid.Text = PaymentOrderGuid;

            DataTable dtl = PaymentOrderManage.GetPaymentOrderBySQL(" where PaymentOrderGuid='" + PaymentOrderGuid + "'");

            txtPaymentOrderID.Text = dtl.Rows[0]["PaymentOrderID"].ToString();
            dtpPaymentOrderDate.Text = DateTime.Parse(dtl.Rows[0]["PaymentOrderDate"].ToString()).ToString("yyyy-MM-dd");
            txtSupplier.Text = dtl.Rows[0]["SupplierName"].ToString();
            txtSupplier.Tag = dtl.Rows[0]["SupplierGuid"].ToString();

            txtPayPerson.Tag = dtl.Rows[0]["PayPerson"].ToString();
            txtPayPerson.Text = dtl.Rows[0]["PayPersonName"].ToString();
            txtBankID.Text = dtl.Rows[0]["BankID"].ToString();
            txtPayID.Text = dtl.Rows[0]["PayID"].ToString();
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
            dtl2 = PaymentOrderManage.GetPaymentOrderDetail1ByGuid(PaymentOrderGuid);
            gridControl1.DataSource = dtl2;

            //加载明细2
            DataTable dtl3 = new DataTable();
            dtl3 = PaymentOrderManage.GetPaymentOrderDetail2ByGuid(PaymentOrderGuid);
            gridControl2.DataSource = dtl3;


            //用于打印
            ds.Tables.Clear();
            ds.Tables.Add(dtl2.Copy());
            ds.Tables[0].TableName = "PaymentOrderDetail1";
            ds.Tables.Add(dtl3.Copy());
            ds.Tables[1].TableName = "PaymentOrderDetail2";


            SetRight();

            this.ShowDialog();
        }


        //初始经表格
        private DataTable IniBindTable1()
        {
            DataTable _dt = new DataTable();
            DataColumn _datacol1 = new DataColumn("PayName");
            DataColumn _datacol2 = new DataColumn("PayMoney");
            DataColumn _datacol3 = new DataColumn("CNYName");
            DataColumn _datacol4 = new DataColumn("PayTypeName");
            DataColumn _datacol5 = new DataColumn("Remark");
            DataColumn _datacol6 = new DataColumn("PayID");
            DataColumn _datacol7 = new DataColumn("CNY");
            DataColumn _datacol8 = new DataColumn("PayType");
        

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


        //初始经表格
        private DataTable IniBindTable2()
        {
            DataTable _dt = new DataTable();
            DataColumn _datacol1 = new DataColumn("PaymentOrderGuid");
            DataColumn _datacol2 = new DataColumn("StockInOrderID");
            DataColumn _datacol3 = new DataColumn("SupplierName");
            DataColumn _datacol4 = new DataColumn("MaterialGuID");
            DataColumn _datacol5 = new DataColumn("MaterialName");
            DataColumn _datacol6 = new DataColumn("MaterialPrice");
            DataColumn _datacol7 = new DataColumn("MaterialSum");
            DataColumn _datacol8 = new DataColumn("MaterialMoney");
            DataColumn _datacol9 = new DataColumn("OrderFlag");
            DataColumn _datacol10 = new DataColumn("Remark");
            DataColumn _datacol11 = new DataColumn("StockInOrderDate");
            DataColumn _datacol12 = new DataColumn("MaterialID");

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





        private void tsbSave_Click(object sender, EventArgs e)
        {
            txtRemark.Focus();
            gridView1.UpdateCurrentRow();
            gridView2.UpdateCurrentRow();
            txtRemark.Focus();

            if (txtSupplier.Text.Trim() == "")
            {
                this.ShowAlertMessage("必须输入供应商!");
                return;
            }

            if (dtpPaymentOrderDate.Text == "")
            {
                this.ShowAlertMessage("必须输入下单日期!");
                return;
            }

            //if (gridView1.RowCount <= 0)
            //{
            //    this.ShowAlertMessage("必须增加明细数据!");
            //    return;
            //}

            //if (bm.IsExistBillID(txtBillID.Text) == true && this.Tag.ToString() == "add")
            //{
            //    this.ShowAlertMessage("订单号已经存在，请重新输入!");
            //    return;
            //}


            PaymentOrder PaymentOrder = new PaymentOrder();
            PaymentOrder.PaymentOrderGuid = txtPaymentOrderGuid.Text;
            PaymentOrder.PaymentOrderID = txtPaymentOrderID.Text;
            PaymentOrder.PaymentOrderDate = DateTime.Parse(dtpPaymentOrderDate.Text);
            if (txtSupplier.Tag != null)
            {
                PaymentOrder.SupplierGuid = txtSupplier.Tag.ToString();
            }
            if (txtPayPerson.Tag != null)
            {
                PaymentOrder.PayPerson = txtPayPerson.Tag.ToString();
            }

            PaymentOrder.BankID = txtBankID.Text;
            PaymentOrder.PayID = txtPayID.Text;
            PaymentOrder.Remark = txtRemark.Text;


            PaymentOrder.CreateGuid = txtCreateGuid.Tag.ToString();
            PaymentOrder.CreateDate = DateTime.Now;
            PaymentOrder.CheckGuid = "";
            PaymentOrder.CheckDate = DateTime.Parse("1900-01-01");
            PaymentOrder.CheckGuid2 = "";
            PaymentOrder.CheckDate2 = DateTime.Parse("1900-01-01");


      

            List<PaymentOrderDetail1> list1 = new List<PaymentOrderDetail1>();
            PaymentOrderDetail1 PaymentOrderDetail1 = new PaymentOrderDetail1();
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRowView dr = (DataRowView)(gridView1.GetRow(i));

                PaymentOrderDetail1 = new PaymentOrderDetail1();
                PaymentOrderDetail1.PaymentOrderGuid = PaymentOrder.PaymentOrderGuid;
                PaymentOrderDetail1.PayID = dr["PayID"].ToString();
                if (dr["PayMoney"].ToString().Trim() != "")
                {
                    PaymentOrderDetail1.PayMoney = decimal.Parse(dr["PayMoney"].ToString());
                }
                else
                {
                    PaymentOrderDetail1.PayMoney = 0;
                }
                PaymentOrderDetail1.CNY = dr["CNY"].ToString();
                PaymentOrderDetail1.PayType = dr["PayType"].ToString();  
                PaymentOrderDetail1.Remark = dr["Remark"].ToString(); //gridView1.GetRowCellValue(i, gridProductGuid).ToString();
                list1.Add(PaymentOrderDetail1);

            }


            List<PaymentOrderDetail2> list2 = new List<PaymentOrderDetail2>();
            PaymentOrderDetail2 PaymentOrderDetail2 = new PaymentOrderDetail2();
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                DataRowView dr = (DataRowView)(gridView2.GetRow(i));

                PaymentOrderDetail2 = new PaymentOrderDetail2();
                PaymentOrderDetail2.PaymentOrderGuid = PaymentOrder.PaymentOrderGuid;
                PaymentOrderDetail2.StockInOrderID = dr["StockInOrderID"].ToString();
                PaymentOrderDetail2.StockInOrderDate = DateTime.Parse(dr["StockInOrderDate"].ToString());
                PaymentOrderDetail2.SupplierName = dr["SupplierName"].ToString();
                PaymentOrderDetail2.MaterialGuID = dr["MaterialGuID"].ToString();
                PaymentOrderDetail2.MaterialID = dr["MaterialID"].ToString();
                PaymentOrderDetail2.MaterialName = dr["MaterialName"].ToString();

                if (dr["MaterialPrice"].ToString().Trim() != "")
                {
                    PaymentOrderDetail2.MaterialPrice = decimal.Parse(dr["MaterialPrice"].ToString());
                }
                else
                {
                    PaymentOrderDetail2.MaterialPrice = 0;
                }
                if (dr["MaterialSum"].ToString().Trim() != "")
                {
                    PaymentOrderDetail2.MaterialSum = decimal.Parse(dr["MaterialSum"].ToString());
                }
                else
                {
                    PaymentOrderDetail2.MaterialSum = 0;
                }
                if (dr["MaterialMoney"].ToString().Trim() != "")
                {
                    PaymentOrderDetail2.MaterialMoney = decimal.Parse(dr["MaterialMoney"].ToString());
                }
                else
                {
                    PaymentOrderDetail2.MaterialMoney = 0;
                }

                PaymentOrderDetail2.Remark = dr["Remark"].ToString(); //gridView1.GetRowCellValue(i, gridProductGuid).ToString();
               
                PaymentOrderDetail2.OrderFlag = dr["OrderFlag"].ToString();
                PaymentOrderDetail2.SortID = i;
                list2.Add(PaymentOrderDetail2);

            }




            //保存
            PaymentOrderManage.SaveBill(PaymentOrder, list1,list2);

            tsbCheck.Enabled = true;
            tsbUnCheck.Enabled = false;

            SetRight();

            //写日志
            SysLog.AddOperateLog(SysParams.UserName, "付款单保存", "保存", SysParams.UserName + "用户保存付款单,唯一号:" + txtPaymentOrderGuid.Text + ",退料单号:" + txtPaymentOrderID.Text);

            //用于打印
            ds.Tables.Clear();
            DataTable dtl2 = base.GetDataTable((DataView)gridView1.DataSource);
            DataTable dtl3 = base.GetDataTable((DataView)gridView2.DataSource);
            ds.Tables.Add(dtl2.Copy());

            ds.Tables[0].TableName = "PaymentOrderDetail1";
            ds.Tables.Add(dtl3.Copy());

            ds.Tables[1].TableName = "PaymentOrderDetail2";

            this.Tag = "edit";
            this.ShowMessage("保存成功");

            frmPaymentOrder.frmpaymentorder.LoadData();
        }



        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
                    }
                }
            }
        }

        private void btnSelectPayPerson_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(1);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtPayPerson.Text = ""; //名称
                    txtPayPerson.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtPayPerson.Text = arrValue[1]; //名称
                        txtPayPerson.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }





        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
        }

        //帐户
        private void repositoryItemTextEdit1_Click(object sender, EventArgs e)
        {

            frmSelectBasicData frmSelectBasicData = new frmSelectBasicData();
            frmSelectBasicData.ShowSelectBasicDataFrm(8);
            if (frmSelectBasicData.Tag != null)
            {
                if (frmSelectBasicData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    gridView1.SetFocusedRowCellValue(gridPayID, ""); //名称
                    gridView1.SetFocusedRowCellValue(gridPayID2, "");  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');


                    if (arrValue.Length > 0)
                    {
                        gridView1.SetFocusedRowCellValue(gridPayID, arrValue[1]); //名称
                        gridView1.SetFocusedRowCellValue(gridPayID2, arrValue[0]);   //Guid
                    }
                }
            }
        }

        //币种
        private void repositoryItemTextEdit2_Click(object sender, EventArgs e)
        {
            frmSelectBasicData frmSelectBasicData = new frmSelectBasicData();
            frmSelectBasicData.ShowSelectBasicDataFrm(2);
            if (frmSelectBasicData.Tag != null)
            {
                if (frmSelectBasicData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    gridView1.SetFocusedRowCellValue(gridCNY, ""); //名称
                    gridView1.SetFocusedRowCellValue(gridCNY2, "");  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');


                    if (arrValue.Length > 0)
                    {
                        gridView1.SetFocusedRowCellValue(gridCNY, arrValue[1]); //名称
                        gridView1.SetFocusedRowCellValue(gridCNY2, arrValue[0]);   //Guid
                    }
                }
            }
        }

        // 支付方式
        private void repositoryItemTextEdit3_Click(object sender, EventArgs e)
        {
            frmSelectBasicData frmSelectBasicData = new frmSelectBasicData();
            frmSelectBasicData.ShowSelectBasicDataFrm(3);
            if (frmSelectBasicData.Tag != null)
            {
                if (frmSelectBasicData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    gridView1.SetFocusedRowCellValue(gridPayType, ""); //名称
                    gridView1.SetFocusedRowCellValue(gridPayType2, "");  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');


                    if (arrValue.Length > 0)
                    {
                        gridView1.SetFocusedRowCellValue(gridPayType, arrValue[1]); //名称
                        gridView1.SetFocusedRowCellValue(gridPayType2, arrValue[0]);   //Guid
                    }
                }
            }
        }

        private void tsbCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定审核该付款单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                PaymentOrderManage.CheckBill(txtPaymentOrderGuid.Text, 1);

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
                SysLog.AddOperateLog(SysParams.UserName, "付款单审核", "审核", SysParams.UserName + "用户审核付款单,唯一号:" + txtPaymentOrderGuid.Text + ",付款单号:" + txtPaymentOrderID.Text);

                frmPaymentOrder.frmpaymentorder.LoadData();
            }
        }

        private void tsbUnCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定反审该付款单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                PaymentOrderManage.CheckBill(txtPaymentOrderGuid.Text, 0);

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
                SysLog.AddOperateLog(SysParams.UserName, "付款单反审", "反审", SysParams.UserName + "用户反审付款单,唯一号:" + txtPaymentOrderGuid.Text + ",付款单号:" + txtPaymentOrderID.Text);

                frmPaymentOrder.frmpaymentorder.LoadData();
            }
        }


        //二级审核
        private void tsbCheck2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定二级审核该付款单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                PaymentOrderManage.CheckBill2(txtPaymentOrderGuid.Text, 1);

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
                SysLog.AddOperateLog(SysParams.UserName, "付款单二级审核", "二级审核", SysParams.UserName + "用户二级审核付款单,唯一号:" + txtPaymentOrderGuid.Text + ",付款单号:" + txtPaymentOrderID.Text);

                frmPaymentOrder.frmpaymentorder.LoadData();
            }
        }

        //二级反审
        private void tsbUnCheck2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定二级反审该付款单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                PaymentOrderManage.CheckBill2(txtPaymentOrderGuid.Text, 0);

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
                SysLog.AddOperateLog(SysParams.UserName, "付款单二级反审", "二级反审", SysParams.UserName + "用户反审付款单,唯一号:" + txtPaymentOrderGuid.Text + ",付款单号:" + txtPaymentOrderID.Text);

                frmPaymentOrder.frmpaymentorder.LoadData();
            }
        }

        private void btnAddDetail2_Click(object sender, EventArgs e)
        {
            gridView2.AddNewRow();
        }

        private void btnDelDetail_Click(object sender, EventArgs e)
        {
            gridView1.DeleteSelectedRows();
        }

        private void btnDeleteDetail2_Click(object sender, EventArgs e)
        {
            gridView2.DeleteSelectedRows();
        }

        private void repositoryItemSpinEdit2_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }

        private void repositoryItemSpinEdit4_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
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

            XtraReportPaymentOrder XtraReportPaymentOrder = new XtraReportPaymentOrder(ds, txtPaymentOrderID.Text, dtpPaymentOrderDate.Text,txtSupplier.Text,txtPayPerson.Text,
                                    txtRemark.Text,txtBankID.Text,txtPayID.Text, txtCreateGuid.Text, txtCreateDate.Text, txtCheckGuid.Text, txtCheckDate.Text,txtCheckGuid2.Text,txtCheckDate2.Text);
            XtraReportPaymentOrder.ShowPreview();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtPaymentOrderID.Text = GetAutoId("PaymentOrder");
            txtPaymentOrderGuid.Text = Guid.NewGuid().ToString();

            dtpPaymentOrderDate.Text = "";
            txtPayPerson.Text = "";
            txtPayPerson.Tag = "";
            txtSupplier.Text = "";
            txtSupplier.Tag = "";
            txtBankID.Text = "";
            txtPayID.Text = "";
            txtRemark.Text = "";

            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            txtCheckDate.Text = "";
            txtCheckGuid.Text = "";
            txtCheckGuid.Tag = "";


            tsbSave.Enabled = true;
            tsbCheck.Enabled = false;
            tsbUnCheck.Enabled = false;

            tsbCheck2.Enabled = false;
            tsbUnCheck2.Enabled = false;

            gridControl1.DataSource = IniBindTable1();

            gridControl2.DataSource = IniBindTable2();

            ds.Tables.Clear();
        }

        //选择采购入库单
        private void btnSelectStockInOrder_Click(object sender, EventArgs e)
        {
            frmSelectStockInOrder3 frmSelectStockInOrder3 = new frmSelectStockInOrder3();
            frmSelectStockInOrder3.ShowDialog();



            if (frmSelectStockInOrder3.Tag != null)
            {
                //取出选择的料件Guid
                List<SelectStockInOrderDetail> lstGuid = frmSelectStockInOrder3.Tag as List<SelectStockInOrderDetail>;
                SelectStockInOrderDetail SelectStockInOrderDetail = new SelectStockInOrderDetail();

                //选择的品名填充
                if (lstGuid.Count > 0)
                {

                    //得到入库单的信息
                    for (int i = 0; i < lstGuid.Count; i++)
                    {
                        SelectStockInOrderDetail = lstGuid[i] as SelectStockInOrderDetail;

                        //填充数据
                        gridView2.AddNewRow();
                        gridView2.SetFocusedRowCellValue(gridStockInOrderGuid, SelectStockInOrderDetail.StockInOrderGuid);
                        gridView2.SetFocusedRowCellValue(gridStockInOrderID, SelectStockInOrderDetail.StockInOrderID);
                        gridView2.SetFocusedRowCellValue(gridStockInOrderDate, DateTime.Parse(SelectStockInOrderDetail.StockInOrderDate.ToString()).ToString("yyyy-MM-dd"));
                        gridView2.SetFocusedRowCellValue(gridSupplierName, SelectStockInOrderDetail.SupplierName);
                        gridView2.SetFocusedRowCellValue(gridMaterialGuID, SelectStockInOrderDetail.MaterialGuID);
                        gridView2.SetFocusedRowCellValue(gridMaterialID, SelectStockInOrderDetail.MaterialID);
                        gridView2.SetFocusedRowCellValue(gridMaterialName, SelectStockInOrderDetail.MaterialName);
                        gridView2.SetFocusedRowCellValue(gridMaterialPrice, SelectStockInOrderDetail.MaterialPrice.ToString("g0"));
                        gridView2.SetFocusedRowCellValue(gridMaterialSum, SelectStockInOrderDetail.StorageSum.ToString("g0"));
                        gridView2.SetFocusedRowCellValue(gridMaterialMoney2, SelectStockInOrderDetail.MaterialMoney.ToString("g0"));

                        gridView2.SetFocusedRowCellValue(gridOrderFlag, "采购入库单");

                    }

                }

            }

        }

        private void gridView2_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e.Column.Name != "gridOrderFlag" && e.Column.Name != "gridStockInOrderGuid" && e.Column.Name != "gridStockInOrderID" && e.Column.Name != "gridStockInOrderDate" && e.Column.Name != "gridSupplierName"
             && e.Column.Name != "gridMaterialGuID" && e.Column.Name != "gridMaterialID" && e.Column.Name != "gridMaterialName" && e.Column.Name != "gridMaterialMoney2"
              )
            {

                decimal number = 0;
                decimal price = 0;
                if (gridView2.GetFocusedRowCellValue("MaterialPrice").ToString() != "")
                {
                    price = Convert.ToDecimal(gridView2.GetFocusedRowCellValue("MaterialPrice").ToString());
                }
                if (gridView2.GetFocusedRowCellValue("MaterialSum").ToString() != "")
                {
                    number = Convert.ToDecimal(gridView2.GetFocusedRowCellValue("MaterialSum").ToString());
                }

                decimal total = price * number;
                total = decimal.Parse(total.ToString("0.0000"));
                gridView2.SetFocusedRowCellValue(gridMaterialMoney2, total);
                //gridView1.SetRowCellValue(e.RowHandle, gridTotal, total);

            }
        }

        //选择退料单
        private void btnSelectQuitOrder_Click(object sender, EventArgs e)
        {



            frmSelectQuitOrder frmSelectQuitOrder = new frmSelectQuitOrder();
            frmSelectQuitOrder.ShowDialog();



            if (frmSelectQuitOrder.Tag != null)
            {
                //取出选择的料件Guid
                List<SelectQuitOrderDetail> lstGuid = frmSelectQuitOrder.Tag as List<SelectQuitOrderDetail>;
                SelectQuitOrderDetail SelectQuitOrderDetail = new SelectQuitOrderDetail();

                //选择的品名填充
                if (lstGuid.Count > 0)
                {

                    //得到入库单的信息
                    for (int i = 0; i < lstGuid.Count; i++)
                    {
                        SelectQuitOrderDetail = lstGuid[i] as SelectQuitOrderDetail;

                        //填充数据
                        gridView2.AddNewRow();
                        gridView2.SetFocusedRowCellValue(gridStockInOrderGuid, SelectQuitOrderDetail.QuitOrderGuid);
                        gridView2.SetFocusedRowCellValue(gridStockInOrderID , SelectQuitOrderDetail.QuitOrderID);
                        gridView2.SetFocusedRowCellValue(gridStockInOrderDate, DateTime.Parse(SelectQuitOrderDetail.QuitOrderDate.ToString()).ToString("yyyy-MM-dd"));
                        gridView2.SetFocusedRowCellValue(gridSupplierName, SelectQuitOrderDetail.SupplierName);
                        gridView2.SetFocusedRowCellValue(gridMaterialGuID, SelectQuitOrderDetail.MaterialGuID);
                        gridView2.SetFocusedRowCellValue(gridMaterialID, SelectQuitOrderDetail.MaterialID);
                        gridView2.SetFocusedRowCellValue(gridMaterialName, SelectQuitOrderDetail.MaterialName);
                        gridView2.SetFocusedRowCellValue(gridMaterialPrice, SelectQuitOrderDetail.MaterialPrice.ToString("g0"));
                        gridView2.SetFocusedRowCellValue(gridMaterialSum, SelectQuitOrderDetail.MaterialSum.ToString("g0"));
                        gridView2.SetFocusedRowCellValue(gridMaterialMoney2, SelectQuitOrderDetail.MaterialMoney.ToString("g0"));

                        gridView2.SetFocusedRowCellValue(gridOrderFlag, "退料单");

                    }

                }

            }
        }

       
    }
}