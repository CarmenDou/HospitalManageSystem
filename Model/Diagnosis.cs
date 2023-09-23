using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class Diagnosis
    {
        public Diagnosis() { } //无参构造函数


        #region Model 
        private int _D_Id;
        private string _D_No;
        private int _P_Id;
        private string _D_Describe;
        private string _D_Prescription;
        private string _D_Results;
        private DateTime _D_Time;
        private int _U_Id;

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
        public string D_No
        {
            set { _D_No = value; }
            get { return _D_No; }
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
        public string D_Describe
        {
            set { _D_Describe = value; }
            get { return _D_Describe; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string D_Prescription
        {
            set { _D_Prescription = value; }
            get { return _D_Prescription; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string D_Results
        {
            set { _D_Results = value; }
            get { return _D_Results; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime D_Time
        {
            set { _D_Time = value; }
            get { return _D_Time; }
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