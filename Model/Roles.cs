using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class Roles
    {
        public Roles() { } //无参构造函数


        #region Model 
        private int _R_Id;
        private string _R_Name;

        /// <summary>
        /// 
        /// </summary>
        public int R_Id
        {
            set { _R_Id = value; }
            get { return _R_Id; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string R_Name
        {
            set { _R_Name = value; }
            get { return _R_Name; }
        }

        #endregion 
    }
}