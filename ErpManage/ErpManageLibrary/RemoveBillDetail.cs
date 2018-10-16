using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    ///  调拨单
    /// </summary>
    public class RemoveBillDetail
    {

        #region Model
        private string _removebillguid;
        private string _materialguid;
        private decimal _materialsum;
     
        /// <summary>
        /// 单据表头Guid
        /// </summary>
        public string RemoveBillGuid
        {
            set { _removebillguid = value; }
            get { return _removebillguid; }
        }
        /// <summary>
        /// 货品guid
        /// </summary>
        public string MaterialGuID
        {
            set { _materialguid = value; }
            get { return _materialguid; }
        }
        /// <summary>
        /// 数量
        /// </summary>
        public decimal MaterialSum
        {
            set { _materialsum = value; }
            get { return _materialsum; }
        }
        #endregion Model
    }
}
