using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 
    /// </summary>
    public class Equipment
    {

        public Equipment()
        { }
        #region Model
        private string _equipmentguid = "";
        private string _equipmentid = "";
        private string _equipmentname = "";
        private string _equipmenttype = "";
        private string _useperson = "";
        private string _equipmentstate = "";
        private string _saveplace = "";
        private string _remark = "";
        /// <summary>
        /// 
        /// </summary>
        public string EquipmentGuID
        {
            set { _equipmentguid = value; }
            get { return _equipmentguid; }
        }
        /// <summary>
        /// 工装设备编号
        /// </summary>
        public string EquipmentID
        {
            set { _equipmentid = value; }
            get { return _equipmentid; }
        }
        /// <summary>
        /// 工装设备名称
        /// </summary>
        public string EquipmentName
        {
            set { _equipmentname = value; }
            get { return _equipmentname; }
        }
        /// <summary>
        /// 工装设备分类
        /// </summary>
        public string EquipmentType
        {
            set { _equipmenttype = value; }
            get { return _equipmenttype; }
        }
        /// <summary>
        /// 使用者
        /// </summary>
        public string UsePerson
        {
            set { _useperson = value; }
            get { return _useperson; }
        }
        /// <summary>
        /// 状态：1-可用 0-停用
        /// </summary>
        public string EquipmentState
        {
            set { _equipmentstate = value; }
            get { return _equipmentstate; }
        }
        /// <summary>
        /// 存放地点
        /// </summary>
        public string SavePlace
        {
            set { _saveplace = value; }
            get { return _saveplace; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        #endregion Model




    }
}
