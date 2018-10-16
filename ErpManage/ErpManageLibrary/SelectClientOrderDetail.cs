using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 销售出入库单从客户订单中选择所用传输数据的实体
    /// </summary>
    public class SelectClientOrderDetail
    {
        #region Model
        private string _ClientOrderguid;
        private string _ClientOrderid;
        private string _ClientOrderdetailguid;
        private DateTime? _ClientOrderdate;
        private string _materialguid;
        private string _materialid;
        private string _materialname;
        private string _unit;
        private string _spec;
        private decimal _materialsum;
        private decimal _outstoragesum;
        private decimal _canOutsum;
        private decimal _price;
        /// <summary>
        /// 
        /// </summary>
        public string ClientOrderGuid
        {
            set { _ClientOrderguid = value; }
            get { return _ClientOrderguid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ClientOrderID
        {
            set { _ClientOrderid = value; }
            get { return _ClientOrderid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ClientOrderDetailGuid
        {
            set { _ClientOrderdetailguid = value; }
            get { return _ClientOrderdetailguid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ClientOrderDate
        {
            set { _ClientOrderdate = value; }
            get { return _ClientOrderdate; }
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
        public decimal Price
        {
            set { _price = value; }
            get { return _price; }
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
        public decimal OutStorageSum
        {
            set { _outstoragesum = value; }
            get { return _outstoragesum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal CanOutSum
        {
            set { _canOutsum = value; }
            get { return _canOutsum; }
        }
        #endregion Model

    }
}
