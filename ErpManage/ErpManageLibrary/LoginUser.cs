using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;
namespace ErpManageLibrary
{
    /// <summary>
    /// ��½����ʵ����
    /// </summary>
    public class LoginUser
    {
        public LoginUser()
        { }
        #region Model
        private string _userid;
        private string _username;
        private string _email;
        private string _password;
        private int _isenable;
        /// <summary>
        /// 
        /// </summary>
        public string USERID
        {
            set { _userid = value; }
            get { return _userid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string USERNAME
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string EMAIL
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PASSWORD
        {
            set { _password = value; }
            get { return _password; }
        }

        /// <summary>
        /// �Ƿ�ͣ�ã� 1-ͣ�� 0-����
        /// </summary>
        public int IsEnable
        {
            set { _isenable = value; }
            get { return _isenable; }
        }


        #endregion Model


        #region  ��Ա����


        /// <summary>
        /// ����һ������
        /// </summary>
        public bool Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into LOGINUSER(");
            strSql.Append("USERID,USERNAME,EMAIL,PASSWORD,IsEnable");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + USERID + "',");
            strSql.Append("'" + USERNAME + "',");
            strSql.Append("'" + EMAIL + "',");
            strSql.Append("'" + PASSWORD + "',");
            strSql.Append("" + IsEnable.ToString() + "");
            strSql.Append(")");
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);

            try
            {
                pComm.Execute(strSql.ToString());//ִ��Sql����޷���ֵ
                pComm.Close();
                return true;
            }
            catch (System.Exception e)
            {
                pComm.Close();
                throw e;
            }
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public bool Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update LOGINUSER set ");
            strSql.Append("USERNAME='" + USERNAME + "',");
            strSql.Append("EMAIL='" + EMAIL + "',");
            strSql.Append("PASSWORD='" + PASSWORD + "',");
            strSql.Append("IsEnable=" + IsEnable.ToString() + "");
            strSql.Append(" where USERID='" + USERID + "' ");
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);

            try
            {
                pComm.Execute(strSql.ToString());//ִ��Sql����޷���ֵ
                pComm.Close();
                return true;
            }
            catch (System.Exception e)
            {
                pComm.Close();
                throw e;
            }
        }
        #endregion  ��Ա����
    }
}
