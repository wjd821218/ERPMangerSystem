using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// �տ
    /// </summary>
    public class IncomeOrderDetail1
    {
        #region Model
        private string _IncomeOrderguid;
        private string _Incomeid;
        private decimal _Incomemoney;
        private string _cny;
        private string _Incometype;
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
        /// �ʻ�
        /// </summary>
        public string IncomeID
        {
            set { _Incomeid = value; }
            get { return _Incomeid; }
        }
        /// <summary>
        /// ���
        /// </summary>
        public decimal IncomeMoney
        {
            set { _Incomemoney = value; }
            get { return _Incomemoney; }
        }
        /// <summary>
        /// ����
        /// </summary>
        public string CNY
        {
            set { _cny = value; }
            get { return _cny; }
        }
        /// <summary>
        /// ֧����ʽ
        /// </summary>
        public string IncomeType
        {
            set { _Incometype = value; }
            get { return _Incometype; }
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
