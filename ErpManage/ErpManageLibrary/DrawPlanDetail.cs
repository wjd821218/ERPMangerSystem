using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// �������ϼƻ���ϸ��
    /// </summary>
   public  class DrawPlanDetail
    {

        #region Model
        private string _noid;
        private string _DrawPlanguid;
        private string _clientorderid;
        private string _clientorderdetailguid;
        private string _materialguid;
        private decimal _materialsum;
        private decimal _ycmaterialsum;
        private int _sortid;
        /// <summary>
        /// 
        /// </summary>
        public string NoID
        {
            set { _noid = value; }
            get { return _noid; }
        }
        /// <summary>
        /// ��������ƻ�����
        /// </summary>
        public string DrawPlanGuid
        {
            set { _DrawPlanguid = value; }
            get { return _DrawPlanguid; }
        }
        /// <summary>
        /// �ͻ�������
        /// </summary>
        public string ClientOrderid
        {
            set { _clientorderid = value; }
            get { return _clientorderid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ClientOrderDetailGuid
        {
            set { _clientorderdetailguid = value; }
            get { return _clientorderdetailguid; }
        }
        /// <summary>
        /// ����guid
        /// </summary>
        public string MaterialGuid
        {
            set { _materialguid = value; }
            get { return _materialguid; }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public decimal MaterialSum
        {
            set { _materialsum = value; }
            get { return _materialsum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal YCMaterialSum
        {
            set { _ycmaterialsum = value; }
            get { return _ycmaterialsum; }
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
