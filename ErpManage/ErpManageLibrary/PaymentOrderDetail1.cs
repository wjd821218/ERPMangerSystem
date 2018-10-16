using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 付款单
    /// </summary>
    public class PaymentOrderDetail1
    {
        #region Model
        private string _paymentorderguid;
        private string _payid;
        private decimal _paymoney;
        private string _cny;
        private string _paytype;
        private string _remark;
        private int _sortid;
        /// <summary>
        /// 
        /// </summary>
        public string PaymentOrderGuid
        {
            set { _paymentorderguid = value; }
            get { return _paymentorderguid; }
        }
        /// <summary>
        /// 帐户
        /// </summary>
        public string PayID
        {
            set { _payid = value; }
            get { return _payid; }
        }
        /// <summary>
        /// 金额
        /// </summary>
        public decimal PayMoney
        {
            set { _paymoney = value; }
            get { return _paymoney; }
        }
        /// <summary>
        /// 币种
        /// </summary>
        public string CNY
        {
            set { _cny = value; }
            get { return _cny; }
        }
        /// <summary>
        /// 支付方式
        /// </summary>
        public string PayType
        {
            set { _paytype = value; }
            get { return _paytype; }
        }
        /// <summary>
        /// 摘要
        /// </summary>
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int SortID
        {
            set { _sortid = value; }
            get { return _sortid; }
        }
        #endregion Model

    }
}
