using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class Authority
    {
        public Authority() { } //无参构造函数


        #region Model 
        private int _A_Id;
        private int _M_Id;
        private int _R_Id;

        /// <summary>
        /// 
        /// </summary>
        public int A_Id
        {
            set { _A_Id = value; }
            get { return _A_Id; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int M_Id
        {
            set { _M_Id = value; }
            get { return _M_Id; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int R_Id
        {
            set { _R_Id = value; }
            get { return _R_Id; }
        }

        #endregion 
    }
}