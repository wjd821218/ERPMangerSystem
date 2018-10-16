using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Daniel.Liu.DAO;

namespace ErpManageLibrary
{
    /// <summary>
    /// 超领单控制
    /// </summary>
    public class ExcessOrderManage
    {

         ///<summary>
        /// 保存数据
        /// </summary>
        /// <param name="pObj">信息集实体类</param>
        /// <returns>返回保存成功(true)或失败(false)</returns>
        public void SaveBill(ExcessOrder ExcessOrder, List<ExcessOrderDetail> ExcessOrderDetail)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from ExcessOrder where  ExcessOrderGuid='" + ExcessOrder.ExcessOrderGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入主表数据
                string strInsertSql = GetAddBillSQL(ExcessOrder);
                pComm.Execute(strInsertSql);


                //删除明细表
                strDeleteSql = "Delete from ExcessOrderDetail where  ExcessOrderGuid='" + ExcessOrder.ExcessOrderGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入明细表数据
                for (int i = 0; i < ExcessOrderDetail.Count; i++)
                {
                    strInsertSql = GetAddBillDetailSQL(ExcessOrderDetail[i]);
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
        public void DeleteBill(string ExcessOrderguid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from ExcessOrder where  ExcessOrderGuid='" + ExcessOrderguid + "'";
                pComm.Execute(strDeleteSql);


                //删除明细表
                strDeleteSql = "Delete from ExcessOrderDetail where  ExcessOrderGuid='" + ExcessOrderguid + "'";
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
        public string GetAddBillSQL(ExcessOrder ExcessOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ExcessOrder(");
            strSql.Append("ExcessOrderGuid,ExcessOrderID,ExcessOrderDate,DrawPerson,EmitPerson,OutStorage,Remark,CreateGuid,CreateDate,CheckGuid,CheckDate,CheckGuid2,CheckDate2");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + ExcessOrder.ExcessOrderGuid + "',");
            strSql.Append("'" + ExcessOrder.ExcessOrderID + "',");
            strSql.Append("'" + ExcessOrder.ExcessOrderDate + "',");
            strSql.Append("'" + ExcessOrder.DrawPerson + "',");
            strSql.Append("'" + ExcessOrder.EmitPerson + "',");
            strSql.Append("'" + ExcessOrder.OutStorage + "',");
            strSql.Append("'" + ExcessOrder.Remark + "',");
            strSql.Append("'" + ExcessOrder.CreateGuid + "',");
            strSql.Append("'" + ExcessOrder.CreateDate + "',");
            strSql.Append("'" + ExcessOrder.CheckGuid + "',");
            if (ExcessOrder.CheckDate == DateTime.Parse("1900-01-01"))
            {
                strSql.Append("null,");
            }
            else
            {
                strSql.Append("'" + ExcessOrder.CheckDate + "',");
            }
            strSql.Append("'" + ExcessOrder.CheckGuid2 + "',");
            if (ExcessOrder.CheckDate2 == DateTime.Parse("1900-01-01"))
            {
                strSql.Append("null");
            }
            else
            {
                strSql.Append("'" + ExcessOrder.CheckDate2 + "'");
            }
            strSql.Append(")");
            return strSql.ToString();

        }


        /// <summary>
        /// 得到增加一条明细的SQL
        /// </summary>
        public string GetAddBillDetailSQL(ExcessOrderDetail ExcessOrderDetail)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ExcessOrderDetail(");
            strSql.Append("ExcessOrderGuid,MaterialGuID,MaterialSum,MaterialOutSum,SortID");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + ExcessOrderDetail.ExcessOrderGuid + "',");
            strSql.Append("'" + ExcessOrderDetail.MaterialGuID + "',");
            strSql.Append("" + ExcessOrderDetail.MaterialSum + ",");
            strSql.Append("" + ExcessOrderDetail.MaterialOutSum + ",");
            strSql.Append("" + ExcessOrderDetail.SortID + "");
            strSql.Append(")");
            return strSql.ToString();
        }



        /// <summary>
        /// 得到领料单的明细
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetExcessOrderDetail(string ExcessOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select   *   from  V_ExcessOrderDetail  where ExcessOrderGuid='" + ExcessOrderGuid + "' order by sortid";
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
        public DataTable GetExcessOrderBySQL(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_ExcessOrder " + strsql + " order by CreateDate desc";
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
        public DataTable GetExcessOrderByExcessOrderGuid(string ExcessOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_ExcessOrder where ExcessOrderGuid='" + ExcessOrderGuid + "'";
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
        public void CheckBill(string ExcessOrderGuid, int pass)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "";
                //删除主表
                if (pass == 1)
                {
                    //通过
                    ps_Sql = "update ExcessOrder  set CheckGuid='" + SysParams.UserID + "',CheckDate='" + DateTime.Now.ToString() + "'  where ExcessOrderGuid='" + ExcessOrderGuid + "'";

                }
                else
                {
                    //不通过
                    ps_Sql = "update ExcessOrder  set CheckGuid='',CheckDate=null  where ExcessOrderGuid='" + ExcessOrderGuid + "'";

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
        /// 更新审核状态度
        /// </summary>
        /// <returns></returns>
        public void CheckBill2(string ExcessOrderGuid, int pass)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "";
                //删除主表
                if (pass == 1)
                {
                    //通过
                    ps_Sql = "update ExcessOrder  set CheckGuid2='" + SysParams.UserID + "',CheckDate2='" + DateTime.Now.ToString() + "'  where ExcessOrderGuid='" + ExcessOrderGuid + "'";

                }
                else
                {
                    //不通过
                    ps_Sql = "update ExcessOrder  set CheckGuid2='',CheckDate2=null  where ExcessOrderGuid='" + ExcessOrderGuid + "'";

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
        public bool GetIsCheck(string ExcessOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  ExcessOrderGuid,CheckGuid,CheckGuid2  from   ExcessOrder where ExcessOrderGuid='" + ExcessOrderGuid + "' ";
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

