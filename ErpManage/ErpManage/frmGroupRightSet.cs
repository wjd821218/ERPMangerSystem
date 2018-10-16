using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Web.UI.WebControls;
using ErpManageLibrary;

namespace ErpManage
{
    /// <summary>
    /// 组功能权限设定
    /// </summary>
    public partial class frmGroupRightSet :frmBase
    {
        public frmGroupRightSet()
        {
            InitializeComponent();
        }

        private void tsBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// 加载权限组
        /// </summary>
        private void LoadRightGroup()
        {
            RightGroupManage RightGroupManage = new RightGroupManage();
            DataTable dtl = RightGroupManage.GetRightGroupInfo();

            ListItem listitem = new ListItem();
            chklstGroup.Items.Clear();

            for (int i = 0; i < dtl.Rows.Count; i++)
            {
                listitem = new ListItem();
                listitem.Text = dtl.Rows[i]["GroupName"].ToString();
                listitem.Value = dtl.Rows[i]["GroupGuid"].ToString();
                chklstGroup.Items.Add(listitem);

            }

        }

        /// <summary>
        /// 加载组的功能权限
        /// </summary>
        private void loadGroupFunctionRight(string groupid)
        {
            RightGroupManage RightGroupManage = new RightGroupManage();
            DataTable dtl = RightGroupManage.GetGroupRightSet(groupid);

            string strValue="";
            string strModuleValue = "";
            //载入模块权限
            for (int i = 0; i < dtl.Rows.Count; i++)
            {
               strValue=dtl.Rows[i]["FunctionRight"].ToString().Trim();
               strModuleValue = dtl.Rows[i]["ModuleID"].ToString().Trim();
               switch (strModuleValue)
               {
                    #region 客户订单
                   case "ClientOrderSave":
                        if (strValue == "1")
                        {
                            chkClientOrderSave.Checked = true;
                        }
                        else
                        {
                            chkClientOrderSave.Checked = false;
                        }
                        break;
                    case "ClientOrderDelete":
                        if (strValue == "1")
                        {
                            chkClientOrderDelete.Checked = true;
                        }
                        else
                        {
                            chkClientOrderDelete.Checked = false;
                        }
                        break;
                    case "ClientOrderQry":
                        if (strValue == "1")
                        {
                            chkClientOrderQry.Checked = true;
                        }
                        else
                        {
                            chkClientOrderQry.Checked = false;
                        }
                        break;
                    case "ClientOrderCheck":
                        if (strValue == "1")
                        {
                            chkClientOrderCheck.Checked = true;
                        }
                        else
                        {
                            chkClientOrderCheck.Checked = false;
                        }
                        break;
                    case "ClientOrderUnCheck":
                        if (strValue == "1")
                        {
                            chkClientOrderUnCheck.Checked = true;
                        }
                        else
                        {
                            chkClientOrderUnCheck.Checked = false;
                        }
                        break;
                    case "ClientOrderCheck2":
                        if (strValue == "1")
                        {
                            chkClientOrderCheck2.Checked = true;
                        }
                        else
                        {
                            chkClientOrderCheck2.Checked = false;
                        }
                        break;
                    case "ClientOrderUnCheck2":
                        if (strValue == "1")
                        {
                            chkClientOrderUnCheck2.Checked = true;
                        }
                        else
                        {
                            chkClientOrderUnCheck2.Checked = false;
                        }
                        break;
                    case "ClientOrderEnd":
                        if (strValue == "1")
                        {
                            chkClientOrderEnd.Checked = true;
                        }
                        else
                        {
                            chkClientOrderEnd.Checked = false;
                        }
                        break;
                    case "ClientOrderPrint":
                        if (strValue == "1")
                        {
                            chkClientOrderPrint.Checked = true;
                        }
                        else
                        {
                            chkClientOrderPrint.Checked = false;
                        }
                        break;

                   #endregion

                    #region 物料需求计划
                    case "StockPlanSave":
                        if (strValue == "1")
                        {
                            chkStockPlanSave.Checked = true;
                        }
                        else
                        {
                            chkStockPlanSave.Checked = false;
                        }
                        break;
                    case "StockPlanDelete":
                        if (strValue == "1")
                        {
                            chkStockPlanDelete.Checked = true;
                        }
                        else
                        {
                            chkClientOrderDelete.Checked = false;
                        }
                        break;
                    case "StockPlanQry":
                        if (strValue == "1")
                        {
                            chkStockPlanQry.Checked = true;
                        }
                        else
                        {
                            chkStockPlanQry.Checked = false;
                        }
                        break;
                

                    #endregion

                    #region 采购订单
                    case "StockOrderSave":
                        if (strValue == "1")
                        {
                            chkStockOrderSave.Checked = true;
                        }
                        else
                        {
                            chkStockOrderSave.Checked = false;
                        }
                        break;
                    case "StockOrderDelete":
                        if (strValue == "1")
                        {
                            chkStockOrderDelete.Checked = true;
                        }
                        else
                        {
                            chkStockOrderDelete.Checked = false;
                        }
                        break;
                    case "StockOrderQry":
                        if (strValue == "1")
                        {
                            chkStockOrderQry.Checked = true;
                        }
                        else
                        {
                            chkStockOrderQry.Checked = false;
                        }
                        break;
                    case "StockOrderCheck":
                        if (strValue == "1")
                        {
                            chkStockOrderCheck.Checked = true;
                        }
                        else
                        {
                            chkStockOrderCheck.Checked = false;
                        }
                        break;
                    case "StockOrderUnCheck":
                        if (strValue == "1")
                        {
                            chkStockOrderUnCheck.Checked = true;
                        }
                        else
                        {
                            chkStockOrderUnCheck.Checked = false;
                        }
                        break;

                    case "StockOrderEnd":
                        if (strValue == "1")
                        {
                            chkStockOrderEnd.Checked = true;
                        }
                        else
                        {
                            chkStockOrderEnd.Checked = false;
                        }
                        break;
                    case "StockOrderPrint":
                        if (strValue == "1")
                        {
                            chkStockOrderPrint.Checked = true;
                        }
                        else
                        {
                            chkStockOrderPrint.Checked = false;
                        }
                        break;

                    #endregion

                    #region 采购入库单
                    case "StockInSave":
                        if (strValue == "1")
                        {
                            chkStockInSave.Checked = true;
                        }
                        else
                        {
                            chkStockInSave.Checked = false;
                        }
                        break;
                    case "StockInDelete":
                        if (strValue == "1")
                        {
                            chkStockInDelete.Checked = true;
                        }
                        else
                        {
                            chkStockInDelete.Checked = false;
                        }
                        break;
                    case "StockInQry":
                        if (strValue == "1")
                        {
                            chkStockInQry.Checked = true;
                        }
                        else
                        {
                            chkStockInQry.Checked = false;
                        }
                        break;
                    case "StockInCheck":
                        if (strValue == "1")
                        {
                            chkStockInCheck.Checked = true;
                        }
                        else
                        {
                            chkStockInCheck.Checked = false;
                        }
                        break;
                    case "StockInUnCheck":
                        if (strValue == "1")
                        {
                            chkStockInUnCheck.Checked = true;
                        }
                        else
                        {
                            chkStockInUnCheck.Checked = false;
                        }
                        break;
                    case "StockInPrint":
                        if (strValue == "1")
                        {
                            chkStockInPrint.Checked = true;
                        }
                        else
                        {
                            chkStockInPrint.Checked = false;
                        }
                        break;

                    #endregion

                    #region 生产领料计划
                    case "DrawPlanSave":
                        if (strValue == "1")
                        {
                            chkDrawPlanSave.Checked = true;
                        }
                        else
                        {
                            chkDrawPlanSave.Checked = false;
                        }
                        break;
                    case "DrawPlanDelete":
                        if (strValue == "1")
                        {
                            chkDrawPlanDelete.Checked = true;
                        }
                        else
                        {
                            chkDrawPlanDelete.Checked = false;
                        }
                        break;
                    case "DrawPlanQry":
                        if (strValue == "1")
                        {
                            chkDrawPlanQry.Checked = true;
                        }
                        else
                        {
                            chkDrawPlanQry.Checked = false;
                        }
                        break;
                 

                    #endregion

                    #region 领料单
                    case "DrawOrderSave":
                        if (strValue == "1")
                        {
                            chkDrawOrderSave.Checked = true;
                        }
                        else
                        {
                            chkDrawOrderSave.Checked = false;
                        }
                        break;
                    case "DrawOrderDelete":
                        if (strValue == "1")
                        {
                            chkDrawOrderDelete.Checked = true;
                        }
                        else
                        {
                            chkDrawOrderDelete.Checked = false;
                        }
                        break;
                    case "DrawOrderQry":
                        if (strValue == "1")
                        {
                            chkDrawOrderQry.Checked = true;
                        }
                        else
                        {
                            chkDrawOrderQry.Checked = false;
                        }
                        break;
                    case "DrawOrderCheck":
                        if (strValue == "1")
                        {
                            chkDrawOrderCheck.Checked = true;
                        }
                        else
                        {
                            chkDrawOrderCheck.Checked = false;
                        }
                        break;
                    case "DrawOrderUnCheck":
                        if (strValue == "1")
                        {
                            chkDrawOrderUnCheck.Checked = true;
                        }
                        else
                        {
                            chkDrawOrderUnCheck.Checked = false;
                        }
                        break;
                    case "DrawOrderPrint":
                        if (strValue == "1")
                        {
                            chkDrawOrderPrint.Checked = true;
                        }
                        else
                        {
                            chkDrawOrderPrint.Checked = false;
                        }
                        break;

                    #endregion

                    #region 半成品入库单
                    case "HalfGoodsSave":
                        if (strValue == "1")
                        {
                            chkHalfGoodsSave.Checked = true;
                        }
                        else
                        {
                            chkHalfGoodsSave.Checked = false;
                        }
                        break;
                    case "HalfGoodsDelete":
                        if (strValue == "1")
                        {
                            chkHalfGoodsDelete.Checked = true;
                        }
                        else
                        {
                            chkHalfGoodsDelete.Checked = false;
                        }
                        break;
                    case "HalfGoodsQry":
                        if (strValue == "1")
                        {
                            chkHalfGoodsQry.Checked = true;
                        }
                        else
                        {
                            chkHalfGoodsQry.Checked = false;
                        }
                        break;
                    case "HalfGoodsCheck":
                        if (strValue == "1")
                        {
                            chkHalfGoodsCheck.Checked = true;
                        }
                        else
                        {
                            chkHalfGoodsCheck.Checked = false;
                        }
                        break;
                    case "HalfGoodsUnCheck":
                        if (strValue == "1")
                        {
                            chkHalfGoodsUnCheck.Checked = true;
                        }
                        else
                        {
                            chkHalfGoodsUnCheck.Checked = false;
                        }
                        break;
                
                    case "HalfGoodsPrint":
                        if (strValue == "1")
                        {
                            chkHalfGoodsPrint.Checked = true;
                        }
                        else
                        {
                            chkHalfGoodsPrint.Checked = false;
                        }
                        break;

                    #endregion

                    #region 成品入库单
                    case "GoodsOrderSave":
                        if (strValue == "1")
                        {
                            chkGoodsOrderSave.Checked = true;
                        }
                        else
                        {
                            chkGoodsOrderSave.Checked = false;
                        }
                        break;
                    case "GoodsOrderDelete":
                        if (strValue == "1")
                        {
                            chkGoodsOrderDelete.Checked = true;
                        }
                        else
                        {
                            chkGoodsOrderDelete.Checked = false;
                        }
                        break;
                    case "GoodsOrderQry":
                        if (strValue == "1")
                        {
                            chkGoodsOrderQry.Checked = true;
                        }
                        else
                        {
                            chkGoodsOrderQry.Checked = false;
                        }
                        break;
                    case "GoodsOrderCheck":
                        if (strValue == "1")
                        {
                            chkGoodsOrderCheck.Checked = true;
                        }
                        else
                        {
                            chkGoodsOrderCheck.Checked = false;
                        }
                        break;
                    case "GoodsOrderUnCheck":
                        if (strValue == "1")
                        {
                            chkGoodsOrderUnCheck.Checked = true;
                        }
                        else
                        {
                            chkGoodsOrderUnCheck.Checked = false;
                        }
                        break;
                
                    case "GoodsOrderPrint":
                        if (strValue == "1")
                        {
                            chkGoodsOrderPrint.Checked = true;
                        }
                        else
                        {
                            chkGoodsOrderPrint.Checked = false;
                        }
                        break;

                    #endregion

                    #region 销售出库单
                    case "SellOrderSave":
                        if (strValue == "1")
                        {
                            chkSellOrderSave.Checked = true;
                        }
                        else
                        {
                            chkSellOrderSave.Checked = false;
                        }
                        break;
                    case "SellOrderDelete":
                        if (strValue == "1")
                        {
                            chkSellOrderDelete.Checked = true;
                        }
                        else
                        {
                            chkSellOrderDelete.Checked = false;
                        }
                        break;
                    case "SellOrderQry":
                        if (strValue == "1")
                        {
                            chkSellOrderQry.Checked = true;
                        }
                        else
                        {
                            chkSellOrderQry.Checked = false;
                        }
                        break;
                    case "SellOrderCheck":
                        if (strValue == "1")
                        {
                            chkSellOrderCheck.Checked = true;
                        }
                        else
                        {
                            chkSellOrderCheck.Checked = false;
                        }
                        break;
                    case "SellOrderUnCheck":
                        if (strValue == "1")
                        {
                            chkSellOrderUnCheck.Checked = true;
                        }
                        else
                        {
                            chkSellOrderUnCheck.Checked = false;
                        }
                        break;
                    case "SellOrderCheck2":
                        if (strValue == "1")
                        {
                            chkSellOrderCheck2.Checked = true;
                        }
                        else
                        {
                            chkSellOrderCheck2.Checked = false;
                        }
                        break;
                    case "SellOrderUnCheck2":
                        if (strValue == "1")
                        {
                            chkSellOrderUnCheck2.Checked = true;
                        }
                        else
                        {
                            chkSellOrderUnCheck2.Checked = false;
                        }
                        break;
                 
                    case "SellOrderPrint":
                        if (strValue == "1")
                        {
                            chkSellOrderPrint.Checked = true;
                        }
                        else
                        {
                            chkSellOrderPrint.Checked = false;
                        }
                        break;

                    #endregion

                    #region 其它出库单
                    case "OtherSellOrderSave":
                        if (strValue == "1")
                        {
                            chkOtherSellOrderSave.Checked = true;
                        }
                        else
                        {
                            chkOtherSellOrderSave.Checked = false;
                        }
                        break;
                    case "OtherSellOrderDelete":
                        if (strValue == "1")
                        {
                            chkOtherSellOrderDelete.Checked = true;
                        }
                        else
                        {
                            chkOtherSellOrderDelete.Checked = false;
                        }
                        break;
                    case "OtherSellOrderQry":
                        if (strValue == "1")
                        {
                            chkOtherSellOrderQry.Checked = true;
                        }
                        else
                        {
                            chkOtherSellOrderQry.Checked = false;
                        }
                        break;
                    case "OtherSellOrderCheck":
                        if (strValue == "1")
                        {
                            chkOtherSellOrderCheck.Checked = true;
                        }
                        else
                        {
                            chkOtherSellOrderCheck.Checked = false;
                        }
                        break;
                    case "OtherSellOrderUnCheck":
                        if (strValue == "1")
                        {
                            chkOtherSellOrderUnCheck.Checked = true;
                        }
                        else
                        {
                            chkOtherSellOrderUnCheck.Checked = false;
                        }
                        break;
              
                    case "OtherSellOrderPrint":
                        if (strValue == "1")
                        {
                            chkOtherSellOrderPrint.Checked = true;
                        }
                        else
                        {
                            chkOtherSellOrderPrint.Checked = false;
                        }
                        break;

                    #endregion

                    #region 退料单
                    case "QuitOrderSave":
                        if (strValue == "1")
                        {
                            chkQuitOrderSave.Checked = true;
                        }
                        else
                        {
                            chkQuitOrderSave.Checked = false;
                        }
                        break;
                    case "QuitOrderDelete":
                        if (strValue == "1")
                        {
                            chkQuitOrderDelete.Checked = true;
                        }
                        else
                        {
                            chkQuitOrderDelete.Checked = false;
                        }
                        break;
                    case "QuitOrderQry":
                        if (strValue == "1")
                        {
                            chkQuitOrderQry.Checked = true;
                        }
                        else
                        {
                            chkQuitOrderQry.Checked = false;
                        }
                        break;
                    case "QuitOrderCheck":
                        if (strValue == "1")
                        {
                            chkQuitOrderCheck.Checked = true;
                        }
                        else
                        {
                            chkQuitOrderCheck.Checked = false;
                        }
                        break;
                    case "QuitOrderUnCheck":
                        if (strValue == "1")
                        {
                            chkQuitOrderUnCheck.Checked = true;
                        }
                        else
                        {
                            chkQuitOrderUnCheck.Checked = false;
                        }
                        break;
                    case "QuitOrderCheck2":
                        if (strValue == "1")
                        {
                            chkQuitOrderCheck2.Checked = true;
                        }
                        else
                        {
                            chkQuitOrderCheck2.Checked = false;
                        }
                        break;
                    case "QuitOrderUnCheck2":
                        if (strValue == "1")
                        {
                            chkQuitOrderUnCheck2.Checked = true;
                        }
                        else
                        {
                            chkQuitOrderUnCheck2.Checked = false;
                        }
                        break;
                    case "QuitOrderPrint":
                        if (strValue == "1")
                        {
                            chkQuitOrderPrint.Checked = true;
                        }
                        else
                        {
                            chkQuitOrderPrint.Checked = false;
                        }
                        break;

                    #endregion

                    #region 退料入库单
                    case "QuitStorageOrderSave":
                        if (strValue == "1")
                        {
                            chkQuitStorageOrderSave.Checked = true;
                        }
                        else
                        {
                            chkQuitStorageOrderSave.Checked = false;
                        }
                        break;
                    case "QuitStorageOrderDelete":
                        if (strValue == "1")
                        {
                            chkQuitStorageOrderDelete.Checked = true;
                        }
                        else
                        {
                            chkQuitStorageOrderDelete.Checked = false;
                        }
                        break;
                    case "QuitStorageOrderQry":
                        if (strValue == "1")
                        {
                            chkQuitStorageOrderQry.Checked = true;
                        }
                        else
                        {
                            chkQuitStorageOrderQry.Checked = false;
                        }
                        break;
                    case "QuitStorageOrderCheck":
                        if (strValue == "1")
                        {
                            chkQuitStorageOrderCheck.Checked = true;
                        }
                        else
                        {
                            chkQuitStorageOrderCheck.Checked = false;
                        }
                        break;
                    case "QuitStorageOrderUnCheck":
                        if (strValue == "1")
                        {
                            chkQuitStorageOrderUnCheck.Checked = true;
                        }
                        else
                        {
                            chkQuitStorageOrderUnCheck.Checked = false;
                        }
                        break;
                  
                    case "QuitStorageOrderPrint":
                        if (strValue == "1")
                        {
                            chkQuitStorageOrderPrint.Checked = true;
                        }
                        else
                        {
                            chkQuitStorageOrderPrint.Checked = false;
                        }
                        break;

                    #endregion

                    #region 超领单
                    case "ExcessOrderSave":
                        if (strValue == "1")
                        {
                            chkExcessOrderSave.Checked = true;
                        }
                        else
                        {
                            chkExcessOrderSave.Checked = false;
                        }
                        break;
                    case "ExcessOrderDelete":
                        if (strValue == "1")
                        {
                            chkExcessOrderDelete.Checked = true;
                        }
                        else
                        {
                            chkExcessOrderDelete.Checked = false;
                        }
                        break;
                    case "ExcessOrderQry":
                        if (strValue == "1")
                        {
                            chkExcessOrderQry.Checked = true;
                        }
                        else
                        {
                            chkExcessOrderQry.Checked = false;
                        }
                        break;
                    case "ExcessOrderCheck":
                        if (strValue == "1")
                        {
                            chkExcessOrderCheck.Checked = true;
                        }
                        else
                        {
                            chkExcessOrderCheck.Checked = false;
                        }
                        break;
                    case "ExcessOrderUnCheck":
                        if (strValue == "1")
                        {
                            chkExcessOrderUnCheck.Checked = true;
                        }
                        else
                        {
                            chkExcessOrderUnCheck.Checked = false;
                        }
                        break;
                    case "ExcessOrderCheck2":
                        if (strValue == "1")
                        {
                            chkExcessOrderCheck2.Checked = true;
                        }
                        else
                        {
                            chkExcessOrderCheck2.Checked = false;
                        }
                        break;
                    case "ExcessOrderUnCheck2":
                        if (strValue == "1")
                        {
                            chkExcessOrderUnCheck2.Checked = true;
                        }
                        else
                        {
                            chkExcessOrderUnCheck2.Checked = false;
                        }
                        break;
                  
                    case "ExcessOrderPrint":
                        if (strValue == "1")
                        {
                            chkExcessOrderPrint.Checked = true;
                        }
                        else
                        {
                            chkExcessOrderPrint.Checked = false;
                        }
                        break;

                    #endregion

                    #region 委外加工入库单
                    case "ConsignSave":
                        if (strValue == "1")
                        {
                            chkConsignSave.Checked = true;
                        }
                        else
                        {
                            chkConsignSave.Checked = false;
                        }
                        break;
                    case "ConsignDelete":
                        if (strValue == "1")
                        {
                            chkConsignDelete.Checked = true;
                        }
                        else
                        {
                            chkConsignDelete.Checked = false;
                        }
                        break;
                    case "ConsignQry":
                        if (strValue == "1")
                        {
                            chkConsignQry.Checked = true;
                        }
                        else
                        {
                            chkConsignQry.Checked = false;
                        }
                        break;
                    case "ConsignCheck":
                        if (strValue == "1")
                        {
                            chkConsignCheck.Checked = true;
                        }
                        else
                        {
                            chkConsignCheck.Checked = false;
                        }
                        break;
                    case "ConsignUnCheck":
                        if (strValue == "1")
                        {
                            chkConsignUnCheck.Checked = true;
                        }
                        else
                        {
                            chkConsignUnCheck.Checked = false;
                        }
                        break;
                    case "ConsignPrint":
                        if (strValue == "1")
                        {
                            chkConsignPrint.Checked = true;
                        }
                        else
                        {
                            chkClientOrderPrint.Checked = false;
                        }
                        break;

                    #endregion

                    #region 委外加工出库单
                    case "ConsignOutSave":
                        if (strValue == "1")
                        {
                            chkConsignOutSave.Checked = true;
                        }
                        else
                        {
                            chkConsignOutSave.Checked = false;
                        }
                        break;
                    case "ConsignOutDelete":
                        if (strValue == "1")
                        {
                            chkConsignOutDelete.Checked = true;
                        }
                        else
                        {
                            chkConsignOutDelete.Checked = false;
                        }
                        break;
                    case "ConsignOutQry":
                        if (strValue == "1")
                        {
                            chkConsignOutQry.Checked = true;
                        }
                        else
                        {
                            chkConsignOutQry.Checked = false;
                        }
                        break;
                    case "ConsignOutCheck":
                        if (strValue == "1")
                        {
                            chkConsignOutCheck.Checked = true;
                        }
                        else
                        {
                            chkConsignOutCheck.Checked = false;
                        }
                        break;
                    case "ConsignOutUnCheck":
                        if (strValue == "1")
                        {
                            chkConsignOutUnCheck.Checked = true;
                        }
                        else
                        {
                            chkConsignOutUnCheck.Checked = false;
                        }
                        break;
               
                    case "ConsignOutPrint":
                        if (strValue == "1")
                        {
                            chkConsignOutPrint.Checked = true;
                        }
                        else
                        {
                            chkConsignOutPrint.Checked = false;
                        }
                        break;

                    #endregion

                    #region 报废单
                    case "RejectOrderSave":
                        if (strValue == "1")
                        {
                            chkRejectOrderSave.Checked = true;
                        }
                        else
                        {
                            chkRejectOrderSave.Checked = false;
                        }
                        break;
                    case "RejectOrderDelete":
                        if (strValue == "1")
                        {
                            chkRejectOrderDelete.Checked = true;
                        }
                        else
                        {
                            chkRejectOrderDelete.Checked = false;
                        }
                        break;
                    case "RejectOrderQry":
                        if (strValue == "1")
                        {
                            chkRejectOrderQry.Checked = true;
                        }
                        else
                        {
                            chkRejectOrderQry.Checked = false;
                        }
                        break;
                    case "RejectOrderCheck":
                        if (strValue == "1")
                        {
                            chkRejectOrderCheck.Checked = true;
                        }
                        else
                        {
                            chkRejectOrderCheck.Checked = false;
                        }
                        break;
                    case "RejectOrderUnCheck":
                        if (strValue == "1")
                        {
                            chkRejectOrderUnCheck.Checked = true;
                        }
                        else
                        {
                            chkRejectOrderUnCheck.Checked = false;
                        }
                        break;
                    case "RejectOrderCheck2":
                        if (strValue == "1")
                        {
                            chkRejectOrderCheck2.Checked = true;
                        }
                        else
                        {
                            chkRejectOrderCheck2.Checked = false;
                        }
                        break;
                    case "RejectOrderUnCheck2":
                        if (strValue == "1")
                        {
                            chkRejectOrderUnCheck2.Checked = true;
                        }
                        else
                        {
                            chkRejectOrderUnCheck2.Checked = false;
                        }
                        break;
               
                    case "RejectOrderPrint":
                        if (strValue == "1")
                        {
                            chkRejectOrderPrint.Checked = true;
                        }
                        else
                        {
                            chkRejectOrderPrint.Checked = false;
                        }
                        break;

                    #endregion

                    #region 付款单
                    case "PaymentOrderSave":
                        if (strValue == "1")
                        {
                            chkPaymentOrderSave.Checked = true;
                        }
                        else
                        {
                            chkPaymentOrderSave.Checked = false;
                        }
                        break;
                    case "PaymentOrderDelete":
                        if (strValue == "1")
                        {
                            chkPaymentOrderDelete.Checked = true;
                        }
                        else
                        {
                            chkPaymentOrderDelete.Checked = false;
                        }
                        break;
                    case "PaymentOrderQry":
                        if (strValue == "1")
                        {
                            chkPaymentOrderQry.Checked = true;
                        }
                        else
                        {
                            chkPaymentOrderQry.Checked = false;
                        }
                        break;
                    case "PaymentOrderCheck":
                        if (strValue == "1")
                        {
                            chkPaymentOrderCheck.Checked = true;
                        }
                        else
                        {
                            chkPaymentOrderCheck.Checked = false;
                        }
                        break;
                    case "PaymentOrderUnCheck":
                        if (strValue == "1")
                        {
                            chkPaymentOrderUnCheck.Checked = true;
                        }
                        else
                        {
                            chkPaymentOrderUnCheck.Checked = false;
                        }
                        break;

                    case "PaymentOrderCheck2":
                        if (strValue == "1")
                        {
                            chkPaymentOrderCheck2.Checked = true;
                        }
                        else
                        {
                            chkPaymentOrderCheck2.Checked = false;
                        }
                        break;
                    case "PaymentOrderUnCheck2":
                        if (strValue == "1")
                        {
                            chkPaymentOrderUnCheck2.Checked = true;
                        }
                        else
                        {
                            chkPaymentOrderUnCheck2.Checked = false;
                        }
                        break;
              
                    case "PaymentOrderPrint":
                        if (strValue == "1")
                        {
                            chkPaymentOrderPrint.Checked = true;
                        }
                        else
                        {
                            chkPaymentOrderPrint.Checked = false;
                        }
                        break;

                    #endregion

                    #region 收款单
                    case "IncomeOrderSave":
                        if (strValue == "1")
                        {
                            chkIncomeOrderSave.Checked = true;
                        }
                        else
                        {
                            chkIncomeOrderSave.Checked = false;
                        }
                        break;
                    case "IncomeOrderDelete":
                        if (strValue == "1")
                        {
                            chkIncomeOrderDelete.Checked = true;
                        }
                        else
                        {
                            chkIncomeOrderDelete.Checked = false;
                        }
                        break;
                    case "IncomeOrderQry":
                        if (strValue == "1")
                        {
                            chkIncomeOrderQry.Checked = true;
                        }
                        else
                        {
                            chkIncomeOrderQry.Checked = false;
                        }
                        break;
                    case "IncomeOrderCheck":
                        if (strValue == "1")
                        {
                            chkIncomeOrderCheck.Checked = true;
                        }
                        else
                        {
                            chkIncomeOrderCheck.Checked = false;
                        }
                        break;
                    case "IncomeOrderUnCheck":
                        if (strValue == "1")
                        {
                            chkIncomeOrderUnCheck.Checked = true;
                        }
                        else
                        {
                            chkIncomeOrderUnCheck.Checked = false;
                        }
                        break;
                
                    case "IncomeOrderPrint":
                        if (strValue == "1")
                        {
                            chkIncomeOrderPrint.Checked = true;
                        }
                        else
                        {
                            chkIncomeOrderPrint.Checked = false;
                        }
                        break;


                    #endregion


                    #region 调拨单
                    case "RemoveBillSave":
                        if (strValue == "1")
                        {
                            chkRemoveBillSave.Checked = true;
                        }
                        else
                        {
                            chkRemoveBillSave.Checked = false;
                        }
                        break;
                    case "RemoveBillDelete":
                        if (strValue == "1")
                        {
                            chkRemoveBillDelete.Checked = true;
                        }
                        else
                        {
                            chkRemoveBillDelete.Checked = false;
                        }
                        break;
                    case "RemoveBillQry":
                        if (strValue == "1")
                        {
                            chkRemoveBillQry.Checked = true;
                        }
                        else
                        {
                            chkRemoveBillQry.Checked = false;
                        }
                        break;
                    case "RemoveBillCheck":
                        if (strValue == "1")
                        {
                            chkRemoveBillCheck.Checked = true;
                        }
                        else
                        {
                            chkRemoveBillCheck.Checked = false;
                        }
                        break;
                    case "RemoveBillUnCheck":
                        if (strValue == "1")
                        {
                            chkRemoveBillUnCheck.Checked = true;
                        }
                        else
                        {
                            chkRemoveBillUnCheck.Checked = false;
                        }
                        break;

                    case "RemoveBillCheck2":
                        if (strValue == "1")
                        {
                            chkRemoveBillCheck2.Checked = true;
                        }
                        else
                        {
                            chkRemoveBillCheck2.Checked = false;
                        }
                        break;
                    case "RemoveBillUnCheck2":
                        if (strValue == "1")
                        {
                            chkRemoveBillUnCheck2.Checked = true;
                        }
                        else
                        {
                            chkRemoveBillUnCheck2.Checked = false;
                        }
                        break;


                    case "RemoveBillPrint":
                        if (strValue == "1")
                        {
                            chkRemoveBillPrint.Checked = true;
                        }
                        else
                        {
                            chkRemoveBillPrint.Checked = false;
                        }
                        break;
                    #endregion

                    #region 其它入库单
                    case "OtherInOrderSave":
                        if (strValue == "1")
                        {
                            chkOtherInOrderSave.Checked = true;
                        }
                        else
                        {
                            chkOtherInOrderSave.Checked = false;
                        }
                        break;
                    case "OtherInOrderDelete":
                        if (strValue == "1")
                        {
                            chkOtherInOrderDelete.Checked = true;
                        }
                        else
                        {
                            chkOtherInOrderDelete.Checked = false;
                        }
                        break;
                    case "OtherInOrderQry":
                        if (strValue == "1")
                        {
                            chkOtherInOrderQry.Checked = true;
                        }
                        else
                        {
                            chkOtherInOrderQry.Checked = false;
                        }
                        break;
                    case "OtherInOrderCheck":
                        if (strValue == "1")
                        {
                            chkOtherInOrderCheck.Checked = true;
                        }
                        else
                        {
                            chkOtherInOrderCheck.Checked = false;
                        }
                        break;
                    case "OtherInOrderUnCheck":
                        if (strValue == "1")
                        {
                            chkOtherInOrderUnCheck.Checked = true;
                        }
                        else
                        {
                            chkOtherInOrderUnCheck.Checked = false;
                        }
                        break;

                    case "OtherInOrderPrint":
                        if (strValue == "1")
                        {
                            chkOtherInOrderPrint.Checked = true;
                        }
                        else
                        {
                            chkOtherInOrderPrint.Checked = false;
                        }
                        break;

                    #endregion


                    #region 基础数据
                    case "MaterialSave":
                        if (strValue == "1")
                        {
                            chkMaterialSave.Checked = true;
                        }
                        else
                        {
                            chkMaterialSave.Checked = false;
                        }
                        break;
                    case "MaterialQry":
                        if (strValue == "1")
                        {
                            chkMaterialQry.Checked = true;
                        }
                        else
                        {
                            chkMaterialQry.Checked = false;
                        }

                        break;
                    case "BomSave":
                        if (strValue == "1")
                        {
                            chkBomSave.Checked = true;
                        }
                        else
                        {
                            chkBomSave.Checked = false;
                        }

                        break;
                    case "BomQry":
                        if (strValue == "1")
                        {
                            chkBomQry.Checked = true;
                        }
                        else
                        {
                            chkBomQry.Checked = false;
                        }


                        break;
                    case "SupplierSave":
                        if (strValue == "1")
                        {
                            chkSupplierSave.Checked = true;
                        }
                        else
                        {
                            chkSupplierSave.Checked = false;
                        }

                        break;
                    case "SupplierQry":
                        if (strValue == "1")
                        {
                            chkSupplierQry.Checked = true;
                        }
                        else
                        {
                            chkSupplierQry.Checked = false;
                        }


                        break;
                    case "ClientSave":
                        if (strValue == "1")
                        {
                            chkClientSave.Checked = true;
                        }
                        else
                        {
                            chkClientSave.Checked = false;
                        }

                        break;
                    case "ClientQry":
                        if (strValue == "1")
                        {
                            chkClientQry.Checked = true;
                        }
                        else
                        {
                            chkClientQry.Checked = false;
                        }

                        break;
                    case "DeptSave":
                        if (strValue == "1")
                        {
                            chkDeptSave.Checked = true;
                        }
                        else
                        {
                            chkDeptSave.Checked = false;
                        }

                        break;
                    case "DeptQry":
                        if (strValue == "1")
                        {
                            chkDeptQry.Checked = true;
                        }
                        else
                        {
                            chkDeptQry.Checked = false;
                        }

                        break;
                    case "EmployeeSave":
                        if (strValue == "1")
                        {
                            chkEmployeeSave.Checked = true;
                        }
                        else
                        {
                            chkEmployeeSave.Checked = false;
                        }

                        break;
                    case "EmployeeQry":
                        if (strValue == "1")
                        {
                            chkEmployeeQry.Checked = true;
                        }
                        else
                        {
                            chkEmployeeQry.Checked = false;
                        }

                        break;
                    case "BasicDataSave":
                        if (strValue == "1")
                        {
                            chkBasicDataSave.Checked = true;
                        }
                        else
                        {
                            chkBasicDataSave.Checked = false;
                        }

                        break;
                    case "BasicDataQry":
                        if (strValue == "1")
                        {
                            chkBasicDataQry.Checked = true;
                        }
                        else
                        {
                            chkBasicDataQry.Checked = false;
                        }
                        break;

                    case "ChangeMaterialIDQry":
                        if (strValue == "1")
                        {
                            chkChangeMaterialID.Checked = true;
                        }
                        else
                        {
                            chkChangeMaterialID.Checked = false;
                        }
                        break;

                       
                    #endregion

                    #region 系统管理
                    case "LoginUser":
                        if (strValue == "1")
                        {
                            chkLoginUser.Checked = true;
                        }
                        else
                        {
                            chkLoginUser.Checked = false;
                        }
                        break;
                    case "LoginUserRight":
                        if (strValue == "1")
                        {
                            chkLoginUserRight.Checked = true;
                        }
                        else
                        {
                            chkLoginUserRight.Checked = false;
                        }
                        break;
                    case "ChangePassword":
                        if (strValue == "1")
                        {
                            chkChangePassword.Checked = true;
                        }
                        else
                        {
                            chkChangePassword.Checked = false;
                        }
                        break;
                    case "SysBackup":
                        if (strValue == "1")
                        {
                            chkSysBackup.Checked = true;
                        }
                        else
                        {
                            chkSysBackup.Checked = false;
                        }
                        break;
                    case "OperateLog":
                        if (strValue == "1")
                        {
                            chkOperateLog.Checked = true;
                        }
                        else
                        {
                            chkOperateLog.Checked = false;
                        }

                        break;
                    #endregion

                    #region 报表管理
                    case "StockReportQry":
                        if (strValue == "1")
                        {
                            chkStockReport.Checked= true;
                        }
                        else
                        {
                            chkStockReport.Checked = false;
                        }
                        break;
                    case "StockDetailReportQry":
                        if (strValue == "1")
                        {
                            chkStockDetailReport.Checked = true;
                        }
                        else
                        {
                            chkStockDetailReport.Checked = false;
                        }
                        break;
                    case "ClientOrderReportQry":
                        if (strValue == "1")
                        {
                            chkClientOrderReport.Checked = true;
                        }
                        else
                        {
                            chkClientOrderReport.Checked = false;
                        }
                        break;
                    case "DrawOrderReportQry":
                        if (strValue == "1")
                        {
                           chkDrawOrderReport.Checked = true;
                        }
                        else
                        {
                            chkDrawOrderReport.Checked = false;
                        }
                        break;
                    case "StockOrderReportQry":
                        if (strValue == "1")
                        {
                            chkStockOrderReport.Checked = true;
                        }
                        else
                        {
                            chkStockOrderReport.Checked = false;
                        }
                        break;
                    case "StockInOrderReportQry":
                        if (strValue == "1")
                        {
                            chkStockInOrderReport.Checked = true;
                        }
                        else
                        {
                            chkStockInOrderReport.Checked = false;
                        }
                        break;
                    case "SellOrderReportQry":
                        if (strValue == "1")
                        {
                            chkSellOrderReport.Checked = true;
                        }
                        else
                        {
                            chkSellOrderReport.Checked = false;
                        }
                        break;
                    case "OtherSellOrderReportQry":
                        if (strValue == "1")
                        {
                            chkOtherSellOrderReport.Checked = true;
                        }
                        else
                        {
                            chkOtherSellOrderReport.Checked = false;
                        }
                        break;
                    case "OtherInOrderReportQry":
                        if (strValue == "1")
                        {
                            chkOtherInOrderReport.Checked = true;
                        }
                        else
                        {
                            chkOtherInOrderReport.Checked = false;
                        }
                        break;
                    case "QuitOrderReportQry":
                        if (strValue == "1")
                        {
                           chkQuitOrderReport.Checked = true;
                            
                        }
                        else
                        {
                            chkQuitOrderReport.Checked = false;
                        }
                        break;
                    case "QuitStorageOrderReportQry":
                        if (strValue == "1")
                        {
                            chkQuitStorageOrderReport.Checked = true;
                        }
                        else
                        {
                            chkQuitStorageOrderReport.Checked = false;
                        }
                        break;
                    case "ExcessOrderReportQry":
                        if (strValue == "1")
                        {
                            chkExcessOrderReport.Checked = true;
                        }
                        else
                        {
                            chkExcessOrderReport.Checked = false;
                        }
                        break;
                    case "RejectOrderReportQry":
                        if (strValue == "1")
                        {
                            chkRejectOrderReport.Checked = true;
                        }
                        else
                        {
                            chkRejectOrderReport.Checked = false;
                        }
                        break;
                    case "ConsignReportQry":
                        if (strValue == "1")
                        {
                           chkConsignReport.Checked= true;
                        }
                        else
                        {
                            chkConsignReport.Checked = false;
                        }
                        break;
                    case "ConsignOutReportQry":
                        if (strValue == "1")
                        {
                            chkConsignOutReport.Checked = true;
                        }
                        else
                        {
                            chkConsignOutReport.Checked = false;
                        }
                        break;
                    //case "PaymentOrderReportQry":
                    //    if (strValue == "1")
                    //    {
                    //       chkPaymentOrderReport.Checked= true;
                    //    }
                    //    else
                    //    {
                    //        chkPaymentOrderReport.Checked = false;
                    //    }
                    //    break;
                    case "IncomeOrderReportQry":
                        if (strValue == "1")
                        {
                            chkIncomeOrderReport.Checked= true;
                        }
                        else
                        {
                            chkIncomeOrderReport.Checked = false;
                        }
                        break;
                    case "GoodsOrderReportQry":
                        if (strValue == "1")
                        {
                            chkGoodsOrderReport.Checked = true;
                        }
                        else
                        {
                            chkGoodsOrderReport.Checked = false;
                        }
                        break;
                    case "HalfGoodsReportQry":
                        if (strValue == "1")
                        {
                            chkHalfGoodsReport.Checked = true;
                        }
                        else
                        {
                            chkHalfGoodsReport.Checked = false;
                        }
                        break;

                    case "StockOrderStatusReportQry":
                        if (strValue == "1")
                        {
                            chkStockOrderStatusReport.Checked = true;
                        }
                        else
                        {
                            chkStockOrderStatusReport.Checked = false;
                        }
                        break;

                    case "ClientOrderStatusReportQry":
                        if (strValue == "1")
                        {
                            chkClientOrderStatusReport.Checked = true;
                        }
                        else
                        {
                            chkClientOrderStatusReport.Checked = false;
                        }
                        break;
                    case "PaymentOrderReportQry":
                        if (strValue == "1")
                        {
                            chkPaymentOrderReport1.Checked = true;
                        }
                        else
                        {
                            chkPaymentOrderReport1.Checked = false;
                        }
                        break;


                    case "StockOrderInvoiceReportQry":
                        if (strValue == "1")
                        {
                           chkStockOrderInvoiceReport.Checked = true;
                        }
                        else
                        {
                            chkStockOrderInvoiceReport.Checked = false;
                        }
                        break;

                    case "InOutStorageReportQry":
                        if (strValue == "1")
                        {
                           chkInOutStorageReport.Checked = true;
                        }
                        else
                        {
                            chkInOutStorageReport.Checked = false;
                        }
                        break;

                     case "ProcessProductQry":
                        if (strValue == "1")
                        {
                            chkProcessProduct.Checked = true;
                        }
                        else
                        {
                            chkProcessProduct.Checked = false;
                        }
                        break;


                    case "StockYJReportQry":
                        if (strValue == "1")
                        {
                            chkStockYJReport.Checked = true;
                        }
                        else
                        {
                            chkStockYJReport.Checked = false;
                        }
                        break;


                   
                    #endregion

                    #region 文件管理
                    case "FileManage":
                        if (strValue == "1")
                        {
                            chkFileManage.Checked = true;
                        }
                        else
                        {
                            chkFileManage.Checked = false;
                        }
                        break;
                    #endregion

                    #region 文件查看
                    case "FileView":
                        if (strValue == "1")
                        {
                            chkFileView.Checked = true;
                        }
                        else
                        {
                            chkFileView.Checked = false;
                        }
                        break;
                    #endregion

                    #region 文件申请
                    case "FileApplySave":
                        if (strValue == "1")
                        {
                            chkFileApplySave.Checked = true;
                        }
                        else
                        {
                            chkFileApplySave.Checked = false;
                        }
                        break;

                    case "FileApplyDelete":
                        if (strValue == "1")
                        {
                            chkFileApplyDelete.Checked = true;
                        }
                        else
                        {
                            chkFileApplyDelete.Checked = false;
                        }
                        break;

                    case "FileApplyCheck":
                        if (strValue == "1")
                        {
                            chkFileApplyCheck.Checked = true;
                        }
                        else
                        {
                            chkFileApplyCheck.Checked = false;
                        }
                        break;
                    case "FileApplyUnCheck":
                        if (strValue == "1")
                        {
                            chkFileApplyUnCheck.Checked = true;
                        }
                        else
                        {
                            chkFileApplyUnCheck.Checked = false;
                        }
                        break;
                    case "FileApplyQry":
                        if (strValue == "1")
                        {
                            chkFileApplyQry.Checked = true;
                        }
                        else
                        {
                            chkFileApplyQry.Checked = false;
                        }
                        break;
                    #endregion

                    #region 文件入库
                    case "FileInStorageSave":
                        if (strValue == "1")
                        {
                            chkFileInStorageSave.Checked = true;
                        }
                        else
                        {
                            chkFileInStorageSave.Checked = false;
                        }
                        break;

                    case "FileInStorageDelete":
                        if (strValue == "1")
                        {
                            chkFileInStorageDelete.Checked = true;
                        }
                        else
                        {
                            chkFileInStorageDelete.Checked = false;
                        }
                        break;

                    case "FileInStorageCheck":
                        if (strValue == "1")
                        {
                            chkFileInStorageCheck.Checked = true;
                        }
                        else
                        {
                            chkFileInStorageCheck.Checked = false;
                        }
                        break;
                    case "FileInStorageUnCheck":
                        if (strValue == "1")
                        {
                            chkFileInStorageUnCheck.Checked = true;
                        }
                        else
                        {
                            chkFileInStorageUnCheck.Checked = false;
                        }
                        break;
                    case "FileInStorageCheck2":
                        if (strValue == "1")
                        {
                            chkFileInStorageCheck2.Checked = true;
                        }
                        else
                        {
                            chkFileInStorageCheck2.Checked = false;
                        }
                        break;
                    case "FileInStorageUnCheck2":
                        if (strValue == "1")
                        {
                            chkFileInStorageUnCheck2.Checked = true;
                        }
                        else
                        {
                            chkFileInStorageUnCheck2.Checked = false;
                        }
                        break;
                    case "FileInStorageQry":
                        if (strValue == "1")
                        {
                            chkFileInStorageQry.Checked = true;
                        }
                        else
                        {
                            chkFileInStorageQry.Checked = false;
                        }
                        break;
                    #endregion


                    #region 工程更改单
                    case "ChangeBillSave":
                        if (strValue == "1")
                        {
                            chkFileChangeSave.Checked = true;
                        }
                        else
                        {
                            chkFileChangeSave.Checked = false;
                        }
                        break;

                    case "ChangeBillDelete":
                        if (strValue == "1")
                        {
                            chkFileChangeDelete.Checked = true;
                        }
                        else
                        {
                            chkFileChangeDelete.Checked = false;
                        }
                        break;

                    case "ChangeBillQry":
                        if (strValue == "1")
                        {
                            chkFileChangeQry.Checked = true;
                        }
                        else
                        {
                            chkFileChangeQry.Checked = false;
                        }
                        break;


                    case "ChangeBillCheck":
                        if (strValue == "1")
                        {

                            chkFileChangeCheck.Checked = true;
                        }
                        else
                        {
                            chkFileChangeCheck.Checked = false;
                        }
                        break;
                    case "ChangeBillUnCheck":
                        if (strValue == "1")
                        {
                            chkFileChangeUnCheck.Checked = true;
                        }
                        else
                        {
                            chkFileChangeUnCheck.Checked = false;
                        }
                        break;
                  
                    #endregion

                    #region 报表：文件一览表、发放统计表、申请统计表
                    case "fjfftjb":
                        if (strValue == "1")
                        {
                            
                            chkfjfftjb.Checked = true;
                        }
                        else
                        {
                            chkfjfftjb.Checked = false;
                        }
                        break;
                    case "fjsqtjb":
                        if (strValue == "1")
                        {

                            chkfjsqtjb.Checked = true;
                        }
                        else
                        {
                            chkfjsqtjb.Checked = false;
                        }
                        break;
                    case "fjzlylb":
                        if (strValue == "1")
                        {

                            chkfjzlylb.Checked = true;
                        }
                        else
                        {
                            chkfjzlylb.Checked = false;
                        }
                        break;
                    #endregion

                       //文件阅览
                    case "FileAllView":
                        if (strValue == "1")
                        {
                            chkFileAllView.Checked = true;
                        }
                        else
                        {
                            chkFileAllView.Checked = false;
                        }
                        break;

                    //文件删除
                    case "DeleteFile":
                        if (strValue == "1")
                        {
                            chkDeleteFile.Checked = true;
                        }
                        else
                        {
                            chkDeleteFile.Checked = false;
                        }
                        break;


                    case "IsDisplayPrice":
                        if (strValue == "1")
                        {
                            chkIsDisplayPrice.Checked = true;
                        }
                        else
                        {
                            chkIsDisplayPrice.Checked = false;
                        }
                        break;

                    case "InitialGoodsQry":
                        if (strValue == "1")
                        {
                            chkInitialGoods.Checked = true;
                        }
                        else
                        {
                            chkInitialGoods.Checked = false;
                        }
                        break;


                    //设备管理
                    case "EquipmentSave":
                        if (strValue == "1")
                        {
                            chkEquipmentSave.Checked = true;
                        }
                        else
                        {
                            chkEquipmentSave.Checked = false;
                        }
                        break;

                    case "EquipmentQry":
                        if (strValue == "1")
                        {
                            chkEquipmentQry.Checked = true;
                        }
                        else
                        {
                            chkEquipmentQry.Checked = false;
                        }
                        break;


                    case "EquipmentDieReportQry":
                        if (strValue == "1")
                        {
                            chkEquipmentDieReportQry.Checked = true;
                        }
                        else
                        {
                            chkEquipmentDieReportQry.Checked = false;
                        }
                        break;
                    case "EquipmentGageReportQry":
                        if (strValue == "1")
                        {
                            chkEquipmentGageReportQry.Checked = true;
                        }
                        else
                        {
                            chkEquipmentGageReportQry.Checked = false;
                        }
                        break;
                    case "EquipmentInformationReportQry":
                        if (strValue == "1")
                        {
                            chkEquipmentInformationReportQry.Checked = true;
                        }
                        else
                        {
                            chkEquipmentInformationReportQry.Checked = false;
                        }
                        break;
                    case "EquipmentOfficeReportQry":
                        if (strValue == "1")
                        {
                            chkEquipmentOfficeReportQry.Checked = true;
                        }
                        else
                        {
                            chkEquipmentOfficeReportQry.Checked = false;
                        }
                        break;
                    case "EquipmentFrockReportQry":
                        if (strValue == "1")
                        {
                            chkEquipmentFrockReportQry.Checked = true;
                        }
                        else
                        {
                            chkEquipmentFrockReportQry.Checked = false;
                        }
                        break;
                    
                }
            
            }

        }

       

        private void frmGroupRightSet_Load(object sender, EventArgs e)
        {
            LoadRightGroup();
        }

        //权限组全选
        private void chkAllGroup_Click(object sender, EventArgs e)
        {
            if (chkAllGroup.Checked == true)
            {
                for (int i = 0; i < chklstGroup.Items.Count; i++)
                {
                    chklstGroup.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < chklstGroup.Items.Count; i++)
                {
                    chklstGroup.SetItemChecked(i, false);
                }
            }
        }

        //保存
        private void tsbtnSave_Click(object sender, EventArgs e)
        {

            //先判断是否有选择权限组
            if (chklstGroup.CheckedItems.Count <= 0)
            {
                this.ShowMessage("请选择权限组!");
                return;
            }

            GroupRightSet groupRightSet = new GroupRightSet();
            List<GroupRightSet> lst = new List<GroupRightSet>();
            List<string> lstGroup = new List<string>();

            ListItem listitem = new ListItem();
            for (int i = 0; i < chklstGroup.CheckedItems.Count; i++)
            {
                listitem = chklstGroup.CheckedItems[i] as ListItem;

                lstGroup.Add(listitem.Value);
            }

            for (int i = 0; i < chklstGroup.CheckedItems.Count; i++)
            {
                listitem = chklstGroup.CheckedItems[i] as ListItem;

                #region 单据权限
                //单据权限---------------------------------

                //客户订单
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ClientOrderSave";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkClientOrderSave.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ClientOrderDelete";
                groupRightSet.FunctionID = "Delete";
                groupRightSet.FunctionRight = chkClientOrderDelete.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ClientOrderQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkClientOrderQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ClientOrderCheck";
                groupRightSet.FunctionID = "Check";
                groupRightSet.FunctionRight = chkClientOrderCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ClientOrderUnCheck";
                groupRightSet.FunctionID = "UnCheck";
                groupRightSet.FunctionRight = chkClientOrderUnCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ClientOrderCheck2";
                groupRightSet.FunctionID = "Check2";
                groupRightSet.FunctionRight = chkClientOrderCheck2.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ClientOrderUnCheck2";
                groupRightSet.FunctionID = "UnCheck2";
                groupRightSet.FunctionRight = chkClientOrderUnCheck2.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ClientOrderEnd";
                groupRightSet.FunctionID = "End";
                groupRightSet.FunctionRight = chkClientOrderEnd.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ClientOrderPrint";
                groupRightSet.FunctionID = "Print";
                groupRightSet.FunctionRight = chkClientOrderPrint.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                //物料需求计划
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "StockPlanSave";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkStockPlanSave.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "StockPlanDelete";
                groupRightSet.FunctionID = "Delete";
                groupRightSet.FunctionRight = chkStockPlanDelete.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "StockPlanQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkStockPlanQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                //采购订单
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "StockOrderSave";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkStockOrderSave.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "StockOrderDelete";
                groupRightSet.FunctionID = "Delete";
                groupRightSet.FunctionRight = chkStockOrderDelete.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "StockOrderQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkStockOrderQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "StockOrderCheck";
                groupRightSet.FunctionID = "Check";
                groupRightSet.FunctionRight = chkStockOrderCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "StockOrderUnCheck";
                groupRightSet.FunctionID = "UnCheck";
                groupRightSet.FunctionRight = chkStockOrderUnCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "StockOrderEnd";
                groupRightSet.FunctionID = "End";
                groupRightSet.FunctionRight = chkStockOrderEnd.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);



                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "StockOrderPrint";
                groupRightSet.FunctionID = "Print";
                groupRightSet.FunctionRight = chkStockOrderPrint.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                //采购入库单
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "StockInSave";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkStockInSave.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "StockInDelete";
                groupRightSet.FunctionID = "Delete";
                groupRightSet.FunctionRight = chkStockInDelete.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "StockInQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkStockInQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "StockInCheck";
                groupRightSet.FunctionID = "Check";
                groupRightSet.FunctionRight = chkStockInCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "StockInUnCheck";
                groupRightSet.FunctionID = "UnCheck";
                groupRightSet.FunctionRight = chkStockInUnCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "StockInPrint";
                groupRightSet.FunctionID = "Print";
                groupRightSet.FunctionRight = chkStockInPrint.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                //生产领料计划
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "DrawPlanSave";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkDrawPlanSave.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "DrawPlanDelete";
                groupRightSet.FunctionID = "Delete";
                groupRightSet.FunctionRight = chkDrawPlanDelete.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "DrawPlanQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkDrawPlanQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                //领料单
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "DrawOrderSave";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkDrawOrderSave.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "DrawOrderDelete";
                groupRightSet.FunctionID = "Delete";
                groupRightSet.FunctionRight = chkDrawOrderDelete.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "DrawOrderQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkDrawOrderQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "DrawOrderCheck";
                groupRightSet.FunctionID = "Check";
                groupRightSet.FunctionRight = chkDrawOrderCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "DrawOrderUnCheck";
                groupRightSet.FunctionID = "UnCheck";
                groupRightSet.FunctionRight = chkDrawOrderUnCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "DrawOrderPrint";
                groupRightSet.FunctionID = "Print";
                groupRightSet.FunctionRight = chkDrawOrderPrint.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                //半成品入库单
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "HalfGoodsSave";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkHalfGoodsSave.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "HalfGoodsDelete";
                groupRightSet.FunctionID = "Delete";
                groupRightSet.FunctionRight = chkHalfGoodsDelete.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "HalfGoodsQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkHalfGoodsQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "HalfGoodsCheck";
                groupRightSet.FunctionID = "Check";
                groupRightSet.FunctionRight = chkHalfGoodsCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "HalfGoodsUnCheck";
                groupRightSet.FunctionID = "UnCheck";
                groupRightSet.FunctionRight = chkHalfGoodsUnCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "HalfGoodsPrint";
                groupRightSet.FunctionID = "Print";
                groupRightSet.FunctionRight = chkHalfGoodsPrint.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                //成品入库单
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "GoodsOrderSave";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkGoodsOrderSave.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "GoodsOrderDelete";
                groupRightSet.FunctionID = "Delete";
                groupRightSet.FunctionRight = chkGoodsOrderDelete.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "GoodsOrderQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkGoodsOrderQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "GoodsOrderCheck";
                groupRightSet.FunctionID = "Check";
                groupRightSet.FunctionRight = chkGoodsOrderCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "GoodsOrderUnCheck";
                groupRightSet.FunctionID = "UnCheck";
                groupRightSet.FunctionRight = chkGoodsOrderUnCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "GoodsOrderPrint";
                groupRightSet.FunctionID = "Print";
                groupRightSet.FunctionRight = chkGoodsOrderPrint.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                //销售出库单
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "SellOrderSave";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkSellOrderSave.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "SellOrderDelete";
                groupRightSet.FunctionID = "Delete";
                groupRightSet.FunctionRight = chkSellOrderDelete.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "SellOrderQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkSellOrderQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "SellOrderCheck";
                groupRightSet.FunctionID = "Check";
                groupRightSet.FunctionRight = chkSellOrderCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "SellOrderUnCheck";
                groupRightSet.FunctionID = "UnCheck";
                groupRightSet.FunctionRight = chkSellOrderUnCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "SellOrderCheck2";
                groupRightSet.FunctionID = "Check2";
                groupRightSet.FunctionRight = chkSellOrderCheck2.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "SellOrderUnCheck2";
                groupRightSet.FunctionID = "UnCheck2";
                groupRightSet.FunctionRight = chkSellOrderUnCheck2.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "SellOrderPrint";
                groupRightSet.FunctionID = "Print";
                groupRightSet.FunctionRight = chkSellOrderPrint.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                //其它出库单
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "OtherSellOrderSave";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkOtherSellOrderSave.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "OtherSellOrderDelete";
                groupRightSet.FunctionID = "Delete";
                groupRightSet.FunctionRight = chkOtherSellOrderDelete.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "OtherSellOrderQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkOtherSellOrderQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "OtherSellOrderCheck";
                groupRightSet.FunctionID = "Check";
                groupRightSet.FunctionRight = chkOtherSellOrderCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "OtherSellOrderUnCheck";
                groupRightSet.FunctionID = "UnCheck";
                groupRightSet.FunctionRight = chkOtherSellOrderUnCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "OtherSellOrderPrint";
                groupRightSet.FunctionID = "Print";
                groupRightSet.FunctionRight = chkOtherSellOrderPrint.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);



                //退料单
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "QuitOrderSave";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkQuitOrderSave.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "QuitOrderDelete";
                groupRightSet.FunctionID = "Delete";
                groupRightSet.FunctionRight = chkQuitOrderDelete.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "QuitOrderQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkQuitOrderQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "QuitOrderCheck";
                groupRightSet.FunctionID = "Check";
                groupRightSet.FunctionRight = chkQuitOrderCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "QuitOrderUnCheck";
                groupRightSet.FunctionID = "UnCheck";
                groupRightSet.FunctionRight = chkQuitOrderUnCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "QuitOrderCheck2";
                groupRightSet.FunctionID = "Check2";
                groupRightSet.FunctionRight = chkQuitOrderCheck2.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "QuitOrderUnCheck2";
                groupRightSet.FunctionID = "UnCheck2";
                groupRightSet.FunctionRight = chkQuitOrderUnCheck2.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "QuitOrderPrint";
                groupRightSet.FunctionID = "Print";
                groupRightSet.FunctionRight = chkQuitOrderPrint.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);



                //退料入库单
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "QuitStorageOrderSave";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkQuitStorageOrderSave.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "QuitStorageOrderDelete";
                groupRightSet.FunctionID = "Delete";
                groupRightSet.FunctionRight = chkQuitStorageOrderDelete.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "QuitStorageOrderQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkQuitStorageOrderQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "QuitStorageOrderCheck";
                groupRightSet.FunctionID = "Check";
                groupRightSet.FunctionRight = chkQuitStorageOrderCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "QuitStorageOrderUnCheck";
                groupRightSet.FunctionID = "UnCheck";
                groupRightSet.FunctionRight = chkQuitStorageOrderUnCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "QuitStorageOrderPrint";
                groupRightSet.FunctionID = "Print";
                groupRightSet.FunctionRight = chkQuitStorageOrderPrint.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                //超领单
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ExcessOrderSave";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkExcessOrderSave.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ExcessOrderDelete";
                groupRightSet.FunctionID = "Delete";
                groupRightSet.FunctionRight = chkExcessOrderDelete.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ExcessOrderQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkExcessOrderQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ExcessOrderCheck";
                groupRightSet.FunctionID = "Check";
                groupRightSet.FunctionRight = chkExcessOrderCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ExcessOrderUnCheck";
                groupRightSet.FunctionID = "UnCheck";
                groupRightSet.FunctionRight = chkExcessOrderUnCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ExcessOrderCheck2";
                groupRightSet.FunctionID = "Check2";
                groupRightSet.FunctionRight = chkExcessOrderCheck2.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ExcessOrderUnCheck2";
                groupRightSet.FunctionID = "UnCheck2";
                groupRightSet.FunctionRight = chkExcessOrderUnCheck2.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ExcessOrderPrint";
                groupRightSet.FunctionID = "Print";
                groupRightSet.FunctionRight = chkExcessOrderPrint.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);



                //委外加工入库单
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ConsignSave";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkConsignSave.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ConsignDelete";
                groupRightSet.FunctionID = "Delete";
                groupRightSet.FunctionRight = chkConsignDelete.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ConsignQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkConsignQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ConsignCheck";
                groupRightSet.FunctionID = "Check";
                groupRightSet.FunctionRight = chkConsignCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ConsignUnCheck";
                groupRightSet.FunctionID = "UnCheck";
                groupRightSet.FunctionRight = chkConsignUnCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ConsignPrint";
                groupRightSet.FunctionID = "Print";
                groupRightSet.FunctionRight = chkConsignPrint.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                //委外加工出库单
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ConsignOutSave";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkConsignOutSave.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ConsignOutDelete";
                groupRightSet.FunctionID = "Delete";
                groupRightSet.FunctionRight = chkConsignOutDelete.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ConsignOutQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkConsignOutQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ConsignOutCheck";
                groupRightSet.FunctionID = "Check";
                groupRightSet.FunctionRight = chkConsignOutCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ConsignOutUnCheck";
                groupRightSet.FunctionID = "UnCheck";
                groupRightSet.FunctionRight = chkConsignOutUnCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ConsignOutPrint";
                groupRightSet.FunctionID = "Print";
                groupRightSet.FunctionRight = chkConsignOutPrint.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                //报废单
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "RejectOrderSave";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkRejectOrderSave.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "RejectOrderDelete";
                groupRightSet.FunctionID = "Delete";
                groupRightSet.FunctionRight = chkRejectOrderDelete.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "RejectOrderQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkRejectOrderQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "RejectOrderCheck";
                groupRightSet.FunctionID = "Check";
                groupRightSet.FunctionRight = chkRejectOrderCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "RejectOrderUnCheck";
                groupRightSet.FunctionID = "UnCheck";
                groupRightSet.FunctionRight = chkRejectOrderUnCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "RejectOrderCheck2";
                groupRightSet.FunctionID = "Check2";
                groupRightSet.FunctionRight = chkRejectOrderCheck2.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "RejectOrderUnCheck2";
                groupRightSet.FunctionID = "UnCheck2";
                groupRightSet.FunctionRight = chkRejectOrderUnCheck2.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "RejectOrderPrint";
                groupRightSet.FunctionID = "Print";
                groupRightSet.FunctionRight = chkRejectOrderPrint.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                //付款单
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "PaymentOrderSave";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkPaymentOrderSave.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "PaymentOrderDelete";
                groupRightSet.FunctionID = "Delete";
                groupRightSet.FunctionRight = chkPaymentOrderDelete.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "PaymentOrderQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkPaymentOrderQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "PaymentOrderCheck";
                groupRightSet.FunctionID = "Check";
                groupRightSet.FunctionRight = chkPaymentOrderCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "PaymentOrderUnCheck";
                groupRightSet.FunctionID = "UnCheck";
                groupRightSet.FunctionRight = chkPaymentOrderUnCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "PaymentOrderCheck2";
                groupRightSet.FunctionID = "Check2";
                groupRightSet.FunctionRight = chkPaymentOrderCheck2.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "PaymentOrderUnCheck2";
                groupRightSet.FunctionID = "UnCheck2";
                groupRightSet.FunctionRight = chkPaymentOrderUnCheck2.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "PaymentOrderPrint";
                groupRightSet.FunctionID = "Print";
                groupRightSet.FunctionRight = chkPaymentOrderPrint.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                //收款单
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "IncomeOrderSave";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkIncomeOrderSave.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "IncomeOrderDelete";
                groupRightSet.FunctionID = "Delete";
                groupRightSet.FunctionRight = chkIncomeOrderDelete.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "IncomeOrderQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkIncomeOrderQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "IncomeOrderCheck";
                groupRightSet.FunctionID = "Check";
                groupRightSet.FunctionRight = chkIncomeOrderCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "IncomeOrderUnCheck";
                groupRightSet.FunctionID = "UnCheck";
                groupRightSet.FunctionRight = chkIncomeOrderUnCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "IncomeOrderPrint";
                groupRightSet.FunctionID = "Print";
                groupRightSet.FunctionRight = chkIncomeOrderPrint.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                //调拨单
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "RemoveBillSave";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkRemoveBillSave.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "RemoveBillDelete";
                groupRightSet.FunctionID = "Delete";
                groupRightSet.FunctionRight = chkRemoveBillDelete.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "RemoveBillQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkRemoveBillQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "RemoveBillCheck";
                groupRightSet.FunctionID = "Check";
                groupRightSet.FunctionRight = chkRemoveBillCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "RemoveBillUnCheck";
                groupRightSet.FunctionID = "UnCheck";
                groupRightSet.FunctionRight = chkRemoveBillUnCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "RemoveBillCheck2";
                groupRightSet.FunctionID = "Check2";
                groupRightSet.FunctionRight = chkRemoveBillCheck2.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "RemoveBillUnCheck2";
                groupRightSet.FunctionID = "UnCheck2";
                groupRightSet.FunctionRight = chkRemoveBillUnCheck2.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "RemoveBillPrint";
                groupRightSet.FunctionID = "Print";
                groupRightSet.FunctionRight = chkRemoveBillPrint.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                //其它入库单
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "OtherInOrderSave";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkOtherInOrderSave.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "OtherInOrderDelete";
                groupRightSet.FunctionID = "Delete";
                groupRightSet.FunctionRight = chkOtherInOrderDelete.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "OtherInOrderQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkOtherInOrderQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "OtherInOrderCheck";
                groupRightSet.FunctionID = "Check";
                groupRightSet.FunctionRight = chkOtherInOrderCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "OtherInOrderUnCheck";
                groupRightSet.FunctionID = "UnCheck";
                groupRightSet.FunctionRight = chkOtherInOrderUnCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "OtherInOrderPrint";
                groupRightSet.FunctionID = "Print";
                groupRightSet.FunctionRight = chkOtherInOrderPrint.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                #endregion

                #region 基础数据管理
                //物料管理---
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "MaterialSave";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkMaterialSave.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "MaterialQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkMaterialQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                //BOM---
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "BomSave";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkBomSave.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "BomQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkBomQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                //供应商---
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "SupplierSave";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkSupplierSave.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "SupplierQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkSupplierQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                //客户---
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ClientSave";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkClientSave.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ClientQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkClientQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                //客户---
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "DeptSave";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkDeptSave.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "DeptQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkDeptQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);



                //员工---
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "EmployeeSave";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkEmployeeSave.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "EmployeeQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkEmployeeQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                //员工---
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "EmployeeSave";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkEmployeeSave.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "EmployeeQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkEmployeeQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                //辅助数据---
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "BasicDataSave";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkBasicDataSave.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "BasicDataQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkBasicDataQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                //修改物料编号
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ChangeMaterialIDQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkChangeMaterialID.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                
                #endregion

                #region 系统管理
                //操作员管理------------
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "LoginUser";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkLoginUser.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                //操作员授权------------
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "LoginUserRight";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkLoginUserRight.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                //修改密码-------------
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ChangePassword";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkChangePassword.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                //系统备份-------------
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "SysBackup";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkSysBackup.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                //系统操作日志-----------
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "OperateLog";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkOperateLog.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                #endregion

                #region 报表管理
                //库存报表------------
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "StockReportQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkStockReport.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                //库存明细报表------------
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "StockDetailReportQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkStockDetailReport.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "DrawOrderReportQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkDrawOrderReport.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "StockOrderReportQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkStockOrderReport.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "StockInOrderReportQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkStockInOrderReport.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "GoodsOrderReportQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkGoodsOrderReport.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "HalfGoodsReportQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkHalfGoodsReport.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "SellOrderReportQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkSellOrderReport.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "RejectOrderReportQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkRejectOrderReport.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "OtherSellOrderReportQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkOtherSellOrderReport.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "OtherInOrderReportQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkOtherInOrderReport.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ConsignReportQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkConsignReport.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ConsignOutReportQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkConsignOutReport.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                //groupRightSet = new GroupRightSet();
                //groupRightSet.GroupID = listitem.Value;
                //groupRightSet.ModuleID = "PaymentOrderReportQry";
                //groupRightSet.FunctionID = "Qry";
                //groupRightSet.FunctionRight = chkPaymentOrderReport.Checked == true ? 1 : 0;
                //lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "IncomeOrderReportQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkIncomeOrderReport.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "QuitOrderReportQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkQuitOrderReport.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "QuitStorageOrderReportQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkQuitStorageOrderReport.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ClientOrderReportQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkClientOrderReport.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ExcessOrderReportQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkExcessOrderReport.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "StockOrderStatusReportQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkStockOrderStatusReport.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ClientOrderStatusReportQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkClientOrderStatusReport.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "PaymentOrderReportQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkPaymentOrderReport1.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "InOutStorageReportQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkInOutStorageReport.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "StockOrderInvoiceReportQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkStockOrderInvoiceReport.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ProcessProductQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkProcessProduct.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);
                

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "StockYJReportQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkStockYJReport.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);
                

                #endregion

                #region 文件管理
                //文件管理
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "FileManage";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkFileManage.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                //文件查看
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "FileView";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkFileView.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                #region 文件申请
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "FileApplySave";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkFileApplySave.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "FileApplyDelete";
                groupRightSet.FunctionID = "Delete";
                groupRightSet.FunctionRight = chkFileApplyDelete.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "FileApplyQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkFileApplyQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "FileApplyCheck";
                groupRightSet.FunctionID = "Check";
                groupRightSet.FunctionRight = chkFileApplyCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "FileApplyUnCheck";
                groupRightSet.FunctionID = "UnCheck";
                groupRightSet.FunctionRight = chkFileApplyUnCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


            
                #endregion


                #region 文件入库
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "FileInStorageSave";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkFileInStorageSave.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "FileInStorageDelete";
                groupRightSet.FunctionID = "Delete";
                groupRightSet.FunctionRight = chkFileInStorageDelete.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "FileInStorageQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkFileInStorageQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "FileInStorageCheck";
                groupRightSet.FunctionID = "Check";
                groupRightSet.FunctionRight = chkFileInStorageCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "FileInStorageUnCheck";
                groupRightSet.FunctionID = "UnCheck";
                groupRightSet.FunctionRight = chkFileInStorageUnCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "FileInStorageCheck2";
                groupRightSet.FunctionID = "Check2";
                groupRightSet.FunctionRight = chkFileInStorageCheck2.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "FileInStorageUnCheck2";
                groupRightSet.FunctionID = "UnCheck2";
                groupRightSet.FunctionRight = chkFileInStorageUnCheck2.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                #endregion


                #region 工程更改单 
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ChangeBillSave";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkFileChangeSave.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ChangeBillQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkFileChangeQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ChangeBillDelete";
                groupRightSet.FunctionID = "Delete";
                groupRightSet.FunctionRight = chkFileChangeDelete.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);


                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ChangeBillCheck";
                groupRightSet.FunctionID = "Check";
                groupRightSet.FunctionRight = chkFileChangeCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);
                 
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "ChangeBillUnCheck";
                groupRightSet.FunctionID = "UnCheck";
                groupRightSet.FunctionRight = chkFileChangeUnCheck.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                #endregion


                #region 文件报表
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "fjfftjb";
                groupRightSet.FunctionID = "fjfftjb";
                groupRightSet.FunctionRight = chkfjfftjb.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "fjsqtjb";
                groupRightSet.FunctionID = "fjsqtjb";
                groupRightSet.FunctionRight = chkfjsqtjb.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "fjzlylb";
                groupRightSet.FunctionID = "fjzlylb";
                groupRightSet.FunctionRight = chkfjzlylb.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);
                #endregion

                


                 //文件阅览
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "FileAllView";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkFileAllView.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                //文件删除
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "DeleteFile";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkDeleteFile.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                #endregion

                #region 设备管理
                //设备保存
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "EquipmentSave";
                groupRightSet.FunctionID = "Save";
                groupRightSet.FunctionRight = chkEquipmentSave.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);
                
                //设备查询
                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "EquipmentQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkEquipmentQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "EquipmentDieReportQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkEquipmentDieReportQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "EquipmentGageReportQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkEquipmentGageReportQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "EquipmentInformationReportQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkEquipmentInformationReportQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "EquipmentOfficeReportQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkEquipmentOfficeReportQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);

                groupRightSet = new GroupRightSet();
                groupRightSet.GroupID = listitem.Value;
                groupRightSet.ModuleID = "EquipmentFrockReportQry";
                groupRightSet.FunctionID = "Qry";
                groupRightSet.FunctionRight = chkEquipmentFrockReportQry.Checked == true ? 1 : 0;
                lst.Add(groupRightSet);
               
                #endregion

            }

            groupRightSet = new GroupRightSet();
            groupRightSet.GroupID = listitem.Value;
            groupRightSet.ModuleID = "IsDisplayPrice";
            groupRightSet.FunctionID = "IsDisplayPrice";
            groupRightSet.FunctionRight = chkIsDisplayPrice.Checked == true ? 1 : 0;
            lst.Add(groupRightSet);

            //期初录入
            groupRightSet = new GroupRightSet();
            groupRightSet.GroupID = listitem.Value;
            groupRightSet.ModuleID = "InitialGoodsQry";
            groupRightSet.FunctionID = "Qry";
            groupRightSet.FunctionRight = chkInitialGoods.Checked == true ? 1 : 0;
            lst.Add(groupRightSet);

            RightGroupManage RightGroupManage = new RightGroupManage();
            RightGroupManage.SaveGroupFunctionRight(lstGroup, lst);




            //写日志
            SysLog.AddOperateLog(SysParams.UserName, "权限设置保存", "保存", SysParams.UserName + "用户保存权限设置,组:" + listitem.Text);



            this.ShowMessage("组功能权限设定保存成功!");


        }

        private void chkBasicDataAll_Click(object sender, EventArgs e)
        {
            //基础数据
            if (chkBasicDataAll.Checked == false)
            {

                chkMaterialSave.Checked = false;
                chkMaterialQry.Checked = false;
                chkBomSave.Checked = false;
                chkBomQry.Checked = false;
                chkSupplierSave.Checked = false;
                chkSupplierQry.Checked = false;
                chkClientSave.Checked = false;
                chkClientQry.Checked = false;
                chkDeptSave.Checked = false;
                chkDeptQry.Checked = false;
                chkEmployeeSave.Checked = false;
                chkEmployeeQry.Checked = false;
                chkBasicDataSave.Checked = false;
                chkBasicDataQry.Checked = false;

            }
            else
            {
                chkMaterialSave.Checked = true;
                chkMaterialQry.Checked = true;
                chkBomSave.Checked = true;
                chkBomQry.Checked = true;
                chkSupplierSave.Checked = true;
                chkSupplierQry.Checked = true;
                chkClientSave.Checked = true;
                chkClientQry.Checked = true;
                chkDeptSave.Checked = true;
                chkDeptQry.Checked = true;
                chkEmployeeSave.Checked = true;
                chkEmployeeQry.Checked = true;
                chkBasicDataSave.Checked = true;
                chkBasicDataQry.Checked = true;
            }
        }

        private void chkSystemManageAll_Click(object sender, EventArgs e)
        {
            //系统管理
            if (chkSystemManageAll.Checked == false)
            {
                chkLoginUser.Checked = false;
                chkLoginUserRight.Checked = false;
                chkChangePassword.Checked = false;
                chkSysBackup.Checked = false;
                chkOperateLog.Checked = false;

            }
            else
            {
                chkLoginUser.Checked = true;
                chkLoginUserRight.Checked = true;
                chkChangePassword.Checked = true;
                chkSysBackup.Checked = true;
                chkOperateLog.Checked = true;

            }
        }

        private void chklstGroup_Click(object sender, EventArgs e)
        {
          
        }

        private void chklstGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Control control in groupBox1.Controls)
            {
                if (control.GetType().Name == "CheckBox")
                {
                    ((System.Windows.Forms.CheckBox)control).Checked = false;

                }
            }

            foreach (System.Windows.Forms.Control control in groupBox2.Controls)
            {
                if (control.GetType().Name == "CheckBox")
                {
                    ((System.Windows.Forms.CheckBox)control).Checked = false;

                }
            }

            foreach (System.Windows.Forms.Control control in groupBox3.Controls)
            {
                if (control.GetType().Name == "CheckBox")
                {
                    ((System.Windows.Forms.CheckBox)control).Checked = false;
                
                }
            }

            foreach (System.Windows.Forms.Control control in groupBox4.Controls)
            {
                if (control.GetType().Name == "CheckBox")
                {
                    ((System.Windows.Forms.CheckBox)control).Checked = false;

                }
            }

            foreach (System.Windows.Forms.Control control in groupBox7.Controls)
            {
                if (control.GetType().Name == "CheckBox")
                {
                    ((System.Windows.Forms.CheckBox)control).Checked = false;

                }
            }

            foreach (System.Windows.Forms.Control control in groupBox8.Controls)
            {
                if (control.GetType().Name == "CheckBox")
                {
                    ((System.Windows.Forms.CheckBox)control).Checked = false;

                }
            }

            chkInitialGoods.Checked = false;

            ListItem item = new ListItem();
            item = chklstGroup.SelectedItem as ListItem;

            loadGroupFunctionRight(item.Value);
        }

        #region 业务单据-全选
        //客户订单-全选
        private void chkClientOrderAll_Click(object sender, EventArgs e)
        {

            //客户订单-全选
            if (chkClientOrderAll.Checked == false)
            {
                chkClientOrderSave.Checked = false;
                chkClientOrderDelete.Checked = false;
                chkClientOrderQry.Checked = false;
                chkClientOrderCheck.Checked = false;
                chkClientOrderUnCheck.Checked = false;
                chkClientOrderCheck2.Checked = false;
                chkClientOrderUnCheck2.Checked = false;
                chkClientOrderEnd.Checked = false;
                chkClientOrderPrint.Checked = false;
            }
            else
            {
                chkClientOrderSave.Checked = true;
                chkClientOrderDelete.Checked = true;
                chkClientOrderQry.Checked = true;
                chkClientOrderCheck.Checked = true;
                chkClientOrderUnCheck.Checked = true;
                chkClientOrderCheck2.Checked = true;
                chkClientOrderUnCheck2.Checked = true;
                chkClientOrderEnd.Checked = true;
                chkClientOrderPrint.Checked = true;
            }
        }

        //物料需求计划-全选
        private void chkStockPlanAll_Click(object sender, EventArgs e)
        {

            if (chkStockPlanAll.Checked == false)
            {
                chkStockPlanSave.Checked = false;
                chkStockPlanDelete.Checked = false;
                chkStockPlanQry.Checked = false;
          
            }
            else
            {
                chkStockPlanSave.Checked = true;
                chkStockPlanDelete.Checked = true;
                chkStockPlanQry.Checked = true;
          
            }
        }

        //采购订单-全选
        private void chkStockOrderAll_Click(object sender, EventArgs e)
        {
            if (chkStockOrderAll.Checked == false)
            {
                chkStockOrderSave.Checked = false;
                chkStockOrderDelete.Checked = false;
                chkStockOrderQry.Checked = false;
                chkStockOrderCheck.Checked = false;
                chkStockOrderUnCheck.Checked = false;
                chkStockOrderEnd.Checked = false;
                chkStockOrderPrint.Checked = false;
            }
            else
            {
                chkStockOrderSave.Checked = true;
                chkStockOrderDelete.Checked = true;
                chkStockOrderQry.Checked = true;
                chkStockOrderCheck.Checked = true;
                chkStockOrderUnCheck.Checked = true;
                chkStockOrderEnd.Checked = true;
                chkStockOrderPrint.Checked = true;
            }
        }

        //采购入库单-全选
        private void chkStockInAll_Click(object sender, EventArgs e)
        {
            if (chkStockInAll.Checked == false)
            {
                chkStockInSave.Checked = false;
                chkStockInDelete.Checked = false;
                chkStockInQry.Checked = false;
                chkStockInCheck.Checked = false;
                chkStockInUnCheck.Checked = false;
                chkStockInPrint.Checked = false;
            }
            else
            {
                chkStockInSave.Checked = true;
                chkStockInDelete.Checked = true;
                chkStockInQry.Checked = true;
                chkStockInCheck.Checked = true;
                chkStockInUnCheck.Checked = true;
                chkStockInPrint.Checked = true;
            }
        }

        //生产领料计划-全选
        private void chkDrawPlanAll_Click(object sender, EventArgs e)
        {
            if (chkDrawPlanAll.Checked == false)
            {
                chkDrawPlanSave.Checked = false;
                chkDrawPlanDelete.Checked = false;
                chkDrawPlanQry.Checked = false;

            }
            else
            {
                chkDrawPlanSave.Checked = true;
                chkDrawPlanDelete.Checked = true;
                chkDrawPlanQry.Checked = true;

            }
        }

        //领料单-全选
        private void chkDrawOrderAll_Click(object sender, EventArgs e)
        {
            if (chkDrawOrderAll.Checked == false)
            {
                chkDrawOrderSave.Checked = false;
                chkDrawOrderDelete.Checked = false;
                chkDrawOrderQry.Checked = false;
                chkDrawOrderCheck.Checked = false;
                chkDrawOrderUnCheck.Checked = false;
                chkDrawOrderPrint.Checked = false;
            }
            else
            {
                chkDrawOrderSave.Checked = true;
                chkDrawOrderDelete.Checked = true;
                chkDrawOrderQry.Checked = true;
                chkDrawOrderCheck.Checked = true;
                chkDrawOrderUnCheck.Checked = true;
                chkDrawOrderPrint.Checked = true;
            }
        }

        //半成品入库单-全选
        private void chkHalfGoodsAll_Click(object sender, EventArgs e)
        {
            if (chkHalfGoodsAll.Checked == false)
            {
                chkHalfGoodsSave.Checked = false;
                chkHalfGoodsDelete.Checked = false;
                chkHalfGoodsQry.Checked = false;
                chkHalfGoodsCheck.Checked = false;
                chkHalfGoodsUnCheck.Checked = false;
                chkHalfGoodsPrint.Checked = false;
            }
            else
            {
                chkHalfGoodsSave.Checked = true;
                chkHalfGoodsDelete.Checked = true;
                chkHalfGoodsQry.Checked = true;
                chkHalfGoodsCheck.Checked = true;
                chkHalfGoodsUnCheck.Checked = true;
                chkHalfGoodsPrint.Checked = true;
            }
        }

        //成品入库单-全选
        private void chkGoodsOrderAll_Click(object sender, EventArgs e)
        {
            if (chkGoodsOrderAll.Checked == false)
            {
                chkGoodsOrderSave.Checked = false;
                chkGoodsOrderDelete.Checked = false;
                chkGoodsOrderQry.Checked = false;
                chkGoodsOrderCheck.Checked = false;
                chkGoodsOrderUnCheck.Checked = false;
                chkGoodsOrderPrint.Checked = false;
            }
            else
            {
                chkGoodsOrderSave.Checked = true;
                chkGoodsOrderDelete.Checked = true;
                chkGoodsOrderQry.Checked = true;
                chkGoodsOrderCheck.Checked = true;
                chkGoodsOrderUnCheck.Checked = true;
                chkGoodsOrderPrint.Checked = true;
            }
        }

        //销售出库单独-全选
        private void chkSellOrderAll_Click(object sender, EventArgs e)
        {
            if (chkSellOrderAll.Checked == false)
            {
                chkSellOrderSave.Checked = false;
                chkSellOrderDelete.Checked = false;
                chkSellOrderQry.Checked = false;
                chkSellOrderCheck.Checked = false;
                chkSellOrderUnCheck.Checked = false;
                chkSellOrderCheck2.Checked = false;
                chkSellOrderUnCheck2.Checked = false;
                chkSellOrderPrint.Checked = false;
            }
            else
            {
                chkSellOrderSave.Checked = true;
                chkSellOrderDelete.Checked = true;
                chkSellOrderQry.Checked = true;
                chkSellOrderCheck.Checked = true;
                chkSellOrderUnCheck.Checked = true;
                chkSellOrderCheck2.Checked = true;
                chkSellOrderUnCheck2.Checked = true;
                chkSellOrderPrint.Checked = true;
            }
        }

        //其它出库单
        private void chkOtherSellOrderAll_Click(object sender, EventArgs e)
        {
            if (chkOtherSellOrderAll.Checked == false)
            {
                chkOtherSellOrderSave.Checked = false;
                chkOtherSellOrderDelete.Checked = false;
                chkOtherSellOrderQry.Checked = false;
                chkOtherSellOrderCheck.Checked = false;
                chkOtherSellOrderUnCheck.Checked = false;
                chkOtherSellOrderPrint.Checked = false;
            }
            else
            {
                chkOtherSellOrderSave.Checked = true;
                chkOtherSellOrderDelete.Checked = true;
                chkOtherSellOrderQry.Checked = true;
                chkOtherSellOrderCheck.Checked = true;
                chkOtherSellOrderUnCheck.Checked = true;
                chkOtherSellOrderPrint.Checked = true;
            }
        }

        //退料单-全选
        private void chkQuitOrderAll_Click(object sender, EventArgs e)
        {
            if (chkQuitOrderAll.Checked == false)
            {
                chkQuitOrderSave.Checked = false;
                chkQuitOrderDelete.Checked = false;
                chkQuitOrderQry.Checked = false;
                chkQuitOrderCheck.Checked = false;
                chkQuitOrderUnCheck.Checked = false;
                chkQuitOrderCheck2.Checked = false;
                chkQuitOrderUnCheck2.Checked = false;
                chkQuitOrderPrint.Checked = false;
            }
            else
            {
                chkQuitOrderSave.Checked = true;
                chkQuitOrderDelete.Checked = true;
                chkQuitOrderQry.Checked = true;
                chkQuitOrderCheck.Checked = true;
                chkQuitOrderUnCheck.Checked = true;
                chkQuitOrderCheck2.Checked = true;
                chkQuitOrderUnCheck2.Checked = true;
                chkQuitOrderPrint.Checked = true;
            }
        }

        //退料入库单-全选
        private void chkQuitStorageOrderAll_Click(object sender, EventArgs e)
        {
            if (chkQuitStorageOrderAll.Checked == false)
            {
                chkQuitStorageOrderSave.Checked = false;
                chkQuitStorageOrderDelete.Checked = false;
                chkQuitStorageOrderQry.Checked = false;
                chkQuitStorageOrderCheck.Checked = false;
                chkQuitStorageOrderUnCheck.Checked = false;
                chkQuitStorageOrderPrint.Checked = false;
            }
            else
            {
                chkQuitStorageOrderSave.Checked = true;
                chkQuitStorageOrderDelete.Checked = true;
                chkQuitStorageOrderQry.Checked = true;
                chkQuitStorageOrderCheck.Checked = true;
                chkQuitStorageOrderUnCheck.Checked = true;
                chkQuitStorageOrderPrint.Checked = true;
            }
        }

        //超领单-全选
        private void chkExcessOrderAll_Click(object sender, EventArgs e)
        {
            if (chkExcessOrderAll.Checked == false)
            {
                chkExcessOrderSave.Checked = false;
                chkExcessOrderDelete.Checked = false;
                chkExcessOrderQry.Checked = false;
                chkExcessOrderCheck.Checked = false;
                chkExcessOrderUnCheck.Checked = false;
                chkExcessOrderCheck2.Checked = false;
                chkExcessOrderUnCheck2.Checked = false;
                chkExcessOrderPrint.Checked = false;
            }
            else
            {
                chkExcessOrderSave.Checked = true;
                chkExcessOrderDelete.Checked = true;
                chkExcessOrderQry.Checked = true;
                chkExcessOrderCheck.Checked = true;
                chkExcessOrderUnCheck.Checked = true;
                chkExcessOrderCheck2.Checked = true;
                chkExcessOrderUnCheck2.Checked = true;
                chkExcessOrderPrint.Checked = true;
            }
        }

        //委外入-全选
        private void chkConsignAll_Click(object sender, EventArgs e)
        {
            if (chkConsignAll.Checked == false)
            {
                chkConsignSave.Checked = false;
                chkConsignDelete.Checked = false;
                chkConsignQry.Checked = false;
                chkConsignCheck.Checked = false;
                chkConsignUnCheck.Checked = false;
                chkConsignPrint.Checked = false;
            }
            else
            {
                chkConsignSave.Checked = true;
                chkConsignDelete.Checked = true;
                chkConsignQry.Checked = true;
                chkConsignCheck.Checked = true;
                chkConsignUnCheck.Checked = true;
                chkConsignPrint.Checked = true;
            }
        }
        //委外出-全选
        private void chkConsignOutAll_Click(object sender, EventArgs e)
        {
            if (chkConsignOutAll.Checked == false)
            {
                chkConsignOutSave.Checked = false;
                chkConsignOutDelete.Checked = false;
                chkConsignOutQry.Checked = false;
                chkConsignOutCheck.Checked = false;
                chkConsignOutUnCheck.Checked = false;
                chkConsignOutPrint.Checked = false;
            }
            else
            {
                chkConsignOutSave.Checked = true;
                chkConsignOutDelete.Checked = true;
                chkConsignOutQry.Checked = true;
                chkConsignOutCheck.Checked = true;
                chkConsignOutUnCheck.Checked = true;
                chkConsignOutPrint.Checked = true;
            }
        }

        //报废单-全选
        private void chkRejectOrderAll_Click(object sender, EventArgs e)
        {
            if (chkRejectOrderAll.Checked == false)
            {
                chkRejectOrderSave.Checked = false;
                chkRejectOrderDelete.Checked = false;
                chkRejectOrderQry.Checked = false;
                chkRejectOrderCheck.Checked = false;
                chkRejectOrderUnCheck.Checked = false;
                chkRejectOrderCheck2.Checked = false;
                chkRejectOrderUnCheck2.Checked = false;
                chkRejectOrderPrint.Checked = false;
            }
            else
            {
                chkRejectOrderSave.Checked = true;
                chkRejectOrderDelete.Checked = true;
                chkRejectOrderQry.Checked = true;
                chkRejectOrderCheck.Checked = true;
                chkRejectOrderUnCheck.Checked = true;
                chkRejectOrderCheck2.Checked = true;
                chkRejectOrderUnCheck2.Checked = true;
                chkRejectOrderPrint.Checked = true;
            }
        }

        //付款单-全选
        private void chkPaymentOrderAll_Click(object sender, EventArgs e)
        {
            if (chkPaymentOrderAll.Checked == false)
            {
                chkPaymentOrderSave.Checked = false;
                chkPaymentOrderDelete.Checked = false;
                chkPaymentOrderQry.Checked = false;
                chkPaymentOrderCheck.Checked = false;
                chkPaymentOrderUnCheck.Checked = false;
                chkPaymentOrderCheck2.Checked = false;
                chkPaymentOrderUnCheck2.Checked = false;
                chkPaymentOrderPrint.Checked = false;
            }
            else
            {
                chkPaymentOrderSave.Checked = true;
                chkPaymentOrderDelete.Checked = true;
                chkPaymentOrderQry.Checked = true;
                chkPaymentOrderCheck.Checked = true;
                chkPaymentOrderUnCheck.Checked = true;
                chkPaymentOrderCheck2.Checked = true;
                chkPaymentOrderUnCheck2.Checked = true;
                chkPaymentOrderPrint.Checked = true;
            }
        }

        //收款单-全选
        private void chkIncomeOrderAll_Click(object sender, EventArgs e)
        {
            if (chkIncomeOrderAll.Checked == false)
            {
                chkIncomeOrderSave.Checked = false;
                chkIncomeOrderDelete.Checked = false;
                chkIncomeOrderQry.Checked = false;
                chkIncomeOrderCheck.Checked = false;
                chkIncomeOrderUnCheck.Checked = false;
                chkIncomeOrderPrint.Checked = false;
            }
            else
            {
                chkIncomeOrderSave.Checked = true;
                chkIncomeOrderDelete.Checked = true;
                chkIncomeOrderQry.Checked = true;
                chkIncomeOrderCheck.Checked = true;
                chkIncomeOrderUnCheck.Checked = true;
                chkIncomeOrderPrint.Checked = true;
            }
        }

        private void chkAll2_Click(object sender, EventArgs e)
        {
            if (chkAll2.Checked == false)
            {
                chkClientOrderAll.Checked = false;
                chkStockPlanAll.Checked = false;
                chkStockOrderAll.Checked = false;
                chkStockInAll.Checked = false;
                chkDrawPlanAll.Checked = false;
                chkDrawOrderAll.Checked = false;
                chkHalfGoodsAll.Checked = false;
                chkGoodsOrderAll.Checked = false;
                chkSellOrderAll.Checked = false;
                chkOtherSellOrderAll.Checked = false;
                chkQuitOrderAll.Checked = false;
                chkQuitStorageOrderAll.Checked = false;
                chkExcessOrderAll.Checked = false;
                chkConsignAll.Checked = false;
                chkConsignOutAll.Checked = false;
                chkRejectOrderAll.Checked = false;
                chkPaymentOrderAll.Checked = false;
                chkIncomeOrderAll.Checked = false;
                chkRemoveBillAll.Checked = false;
               // chkReportAll.Checked = false;
               


                chkClientOrderAll_Click(null, null);
                chkStockPlanAll_Click(null, null);
                chkStockOrderAll_Click(null, null);
                chkStockInAll_Click(null, null);
                chkDrawPlanAll_Click(null, null);
                chkDrawOrderAll_Click(null, null);
                chkHalfGoodsAll_Click(null, null);
                chkGoodsOrderAll_Click(null, null);
                chkSellOrderAll_Click(null, null);
                chkOtherSellOrderAll_Click(null, null);
                chkQuitOrderAll_Click(null, null);
                chkQuitStorageOrderAll_Click(null, null);
                chkExcessOrderAll_Click(null, null);
                chkConsignAll_Click(null, null);
                chkConsignOutAll_Click(null, null);
                chkRejectOrderAll_Click(null, null);
                chkPaymentOrderAll_Click(null, null);
                chkIncomeOrderAll_Click(null, null);
                chkRemoveBillAll_Click(null, null);
                //chkReportAll_Click(null, null);
            }
            else
            {
                chkClientOrderAll.Checked = true;
                chkStockPlanAll.Checked = true;
                chkStockOrderAll.Checked = true;
                chkStockInAll.Checked = true;
                chkDrawPlanAll.Checked = true;
                chkDrawOrderAll.Checked = true;
                chkHalfGoodsAll.Checked = true;
                chkGoodsOrderAll.Checked = true;
                chkSellOrderAll.Checked = true;
                chkOtherSellOrderAll.Checked = true;
                chkQuitOrderAll.Checked = true;
                chkQuitStorageOrderAll.Checked = true;
                chkExcessOrderAll.Checked = true;
                chkConsignAll.Checked = true;
                chkConsignOutAll.Checked = true;
                chkRejectOrderAll.Checked = true;
                chkPaymentOrderAll.Checked = true;
                chkIncomeOrderAll.Checked = true;
                chkRemoveBillAll.Checked = true;
               // chkReportAll.Checked = true;


                chkClientOrderAll_Click(null, null);
                chkStockPlanAll_Click(null, null);
                chkStockOrderAll_Click(null, null);
                chkStockInAll_Click(null, null);
                chkDrawPlanAll_Click(null, null);
                chkDrawOrderAll_Click(null, null);
                chkHalfGoodsAll_Click(null, null);
                chkGoodsOrderAll_Click(null, null);
                chkSellOrderAll_Click(null, null);
                chkOtherSellOrderAll_Click(null, null);
                chkQuitOrderAll_Click(null, null);
                chkQuitStorageOrderAll_Click(null, null);
                chkExcessOrderAll_Click(null, null);
                chkConsignAll_Click(null, null);
                chkConsignOutAll_Click(null, null);
                chkRejectOrderAll_Click(null, null);
                chkPaymentOrderAll_Click(null, null);
                chkIncomeOrderAll_Click(null, null);
                chkRemoveBillAll_Click(null, null);
                //chkReportAll_Click(null, null);
            }


        }
        #endregion

        private void chkReportAll_Click(object sender, EventArgs e)
        {
            //
            if (chkReportAll.Checked == false)
            {
                chkStockReport.Checked = false;
                chkStockDetailReport.Checked = false;
                chkDrawOrderReport.Checked = false;
                chkQuitOrderReport.Checked = false;
                chkQuitStorageOrderReport.Checked = false;
                chkConsignReport.Checked = false;
                chkConsignOutReport.Checked = false;
                chkGoodsOrderReport.Checked = false;
                chkHalfGoodsReport.Checked = false;
                chkRejectOrderReport.Checked = false;
                chkExcessOrderReport.Checked = false;
                chkSellOrderReport.Checked = false;
                chkOtherSellOrderReport.Checked = false;
                chkOtherInOrderReport.Checked = false;
                chkIncomeOrderReport.Checked = false;
                chkPaymentOrderReport.Checked = false;
                chkClientOrderReport.Checked = false;
                chkStockInOrderReport.Checked = false;
                chkStockOrderReport.Checked = false;
                chkStockOrderStatusReport.Checked = false;
                chkClientOrderStatusReport.Checked = false;
                chkPaymentOrderReport1.Checked = false;
                chkInOutStorageReport.Checked = false;
                chkStockOrderInvoiceReport.Checked = false;
                chkProcessProduct.Checked = false;
                chkStockYJReport.Checked = false;

                
            
            }
            else
            {
                chkStockReport.Checked = true;
                chkStockDetailReport.Checked = true;
                chkDrawOrderReport.Checked = true;
                chkQuitOrderReport.Checked = true;
                chkQuitStorageOrderReport.Checked = true;
                chkConsignReport.Checked = true;
                chkConsignOutReport.Checked = true;
                chkGoodsOrderReport.Checked = true;
                chkHalfGoodsReport.Checked = true;
                chkRejectOrderReport.Checked = true;
                chkExcessOrderReport.Checked = true;
                chkSellOrderReport.Checked = true;
                chkOtherSellOrderReport.Checked = true;
                chkOtherInOrderReport.Checked = true;
                chkIncomeOrderReport.Checked = true;
                chkPaymentOrderReport.Checked = true;
                chkClientOrderReport.Checked = true;
                chkStockInOrderReport.Checked = true;
                chkStockOrderReport.Checked = true;
                chkStockOrderStatusReport.Checked = true;
                chkClientOrderStatusReport.Checked = true;
                chkPaymentOrderReport1.Checked = true;
                chkInOutStorageReport.Checked = true;
                chkStockOrderInvoiceReport.Checked = true;
                chkProcessProduct.Checked = true;
                chkStockYJReport.Checked = true;
            

            }
        }

        private void chkRemoveBillAll_Click(object sender, EventArgs e)
        {
            //调拨单
            if (chkRemoveBillAll.Checked == false)
            {
                chkRemoveBillSave.Checked = false;
                chkRemoveBillDelete.Checked = false;
                chkRemoveBillQry.Checked = false;
                chkRemoveBillCheck.Checked = false;
                chkRemoveBillUnCheck.Checked = false;
                chkRemoveBillCheck2.Checked = false;
                chkRemoveBillUnCheck2.Checked = false;
                chkRemoveBillPrint.Checked = false;
                
            }
            else
            {
                chkRemoveBillSave.Checked = true;
                chkRemoveBillDelete.Checked = true;
                chkRemoveBillQry.Checked = true;
                chkRemoveBillCheck.Checked = true;
                chkRemoveBillUnCheck.Checked = true;
                chkRemoveBillCheck2.Checked = true;
                chkRemoveBillUnCheck2.Checked = true;
                chkRemoveBillPrint.Checked = true;
            }
        }

        private void chklstGroup_Click_1(object sender, EventArgs e)
        {
           


            ((System.Windows.Forms.CheckedListBox)(sender)).CheckOnClick = true;
        }

        //其它入库单
        private void chkOtherInOrderAll_Click(object sender, EventArgs e)
        {
            if (chkOtherInOrderAll.Checked == false)
            {
                chkOtherInOrderSave.Checked = false;
                chkOtherInOrderDelete.Checked = false;
                chkOtherInOrderQry.Checked = false;
                chkOtherInOrderCheck.Checked = false;
                chkOtherInOrderUnCheck.Checked = false;
                chkOtherInOrderPrint.Checked = false;
            }
            else
            {
                chkOtherInOrderSave.Checked = true;
                chkOtherInOrderDelete.Checked = true;
                chkOtherInOrderQry.Checked = true;
                chkOtherInOrderCheck.Checked = true;
                chkOtherInOrderUnCheck.Checked = true;
                chkOtherInOrderPrint.Checked = true;
            }
        }

        //文件管理
        private void chkFileManageAll_Click(object sender, EventArgs e)
        {
            if (chkFileManageAll.Checked == false)
            {
                chkFileManage.Checked = false;
                chkFileView.Checked = false;
                
                chkFileApplyDelete.Checked = false;
                chkFileApplySave.Checked = false;
                chkFileApplyCheck.Checked = false;
                chkFileApplyUnCheck.Checked = false;
                chkFileApplyQry.Checked = false;

               
                chkFileInStorageDelete.Checked = false;
                chkFileInStorageSave.Checked = false;
                chkFileInStorageCheck.Checked = false;
                chkFileInStorageUnCheck.Checked = false;
                chkFileInStorageCheck2.Checked = false;
                chkFileInStorageUnCheck2.Checked = false;
                chkFileInStorageQry.Checked = false;

               
                chkFileChangeDelete.Checked = false;
                chkFileChangeSave.Checked = false;
                chkFileChangeQry.Checked = false;
                chkFileChangeCheck.Checked = false;
                chkFileChangeUnCheck.Checked = false;

                chkfjfftjb.Checked = false;
                chkfjsqtjb.Checked = false;
                chkfjzlylb.Checked = false;

                chkFileAllView.Checked = false;
                chkDeleteFile.Checked = false;
              
            }
            else
            {
                chkFileManage.Checked = true;
                chkFileView.Checked = true;
              
                chkFileApplyDelete.Checked = true;
                chkFileApplySave.Checked = true;
                chkFileApplyCheck.Checked = true;
                chkFileApplyUnCheck.Checked = true;
                chkFileApplyQry.Checked = true;

             
                chkFileInStorageDelete.Checked = true;
                chkFileInStorageSave.Checked = true;
                chkFileInStorageCheck.Checked = true;
                chkFileInStorageUnCheck.Checked = true;
                chkFileInStorageCheck2.Checked = true;
                chkFileInStorageUnCheck2.Checked = true;
                chkFileInStorageQry.Checked = true;

            
                chkFileChangeDelete.Checked = true;
                chkFileChangeSave.Checked = true;
                chkFileChangeQry.Checked = true;
                chkFileChangeCheck.Checked = true;
                chkFileChangeUnCheck.Checked = true;

                chkfjfftjb.Checked = true;
                chkfjsqtjb.Checked = true;
                chkfjzlylb.Checked = true;

                chkFileAllView.Checked = true;
                chkDeleteFile.Checked = true;
            }
        }

        private void chklstGroup_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.CurrentValue == CheckState.Checked) return;
            for (int i = 0; i < ((CheckedListBox)sender).Items.Count; i++)
            {
                ((CheckedListBox)sender).SetItemChecked(i, false);
            }
            e.NewValue = CheckState.Checked;

        }

    }
}