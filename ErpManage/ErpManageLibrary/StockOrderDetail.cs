using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 采购订单明细
    /// </summary>
    public class StockOrderDetail
    {

        public StockOrderDetail()
        { }
        #region Model
        private string _stockorderguid;
        private string _materialguid;
        private decimal _materialprice;
        private decimal _materialsum;
        private decimal _materialtotalmoney;
        private string _arrivedate;
        /// <summary>
        /// 
        /// </summary>
        public string StockOrderGuid
        {
            set { _stockorderguid = value; }
            get { return _stockorderguid; }
        }
        /// <summary>
        /// 物料Guid号
        /// </summary>
        public string MaterialGuID
        {
            set { _materialguid = value; }
            get { return _materialguid; }
        }
        /// <summary>
        /// 单价
        /// </summary>
        public decimal MaterialPrice
        {
            set { _materialprice = value; }
            get { return _materialprice; }
        }
        /// <summary>
        /// 数量
        /// </summary>
        public decimal MaterialSum
        {
            set { _materialsum = value; }
            get { return _materialsum; }
        }
        /// <summary>
        /// 总金额
        /// </summary>
        public decimal MaterialTotalMoney
        {
            set { _materialtotalmoney = value; }
            get { return _materialtotalmoney; }
        }
        /// <summary>
        /// 到货时间
        /// </summary>
        public string ArriveDate
        {
            set { _arrivedate = value; }
            get { return _arrivedate; }
        }
        #endregion Model
    }
}
