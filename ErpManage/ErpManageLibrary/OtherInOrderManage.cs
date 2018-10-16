using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;

namespace ErpManageLibrary
{
    /// <summary>
    /// 其它入库单
    /// </summary>
    public class OtherInOrderManage
    {
          ///<summary>
        /// 保存数据
        /// </summary>
        /// <param name="pObj">信息集实体类</param>
        /// <returns>返回保存成功(true)或失败(false)</returns>
        public void SaveBill(OtherInOrder OtherInOrder, List<OtherInOrderDetail> OtherInOrderDetail)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from OtherInOrder where  OtherInOrderGuid='" + OtherInOrder.OtherInOrderGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入主表数据
                string strInsertSql = GetAddBillSQL(OtherInOrder);
                pComm.Execute(strInsertSql);


                //删除明细表
                strDeleteSql = "Delete from OtherInOrderDetail where  OtherInOrderGuid='" + OtherInOrder.OtherInOrderGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入明细表数据
                for (int i = 0; i < OtherInOrderDetail.Count; i++)
                {
                    strInsertSql = GetAddBillDetailSQL(OtherInOrderDetail[i]);
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
        public void DeleteBill(string OtherInOrderguid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from OtherInOrder where  OtherInOrderGuid='" + OtherInOrderguid + "'";
                pComm.Execute(strDeleteSql);


                //删除明细表
                strDeleteSql = "Delete from OtherInOrderDetail where  OtherInOrderGuid='" + OtherInOrderguid + "'";
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
        public string GetAddBillSQL(OtherInOrder OtherInOrder)
        {
             StringBuilder strSql = new StringBuilder();
             strSql.Append("insert into OtherInOrder(");
             strSql.Append("OtherInOrderGuid,OtherInOrderID,OtherInOrderDate,InStorage,StoragePerson,QualityPerson,BatchNo,Remark,CreateGuid,CreateDate,CheckGuid,CheckDate");
             strSql.Append(")");
             strSql.Append(" values (");
             strSql.Append("'" + OtherInOrder.OtherInOrderGuid + "',");
             strSql.Append("'" + OtherInOrder.OtherInOrderID + "',");
             strSql.Append("'" + OtherInOrder.OtherInOrderDate + "',");
             strSql.Append("'" + OtherInOrder.InStorage + "',");
             strSql.Append("'" + OtherInOrder.StoragePerson + "',");
             strSql.Append("'" + OtherInOrder.QualityPerson + "',");
             strSql.Append("'" + OtherInOrder.BatchNo + "',");
             strSql.Append("'" + OtherInOrder.Remark + "',");
             strSql.Append("'" + OtherInOrder.CreateGuid + "',");
             strSql.Append("'" + OtherInOrder.CreateDate + "',");
             strSql.Append("'" + OtherInOrder.CheckGuid + "',");
             if (OtherInOrder.CheckDate == DateTime.Parse("1900-01-01"))
             {
                 strSql.Append("null");
             }
             else
             {
                 strSql.Append("'" + OtherInOrder.CheckDate + "'");
             }
             strSql.Append(")");
            return strSql.ToString();

        }


        /// <summary>
        /// 得到增加一条明细的SQL
        /// </summary>
        public string GetAddBillDetailSQL(OtherInOrderDetail OtherInOrderDetail)
        {
        StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into OtherInOrderDetail(");
			strSql.Append("OtherInOrderGuid,MaterialGuID,Price,MaterialSum,MaterialMoney,Remark,SortID");
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append("'"+OtherInOrderDetail.OtherInOrderGuid+"',");
			strSql.Append("'"+OtherInOrderDetail.MaterialGuID+"',");
			strSql.Append(""+OtherInOrderDetail.Price+",");
			strSql.Append(""+OtherInOrderDetail.MaterialSum+",");
			strSql.Append(""+OtherInOrderDetail.MaterialMoney+",");
			strSql.Append("'"+OtherInOrderDetail.Remark+"',");
			strSql.Append(""+OtherInOrderDetail.SortID+"");
			strSql.Append(")");
            return strSql.ToString();
        }



        /// <summary>
        /// 得到其它入库单的明细
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetOtherInOrderDetail(string OtherInOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select   *   from  V_OtherInOrderDetail  where OtherInOrderGuid='" + OtherInOrderGuid + "' order by sortid";
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
        /// 得到其它入库单主表数据
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetOtherInOrderBySQL(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_OtherInOrder " + strsql + " order by CreateDate desc";
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
        /// 得到其它入库单主表数据
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetOtherInOrderByOtherInOrderGuid(string OtherInOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_OtherInOrder where OtherInOrderGuid='" + OtherInOrderGuid + "'";
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
        public void CheckBill(string OtherInOrderGuid, int pass)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "";
                //删除主表
                if (pass == 1)
                {
                    //通过
                    ps_Sql = "update OtherInOrder  set CheckGuid='" + SysParams.UserID + "',CheckDate='" + DateTime.Now.ToString() + "'  where OtherInOrderGuid='" + OtherInOrderGuid + "'";

                }
                else
                {
                    //不通过
                    ps_Sql = "update OtherInOrder  set CheckGuid='',CheckDate=null  where OtherInOrderGuid='" + OtherInOrderGuid + "'";

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
        /// 得到客户订单是否已审核
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public bool GetIsCheck(string OtherInOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  OtherInOrderGuid,CheckGuid  from   OtherInOrder where OtherInOrderGuid='" + OtherInOrderGuid + "' ";
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

