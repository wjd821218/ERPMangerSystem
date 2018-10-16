using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 销售出库单
    /// </summary>
    public class SellOrderDetail
    {
        #region Model
        private string _sellorderguid;
        private string _clientorderguid;
        private string _clientorderid;
        private string _clientorderdetailguid;
        private string _materialguid;
        private decimal _price;
        private decimal _materialsum;
        private decimal _materialmoney;
        private decimal _boxsum;

        private string _remark;
        private int _sortid;
        /// <summary>
        /// 
        /// </summary>
        public string SellOrderGuid
        {
            set { _sellorderguid = value; }
            get { return _sellorderguid; }
        }
        /// <summary>
        /// 客户订单Guid
        /// </summary>
        public string ClientOrderGuid
        {
            set { _clientorderguid = value; }
            get { return _clientorderguid; }
        }
        /// <summary>
        /// 客户订单号
        /// </summary>
        public string ClientOrderID
        {
            set { _clientorderid = value; }
            get { return _clientorderid; }
        }
        /// <summary>
        /// 客户订单明细Guid
        /// </summary>
        public string ClientOrderDetailGuid
        {
            set { _clientorderdetailguid = value; }
            get { return _clientorderdetailguid; }
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
        /// 单价
        /// </summary>
        public decimal Price
        {
            set { _price = value; }
            get { return _price; }
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
        /// 箱数
        /// </summary>
        public decimal BoxSum
        {
            set { _boxsum = value; }
            get { return _boxsum; }
        }
        /// <summary>
        /// 备注
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
