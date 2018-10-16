using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 选择货品分类
    /// </summary>
    public class SelectMaterialType
    {
        private string _MaterialTypeID;
        private string _MaterialTypeName;


        public string MaterialTypeID
        {
            set { _MaterialTypeID = value; }
            get { return _MaterialTypeID; }
        }

        public string MaterialTypeName
        {
            set { _MaterialTypeName = value; }
            get { return _MaterialTypeName; }
        }


    }
}
