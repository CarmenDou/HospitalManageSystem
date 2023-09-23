using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class RegisterType
    {
        public RegisterType() { } //无参构造函数


        #region Model 
        private int _Rt_Id;
        private string _Rt_Name;
        private decimal _Rt_Cost;

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
        public string Rt_Name
        {
            set { _Rt_Name = value; }
            get { return _Rt_Name; }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal Rt_Cost
        {
            set { _Rt_Cost = value; }
            get { return _Rt_Cost; }
        }

        #endregion 
    }
}