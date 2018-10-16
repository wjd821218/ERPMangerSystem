using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 单据删除时的提示出有么有别的单据已引用
    /// </summary>
    public class YJOrderDelete
    {
       
        private string _OrderID;
        private string _OrderName;
       
    
        /// <summary>
        /// 单据编号
        /// </summary>
        public string OrderID
        {
            set { _OrderID = value; }
            get { return _OrderID; }
        }


        /// <summary>
        /// 单据名称
        /// </summary>
        public string OrderName
        {
            set { _OrderName = value; }
            get { return _OrderName; }
        }
      
    }
}
