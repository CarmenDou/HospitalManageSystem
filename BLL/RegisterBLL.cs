using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;
using System.Data;

namespace BLL
{
    public class RegisterBLL
    {
        /// <summary> 
        /// 添加 
        ///</summary> 
        public static int AddRegister(Register RegisterModel)
        {
            return RegisterDAL.AddRegister(RegisterModel);
        }
        /// <summary> 
        /// 根据主键删除 
        ///</summary> 
        public static int DeleteRegister(int Id)
        {
            return RegisterDAL.DeleteRegister(Id);
        }
        /// <summary> 
        /// 分页 
        ///</summary> 
        public static List<Register> PageSelectRegister(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return RegisterDAL.PageSelectRegister(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
          /// <summary>
        /// 分页 
        ///</summary> 
        public static DataTable PageSelectRegister2(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        { 
             pageIndex = pageIndex - 1;
             return RegisterDAL.PageSelectRegister2(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// 修改 
        ///</summary> 
        public static int UpdateRegister(Register RegisterModel)
        {
            return RegisterDAL.UpdateRegister(RegisterModel);
        }
        /// <summary> 
        /// 查询全部
        ///</summary>
        public static List<Register> AllData(string NewWHere)
        {
            return RegisterDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return RegisterDAL.CountNumber(NewWHere);
        }
        
        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber2(string NewWHere)
        {
            return RegisterDAL.CountNumber2(NewWHere);
        }
        /// <summary> 
        /// 根据主键查询实体 
        ///</summary> 
        public static Register GetIdByRegister(int Id)
        {
            return RegisterDAL.GetIdByRegister(Id);
        }
    }
}