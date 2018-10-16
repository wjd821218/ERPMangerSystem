using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    public class ClientOrderDetail
    {
        #region Model
        private string _clientorderguid;
        private string _materialguid;
        private decimal _materialsum;
        private string _remark;
        /// <summary>
        /// 客户订单号
        /// </summary>
        public string ClientOrderGuid
        {
            set { _clientorderguid = value; }
            get { return _clientorderguid; }
        }
        /// <summary>
        /// 物料Guid号
        /// </summary>
        public string MaterialGuid
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
        /// <summary>
        /// 说明
        /// </summary>
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        #endregion Model
    }
}
