using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;

namespace ErpManageLibrary
{
    /// <summary>
    ///  委外加工入库单
    /// </summary>
    public class ConsignManage
    {
        
          ///<summary>
        /// 保存数据
        /// </summary>
        /// <param name="pObj">信息集实体类</param>
        /// <returns>返回保存成功(true)或失败(false)</returns>
        public void SaveBill(Consign Consign, List<ConsignDetail> ConsignDetail)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from Consign where  ConsignGuid='" + Consign.ConsignGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入主表数据
                string strInsertSql = GetAddBillSQL(Consign);
                pComm.Execute(strInsertSql);


                //删除明细表
                strDeleteSql = "Delete from ConsignDetail where  ConsignGuid='" + Consign.ConsignGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入明细表数据
                for (int i = 0; i < ConsignDetail.Count; i++)
                {
                    strInsertSql = GetAddBillDetailSQL(ConsignDetail[i]);
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
        public void DeleteBill(string Consignguid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from Consign where  ConsignGuid='" + Consignguid + "'";
                pComm.Execute(strDeleteSql);


                //删除明细表
                strDeleteSql = "Delete from ConsignDetail where  ConsignGuid='" + Consignguid + "'";
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
        public string GetAddBillSQL(Consign Consign)
        {
             StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Consign(");
			strSql.Append("ConsignGuid,ConsignID,ConsignDate,Plant,IncomeDepot,TransactorPerson,SatrapPerson,QualityPerson,DepotPerson,SupplierGuid,BatchNo,Remark,CreateGuid,CreateDate,CheckGuid,CheckDate");
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append("'"+Consign.ConsignGuid+"',");
			strSql.Append("'"+Consign.ConsignID+"',");
			strSql.Append("'"+Consign.ConsignDate+"',");
			strSql.Append("'"+Consign.Plant+"',");
			strSql.Append("'"+Consign.IncomeDepot+"',");
			strSql.Append("'"+Consign.TransactorPerson+"',");
			strSql.Append("'"+Consign.SatrapPerson+"',");
			strSql.Append("'"+Consign.QualityPerson+"',");
			strSql.Append("'"+Consign.DepotPerson+"',");
            strSql.Append("'" + Consign.SupplierGuid + "',");
            strSql.Append("'" + Consign.BatchNo + "',");
			strSql.Append("'"+Consign.Remark+"',");
			strSql.Append("'"+Consign.CreateGuid+"',");
			strSql.Append("'"+Consign.CreateDate+"',");
			strSql.Append("'"+Consign.CheckGuid+"',");
			 if (Consign.CheckDate == DateTime.Parse("1900-01-01"))
            {
                strSql.Append("null");
            }
            else
            {
                strSql.Append("'" + Consign.CheckDate + "'");
            }
			strSql.Append(")");
            return strSql.ToString();

        }


        /// <summary>
        /// 得到增加一条明细的SQL
        /// </summary>
        public string GetAddBillDetailSQL(ConsignDetail ConsignDetail)
        {
       	StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ConsignDetail(");
			strSql.Append("ConsignGuid,MaterialGuID,MaterialSum,Determinant,SortID");
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append("'"+ConsignDetail.ConsignGuid+"',");
			strSql.Append("'"+ConsignDetail.MaterialGuID+"',");
			strSql.Append(""+ConsignDetail.MaterialSum+",");
			strSql.Append("'"+ConsignDetail.Determinant+"',");
			strSql.Append(""+ConsignDetail.SortID+"");
			strSql.Append(")");
            return strSql.ToString();
        }



        /// <summary>
        /// 得到 委外加工入库单的明细
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetConsignDetail(string ConsignGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select   *   from  V_ConsignDetail  where ConsignGuid='" + ConsignGuid + "' order by sortid";
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
        /// 得到 委外加工入库单主表数据
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetConsignBySQL(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_Consign " + strsql + " order by CreateDate desc";
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
        /// 得到 委外加工入库单主表数据
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetConsignByConsignGuid(string ConsignGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_Consign where ConsignGuid='" + ConsignGuid + "'";
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
        public void CheckBill(string ConsignGuid, int pass)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "";
                //删除主表
                if (pass == 1)
                {
                    //通过
                    ps_Sql = "update Consign  set CheckGuid='" + SysParams.UserID + "',CheckDate='" + DateTime.Now.ToString() + "'  where ConsignGuid='" + ConsignGuid + "'";

                }
                else
                {
                    //不通过
                    ps_Sql = "update Consign  set CheckGuid='',CheckDate=null  where ConsignGuid='" + ConsignGuid + "'";

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
        public bool GetIsCheck(string ConsignGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select ConsignGuid,CheckGuid  from   Consign where ConsignGuid='" + ConsignGuid + "' ";
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

