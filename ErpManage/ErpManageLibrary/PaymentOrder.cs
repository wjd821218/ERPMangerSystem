using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 付款单
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
        /// 付款单号
        /// </summary>
        public string PaymentOrderID
        {
            set { _paymentorderid = value; }
            get { return _paymentorderid; }
        }
        /// <summary>
        /// 开单日期
        /// </summary>
        public DateTime? PaymentOrderDate
        {
            set { _paymentorderdate = value; }
            get { return _paymentorderdate; }
        }
        /// <summary>
        /// 供应商
        /// </summary>
        public string SupplierGuid
        {
            set { _supplierguid = value; }
            get { return _supplierguid; }
        }
        /// <summary>
        /// 付款人
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
        /// 开户行
        /// </summary>
        public string BankID
        {
            set { _bankid = value; }
            get { return _bankid; }
        }

        /// <summary>
        /// 付款帐号
        /// </summary>
        public string PayID
        {
            set { _payid = value; }
            get { return _payid; }
        }
        /// <summary>
        /// 制单人
        /// </summary>
        public string CreateGuid
        {
            set { _createguid = value; }
            get { return _createguid; }
        }
        /// <summary>
        /// 制单时间
        /// </summary>
        public DateTime? CreateDate
        {
            set { _createdate = value; }
            get { return _createdate; }
        }
        /// <summary>
        /// 审核人
        /// </summary>
        public string CheckGuid
        {
            set { _checkguid = value; }
            get { return _checkguid; }
        }
        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime? CheckDate
        {
            set { _checkdate = value; }
            get { return _checkdate; }
        }

        /// <summary>
        /// 2审核人
        /// </summary>
        public string CheckGuid2
        {
            set { _checkguid2 = value; }
            get { return _checkguid2; }
        }
        /// <summary>
        /// 2审核时间
        /// </summary>
        public DateTime? CheckDate2
        {
            set { _checkdate2 = value; }
            get { return _checkdate2; }
        }
        #endregion Model

    }
}
