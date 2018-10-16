using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// �տ
    /// </summary>
    public class IncomeOrder
    {
        #region Model
        private string _IncomeOrderguid;
        private string _IncomeOrderid;
        private DateTime? _IncomeOrderdate;
        private string _clientguid;
        private string _Incomeperson;
        private string _remark;
        private string _createguid;
        private DateTime? _createdate;
        private string _checkguid;
        private DateTime? _checkdate;
        /// <summary>
        /// 
        /// </summary>
        public string IncomeOrderGuid
        {
            set { _IncomeOrderguid = value; }
            get { return _IncomeOrderguid; }
        }
        /// <summary>
        /// �����
        /// </summary>
        public string IncomeOrderID
        {
            set { _IncomeOrderid = value; }
            get { return _IncomeOrderid; }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public DateTime? IncomeOrderDate
        {
            set { _IncomeOrderdate = value; }
            get { return _IncomeOrderdate; }
        }
        /// <summary>
        /// �ͻ�
        /// </summary>
        public string ClientGuid
        {
            set { _clientguid = value; }
            get { return _clientguid; }
        }
        /// <summary>
        /// ������
        /// </summary>
        public string IncomePerson
        {
            set { _Incomeperson = value; }
            get { return _Incomeperson; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        /// <summary>
        /// �Ƶ���
        /// </summary>
        public string CreateGuid
        {
            set { _createguid = value; }
            get { return _createguid; }
        }
        /// <summary>
        /// �Ƶ�ʱ��
        /// </summary>
        public DateTime? CreateDate
        {
            set { _createdate = value; }
            get { return _createdate; }
        }
        /// <summary>
        /// �����
        /// </summary>
        public string CheckGuid
        {
            set { _checkguid = value; }
            get { return _checkguid; }
        }
        /// <summary>
        /// ���ʱ��
        /// </summary>
        public DateTime? CheckDate
        {
            set { _checkdate = value; }
            get { return _checkdate; }
        }
        #endregion Model

    }
}
