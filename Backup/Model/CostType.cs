using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class CostType
    {
        public CostType() { } //无参构造函数


        #region Model 
        private int _Ct_Id;
        private string _Ct_Name;

        /// <summary>
        /// 
        /// </summary>
        public int Ct_Id
        {
            set { _Ct_Id = value; }
            get { return _Ct_Id; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Ct_Name
        {
            set { _Ct_Name = value; }
            get { return _Ct_Name; }
        }

        #endregion 
    }
}