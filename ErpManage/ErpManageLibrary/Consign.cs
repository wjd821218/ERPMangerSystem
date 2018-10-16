using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 委外加工入库单
    /// </summary>
    public class Consign
    {

        #region Model
        private string _Consignguid;
        private string _Consignid;
        private DateTime _Consigndate;
        private string _plant;
        private string _incomedepot;
        private string _transactorperson;
        private string _satrapperson;
        private string _qualityperson;
        private string _depotperson;
        private string _supplierguid;
        private string _remark;
        private string _createguid;
        private DateTime _createdate;
        private string _checkguid;
        private DateTime _checkdate;

        private string _batchno;

        public string BatchNo
        {
            set { _batchno = value; }
            get { return _batchno; }
        }


        /// <summary>
        /// 
        /// </summary>
        public string ConsignGuid
        {
            set { _Consignguid = value; }
            get { return _Consignguid; }
        }

        /// <summary>
        /// 供应商
        /// </summary>
        public string SupplierGuid
        {
            set { _supplierguid = value; }
            get { return _supplierguid; }
        }
        /// <summary>
        /// 半成品入库单号
        /// </summary>
        public string ConsignID
        {
            set { _Consignid = value; }
            get { return _Consignid; }
        }
        /// <summary>
        /// 开单日期
        /// </summary>
        public DateTime ConsignDate
        {
            set { _Consigndate = value; }
            get { return _Consigndate; }
        }
        /// <summary>
        /// 车间
        /// </summary>
        public string Plant
        {
            set { _plant = value; }
            get { return _plant; }
        }
        /// <summary>
        /// 收货仓库
        /// </summary>
        public string IncomeDepot
        {
            set { _incomedepot = value; }
            get { return _incomedepot; }
        }
        /// <summary>
        /// 经办人
        /// </summary>
        public string TransactorPerson
        {
            set { _transactorperson = value; }
            get { return _transactorperson; }
        }
        /// <summary>
        /// 主管
        /// </summary>
        public string SatrapPerson
        {
            set { _satrapperson = value; }
            get { return _satrapperson; }
        }
        /// <summary>
        /// 品管
        /// </summary>
        public string QualityPerson
        {
            set { _qualityperson = value; }
            get { return _qualityperson; }
        }
        /// <summary>
        /// 仓管
        /// </summary>
        public string DepotPerson
        {
            set { _depotperson = value; }
            get { return _depotperson; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        /// <summary>
        /// 制单人
        /// </summary>
        public string CreateGuid
        {
            set { _createguid = value; }
            get { return _createguid; }
        }
        /// <summary>
        /// 制单时间
        /// </summary>
        public DateTime CreateDate
        {
            set { _createdate = value; }
            get { return _createdate; }
        }
        /// <summary>
        /// 审核人
        /// </summary>
        public string CheckGuid
        {
            set { _checkguid = value; }
            get { return _checkguid; }
        }
        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime CheckDate
        {
            set { _checkdate = value; }
            get { return _checkdate; }
        }
        #endregion Model
    }
}
