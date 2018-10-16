using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 付款单
    /// </summary>
    public class PaymentOrderDetail2
    {
        #region Model
        private string _paymentorderguid;
        private string _stockinorderid;
        private DateTime? _stockinorderdate;
        private string _suppliername;
        private string _materialguid;
        private string _materialid;
        private string _materialname;
        private decimal _materialprice;
        private decimal _materialsum;
        private decimal _materialmoney;
        private string _remark;
        private string _orderflag;
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
        /// 采购订单号
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
        /// 供应商名称
        /// </summary>
        public string SupplierName
        {
            set { _suppliername = value; }
            get { return _suppliername; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MaterialGuID
        {
            set { _materialguid = value; }
            get { return _materialguid; }
        }

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
        /// 金额
        /// </summary>
        public decimal MaterialMoney
        {
            set { _materialmoney = value; }
            get { return _materialmoney; }
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
        /// 订单类别(采购入库单 退料单)
        /// </summary>
        public string OrderFlag
        {
            set { _orderflag = value; }
            get { return _orderflag; }
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
