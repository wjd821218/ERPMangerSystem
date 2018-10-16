using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Daniel.Liu.DAO;
using System.Data.SqlClient;

namespace ErpManageLibrary
{
    /// <summary>
    /// 工程更改单
    /// </summary>
    public class ChangeBillManage
    {
        
        ///<summary>
        /// 保存数据
        /// </summary>
        /// <param name="pObj">信息集实体类</param>
        /// <returns>返回保存成功(true)或失败(false)</returns>
        public void SaveChangeBill(ChangeBill ChangeBill, List<ChangeBillDataAttachment> ChangeBillDataAttachment)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from ChangeBill where  ChangeBillGuID='" + ChangeBill.ChangeBillGuID + "'";
                pComm.Execute(strDeleteSql);

                //插入主表数据
                string strInsertSql = GetAddSQL(ChangeBill);
                pComm.Execute(strInsertSql);


                //删除明细表
                strDeleteSql = "Delete from ChangeBillDataAttachment where  ChangeBillGuID='" + ChangeBill.ChangeBillGuID + "'";
                pComm.Execute(strDeleteSql);

                //插入明细表数据
                for (int i = 0; i < ChangeBillDataAttachment.Count; i++)
                {
                    AddChangeBillDataAttachment(ChangeBillDataAttachment[i], pComm);
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
        public void DeleteChangeBill(string ChangeBillGuID)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from ChangeBill where  ChangeBillGuID='" + ChangeBillGuID + "'";
                pComm.Execute(strDeleteSql);


                //删除明细附件表
                strDeleteSql = "Delete from ChangeBillDataAttachment where  ChangeBillGuID='" + ChangeBillGuID + "'";
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
        /// 增加文档主表数据
        /// </summary>
        public string GetAddSQL(ChangeBill ChangeBill)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ChangeBill(");
            strSql.Append("ChangeBillGuID,ChangeBillID,ChangeBillDate,ChangePerson,FileGuID,NewVersionID,Remark,CreateGuid,CreateDate,CheckGuid,CheckDate");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + ChangeBill.ChangeBillGuID + "',");
            strSql.Append("'" + ChangeBill.ChangeBillID + "',");
            strSql.Append("'" + ChangeBill.ChangeBillDate + "',");
            strSql.Append("'" + ChangeBill.ChangePerson + "',");
            strSql.Append("'" + ChangeBill.FileGuID + "',");
            strSql.Append("'" + ChangeBill.NewVersionID + "',");
            strSql.Append("'" + ChangeBill.Remark + "',");
            strSql.Append("'" + ChangeBill.CreateGuid + "',");
            strSql.Append("'" + ChangeBill.CreateDate + "',");
            strSql.Append("'" + ChangeBill.CheckGuid + "',");
            if (ChangeBill.CheckDate == DateTime.Parse("1900-01-01"))
            {
                strSql.Append("null");
            }
            else
            {
                strSql.Append("'" + ChangeBill.CheckDate + "'");
            }
            strSql.Append(")");
            return strSql.ToString();
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void AddChangeBillDataAttachment(ChangeBillDataAttachment ChangeBillDataAttachment, CommonInterface pcomm)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ChangeBillDataAttachment(");
            strSql.Append("ChangeBillDataAttachmentGuID,ChangeBillGuID,FileGuID,FileSourceName,FileContent)");
            strSql.Append(" values (");
            strSql.Append("@ChangeBillDataAttachmentGuid,@ChangeBillGuID,@FileGuID,@FileSourceName,@FileContent)");

            SqlParameter[] parameters = {
					new SqlParameter("@ChangeBillDataAttachmentGuID", SqlDbType.NVarChar,50),
                	new SqlParameter("@ChangeBillGuID", SqlDbType.NVarChar,50),
					new SqlParameter("@FileGuID", SqlDbType.NVarChar,50),
					new SqlParameter("@FileSourceName", SqlDbType.NVarChar,100),
					new SqlParameter("@FileContent", SqlDbType.Image)};
            parameters[0].Value = ChangeBillDataAttachment.ChangeBillDataAttachmentGuID;
            parameters[1].Value = ChangeBillDataAttachment.ChangeBillGuID;
            parameters[2].Value = ChangeBillDataAttachment.FileGuID;
            parameters[3].Value = ChangeBillDataAttachment.FileSourceName;
            parameters[4].Value = ChangeBillDataAttachment.FileContent;

            pcomm.ExecuteNonQueryBySqlParameters(strSql.ToString(), parameters);

        }



        /// <summary>
        /// 得到所有产品类另信息
        /// </summary>
        /// <returns>pDTMain 字段信息集</returns>
        public DataTable GetChangeBillDataAttachmentByGuID(string GuID)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select ChangeBillDataAttachmentGuID,ChangeBillGuID,FileGuID,FileSourceName,FileContent  "
                     + " from ChangeBillDataAttachment  where  ChangeBillDataAttachmentGuID='" + GuID + "'  order by SortID";

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
        /// 得到所有产品类另信息
        /// </summary>
        /// <returns>pDTMain 字段信息集</returns>
        public DataTable GetChangeBill(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select *   from V_ChangeBill " + strsql +"  order by ChangeBillDate desc";

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
        /// 得到所有产品类另信息
        /// </summary>
        /// <returns>pDTMain 字段信息集</returns>
        public DataTable GetChangeBillByChangeBillGuID(string ChangeBillGuID)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select *   from V_ChangeBill where ChangeBillGuID='" + ChangeBillGuID + "'";

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
        /// 得到一个对象实体
        /// </summary>
        public DataTable GetChangeBillDataAttachment(string ChangeBillGuID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  *  from ChangeBillDataAttachment  ");
            strSql.Append(" where ChangeBillGuID='" + ChangeBillGuID + "' ");

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);

            DataTable dtl = pComm.ExeForDtl(strSql.ToString());

            return dtl;
        }



        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public DataTable GetChangeBillDataAttachmentByGuid(string ChangeBillDataAttachmentGuid)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  *  from ChangeBillDataAttachment  ");
            strSql.Append(" where ChangeBillDataAttachmentGuid='" + ChangeBillDataAttachmentGuid + "' ");

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);

            DataTable dtl = pComm.ExeForDtl(strSql.ToString());

            return dtl;
        }


        /// <summary>
        /// 得到客户订单是否已审核或已结单-
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public bool GetIsCheck(string ChangeBillGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  ChangeBillGuid,CheckGuid from   ChangeBill where ChangeBillGuid='" + ChangeBillGuid + "' ";
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
        /// 判断当前工种更改单号是否已经存在
        /// </summary>
        public bool IsExistChangeBillID(string ChangeBillID,string ChangeBillGuID, bool IsEdit)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);

            ps_Sql = " select  ChangeBillGuID from   ChangeBill where ChangeBillID='" + ChangeBillID + "' ";


            try
            {
                DataTable dt = pObj_Comm.ExeForDtl(ps_Sql);
                pObj_Comm.Close();
                if (dt.Rows.Count > 0)
                {
                    if (IsEdit == false)
                    {
                        return true;  //Exist
                    }
                    else
                    {
                        string strChangeBillGuID = dt.Rows[0]["ChangeBillGuID"].ToString();
                        if (strChangeBillGuID.Trim() != ChangeBillGuID.Trim())
                        {
                            return true;  //Exist
                        }
                        else
                        {
                            return false; //Not Exist

                        }

                    }
                }
                else
                {
                    return false; //Not Exist
                }

            }
            catch (Exception e)
            {
                pObj_Comm.Close();
                throw e;
            }
        }
          

        /// <summary>
        /// 更新审核状态度,同时要执行业务
        /// 1.先找到当前文件编号+版本的记录，复制一条出来，只是将新版本号去更新这条记录
        /// 2.同时将当前工程更改单中的附件数据也更新到刚才复制出来的记录中，将原来老的记录删除掉
        /// 3.同时将所有申请单中引用旧的编号+版本号的记录全部替换成新的复制出来的那条记录guid
        /// </summary>
        /// <returns></returns>
        public void CheckBill(string ChangeBillGuID, int pass,string FileGuID,string NewVersionID)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            pObj_Comm.BeginTrans();
            try
            {
                string ps_Sql = "";
                //删除主表
                if (pass == 1)
                {

                    //更新审批状态
                    ps_Sql = "update ChangeBill  set CheckGuid='" + SysParams.UserID + "',CheckDate='" + DateTime.Now.ToString() + "'  where ChangeBillGuID='" + ChangeBillGuID + "'";
                    pObj_Comm.Execute(ps_Sql);


                    //根据文件编号+版本复制一条数据出来,GuID换成新的
                    string GuID=Guid.NewGuid().ToString();
                    ps_Sql="insert into FileData(FileGuID,FileID,FileName,FileType,ProductName,PublishDate,VersionID,WriteDept,ControlType,IsEnable,Remark,CreateGuid,CreateDate)"
                        + " select '"+GuID+"',FileID,FileName,FileType,ProductName,PublishDate,'"+NewVersionID+"',WriteDept,ControlType,IsEnable,'工程更改单创建 '+Remark,CreateGuid,CreateDate  "
                        +" from FileData where FileGuID='"+FileGuID+"'";


                    pObj_Comm.Execute(ps_Sql);


                    //插入明细
                    ps_Sql = "insert into FileDataAttachment(FileDataAttachmentGuid,FileGuID,FileSourceName,FileContent) "
                         +" select newid(),'" + GuID + "',FileSourceName,FileContent "
                         + "  from ChangeBillDataAttachment where ChangeBillGuID='" + ChangeBillGuID + "'";

                    pObj_Comm.Execute(ps_Sql);


                    //将申请单表所有用到文件编号+旧版本的文件Guid全部替换为新的文件编号+新版本号的文件guid
                    ps_Sql = "update FileApplyDetail set FileGuID='" + GuID + "'  where FileGuID='" + FileGuID + "'";

                    pObj_Comm.Execute(ps_Sql);


                    //将入库记录也要换成新的guid
                    ps_Sql = "update FileInStorageDetail set FileGuID='" + GuID + "'  where FileGuID='" + FileGuID + "'";

                    pObj_Comm.Execute(ps_Sql);

                }
                else
                {
                    //不通过
                    ps_Sql = "update ChangeBill  set CheckGuid='',CheckDate=null  where ChangeBillGuID='" + ChangeBillGuID + "'";
                    pObj_Comm.Execute(ps_Sql);
                    
                }

               
               

                pObj_Comm.CommitTrans();
                pObj_Comm.Close();
            }
            catch (Exception e)
            {
                pObj_Comm.RollbackTrans();
                pObj_Comm.Close();
                throw e;
            }
        }



        /// <summary>
        /// 审核时需要先判断新文件编号+新版本号是否已经存在
        /// </summary>
        public bool IsExistChangeBillID(string FileID, string NewVersionID)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);

            ps_Sql = " select  FileGuID from   FileData where FileID='" + FileID + "' and  VersionID='" + NewVersionID + "'";


            try
            {
                DataTable dt = pObj_Comm.ExeForDtl(ps_Sql);
                pObj_Comm.Close();
                if (dt.Rows.Count > 0)
                {
                    return true;// Exist
                }
                else
                {
                    return false; //Not Exist
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
