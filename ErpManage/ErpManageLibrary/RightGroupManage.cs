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
    /// Ȩ�������
    /// </summary>
    public class RightGroupManage
    {



        ///<summary>
        /// �����������ؽ����ѯ
        /// </summary>
        /// <param name="tableid">SQL��ѯ����</param>
        /// <returns>��Ų�ѯ�����DataTable</returns>
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
        /// �����û������Ǹ�Ȩ����
        /// </summary>
        /// <param name="tableid">SQL��ѯ����</param>
        /// <returns>��Ų�ѯ�����DataTable</returns>
        public void SaveUserRightGroup(List<string> lstUser,List<string> lstgroup)
        {
            string StrSQL = "";
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                for (int i = 0; i < lstUser.Count; i++)
                {
                    //��ɾ�����û�ԭ�����ڵ�Ȩ����
                    StrSQL = "delete from UserRightGroup where UserID='" + lstUser[i]+ "'";
                    pComm.Execute(StrSQL);


                    //����Ӵ��û���Ȩ����
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
        /// Ȩ����ά��
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
        /// �õ��û����ڵ�Ȩ����
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
        ///�õ��������е�ģ�鹦������
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
        /// ������Ĺ���ģ��Ȩ��
        /// </summary>
        /// <param name="tableid">SQL��ѯ����</param>
        /// <returns>��Ų�ѯ�����DataTable</returns>
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
                    //��ɾ������ԭ�����ڵĹ���Ȩ��
                    StrSQL = "delete from GroupRightSet where GroupID='" + lstGroup[i] + "'";
                    pComm.Execute(StrSQL);


                    //����Ӵ������ڵĹ���Ȩ��
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
        /// �õ�ĳ�û��Ƿ��в���Ȩ��
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
                //�õ��û������Ǹ�Ȩ����
                DataTable dtl = new DataTable();
                DataTable dtl2 = new DataTable();
                string StrSQL = " select  GroupID  from UserRightGroup  where userid='" + userid + "'";
                dtl = pComm.ExeForDtl(StrSQL);


                //�жϴ��û����ڵ����Ȩ������ʲô�в�����ģ����Ӧ���ܵ�Ȩ��:  
                //     ����: Save:����  Edit:�޸�  delete:ɾ��  Qry:��ѯ Check: ���  UnCheck:����  Print:��ӡ    
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
