using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    public class EquipmentInformation
    {

        public EquipmentInformation()
        { }
        #region Model
        private string _equipmentinformationguid;
        private string _equipmentguid = "";
        private string _equipmentinformationspec = "";
        private string _mademanufacturer = "";
        private DateTime? _madedate;
        private DateTime? _usedate;
        private string _historyrecord = "";
        /// <summary>
        /// 
        /// </summary>
        public string EquipmentInformationGuID
        {
            set { _equipmentinformationguid = value; }
            get { return _equipmentinformationguid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string EquipmentGuID
        {
            set { _equipmentguid = value; }
            get { return _equipmentguid; }
        }
        /// <summary>
        /// 设备型号规格
        /// </summary>
        public string EquipmentInformationSpec
        {
            set { _equipmentinformationspec = value; }
            get { return _equipmentinformationspec; }
        }
        /// <summary>
        /// 设备制造厂商
        /// </summary>
        public string MadeManufacturer
        {
            set { _mademanufacturer = value; }
            get { return _mademanufacturer; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? MadeDate
        {
            set { _madedate = value; }
            get { return _madedate; }
        }
        /// <summary>
        /// 设备制造厂商
        /// </summary>
        public DateTime? UseDate
        {
            set { _usedate = value; }
            get { return _usedate; }
        }
        /// <summary>
        /// 历史记录
        /// </summary>
        public string HistoryRecord
        {
            set { _historyrecord = value; }
            get { return _historyrecord; }
        }
        #endregion Model
    }
}
