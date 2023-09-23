using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class Drug
    {
        public Drug() { } //无参构造函数


        #region Model 
        private int _D_Id;
        private string _D_Name;
        private decimal _D_Price;
        private int _U_Id;
        private string _D_Approval;
        private string _D_Composition;
        private string _D_Efficacy;
        private string _D_Methods;
        private int _Dt_Id;
        private string _D_No;

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

        /// <summary>
        /// 
        /// </summary>
        public decimal D_Price
        {
            set { _D_Price = value; }
            get { return _D_Price; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int U_Id
        {
            set { _U_Id = value; }
            get { return _U_Id; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string D_Approval
        {
            set { _D_Approval = value; }
            get { return _D_Approval; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string D_Composition
        {
            set { _D_Composition = value; }
            get { return _D_Composition; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string D_Efficacy
        {
            set { _D_Efficacy = value; }
            get { return _D_Efficacy; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string D_Methods
        {
            set { _D_Methods = value; }
            get { return _D_Methods; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Dt_Id
        {
            set { _Dt_Id = value; }
            get { return _Dt_Id; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string D_No
        {
            set { _D_No = value; }
            get { return _D_No; }
        }


        #endregion 
    }
}