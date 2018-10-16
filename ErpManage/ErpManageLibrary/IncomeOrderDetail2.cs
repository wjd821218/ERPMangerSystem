using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 付款单
    /// </summary>
    public class IncomeOrderDetail2
    {
        #region Model
        private string _IncomeOrderguid;
        private string _SellOrderid;
        private DateTime? _SellOrderdate;
        private decimal _SellOrdermoney;
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
        /// 销售出库单号
        /// </summary>
        public string SellOrderID
        {
            set { _SellOrderid = value; }
            get { return _SellOrderid; }
        }
        /// <summary>
        /// 开单日期
        /// </summary>
        public DateTime? SellOrderDate
        {
            set { _SellOrderdate = value; }
            get { return _SellOrderdate; }
        }
        /// <summary>
        /// 金额
        /// </summary>
        public decimal SellOrderMoney
        {
            set { _SellOrdermoney = value; }
            get { return _SellOrdermoney; }
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
