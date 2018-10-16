using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;

namespace ErpManageLibrary
{
    /// <summary>
    /// 报废单
    /// </summary>
    public class RejectOrderManage
    {

        ///<summary>
        /// 保存数据
        /// </summary>
        /// <param name="pObj">信息集实体类</param>
        /// <returns>返回保存成功(true)或失败(false)</returns>
        public void SaveBill(RejectOrder RejectOrder, List<RejectOrderDetail> RejectOrderDetail)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from RejectOrder where  RejectOrderGuid='" + RejectOrder.RejectOrderGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入主表数据
                string strInsertSql = GetAddBillSQL(RejectOrder);
                pComm.Execute(strInsertSql);


                //删除明细表
                strDeleteSql = "Delete from RejectOrderDetail where  RejectOrderGuid='" + RejectOrder.RejectOrderGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入明细表数据
                for (int i = 0; i < RejectOrderDetail.Count; i++)
                {
                    strInsertSql = GetAddBillDetailSQL(RejectOrderDetail[i]);
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
        public void DeleteBill(string RejectOrderguid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from RejectOrder where  RejectOrderGuid='" + RejectOrderguid + "'";
                pComm.Execute(strDeleteSql);


                //删除明细表
                strDeleteSql = "Delete from RejectOrderDetail where  RejectOrderGuid='" + RejectOrderguid + "'";
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
        public string GetAddBillSQL(RejectOrder RejectOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into RejectOrder(");
            strSql.Append("RejectOrderGuid,RejectOrderID,RejectOrderDate,ProductType,ClientOrderID,StoragePerson,QualityPerson,ProjectPerson,StockPerson,ProducePerson,Remark,RejectStorage,CreateGuid,CreateDate,CheckGuid,CheckDate,CheckGuid2,CheckDate2");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + RejectOrder.RejectOrderGuid + "',");
            strSql.Append("'" + RejectOrder.RejectOrderID + "',");
            strSql.Append("'" + RejectOrder.RejectOrderDate + "',");
            strSql.Append("'" + RejectOrder.ProductType + "',");
            strSql.Append("'" + RejectOrder.ClientOrderID + "',");
            strSql.Append("'" + RejectOrder.StoragePerson + "',");
            strSql.Append("'" + RejectOrder.QualityPerson + "',");
            strSql.Append("'" + RejectOrder.ProjectPerson + "',");
            strSql.Append("'" + RejectOrder.StockPerson + "',");
            strSql.Append("'" + RejectOrder.ProducePerson + "',");
            strSql.Append("'" + RejectOrder.Remark + "',");
            strSql.Append("'" + RejectOrder.RejectStorage + "',");
            strSql.Append("'" + RejectOrder.CreateGuid + "',");
            strSql.Append("'" + RejectOrder.CreateDate + "',");
            strSql.Append("'" + RejectOrder.CheckGuid + "',");
            if (RejectOrder.CheckDate == DateTime.Parse("1900-01-01"))
            {
                strSql.Append("null,");
            }
            else
            {
                strSql.Append("'" + RejectOrder.CheckDate + "',");
            }

            strSql.Append("'" + RejectOrder.CheckGuid2 + "',");
            if (RejectOrder.CheckDate2 == DateTime.Parse("1900-01-01"))
            {
                strSql.Append("null");
            }
            else
            {
                strSql.Append("'" + RejectOrder.CheckDate2 + "'");
            }

            strSql.Append(")");        
            return strSql.ToString();

        }


        /// <summary>
        /// 得到增加一条明细的SQL
        /// </summary>
        public string GetAddBillDetailSQL(RejectOrderDetail RejectOrderDetail)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into RejectOrderDetail(");
            strSql.Append("RejectOrderGuid,MaterialGuID,MaterialSum,Remark,SortID");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + RejectOrderDetail.RejectOrderGuid + "',");
            strSql.Append("'" + RejectOrderDetail.MaterialGuID + "',");
            strSql.Append("" + RejectOrderDetail.MaterialSum + ",");
            strSql.Append("'" + RejectOrderDetail.Remark + "',");
            strSql.Append("" + RejectOrderDetail.SortID + "");
            strSql.Append(")");

            return strSql.ToString();
        }



        /// <summary>
        /// 得到报废单的明细
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetRejectOrderDetail(string RejectOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select   *   from  V_RejectOrderDetail  where RejectOrderGuid='" + RejectOrderGuid + "' order by sortid";
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
        /// 得到报废单主表数据
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetRejectOrderBySQL(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_RejectOrder " + strsql + " order by CreateDate desc";
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
        /// 得到报废单主表数据
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetRejectOrderByRejectOrderGuid(string RejectOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_RejectOrder where RejectOrderGuid='" + RejectOrderGuid + "' order by CreateDate desc";
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
        public void CheckBill(string RejectOrderGuid, int pass)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "";
                //删除主表
                if (pass == 1)
                {
                    //通过
                    ps_Sql = "update RejectOrder  set CheckGuid='" + SysParams.UserID + "',CheckDate='" + DateTime.Now.ToString() + "'  where RejectOrderGuid='" +RejectOrderGuid + "'";

                }
                else
                {
                    //不通过
                    ps_Sql = "update RejectOrder  set CheckGuid='',CheckDate=null  where RejectOrderGuid='" +RejectOrderGuid + "'";

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
        public void CheckBill2(string RejectOrderGuid, int pass)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "";
                //删除主表
                if (pass == 1)
                {
                    //通过
                    ps_Sql = "update  RejectOrder  set CheckGuid2='" + SysParams.UserID + "',CheckDate2='" + DateTime.Now.ToString() + "'  where  RejectOrderGuid='" + RejectOrderGuid + "'";

                }
                else
                {
                    //不通过
                    ps_Sql = "update  RejectOrder  set CheckGuid2='',CheckDate2=null  where  RejectOrderGuid='" + RejectOrderGuid + "'";

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
        /// 得到报废单主表数据
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public string GetMaterialByRejectOrderDetailGuid(string RejectOrderDetailGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  MaterialGuid   from  RejectOrderDetail where RejectOrderDetailGuid='" + RejectOrderDetailGuid + "'";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

                pObj_Comm.Close();

                if (pDTMain.Rows.Count > 0)
                {
                    return pDTMain.Rows[0]["MaterialGuid"].ToString().Trim();
                }
                else
                {
                    return "";
                }

               
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
        public bool GetIsCheck(string RejectOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  RejectOrderGuid,CheckGuid,CheckGuid2  from   RejectOrder where RejectOrderGuid='" + RejectOrderGuid + "' ";
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
