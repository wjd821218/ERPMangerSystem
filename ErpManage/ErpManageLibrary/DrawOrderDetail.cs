using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 领料单明细
    /// 
    /// 修改：增加请领数一列  2010-8-4
    /// </summary>
    public class DrawOrderDetail
    {
        public DrawOrderDetail()
        { }
        #region Model
        private string _draworderguid;
        private string _materialguid;
        private decimal _materialsum;
        private decimal _applymaterialsum;
        private decimal _consumesum;
        private int _sortid;
        /// <summary>
        /// 
        /// </summary>
        public string DrawOrderGuid
        {
            set { _draworderguid = value; }
            get { return _draworderguid; }
        }
        /// <summary>
        /// 物料Guid
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
        /// 
        /// </summary>
        public int SortID
        {
            set { _sortid = value; }
            get { return _sortid; }
        }

        /// <summary>
        /// 请领数
        /// </summary>
        public decimal ApplyMaterialSum
        {
            set { _applymaterialsum = value; }
            get { return _applymaterialsum; }
        }

        /// <summary>
        /// 单耗
        /// </summary>
        public decimal ConsumeSum
        {
            set { _consumesum = value; }
            get { return _consumesum; }
        }


        #endregion Model
    }
}
