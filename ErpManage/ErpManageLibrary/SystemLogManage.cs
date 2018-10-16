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
    /// 系统操作日志管理
    /// </summary>
    public class SystemLogManage
    {


        ///<summary>
        /// 输入条件返回结果查询
        /// </summary>
        /// <param name="tableid">SQL查询条件</param>
        /// <returns>存放查询结果的DataTable</returns>
        public DataTable GetSystemLogInfo(string strsql)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataTable dtl = new DataTable();
               // string StrSQL = " select NoID, OperateUser as 操作员,OperateModule as 操作模块,OperateType as 操作类型,OperateContent as 操作内容,OperateDate as 操作日期   from  SystemLog order by OperateDate desc ";
                string StrSQL = " select 'False' as selectvalue,NoID, OperateUser,OperateModule ,OperateType ,OperateContent,convert(nvarchar(30),OperateDate,120) as  OperateDate   from  SystemLog " + strsql + " order by OperateDate desc ";

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
        /// 输入条件返回结果查询
        /// </summary>
        /// <param name="tableid">SQL查询条件</param>
        /// <returns>存放查询结果的DataTable</returns>
        public void DeleteSyslog(List<string> lst)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();
                string StrSQL = "";
                for (int i = 0; i < lst.Count; i++)
                {
                   StrSQL = " delete   from  SystemLog where NoID='"+lst[i]+"'";
                   pComm.Execute(StrSQL);
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

    }
}
