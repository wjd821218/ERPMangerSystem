using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 模具信息
    /// </summary>
    public class EquipmentDie
    {

        public EquipmentDie()
        { }
        #region Model
        private string _dieguid = "";
        private string _equipmentguid = "";
        private string _dietype = "";
        private string _producttype = "";
        private string _life = "";
        private string _energy = "";
        private string _partname = "";
        private string _partid = "";
        private string _exteriorsize = "";
        private string _datum;
        private string _diesource = "";
        private string _aperture = "";
        /// <summary>
        /// 
        /// </summary>
        public string DieGuID
        {
            set { _dieguid = value; }
            get { return _dieguid; }
        }
        /// <summary>
        /// 工装设备主表号
        /// </summary>
        public string EquipmentGuID
        {
            set { _equipmentguid = value; }
            get { return _equipmentguid; }
        }
        /// <summary>
        /// 模具类别
        /// </summary>
        public string DieType
        {
            set { _dietype = value; }
            get { return _dietype; }
        }
        /// <summary>
        /// 产品类别
        /// </summary>
        public string ProductType
        {
            set { _producttype = value; }
            get { return _producttype; }
        }
        /// <summary>
        /// 寿命
        /// </summary>
        public string Life
        {
            set { _life = value; }
            get { return _life; }
        }
        /// <summary>
        /// 产能
        /// </summary>
        public string Energy
        {
            set { _energy = value; }
            get { return _energy; }
        }
        /// <summary>
        /// 零件名称
        /// </summary>
        public string PartName
        {
            set { _partname = value; }
            get { return _partname; }
        }
        /// <summary>
        /// 零件物料编号
        /// </summary>
        public string PartID
        {
            set { _partid = value; }
            get { return _partid; }
        }
        /// <summary>
        /// 外型尺寸（mm)
        /// </summary>
        public string ExteriorSize
        {
            set { _exteriorsize = value; }
            get { return _exteriorsize; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Datum
        {
            set { _datum = value; }
            get { return _datum; }
        }
        /// <summary>
        /// 模具来源
        /// </summary>
        public string DieSource
        {
            set { _diesource = value; }
            get { return _diesource; }
        }
        /// <summary>
        /// 模穴
        /// </summary>
        public string Aperture
        {
            set { _aperture = value; }
            get { return _aperture; }
        }
        #endregion Model






    }
}
