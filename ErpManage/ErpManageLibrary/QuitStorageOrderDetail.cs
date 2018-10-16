using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 退料入库单
    /// </summary>
    public class QuitStorageOrderDetail
    {
        #region Model
        private string _quitstorageorderguid;
        private string _materialguid;
        private decimal _materialsum;
        private string _remark;
        private int _sortid;
        /// <summary>
        /// 
        /// </summary>
        public string QuitStorageOrderGuid
        {
            set { _quitstorageorderguid = value; }
            get { return _quitstorageorderguid; }
        }
        /// <summary>
        /// 物料guid
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
