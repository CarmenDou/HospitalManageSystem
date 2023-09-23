using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class DrugBLL
    {
        /// <summary> 
        /// 添加 
        ///</summary> 
        public static int AddDrug(Drug DrugModel)
        {
            return DrugDAL.AddDrug(DrugModel);
        }
        /// <summary> 
        /// 根据主键删除 
        ///</summary> 
        public static int DeleteDrug(int Id)
        {
            return DrugDAL.DeleteDrug(Id);
        }
        /// <summary> 
        /// 分页 
        ///</summary> 
        public static List<Drug> PageSelectDrug(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return DrugDAL.PageSelectDrug(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// 修改 
        ///</summary> 
        public static int UpdateDrug(Drug DrugModel)
        {
            return DrugDAL.UpdateDrug(DrugModel);
        }
        /// <summary> 
        /// 查询全部
        ///</summary>
        public static List<Drug> AllData(string NewWHere)
        {
            return DrugDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return DrugDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// 根据主键查询实体 
        ///</summary> 
        public static Drug GetIdByDrug(int Id)
        {
            return DrugDAL.GetIdByDrug(Id);
        }
    }
}