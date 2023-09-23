using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class Register
    {
        public Register() { } //无参构造函数


        #region Model 
        private int _R_Id;
        private string _R_No;
        private string _R_Name;
        private int _D_Id;
        private int _Rt_Id;
        private decimal _R_Cost;
        private int _U_Id;

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
        public string R_No
        {
            set { _R_No = value; }
            get { return _R_No; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string R_Name
        {
            set { _R_Name = value; }
            get { return _R_Name; }
        }

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
        public int Rt_Id
        {
            set { _Rt_Id = value; }
            get { return _Rt_Id; }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal R_Cost
        {
            set { _R_Cost = value; }
            get { return _R_Cost; }
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