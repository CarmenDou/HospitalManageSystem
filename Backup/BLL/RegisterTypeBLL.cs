using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class RegisterTypeBLL
    {
        /// <summary> 
        /// 添加 
        ///</summary> 
        public static int AddRegisterType(RegisterType RegisterTypeModel)
        {
            return RegisterTypeDAL.AddRegisterType(RegisterTypeModel);
        }
        /// <summary> 
        /// 根据主键删除 
        ///</summary> 
        public static int DeleteRegisterType(int Id)
        {
            return RegisterTypeDAL.DeleteRegisterType(Id);
        }
        /// <summary> 
        /// 分页 
        ///</summary> 
        public static List<RegisterType> PageSelectRegisterType(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return RegisterTypeDAL.PageSelectRegisterType(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// 修改 
        ///</summary> 
        public static int UpdateRegisterType(RegisterType RegisterTypeModel)
        {
            return RegisterTypeDAL.UpdateRegisterType(RegisterTypeModel);
        }
        /// <summary> 
        /// 查询全部
        ///</summary>
        public static List<RegisterType> AllData(string NewWHere)
        {
            return RegisterTypeDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return RegisterTypeDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// 根据主键查询实体 
        ///</summary> 
        public static RegisterType GetIdByRegisterType(int Id)
        {
            return RegisterTypeDAL.GetIdByRegisterType(Id);
        }
    }
}