using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 采购入库单从采购订单中选择所用传输数据的实体
    /// </summary>
    public class SelectStockOrderDetail
    {
        #region Model
        private string _stockorderguid;
        private string _stockorderid;
        private string _stockorderdetailguid;
        private DateTime? _stockorderdate;
        private string _materialguid;
        private string _materialid;
        private string _materialname;
        private string _unit;
        private string _spec;
        private decimal _materialsum;
        private decimal _storagesum;
        private decimal _caninsum;
        /// <summary>
        /// 
        /// </summary>
        public string StockOrderGuid
        {
            set { _stockorderguid = value; }
            get { return _stockorderguid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string StockOrderID
        {
            set { _stockorderid = value; }
            get { return _stockorderid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string StockOrderDetailGuid
        {
            set { _stockorderdetailguid = value; }
            get { return _stockorderdetailguid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? StockOrderDate
        {
            set { _stockorderdate = value; }
            get { return _stockorderdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MaterialGuID
        {
            set { _materialguid = value; }
            get { return _materialguid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MaterialID
        {
            set { _materialid = value; }
            get { return _materialid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MaterialName
        {
            set { _materialname = value; }
            get { return _materialname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Unit
        {
            set { _unit = value; }
            get { return _unit; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Spec
        {
            set { _spec = value; }
            get { return _spec; }
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
        public decimal StorageSum
        {
            set { _storagesum = value; }
            get { return _storagesum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal CanInSum
        {
            set { _caninsum = value; }
            get { return _caninsum; }
        }
        #endregion Model

    }
}
