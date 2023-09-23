using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class Modules
    {
        public Modules() { } //无参构造函数


        #region Model 
        private int _M_Id;
        private string _M_SubName;
        private int _M_ParentId;
        private string _M_Url;

        /// <summary>
        /// 
        /// </summary>
        public int M_Id
        {
            set { _M_Id = value; }
            get { return _M_Id; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string M_SubName
        {
            set { _M_SubName = value; }
            get { return _M_SubName; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int M_ParentId
        {
            set { _M_ParentId = value; }
            get { return _M_ParentId; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string M_Url
        {
            set { _M_Url = value; }
            get { return _M_Url; }
        }

        #endregion 
    }
}