using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class Record
    {
        public Record() { } //无参构造函数


        #region Model 
        private int _R_Id;
        private int _P_Id;
        private int _R_Room;
        private int _R_Bed;
        private DateTime _R_Enter;
        private DateTime _R_Out;
        private string _R_State;
        private int _U_Id;
        private string _R_No;

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
        public int P_Id
        {
            set { _P_Id = value; }
            get { return _P_Id; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int R_Room
        {
            set { _R_Room = value; }
            get { return _R_Room; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int R_Bed
        {
            set { _R_Bed = value; }
            get { return _R_Bed; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime R_Enter
        {
            set { _R_Enter = value; }
            get { return _R_Enter; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime R_Out
        {
            set { _R_Out = value; }
            get { return _R_Out; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string R_State
        {
            set { _R_State = value; }
            get { return _R_State; }
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
        public string R_No
        {
            set { _R_No = value; }
            get { return _R_No; }
        }

        #endregion 
    }
}