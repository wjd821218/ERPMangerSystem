using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;

namespace ErpManageLibrary
{
    public class ClientOrderManage
    {
        ///<summary>
        /// 保存数据
        /// </summary>
        /// <param name="pObj">信息集实体类</param>
        /// <returns>返回保存成功(true)或失败(false)</returns>
        public void SaveBill(ClientOrder clientOrder, List<ClientOrderDetail> clientOrderDetail)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from ClientOrder where  ClientOrderGuid='" + clientOrder.ClientOrderGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入主表数据
                string strInsertSql = GetAddBillSQL(clientOrder);
                pComm.Execute(strInsertSql);


                //删除明细表
                strDeleteSql = "Delete from ClientOrderDetail where  ClientOrderGuid='" + clientOrder.ClientOrderGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入明细表数据
                for (int i = 0; i < clientOrderDetail.Count; i++)
                {
                    strInsertSql = GetAddBillDetailSQL(clientOrderDetail[i]);
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
        public void DeleteBill(string clientorderguid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from ClientOrder where  ClientOrderGuid='" + clientorderguid + "'";
                pComm.Execute(strDeleteSql);


                //删除明细表
                strDeleteSql = "Delete from ClientOrderDetail where  ClientOrderGuid='" + clientorderguid + "'";
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
        public string GetAddBillSQL(ClientOrder ClientOrder)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ClientOrder(");
            strSql.Append("ClientOrderGuid,ClientOrderID,ClientOrderDate,EncasementDate,ContractID,CheckBatchID,DownDept,ReceiveDept,OrderType,Remark,CreateGuid,CreateDate,CheckGuid,CheckDate,CheckGuid2,CheckDate2,EndGuid,EndDate");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + ClientOrder.ClientOrderGuid + "',");
            strSql.Append("'" + ClientOrder.ClientOrderID + "',");
            strSql.Append("'" + ClientOrder.ClientOrderDate + "',");
            if (ClientOrder.EncasementDate == DateTime.Parse("1900-01-01"))
            {
                strSql.Append("null,");
            }
            else
            {
                strSql.Append("'" + ClientOrder.EncasementDate + "',");
            }
            strSql.Append("'" + ClientOrder.ContractID + "',");
            strSql.Append("'" + ClientOrder.CheckBatchID + "',");
            strSql.Append("'" + ClientOrder.DownDept + "',");
            strSql.Append("'" + ClientOrder.ReceiveDept + "',");
            strSql.Append("'" + ClientOrder.OrderType + "',");
            strSql.Append("'" + ClientOrder.Remark + "',");
            strSql.Append("'" + ClientOrder.CreateGuid + "',");
            strSql.Append("'" + ClientOrder.CreateDate + "',");
            strSql.Append("'" + ClientOrder.CheckGuid + "',");
            if (ClientOrder.CheckDate == DateTime.Parse("1900-01-01"))
            {
                strSql.Append("null,");
            }
            else
            {
                strSql.Append("'" + ClientOrder.CheckDate2 + "',");
            }
            strSql.Append("'" + ClientOrder.CheckGuid2 + "',");
            if (ClientOrder.CheckDate2 == DateTime.Parse("1900-01-01"))
            {
                strSql.Append("null,");
            }
            else
            {
                strSql.Append("'" + ClientOrder.CheckDate2 + "',");
            }
            strSql.Append("'" + ClientOrder.EndGuid + "',");
            if (ClientOrder.EndDate == DateTime.Parse("1900-01-01"))
            {
                strSql.Append("null");
            }
            else
            {
                strSql.Append("'" + ClientOrder.EndDate + "'");
            }
            strSql.Append(")");
            return strSql.ToString();


           
        }


        /// <summary>
        /// 得到增加一条明细的SQL
        /// </summary>
        public string GetAddBillDetailSQL(ClientOrderDetail clientOrderDetail)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ClientOrderDetail(");
            strSql.Append("ClientOrderGuid,MaterialGuid,MaterialSum,Remark");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + clientOrderDetail.ClientOrderGuid + "',");
            strSql.Append("'" + clientOrderDetail.MaterialGuid + "',");
            strSql.Append("" + clientOrderDetail.MaterialSum + ",");
            strSql.Append("'" + clientOrderDetail.Remark + "'");
            strSql.Append(")");
            return strSql.ToString();
        }


        /// <summary>
        /// 得到客户订单的明细
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetClientOrderDetail(string ClientOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select   *   from  V_ClientOrderDetail  where ClientOrderGuid='" + ClientOrderGuid + "' order by sortid";
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
        /// 得到客户订单主表数据
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetClientOrder(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select   ClientOrderGuid ,ClientOrderID as 客户订单号,ClientOrderDate as 下单日期,EncasementDate as 装箱日期,"
                                  +"ContractID as 合同号,CheckBatchID as 商检批号,"
                                  + " (select  DeptName from Dept where DeptGuid=DownDept) as 下单部门,"
                                  + " ReceiveDept as 收单部门,OrderType as 订单类别,"
                                  + "( select  UserName from LoginUser where UserID=CreateGuid) as 制单人,"
                                  +"CreateDate  as  制单时间, "
                                   + "( select  UserName from LoginUser where UserID=CheckGuid) as 审核人,"
                                    + "( select  UserName from LoginUser where UserID=CheckGuid2) as 二审核人 "
                                  +" from  ClientOrder " + strsql + " order by CreateDate desc";
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
        /// 得到客户订单主表数据--供物料需求计划调用
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetClientOrderBySelect(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select   'False' as selectvalue, ClientOrderGuid,ClientOrderDetailGuid, ClientOrderID,"
                                  +"ClientOrderDate, MaterialGuid, MaterialID, MaterialName, Spec, MaterialSum "
                                  + " from  V_SelectClientOrder " + strsql + " order by CreateDate desc";
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
        /// 得到客户订单主表数据--供物销售出库单
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetClientOrderBySellOrderSelect(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select   *  from  V_ClientOrder " + strsql + " order by CreateDate desc";
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
        /// 得到客户订单主表数据
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetClientOrderByClientOrderGuid(string ClientOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                /* ps_Sql = "select   ClientOrderGuid ,ClientOrderID,convert(nvarchar(10),ClientOrderDate,120) as ClientOrderDate,"
                                   + "convert(nvarchar(10),EncasementDate,120)  as  EncasementDate,"
                                   + "ContractID,CheckBatchID,DownDept,"
                                   + " (select  DeptName from Dept where DeptGuid=DownDept) as DownDeptName,ReceiveDept,"
                                   + "(select  DeptName from Dept where DeptGuid=ReceiveDept) as ReceiveDeptName,CreateGuid,"
                                   + "( select UserName from LoginUser where UserID=CreateGuid) as CreateName,CheckGuid,"
                                   + "CreateDate,( select UserName from LoginUser where UserID=CheckGuid) as  CheckName, CheckDate,EndGuid,"
                                   + "( select UserName from LoginUser where UserID=EndGuid) as  EndName, EndDate ,Remark  from  ClientOrder where ClientOrderGuid='" + ClientOrderGuid + "' order by CreateDate desc";
                */
                ps_Sql = " select  *,convert(nvarchar(10),ClientOrderDate,120) as ClientOrderDate2 from V_ClientOrderAndDetail_All  ClientOrder where ClientOrderGuid='" + ClientOrderGuid + "' order by CreateDate desc";
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
        /// 得到客户订单主表数据
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetClientOrderBySQL(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  *,convert(nvarchar(10),ClientOrderDate,120) as ClientOrderDate2  from V_ClientOrderAndDetail_All   " + strsql + " order by CreateDate desc";
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
        public void CheckBill(string ClientOrderGuid, int pass)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "";
                //删除主表
                if (pass == 1)
                {
                    //通过
                    ps_Sql = "update  ClientOrder  set CheckGuid='" + SysParams.UserID + "',CheckDate='" + DateTime.Now.ToString() + "'  where  ClientOrderGuid='" + ClientOrderGuid + "'";

                }
                else
                {
                    //不通过
                    ps_Sql = "update  ClientOrder  set CheckGuid='',CheckDate=null  where  ClientOrderGuid='" + ClientOrderGuid + "'";

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
        public void CheckBill2(string ClientOrderGuid, int pass)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "";
                //删除主表
                if (pass == 1)
                {
                    //通过
                    ps_Sql = "update  ClientOrder  set CheckGuid2='" + SysParams.UserID + "',CheckDate2='" + DateTime.Now.ToString() + "'  where  ClientOrderGuid='" + ClientOrderGuid + "'";

                }
                else
                {
                    //不通过
                    ps_Sql = "update  ClientOrder  set CheckGuid2='',CheckDate2=null  where  ClientOrderGuid='" + ClientOrderGuid + "'";

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
        public void EndBill(string ClientOrderGuid)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "";

                //结单
                ps_Sql = "update  ClientOrder  set EndGuid='" + SysParams.UserID + "',EndDate='" + DateTime.Now.ToString() + "'  where  ClientOrderGuid='" + ClientOrderGuid + "'";

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
        public bool GetIsCheck(string ClientOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  ClientOrderGuid,CheckGuid,CheckGuid2,EndGuid  from   ClientOrder where ClientOrderGuid='" + ClientOrderGuid + "' ";
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
        /// 删除客户订单时得到此订单已经被使用的销售订单号
        /// </summary>
        /// <returns></returns>
        public DataTable GetSellOrderID(string ClientGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select distinct SellOrderID  from V_SellOrderAndSellOrderDetail  where ClientOrderGuid='" + ClientGuid + "' order by SellOrderID desc";
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
        /// 得到客户订单Guid
        /// </summary>
        /// <param name="ClientOrderID"></param>
        /// <param name="MaterialGuid"></param>
        /// <returns>返回值：0:没有找到这个客户订单号  1:没有找到这个料件  </returns>
        public string GetClientOrderGuid(string ClientOrderID,string MaterialGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  ClientOrderGuid  from   ClientOrder where ClientOrderID='" + ClientOrderID + "' ";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);
              

                if (pDTMain.Rows.Count > 0)
                {
                    string strClientOrderGuid= pDTMain.Rows[0]["ClientOrderGuid"].ToString().Trim();

                    //检查此客户订单中是否存在这个料件
                    DataTable pDTMain2 = new DataTable();
                    ps_Sql = " select  ClientOrderGuid  from   ClientOrderDetail where ClientOrderGuid='" + strClientOrderGuid + "' and MaterialGuid='" + MaterialGuid + "'";
                    pDTMain2 = pObj_Comm.ExeForDtl(ps_Sql);
                    pObj_Comm.Close();

                    if (pDTMain2.Rows.Count > 0)
                    {
                        //找到了，并返回ClientOrderGuid
                        return strClientOrderGuid;
                    }
                    else
                    {
                        return "1"; //表示没有找到这个料件
                    }
                }
                else
                {
                    pObj_Comm.Close();
                    return "0"; //表示没有找到这个客户订单号
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
