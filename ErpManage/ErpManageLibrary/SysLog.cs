using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;

namespace ErpManageLibrary
{
    //操作日志
    public static class SysLog
    {

    
        /// <summary>
        /// 接口操作日志
        /// </summary>
        /// <param name="OperateUser">用户</param>
        /// <param name="OperateModule">模块</param>
        /// <param name="OperateType">类型(增,删,改,查)</param>
        /// <param name="OperateContent">操作内容</param>
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
