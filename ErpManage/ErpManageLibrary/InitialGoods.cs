using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 期初数据录入
    /// </summary>
    public class InitialGoods
    {

        #region Model
        private string _InitialGoodsguid;
        private string _InitialGoodsid;
        private DateTime _InitialGoodsdate;
        private string _incomedepot;
        private string _remark;
        private string _createguid;
        private DateTime _createdate;
        private string _checkguid;
        private DateTime _checkdate;
        /// <summary>
        /// 
        /// </summary>
        public string InitialGoodsGuid
        {
            set { _InitialGoodsguid = value; }
            get { return _InitialGoodsguid; }
        }
        /// <summary>
        /// 期初ID
        /// </summary>
        public string InitialGoodsID
        {
            set { _InitialGoodsid = value; }
            get { return _InitialGoodsid; }
        }
        /// <summary>
        /// 开单日期
        /// </summary>
        public DateTime InitialGoodsDate
        {
            set { _InitialGoodsdate = value; }
            get { return _InitialGoodsdate; }
        }
     
        /// <summary>
        /// 收货仓库
        /// </summary>
        public string IncomeDepot
        {
            set { _incomedepot = value; }
            get { return _incomedepot; }
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
        /// 制单人
        /// </summary>
        public string CreateGuid
        {
            set { _createguid = value; }
            get { return _createguid; }
        }
        /// <summary>
        /// 制单时间
        /// </summary>
        public DateTime CreateDate
        {
            set { _createdate = value; }
            get { return _createdate; }
        }
        /// <summary>
        /// 审核人
        /// </summary>
        public string CheckGuid
        {
            set { _checkguid = value; }
            get { return _checkguid; }
        }
        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime CheckDate
        {
            set { _checkdate = value; }
            get { return _checkdate; }
        }
        #endregion Model
    }
}
