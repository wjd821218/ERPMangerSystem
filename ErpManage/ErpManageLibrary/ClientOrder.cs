using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    public class ClientOrder
    {

        public ClientOrder()
        { }
        #region Model
        private string _clientorderguid;
        private string _clientorderid;
        private DateTime _clientorderdate;
        private DateTime _encasementdate;
        private string _contractid;
        private string _checkbatchid;
        private string _downdept;
        private string _receivedept;
        private string _remark;
        private string _createguid;
        private DateTime _createdate;
        private string _checkguid;
        private DateTime _checkdate;
        private string _endguid;
        private DateTime _enddate;
        private string _checkguid2;
        private DateTime _checkdate2;
        private string _ordertype;
        /// <summary>
        /// �ͻ�����Ψһ��
        /// </summary>
        public string ClientOrderGuid
        {
            set { _clientorderguid = value; }
            get { return _clientorderguid; }
        }
        /// <summary>
        /// �ͻ�������
        /// </summary>
        public string ClientOrderID
        {
            set { _clientorderid = value; }
            get { return _clientorderid; }
        }
        /// <summary>
        /// �µ�����
        /// </summary>
        public DateTime ClientOrderDate
        {
            set { _clientorderdate = value; }
            get { return _clientorderdate; }
        }
        /// <summary>
        /// װ������
        /// </summary>
        public DateTime EncasementDate
        {
            set { _encasementdate = value; }
            get { return _encasementdate; }
        }
        /// <summary>
        /// ��ͬ��
        /// </summary>
        public string ContractID
        {
            set { _contractid = value; }
            get { return _contractid; }
        }
        /// <summary>
        /// �̼�����
        /// </summary>
        public string CheckBatchID
        {
            set { _checkbatchid = value; }
            get { return _checkbatchid; }
        }
        /// <summary>
        /// �µ�����
        /// </summary>
        public string DownDept
        {
            set { _downdept = value; }
            get { return _downdept; }
        }
        /// <summary>
        /// �յ�����
        /// </summary>
        public string ReceiveDept
        {
            set { _receivedept = value; }
            get { return _receivedept; }
        }
        /// <summary>
        /// ��ע
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
        public DateTime CreateDate
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
        public DateTime CheckDate
        {
            set { _checkdate = value; }
            get { return _checkdate; }
        }
        /// <summary>
        /// �ᵥ��
        /// </summary>
        public string EndGuid
        {
            set { _endguid = value; }
            get { return _endguid; }
        }
        /// <summary>
        /// �ᵥʱ��
        /// </summary>
        public DateTime EndDate
        {
            set { _enddate = value; }
            get { return _enddate; }
        }
        /// <summary>
        /// ���������
        /// </summary>
        public string CheckGuid2
        {
            set { _checkguid2 = value; }
            get { return _checkguid2; }
        }
        /// <summary>
        /// �����������
        /// </summary>
        public DateTime CheckDate2
        {
            set { _checkdate2 = value; }
            get { return _checkdate2; }
        }

        /// <summary>
        /// ��������ڲ��������ͻ�����
        /// </summary>
        public string OrderType
        {
            set { _ordertype = value; }
            get { return _ordertype; }
        }
        #endregion Model

       

    }
}
