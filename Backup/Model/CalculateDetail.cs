using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class CalculateDetail
    {
        public CalculateDetail() { } //无参构造函数


        #region Model 
        private int _Cd_Id;
        private int _C_Id;
        private decimal _Cd_Price;
        private int _Cd_Count;
        private decimal _Cd_Amount;
        private int _D_Id;

        /// <summary>
        /// 
        /// </summary>
        public int Cd_Id
        {
            set { _Cd_Id = value; }
            get { return _Cd_Id; }
        }

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
        public decimal Cd_Price
        {
            set { _Cd_Price = value; }
            get { return _Cd_Price; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Cd_Count
        {
            set { _Cd_Count = value; }
            get { return _Cd_Count; }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal Cd_Amount
        {
            set { _Cd_Amount = value; }
            get { return _Cd_Amount; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int D_Id
        {
            set { _D_Id = value; }
            get { return _D_Id; }
        }

        #endregion 
    }
}