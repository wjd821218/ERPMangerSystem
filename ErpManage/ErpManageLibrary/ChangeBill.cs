using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Daniel.Liu.DAO;

namespace ErpManageLibrary
{
    /// <summary>
    /// 工程更改单
    /// </summary>
    public class ChangeBill
    {
        #region Model
        private string _changebillguid;
        private string _changebillid = "";
        private DateTime? _changebilldate;
        private string _changeperson = "";
        private string _fileguid = "";
        private string _newversionid = "";
        private string _remark = "";
        private string _createguid = "";
        private DateTime? _createdate;
        private string _checkguid = "";
        private DateTime? _checkdate;
        /// <summary>
        /// 
        /// </summary>
        public string ChangeBillGuID
        {
            set { _changebillguid = value; }
            get { return _changebillguid; }
        }
        /// <summary>
        /// 工程更改编号
        /// </summary>
        public string ChangeBillID
        {
            set { _changebillid = value; }
            get { return _changebillid; }
        }
        /// <summary>
        /// 开单日期
        /// </summary>
        public DateTime? ChangeBillDate
        {
            set { _changebilldate = value; }
            get { return _changebilldate; }
        }
        /// <summary>
        /// 更改记录人
        /// </summary>
        public string ChangePerson
        {
            set { _changeperson = value; }
            get { return _changeperson; }
        }
        /// <summary>
        /// 文件guid
        /// </summary>
        public string FileGuID
        {
            set { _fileguid = value; }
            get { return _fileguid; }
        }
        /// <summary>
        /// 新版本
        /// </summary>
        public string NewVersionID
        {
            set { _newversionid = value; }
            get { return _newversionid; }
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
        public DateTime? CreateDate
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
        public DateTime? CheckDate
        {
            set { _checkdate = value; }
            get { return _checkdate; }
        }
        #endregion Model



    }
}
