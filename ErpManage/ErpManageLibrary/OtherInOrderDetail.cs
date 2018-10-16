using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 其它入库单
    /// </summary>
    public class OtherInOrderDetail
    {
        #region Model
        private string _OtherInOrderguid;
        private string _materialguid;
        private decimal _price;
        private decimal _materialsum;
        private decimal _materialmoney;
        private string _remark;
        private int _sortid;
        /// <summary>
        /// 
        /// </summary>
        public string OtherInOrderGuid
        {
            set { _OtherInOrderguid = value; }
            get { return _OtherInOrderguid; }
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
