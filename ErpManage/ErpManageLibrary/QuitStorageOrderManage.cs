using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;

namespace ErpManageLibrary
{
    /// <summary>
    /// 退料入库单
    /// </summary>
    public class QuitStorageOrderManage
    {
          ///<summary>
        /// 保存数据
        /// </summary>
        /// <param name="pObj">信息集实体类</param>
        /// <returns>返回保存成功(true)或失败(false)</returns>
        public void SaveBill(QuitStorageOrder QuitStorageOrder, List<QuitStorageOrderDetail> QuitStorageOrderDetail)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from QuitStorageOrder where  QuitStorageOrderGuid='" + QuitStorageOrder.QuitStorageOrderGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入主表数据
                string strInsertSql = GetAddBillSQL(QuitStorageOrder);
                pComm.Execute(strInsertSql);


                //删除明细表
                strDeleteSql = "Delete from QuitStorageOrderDetail where  QuitStorageOrderGuid='" + QuitStorageOrder.QuitStorageOrderGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入明细表数据
                for (int i = 0; i < QuitStorageOrderDetail.Count; i++)
                {
                    strInsertSql = GetAddBillDetailSQL(QuitStorageOrderDetail[i]);
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
        public void DeleteBill(string QuitStorageOrderguid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from QuitStorageOrder where  QuitStorageOrderGuid='" + QuitStorageOrderguid + "'";
                pComm.Execute(strDeleteSql);


                //删除明细表
                strDeleteSql = "Delete from QuitStorageOrderDetail where  QuitStorageOrderGuid='" + QuitStorageOrderguid + "'";
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
        public string GetAddBillSQL(QuitStorageOrder QuitStorageOrder)
        {
             StringBuilder strSql = new StringBuilder();
             strSql.Append("insert into QuitStorageOrder(");
             strSql.Append("QuitStorageOrderGuid,QuitStorageOrderID,QuitStorageOrderDate,Dept,InStorage,MaterialPerson,StoragePerson,QualityPerson,BatchNo,Remark,CreateGuid,CreateDate,CheckGuid,CheckDate");
             strSql.Append(")");
             strSql.Append(" values (");
             strSql.Append("'" + QuitStorageOrder.QuitStorageOrderGuid + "',");
             strSql.Append("'" + QuitStorageOrder.QuitStorageOrderID + "',");
             strSql.Append("'" + QuitStorageOrder.QuitStorageOrderDate + "',");
             strSql.Append("'" + QuitStorageOrder.Dept + "',");
             strSql.Append("'" + QuitStorageOrder.InStorage + "',");
             strSql.Append("'" + QuitStorageOrder.MaterialPerson + "',");
             strSql.Append("'" + QuitStorageOrder.StoragePerson + "',");
             strSql.Append("'" + QuitStorageOrder.QualityPerson + "',");
             strSql.Append("'" + QuitStorageOrder.BatchNo + "',");
             strSql.Append("'" + QuitStorageOrder.Remark + "',");
             strSql.Append("'" + QuitStorageOrder.CreateGuid + "',");
             strSql.Append("'" + QuitStorageOrder.CreateDate + "',");
             strSql.Append("'" + QuitStorageOrder.CheckGuid + "',");
             if (QuitStorageOrder.CheckDate == DateTime.Parse("1900-01-01"))
             {
                 strSql.Append("null");
             }
             else
             {
                 strSql.Append("'" + QuitStorageOrder.CheckDate + "'");
             }
             strSql.Append(")");

 
            return strSql.ToString();

        }


        /// <summary>
        /// 得到增加一条明细的SQL
        /// </summary>
        public string GetAddBillDetailSQL(QuitStorageOrderDetail QuitStorageOrderDetail)
        {
        StringBuilder strSql=new StringBuilder();
        strSql.Append("insert into QuitStorageOrderDetail(");
        strSql.Append("QuitStorageOrderGuid,MaterialGuID,MaterialSum,Remark,SortID");
        strSql.Append(")");
        strSql.Append(" values (");
        strSql.Append("'" + QuitStorageOrderDetail.QuitStorageOrderGuid + "',");
        strSql.Append("'" + QuitStorageOrderDetail.MaterialGuID + "',");
        strSql.Append("" + QuitStorageOrderDetail.MaterialSum + ",");
        strSql.Append("'" + QuitStorageOrderDetail.Remark + "',");
        strSql.Append("" + QuitStorageOrderDetail.SortID + "");
        strSql.Append(")");
            return strSql.ToString();
        }



        /// <summary>
        /// 得到领料单的明细
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetQuitStorageOrderDetail(string QuitStorageOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select   *   from  V_QuitStorageOrderDetail  where QuitStorageOrderGuid='" + QuitStorageOrderGuid + "' order by sortid";
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
        /// 得到退料入库单主表数据
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetQuitStorageOrderBySQL(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_QuitStorageOrder " + strsql + " order by CreateDate desc";
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
        /// 得到退料入库单主表数据
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetQuitStorageOrderByQuitStorageOrderGuid(string QuitStorageOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_QuitStorageOrder where QuitStorageOrderGuid='" + QuitStorageOrderGuid + "'";
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
        public void CheckBill(string QuitStorageOrderGuid, int pass)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "";
                //删除主表
                if (pass == 1)
                {
                    //通过
                    ps_Sql = "update QuitStorageOrder  set CheckGuid='" + SysParams.UserID + "',CheckDate='" + DateTime.Now.ToString() + "'  where QuitStorageOrderGuid='" + QuitStorageOrderGuid + "'";

                }
                else
                {
                    //不通过
                    ps_Sql = "update QuitStorageOrder  set CheckGuid='',CheckDate=null  where QuitStorageOrderGuid='" + QuitStorageOrderGuid + "'";

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
        public bool GetIsCheck(string QuitStorageOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select QuitStorageOrderGuid,CheckGuid  from   QuitStorageOrder where QuitStorageOrderGuid='" + QuitStorageOrderGuid + "' ";
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

