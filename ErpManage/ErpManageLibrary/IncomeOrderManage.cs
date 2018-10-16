using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;

namespace ErpManageLibrary
{
    /// <summary>
    /// 付款单
    /// </summary>
    public class IncomeOrderManage
    {

        ///<summary>
        /// 保存数据----点击保存时用
        /// </summary>
        /// <param name="pObj">信息集实体类</param>
        /// <returns>返回保存成功(true)或失败(false)</returns>
        public void SaveBill(IncomeOrder IncomeOrder, List<IncomeOrderDetail1> IncomeOrderDetail1, List<IncomeOrderDetail2> IncomeOrderDetail2)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from IncomeOrder where  IncomeOrderGuid='" + IncomeOrder.IncomeOrderGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入主表数据
                string strInsertSql = GetAddSQL(IncomeOrder);
                pComm.Execute(strInsertSql);


                //删除明细表
                strDeleteSql = "Delete from IncomeOrderDetail1 where  IncomeOrderGuid='" + IncomeOrder.IncomeOrderGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入明细表数据
                for (int i = 0; i < IncomeOrderDetail1.Count; i++)
                {
                    strInsertSql = GetAddDetailSQL1(IncomeOrderDetail1[i]);
                    pComm.Execute(strInsertSql);
                }


                //删除计算明细
                strDeleteSql = "Delete from IncomeOrderDetail2 where  IncomeOrderGuid='" + IncomeOrder.IncomeOrderGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入明细表数据
                for (int i = 0; i < IncomeOrderDetail2.Count; i++)
                {
                    strInsertSql = GetAddDetailSQL2(IncomeOrderDetail2[i]);
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
        public void DeleteBill(string IncomeOrderGuid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from IncomeOrder where  IncomeOrderGuid='" + IncomeOrderGuid + "'";
                pComm.Execute(strDeleteSql);


                //删除明细表1
                strDeleteSql = "Delete from IncomeOrderDetail1 where  IncomeOrderGuid='" + IncomeOrderGuid + "'";
                pComm.Execute(strDeleteSql);


                //删除明细表2
                strDeleteSql = "Delete from IncomeOrderDetail2 where  IncomeOrderGuid='" + IncomeOrderGuid + "'";
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
        public string GetAddSQL(IncomeOrder IncomeOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into IncomeOrder(");
            strSql.Append("IncomeOrderGuid,IncomeOrderID,IncomeOrderDate,ClientGuid,IncomePerson,Remark,CreateGuid,CreateDate,CheckGuid,CheckDate");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + IncomeOrder.IncomeOrderGuid + "',");
            strSql.Append("'" + IncomeOrder.IncomeOrderID + "',");
            if (IncomeOrder.IncomeOrderDate == DateTime.Parse("1900-01-01"))
            {
                strSql.Append("null,");
            }
            else            
            {
                strSql.Append("'" + IncomeOrder.IncomeOrderDate + "',");
            }
            strSql.Append("'" + IncomeOrder.ClientGuid+ "',");
            strSql.Append("'" + IncomeOrder.IncomePerson + "',");
            strSql.Append("'" + IncomeOrder.Remark + "',");
            strSql.Append("'" + IncomeOrder.CreateGuid + "',");
            strSql.Append("'" + IncomeOrder.CreateDate + "',");
            strSql.Append("'" + IncomeOrder.CheckGuid + "',");
            if (IncomeOrder.CheckDate == DateTime.Parse("1900-01-01"))
            {
                strSql.Append("null");
            }
            else
            {
                strSql.Append("'" + IncomeOrder.CreateDate + "'");
            }

            strSql.Append(")");
            return strSql.ToString();

        }


        /// <summary>
        /// 得到生产领料计划明细sql
        /// </summary>
        public string GetAddDetailSQL1(IncomeOrderDetail1 IncomeOrderDetail1)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into IncomeOrderDetail1(");
            strSql.Append("IncomeOrderGuid,IncomeID,IncomeMoney,CNY,IncomeType,Remark,SortID");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + IncomeOrderDetail1.IncomeOrderGuid + "',");
            strSql.Append("'" + IncomeOrderDetail1.IncomeID + "',");
            strSql.Append("" + IncomeOrderDetail1.IncomeMoney + ",");
            strSql.Append("'" + IncomeOrderDetail1.CNY + "',");
            strSql.Append("'" + IncomeOrderDetail1.IncomeType + "',");
            strSql.Append("'" + IncomeOrderDetail1.Remark + "',");
            strSql.Append("" + IncomeOrderDetail1.SortID + "");
            strSql.Append(")");
            return strSql.ToString();
        }

        /// <summary>
        /// 得到生产领料计划明细sql
        /// </summary>
        public string GetAddDetailSQL2(IncomeOrderDetail2 IncomeOrderDetail2)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into IncomeOrderDetail2(");
            strSql.Append("IncomeOrderGuid,SellOrderID,SellOrderDate,SellOrderMoney,Remark,SortID");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + IncomeOrderDetail2.IncomeOrderGuid + "',");
            strSql.Append("'" + IncomeOrderDetail2.SellOrderID + "',");
            strSql.Append("'" + IncomeOrderDetail2.SellOrderDate + "',");
            strSql.Append("" + IncomeOrderDetail2.SellOrderMoney + ",");
            strSql.Append("'" + IncomeOrderDetail2.Remark + "',");
            strSql.Append("" + IncomeOrderDetail2.SortID + "");
            strSql.Append(")");
            return strSql.ToString();
        }



      



        /// <summary>
        /// 得到付款单数据
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetIncomeOrderBySQL(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  *  from  V_IncomeOrder   " + strsql + " order by CreateDate desc";
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
        /// 得到付款单帐户数据
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetIncomeOrderDetail1ByGuid(string IncomeOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  *  from    V_IncomeOrderDetail1  where IncomeOrderGuid='" + IncomeOrderGuid + "' order by sortid";
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
        /// 得到采购订单数据
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetIncomeOrderDetail2ByGuid(string IncomeOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  IncomeOrderDetail2Guid,IncomeOrderGuid,SellOrderID,convert(nvarchar(10),SellOrderDate,120) as SellOrderDate,SellOrderMoney,Remark  from  IncomeOrderDetail2  where IncomeOrderGuid='" + IncomeOrderGuid + "' order by sortid";
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
        public void CheckBill(string IncomeOrderGuid, int pass)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "";
                //删除主表
                if (pass == 1)
                {
                    //通过
                    ps_Sql = "update IncomeOrder  set CheckGuid='" + SysParams.UserID + "',CheckDate='" + DateTime.Now.ToString() + "'  where IncomeOrderGuid='" + IncomeOrderGuid + "'";

                }
                else
                {
                    //不通过
                    ps_Sql = "update IncomeOrder  set CheckGuid='',CheckDate=null  where IncomeOrderGuid='" + IncomeOrderGuid + "'";

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
        /// 得到订单是否已审核或已结单
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public bool GetIsCheck(string IncomeOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select IncomeOrderGuid,CheckGuid  from   IncomeOrder where IncomeOrderGuid='" + IncomeOrderGuid + "' ";
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



    }
}
