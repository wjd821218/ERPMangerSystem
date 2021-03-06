﻿using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;

namespace ErpManageLibrary
{
    /// <summary>
    /// 期初录入
    /// </summary>
    public class InitialGoodsManage
    {
        
          ///<summary>
        /// 保存数据
        /// </summary>
        /// <param name="pObj">信息集实体类</param>
        /// <returns>返回保存成功(true)或失败(false)</returns>
        public void SaveBill(InitialGoods InitialGoods, List<InitialGoodsDetail> InitialGoodsDetail)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from InitialGoods where  InitialGoodsGuid='" + InitialGoods.InitialGoodsGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入主表数据
                string strInsertSql = GetAddBillSQL(InitialGoods);
                pComm.Execute(strInsertSql);


                //删除明细表
                strDeleteSql = "Delete from InitialGoodsDetail where  InitialGoodsGuid='" + InitialGoods.InitialGoodsGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入明细表数据
                for (int i = 0; i < InitialGoodsDetail.Count; i++)
                {
                    strInsertSql = GetAddBillDetailSQL(InitialGoodsDetail[i]);
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
        public void DeleteBill(string InitialGoodsguid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from InitialGoods where  InitialGoodsGuid='" + InitialGoodsguid + "'";
                pComm.Execute(strDeleteSql);


                //删除明细表
                strDeleteSql = "Delete from InitialGoodsDetail where  InitialGoodsGuid='" + InitialGoodsguid + "'";
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
        public string GetAddBillSQL(InitialGoods InitialGoods)
        {
             StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into InitialGoods(");
			strSql.Append("InitialGoodsGuid,InitialGoodsID,InitialGoodsDate,IncomeDepot,Remark,CreateGuid,CreateDate,CheckGuid,CheckDate");
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append("'"+InitialGoods.InitialGoodsGuid+"',");
			strSql.Append("'"+InitialGoods.InitialGoodsID+"',");
			strSql.Append("'"+InitialGoods.InitialGoodsDate+"',");
			strSql.Append("'"+InitialGoods.IncomeDepot+"',");
			strSql.Append("'"+InitialGoods.Remark+"',");
			strSql.Append("'"+InitialGoods.CreateGuid+"',");
			strSql.Append("'"+InitialGoods.CreateDate+"',");
			strSql.Append("'"+InitialGoods.CheckGuid+"',");
			 if (InitialGoods.CheckDate == DateTime.Parse("1900-01-01"))
            {
                strSql.Append("null");
            }
            else
            {
                strSql.Append("'" + InitialGoods.CheckDate + "'");
            }
			strSql.Append(")");
            return strSql.ToString();

        }


        /// <summary>
        /// 得到增加一条明细的SQL
        /// </summary>
        public string GetAddBillDetailSQL(InitialGoodsDetail InitialGoodsDetail)
        {
       	StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into InitialGoodsDetail(");
			strSql.Append("InitialGoodsGuid,MaterialGuID,MaterialSum");
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append("'"+InitialGoodsDetail.InitialGoodsGuid+"',");
			strSql.Append("'"+InitialGoodsDetail.MaterialGuID+"',");
			strSql.Append(""+InitialGoodsDetail.MaterialSum+"");
			strSql.Append(")");
            return strSql.ToString();
        }



        /// <summary>
        /// 得到领料单的明细
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetInitialGoodsDetail(string InitialGoodsGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select   *   from  V_InitialGoodsDetail  where InitialGoodsGuid='" + InitialGoodsGuid + "' order by sortid";
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
        public DataTable GetInitialGoodsBySQL(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_InitialGoods " + strsql + " order by CreateDate desc";
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
        public DataTable GetInitialGoodsByInitialGoodsGuid(string InitialGoodsGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_InitialGoods where InitialGoodsGuid='" + InitialGoodsGuid + "'";
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
        public void CheckBill(string InitialGoodsGuid, int pass)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "";
                //删除主表
                if (pass == 1)
                {
                    //通过
                    ps_Sql = "update InitialGoods  set CheckGuid='" + SysParams.UserID + "',CheckDate='" + DateTime.Now.ToString() + "'  where InitialGoodsGuid='" + InitialGoodsGuid + "'";

                }
                else
                {
                    //不通过
                    ps_Sql = "update InitialGoods  set CheckGuid='',CheckDate=null  where InitialGoodsGuid='" + InitialGoodsGuid + "'";

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
        public bool GetIsCheck(string InitialGoodsGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select InitialGoodsGuid,CheckGuid  from   InitialGoods where InitialGoodsGuid='" + InitialGoodsGuid + "' ";
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

