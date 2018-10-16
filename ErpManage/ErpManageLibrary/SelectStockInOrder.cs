using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 付款单从采购入库单中选择
    /// </summary>
    public class SelectStockInOrder
    {
        #region Model
        private string _stockinorderid;
        private DateTime? _stockinorderdate;
        private decimal _materialsum;
        private decimal _totalmoney;
      
        /// <summary>
        /// 
        /// </summary>
        public string StockInOrderID
        {
            set { _stockinorderid = value; }
            get { return _stockinorderid; }
        }
     
        /// <summary>
        /// 
        /// </summary>
        public DateTime? StockInOrderDate
        {
            set { _stockinorderdate = value; }
            get { return _stockinorderdate; }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal MaterialSum
        {
            set { _materialsum = value; }
            get { return _materialsum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal TotalMoney
        {
            set { _totalmoney = value; }
            get { return _totalmoney; }
        }
       
        #endregion Model

    }
}
