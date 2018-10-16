using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;

namespace ErpManageLibrary
{
    /// <summary>
    /// 成品入库单
    /// </summary>
    public class GoodsOrderManage
    {
        
          ///<summary>
        /// 保存数据
        /// </summary>
        /// <param name="pObj">信息集实体类</param>
        /// <returns>返回保存成功(true)或失败(false)</returns>
        public void SaveBill(GoodsOrder GoodsOrder, List<GoodsOrderDetail> GoodsOrderDetail)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from GoodsOrder where  GoodsOrderGuid='" + GoodsOrder.GoodsOrderGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入主表数据
                string strInsertSql = GetAddBillSQL(GoodsOrder);
                pComm.Execute(strInsertSql);


                //删除明细表
                strDeleteSql = "Delete from GoodsOrderDetail where  GoodsOrderGuid='" + GoodsOrder.GoodsOrderGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入明细表数据
                for (int i = 0; i < GoodsOrderDetail.Count; i++)
                {
                    strInsertSql = GetAddBillDetailSQL(GoodsOrderDetail[i]);
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
        public void DeleteBill(string GoodsOrderguid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from GoodsOrder where  GoodsOrderGuid='" + GoodsOrderguid + "'";
                pComm.Execute(strDeleteSql);


                //删除明细表
                strDeleteSql = "Delete from GoodsOrderDetail where  GoodsOrderGuid='" + GoodsOrderguid + "'";
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
        public string GetAddBillSQL(GoodsOrder GoodsOrder)
        {
             StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into GoodsOrder(");
			strSql.Append("GoodsOrderGuid,GoodsOrderID,GoodsOrderDate,Plant,IncomeDepot,TransactorPerson,SatrapPerson,QualityPerson,DepotPerson,BatchNo,Remark,CreateGuid,CreateDate,CheckGuid,CheckDate");
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append("'"+GoodsOrder.GoodsOrderGuid+"',");
			strSql.Append("'"+GoodsOrder.GoodsOrderID+"',");
			strSql.Append("'"+GoodsOrder.GoodsOrderDate+"',");
			strSql.Append("'"+GoodsOrder.Plant+"',");
			strSql.Append("'"+GoodsOrder.IncomeDepot+"',");
			strSql.Append("'"+GoodsOrder.TransactorPerson+"',");
			strSql.Append("'"+GoodsOrder.SatrapPerson+"',");
			strSql.Append("'"+GoodsOrder.QualityPerson+"',");
			strSql.Append("'"+GoodsOrder.DepotPerson+"',");
            strSql.Append("'" + GoodsOrder.BatchNo + "',");
			strSql.Append("'"+GoodsOrder.Remark+"',");
			strSql.Append("'"+GoodsOrder.CreateGuid+"',");
			strSql.Append("'"+GoodsOrder.CreateDate+"',");
			strSql.Append("'"+GoodsOrder.CheckGuid+"',");
			 if (GoodsOrder.CheckDate == DateTime.Parse("1900-01-01"))
            {
                strSql.Append("null");
            }
            else
            {
                strSql.Append("'" + GoodsOrder.CheckDate + "'");
            }
			strSql.Append(")");
            return strSql.ToString();

        }


        /// <summary>
        /// 得到增加一条明细的SQL
        /// </summary>
        public string GetAddBillDetailSQL(GoodsOrderDetail GoodsOrderDetail)
        {
       	StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into GoodsOrderDetail(");
			strSql.Append("GoodsOrderGuid,MaterialGuID,MaterialSum,Determinant,SortID");
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append("'"+GoodsOrderDetail.GoodsOrderGuid+"',");
			strSql.Append("'"+GoodsOrderDetail.MaterialGuID+"',");
			strSql.Append(""+GoodsOrderDetail.MaterialSum+",");
			strSql.Append("'"+GoodsOrderDetail.Determinant+"',");
			strSql.Append(""+GoodsOrderDetail.SortID+"");
			strSql.Append(")");
            return strSql.ToString();
        }



        /// <summary>
        /// 得到领料单的明细
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetGoodsOrderDetail(string GoodsOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select   *   from  V_GoodsOrderDetail  where GoodsOrderGuid='" + GoodsOrderGuid + "' order by sortid";
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
        public DataTable GetGoodsOrderBySQL(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_GoodsOrder " + strsql + " order by CreateDate desc";
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
        /// 得到成品入库单主表数据
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetGoodsOrderByGoodsOrderGuid(string GoodsOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_GoodsOrder where GoodsOrderGuid='" + GoodsOrderGuid + "'";
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
        public void CheckBill(string GoodsOrderGuid, int pass)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "";
                //删除主表
                if (pass == 1)
                {
                    //通过
                    ps_Sql = "update GoodsOrder  set CheckGuid='" + SysParams.UserID + "',CheckDate='" + DateTime.Now.ToString() + "'  where GoodsOrderGuid='" + GoodsOrderGuid + "'";

                }
                else
                {
                    //不通过
                    ps_Sql = "update GoodsOrder  set CheckGuid='',CheckDate=null  where GoodsOrderGuid='" + GoodsOrderGuid + "'";

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
        public bool GetIsCheck(string GoodsOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select GoodsOrderGuid,CheckGuid  from   GoodsOrder where GoodsOrderGuid='" + GoodsOrderGuid + "' ";
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

