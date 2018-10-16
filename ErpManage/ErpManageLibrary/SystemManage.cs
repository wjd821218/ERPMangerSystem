using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;

namespace ErpManageLibrary
{
    /// <summary>
    /// ϵͳ����
    /// </summary>
    public class SystemManage
    {

        //ϵͳ���ݿⱸ��-���ô洢����
        public void sp_BackupDatabase(string strPath,string strFileName)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string[,] par;
                par = new string[2, 2];
                par[0, 0] = "@strBackupPath";
                par[0, 1] = strPath;
                par[1, 0] = "@strFileName";
                par[1, 1] = strFileName;
                pComm.ExcuteSp("sp_BackupDatabase", par);

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
