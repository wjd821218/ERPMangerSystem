using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;

namespace ErpManageLibrary
{
    //������־
    public static class SysLog
    {

    
        /// <summary>
        /// �ӿڲ�����־
        /// </summary>
        /// <param name="OperateUser">�û�</param>
        /// <param name="OperateModule">ģ��</param>
        /// <param name="OperateType">����(��,ɾ,��,��)</param>
        /// <param name="OperateContent">��������</param>
        public static void AddOperateLog(string OperateUser, string OperateModule, string OperateType, string OperateContent)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string pSql = "";
                pSql = "insert into   SystemLog(OperateUser,OperateModule,OperateType,OperateContent) ";
                pSql = pSql + " values('" + OperateUser + "','" + OperateModule + "','" + OperateType + "','" + OperateContent + "')";
                pComm.Execute(pSql);
                pComm.Close();

            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }
        } 
    }
}
