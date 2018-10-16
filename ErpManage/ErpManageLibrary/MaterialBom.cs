using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;

namespace ErpManageLibrary
{
    /// <summary>
    /// 母件信息保存
    /// </summary>
    public class MaterialBom
    {
        public MaterialBom()
        { }
        #region Model
        private string _materialguid;
        private string _materialname;
        private string _remark;
        /// <summary>
        /// 母件料件Guid
        /// </summary>
        public string MaterialGuid
        {
            set { _materialguid = value; }
            get { return _materialguid; }
        }
        /// <summary>
        /// 母件料件名称
        /// </summary>
        public string MaterialName
        {
            set { _materialname = value; }
            get { return _materialname; }
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
