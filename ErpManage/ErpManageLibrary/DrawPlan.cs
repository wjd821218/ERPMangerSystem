using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 生产领料计划主表
    /// </summary>
    public class DrawPlan
    {
        #region Model
        private string _DrawPlanguid;
        private string _DrawPlanid;
        private DateTime? _DrawPlandate;
        private string _remark;
        private string _createguid;
        private DateTime? _createdate;
        /// <summary>
        /// 
        /// </summary>
        public string DrawPlanGuid
        {
            set { _DrawPlanguid = value; }
            get { return _DrawPlanguid; }
        }
        /// <summary>
        /// 物料需求计划单号
        /// </summary>
        public string DrawPlanID
        {
            set { _DrawPlanid = value; }
            get { return _DrawPlanid; }
        }
        /// <summary>
        /// 计算日期
        /// </summary>
        public DateTime? DrawPlanDate
        {
            set { _DrawPlandate = value; }
            get { return _DrawPlandate; }
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
