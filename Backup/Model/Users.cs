using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class Users
    {
        public Users() { } //无参构造函数


        #region Model 
        private int _U_Id;
        private string _U_No;
        private string _U_Pwd;
        private string _U_Name;
        private string _U_Sex;
        private string _U_Phone;
        private int _R_Id;
        private int _D_Id;
        private string _U_Note;

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
        public string U_No
        {
            set { _U_No = value; }
            get { return _U_No; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string U_Pwd
        {
            set { _U_Pwd = value; }
            get { return _U_Pwd; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string U_Name
        {
            set { _U_Name = value; }
            get { return _U_Name; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string U_Sex
        {
            set { _U_Sex = value; }
            get { return _U_Sex; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string U_Phone
        {
            set { _U_Phone = value; }
            get { return _U_Phone; }
        }

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
        public int D_Id
        {
            set { _D_Id = value; }
            get { return _D_Id; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string U_Note
        {
            set { _U_Note = value; }
            get { return _U_Note; }
        }

        #endregion 
    }
}