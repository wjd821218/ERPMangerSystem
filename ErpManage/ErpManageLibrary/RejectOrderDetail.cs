using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    ///  报废单明细
    /// </summary>
    public class RejectOrderDetail
    {

        public RejectOrderDetail()
        { }
        #region Model
        private string _rejectorderguid;
        private string _materialguid;
        private decimal _materialsum;
        private string _remark;
        private int _sortid;
        /// <summary>
        /// 
        /// </summary>
        public string RejectOrderGuid
        {
            set { _rejectorderguid = value; }
            get { return _rejectorderguid; }
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
