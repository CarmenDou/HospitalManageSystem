using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class DrugType
    {
        public DrugType() { } //�޲ι��캯��


        #region Model 
        private int _Dt_Id;
        private string _Dt_Name;

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
        public string Dt_Name
        {
            set { _Dt_Name = value; }
            get { return _Dt_Name; }
        }

        #endregion 
    }
}