using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 物料当前库存数量预警类
    /// </summary>
    public class YJMaterialStorage
    {
       
        private string _materialid;
        private string _materialname;
        private decimal _MaterialSum;
        private decimal _StorageSum;
        private string _storagename;
     
     
      
        /// <summary>
        /// 物料编号
        /// </summary>
        public string MaterialID
        {
            set { _materialid = value; }
            get { return _materialid; }
        }


        /// <summary>
        /// 物料名称
        /// </summary>
        public string MaterialName
        {
            set { _materialname = value; }
            get { return _materialname; }
        }
        /// <summary>
        /// 出库数量
        /// </summary>
        public decimal MaterialSum
        {
            set { _MaterialSum = value; }
            get { return _MaterialSum; }
        }


        /// <summary>
        /// 库存数量
        /// </summary>
        public decimal StorageSum
        {
            set { _StorageSum = value; }
            get { return _StorageSum; }
        }
        /// <summary>
        /// 仓库名称
        /// </summary>
        public string StorageName
        {
            set { _storagename = value; }
            get { return _storagename; }
        }
    }
}
