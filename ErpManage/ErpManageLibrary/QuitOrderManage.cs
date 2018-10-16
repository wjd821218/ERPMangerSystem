using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;

namespace ErpManageLibrary
{
    /// <summary>
    /// 退料单
    /// </summary>
    public class QuitOrderManage
    {
          ///<summary>
        /// 保存数据
        /// </summary>
        /// <param name="pObj">信息集实体类</param>
        /// <returns>返回保存成功(true)或失败(false)</returns>
        public void SaveBill(QuitOrder QuitOrder, List<QuitOrderDetail> QuitOrderDetail)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from QuitOrder where  QuitOrderGuid='" + QuitOrder.QuitOrderGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入主表数据
                string strInsertSql = GetAddBillSQL(QuitOrder);
                pComm.Execute(strInsertSql);


                //删除明细表
                strDeleteSql = "Delete from QuitOrderDetail where  QuitOrderGuid='" + QuitOrder.QuitOrderGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入明细表数据
                for (int i = 0; i < QuitOrderDetail.Count; i++)
                {
                    strInsertSql = GetAddBillDetailSQL(QuitOrderDetail[i]);
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
        public void DeleteBill(string QuitOrderguid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from QuitOrder where  QuitOrderGuid='" + QuitOrderguid + "'";
                pComm.Execute(strDeleteSql);


                //删除明细表
                strDeleteSql = "Delete from QuitOrderDetail where  QuitOrderGuid='" + QuitOrderguid + "'";
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
        public string GetAddBillSQL(QuitOrder QuitOrder)
        {
             StringBuilder strSql = new StringBuilder();
             strSql.Append("insert into QuitOrder(");
             strSql.Append("QuitOrderGuid,QuitOrderID,QuitOrderDate,SupplierGuid,DeliverGoodsPerson,StoragePerson,OutStorage,Remark,CreateGuid,CreateDate,CheckGuid,CheckDate,CheckGuid2,CheckDate2");
             strSql.Append(")");
             strSql.Append(" values (");
             strSql.Append("'" + QuitOrder.QuitOrderGuid + "',");
             strSql.Append("'" + QuitOrder.QuitOrderID + "',");
             strSql.Append("'" + QuitOrder.QuitOrderDate + "',");
             strSql.Append("'" + QuitOrder.SupplierGuid + "',");
             strSql.Append("'" + QuitOrder.DeliverGoodsPerson + "',");
             strSql.Append("'" + QuitOrder.StoragePerson + "',");
             strSql.Append("'" + QuitOrder.OutStorage + "',");
             strSql.Append("'" + QuitOrder.Remark + "',");
             strSql.Append("'" + QuitOrder.CreateGuid + "',");
             strSql.Append("'" + QuitOrder.CreateDate + "',");
             strSql.Append("'" + QuitOrder.CheckGuid + "',");
             if (QuitOrder.CheckDate == DateTime.Parse("1900-01-01"))
             {
                 strSql.Append("null,");
             }
             else
             {
                 strSql.Append("'" + QuitOrder.CheckDate2 + "',");
             }
             strSql.Append("'" + QuitOrder.CheckGuid2 + "',");
             if (QuitOrder.CheckDate2 == DateTime.Parse("1900-01-01"))
             {
                 strSql.Append("null");
             }
             else
             {
                 strSql.Append("'" + QuitOrder.CheckDate2 + "'");
             }
        
             strSql.Append(")");

            return strSql.ToString();

        }


        /// <summary>
        /// 得到增加一条明细的SQL
        /// </summary>
        public string GetAddBillDetailSQL(QuitOrderDetail QuitOrderDetail)
        {
        StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into QuitOrderDetail(");
			strSql.Append("QuitOrderGuid,MaterialGuID,Price,MaterialSum,MaterialMoney,Remark,SortID");
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append("'"+QuitOrderDetail.QuitOrderGuid+"',");
			strSql.Append("'"+QuitOrderDetail.MaterialGuID+"',");
			strSql.Append(""+QuitOrderDetail.Price+",");
			strSql.Append(""+QuitOrderDetail.MaterialSum+",");
			strSql.Append(""+QuitOrderDetail.MaterialMoney+",");
			strSql.Append("'"+QuitOrderDetail.Remark+"',");
			strSql.Append(""+QuitOrderDetail.SortID+"");
			strSql.Append(")");
            return strSql.ToString();
        }



        /// <summary>
        /// 得到领料单的明细
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetQuitOrderDetail(string QuitOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select   *   from  V_QuitOrderDetail  where QuitOrderGuid='" + QuitOrderGuid + "' order by sortid";
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
        public DataTable GetQuitOrderBySQL(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_QuitOrder " + strsql + " order by CreateDate desc";
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
        /// 得到退料单的明细
        /// </summary>
        /// <param name="QuitOrderGuid"></param>
        /// <returns></returns>
        public DataTable GetQuitOrderDetailBySelect(string QuitOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select   'False' as selectvalue,*   from  V_QuitOrderDetail  where QuitOrderGuid='" + QuitOrderGuid + "' order by sortid";
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
        public DataTable GetQuitOrderByQuitOrderGuid(string QuitOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_QuitOrder where QuitOrderGuid='" + QuitOrderGuid + "'";
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
        public void CheckBill(string QuitOrderGuid, int pass)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "";
                //删除主表
                if (pass == 1)
                {
                    //通过
                    ps_Sql = "update QuitOrder  set CheckGuid='" + SysParams.UserID + "',CheckDate='" + DateTime.Now.ToString() + "'  where QuitOrderGuid='" + QuitOrderGuid + "'";

                }
                else
                {
                    //不通过
                    ps_Sql = "update QuitOrder  set CheckGuid='',CheckDate=null  where QuitOrderGuid='" + QuitOrderGuid + "'";

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
        public void CheckBill2(string QuitOrderGuid, int pass)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "";
                //删除主表
                if (pass == 1)
                {
                    //通过
                    ps_Sql = "update  QuitOrder  set CheckGuid2='" + SysParams.UserID + "',CheckDate2='" + DateTime.Now.ToString() + "'  where  QuitOrderGuid='" + QuitOrderGuid + "'";

                }
                else
                {
                    //不通过
                    ps_Sql = "update  QuitOrder  set CheckGuid2='',CheckDate2=null  where  QuitOrderGuid='" + QuitOrderGuid + "'";

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
        public bool GetIsCheck(string QuitOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select QuitOrderGuid,CheckGuid,CheckGuid2  from   QuitOrder where QuitOrderGuid='" + QuitOrderGuid + "' ";
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

