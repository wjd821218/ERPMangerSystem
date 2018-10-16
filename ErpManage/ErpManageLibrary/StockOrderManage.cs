using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;

namespace ErpManageLibrary
{
    /// <summary>
    /// 采购订单控制
    /// </summary>
    public class StockOrderManage
    {

        ///<summary>
        /// 保存数据
        /// </summary>
        /// <param name="pObj">信息集实体类</param>
        /// <returns>返回保存成功(true)或失败(false)</returns>
        public void SaveBill(StockOrder StockOrder, List<StockOrderDetail> StockOrderDetail)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from StockOrder where  StockOrderGuid='" + StockOrder.StockOrderGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入主表数据
                string strInsertSql = GetAddBillSQL(StockOrder);
                pComm.Execute(strInsertSql);


                //删除明细表
                strDeleteSql = "Delete from StockOrderDetail where  StockOrderGuid='" + StockOrder.StockOrderGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入明细表数据
                for (int i = 0; i < StockOrderDetail.Count; i++)
                {
                    strInsertSql = GetAddBillDetailSQL(StockOrderDetail[i]);
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
        public void DeleteBill(string StockOrderguid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from StockOrder where  StockOrderGuid='" + StockOrderguid + "'";
                pComm.Execute(strDeleteSql);


                //删除明细表
                strDeleteSql = "Delete from StockOrderDetail where  StockOrderGuid='" + StockOrderguid + "'";
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
        public string GetAddBillSQL(StockOrder StockOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into StockOrder(");
            strSql.Append("StockOrderGuid,StockOrderID,SupplierGuid,StockOrderDate,Linkman,Telephone,Fax,MALinkman,MATelephone,MAFax,Remark,CreateGuid,CreateDate,CheckGuid,CheckDate,EndGuid,EndDate");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + StockOrder.StockOrderGuid + "',");
            strSql.Append("'" + StockOrder.StockOrderID + "',");
            strSql.Append("'" + StockOrder.SupplierGuid + "',");
            strSql.Append("'" + StockOrder.StockOrderDate + "',");
            strSql.Append("'" + StockOrder.Linkman + "',");
            strSql.Append("'" + StockOrder.Telephone + "',");
            strSql.Append("'" + StockOrder.Fax + "',");
            strSql.Append("'" + StockOrder.MALinkman + "',");
            strSql.Append("'" + StockOrder.MATelephone + "',");
            strSql.Append("'" + StockOrder.MAFax + "',");
            strSql.Append("'" + StockOrder.Remark + "',");
            strSql.Append("'" + StockOrder.CreateGuid + "',");
            strSql.Append("'" + StockOrder.CreateDate + "',");
            strSql.Append("'" + StockOrder.CheckGuid + "',");
            if (StockOrder.CheckDate == DateTime.Parse("1900-01-01"))
            {
                strSql.Append("null,");
            }
            else
            {
                strSql.Append("'" + StockOrder.CheckDate + "',");
            }
            strSql.Append("'" + StockOrder.EndGuid + "',");
            if (StockOrder.EndDate == DateTime.Parse("1900-01-01"))
            {
                strSql.Append("null");
            }
            else
            {
                strSql.Append("'" + StockOrder.EndDate + "'");
            }
            strSql.Append(")");
            return strSql.ToString();

        }


        /// <summary>
        /// 得到增加一条明细的SQL
        /// </summary>
        public string GetAddBillDetailSQL(StockOrderDetail StockOrderDetail)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into StockOrderDetail(");
            strSql.Append("StockOrderGuid,MaterialGuid,MaterialPrice,MaterialSum,MaterialTotalMoney,ArriveDate");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + StockOrderDetail.StockOrderGuid + "',");
            strSql.Append("'" + StockOrderDetail.MaterialGuID + "',");
            strSql.Append("" + StockOrderDetail.MaterialPrice + ",");
            strSql.Append("" + StockOrderDetail.MaterialSum + ",");
            strSql.Append("" + StockOrderDetail.MaterialTotalMoney + ",");
            strSql.Append("'" + StockOrderDetail.ArriveDate + "'");
            strSql.Append(")");
            return strSql.ToString();
        }



        /// <summary>
        /// 得到采购订单的明细
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetStockOrderDetail(string StockOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select   *   from  V_StockOrderDetail  where StockOrderGuid='" + StockOrderGuid + "' order by sortid";
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
        /// 得到采购订单的明细-----提供给采购入库单从采购订单选择界面
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetStockOrderDetailBySelect(string StockOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select   'False' as selectvalue,*   from  V_StockOrderDetail  where StockOrderGuid='" + StockOrderGuid + "' order by sortid";
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
        /// 得到采购订单主表数据----提供给采购入库单从采购订单选择界面
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetStockOrderBySQL_Select(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select     *   from    V_StockOrder " + strsql + " order by CreateDate desc";
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
        public DataTable GetStockOrderBySQL(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  StockOrder " + strsql + " order by CreateDate desc";
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
        public DataTable GetStockOrderBySQL_CN(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select     *   from    V_StockOrder " + strsql + " order by CreateDate desc";
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
        public DataTable GetStockOrderByStockOrderGuid(string StockOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_StockOrder where StockOrderGuid='" + StockOrderGuid + "' order by CreateDate desc";
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
        /// 更新审核状态度
        /// </summary>
        /// <returns></returns>
        public void CheckBill(string StockOrderGuid, int pass)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "";
                //删除主表
                if (pass == 1)
                {
                    //通过
                    ps_Sql = "update StockOrder  set CheckGuid='" + SysParams.UserID + "',CheckDate='" + DateTime.Now.ToString() + "'  where StockOrderGuid='" +StockOrderGuid + "'";

                }
                else
                {
                    //不通过
                    ps_Sql = "update StockOrder  set CheckGuid='',CheckDate=null  where StockOrderGuid='" +StockOrderGuid + "'";

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
        /// 结单
        /// </summary>
        /// <returns></returns>
        public void EndBill(string StockOrderGuid)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "";

                //结单
                ps_Sql = "update StockOrder  set EndGuid='" + SysParams.UserID + "',EndDate='" + DateTime.Now.ToString() + "'  where StockOrderGuid='" +StockOrderGuid + "'";

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
        /// 得到采购订单主表数据
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public string GetMaterialByStockOrderDetailGuid(string StockOrderDetailGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  MaterialGuid   from  StockOrderDetail where StockOrderDetailGuid='" + StockOrderDetailGuid + "'";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

                pObj_Comm.Close();

                if (pDTMain.Rows.Count > 0)
                {
                    return pDTMain.Rows[0]["MaterialGuid"].ToString().Trim();
                }
                else
                {
                    return "";
                }

               
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
        public bool GetIsCheck(string StockOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  StockOrderGuid,CheckGuid,EndGuid  from   StockOrder where StockOrderGuid='" + StockOrderGuid + "' ";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

                pObj_Comm.Close();

                if (pDTMain.Rows.Count > 0)
                {
                    if (pDTMain.Rows[0]["CheckGuid"].ToString().Trim() != "")
                    {
                        return true;
                    }
                    if (pDTMain.Rows[0]["EndGuid"].ToString().Trim() != "")
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


        //----------------------------------------------------------
        /// <summary>
        /// 删除采购订单时得到此采购订单已经被使用的采购入库单号
        /// </summary>
        /// <returns></returns>
        public DataTable GetStockOrderIDAndPaymentOrderID(string StockOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select distinct StockInOrderID from V_StockInOrderAndStockInOrderDetail  where StockOrderGuid='" + StockOrderGuid + "' order by StockInOrderID desc";
                
                
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

    }
}
