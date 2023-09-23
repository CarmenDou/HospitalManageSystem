using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class Calculate
    {
        public Calculate() { } //无参构造函数


        #region Model 
        private int _C_Id;
        private string _C_No;
        private int _P_Id;
        private decimal _C_Amount;
        private DateTime _C_Time;
        private int _U_Id;

        /// <summary>
        /// 
        /// </summary>
        public int C_Id
        {
            set { _C_Id = value; }
            get { return _C_Id; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string C_No
        {
            set { _C_No = value; }
            get { return _C_No; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int P_Id
        {
            set { _P_Id = value; }
            get { return _P_Id; }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal C_Amount
        {
            set { _C_Amount = value; }
            get { return _C_Amount; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime C_Time
        {
            set { _C_Time = value; }
            get { return _C_Time; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int U_Id
        {
            set { _U_Id = value; }
            get { return _U_Id; }
        }

        #endregion 
    }
}