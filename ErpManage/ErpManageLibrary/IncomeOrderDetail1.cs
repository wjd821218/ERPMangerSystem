using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 收款单
    /// </summary>
    public class IncomeOrderDetail1
    {
        #region Model
        private string _IncomeOrderguid;
        private string _Incomeid;
        private decimal _Incomemoney;
        private string _cny;
        private string _Incometype;
        private string _remark;
        private int _sortid;
        /// <summary>
        /// 
        /// </summary>
        public string IncomeOrderGuid
        {
            set { _IncomeOrderguid = value; }
            get { return _IncomeOrderguid; }
        }
        /// <summary>
        /// 帐户
        /// </summary>
        public string IncomeID
        {
            set { _Incomeid = value; }
            get { return _Incomeid; }
        }
        /// <summary>
        /// 金额
        /// </summary>
        public decimal IncomeMoney
        {
            set { _Incomemoney = value; }
            get { return _Incomemoney; }
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
        public string IncomeType
        {
            set { _Incometype = value; }
            get { return _Incometype; }
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
