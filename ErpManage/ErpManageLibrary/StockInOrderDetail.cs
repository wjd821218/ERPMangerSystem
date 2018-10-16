using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 采购入库单明细
    /// </summary>
    public class StockInOrderDetail
    {
        public StockInOrderDetail()
        { }
        #region Model
        private string _stockinorderguid;
        private string _stockorderguid;
        private string _stockorderid;
        private string _stockorderdetailguid;
        private string _materialguid;
        private decimal _materialsum;
        private decimal _deliverysum;
        private decimal _storagesum;
        private string _remark;
        /// <summary>
        /// 
        /// </summary>
        public string StockInOrderGuid
        {
            set { _stockinorderguid = value; }
            get { return _stockinorderguid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string StockOrderGuid
        {
            set { _stockorderguid = value; }
            get { return _stockorderguid; }
        }
        /// <summary>
        /// 采购订单号
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
        /// 物料Guid号
        /// </summary>
        public string MaterialGuID
        {
            set { _materialguid = value; }
            get { return _materialguid; }
        }
        /// <summary>
        /// 订单数量
        /// </summary>
        public decimal MaterialSum
        {
            set { _materialsum = value; }
            get { return _materialsum; }
        }
        /// <summary>
        /// 交货数量
        /// </summary>
        public decimal DeliverySum
        {
            set { _deliverysum = value; }
            get { return _deliverysum; }
        }
        /// <summary>
        /// 实收数量:入库数量
        /// </summary>
        public decimal StorageSum
        {
            set { _storagesum = value; }
            get { return _storagesum; }
        }
        /// <summary>
        /// 到货时间
        /// </summary>
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        #endregion Model
    }
}
