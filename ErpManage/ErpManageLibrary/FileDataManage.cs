using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data.SqlClient;
using System.Data;

namespace ErpManageLibrary
{
    /// <summary>
    /// 文件管理控制类
    /// </summary>
    public class FileDataManage
    {


        ///<summary>
        /// 保存数据
        /// </summary>
        /// <param name="pObj">信息集实体类</param>
        /// <returns>返回保存成功(true)或失败(false)</returns>
        public void SaveFile(FileData FileData, List<FileDataAttachment> FileDataAttachment)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();


              




                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from FileData where  FileGuID='" + FileData.FileGuID + "'";
                pComm.Execute(strDeleteSql);

                //插入主表数据
                string strInsertSql = GetAddSQL(FileData);
                pComm.Execute(strInsertSql);


                //删除明细表
                strDeleteSql = "Delete from FileDataAttachment where  FileGuID='" + FileData.FileGuID + "'";
                pComm.Execute(strDeleteSql);

                //插入明细表数据
                for (int i = 0; i < FileDataAttachment.Count; i++)
                {
                    AddFileDataAttachment(FileDataAttachment[i],pComm);
                }


                /*先查找与当前文件相同文件编号的文件,再以发布日期来判断，如果当前文件比系统中存在的文件发布日期新，
                  则把发布日期旧的自动停用，另外所有用到这个旧文件的地方全部以这个新文件替换*/
                string strSQL = " select FileID  from FileData where FileID='" + FileData.FileID + "' and PublishDate>'" + FileData.PublishDate.ToString()+ "'";
                DataTable dtl = pComm.ExeForDtl(strSQL);
                if (dtl.Rows.Count <= 0)
                { 
                   //执行将相同文件编号并且发布日期为旧的文件全部禁用,并且以新的这个文件替代旧的文件
                     strSQL = " update FileData  set IsEnable=1 where FileID='" + FileData.FileID + "' and PublishDate<'" + FileData.PublishDate.ToString() + "'";
                    pComm.Execute(strSQL);


                   //将所有用到这些禁用文件的地方全部替换为新的文件
                    strSQL = " Update FileInStorageDetail  set FileGuID='" + FileData.FileGuID 
                        + "' where FileGuID in (select FileGuID from FileData where FileID='" + FileData.FileID
                        + "' and PublishDate<'" + FileData.PublishDate.ToString() + "')";
                    pComm.Execute(strSQL);


                    strSQL = " Update FileApplyDetail  set FileGuID='" + FileData.FileGuID
                    + "' where FileGuID in (select FileGuID from FileData where FileID='" + FileData.FileID
                    + "' and PublishDate<'" + FileData.PublishDate.ToString() + "')";
                    pComm.Execute(strSQL);
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
        public void DeleteFileData(string FileGuID)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from FileData where  FileGuID='" + FileGuID + "'";
                pComm.Execute(strDeleteSql);


                //删除明细附件表
                strDeleteSql = "Delete from FileDataAttachment where  FileGuID='" + FileGuID + "'";
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
        public string GetAddSQL(FileData FileData)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into FileData(");
            strSql.Append("FileGuID,FileID,FileName,FileType,ProductName,PublishDate,VersionID,WriteDept,ControlType,IsEnable,Remark,CreateGuid,CreateDate");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + FileData.FileGuID + "',");
            strSql.Append("'" + FileData.FileID + "',");
            strSql.Append("'" + FileData.FileName + "',");
            strSql.Append("'" + FileData.FileType + "',");
            strSql.Append("'" + FileData.ProductName + "',");
            strSql.Append("'" + FileData.PublishDate + "',");
            strSql.Append("'" + FileData.VersionID + "',");
            strSql.Append("'" + FileData.WriteDept + "',");
            strSql.Append("'" + FileData.ControlType + "',");
            strSql.Append("" + FileData.IsEnable + ",");
            strSql.Append("'" + FileData.Remark + "',");
            strSql.Append("'" + FileData.CreateGuid + "',");
            strSql.Append("'" + FileData.CreateDate + "'");
            strSql.Append(")");
            return strSql.ToString();
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void AddFileDataAttachment(FileDataAttachment FileDataAttachment,CommonInterface pcomm)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into FileDataAttachment(");
            strSql.Append("FileDataAttachmentGuid,FileGuID,FileSourceName,FileContent)");
            strSql.Append(" values (");
            strSql.Append("@FileDataAttachmentGuid,@FileGuID,@FileSourceName,@FileContent)");
            
            SqlParameter[] parameters = {
					new SqlParameter("@FileDataAttachmentGuid", SqlDbType.NVarChar,50),
					new SqlParameter("@FileGuID", SqlDbType.NVarChar,50),
					new SqlParameter("@FileSourceName", SqlDbType.NVarChar,100),
					new SqlParameter("@FileContent", SqlDbType.Image)};
            parameters[0].Value = FileDataAttachment.FileDataAttachmentGuid;
            parameters[1].Value = FileDataAttachment.FileGuID;
            parameters[2].Value = FileDataAttachment.FileSourceName;
            parameters[3].Value = FileDataAttachment.FileContent;

            pcomm.ExecuteNonQueryBySqlParameters(strSql.ToString(), parameters);

        }


      

        //public void SavePic(byte[]  byteobj,string personid)
        //{
        //    CommonInterface pComm=CommonFactory.CreateInstance(CommonData.sql);

        //    try
        //    {
        //        string strsql="";
        //        //图片放入数据库中间
        //        if (byteobj!=null)
        //        {
        //            strsql="Update LGBPInfo set A9901=@Fimage where PersonInfoID='"+personid+"'";
        //        }
        //        else
        //        {
        //            strsql="Update LGBPInfo set A9901=null where PersonInfoID='"+personid+"'";

        //        }
        //        SqlCommand  mCommand=new SqlCommand();
        //        mCommand=(SqlCommand)pComm.GetCommand();

        //        mCommand.CommandText=strsql;
        //        mCommand.Parameters.Clear();

        //        if (byteobj!=null)
        //        {
        //            mCommand.Parameters.Add("@Fimage",System.Data.SqlDbType.Image);
        //            mCommand.Parameters["@Fimage"].Value=byteobj;
        //        }

        //        mCommand.ExecuteNonQuery();

        //        pComm.Close();

        //    }
        //    catch(Exception e)
        //    {
        //        pComm.Close();
        //        throw e;
		
        //    }
		
        //}

             
        
   /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public DataTable GetFileDataAttachment(string FileGuID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  *  from FileDataAttachment  ");
            strSql.Append(" where FileGuID='" + FileGuID + "' ");

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);

            DataTable dtl = pComm.ExeForDtl(strSql.ToString());

            return dtl;
        }



        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public DataTable GetFileDataAttachmentByAttachmentGuid(string FileDataAttachmentGuid)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  *  from FileDataAttachment  ");
            strSql.Append(" where FileDataAttachmentGuid='" + FileDataAttachmentGuid + "' ");

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);

            DataTable dtl = pComm.ExeForDtl(strSql.ToString());

            return dtl;
        }





        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public FileData GetFileData(string FileGuID)
        {
            FileData FileData = new FileData();
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  ");
            strSql.Append("FileGuID,FileID,FileName,FileType,ProductName,PublishDate,VersionID,WriteDept,ControlType,IsEnable,Remark,CreateGuid,CreateDate ");
            strSql.Append(" from FileData ");
            strSql.Append(" where FileGuID='" + FileGuID + "' ");

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            DataSet ds = pComm.ExeForDst(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                FileData.FileGuID = ds.Tables[0].Rows[0]["FileGuID"].ToString();
                FileData.FileID = ds.Tables[0].Rows[0]["FileID"].ToString();
                FileData.FileName = ds.Tables[0].Rows[0]["FileName"].ToString();
                FileData.FileType = ds.Tables[0].Rows[0]["FileType"].ToString();
                FileData.ProductName = ds.Tables[0].Rows[0]["ProductName"].ToString();
                if (ds.Tables[0].Rows[0]["PublishDate"].ToString() != "")
                {
                    FileData.PublishDate = DateTime.Parse(ds.Tables[0].Rows[0]["PublishDate"].ToString());
                }
                FileData.VersionID = ds.Tables[0].Rows[0]["VersionID"].ToString();
                FileData.IsEnable = int.Parse(ds.Tables[0].Rows[0]["IsEnable"].ToString());
                FileData.WriteDept = ds.Tables[0].Rows[0]["WriteDept"].ToString();
                FileData.ControlType = ds.Tables[0].Rows[0]["ControlType"].ToString();
                FileData.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                FileData.CreateGuid = ds.Tables[0].Rows[0]["CreateGuid"].ToString();
                if (ds.Tables[0].Rows[0]["CreateDate"].ToString() != "")
                {
                    FileData.CreateDate = DateTime.Parse(ds.Tables[0].Rows[0]["CreateDate"].ToString());
                }
            }

            return FileData;
        }

        /// <summary>
        /// 是否已经存在相同的货品
        /// </summary>
        /// <returns></returns>
        public bool IsExistFile(string FileGuid, string FileID, bool IsEdit)
        {
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            string strSql = "";
            if (IsEdit == false)
            {
                //ADD
                strSql = " select FileGuid  from FileData where FileID='" + FileID + "'";

            }
            else
            {
                //Edit
                strSql = " select FileGuid  from FileData where FileID='" + FileID + "'";

            }

            try
            {
                DataTable dt = pObj_Comm.ExeForDtl(strSql);
                pObj_Comm.Close();
                if (dt.Rows.Count > 0)
                {
                    if (IsEdit == false)
                    {
                        return true;  //Exist
                    }
                    else
                    {
                        string strFileGuid = dt.Rows[0]["FileGuid"].ToString();
                        if (strFileGuid.Trim() != FileGuid.Trim())
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
        /// 是否已经存在相同的货品
        /// </summary>
        /// <returns></returns>
        public bool IsExistFile(string FileGuid, string FileID,string VersionID, bool IsEdit)
        {
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            string strSql = "";
            if (IsEdit == false)
            {
                //ADD
                strSql = " select FileGuid  from FileData where FileID='" + FileID + "' and VersionID='"+VersionID+"'";

            }
            else
            {
                //Edit
                strSql = " select FileGuid  from FileData where FileID='" + FileID + "' and VersionID='" + VersionID + "'";

            }

            try
            {
                DataTable dt = pObj_Comm.ExeForDtl(strSql);
                pObj_Comm.Close();
                if (dt.Rows.Count > 0)
                {
                    if (IsEdit == false)
                    {
                        return true;  //Exist
                    }
                    else
                    {
                        string strFileGuid = dt.Rows[0]["FileGuid"].ToString();
                        if (strFileGuid.Trim() != FileGuid.Trim())
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
        /// 得到所有文件类另信息---包括了此文件是否入库的标识
        /// </summary>
        /// <returns>pDTMain 字段信息集</returns>
        public DataTable GetFileDataBySQL2(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "  select 'False' as selectvalue,FileGuID ,FileID as 文件编号,FileName as 文件名称,ProductName as 产品名称, "
                       + " (select UnitName from BasicData where UnitID=ControlType ) as 受控类别,"
                       + " PublishDate as 发布日期,VersionID as 版本号, "
                       + " (select InterName from FileClass where    InterId=FileType) as 文件类别,"
                       + " (select DeptName from Dept where DeptGuid=WriteDept ) as 编写部门,"
                       + "case when IsEnable=1 then '停用' else  '正常' end  as 状态,"
                       +" case when (select count(*)  from V_FileInStorageDetail  where CheckGuid2<>'' and  FileGuID=FileData.FileGuID)>=1 "
                       +" then '已入库'  else '未入库'  end as IsStorage ,"
                       + " Remark as 备注  from FileData " + strsql + "  order by FileID";

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
        /// 得到所有文件类另信息---只加载已入库的文件
        /// </summary>
        /// <returns>pDTMain 字段信息集</returns>
        public DataTable GetFileDataBySQL_InStorage(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "  select 'False' as selectvalue,FileGuID ,FileID as 文件编号,FileName as 文件名称,ProductName as 产品名称, "
                       + " (select UnitName from BasicData where UnitID=ControlType ) as 受控类别,"
                       + " PublishDate as 发布日期,VersionID as 版本号, "
                       + " (select InterName from FileClass where    InterId=FileType) as 文件类别,"
                       + " (select DeptName from Dept where DeptGuid=WriteDept ) as 编写部门,"
                       + "case when IsEnable=1 then '停用' else  '正常' end  as 状态,"
                       + " case when (select count(*)  from V_FileInStorageDetail  where CheckGuid2<>'' and  FileGuID=FileData.FileGuID)>=1 "
                       + " then '已入库'  else '未入库'  end as IsStorage ,"
                       + " Remark as 备注  from FileData where  FileGuID in  (select FileGuID  from V_FileInStorageDetail  where CheckGuid2<>'')   " + strsql + "  order by FileID";

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
        public DataTable GetFileDataBySQL(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "  select 'False' as selectvalue,FileGuID ,FileID as 文件编号,FileName as 文件名称,ProductName as 产品名称, "
                       + " (select UnitName from BasicData where UnitID=ControlType ) as 受控类别," 
                       + " PublishDate as 发布日期,VersionID as 版本号, "
                       + " (select InterName from FileClass where    InterId=FileType) as 文件类别,"
                       + " (select DeptName from Dept where DeptGuid=WriteDept ) as 编写部门,"            
                       + "case when IsEnable=1 then '停用' else  '正常' end  as 状态,"
                       + " case when (select count(*)  from V_FileInStorageDetail  where CheckGuid2<>'' and  FileGuID=FileData.FileGuID)>=1 "
                       + " then '已入库'  else '未入库'  end as 是否入库 ,"
                        + " (select top 1  FileInStorageDate   from V_FileInStorageDetail  where CheckGuid2<>'' and  FileGuID=FileData.FileGuID) as 入库日期, "
                      
                       + " Remark as 备注,CreateGuid,CreateDate,(select UserName from LoginUser where UserID=CreateGuid) as CreateName  from FileData " + strsql + "  order by FileID";

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
        public DataTable GetFileDataByFileGuID(string FileGuID)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select FileGuID ,FileID ,FileName,ProductName, "
                       + " (select UnitName from BasicData where UnitID=ControlType ) as ControlTypeName,ControlType,"
                       + " PublishDate,VersionID, "
                       + " (select InterName from FileClass where    InterId=FileType) as FileTypeName,FileType,"
                       + " (select DeptName from Dept where DeptGuid=WriteDept ) as WriteDeptName,WriteDept,"
                       + " IsEnable,"
                       + " Remark ,CreateGuid,CreateDate,(select UserName from LoginUser where UserID=CreateGuid) as CreateName   from FileData where FileGuID='" + FileGuID + "'  order by FileID";

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
        /// 得到所有产品信息，返回英文字段
        /// </summary>
        /// <returns>pDTMain 字段信息集</returns>
        public DataTable GetFileDataBySQL_en(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select FileGuID ,FileID ,FileName,ProductName, "
                       + " (select UnitName from BasicData where UnitID=ControlType ) as ControlTypeName,ControlType,"
                       + " PublishDate,VersionID, "
                       + " (select InterName2 from tempFileType where    InterId=FileType) as FileTypeName,FileType,"
                       + " (select DeptName from Dept where DeptGuid=WriteDept ) as WriteDeptName,WriteDept,"
                       + " IsEnable,"
                       + " Remark ,CreateGuid,CreateDate,(select UserName from LoginUser where UserID=CreateGuid) as CreateName   from FileData  "+strsql +"  order by FileID";

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
        /// 得到所有产品信息，返回英文字段
        /// </summary>
        /// <returns>pDTMain 字段信息集</returns>
        public DataTable GetFileFFCountBySQL(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select * from V_FileApply_ApplyPerson  " + strsql + "  order by  FileID ";
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
        /// 得到文件类别名称
        /// </summary>
        /// <param name="FileTypeID"></param>
        /// <returns></returns>
        public string GetFileTypeName(string FileTypeID)
        {

            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select InterName from FileClass where    InterId='" + FileTypeID + "'";

                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

                pObj_Comm.Close();

                return pDTMain.Rows[0]["InterName"].ToString(); ;
            }
            catch (Exception e)
            {
                pObj_Comm.Close();
                throw e;
            }
        }

        /// <summary>
        /// 得到文件创建人名称
        /// </summary>
        /// <param name="FileTypeID"></param>
        /// <returns></returns>
        public string GetFileCreateName(string FileGuID)
        {

            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select CreateGuid from FileData where    FileGuID='" + FileGuID + "'";

                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

                pObj_Comm.Close();

                return pDTMain.Rows[0]["CreateGuid"].ToString(); ;
            }
            catch (Exception e)
            {
                pObj_Comm.Close();
                throw e;
            }
        }

        /// <summary>
        /// 得到文件大小
        /// </summary>
        /// <param name="FileGuID"></param>
        /// <param name="FileSourceName"></param>
        /// <returns></returns>
        public int GetFileLength(string FileGuID,string FileSourceName)
        {

            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {

                ps_Sql = "select   datalength(filecontent)   as   filelength   from  FileDataAttachment where  FileGuID='" + FileGuID + "' and FileSourceName='" + FileSourceName + "'";

                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

                pObj_Comm.Close();

                if (pDTMain.Rows.Count > 0)
                {
                    return int.Parse(pDTMain.Rows[0]["filelength"].ToString());
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                pObj_Comm.Close();
                throw e;
            }
        }


        /// <summary>
        /// 新增文件附件修改记录
        /// </summary>
        /// <param name="FileGuID"></param>
        /// <param name="FileSourceName"></param>
        /// <param name="ChangeUser"></param>
        public void AddFileChangeRecord(string FileGuID,string FileSourceName,string ChangeUser)
        {
            string ps_Sql = "";
           
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {

                ps_Sql = "insert into FileChangeRecord(FileGuID,FileSourceName,ChangeUser) values('" + FileGuID + "','" + FileSourceName + "','" + ChangeUser + "')";

               pObj_Comm.Execute(ps_Sql);

              
            }
            catch (Exception e)
            {
                pObj_Comm.Close();
                throw e;
            }
        
        
        }

        /// <summary>
        /// 得到某个文件的附件修改记录
        /// </summary>
        /// <param name="FileGuID"></param>
        /// <returns></returns>
        public DataTable GetFileChangeRecord(string FileGuID)
        {

            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {

                ps_Sql = "select  *   from  FileChangeRecord where  FileGuID='" + FileGuID + "' order by ChangeDate Desc";

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

        //显示本人所能查看的文件
        public DataTable sp_GetFileDataView(string LoginUserID, string LoginUserName, string strsql, string IsRight)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[4, 2];
                par[0, 0] = "@LoginUserID";
                par[0, 1] = LoginUserID;
                par[1, 0] = "@LoginUserName";
                par[1, 1] = LoginUserName;
                par[2, 0] = "@strWhereSQL";
                par[2, 1] = strsql;
                par[3, 0] = "@IsRight";
                par[3, 1] = IsRight;
                dset = pComm.ExcuteSp("sp_GetFileDataView", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }

        //判断文件是否被使用(文件入库、文件申请、工程更改单)
        public bool IsFileUse(string FileGuID)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@FileGuID";
                par[0, 1] = FileGuID;
                dset = pComm.ExcuteSp("sp_FileIsUse", par);

                pComm.Close();
                if (dset.Tables[0].Rows.Count > 0)
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
                pComm.Close();
                throw e;

            }
          
        }

        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="FileTypeID"></param>
        /// <returns></returns>
        public void DeleteFile(string FileGuID)
        {

            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            pObj_Comm.BeginTrans();
            try
            {
                ps_Sql = " delete from  FileData  where    FileGuID='" + FileGuID + "'";

                pObj_Comm.Execute(ps_Sql);


                ps_Sql = " delete from  FileDataAttachment  where    FileGuID='" + FileGuID + "'";

                pObj_Comm.Execute(ps_Sql);


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
        /// 得到当前类别下面的所有子类别
        /// </summary>
        /// <param name="FileType"></param>
        /// <returns></returns>
        public DataTable GetSubFileType(string FileType)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@FileType";
                par[0, 1] = FileType;
                dset = pComm.ExcuteSp("sp_GetSubFileType", par);

                pComm.Close();

                return dset.Tables[0];

            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }
        }

        /// <summary>
        /// 将子类别全部置为一级类别名称
        /// </summary>
        /// <param name="FileType"></param>
        /// <returns></returns>
        public void GetSubFileType2(string FileType)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                //DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@FileType";
                par[0, 1] = FileType;
                pComm.ExcuteSp("sp_GetSubFileType2", par);

                pComm.Close();

               // return dset.Tables[0];

            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }
        }

    }
}
