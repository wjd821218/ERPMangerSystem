using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;

namespace ErpManageLibrary
{
    /// <summary>
    /// 半成品入库单
    /// </summary>
    public class HalfGoodsManage
    {
        
          ///<summary>
        /// 保存数据
        /// </summary>
        /// <param name="pObj">信息集实体类</param>
        /// <returns>返回保存成功(true)或失败(false)</returns>
        public void SaveBill(HalfGoods HalfGoods, List<HalfGoodsDetail> HalfGoodsDetail)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from HalfGoods where  HalfGoodsGuid='" + HalfGoods.HalfGoodsGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入主表数据
                string strInsertSql = GetAddBillSQL(HalfGoods);
                pComm.Execute(strInsertSql);


                //删除明细表
                strDeleteSql = "Delete from HalfGoodsDetail where  HalfGoodsGuid='" + HalfGoods.HalfGoodsGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入明细表数据
                for (int i = 0; i < HalfGoodsDetail.Count; i++)
                {
                    strInsertSql = GetAddBillDetailSQL(HalfGoodsDetail[i]);
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
        public void DeleteBill(string HalfGoodsguid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from HalfGoods where  HalfGoodsGuid='" + HalfGoodsguid + "'";
                pComm.Execute(strDeleteSql);


                //删除明细表
                strDeleteSql = "Delete from HalfGoodsDetail where  HalfGoodsGuid='" + HalfGoodsguid + "'";
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
        public string GetAddBillSQL(HalfGoods HalfGoods)
        {
             StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into HalfGoods(");
			strSql.Append("HalfGoodsGuid,HalfGoodsID,HalfGoodsDate,Plant,IncomeDepot,TransactorPerson,SatrapPerson,QualityPerson,DepotPerson,BatchNo,Remark,CreateGuid,CreateDate,CheckGuid,CheckDate");
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append("'"+HalfGoods.HalfGoodsGuid+"',");
			strSql.Append("'"+HalfGoods.HalfGoodsID+"',");
			strSql.Append("'"+HalfGoods.HalfGoodsDate+"',");
			strSql.Append("'"+HalfGoods.Plant+"',");
			strSql.Append("'"+HalfGoods.IncomeDepot+"',");
			strSql.Append("'"+HalfGoods.TransactorPerson+"',");
			strSql.Append("'"+HalfGoods.SatrapPerson+"',");
			strSql.Append("'"+HalfGoods.QualityPerson+"',");
			strSql.Append("'"+HalfGoods.DepotPerson+"',");
            strSql.Append("'" + HalfGoods.BatchNo + "',");
			strSql.Append("'"+HalfGoods.Remark+"',");
			strSql.Append("'"+HalfGoods.CreateGuid+"',");
			strSql.Append("'"+HalfGoods.CreateDate+"',");
			strSql.Append("'"+HalfGoods.CheckGuid+"',");
			 if (HalfGoods.CheckDate == DateTime.Parse("1900-01-01"))
            {
                strSql.Append("null");
            }
            else
            {
                strSql.Append("'" + HalfGoods.CheckDate + "'");
            }
			strSql.Append(")");
            return strSql.ToString();

        }


        /// <summary>
        /// 得到增加一条明细的SQL
        /// </summary>
        public string GetAddBillDetailSQL(HalfGoodsDetail HalfGoodsDetail)
        {
       	StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into HalfGoodsDetail(");
			strSql.Append("HalfGoodsGuid,MaterialGuID,MaterialSum,Determinant,SortID");
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append("'"+HalfGoodsDetail.HalfGoodsGuid+"',");
			strSql.Append("'"+HalfGoodsDetail.MaterialGuID+"',");
			strSql.Append(""+HalfGoodsDetail.MaterialSum+",");
			strSql.Append("'"+HalfGoodsDetail.Determinant+"',");
			strSql.Append(""+HalfGoodsDetail.SortID+"");
			strSql.Append(")");
            return strSql.ToString();
        }



        /// <summary>
        /// 得到领料单的明细
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetHalfGoodsDetail(string HalfGoodsGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select   *   from  V_HalfGoodsDetail  where HalfGoodsGuid='" + HalfGoodsGuid + "' order by sortid";
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
        public DataTable GetHalfGoodsBySQL(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_HalfGoods " + strsql + " order by CreateDate desc";
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
        public DataTable GetHalfGoodsByHalfGoodsGuid(string HalfGoodsGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_HalfGoods where HalfGoodsGuid='" + HalfGoodsGuid + "'";
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
        public void CheckBill(string HalfGoodsGuid, int pass)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "";
                //删除主表
                if (pass == 1)
                {
                    //通过
                    ps_Sql = "update HalfGoods  set CheckGuid='" + SysParams.UserID + "',CheckDate='" + DateTime.Now.ToString() + "'  where HalfGoodsGuid='" + HalfGoodsGuid + "'";

                }
                else
                {
                    //不通过
                    ps_Sql = "update HalfGoods  set CheckGuid='',CheckDate=null  where HalfGoodsGuid='" + HalfGoodsGuid + "'";

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
        public bool GetIsCheck(string HalfGoodsGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select HalfGoodsGuid,CheckGuid  from   HalfGoods where HalfGoodsGuid='" + HalfGoodsGuid + "' ";
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

