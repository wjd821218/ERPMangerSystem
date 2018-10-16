using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// ���ϵ���ϸ
    /// 
    /// �޸ģ�����������һ��  2010-8-4
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
        /// 
        /// </summary>
        public int SortID
        {
            set { _sortid = value; }
            get { return _sortid; }
        }

        /// <summary>
        /// ������
        /// </summary>
        public decimal ApplyMaterialSum
        {
            set { _applymaterialsum = value; }
            get { return _applymaterialsum; }
        }

        /// <summary>
        /// ����
        /// </summary>
        public decimal ConsumeSum
        {
            set { _consumesum = value; }
            get { return _consumesum; }
        }


        #endregion Model
    }
}
