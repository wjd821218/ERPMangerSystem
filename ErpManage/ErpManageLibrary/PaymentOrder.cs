using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// ���
    /// </summary>
    public class PaymentOrder
    {
        #region Model
        private string _paymentorderguid;
        private string _paymentorderid;
        private DateTime? _paymentorderdate;
        private string _supplierguid;
        private string _payperson;
        private string _bankid;
        private string _payid;
        private string _remark;
        private string _createguid;
        private DateTime? _createdate;
        private string _checkguid;
        private DateTime? _checkdate;
        private string _checkguid2;
        private DateTime? _checkdate2;
        /// <summary>
        /// 
        /// </summary>
        public string PaymentOrderGuid
        {
            set { _paymentorderguid = value; }
            get { return _paymentorderguid; }
        }
        /// <summary>
        /// �����
        /// </summary>
        public string PaymentOrderID
        {
            set { _paymentorderid = value; }
            get { return _paymentorderid; }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public DateTime? PaymentOrderDate
        {
            set { _paymentorderdate = value; }
            get { return _paymentorderdate; }
        }
        /// <summary>
        /// ��Ӧ��
        /// </summary>
        public string SupplierGuid
        {
            set { _supplierguid = value; }
            get { return _supplierguid; }
        }
        /// <summary>
        /// ������
        /// </summary>
        public string PayPerson
        {
            set { _payperson = value; }
            get { return _payperson; }
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
        /// ������
        /// </summary>
        public string BankID
        {
            set { _bankid = value; }
            get { return _bankid; }
        }

        /// <summary>
        /// �����ʺ�
        /// </summary>
        public string PayID
        {
            set { _payid = value; }
            get { return _payid; }
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

        /// <summary>
        /// 2�����
        /// </summary>
        public string CheckGuid2
        {
            set { _checkguid2 = value; }
            get { return _checkguid2; }
        }
        /// <summary>
        /// 2���ʱ��
        /// </summary>
        public DateTime? CheckDate2
        {
            set { _checkdate2 = value; }
            get { return _checkdate2; }
        }
        #endregion Model

    }
}
