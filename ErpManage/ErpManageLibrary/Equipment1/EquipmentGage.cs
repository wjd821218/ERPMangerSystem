using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 计量器信息
    /// </summary>
    public class EquipmentGage
    {
        public EquipmentGage()
        { }
        #region Model
        private string _gageguid;
        private string _equipmentguid = "";
        private string _gagespec = "";
        private string _leavefactoryid = "";
        private string _scalearea = "";
        private string _scaleprecision = "";
        private string _managelevel = "";
        private string _checktype = "";
        private string _checkcycle = "";
        private string _checkunit = "";
        private string _appraisalrecord = "";
        /// <summary>
        /// 
        /// </summary>
        public string GageGuID
        {
            set { _gageguid = value; }
            get { return _gageguid; }
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
        /// 规格型号
        /// </summary>
        public string GageSpec
        {
            set { _gagespec = value; }
            get { return _gagespec; }
        }
        /// <summary>
        /// 出厂编号
        /// </summary>
        public string LeaveFactoryID
        {
            set { _leavefactoryid = value; }
            get { return _leavefactoryid; }
        }
        /// <summary>
        /// 测量范围
        /// </summary>
        public string ScaleArea
        {
            set { _scalearea = value; }
            get { return _scalearea; }
        }
        /// <summary>
        /// 精度
        /// </summary>
        public string ScalePrecision
        {
            set { _scaleprecision = value; }
            get { return _scaleprecision; }
        }
        /// <summary>
        /// 管理级别
        /// </summary>
        public string ManageLevel
        {
            set { _managelevel = value; }
            get { return _managelevel; }
        }
        /// <summary>
        /// 检定方式
        /// </summary>
        public string CheckType
        {
            set { _checktype = value; }
            get { return _checktype; }
        }
        /// <summary>
        /// 校准周期
        /// </summary>
        public string CheckCycle
        {
            set { _checkcycle = value; }
            get { return _checkcycle; }
        }
        /// <summary>
        /// 校准单位
        /// </summary>
        public string CheckUnit
        {
            set { _checkunit = value; }
            get { return _checkunit; }
        }
        /// <summary>
        /// 鉴定记录
        /// </summary>
        public string AppraisalRecord
        {
            set { _appraisalrecord = value; }
            get { return _appraisalrecord; }
        }
        #endregion Model







    }
}
