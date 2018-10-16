using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Daniel.Liu.DAO;

namespace ErpManageLibrary
{
    /// <summary>
    /// 统计报表控制类
    /// </summary>
    public class StatReportManage
    {

        /// <summary>
        /// 库存报表
        /// </summary>
        /// <param name="MaterialGuid"></param>
        /// <param name="StorageID"></param>
        /// <param name="MaterialTypeGuid"></param>
        /// <param name="EndDate"></param>
        /// <returns></returns>
        public DataTable StockReport(string MaterialGuid, string StorageID, string MaterialTypeGuid, string EndDate)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[4, 2];
                par[0, 0] = "@MaterialGuid";
                par[0, 1] = MaterialGuid;
                par[1, 0] = "@StorageID";
                par[1, 1] = StorageID;
                par[2, 0] = "@MaterialTypeGuid";
                par[2, 1] = MaterialTypeGuid;
                par[3, 0] = "@EndDate";
                par[3, 1] = EndDate;

                dset = pComm.ExcuteSp("sp_GetStorageReport", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }


        /// <summary>
        /// 库存明细报表
        /// </summary>
        /// <param name="MaterialGuid"></param>
        /// <param name="StorageID"></param>
        public DataTable StockDetailReport(string MaterialGuid, string StorageID)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[2, 2];
                par[0, 0] = "@Depot";
                par[0, 1] = StorageID;
                par[1, 0] = "@MaterialGuID";
                par[1, 1] = MaterialGuid;
                dset = pComm.ExcuteSp("sp_GetStorageMaterialDetailSum", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }

        /// <summary>
        /// 销售出库统计报表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_SellOrder_Report(string strWheresql)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@strWheresql";
                par[0, 1] = strWheresql;

                dset = pComm.ExcuteSp("sp_SellOrder_Report", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }



        /// <summary>
        /// 销售出库明细报表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_SellOrderDetail_Report(string strWheresql)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@strWheresql";
                par[0, 1] = strWheresql;

                dset = pComm.ExcuteSp("sp_SellOrderDetail_Report", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }




        /// <summary>
        /// 客户订单统计报表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_ClientOrder_Report(string strWheresql)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@strWheresql";
                par[0, 1] = strWheresql;

                dset = pComm.ExcuteSp("sp_ClientOrder_Report", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }


        /// <summary>
        /// 客户订单明细报表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_ClientOrderDetail_Report(string strWheresql)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@strWheresql";
                par[0, 1] = strWheresql;

                dset = pComm.ExcuteSp("sp_ClientOrderDetail_Report", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }



        /// <summary>
        /// 半成品入库单统计报表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_HalfGoods_Report(string strWheresql)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@strWheresql";
                par[0, 1] = strWheresql;

                dset = pComm.ExcuteSp("sp_HalfGoods_Report", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }


        /// <summary>
        ///  半成品入库单明细报表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_HalfGoodsDetail_Report(string strWheresql)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@strWheresql";
                par[0, 1] = strWheresql;

                dset = pComm.ExcuteSp("sp_HalfGoodsDetail_Report", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }



        /// <summary>
        /// 成品入库单统计报表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_GoodsOrder_Report(string strWheresql)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@strWheresql";
                par[0, 1] = strWheresql;

                dset = pComm.ExcuteSp("sp_GoodsOrder_Report", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }


        /// <summary>
        ///  成品入库单明细报表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_GoodsOrderDetail_Report(string strWheresql)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@strWheresql";
                par[0, 1] = strWheresql;

                dset = pComm.ExcuteSp("sp_GoodsOrderDetail_Report", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }


        /// <summary>
        /// 采购订单统计报表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_StockOrder_Report(string strWheresql)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@strWheresql";
                par[0, 1] = strWheresql;

                dset = pComm.ExcuteSp("sp_StockOrder_Report", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }


        /// <summary>
        ///  采购订单明细报表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_StockOrderDetail_Report(string strWheresql)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@strWheresql";
                par[0, 1] = strWheresql;

                dset = pComm.ExcuteSp("sp_StockOrderDetail_Report", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }



        /// <summary>
        /// 采购入库单统计报表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_StockInOrder_Report(string strWheresql)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@strWheresql";
                par[0, 1] = strWheresql;

                dset = pComm.ExcuteSp("sp_StockInOrder_Report", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }


        /// <summary>
        ///  采购入库单明细报表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_StockInOrderDetail_Report(string strWheresql)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@strWheresql";
                par[0, 1] = strWheresql;

                dset = pComm.ExcuteSp("sp_StockInOrderDetail_Report", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }



        /// <summary>
        /// 领料单统计报表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_DrawOrder_Report(string strWheresql)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@strWheresql";
                par[0, 1] = strWheresql;

                dset = pComm.ExcuteSp("sp_DrawOrder_Report", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }


        /// <summary>
        ///   领料单明细报表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_DrawOrderDetail_Report(string strWheresql)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@strWheresql";
                par[0, 1] = strWheresql;

                dset = pComm.ExcuteSp("sp_DrawOrderDetail_Report", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }


        /// <summary>
        /// 超领单统计报表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_ExcessOrder_Report(string strWheresql)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@strWheresql";
                par[0, 1] = strWheresql;

                dset = pComm.ExcuteSp("sp_ExcessOrder_Report", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }


        /// <summary>
        ///   超领单明细报表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_ExcessOrderDetail_Report(string strWheresql)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@strWheresql";
                par[0, 1] = strWheresql;

                dset = pComm.ExcuteSp("sp_ExcessOrderDetail_Report", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }



        /// <summary>
        /// 退料单统计报表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_QuitOrder_Report(string strWheresql)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@strWheresql";
                par[0, 1] = strWheresql;

                dset = pComm.ExcuteSp("sp_QuitOrder_Report", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }


        /// <summary>
        ///   退料单明细报表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_QuitOrderDetail_Report(string strWheresql)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@strWheresql";
                par[0, 1] = strWheresql;

                dset = pComm.ExcuteSp("sp_QuitOrderDetail_Report", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }


        /// <summary>
        /// 其它出库单统计报表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_OtherSellOrder_Report(string strWheresql)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@strWheresql";
                par[0, 1] = strWheresql;

                dset = pComm.ExcuteSp("sp_OtherSellOrder_Report", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }


        /// <summary>
        ///   其它出库单明细报表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_OtherSellOrderDetail_Report(string strWheresql)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@strWheresql";
                par[0, 1] = strWheresql;

                dset = pComm.ExcuteSp("sp_OtherSellOrderDetail_Report", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }



        /// <summary>
        /// 其它入库单统计报表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_OtherInOrder_Report(string strWheresql)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@strWheresql";
                par[0, 1] = strWheresql;

                dset = pComm.ExcuteSp("sp_OtherInOrder_Report", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }


        /// <summary>
        ///   其它入库单明细报表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_OtherInOrderDetail_Report(string strWheresql)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@strWheresql";
                par[0, 1] = strWheresql;

                dset = pComm.ExcuteSp("sp_OtherInOrderDetail_Report", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }



        /// <summary>
        /// 委外加工入库单统计报表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_Consign_Report(string strWheresql)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@strWheresql";
                par[0, 1] = strWheresql;

                dset = pComm.ExcuteSp("sp_Consign_Report", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }


        /// <summary>
        ///   委外加工入库单明细报表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_ConsignDetail_Report(string strWheresql)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@strWheresql";
                par[0, 1] = strWheresql;

                dset = pComm.ExcuteSp("sp_ConsignDetail_Report", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }


        /// <summary>
        /// 委外加工出库单统计报表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_ConsignOut_Report(string strWheresql)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@strWheresql";
                par[0, 1] = strWheresql;

                dset = pComm.ExcuteSp("sp_ConsignOut_Report", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }


        /// <summary>
        ///   委外加工出库单明细报表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_ConsignOutDetail_Report(string strWheresql)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@strWheresql";
                par[0, 1] = strWheresql;

                dset = pComm.ExcuteSp("sp_ConsignOutDetail_Report", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }


        /// <summary>
        /// 退料入库单统计报表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_QuitStorageOrder_Report(string strWheresql)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@strWheresql";
                par[0, 1] = strWheresql;

                dset = pComm.ExcuteSp("sp_QuitStorageOrder_Report", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }


        /// <summary>
        ///   退料入库单单明细报表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_QuitStorageOrderDetail_Report(string strWheresql)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@strWheresql";
                par[0, 1] = strWheresql;

                dset = pComm.ExcuteSp("sp_QuitStorageOrderDetail_Report", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }



        /// <summary>
        /// 报废单统计报表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_RejectOrder_Report(string strWheresql)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@strWheresql";
                par[0, 1] = strWheresql;

                dset = pComm.ExcuteSp("sp_RejectOrder_Report", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }


        /// <summary>
        ///   报废单明细报表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_RejectOrderDetail_Report(string strWheresql)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@strWheresql";
                par[0, 1] = strWheresql;

                dset = pComm.ExcuteSp("sp_RejectOrderDetail_Report", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }


        /// <summary>
        ///   采购付款单报表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_Payment_Report(string strbegindate,string strenddate)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[2, 2];
                par[0, 0] = "@BeginDate";
                par[0, 1] = strbegindate;
                par[1, 0] = "@EndDate";
                par[1, 1] = strenddate;


                dset = pComm.ExcuteSp("sp_Payment_Report", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }



        /// <summary>
        ///  采购入库单是否已开票报表(已勾结，未勾结)
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_GetStockInOrderStatus_Report(string StockInOrderID, string strbegindate, string strenddate, string SupplierGuid, string IsInvoice)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[5, 2];
                par[0, 0] = "@StockInOrderID";
                par[0, 1] = StockInOrderID;
                par[1, 0] = "@BeginDate";
                par[1, 1] = strbegindate;
                par[2, 0] = "@EndDate";
                par[2, 1] = strenddate;
                par[3, 0] = "@SupplierGuid";
                par[3, 1] = SupplierGuid;
                par[4, 0] = "@IsInvoice";
                par[4, 1] = IsInvoice;


                dset = pComm.ExcuteSp("sp_GetStockInOrderStatus", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }

        /// <summary>
        ///  收发存汇总表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_GetInOutStorageSum(string strbegindate, string strenddate, string MaterialGuid, string StorageID, string MaterialTypeGuid,string SupplierGuid)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[6, 2];
                par[0, 0] = "@BeginDate";
                par[0, 1] = strbegindate;
                par[1, 0] = "@EndDate";
                par[1, 1] = strenddate;
                par[2, 0] = "@MaterialGuid";
                par[2, 1] = MaterialGuid;
                par[3, 0] = "@StorageID";
                par[3, 1] = StorageID;
                par[4, 0] = "@MaterialTypeGuid";
                par[4, 1] = MaterialTypeGuid;
                par[5, 0] = "@Supplier";
                par[5, 1] = SupplierGuid;


                dset = pComm.ExcuteSp("sp_GetInOutStorageSum", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }

        /// <summary>
        /// 在制品报表
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable sp_ProcessProduct(string MaterialGuid)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@MaterialGuid";
                par[0, 1] = MaterialGuid;

                dset = pComm.ExcuteSp("sp_ProcessProduct", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }



        /// <summary>
        /// 得到某个物料入库的所有批号情况
        /// </summary>
        /// <param name="MaterialGuid"></param>
        /// <param name="StorageID"></param>
        public DataTable sp_GetStorageSumBatchNo(string MaterialGuid)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@MaterialGuID";
                par[0, 1] = MaterialGuid;

                dset = pComm.ExcuteSp("sp_GetStorageSumBatchNo", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }


    }
}
