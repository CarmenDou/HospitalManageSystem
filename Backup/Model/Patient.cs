using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class Patient
    {
        public Patient() { } //无参构造函数


        #region Model 
        private int _P_Id;
        private string _P_No;
        private string _P_Name;
        private string _P_Sex;
        private int _P_Age;
        private string _P_Phone;

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
        public string P_No
        {
            set { _P_No = value; }
            get { return _P_No; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string P_Name
        {
            set { _P_Name = value; }
            get { return _P_Name; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string P_Sex
        {
            set { _P_Sex = value; }
            get { return _P_Sex; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int P_Age
        {
            set { _P_Age = value; }
            get { return _P_Age; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string P_Phone
        {
            set { _P_Phone = value; }
            get { return _P_Phone; }
        }

        #endregion 
    }
}