using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 物料需求计划主表
    /// </summary>
    public class MaterialMRPPlan
    {
        #region Model
        private string _materialmrpplanguid;
        private string _materialmrpplanid;
        private DateTime? _materialmrpplandate;
        private string _remark;
        private string _createguid;
        private DateTime? _createdate;
        /// <summary>
        /// 
        /// </summary>
        public string MaterialMRPPlanGuid
        {
            set { _materialmrpplanguid = value; }
            get { return _materialmrpplanguid; }
        }
        /// <summary>
        /// 物料需求计划单号
        /// </summary>
        public string MaterialMRPPlanID
        {
            set { _materialmrpplanid = value; }
            get { return _materialmrpplanid; }
        }
        /// <summary>
        /// 计算日期
        /// </summary>
        public DateTime? MaterialMRPPlanDate
        {
            set { _materialmrpplandate = value; }
            get { return _materialmrpplandate; }
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
        #endregion Model


    }
}
