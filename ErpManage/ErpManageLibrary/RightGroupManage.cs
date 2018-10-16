using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using Daniel.Liu.DAO;
using System.Data;

namespace ErpManageLibrary
{
    /// <summary>
    /// 权限组管理
    /// </summary>
    public class RightGroupManage
    {



        ///<summary>
        /// 输入条件返回结果查询
        /// </summary>
        /// <param name="tableid">SQL查询条件</param>
        /// <returns>存放查询结果的DataTable</returns>
        public DataTable GetRightGroupInfo()
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataTable dtl = new DataTable();
                string StrSQL = " select  *   from  RightGroup order by GroupName ";

                dtl = pComm.ExeForDtl(StrSQL);
                pComm.Close();
                return dtl;
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }
        }


        ///<summary>
        /// 保存用户属于那个权限组
        /// </summary>
        /// <param name="tableid">SQL查询条件</param>
        /// <returns>存放查询结果的DataTable</returns>
        public void SaveUserRightGroup(List<string> lstUser,List<string> lstgroup)
        {
            string StrSQL = "";
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                for (int i = 0; i < lstUser.Count; i++)
                {
                    //先删除此用户原来属于的权限组
                    StrSQL = "delete from UserRightGroup where UserID='" + lstUser[i]+ "'";
                    pComm.Execute(StrSQL);


                    //再添加此用户的权限组
                    for (int j = 0; j < lstgroup.Count; j++)
                    {

                        StrSQL = " insert into UserRightGroup(UserID,GroupID) values('" + lstUser[i] + "','" + lstgroup [j]+ "')";
                        pComm.Execute(StrSQL);
                    }


                }

                pComm.CommitTrans();
                pComm.Close();
              
            }
            catch (Exception e)
            {
                pComm.RollbackTrans();
                pComm.Close();
                throw e;

            }
        }


        /// <summary>
        /// 权限组维护
        /// </summary>
        /// <param name="groupname"></param>
        public void AddGroup(string groupname)
        { 
          string StrSQL = "";
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                StrSQL = " insert into RightGroup(groupname) values('"+groupname +"')";
                pComm.Execute(StrSQL); 


                pComm.Close();
            }
            catch (Exception e)
            {
               
                pComm.Close();
                throw e;

            }
        
        
        }

        /// <summary>
        /// 得到用户所在的权限组
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public DataTable GetUserGroup(string userid)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataTable dtl = new DataTable();
                string StrSQL = " select   GroupID   from  UserRightGroup where userid='" + userid + "'";

                dtl = pComm.ExeForDtl(StrSQL);
                pComm.Close();
                return dtl;
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }
        
        
        }


        /// <summary>
        ///得到组所具有的模块功能数据
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public DataTable GetGroupRightSet(string groupid)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataTable dtl = new DataTable();
                string StrSQL = " select   *   from  GroupRightSet where GroupID='" + groupid + "'";

                dtl = pComm.ExeForDtl(StrSQL);
                pComm.Close();
                return dtl;
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }


        }




        ///<summary>
        /// 保存组的功能模块权限
        /// </summary>
        /// <param name="tableid">SQL查询条件</param>
        /// <returns>存放查询结果的DataTable</returns>
        public void SaveGroupFunctionRight(List<string > lstGroup,List<GroupRightSet> lstFunctionRight)
        {
            string StrSQL = "";
            GroupRightSet GroupRightSet = new GroupRightSet();
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                for (int i = 0; i < lstGroup.Count; i++)
                {
                    //先删除此组原来属于的功能权限
                    StrSQL = "delete from GroupRightSet where GroupID='" + lstGroup[i] + "'";
                    pComm.Execute(StrSQL);


                    //再添加此组属于的功能权限
                    for (int j = 0; j < lstFunctionRight.Count; j++)
                    {
                        GroupRightSet = lstFunctionRight[j] as GroupRightSet;
                        StrSQL = " insert into GroupRightSet(GroupID,ModuleID,FunctionID,FunctionRight) values('"
                            + lstGroup[i] + "','" + GroupRightSet.ModuleID + "','" + GroupRightSet.FunctionID + "'," + GroupRightSet.FunctionRight.ToString()+ ")";
                        pComm.Execute(StrSQL);
                    }


                }

                pComm.CommitTrans();
                pComm.Close();

            }
            catch (Exception e)
            {
                pComm.RollbackTrans();
                pComm.Close();
                throw e;

            }
        }



        /// <summary>
        /// 得到某用户是否有操作权限
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="moduleid"></param>
        /// <param name="functionid"></param>
        /// <returns></returns>
        public bool IsOperateRightByUserID(string userid,string moduleid,string functionid)
        {
            bool IsRight = false;
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                //得到用户属于那个权限组
                DataTable dtl = new DataTable();
                DataTable dtl2 = new DataTable();
                string StrSQL = " select  GroupID  from UserRightGroup  where userid='" + userid + "'";
                dtl = pComm.ExeForDtl(StrSQL);


                //判断此用户所在的这个权限组有什么有操作此模块相应功能的权限:  
                //     功能: Save:保存  Edit:修改  delete:删除  Qry:查询 Check: 审核  UnCheck:反审  Print:打印    
                for (int i = 0; i < dtl.Rows.Count; i++)
                {
                    StrSQL = " select  FunctionRight  from GroupRightSet  where GroupID='"
                        + dtl.Rows[i]["GroupID"].ToString() + "' and ModuleID='" + moduleid + "' and FunctionID='" + functionid + "'";
                    dtl2 = pComm.ExeForDtl(StrSQL);

                    if (dtl2.Rows.Count > 0)
                    {
                        if (dtl2.Rows[i]["FunctionRight"].ToString() == "1")
                        {
                            IsRight = true;
                            break;
                        }
                    
                    }
                
                }




                pComm.Close();
                return IsRight;
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }


        }

        
    }
}
