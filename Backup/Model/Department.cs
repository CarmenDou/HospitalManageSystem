using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class Department
    {
        public Department() { } //无参构造函数


        #region Model 
        private int _D_Id;
        private string _D_Name;

        /// <summary>
        /// 
        /// </summary>
        public int D_Id
        {
            set { _D_Id = value; }
            get { return _D_Id; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string D_Name
        {
            set { _D_Name = value; }
            get { return _D_Name; }
        }

        #endregion 
    }
}