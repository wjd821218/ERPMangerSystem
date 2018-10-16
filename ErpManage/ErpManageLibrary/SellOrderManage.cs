using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;

namespace ErpManageLibrary
{
    /// <summary>
    /// 其它出库单
    /// </summary>
    public class SellOrderManage
    {
          ///<summary>
        /// 保存数据
        /// </summary>
        /// <param name="pObj">信息集实体类</param>
        /// <returns>返回保存成功(true)或失败(false)</returns>
        public void SaveBill(SellOrder SellOrder, List<SellOrderDetail> SellOrderDetail)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from SellOrder where  SellOrderGuid='" + SellOrder.SellOrderGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入主表数据
                string strInsertSql = GetAddBillSQL(SellOrder);
                pComm.Execute(strInsertSql);


                //删除明细表
                strDeleteSql = "Delete from SellOrderDetail where  SellOrderGuid='" + SellOrder.SellOrderGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入明细表数据
                for (int i = 0; i < SellOrderDetail.Count; i++)
                {
                    strInsertSql = GetAddBillDetailSQL(SellOrderDetail[i]);
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
        public void DeleteBill(string SellOrderguid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from SellOrder where  SellOrderGuid='" + SellOrderguid + "'";
                pComm.Execute(strDeleteSql);


                //删除明细表
                strDeleteSql = "Delete from SellOrderDetail where  SellOrderGuid='" + SellOrderguid + "'";
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
        public string GetAddBillSQL(SellOrder SellOrder)
        {
             StringBuilder strSql = new StringBuilder();
             strSql.Append("insert into SellOrder(");
             strSql.Append("SellOrderGuid,SellOrderID,Client,SellOrderDate,OutStorage,StoragePerson,QualityPerson,Shipping,Remark,CreateGuid,CreateDate,CheckGuid,CheckDate");
             strSql.Append(")");
             strSql.Append(" values (");
             strSql.Append("'" + SellOrder.SellOrderGuid + "',");
             strSql.Append("'" + SellOrder.SellOrderID + "',");
             strSql.Append("'" + SellOrder.Client + "',");
             strSql.Append("'" + SellOrder.SellOrderDate + "',");
             strSql.Append("'" + SellOrder.OutStorage + "',");
             strSql.Append("'" + SellOrder.StoragePerson + "',");
             strSql.Append("'" + SellOrder.QualityPerson + "',");
             strSql.Append("'" + SellOrder.Shipping + "',");
             strSql.Append("'" + SellOrder.Remark + "',");
             strSql.Append("'" + SellOrder.CreateGuid + "',");
             strSql.Append("'" + SellOrder.CreateDate + "',");
             strSql.Append("'" + SellOrder.CheckGuid + "',");
             if (SellOrder.CheckDate == DateTime.Parse("1900-01-01"))
             {
                 strSql.Append("null");
             }
             else
             {
                 strSql.Append("'" + SellOrder.CheckDate + "'");
             }
             strSql.Append(")");
            return strSql.ToString();

        }


        /// <summary>
        /// 得到增加一条明细的SQL
        /// </summary>
        public string GetAddBillDetailSQL(SellOrderDetail SellOrderDetail)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [SellOrderDetail](");
            strSql.Append("SellOrderGuid,ClientOrderGuid,ClientOrderID,ClientOrderDetailGuid,MaterialGuID,Price,MaterialSum,MaterialMoney,BoxSum,Remark,SortID");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + SellOrderDetail.SellOrderGuid + "',");
            strSql.Append("'" + SellOrderDetail.ClientOrderGuid + "',");
            strSql.Append("'" + SellOrderDetail.ClientOrderID + "',");
            strSql.Append("'" + SellOrderDetail.ClientOrderDetailGuid + "',");
            strSql.Append("'" + SellOrderDetail.MaterialGuID + "',");
            strSql.Append("" + SellOrderDetail.Price + ",");
            strSql.Append("" + SellOrderDetail.MaterialSum + ",");
            strSql.Append("" + SellOrderDetail.MaterialMoney + ",");
            strSql.Append("" + SellOrderDetail.BoxSum + ",");
            strSql.Append("'" + SellOrderDetail.Remark + "',");
            strSql.Append("" + SellOrderDetail.SortID + "");
            strSql.Append(")");
            return strSql.ToString();
        }



        /// <summary>
        /// 得到领料单的明细
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetSellOrderDetail(string SellOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select   *   from  V_SellOrderDetail  where SellOrderGuid='" + SellOrderGuid + "' order by sortid";
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
        /// 得到领料单主表数据
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetSellOrderBySQL(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_SellOrder " + strsql + " order by CreateDate desc";
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
        public DataTable GetSellOrderBySellOrderGuid(string SellOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_SellOrder where SellOrderGuid='" + SellOrderGuid + "'";
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


        //销售出库单从客户订单中选择数据，这里是加载数据,数据中已经包括:客户订单数量,已出库数量,可出库数量
        public DataTable sp_GetSelectClientOrderData(string strClientOrderGuID, string begindate, string enddate)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[3, 2];
                par[0, 0] = "@ClientOrderGuID";
                par[0, 1] = strClientOrderGuID;
                par[1, 0] = "@BeginDate";
                par[1, 1] = begindate;
                par[2, 0] = "@EndDate";
                par[2, 1] = enddate;

                dset = pComm.ExcuteSp("sp_GetSelectClientOrderData", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }


        //客户订单执行情况
        public DataTable sp_GetSelectClientOrderDataReport(string strClientOrderID, string begindate, string enddate,string endflag)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[4, 2];
                par[0, 0] = "@ClientOrderID";
                par[0, 1] = strClientOrderID;
                par[1, 0] = "@BeginDate";
                par[1, 1] = begindate;
                par[2, 0] = "@EndDate";
                par[2, 1] = enddate;
                par[3, 0] = "@endFlag";
                par[3, 1] = endflag;

                dset = pComm.ExcuteSp("sp_GetSelectClientOrderDataReport", par);

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
        public void CheckBill(string SellOrderGuid, int pass)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "";
                //删除主表
                if (pass == 1)
                {
                    //通过
                    ps_Sql = "update SellOrder  set CheckGuid='" + SysParams.UserID + "',CheckDate='" + DateTime.Now.ToString() + "'  where SellOrderGuid='" + SellOrderGuid + "'";

                }
                else
                {
                    //不通过
                    ps_Sql = "update SellOrder  set CheckGuid='',CheckDate=null  where SellOrderGuid='" + SellOrderGuid + "'";

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
        /// 更新审核状态度-二级审核
        /// </summary>
        /// <returns></returns>
        public void CheckBill2(string SellOrderGuid, int pass)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "";
                //删除主表
                if (pass == 1)
                {
                    //通过
                    ps_Sql = "update  SellOrder  set CheckGuid2='" + SysParams.UserID + "',CheckDate2='" + DateTime.Now.ToString() + "'  where  SellOrderGuid='" + SellOrderGuid + "'";

                }
                else
                {
                    //不通过
                    ps_Sql = "update  SellOrder  set CheckGuid2='',CheckDate2=null  where  SellOrderGuid='" + SellOrderGuid + "'";

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
        /// 得到客户订单是否已审核或已结单-
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public bool GetIsCheck(string SellOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  SellOrderGuid,CheckGuid,CheckGuid2  from   SellOrder where SellOrderGuid='" + SellOrderGuid + "' ";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

                pObj_Comm.Close();

                if (pDTMain.Rows.Count > 0)
                {
                    if (pDTMain.Rows[0]["CheckGuid"].ToString().Trim() != "")
                    {
                        return true;
                    }

                    if (pDTMain.Rows[0]["CheckGuid2"].ToString().Trim() != "")
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
    }
}

