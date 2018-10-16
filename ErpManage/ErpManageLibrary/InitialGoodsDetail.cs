using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 期初录入
    /// </summary>
    public class InitialGoodsDetail
    {

        #region Model
        private string _InitialGoodsguid;
        private string _materialguid;
        private decimal _materialsum;
      
        /// <summary>
        /// 
        /// </summary>
        public string InitialGoodsGuid
        {
            set { _InitialGoodsguid = value; }
            get { return _InitialGoodsguid; }
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
    
        #endregion Model
    }
}
