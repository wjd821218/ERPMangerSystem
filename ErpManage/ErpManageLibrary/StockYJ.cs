using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    public class StockYJ
    {

        public StockYJ()
        { }
       
        private string _materialguid;
        private decimal _stockyjdown;
        private decimal _stockyjup;
        private string _stockguid;
        private decimal _BomSum;


        public string StockYJGuid
        {
            set { _stockguid = value; }
            get { return _stockguid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MaterialGuid
        {
            set { _materialguid = value; }
            get { return _materialguid; }
        }
        /// <summary>
        /// 下限
        /// </summary>
        public decimal StockYJDown
        {
            set { _stockyjdown = value; }
            get { return _stockyjdown; }
        }
        /// <summary>
        /// 上限
        /// </summary>
        public decimal StockYJUp
        {
            set { _stockyjup = value; }
            get { return _stockyjup; }
        }
        public decimal BomSum
        {
            set { _BomSum = value; }
            get { return _BomSum; }
        }


    }

}
