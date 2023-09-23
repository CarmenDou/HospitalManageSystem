using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class PatientProject
    {
        public PatientProject() { } //无参构造函数


        #region Model 
        private int _Pp_Id;
        private int _Pp_Count;
        private decimal _Pp_Price;
        private decimal _Pp_Amount;
        private int _P_Id;
        private int _Cp_Id;
        private DateTime _Pp_Time;
        private int _U_Id;

        /// <summary>
        /// 
        /// </summary>
        public int Pp_Id
        {
            set { _Pp_Id = value; }
            get { return _Pp_Id; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Pp_Count
        {
            set { _Pp_Count = value; }
            get { return _Pp_Count; }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal Pp_Price
        {
            set { _Pp_Price = value; }
            get { return _Pp_Price; }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal Pp_Amount
        {
            set { _Pp_Amount = value; }
            get { return _Pp_Amount; }
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
        public int Cp_Id
        {
            set { _Cp_Id = value; }
            get { return _Cp_Id; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime Pp_Time
        {
            set { _Pp_Time = value; }
            get { return _Pp_Time; }
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