using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class ModulesBLL
    {
        /// <summary> 
        /// 添加 
        ///</summary> 
        public static int AddModules(Modules ModulesModel)
        {
            return ModulesDAL.AddModules(ModulesModel);
        }
        /// <summary> 
        /// 根据主键删除 
        ///</summary> 
        public static int DeleteModules(int Id)
        {
            return ModulesDAL.DeleteModules(Id);
        }
        /// <summary> 
        /// 分页 
        ///</summary> 
        public static List<Modules> PageSelectModules(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return ModulesDAL.PageSelectModules(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// 修改 
        ///</summary> 
        public static int UpdateModules(Modules ModulesModel)
        {
            return ModulesDAL.UpdateModules(ModulesModel);
        }
        /// <summary> 
        /// 查询全部
        ///</summary>
        public static List<Modules> AllData(string NewWHere)
        {
            return ModulesDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return ModulesDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// 根据主键查询实体 
        ///</summary> 
        public static Modules GetIdByModules(int Id)
        {
            return ModulesDAL.GetIdByModules(Id);
        }
    }
}