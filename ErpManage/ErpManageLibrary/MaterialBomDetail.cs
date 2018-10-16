using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// BOM明细类
    /// </summary>
    public class MaterialBomDetail
    {
        public MaterialBomDetail()
        { }
        #region Model
        private string _materialfatherguid;
        private string _materialguid;
        private string _materialname;
        private decimal _materialsum;
        private int _sortid;
        /// <summary>
        /// 是否是同一家结点
        /// </summary>
        public string MaterialFatherGuid
        {
            set { _materialfatherguid = value; }
            get { return _materialfatherguid; }
        }
        /// <summary>
        /// 物料Guid
        /// </summary>
        public string MaterialGuid
        {
            set { _materialguid = value; }
            get { return _materialguid; }
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
        /// 数量
        /// </summary>
        public decimal MaterialSum
        {
            set { _materialsum = value; }
            get { return _materialsum; }
        }

       
        public int SortID
        {
            set { _sortid = value; }
            get { return _sortid; }
        }
        #endregion Model

      

    }
}
