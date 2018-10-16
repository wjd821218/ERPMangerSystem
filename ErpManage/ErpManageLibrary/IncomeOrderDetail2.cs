using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// ���
    /// </summary>
    public class IncomeOrderDetail2
    {
        #region Model
        private string _IncomeOrderguid;
        private string _SellOrderid;
        private DateTime? _SellOrderdate;
        private decimal _SellOrdermoney;
        private string _remark;
        private int _sortid;
        /// <summary>
        /// 
        /// </summary>
        public string IncomeOrderGuid
        {
            set { _IncomeOrderguid = value; }
            get { return _IncomeOrderguid; }
        }
        /// <summary>
        /// ���۳��ⵥ��
        /// </summary>
        public string SellOrderID
        {
            set { _SellOrderid = value; }
            get { return _SellOrderid; }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public DateTime? SellOrderDate
        {
            set { _SellOrderdate = value; }
            get { return _SellOrderdate; }
        }
        /// <summary>
        /// ���
        /// </summary>
        public decimal SellOrderMoney
        {
            set { _SellOrdermoney = value; }
            get { return _SellOrdermoney; }
        }
        /// <summary>
        /// ժҪ
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
