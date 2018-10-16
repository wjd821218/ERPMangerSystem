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
    /// </summary>
    public partial class frmIncomeOrderAdd : frmBase
    {
        IncomeOrderManage IncomeOrderManage = new IncomeOrderManage();
        DataSet ds = new DataSet();
        public frmIncomeOrderAdd()
        {
            InitializeComponent();
        }
        //权限判断
        public void SetRight()
        {

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "IncomeOrderSave", "Save") == false)
            {
                btnAdd.Enabled = false;
                tsbSave.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "IncomeOrderCheck", "Check") == false)
            {
                tsbCheck.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "IncomeOrderUnCheck", "UnCheck") == false)
            {
                tsbUnCheck.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "IncomeOrderPrint", "Print") == false)
            {
                tsbPrint.Enabled = false;
            }
        }



        //新增
        public void AddBill()
        {
            txtIncomeOrderID.Text = GetAutoId("IncomeOrder");
            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            txtIncomeOrderGuid.Text = Guid.NewGuid().ToString();

            gridControl1.DataSource = IniBindTable1();

            gridControl2.DataSource = IniBindTable2();
            tsbSave.Enabled = true;
            tsbCheck.Enabled = false;
            tsbUnCheck.Enabled = false;
         
            SetRight();
            this.ShowDialog();

        }

         //编辑
        public void EditBill(string IncomeOrderGuid)
        {
            txtIncomeOrderGuid.Text = IncomeOrderGuid;

            DataTable dtl = IncomeOrderManage.GetIncomeOrderBySQL(" where IncomeOrderGuid='" + IncomeOrderGuid + "'");

            txtIncomeOrderID.Text = dtl.Rows[0]["IncomeOrderID"].ToString();
            dtpIncomeOrderDate.Text = DateTime.Parse(dtl.Rows[0]["IncomeOrderDate"].ToString()).ToString("yyyy-MM-dd");
            txtClient.Text = dtl.Rows[0]["ClientName"].ToString();
            txtClient.Tag = dtl.Rows[0]["ClientGuid"].ToString();

            txtIncomePerson.Tag = dtl.Rows[0]["IncomePerson"].ToString();
            txtIncomePerson.Text = dtl.Rows[0]["IncomePersonName"].ToString();
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
            dtl2 = IncomeOrderManage.GetIncomeOrderDetail1ByGuid(IncomeOrderGuid);
            gridControl1.DataSource = dtl2;
           

            //加载明细2
            DataTable dtl3 = new DataTable();
            dtl3 = IncomeOrderManage.GetIncomeOrderDetail2ByGuid(IncomeOrderGuid);
            gridControl2.DataSource = dtl3;


            //用于打印
            ds.Tables.Clear();
            ds.Tables.Add(dtl2.Copy());
            ds.Tables[0].TableName = "IncomeOrderDetail1";
            ds.Tables.Add(dtl3.Copy());
            ds.Tables[1].TableName = "IncomeOrderDetail2";



            SetRight();
            this.ShowDialog();
        }


        //初始经表格
        private DataTable IniBindTable1()
        {
            DataTable _dt = new DataTable();
            DataColumn _datacol1 = new DataColumn("IncomeName");
            DataColumn _datacol2 = new DataColumn("IncomeMoney");
            DataColumn _datacol3 = new DataColumn("CNYName");
            DataColumn _datacol4 = new DataColumn("IncomeTypeName");
            DataColumn _datacol5 = new DataColumn("Remark");
            DataColumn _datacol6 = new DataColumn("IncomeID");
            DataColumn _datacol7 = new DataColumn("CNY");
            DataColumn _datacol8 = new DataColumn("IncomeType");
        

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
            DataColumn _datacol1 = new DataColumn("SellOrderID");
            DataColumn _datacol2 = new DataColumn("SellOrderDate");
            DataColumn _datacol3 = new DataColumn("SellOrderMoney");
            DataColumn _datacol4 = new DataColumn("Remark");

            _dt.Columns.Add(_datacol1);
            _dt.Columns.Add(_datacol2);
            _dt.Columns.Add(_datacol3);
            _dt.Columns.Add(_datacol4);
        
            return _dt;
        }





        private void tsbSave_Click(object sender, EventArgs e)
        {
            txtRemark.Focus();
            gridView1.UpdateCurrentRow();

            if (txtClient.Text.Trim() == "")
            {
                this.ShowAlertMessage("必须输入客户!");
                return;
            }

            if (dtpIncomeOrderDate.Text == "")
            {
                this.ShowAlertMessage("必须输入下单日期!");
                return;
            }

            if (gridView1.RowCount <= 0)
            {
                this.ShowAlertMessage("必须增加收款明细数据!");
                return;
            }

            //if (bm.IsExistBillID(txtBillID.Text) == true && this.Tag.ToString() == "add")
            //{
            //    this.ShowAlertMessage("订单号已经存在，请重新输入!");
            //    return;
            //}


            IncomeOrder IncomeOrder = new IncomeOrder();
            IncomeOrder.IncomeOrderGuid = txtIncomeOrderGuid.Text;
            IncomeOrder.IncomeOrderID = txtIncomeOrderID.Text;
            IncomeOrder.IncomeOrderDate = DateTime.Parse(dtpIncomeOrderDate.Text);
            if (txtClient.Tag != null)
            {
                IncomeOrder.ClientGuid = txtClient.Tag.ToString();
            }
            if (txtIncomePerson.Tag != null)
            {
                IncomeOrder.IncomePerson = txtIncomePerson.Tag.ToString();
            }
            IncomeOrder.Remark = txtRemark.Text;

            IncomeOrder.CreateGuid = txtCreateGuid.Tag.ToString();
            IncomeOrder.CreateDate = DateTime.Now;
            IncomeOrder.CheckGuid = "";
            IncomeOrder.CheckDate = DateTime.Parse("1900-01-01");
      

            List<IncomeOrderDetail1> list1 = new List<IncomeOrderDetail1>();
            IncomeOrderDetail1 IncomeOrderDetail1 = new IncomeOrderDetail1();
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRowView dr = (DataRowView)(gridView1.GetRow(i));

                IncomeOrderDetail1 = new IncomeOrderDetail1();
                IncomeOrderDetail1.IncomeOrderGuid = IncomeOrder.IncomeOrderGuid;
                IncomeOrderDetail1.IncomeID = dr["IncomeID"].ToString();
                if (dr["IncomeMoney"].ToString().Trim() != "")
                {
                    IncomeOrderDetail1.IncomeMoney = decimal.Parse(dr["IncomeMoney"].ToString());
                }
                else
                {
                    IncomeOrderDetail1.IncomeMoney = 0;
                }
                IncomeOrderDetail1.CNY = dr["CNY"].ToString();
                IncomeOrderDetail1.IncomeType = dr["IncomeType"].ToString();  
                IncomeOrderDetail1.Remark = dr["Remark"].ToString(); //gridView1.GetRowCellValue(i, gridProductGuid).ToString();
                list1.Add(IncomeOrderDetail1);

            }


            List<IncomeOrderDetail2> list2 = new List<IncomeOrderDetail2>();
            IncomeOrderDetail2 IncomeOrderDetail2 = new IncomeOrderDetail2();
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                DataRowView dr = (DataRowView)(gridView2.GetRow(i));

                IncomeOrderDetail2 = new IncomeOrderDetail2();
                IncomeOrderDetail2.IncomeOrderGuid = IncomeOrder.IncomeOrderGuid;
                IncomeOrderDetail2.SellOrderID = dr["SellOrderID"].ToString();
                IncomeOrderDetail2.SellOrderDate =DateTime.Parse( dr["SellOrderDate"].ToString());
                if (dr["SellOrderMoney"].ToString().Trim() != "")
                {
                    IncomeOrderDetail2.SellOrderMoney = decimal.Parse(dr["SellOrderMoney"].ToString());
                }
                else
                {
                    IncomeOrderDetail2.SellOrderMoney = 0;
                }
                IncomeOrderDetail2.Remark = dr["Remark"].ToString(); //gridView1.GetRowCellValue(i, gridProductGuid).ToString();
                list2.Add(IncomeOrderDetail2);

            }




            //保存
            IncomeOrderManage.SaveBill(IncomeOrder, list1,list2);

            tsbCheck.Enabled = true;
            tsbUnCheck.Enabled = false;

            SetRight();

            //写日志
            SysLog.AddOperateLog(SysParams.UserName, "收款单保存", "保存", SysParams.UserName + "用户保存收款单,唯一号:" + txtIncomeOrderGuid.Text + ",收款单号:" + txtIncomeOrderID.Text);


            //用于打印
            ds.Tables.Clear();
            DataTable dtl2 = base.GetDataTable((DataView)gridView1.DataSource);
            DataTable dtl3 = base.GetDataTable((DataView)gridView2.DataSource);
            ds.Tables.Add(dtl2.Copy());
          
            ds.Tables[0].TableName = "IncomeOrderDetail1";
            ds.Tables.Add(dtl3.Copy());
         
            ds.Tables[1].TableName = "IncomeOrderDetail2";

            this.Tag = "edit";
            this.ShowMessage("保存成功");

            frmIncomeOrder.frmincomeorder.LoadData();
        }



        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectClient_Click(object sender, EventArgs e)
        {

            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(4);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtClient.Text = ""; //名称
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

        private void btnSelectIncomePerson_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(1);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtIncomePerson.Text = ""; //名称
                    txtIncomePerson.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtIncomePerson.Text = arrValue[1]; //名称
                        txtIncomePerson.Tag = arrValue[0];  //Guid
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
                    gridView1.SetFocusedRowCellValue(gridIncomeID, ""); //名称
                    gridView1.SetFocusedRowCellValue(gridIncomeID2, "");  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');


                    if (arrValue.Length > 0)
                    {
                        gridView1.SetFocusedRowCellValue(gridIncomeID, arrValue[1]); //名称
                        gridView1.SetFocusedRowCellValue(gridIncomeID2, arrValue[0]);   //Guid
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
                    gridView1.SetFocusedRowCellValue(gridIncomeType, ""); //名称
                    gridView1.SetFocusedRowCellValue(gridIncomeType2, "");  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');


                    if (arrValue.Length > 0)
                    {
                        gridView1.SetFocusedRowCellValue(gridIncomeType, arrValue[1]); //名称
                        gridView1.SetFocusedRowCellValue(gridIncomeType2, arrValue[0]);   //Guid
                    }
                }
            }
        }

        private void tsbCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定审核该收款单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                IncomeOrderManage.CheckBill(txtIncomeOrderGuid.Text, 1);

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
                SysLog.AddOperateLog(SysParams.UserName, "收款单审核", "审核", SysParams.UserName + "用户审核收款单,唯一号:" + txtIncomeOrderGuid.Text + ",收款单号:" + txtIncomeOrderID.Text);

                frmIncomeOrder.frmincomeorder.LoadData();
            }
        }

        private void tsbUnCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定反审该收款单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                IncomeOrderManage.CheckBill(txtIncomeOrderGuid.Text, 0);

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
                SysLog.AddOperateLog(SysParams.UserName, "收款单反审", "反审", SysParams.UserName + "用户反审收款单,唯一号:" + txtIncomeOrderGuid.Text + ",收款单号:" + txtIncomeOrderID.Text);

                frmIncomeOrder.frmincomeorder.LoadData();
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

            XtraReportIncomeOrder XtraReportIncomeOrder = new XtraReportIncomeOrder(ds,txtIncomeOrderID.Text,dtpIncomeOrderDate.Text,txtClient.Text,txtIncomePerson.Text,
                                    txtRemark.Text, txtCreateGuid.Text, txtCreateDate.Text, txtCheckGuid.Text, txtCheckDate.Text);
            XtraReportIncomeOrder.ShowPreview();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            txtIncomeOrderID.Text = GetAutoId("IncomeOrder");
            txtIncomeOrderGuid.Text  = Guid.NewGuid().ToString();

            dtpIncomeOrderDate.Text = "";
            txtIncomePerson.Text = "";
            txtIncomePerson.Tag = "";
            txtClient.Text = "";
            txtClient.Tag = "";
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

            gridControl1.DataSource = IniBindTable1();

            gridControl2.DataSource = IniBindTable2();

            ds.Tables.Clear();
        }
    }
}