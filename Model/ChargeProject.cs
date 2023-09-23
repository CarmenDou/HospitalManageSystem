using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class ChargeProject
    {
        public ChargeProject() { } //无参构造函数


        #region Model 
        private int _Cp_Id;
        private string _Cp_No;
        private string _Cp_Name;
        private decimal _Cp_Cost;
        private int _Ct_Id;
        private string _Cp_Note;

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
        public string Cp_No
        {
            set { _Cp_No = value; }
            get { return _Cp_No; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Cp_Name
        {
            set { _Cp_Name = value; }
            get { return _Cp_Name; }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal Cp_Cost
        {
            set { _Cp_Cost = value; }
            get { return _Cp_Cost; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Ct_Id
        {
            set { _Ct_Id = value; }
            get { return _Ct_Id; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Cp_Note
        {
            set { _Cp_Note = value; }
            get { return _Cp_Note; }
        }

        #endregion 
    }
}