using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;

namespace ErpManageLibrary
{
    /// <summary>
    /// 文件入库
    /// </summary>
    public class FileInStorageManage
    {

        ///<summary>
        /// 保存数据
        /// </summary>
        /// <param name="pObj">信息集实体类</param>
        /// <returns>返回保存成功(true)或失败(false)</returns>
        public void SaveBill(FileInStorage FileInStorage, List<FileInStorageDetail> FileInStorageDetail)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from FileInStorage where  FileInStorageGuid='" + FileInStorage.FileInStorageGuID + "'";
                pComm.Execute(strDeleteSql);

                //插入主表数据
                string strInsertSql = GetAddBillSQL(FileInStorage);
                pComm.Execute(strInsertSql);


                //删除明细表
                strDeleteSql = "Delete from FileInStorageDetail where  FileInStorageGuid='" + FileInStorage.FileInStorageGuID + "'";
                pComm.Execute(strDeleteSql);

                //插入明细表数据
                for (int i = 0; i < FileInStorageDetail.Count; i++)
                {
                    strInsertSql = GetAddBillDetailSQL(FileInStorageDetail[i]);
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
        public void DeleteBill(string FileInStorageguid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from FileInStorage where  FileInStorageGuid='" + FileInStorageguid + "'";
                pComm.Execute(strDeleteSql);


                //删除明细表
                strDeleteSql = "Delete from FileInStorageDetail where  FileInStorageGuid='" + FileInStorageguid + "'";
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
        public string GetAddBillSQL(FileInStorage FileInStorage)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into FileInStorage(");
            strSql.Append("FileInStorageGuID,FileInStorageID,FileInStorageDate,FileInStoragePerson,Remark,CreateGuid,CreateDate,CheckGuid,CheckDate,CheckGuid2,CheckDate2");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + FileInStorage.FileInStorageGuID + "',");
            strSql.Append("'" + FileInStorage.FileInStorageID + "',");
            strSql.Append("'" + FileInStorage.FileInStorageDate + "',");
            strSql.Append("'" + FileInStorage.FileInStoragePerson + "',");
            strSql.Append("'" + FileInStorage.Remark + "',");
            strSql.Append("'" + FileInStorage.CreateGuid + "',");
            strSql.Append("'" + FileInStorage.CreateDate + "',");
            strSql.Append("'" + FileInStorage.CheckGuid + "',");
            if (FileInStorage.CheckDate == DateTime.Parse("1900-01-01"))
            {
                strSql.Append("null,");
            }
            else
            {
                strSql.Append("'" + FileInStorage.CheckDate + "',");
            }

            strSql.Append("'" + FileInStorage.CheckGuid2 + "',");
            if (FileInStorage.CheckDate2 == DateTime.Parse("1900-01-01"))
            {
                strSql.Append("null");
            }
            else
            {
                strSql.Append("'" + FileInStorage.CheckDate2 + "'");
            }

            strSql.Append(")");        
            return strSql.ToString();

        }


        /// <summary>
        /// 得到增加一条明细的SQL
        /// </summary>
        public string GetAddBillDetailSQL(FileInStorageDetail FileInStorageDetail)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into FileInStorageDetail(");
            strSql.Append("FileInStorageDetailGuID,FileInStorageGuID,FileGuID,SortID");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + FileInStorageDetail.FileInStorageDetailGuID + "',");
            strSql.Append("'" + FileInStorageDetail.FileInStorageGuID + "',");
            strSql.Append("'" + FileInStorageDetail.FileGuID + "',");
            strSql.Append("" + FileInStorageDetail.SortID + "");
            strSql.Append(")");

            return strSql.ToString();
        }



        /// <summary>
        /// 得到明细
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetFileInStorageDetail(string FileInStorageGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select   *   from  V_FileInStorageDetail  where FileInStorageGuid='" + FileInStorageGuid + "' order by sortid";
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
        /// 得到主表数据
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetFileInStorageBySQL(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_FileInStorage " + strsql + " order by CreateDate desc";
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
        /// 得到主表数据
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetFileInStorageByFileInStorageGuid(string FileInStorageGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_FileInStorage where FileInStorageGuid='" + FileInStorageGuid + "' order by CreateDate desc";
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
        public void CheckBill(string FileInStorageGuid, int pass)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "";
                //删除主表
                if (pass == 1)
                {
                    //通过
                    ps_Sql = "update FileInStorage  set CheckGuid='" + SysParams.UserID + "',CheckDate='" + DateTime.Now.ToString() + "'  where FileInStorageGuid='" +FileInStorageGuid + "'";

                }
                else
                {
                    //不通过
                    ps_Sql = "update FileInStorage  set CheckGuid='',CheckDate=null  where FileInStorageGuid='" +FileInStorageGuid + "'";

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
        public void CheckBill2(string FileInStorageGuid, int pass)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "";
                //删除主表
                if (pass == 1)
                {
                    //通过
                    ps_Sql = "update  FileInStorage  set CheckGuid2='" + SysParams.UserID + "',CheckDate2='" + DateTime.Now.ToString() + "'  where  FileInStorageGuid='" + FileInStorageGuid + "'";

                }
                else
                {
                    //不通过
                    ps_Sql = "update  FileInStorage  set CheckGuid2='',CheckDate2=null  where  FileInStorageGuid='" + FileInStorageGuid + "'";

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
        public string GetMaterialByFileInStorageDetailGuid(string FileInStorageDetailGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  FileGuid   from  FileInStorageDetail where FileInStorageDetailGuid='" + FileInStorageDetailGuid + "'";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

                pObj_Comm.Close();

                if (pDTMain.Rows.Count > 0)
                {
                    return pDTMain.Rows[0]["FileGuid"].ToString().Trim();
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
        public bool GetIsCheck(string FileInStorageGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  FileInStorageGuid,CheckGuid,CheckGuid2  from   FileInStorage where FileInStorageGuid='" + FileInStorageGuid + "' ";
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


        /// <summary>
        /// 得到某个料件是否已经入库并且审核
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public bool GetFileInStorageIsCheck(string FileGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  CheckGuid2  from   V_FileInStorageDetail  where FileGuid='" + FileGuid + "' ";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

                pObj_Comm.Close();

                if (pDTMain.Rows.Count > 0)
                {

                    if (pDTMain.Rows[0]["CheckGuid2"].ToString().Trim() != "")
                    {
                        return true;
                    }


                    return false;
                }
                else
                {
                    return false;
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
