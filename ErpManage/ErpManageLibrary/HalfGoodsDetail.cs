using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 半成品入库单
    /// </summary>
    public class HalfGoodsDetail
    {

        #region Model
        private string _halfgoodsguid;
        private string _materialguid;
        private decimal _materialsum;
        private string _determinant;
        private int _sortid;
        /// <summary>
        /// 
        /// </summary>
        public string HalfGoodsGuid
        {
            set { _halfgoodsguid = value; }
            get { return _halfgoodsguid; }
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
        /// 品质判定
        /// </summary>
        public string Determinant
        {
            set { _determinant = value; }
            get { return _determinant; }
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
