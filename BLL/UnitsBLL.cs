using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class UnitsBLL
    {
        /// <summary> 
        /// 添加 
        ///</summary> 
        public static int AddUnits(Units UnitsModel)
        {
            return UnitsDAL.AddUnits(UnitsModel);
        }
        /// <summary> 
        /// 根据主键删除 
        ///</summary> 
        public static int DeleteUnits(int Id)
        {
            return UnitsDAL.DeleteUnits(Id);
        }
        /// <summary> 
        /// 分页 
        ///</summary> 
        public static List<Units> PageSelectUnits(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return UnitsDAL.PageSelectUnits(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// 修改 
        ///</summary> 
        public static int UpdateUnits(Units UnitsModel)
        {
            return UnitsDAL.UpdateUnits(UnitsModel);
        }
        /// <summary> 
        /// 查询全部
        ///</summary>
        public static List<Units> AllData(string NewWHere)
        {
            return UnitsDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return UnitsDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// 根据主键查询实体 
        ///</summary> 
        public static Units GetIdByUnits(int Id)
        {
            return UnitsDAL.GetIdByUnits(Id);
        }
    }
}