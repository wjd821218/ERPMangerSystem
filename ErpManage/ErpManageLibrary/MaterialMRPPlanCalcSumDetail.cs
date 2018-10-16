using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// ��������ƻ�-ѡ��Ŀͻ�������ϸ��
    /// </summary>
    public class MaterialMRPPlanCalcSumDetail
    {


        #region Model
        private string _noid;
        private string _materialmrpplanguid;
        private string _materialguid;
        private decimal _materialrequirementsum;
        private decimal _materialstocksum;
        private decimal _materialstockinsum;
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
        public string MaterialMRPPlanGuid
        {
            set { _materialmrpplanguid = value; }
            get { return _materialmrpplanguid; }
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
        /// ë������
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
        /// <summary>
        /// ��������
        /// </summary>
        public decimal MaterialStockInSum
        {
            set { _materialstockinsum = value; }
            get { return _materialstockinsum; }
        }
        #endregion Model
    }
}
