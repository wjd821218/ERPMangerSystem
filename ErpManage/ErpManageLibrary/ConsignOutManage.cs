using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;

namespace ErpManageLibrary
{
    /// <summary>
    ///  委外加工出库单
    /// </summary>
    public class ConsignOutManage
    {
        
          ///<summary>
        /// 保存数据
        /// </summary>
        /// <param name="pObj">信息集实体类</param>
        /// <returns>返回保存成功(true)或失败(false)</returns>
        public void SaveBill(ConsignOut ConsignOut, List<ConsignOutDetail> ConsignOutDetail)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from ConsignOut where  ConsignOutGuid='" + ConsignOut.ConsignOutGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入主表数据
                string strInsertSql = GetAddBillSQL(ConsignOut);
                pComm.Execute(strInsertSql);


                //删除明细表
                strDeleteSql = "Delete from ConsignOutDetail where  ConsignOutGuid='" + ConsignOut.ConsignOutGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入明细表数据
                for (int i = 0; i < ConsignOutDetail.Count; i++)
                {
                    strInsertSql = GetAddBillDetailSQL(ConsignOutDetail[i]);
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
        public void DeleteBill(string ConsignOutguid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from ConsignOut where  ConsignOutGuid='" + ConsignOutguid + "'";
                pComm.Execute(strDeleteSql);


                //删除明细表
                strDeleteSql = "Delete from ConsignOutDetail where  ConsignOutGuid='" + ConsignOutguid + "'";
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
        public string GetAddBillSQL(ConsignOut ConsignOut)
        {
             StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ConsignOut(");
			strSql.Append("ConsignOutGuid,ConsignOutID,ConsignOutDate,Plant,OutcomeDepot,TransactorPerson,SatrapPerson,QualityPerson,DepotPerson,ArriveDate,InUnit,SupplierGuid,Remark,CreateGuid,CreateDate,CheckGuid,CheckDate");
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append("'"+ConsignOut.ConsignOutGuid+"',");
			strSql.Append("'"+ConsignOut.ConsignOutID+"',");
			strSql.Append("'"+ConsignOut.ConsignOutDate+"',");
			strSql.Append("'"+ConsignOut.Plant+"',");
			strSql.Append("'"+ConsignOut.OutcomeDepot+"',");
			strSql.Append("'"+ConsignOut.TransactorPerson+"',");
			strSql.Append("'"+ConsignOut.SatrapPerson+"',");
			strSql.Append("'"+ConsignOut.QualityPerson+"',");
			strSql.Append("'"+ConsignOut.DepotPerson+"',");
            strSql.Append("'" + ConsignOut.ArriveDate + "',");
            strSql.Append("'" + ConsignOut.InUnit + "',");
            strSql.Append("'" + ConsignOut.SupplierGuid + "',");
			strSql.Append("'"+ConsignOut.Remark+"',");
			strSql.Append("'"+ConsignOut.CreateGuid+"',");
			strSql.Append("'"+ConsignOut.CreateDate+"',");
			strSql.Append("'"+ConsignOut.CheckGuid+"',");
			 if (ConsignOut.CheckDate == DateTime.Parse("1900-01-01"))
            {
                strSql.Append("null");
            }
            else
            {
                strSql.Append("'" + ConsignOut.CheckDate + "'");
            }
			strSql.Append(")");
            return strSql.ToString();

        }


        /// <summary>
        /// 得到增加一条明细的SQL
        /// </summary>
        public string GetAddBillDetailSQL(ConsignOutDetail ConsignOutDetail)
        {
          	StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ConsignOutDetail(");
			strSql.Append("ConsignOutGuid,MaterialGuID,MaterialSum,Determinant,SortID");
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append("'"+ConsignOutDetail.ConsignOutGuid+"',");
			strSql.Append("'"+ConsignOutDetail.MaterialGuID+"',");
			strSql.Append(""+ConsignOutDetail.MaterialSum+",");
			strSql.Append("'"+ConsignOutDetail.Determinant+"',");
			strSql.Append(""+ConsignOutDetail.SortID+"");
			strSql.Append(")");
            return strSql.ToString();
        }



        /// <summary>
        /// 得到 委外加工出库单的明细
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetConsignOutDetail(string ConsignOutGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select   *   from  V_ConsignOutDetail  where ConsignOutGuid='" + ConsignOutGuid + "' order by sortid";
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
        /// 得到 委外加工出库单主表数据
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetConsignOutBySQL(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_ConsignOut " + strsql + " order by CreateDate desc";
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
        /// 得到 委外加工出库单主表数据
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetConsignOutByConsignOutGuid(string ConsignOutGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_ConsignOut where ConsignOutGuid='" + ConsignOutGuid + "'";
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
        public void CheckBill(string ConsignOutGuid, int pass)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "";
                //删除主表
                if (pass == 1)
                {
                    //通过
                    ps_Sql = "update ConsignOut  set CheckGuid='" + SysParams.UserID + "',CheckDate='" + DateTime.Now.ToString() + "'  where ConsignOutGuid='" + ConsignOutGuid + "'";

                }
                else
                {
                    //不通过
                    ps_Sql = "update ConsignOut  set CheckGuid='',CheckDate=null  where ConsignOutGuid='" + ConsignOutGuid + "'";

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
        public bool GetIsCheck(string ConsignOutGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select ConsignOutGuid,CheckGuid  from   ConsignOut where ConsignOutGuid='" + ConsignOutGuid + "' ";
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

