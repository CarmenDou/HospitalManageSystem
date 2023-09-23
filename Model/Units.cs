using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class Units
    {
        public Units() { } //无参构造函数


        #region Model 
        private int _U_Id;
        private string _U_Name;

        /// <summary>
        /// 
        /// </summary>
        public int U_Id
        {
            set { _U_Id = value; }
            get { return _U_Id; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string U_Name
        {
            set { _U_Name = value; }
            get { return _U_Name; }
        }

        #endregion 
    }
}