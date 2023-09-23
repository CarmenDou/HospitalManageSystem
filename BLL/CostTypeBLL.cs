using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class CostTypeBLL
    {
        /// <summary> 
        /// 添加 
        ///</summary> 
        public static int AddCostType(CostType CostTypeModel)
        {
            return CostTypeDAL.AddCostType(CostTypeModel);
        }
        /// <summary> 
        /// 根据主键删除 
        ///</summary> 
        public static int DeleteCostType(int Id)
        {
            return CostTypeDAL.DeleteCostType(Id);
        }
        /// <summary> 
        /// 分页 
        ///</summary> 
        public static List<CostType> PageSelectCostType(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return CostTypeDAL.PageSelectCostType(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// 修改 
        ///</summary> 
        public static int UpdateCostType(CostType CostTypeModel)
        {
            return CostTypeDAL.UpdateCostType(CostTypeModel);
        }
        /// <summary> 
        /// 查询全部
        ///</summary>
        public static List<CostType> AllData(string NewWHere)
        {
            return CostTypeDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return CostTypeDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// 根据主键查询实体 
        ///</summary> 
        public static CostType GetIdByCostType(int Id)
        {
            return CostTypeDAL.GetIdByCostType(Id);
        }
    }
}