using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;

namespace ErpManageLibrary
{
    /// <summary>
    /// 采购入库单管理
    /// </summary>
    public class StockInOrderManage
    {

        ///<summary>
        /// 保存数据
        /// </summary>
        /// <param name="pObj">信息集实体类</param>
        /// <returns>返回保存成功(true)或失败(false)</returns>
        public void SaveBill(StockInOrder StockInOrder, List<StockInOrderDetail> StockInOrderDetail)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from StockInOrder where  StockInOrderGuid='" + StockInOrder.StockInOrderGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入主表数据
                string strInsertSql = GetAddBillSQL(StockInOrder);
                pComm.Execute(strInsertSql);


                //删除明细表
                strDeleteSql = "Delete from StockInOrderDetail where  StockInOrderGuid='" + StockInOrder.StockInOrderGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入明细表数据
                for (int i = 0; i < StockInOrderDetail.Count; i++)
                {
                    strInsertSql = GetAddBillDetailSQL(StockInOrderDetail[i]);
                    pComm.Execute(strInsertSql);
                }


                pComm.CommitTrans();

            }
            catch (Exception e)
            {
                pComm.RollbackTrans();
                pComm.Close();
                throw e;

            }
        }


        ///<summary>
        ///删除数据
        /// </summary>
        /// <param name="pObj">信息集实体类</param>
        /// <returns>返回保存成功(true)或失败(false)</returns>
        public void DeleteBill(string StockInOrderguid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from StockInOrder where  StockInOrderGuid='" + StockInOrderguid + "'";
                pComm.Execute(strDeleteSql);


                //删除明细表
                strDeleteSql = "Delete from StockInOrderDetail where  StockInOrderGuid='" + StockInOrderguid + "'";
                pComm.Execute(strDeleteSql);


                pComm.CommitTrans();

            }
            catch (Exception e)
            {
                pComm.RollbackTrans();
                pComm.Close();
                throw e;

            }
        }




        /// <summary>
        /// 得到新增sql
        /// </summary>
        public string GetAddBillSQL(StockInOrder StockInOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into StockInOrder(");
            strSql.Append("StockInOrderGuid,StockInOrderID,StockInOrderDate,SupplierGuid,InStorage,StockPerson,StoragePerson,BatchNO,Remark,CreateGuid,CreateDate,CheckGuid,CheckDate");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + StockInOrder.StockInOrderGuid + "',");
            strSql.Append("'" + StockInOrder.StockInOrderID + "',");
            strSql.Append("'" + StockInOrder.StockInOrderDate + "',");
            strSql.Append("'" + StockInOrder.SupplierGuid + "',");
            strSql.Append("'" + StockInOrder.InStorage + "',");
            strSql.Append("'" + StockInOrder.StockPerson + "',");
            strSql.Append("'" + StockInOrder.StoragePerson + "',");
            strSql.Append("'" + StockInOrder.BatchNO + "',");
            strSql.Append("'" + StockInOrder.Remark + "',");
            strSql.Append("'" + StockInOrder.CreateGuid + "',");
            strSql.Append("'" + StockInOrder.CreateDate + "',");
            strSql.Append("'" + StockInOrder.CheckGuid + "',");
            if (StockInOrder.CheckDate == DateTime.Parse("1900-01-01"))
            {
                strSql.Append("null");
            }
            else
            {
                strSql.Append("'" + StockInOrder.CheckDate + "'");
            }
            strSql.Append(")");

            return strSql.ToString();

        }


        /// <summary>
        /// 得到增加一条明细的SQL
        /// </summary>
        public string GetAddBillDetailSQL(StockInOrderDetail StockInOrderDetail)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into StockInOrderDetail(");
            strSql.Append("StockInOrderGuid,StockOrderGuid,StockOrderID,StockOrderDetailGuid,MaterialGuID,MaterialSum,DeliverySum,StorageSum,Remark");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + StockInOrderDetail.StockInOrderGuid + "',");
            strSql.Append("'" + StockInOrderDetail.StockOrderGuid + "',");
            strSql.Append("'" + StockInOrderDetail.StockOrderID + "',");
            strSql.Append("'" + StockInOrderDetail.StockOrderDetailGuid + "',");
            strSql.Append("'" + StockInOrderDetail.MaterialGuID + "',");
            strSql.Append("" + StockInOrderDetail.MaterialSum + ",");
            strSql.Append("" + StockInOrderDetail.DeliverySum + ",");
            strSql.Append("" + StockInOrderDetail.StorageSum + ",");
            strSql.Append("'" + StockInOrderDetail.Remark + "'");
            strSql.Append(")");
            return strSql.ToString();
        }


        /// <summary>
        /// 得到采购订单的明细
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetStockInOrderDetail(string StockInOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select   *   from  V_StockInOrderDetail  where StockInOrderGuid='" + StockInOrderGuid + "' order by sortid";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

                pObj_Comm.Close();

                return pDTMain;
            }
            catch (Exception e)
            {
                pObj_Comm.Close();
                throw e;
            }
        }

         /// <summary>
        /// 得到采购入库单的明细
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetStockInOrderDetailBySelect(string StockInOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select   'False' as selectvalue,*   from  V_StockInOrderDetail  where StockInOrderGuid='" + StockInOrderGuid + "' order by sortid";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

                pObj_Comm.Close();

                return pDTMain;
            }
            catch (Exception e)
            {
                pObj_Comm.Close();
                throw e;
            }
        }


       


        /// <summary>
        /// 得到采购订单主表数据
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetStockInOrderBySQL(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_StockInOrder " + strsql + " order by CreateDate desc";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

                pObj_Comm.Close();

                return pDTMain;
            }
            catch (Exception e)
            {
                pObj_Comm.Close();
                throw e;
            }
        }


        /// <summary>
        /// 得到采购订单主表数据
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetStockInOrderByStockInOrderGuid(string StockInOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_StockInOrder where StockInOrderGuid='" + StockInOrderGuid + "'";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

                pObj_Comm.Close();

                return pDTMain;
            }
            catch (Exception e)
            {
                pObj_Comm.Close();
                throw e;
            }
        }



        //采购入库单从采购订单中选择数据，这里是加载数据,数据中已经包括: 采购订单数量,已入库数量,可入库数量
        public DataTable sp_GetSelectStockOrderData(string strStockOrderGuID,string begindate,string enddate)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[3, 2];
                par[0, 0] = "@StockOrderGuID";
                par[0, 1] = strStockOrderGuID;
                par[1, 0] = "@BeginDate";
                par[1, 1] = begindate;
                par[2, 0] = "@EndDate";
                par[2, 1] = enddate;

                dset = pComm.ExcuteSp("sp_GetSelectStockOrderData", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }



        //采购订单执行情况报表,
        public DataTable sp_GetSelectStockOrderDataReport(string strStockOrderID, string begindate, string enddate,string endflag)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[4, 2];
                par[0, 0] = "@StockOrderID";
                par[0, 1] = strStockOrderID;
                par[1, 0] = "@BeginDate";
                par[1, 1] = begindate;
                par[2, 0] = "@EndDate";
                par[2, 1] = enddate;
                par[3, 0] = "@endFlag";
                par[3, 1] = endflag;

                dset = pComm.ExcuteSp("sp_GetSelectStockOrderDataReport", par);

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
        /// 更新审核状态度
        /// </summary>
        /// <returns></returns>
        public void CheckBill(string StockInOrderGuid, int pass)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "";
                //删除主表
                if (pass == 1)
                {
                    //通过
                    ps_Sql = "update StockInOrder  set CheckGuid='" + SysParams.UserID + "',CheckDate='" + DateTime.Now.ToString() + "'  where StockInOrderGuid='" + StockInOrderGuid + "'";

                }
                else
                {
                    //不通过
                    ps_Sql = "update StockInOrder  set CheckGuid='',CheckDate=null  where StockInOrderGuid='" + StockInOrderGuid + "'";

                }

                pObj_Comm.Execute(ps_Sql);
                pObj_Comm.Close();
            }
            catch (Exception e)
            {

                pObj_Comm.Close();
                throw e;
            }
        }

        /// <summary>
        /// 得到订单是否已审核或已结单-
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public bool GetIsCheck(string StockInOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  StockInOrderGuid,CheckGuid from   StockInOrder where StockInOrderGuid='" + StockInOrderGuid + "' ";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

                pObj_Comm.Close();

                if (pDTMain.Rows.Count > 0)
                {
                    if (pDTMain.Rows[0]["CheckGuid"].ToString().Trim() != "")
                    {
                        return true;
                    }
                 
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                pObj_Comm.Close();
                throw e;
            }
        }

        /// <summary>
        /// 根据采购订单号与物料号来取得这个料件做采购订单中的单价
        /// </summary>
        /// <param name="StockOrderGuid"></param>
        /// <param name="MaterialGuID"></param>
        /// <returns></returns>
        public decimal GetStockOrderPriceByMaterial(string StockOrderGuid,string MaterialGuID)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  MaterialPrice  from   StockOrderDetail where StockOrderGuid='" + StockOrderGuid + "' and  MaterialGuID='" + MaterialGuID + "'";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

                pObj_Comm.Close();

                if (pDTMain.Rows.Count > 0)
                {
                    if (pDTMain.Rows[0]["MaterialPrice"].ToString().Trim() != "")
                    {
                        return decimal.Parse(pDTMain.Rows[0]["MaterialPrice"].ToString());
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                pObj_Comm.Close();
                throw e;
            }
        }


    }
}
