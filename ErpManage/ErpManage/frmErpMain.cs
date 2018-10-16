using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Daniel.Liu.DAO;
using System.Data.SqlClient;
using ErpManageLibrary;
using System.Diagnostics;
using ErpManage.Business;
using ErpManage.BasicData;
using ErpManage.StatReport;
using DevExpress.XtraNavBar;

namespace ErpManage
{
    public partial class frmErpMain : frmBase
    {
        private int  intExit=1;//退出标记
      
        public frmErpMain()
        {
            InitializeComponent();
        }


        private void frmOrderMain_Load(object sender, EventArgs e)
        {
            //正在转
            this.Cursor = Cursors.WaitCursor;

            //初始化数据库连接字符串
            CommonDataConfig.ConnectionDefaultStr = System.Configuration.ConfigurationSettings.AppSettings["ConnStr"].ToString();
            string strIsDisplayMainFormJPG = System.Configuration.ConfigurationSettings.AppSettings["IsDisplayMainFormJPG"].ToString();
            if (strIsDisplayMainFormJPG.ToUpper() == "TRUE")
            {
                this.panel1.Visible = true;
            }
            else 
            {
                this.panel1.Visible = false;
            }

            //是否显示期初录入界面
            if (System.Configuration.ConfigurationSettings.AppSettings["IsDisplayInitialGoods"].ToString().ToUpper() == "TRUE")
            {
                navBarItem75.Visible = true;
            }
            else
            {
                navBarItem75.Visible = false;
            }
            
            //企业名称
            tsbCompanyName.Text = "企业名称:" + System.Configuration.ConfigurationSettings.AppSettings["CompanyName"].ToString(); ;
            tsbCompanyName.Text = tsbCompanyName.Text + "              操作员: " + SysParams.UserName;
          
            try
            {
                //检测数据库连接
                SqlConnection Conn = new SqlConnection();

                //连接字符串
                string  strconn = CommonDataConfig.ConnectionDefaultStr;

                //定义与SQLSERVER数据库存连接并打开
                Conn.ConnectionString = strconn;
                Conn.Open();
                Conn.Close();

                this.Cursor = Cursors.Arrow;
				
            }
            catch
            {
                this.Cursor = Cursors.Arrow;
                MessageBox.Show("数据库连接失败，请查看数据库服务器名、用户名、密码的正确性!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //frmSetSetupConn frmSetSetupConn = new frmSetSetupConn();
                //frmSetSetupConn.Show(this);
            }
           

          
        }

        //辅助数据
        private void navBarItem32_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "BasicDataQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }

            frmBasicDataAdd frmBasicDataAdd = new frmBasicDataAdd();
            frmBasicDataAdd.Show(this);
        }

        //物料管理
        private void navBarItem25_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //权限判断
           if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID,"MaterialQry","Qry")==false)
           {
               this.ShowMessage("对不起，你没有操作此项功能的权限！");
               return;
           }


            frmMaterial frmMaterial = new frmMaterial();
            frmMaterial.Show(this);
        }

        //员工维护
        private void navBarItem28_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "EmployeeQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }

            frmEmployee frmEmployee = new frmEmployee();
            frmEmployee.Show(this);
        }

        //客户
        private void navBarItem31_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ClientQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }

            frmClient frmClient = new frmClient();
            frmClient.Show(this);
        }

        //供应商
        private void navBarItem29_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "SupplierQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }

            frmSupplier frmSupplier = new frmSupplier();
            frmSupplier.Show(this);
        }

        //部门
        private void navBarItem27_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "DeptQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }

            frmDept frmDept = new frmDept();
            frmDept.Show(this);
        }

        //BOM维护
        private void navBarItem26_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "BomQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }

            frmBOM frmBOM = new frmBOM();
            frmBOM.Show(this);
        }

        //物料需求计划
        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "DrawPlanQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }


            frmBomMRP frmBomMRP = new frmBomMRP();
            frmBomMRP.Show(this);
        }

        //客户订单
        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ClientOrderQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }

            frmClientOrder frmClientOrder = new frmClientOrder();
            frmClientOrder.Show(this);
        }

        //修改密码
        private void navBarItem34_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ChangePassword", "Save") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }

            frmChangePassword frmcp = new frmChangePassword();
            frmcp.USERID = SysParams.UserID;
            frmcp.USERName = SysParams.UserName;
            frmcp.Show(this);
        }

       

        //操作员管理
        private void navBarItem30_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "LoginUser", "Save") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }

            frmLoginUser frmLoginUser = new frmLoginUser();
            frmLoginUser.Show(this);
        }

        /// <summary>
        /// 操作员授权
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navBarItem33_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (SysParams.UserID.Trim() != "SuperAdmin")
            {

                //权限判断
                if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "LoginUserRight", "Save") == false)
                {
                    this.ShowMessage("对不起，你没有操作此项功能的权限！");
                    return;
                }
            }

            frmRight frmRight = new frmRight();
            frmRight.Show(this);
        }

        //采购订单
        private void navBarItem13_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "StockOrderQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }

            frmStockOrder frmStockOrder = new frmStockOrder();
            frmStockOrder.Show(this);
        }

       //采购入库单
        private void navBarItem14_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "StockInQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            frmStockInOrder frmStockInOrder = new frmStockInOrder();
            frmStockInOrder.Show(this);
        }

        //系统操作日志
        private void navBarItem49_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "SysBackup", "Save") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }


            frmSystemLog frmSystemLog = new frmSystemLog();
            frmSystemLog.Show(this);
        }

        //系统备份
        private void navBarItem48_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "OperateLog", "Save") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }

            frmSystemBackup frmSystemBackup = new frmSystemBackup();
            frmSystemBackup.Show(this);
        }

        

        //生产领料计划
        private void navBarItem22_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "DrawPlanQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            frmDrawPlan frmDrawPlan = new frmDrawPlan();
            frmDrawPlan.Show(this);
        }

        //领料单
        private void navBarItem36_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "DrawOrderQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            frmDrawOrder frmDrawOrder = new frmDrawOrder();
            frmDrawOrder.Show(this);
        }

        //超领单
        private void navBarItem41_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ExcessOrderQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            frmExcessOrder frmExcessOrder = new frmExcessOrder();
            frmExcessOrder.Show(this);
        }

        //半成品入库
        private void navBarItem37_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "HalfGoodsQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            frmHalfGoods frmHalfGoods = new frmHalfGoods();
            frmHalfGoods.Show(this);
        }

        //成品入库
        private void navBarItem38_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "GoodsOrderQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            frmGoodsOrder frmGoodsOrder = new frmGoodsOrder();
            frmGoodsOrder.Show(this);
        }

        //销售出库单
        private void navBarItem39_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "SellOrderQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            frmSellOrder frmSellOrder = new frmSellOrder();
            frmSellOrder.Show(this);
        }

        //报废单
        private void navBarItem43_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        { //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "RejectOrderQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }

            frmRejectOrder frmRejectOrder = new frmRejectOrder();
            frmRejectOrder.Show(this);
        }

        //委外加工入库单
        private void navBarItem42_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ConsignQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }

            frmConsign frmConsign = new frmConsign();
            frmConsign.Show(this);
        }

        //退料单
        private void navBarItem40_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "QuitOrderQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            frmQuitOrder frmQuitOrder = new frmQuitOrder();
            frmQuitOrder.Show(this);
        }

       
        //委外出库单
        private void navBarItem44_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ConsignOutQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            frmConsignOut frmConsignOut = new frmConsignOut();
            frmConsignOut.Show(this);
        }

        //退料入库单
        private void navBarItem45_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "QuitStorageOrderQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            frmQuitStorageOrder frmQuitStorageOrder = new frmQuitStorageOrder();
            frmQuitStorageOrder.Show(this);
        }


       

        //------------------------------------报表---------------------------------

        //库存报表
        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "StockReportQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            frmStockReport frmStockReport = new frmStockReport();
            frmStockReport.Show(this);
        }


        //客户订单统计报表
        private void navBarItem1_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmClientOrderReport frmClientOrderReport = new frmClientOrderReport();
            frmClientOrderReport.Show(this);
        }

        //客户订单明细报表
        private void navBarItem17_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmClientOrderDetailReport frmClientOrderDetailReport = new frmClientOrderDetailReport();
            frmClientOrderDetailReport.Show(this);
        }

        //销售出库统计报表
        private void navBarItem8_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmSellOrderReport frmSellOrderReport = new frmSellOrderReport();
            frmSellOrderReport.Show(this);
        }

        //销售出库明细报表
        private void navBarItem9_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmSellOrderDetailReport frmSellOrderDetailReport = new frmSellOrderDetailReport();
            frmSellOrderDetailReport.Show(this);
        }

        //采购订单统计报表
        private void navBarItem19_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmStockOrderReport frmStockOrderReport = new frmStockOrderReport();
            frmStockOrderReport.Show(this);
        }

        //采购订单明细报表
        private void navBarItem20_LinkClicked(object sender, NavBarLinkEventArgs e)
        {

            frmStockOrderDetailReport frmStockOrderDetailReport = new frmStockOrderDetailReport();
            frmStockOrderDetailReport.Show(this);
        }

    
       

    
        //生产统计报表
        private void navBarItem50_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
           // frmProduceOrderReport frmProduceOrderReport = new frmProduceOrderReport();
           // frmProduceOrderReport.Show(this);
        }

     

        //采购入库统计
        private void navBarItem52_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmStockInOrderReport frmStockInOrderReport = new frmStockInOrderReport();
            frmStockInOrderReport.Show(this);
        }

        //采购入库明细统计
        private void navBarItem53_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmStockInOrderDetailReport frmStockInOrderDetailReport = new frmStockInOrderDetailReport();
            frmStockInOrderDetailReport.Show(this);
        }

        //库存明细帐
        private void navBarItem56_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "StockDetailReportQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            frmStockDetailReport frmStockDetailReport = new frmStockDetailReport();
            frmStockDetailReport.Show(this);
        }

        //---------------------------------------------------------------------------



        //注销
        private void navBarItem35_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定要注销系统?", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                try
                {
                    intExit = 2;
                    Application.Exit();

                    Process p = new Process();
                    p.StartInfo.FileName = Application.StartupPath + @"\ERPManage.exe";
                    p.StartInfo.Arguments = "/ErpManage";
                    p.Start();
                }
                catch (Exception ee)
                {
                    throw ee;
                }

            }
        }


        private void frmErpMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (intExit == 1)
            {
                DialogResult dr = MessageBox.Show("确定要退出本系统?", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    SysLog.AddOperateLog(SysParams.UserName, "系统退出", "", SysParams.UserName + "用户退出系统");

                    Application.ExitThread();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }



        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定退出本系统！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                intExit = 2;
                //写日志
                SysLog.AddOperateLog(SysParams.UserName, "系统退出", "", SysParams.UserName + "用户退出系统");

                Application.Exit();
            }


        }

        //付款单
        private void navBarItem16_LinkClicked_1(object sender, NavBarLinkEventArgs e)
        {

            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "PaymentOrderQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            frmPaymentOrder frmPaymentOrder = new frmPaymentOrder();
            frmPaymentOrder.Show(this);
        }

        //收款单
        private void navBarItem50_LinkClicked_1(object sender, NavBarLinkEventArgs e)
        {

            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "IncomeOrderQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            frmIncomeOrder frmIncomeOrder = new frmIncomeOrder();
            frmIncomeOrder.Show(this);
        }

        //其它出库单
        private void navBarItem57_LinkClicked(object sender, NavBarLinkEventArgs e)
        {

            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "OtherSellOrderQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            frmOtherSellOrder frmOtherSellOrder = new frmOtherSellOrder();
            frmOtherSellOrder.Show(this);

        }


        //--------------------------------图标客户订单-------------------------------
        private void pbxClientOrder_MouseLeave(object sender, EventArgs e)
        {
            pbxClientOrder.BorderStyle = BorderStyle.None;
            this.Cursor = Cursors.Default;
        }

        private void pbxClientOrder_MouseMove(object sender, MouseEventArgs e)
        {
            pbxClientOrder.BorderStyle = BorderStyle.FixedSingle;
            this.Cursor = Cursors.Hand;
        }

        private void pbxClientOrder_Click(object sender, EventArgs e)
        {
            navBarItem4_LinkClicked(null, null);

        }




        //-----------------------------------------------------------------------------


        //物料需求计划
        private void pbxMRPPlan_MouseLeave(object sender, EventArgs e)
        {
            pbxMRPPlan.BorderStyle = BorderStyle.None;
            this.Cursor = Cursors.Default;
        }

        private void pbxMRPPlan_MouseMove(object sender, MouseEventArgs e)
        {
            pbxMRPPlan.BorderStyle = BorderStyle.FixedSingle;
            this.Cursor = Cursors.Hand;
        }

        private void pbxMRPPlan_Click(object sender, EventArgs e)
        {
            navBarItem6_LinkClicked(null, null);
        }


        //采购订单
        private void pbxStockOrder_MouseLeave(object sender, EventArgs e)
        {
            pbxStockOrder.BorderStyle = BorderStyle.None;
            this.Cursor = Cursors.Default;
        }

        private void pbxStockOrder_MouseMove(object sender, MouseEventArgs e)
        {
            pbxStockOrder.BorderStyle = BorderStyle.FixedSingle;
            this.Cursor = Cursors.Hand;
        }

        private void pbxStockOrder_Click(object sender, EventArgs e)
        {
            navBarItem13_LinkClicked(null, null);
        }

        //采购入库单
        private void pbxStockInOrder_MouseLeave(object sender, EventArgs e)
        {
            pbxStockInOrder.BorderStyle = BorderStyle.None;
            this.Cursor = Cursors.Default;
        }

        private void pbxStockInOrder_MouseMove(object sender, MouseEventArgs e)
        {
            pbxStockInOrder.BorderStyle = BorderStyle.FixedSingle;
            this.Cursor = Cursors.Hand;
        } 

        private void pbxStockInOrder_Click(object sender, EventArgs e)
        {
            navBarItem14_LinkClicked_1(null, null);
        }

        //退料单
        private void pbxQuitOrder_MouseLeave(object sender, EventArgs e)
        {
            pbxQuitOrder.BorderStyle = BorderStyle.None;
            this.Cursor = Cursors.Default;
        }

        private void pbxQuitOrder_MouseMove(object sender, MouseEventArgs e)
        {
            pbxQuitOrder.BorderStyle = BorderStyle.FixedSingle;
            this.Cursor = Cursors.Hand;
        }

        private void pbxQuitOrder_Click(object sender, EventArgs e)
        {
            navBarItem40_LinkClicked(null, null);
        }

        //付款单
        private void pbxPaymentOrder_MouseLeave(object sender, EventArgs e)
        {
            pbxPaymentOrder.BorderStyle = BorderStyle.None;
            this.Cursor = Cursors.Default;
        }

        private void pbxPaymentOrder_MouseMove(object sender, MouseEventArgs e)
        {
            pbxPaymentOrder.BorderStyle = BorderStyle.FixedSingle;
            this.Cursor = Cursors.Hand;
        }

        private void pbxPaymentOrder_Click(object sender, EventArgs e)
        {
            navBarItem16_LinkClicked_1(null, null);
        }

        //生产领料计划
        private void pbxDrawPlan_MouseLeave(object sender, EventArgs e)
        {
            pbxDrawPlan.BorderStyle = BorderStyle.None;
            this.Cursor = Cursors.Default;
        }

        private void pbxDrawPlan_MouseMove(object sender, MouseEventArgs e)
        {
            pbxDrawPlan.BorderStyle = BorderStyle.FixedSingle;
            this.Cursor = Cursors.Hand;
        }

        private void pbxDrawPlan_Click(object sender, EventArgs e)
        {
            navBarItem22_LinkClicked(null, null);
        }

        //领料单
        private void pbxDrawOrder_MouseLeave(object sender, EventArgs e)
        {
            pbxDrawOrder.BorderStyle = BorderStyle.None;
            this.Cursor = Cursors.Default;
        }

        private void pbxDrawOrder_MouseMove(object sender, MouseEventArgs e)
        {
            pbxDrawOrder.BorderStyle = BorderStyle.FixedSingle;
            this.Cursor = Cursors.Hand;
        }

        private void pbxDrawOrder_Click(object sender, EventArgs e)
        {
            navBarItem36_LinkClicked(null, null);
        }

        //半成品入库单
        private void pbxHalfGoods_MouseLeave(object sender, EventArgs e)
        {
            pbxHalfGoods.BorderStyle = BorderStyle.None;
            this.Cursor = Cursors.Default;
        }

        private void pbxHalfGoods_MouseMove(object sender, MouseEventArgs e)
        {
            pbxHalfGoods.BorderStyle = BorderStyle.FixedSingle;
            this.Cursor = Cursors.Hand;
        }

        private void pbxHalfGoods_Click(object sender, EventArgs e)
        {
            navBarItem37_LinkClicked(null, null);
        }

        //成品入库单
        private void pbxGoodsOrder_MouseLeave(object sender, EventArgs e)
        {
            pbxGoodsOrder.BorderStyle = BorderStyle.None;
            this.Cursor = Cursors.Default;
        }

        private void pbxGoodsOrder_MouseMove(object sender, MouseEventArgs e)
        {
            pbxGoodsOrder.BorderStyle = BorderStyle.FixedSingle;
            this.Cursor = Cursors.Hand;
        }

        private void pbxGoodsOrder_Click(object sender, EventArgs e)
        {
            navBarItem38_LinkClicked(null, null);
        }

        //退料入库单
        private void pbxQuitStorageOrder_MouseLeave(object sender, EventArgs e)
        {
            pbxQuitStorageOrder.BorderStyle = BorderStyle.None;
            this.Cursor = Cursors.Default;
        }

        private void pbxQuitStorageOrder_MouseMove(object sender, MouseEventArgs e)
        {
            pbxQuitStorageOrder.BorderStyle = BorderStyle.FixedSingle;
            this.Cursor = Cursors.Hand;
        }

        private void pbxQuitStorageOrder_Click(object sender, EventArgs e)
        {
            navBarItem45_LinkClicked(null, null);
        }

        //报废单
        private void pbxRejectOrder_MouseLeave(object sender, EventArgs e)
        {
            pbxRejectOrder.BorderStyle = BorderStyle.None;
            this.Cursor = Cursors.Default;
        }

        private void pbxRejectOrder_MouseMove(object sender, MouseEventArgs e)
        {
            pbxRejectOrder.BorderStyle = BorderStyle.FixedSingle;
            this.Cursor = Cursors.Hand;
        }

        private void pbxRejectOrder_Click(object sender, EventArgs e)
        {
            navBarItem43_LinkClicked(null, null);
        }

        //销售出库单
        private void pbxSellOrder_MouseLeave(object sender, EventArgs e)
        {
            pbxSellOrder.BorderStyle = BorderStyle.None;
            this.Cursor = Cursors.Default;
        }

        private void pbxSellOrder_MouseMove(object sender, MouseEventArgs e)
        {
            pbxSellOrder.BorderStyle = BorderStyle.FixedSingle;
            this.Cursor = Cursors.Hand;
        }

        private void pbxSellOrder_Click(object sender, EventArgs e)
        {
            navBarItem39_LinkClicked(null, null);
        }
        
        //收款单
        private void pbxIncomeOrder_MouseLeave(object sender, EventArgs e)
        {
            pbxIncomeOrder.BorderStyle = BorderStyle.None;
            this.Cursor = Cursors.Default;
        }

        private void pbxIncomeOrder_MouseMove(object sender, MouseEventArgs e)
        {
            pbxIncomeOrder.BorderStyle = BorderStyle.FixedSingle;
            this.Cursor = Cursors.Hand;
        }

        private void pbxIncomeOrder_Click(object sender, EventArgs e)
        {
            navBarItem50_LinkClicked_1(null, null);
        }

        private void tsbClientOrder_Click(object sender, EventArgs e)
        {
            navBarGroup7.Expanded = true;
            //navBarItem4_LinkClicked(null, null);
        }

        private void tsbMaterialMRP_Click(object sender, EventArgs e)
        {
            navBarGroup8.Expanded = true;
            //navBarItem6_LinkClicked(null, null);
        }

        private void tsbStockOrder_Click(object sender, EventArgs e)
        {
            navBarGroup9.Expanded = true;
            //navBarItem13_LinkClicked(null, null);
        }

        private void tsbStockReport_Click(object sender, EventArgs e)
        {
            navBarGroup10.Expanded = true;
            //navBarItem7_LinkClicked(null, null);
        }

        private void tsbSellOrder_Click(object sender, EventArgs e)
        {
            navBarGroup11.Expanded = true;
            //navBarItem39_LinkClicked(null, null);
        }

        //注销
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            navBarItem35_LinkClicked(null, null);
        }

        //半成品入库统计
        private void navBarItem54_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmHalfGoodsReport frmHalfGoodsReport = new frmHalfGoodsReport();
            frmHalfGoodsReport.Show(this);
        }
        //半成品入库明细
        private void navBarItem55_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmHalfGoodsDetailReport frmHalfGoodsDetailReport = new frmHalfGoodsDetailReport();
            frmHalfGoodsDetailReport.Show(this);
        }

        //成品入库统计报表
        private void navBarItem15_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmGoodsOrderReport frmGoodsOrderReport = new frmGoodsOrderReport();
            frmGoodsOrderReport.Show(this);
        }

        //成品入库明细报表
        private void navBarItem24_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmGoodsOrderDetailReport frmGoodsOrderDetailReport = new frmGoodsOrderDetailReport();
            frmGoodsOrderDetailReport.Show(this);
        }

        //领料单明细报表
        private void navBarItem59_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmDrawOrderDetailReport frmDrawOrderDetailReport = new frmDrawOrderDetailReport();
            frmDrawOrderDetailReport.Show(this);
        }
        //领料单统计
        private void navBarItem46_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmDrawOrderReport frmDrawOrderReport = new frmDrawOrderReport();
            frmDrawOrderReport.Show(this);
        }

        //超领单明细
        private void navBarItem60_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmExcessOrderDetailReport frmExcessOrderDetailReport = new frmExcessOrderDetailReport();
            frmExcessOrderDetailReport.Show(this);
        }

        //超领单统计报表
        private void navBarItem18_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmExcessOrderReport frmExcessOrderReport = new frmExcessOrderReport();
            frmExcessOrderReport.Show(this);
        }

        //退料统计报表
        private void navBarItem51_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmQuitOrderReport frmQuitOrderReport = new frmQuitOrderReport();
            frmQuitOrderReport.Show(this);
        }

        //退料单明细报表
        private void navBarItem61_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmQuitOrderDetailReport frmQuitOrderDetailReport = new frmQuitOrderDetailReport();
            frmQuitOrderDetailReport.Show(this);
        }

        //委外入统计
        private void navBarItem62_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmConsignReport frmConsignReport = new frmConsignReport();
            frmConsignReport.Show(this);

        }

        //委外入明细
        private void navBarItem63_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmConsignDetailReport frmConsignDetailReport = new frmConsignDetailReport();
            frmConsignDetailReport.Show(this);
        }

        //委外出统计
        private void navBarItem64_LinkClicked(object sender, NavBarLinkEventArgs e)
        {

            frmConsignOutReport frmConsignOutReport = new frmConsignOutReport();
            frmConsignOutReport.Show(this);
        }

        //委外出明细
        private void navBarItem65_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmConsignOutDetailReport frmConsignOutDetailReport = new frmConsignOutDetailReport();
            frmConsignOutDetailReport.Show(this);
        }

        //退料入库统计报表
        private void navBarItem66_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmQuitStorageOrderReport frmQuitStorageOrderReport = new frmQuitStorageOrderReport();
            frmQuitStorageOrderReport.Show(this);
        }

        //退料入库明细报表
        private void navBarItem67_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmQuitStorageOrderDetailReport frmQuitStorageOrderDetailReport = new frmQuitStorageOrderDetailReport();
            frmQuitStorageOrderDetailReport.Show(this);
        }

        //其它出库单统计报表
        private void navBarItem68_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmOtherSellOrderReport frmOtherSellOrderReport = new frmOtherSellOrderReport();
            frmOtherSellOrderReport.Show(this);
        }

        //其它出库单明细报表
        private void navBarItem69_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmOtherSellOrderDetailReport frmOtherSellOrderDetailReport = new frmOtherSellOrderDetailReport();
            frmOtherSellOrderDetailReport.Show(this);
        }

        //报废单统计报表
        private void navBarItem70_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmRejectOrderReport frmRejectOrderReport = new frmRejectOrderReport();
            frmRejectOrderReport.Show(this);
        }

        //报废单明细报表
        private void navBarItem71_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmRejectOrderDetailReport frmRejectOrderDetailReport = new frmRejectOrderDetailReport();
            frmRejectOrderDetailReport.Show(this);
        }

        //采购订单执行情况
        private void navBarItem72_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "StockOrderStatusReportQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            frmSelectStockOrderReport frmSelectStockOrderReport = new frmSelectStockOrderReport();
            frmSelectStockOrderReport.Show(this);
        }

        //客户订单执行情况
        private void navBarItem73_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ClientOrderStatusReportQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            frmSelectClientOrderReport frmSelectClientOrderReport = new frmSelectClientOrderReport();
            frmSelectClientOrderReport.Show(this);
        }

        //调拨单
        private void navBarItem74_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "RemoveBillQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            frmRemoveBill frmRemoveBill = new frmRemoveBill();
            frmRemoveBill.Show(this);
        }

        //期初入库单
        private void navBarItem75_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "InitialGoodsQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            frmInitialGoods frmInitialGoods = new frmInitialGoods();
            frmInitialGoods.Show(this);
        }

        //采购付款单统计报表
        private void navBarItem76_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "PaymentOrderReportQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            frmPaymentOrderReport frmPaymentOrderReport = new frmPaymentOrderReport();
            frmPaymentOrderReport.Show(this);
        }

        //采购入库单已开票报表
        private void navBarItem78_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "StockOrderInvoiceReportQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            frmStockInOrderStatus frmStockInOrderStatus = new frmStockInOrderStatus();
            frmStockInOrderStatus.Show(this);
        }

        /// <summary>
        /// 收发存汇总表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navBarItem77_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
             //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "InOutStorageReportQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            frmDepotMaterialInOutSum frmDepotMaterialInOutSum = new frmDepotMaterialInOutSum();
            frmDepotMaterialInOutSum.Show(this);
            
        }

        //修改物料编号
        private void navBarItem79_LinkClicked(object sender, NavBarLinkEventArgs e)
        {

              //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ChangeMaterialIDQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            frmChangeMaterialID frmChangeMaterialID = new frmChangeMaterialID();
            frmChangeMaterialID.Show(this);
            
        }

        //在制品报表
        private void navBarItem80_LinkClicked(object sender, NavBarLinkEventArgs e)
        {

            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ProcessProductQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            frmProcessReport frmProcessReport = new frmProcessReport();
            frmProcessReport.Show(this);
        }

        //其它入库单
        private void navBarItem81_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "OtherInOrderQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            frmOtherInOrder frmOtherInOrder = new frmOtherInOrder();
            frmOtherInOrder.Show(this);
        }

        //库存预警报表
        private void navBarItem82_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "StockYJReportQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            frmStockYJReport frmStockYJReport = new frmStockYJReport();
            frmStockYJReport.Show(this);
        }


        //文件管理
        private void navFileManage_LinkClicked(object sender, NavBarLinkEventArgs e)
        {

            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "FileManage", "Save") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }



            frmFileManage frmFileManage = new frmFileManage();
            frmFileManage.Show(this);
        }

        //文件申请
        private void navFileApply_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
           // this.ShowMessage("此功能正在开发建设中......");
         //   return;


            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "FileApplyQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }


            frmFileApply frmFileApply = new frmFileApply();
            frmFileApply.Show(this);
        }

        //文件查看
        private void navFileView_LinkClicked(object sender, NavBarLinkEventArgs e)
        {


            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "FileView", "Save") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }

            frmFileView frmFileView = new frmFileView();
            frmFileView.Show(this);
        }

        //文件入库
        private void navFileInStorage_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
           // this.ShowMessage("此功能正在开发建设中......");
           // return;


            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "FileInStorageQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }

            frmFileInStorage frmFileInStorage = new frmFileInStorage();
            frmFileInStorage.Show(this);
        }

        //一览表报表
        private void navBarItem83_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            //this.ShowMessage("此功能正在开发建设中......");
            //return;
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "fjzlylb", "fjzlylb") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }

            frmFileDetailReport frmFileDetailReport = new frmFileDetailReport();
            frmFileDetailReport.Show(this);
        }

        //发放报表
        private void navBarItem84_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            //this.ShowMessage("此功能正在开发建设中......");
           // return;

            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "fjfftjb", "fjfftjb") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            frmFileFFCountReport frmFileFFCountReport = new frmFileFFCountReport();
            frmFileFFCountReport.Show(this);
        }

        //申请报表
        private void navBarItem85_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "fjsqtjb", "fjsqtjb") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }

           // this.ShowMessage("此功能正在开发建设中......");
           // return;


            frmFileApplyCountReport frmFileApplyCountReport = new frmFileApplyCountReport();
            frmFileApplyCountReport.Show(this);
        }

        //工程更改单
        private void navChangeBill_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
           // this.ShowMessage("此功能正在开发建设中......");
           // return;


            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ChangeBillQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }


            frmChangeBill frmChangeBill = new frmChangeBill();
            frmChangeBill.Show(this);
            
        }

        /// <summary>
        /// 设备基础资料维护
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navBarItem83_LinkClicked_1(object sender, NavBarLinkEventArgs e)
        {
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "EquipmentQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }


            frmEquipment frmEquipment = new frmEquipment();
            frmEquipment.Show(this);
        }

        private void navBarItem84_LinkClicked_1(object sender, NavBarLinkEventArgs e)
        {
            this.ShowMessage("此模块功能正在建设中...");
        }

        private void navBarItem85_LinkClicked_1(object sender, NavBarLinkEventArgs e)
        {
            this.ShowMessage("此模块功能正在建设中...");
        }

        private void navBarItem86_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            this.ShowMessage("此模块功能正在建设中...");
        }

        private void navBarItem87_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            this.ShowMessage("此模块功能正在建设中...");
        }

        private void navBarItem88_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            this.ShowMessage("此模块功能正在建设中...");
        }

        private void navBarItem89_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            this.ShowMessage("此模块功能正在建设中...");
        }

        private void navBarItem90_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "EquipmentGageReportQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }


           // this.ShowMessage("此模块功能正在建设中...");
            frmEquipmentGageReport frmEquipmentGageReport = new frmEquipmentGageReport();
            frmEquipmentGageReport.Show(this);
        }

        private void navBarItem91_LinkClicked(object sender, NavBarLinkEventArgs e)
        {

            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "EquipmentDieReportQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            //this.ShowMessage("此模块功能正在建设中...");

            frmEquipmentDieReport frmEquipmentDieReport = new frmEquipmentDieReport();
            frmEquipmentDieReport.Show(this);
        }

        private void navBarItem92_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "EquipmentInformationReportQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            
            //this.ShowMessage("此模块功能正在建设中...");
            frmEquipmentInformationReport frmEquipmentInformationReport = new frmEquipmentInformationReport();
            frmEquipmentInformationReport.Show(this);
        }

        private void navBarItem93_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "EquipmentOfficeReportQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            
            
            //this.ShowMessage("此模块功能正在建设中...");
            frmEquipmentOfficeReport frmEquipmentOfficeReport = new frmEquipmentOfficeReport();
            frmEquipmentOfficeReport.Show(this);
        }

        private void navBarItem94_LinkClicked(object sender, NavBarLinkEventArgs e)
        {

            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "EquipmentFrockReportQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            

            frmEquipmentFrockReport frmEquipmentFrockReport = new frmEquipmentFrockReport();
            frmEquipmentFrockReport.Show(this);
        }


        //其它入库单统计报表
        private void navBarItem95_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "OtherInOrderReportQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            

            frmOtherInOrderReport frmOtherInOrderReport = new frmOtherInOrderReport();
            frmOtherInOrderReport.Show(this);
        }

        //其它入库单明细报表
        private void navBarItem96_LinkClicked(object sender, NavBarLinkEventArgs e)
        {

            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "OtherInOrderReportQry", "Qry") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }
            frmOtherInOrderDetailReport frmOtherInOrderDetailReport = new frmOtherInOrderDetailReport();
            frmOtherInOrderDetailReport.Show(this);
        }

        //
        private void tsbVer_Click(object sender, EventArgs e)
        {
            navBarGroup1.Expanded = true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            navBarGroup2.Expanded=true;
        }      

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            navBarGroup3.Expanded = true;
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            navBarGroup3.Expanded = true;
        }

        private void btnStockOrder_Click(object sender, EventArgs e)
        {
            navBarItem13_LinkClicked(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            navBarItem38_LinkClicked(null, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            navBarItem37_LinkClicked(null, null);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            navBarItem81_LinkClicked(null, null);
        }

        private void button69_Click(object sender, EventArgs e)
        {
            navBarItem42_LinkClicked(null, null);
        }

        private void button62_Click(object sender, EventArgs e)
        {
            navBarItem14_LinkClicked_1(null, null);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            navBarItem7_LinkClicked(null, null);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            navBarItem40_LinkClicked(null, null);
        }

        private void button90_Click(object sender, EventArgs e)
        {
            navBarItem74_LinkClicked(null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            navBarItem4_LinkClicked(null, null);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            navBarItem36_LinkClicked(null, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            navBarItem41_LinkClicked(null, null);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            navBarItem57_LinkClicked(null, null);
        }

        private void button70_Click(object sender, EventArgs e)
        {
            navBarItem44_LinkClicked(null, null);
        }

    }
}