using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;

namespace ErpManageLibrary
{
    /// <summary>
    ///  调拨单
    /// </summary>
    public class RemoveBillManage
    {
        
          ///<summary>
        /// 保存数据
        /// </summary>
        /// <param name="pObj">信息集实体类</param>
        /// <returns>返回保存成功(true)或失败(false)</returns>
        public void SaveBill(RemoveBill RemoveBill, List<RemoveBillDetail> RemoveBillDetail)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from RemoveBill where  RemoveBillGuid='" + RemoveBill.RemoveBillGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入主表数据
                string strInsertSql = GetAddBillSQL(RemoveBill);
                pComm.Execute(strInsertSql);


                //删除明细表
                strDeleteSql = "Delete from RemoveBillDetail where  RemoveBillGuid='" + RemoveBill.RemoveBillGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入明细表数据
                for (int i = 0; i < RemoveBillDetail.Count; i++)
                {
                    strInsertSql = GetAddBillDetailSQL(RemoveBillDetail[i]);
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
        public void DeleteBill(string RemoveBillguid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from RemoveBill where  RemoveBillGuid='" + RemoveBillguid + "'";
                pComm.Execute(strDeleteSql);


                //删除明细表
                strDeleteSql = "Delete from RemoveBillDetail where  RemoveBillGuid='" + RemoveBillguid + "'";
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
        public string GetAddBillSQL(RemoveBill RemoveBill)
        {
             StringBuilder strSql=new StringBuilder();
             strSql.Append("insert into [RemoveBill](");
             strSql.Append("RemoveBillGuid,RemoveBillID,RemoveBillDate,DepotOut,DepotIn,HandlePerson,Remark,CreateGuid,CreateDate,CheckGuid,CheckDate");
             strSql.Append(")");
             strSql.Append(" values (");
             strSql.Append("'" + RemoveBill.RemoveBillGuid + "',");
             strSql.Append("'" + RemoveBill.RemoveBillID + "',");
             strSql.Append("'" + RemoveBill.RemoveBillDate + "',");
             strSql.Append("'" + RemoveBill.DepotOut + "',");
             strSql.Append("'" + RemoveBill.DepotIn + "',");
             strSql.Append("'" + RemoveBill.HandlePerson + "',");
             strSql.Append("'" + RemoveBill.Remark + "',");
             strSql.Append("'" + RemoveBill.CreateGuid + "',");
             strSql.Append("'" + RemoveBill.CreateDate + "',");
             strSql.Append("'" + RemoveBill.CheckGuid + "',");
			 if (RemoveBill.CheckDate == DateTime.Parse("1900-01-01"))
            {
                strSql.Append("null");
            }
            else
            {
                strSql.Append("'" + RemoveBill.CheckDate + "'");
            }
			strSql.Append(")");
            return strSql.ToString();

        }


        /// <summary>
        /// 得到增加一条明细的SQL
        /// </summary>
        public string GetAddBillDetailSQL(RemoveBillDetail RemoveBillDetail)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [RemoveBillDetail](");
            strSql.Append("RemoveBillGuid,MaterialGuID,MaterialSum");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + RemoveBillDetail.RemoveBillGuid + "',");
            strSql.Append("'" + RemoveBillDetail.MaterialGuID + "',");
            strSql.Append("" + RemoveBillDetail.MaterialSum + "");
            strSql.Append(")");
            return strSql.ToString();
        }



        /// <summary>
        /// 得到调拨单的明细
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetRemoveBillDetail(string RemoveBillGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select   *   from  V_RemoveBillDetail  where RemoveBillGuid='" + RemoveBillGuid + "' order by sortid";
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
        /// 得到调拨单主表数据
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetRemoveBillBySQL(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_RemoveBill " + strsql + " order by CreateDate desc";
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
        /// 得到调拨单主表数据
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetRemoveBillByRemoveBillGuid(string RemoveBillGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_RemoveBill where RemoveBillGuid='" + RemoveBillGuid + "'";
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
        public void CheckBill(string RemoveBillGuid, int pass)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "";
                //删除主表
                if (pass == 1)
                {
                    //通过
                    ps_Sql = "update RemoveBill  set CheckGuid='" + SysParams.UserID + "',CheckDate='" + DateTime.Now.ToString() + "'  where RemoveBillGuid='" + RemoveBillGuid + "'";

                }
                else
                {
                    //不通过
                    ps_Sql = "update RemoveBill  set CheckGuid='',CheckDate=null  where RemoveBillGuid='" + RemoveBillGuid + "'";

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
        /// 更新二审核状态度
        /// </summary>
        /// <returns></returns>
        public void CheckBill2(string RemoveBillGuid, int pass)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "";
                //删除主表
                if (pass == 1)
                {
                    //通过
                    ps_Sql = "update RemoveBill  set CheckGuid2='" + SysParams.UserID + "',CheckDate2='" + DateTime.Now.ToString() + "'  where RemoveBillGuid='" + RemoveBillGuid + "'";

                }
                else
                {
                    //不通过
                    ps_Sql = "update RemoveBill  set CheckGuid2='',CheckDate2=null  where RemoveBillGuid='" + RemoveBillGuid + "'";

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
        /// 得到调拨单是否已审核或已结单-
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public bool GetIsCheck(string RemoveBillGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select RemoveBillGuid,CheckGuid  from   RemoveBill where RemoveBillGuid='" + RemoveBillGuid + "' ";
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

