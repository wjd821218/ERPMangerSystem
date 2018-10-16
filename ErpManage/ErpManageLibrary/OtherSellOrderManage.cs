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
    public class OtherSellOrderManage
    {
          ///<summary>
        /// 保存数据
        /// </summary>
        /// <param name="pObj">信息集实体类</param>
        /// <returns>返回保存成功(true)或失败(false)</returns>
        public void SaveBill(OtherSellOrder OtherSellOrder, List<OtherSellOrderDetail> OtherSellOrderDetail)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from OtherSellOrder where  OtherSellOrderGuid='" + OtherSellOrder.OtherSellOrderGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入主表数据
                string strInsertSql = GetAddBillSQL(OtherSellOrder);
                pComm.Execute(strInsertSql);


                //删除明细表
                strDeleteSql = "Delete from OtherSellOrderDetail where  OtherSellOrderGuid='" + OtherSellOrder.OtherSellOrderGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入明细表数据
                for (int i = 0; i < OtherSellOrderDetail.Count; i++)
                {
                    strInsertSql = GetAddBillDetailSQL(OtherSellOrderDetail[i]);
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
        public void DeleteBill(string OtherSellOrderguid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from OtherSellOrder where  OtherSellOrderGuid='" + OtherSellOrderguid + "'";
                pComm.Execute(strDeleteSql);


                //删除明细表
                strDeleteSql = "Delete from OtherSellOrderDetail where  OtherSellOrderGuid='" + OtherSellOrderguid + "'";
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
        public string GetAddBillSQL(OtherSellOrder OtherSellOrder)
        {
             StringBuilder strSql = new StringBuilder();
             strSql.Append("insert into OtherSellOrder(");
             strSql.Append("OtherSellOrderGuid,OtherSellOrderID,Client,OtherSellOrderDate,OutStorage,StoragePerson,QualityPerson,Remark,CreateGuid,CreateDate,CheckGuid,CheckDate");
             strSql.Append(")");
             strSql.Append(" values (");
             strSql.Append("'" + OtherSellOrder.OtherSellOrderGuid + "',");
             strSql.Append("'" + OtherSellOrder.OtherSellOrderID + "',");
             strSql.Append("'" + OtherSellOrder.Client + "',");
             strSql.Append("'" + OtherSellOrder.OtherSellOrderDate + "',");
             strSql.Append("'" + OtherSellOrder.OutStorage + "',");
             strSql.Append("'" + OtherSellOrder.StoragePerson + "',");
             strSql.Append("'" + OtherSellOrder.QualityPerson + "',");
             strSql.Append("'" + OtherSellOrder.Remark + "',");
             strSql.Append("'" + OtherSellOrder.CreateGuid + "',");
             strSql.Append("'" + OtherSellOrder.CreateDate + "',");
             strSql.Append("'" + OtherSellOrder.CheckGuid + "',");
             if (OtherSellOrder.CheckDate == DateTime.Parse("1900-01-01"))
             {
                 strSql.Append("null");
             }
             else
             {
                 strSql.Append("'" + OtherSellOrder.CheckDate + "'");
             }
             strSql.Append(")");
            return strSql.ToString();

        }


        /// <summary>
        /// 得到增加一条明细的SQL
        /// </summary>
        public string GetAddBillDetailSQL(OtherSellOrderDetail OtherSellOrderDetail)
        {
        StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into OtherSellOrderDetail(");
			strSql.Append("OtherSellOrderGuid,MaterialGuID,Price,MaterialSum,MaterialMoney,Remark,SortID");
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append("'"+OtherSellOrderDetail.OtherSellOrderGuid+"',");
			strSql.Append("'"+OtherSellOrderDetail.MaterialGuID+"',");
			strSql.Append(""+OtherSellOrderDetail.Price+",");
			strSql.Append(""+OtherSellOrderDetail.MaterialSum+",");
			strSql.Append(""+OtherSellOrderDetail.MaterialMoney+",");
			strSql.Append("'"+OtherSellOrderDetail.Remark+"',");
			strSql.Append(""+OtherSellOrderDetail.SortID+"");
			strSql.Append(")");
            return strSql.ToString();
        }



        /// <summary>
        /// 得到领料单的明细
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetOtherSellOrderDetail(string OtherSellOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select   *   from  V_OtherSellOrderDetail  where OtherSellOrderGuid='" + OtherSellOrderGuid + "' order by sortid";
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
        public DataTable GetOtherSellOrderBySQL(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_OtherSellOrder " + strsql + " order by CreateDate desc";
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
        public DataTable GetOtherSellOrderByOtherSellOrderGuid(string OtherSellOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_OtherSellOrder where OtherSellOrderGuid='" + OtherSellOrderGuid + "'";
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
        public void CheckBill(string OtherSellOrderGuid, int pass)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "";
                //删除主表
                if (pass == 1)
                {
                    //通过
                    ps_Sql = "update OtherSellOrder  set CheckGuid='" + SysParams.UserID + "',CheckDate='" + DateTime.Now.ToString() + "'  where OtherSellOrderGuid='" + OtherSellOrderGuid + "'";

                }
                else
                {
                    //不通过
                    ps_Sql = "update OtherSellOrder  set CheckGuid='',CheckDate=null  where OtherSellOrderGuid='" + OtherSellOrderGuid + "'";

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
        public bool GetIsCheck(string OtherSellOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  OtherSellOrderGuid,CheckGuid  from   OtherSellOrder where OtherSellOrderGuid='" + OtherSellOrderGuid + "' ";
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

