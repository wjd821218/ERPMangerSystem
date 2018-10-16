using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;

namespace ErpManageLibrary
{
    /// <summary>
    /// 文件申请
    /// </summary>
    public class FileApplyManage
    {

        ///<summary>
        /// 保存数据
        /// </summary>
        /// <param name="pObj">信息集实体类</param>
        /// <returns>返回保存成功(true)或失败(false)</returns>
        public void SaveBill(FileApply FileApply, List<FileApplyDetail> FileApplyDetail, List<FileApplyPersonDetail> lstFileApplyPersonDetail)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from FileApply where  FileApplyGuid='" + FileApply.FileApplyGuID + "'";
                pComm.Execute(strDeleteSql);

                //插入主表数据
                string strInsertSql = GetAddBillSQL(FileApply);
                pComm.Execute(strInsertSql);


                //删除明细表
                strDeleteSql = "Delete from FileApplyDetail where  FileApplyGuid='" + FileApply.FileApplyGuID + "'";
                pComm.Execute(strDeleteSql);

                //插入明细表数据
                for (int i = 0; i < FileApplyDetail.Count; i++)
                {
                    strInsertSql = GetAddBillDetailSQL(FileApplyDetail[i]);
                    pComm.Execute(strInsertSql);
                }

                //删除申请人员明细
                strDeleteSql = "Delete from FileApplyPersonDetail where  FileApplyGuid='" + FileApply.FileApplyGuID + "'";
                pComm.Execute(strDeleteSql);



                //插入申请人员明细
                for (int i = 0; i < lstFileApplyPersonDetail.Count; i++)
                {
                    strInsertSql = GetAddBillPersonDetailSQL(lstFileApplyPersonDetail[i]);
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
        public void DeleteBill(string FileApplyguid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from FileApply where  FileApplyGuid='" + FileApplyguid + "'";
                pComm.Execute(strDeleteSql);


                //删除明细表
                strDeleteSql = "Delete from FileApplyDetail where  FileApplyGuid='" + FileApplyguid + "'";
                pComm.Execute(strDeleteSql);


                //删除申请人明细表
                strDeleteSql = "Delete from FileApplyPersonDetail where  FileApplyGuid='" + FileApplyguid + "'";
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
        public string GetAddBillSQL(FileApply FileApply)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into FileApply(");
            strSql.Append("FileApplyGuID,FileApplyID,FileApplyDate,FileApplyType,FileApplyPerson,FileApplyDept,Remark,CreateGuid,CreateDate,CheckGuid,CheckDate ");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + FileApply.FileApplyGuID + "',");
            strSql.Append("'" + FileApply.FileApplyID + "',");
            strSql.Append("'" + FileApply.FileApplyDate + "',");
            strSql.Append("'" + FileApply.FileApplyType + "',");
            strSql.Append("'" + FileApply.FileApplyPerson + "',");
            strSql.Append("'" + FileApply.FileApplyDept + "',");
            strSql.Append("'" + FileApply.Remark + "',");
            strSql.Append("'" + FileApply.CreateGuid + "',");
            strSql.Append("'" + FileApply.CreateDate + "',");
            strSql.Append("'" + FileApply.CheckGuid + "',");
            if (FileApply.CheckDate == DateTime.Parse("1900-01-01"))
            {
                strSql.Append("null");
            }
            else
            {
                strSql.Append("'" + FileApply.CheckDate + "'");
            }

          
            strSql.Append(")");        
            return strSql.ToString();

        }


        /// <summary>
        /// 得到增加一条明细的SQL
        /// </summary>
        public string GetAddBillDetailSQL(FileApplyDetail FileApplyDetail)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into FileApplyDetail(");
            strSql.Append("FileApplyDetailGuID,FileApplyGuID,FileGuID,IsDownload,SortID");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + FileApplyDetail.FileApplyDetailGuID + "',");
            strSql.Append("'" + FileApplyDetail.FileApplyGuID + "',");
            strSql.Append("'" + FileApplyDetail.FileGuID + "',");
            strSql.Append("'" + FileApplyDetail.IsDownload + "',");
            strSql.Append("" + FileApplyDetail.SortID + "");
            strSql.Append(")");

            return strSql.ToString();
        }


        /// <summary>
        /// 得到增加一条明细的SQL
        /// </summary>
        public string GetAddBillPersonDetailSQL(FileApplyPersonDetail FileApplyPersonDetail)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [FileApplyPersonDetail](");
            strSql.Append("FileApplyPersonDetailGuID,FileApplyGuID,PersonGuID,SortID");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + FileApplyPersonDetail.FileApplyPersonDetailGuID + "',");
            strSql.Append("'" + FileApplyPersonDetail.FileApplyGuID + "',");
            strSql.Append("'" + FileApplyPersonDetail.PersonGuID + "',");
            strSql.Append("" + FileApplyPersonDetail.SortID + "");
            strSql.Append(")");

            return strSql.ToString();
        }







        /// <summary>
        /// 得到明细
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetFileApplyDetail(string FileApplyGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select   *,case IsDownLoad when '1' then '是' when '0' then '否' end as IsDownloadName    from  V_FileApplyDetail  where FileApplyGuid='" + FileApplyGuid + "' order by sortid";
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
        /// 得到明细
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetFileApplyPersonDetail(string FileApplyGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select   *   from  V_FileApplyPersonDetail  where FileApplyGuid='" + FileApplyGuid + "' order by sortid";
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
        public DataTable GetFileApplyBySQL(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *,case when FileApplyType='1' then '员工' else '部门' end as FileApplyTypeName   from  V_FileApply " + strsql + " order by CreateDate desc";
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
        public DataTable GetFileApplyByFileApplyGuid(string FileApplyGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  * ,case when FileApplyType='1' then '员工' else '部门' end as FileApplyTypeName   from  V_FileApply where FileApplyGuid='" + FileApplyGuid + "' order by CreateDate desc";
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
        public void CheckBill(string FileApplyGuid, int pass)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "";
                //删除主表
                if (pass == 1)
                {
                    //通过
                    ps_Sql = "update FileApply  set CheckGuid='" + SysParams.UserID + "',CheckDate='" + DateTime.Now.ToString() + "'  where FileApplyGuid='" +FileApplyGuid + "'";

                }
                else
                {
                    //不通过
                    ps_Sql = "update FileApply  set CheckGuid='',CheckDate=null  where FileApplyGuid='" +FileApplyGuid + "'";

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
        public string GetMaterialByFileApplyDetailGuid(string FileApplyDetailGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  FileGuid   from  FileApplyDetail where FileApplyDetailGuid='" + FileApplyDetailGuid + "'";
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
        public bool GetIsCheck(string FileApplyGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  FileApplyGuid,CheckGuid from   FileApply where FileApplyGuid='" + FileApplyGuid + "' ";
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


        /// <summary>
        /// 判断当前用户是否有查看此文件的权限，申请单中的申请人中有此用户或此人在这个申请部门中才能相看权限
        /// </summary>
        /// <param name="FileApplyGuid"></param>
        /// <param name="LoginUserID"></param>
        /// <returns></returns>
        public bool IsViewRight_User(string FileApplyGuid, string LoginUserName)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  FileApplyPersonDetailGuID from   FileApplyPersonDetail F left join employee  E on  F.PersonGuID=E.EmpGuID where F.FileApplyGuid='" + FileApplyGuid + "' and E.EmpName='" + LoginUserName + "'";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

                pObj_Comm.Close();

                if (pDTMain.Rows.Count > 0)
                {
                    return true;

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


        /// <summary>
        /// 判断当前用户是否有查看此文件的权限，申请单中的申请人中有此用户或此人在这个申请部门中才能相看权限
        /// </summary>
        /// <param name="FileApplyGuid"></param>
        /// <param name="LoginUserID"></param>
        /// <returns></returns>
        public bool IsViewRight_Dept(string FileApplyGuid, string LoginUserName)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            DataTable pDTMain2 = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  FileApplyDept  from   FileApply  where FileApplyGuid='" + FileApplyGuid + "'";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

                LoginUserManage LoginUserManage = new LoginUserManage();
                ps_Sql = "select Dept  from Employee  where EmpName='" + LoginUserName + "'";
                pDTMain2 = pObj_Comm.ExeForDtl(ps_Sql);

                pObj_Comm.Close();

                if (pDTMain.Rows.Count > 0 && pDTMain2.Rows.Count > 0)
                {
                    if (pDTMain.Rows[0]["FileApplyDept"].ToString() == pDTMain2.Rows[0]["Dept"].ToString())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

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

        /// <summary>
        /// 是否有下载权限
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        public bool IsDownloadByUserID(string UserID,string UserDept,string FileGuID)
        {
            string ps_Sql = "";
            bool IsValue = false;
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  IsDownLoad  from   V_FileApply_ApplyPerson where FileGuID='" + FileGuID + "' and (PersonGuID='" + UserID + "' or FileApplyDept='" + UserDept + "')";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

                pObj_Comm.Close();

                if (pDTMain.Rows.Count > 0)
                {
                    for (int i = 0; i < pDTMain.Rows.Count; i++)
                    {
                        if (pDTMain.Rows[i]["IsDownLoad"].ToString() == "1")
                        {
                            IsValue = true;
                            break;
                        }
                    }

                }
                else
                {
                    IsValue= false;
                }


                return IsValue;
            }
            catch (Exception e)
            {
                pObj_Comm.Close();
                throw e;
            }
        }
    }
}
