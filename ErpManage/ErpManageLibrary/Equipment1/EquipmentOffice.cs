using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 办公设备
    /// </summary>
    public class EquipmentOffice
    {
        public EquipmentOffice()
        { }
        #region Model
        private string _equipmentofficeguid;
        private string _equipmentguid = "";
        private string _brand = "";
        private string _equipmentofficespec = "";
        private string _disksize = "";
        private string _cpu = "";
        private string _memory = "";
        private string _displaycar = "";
        /// <summary>
        /// 
        /// </summary>
        public string EquipmentOfficeGuID
        {
            set { _equipmentofficeguid = value; }
            get { return _equipmentofficeguid; }
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
        /// 品牌
        /// </summary>
        public string Brand
        {
            set { _brand = value; }
            get { return _brand; }
        }
        /// <summary>
        /// 规格
        /// </summary>
        public string EquipmentOfficeSpec
        {
            set { _equipmentofficespec = value; }
            get { return _equipmentofficespec; }
        }
        /// <summary>
        /// 硬盘大小
        /// </summary>
        public string DiskSize
        {
            set { _disksize = value; }
            get { return _disksize; }
        }
        /// <summary>
        /// CPU
        /// </summary>
        public string CPU
        {
            set { _cpu = value; }
            get { return _cpu; }
        }
        /// <summary>
        /// 内存
        /// </summary>
        public string Memory
        {
            set { _memory = value; }
            get { return _memory; }
        }
        /// <summary>
        /// 显卡
        /// </summary>
        public string DisplayCar
        {
            set { _displaycar = value; }
            get { return _displaycar; }
        }
        #endregion Model





    }
}
