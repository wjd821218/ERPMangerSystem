using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 工装设备
    /// </summary>
    public class EquipmentFrock
    {

        public EquipmentFrock()
        { }
        #region Model
        private string _equipmentfrockguid;
        private string _equipmentguid = "";
        private string _productclass = "";
        private string _workefficiency = "";
        private string _equipmentstuff = "";
        private string _equipmentformal = "";
        private string _frocksource = "";
        /// <summary>
        /// 
        /// </summary>
        public string EquipmentFrockGuID
        {
            set { _equipmentfrockguid = value; }
            get { return _equipmentfrockguid; }
        }
        /// <summary>
        /// 主表guid
        /// </summary>
        public string EquipmentGuID
        {
            set { _equipmentguid = value; }
            get { return _equipmentguid; }
        }
        /// <summary>
        /// 产品类别
        /// </summary>
        public string ProductClass
        {
            set { _productclass = value; }
            get { return _productclass; }
        }
        /// <summary>
        /// 工位
        /// </summary>
        public string WorkEfficiency
        {
            set { _workefficiency = value; }
            get { return _workefficiency; }
        }
        /// <summary>
        /// 材料
        /// </summary>
        public string EquipmentStuff
        {
            set { _equipmentstuff = value; }
            get { return _equipmentstuff; }
        }
        /// <summary>
        /// 外形尺寸
        /// </summary>
        public string EquipmentFormal
        {
            set { _equipmentformal = value; }
            get { return _equipmentformal; }
        }
        /// <summary>
        /// 工装来源
        /// </summary>
        public string FrockSource
        {
            set { _frocksource = value; }
            get { return _frocksource; }
        }
        #endregion Model










    }
}
