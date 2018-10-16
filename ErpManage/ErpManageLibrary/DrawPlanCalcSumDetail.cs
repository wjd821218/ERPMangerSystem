using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// �������ϼƻ�-ѡ��Ŀͻ�������ϸ��
    /// </summary>
    public class DrawPlanCalcSumDetail
    {


        #region Model
        private string _noid;
        private string _DrawPlanguid;
        private string _materialguid;
        private decimal _materialrequirementsum;
        private decimal _materialstocksum;
        /// <summary>
        /// 
        /// </summary>
        public string NoID
        {
            set { _noid = value; }
            get { return _noid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DrawPlanGuid
        {
            set { _DrawPlanguid = value; }
            get { return _DrawPlanguid; }
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
        ///������ȡ��
        /// </summary>
        public decimal MaterialRequirementSum
        {
            set { _materialrequirementsum = value; }
            get { return _materialrequirementsum; }
        }
        /// <summary>
        /// �����
        /// </summary>
        public decimal MaterialStockSum
        {
            set { _materialstocksum = value; }
            get { return _materialstocksum; }
        }
     
        #endregion Model
    }
}
