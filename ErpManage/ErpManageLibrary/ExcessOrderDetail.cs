using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
     /// <summary>
    /// ���쵥
    /// </summary>
    public class ExcessOrderDetail
    {

        #region Model
        private string _excessorderguid;
        private string _materialguid;
        private decimal _materialsum;
        private decimal _materialoutsum;
        private int _sortid;
        /// <summary>
        /// 
        /// </summary>
        public string ExcessOrderGuid
        {
            set { _excessorderguid = value; }
            get { return _excessorderguid; }
        }
        /// <summary>
        /// ����Guid
        /// </summary>
        public string MaterialGuID
        {
            set { _materialguid = value; }
            get { return _materialguid; }
        }
        /// <summary>
        /// ����
        /// </summary>
        public decimal MaterialSum
        {
            set { _materialsum = value; }
            get { return _materialsum; }
        }

        /// <summary>
        /// ʵ������
        /// </summary>
        public decimal MaterialOutSum
        {
            set { _materialoutsum = value; }
            get { return _materialoutsum; }
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
