using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class DrugTypeBLL
    {
        /// <summary> 
        /// 添加 
        ///</summary> 
        public static int AddDrugType(DrugType DrugTypeModel)
        {
            return DrugTypeDAL.AddDrugType(DrugTypeModel);
        }
        /// <summary> 
        /// 根据主键删除 
        ///</summary> 
        public static int DeleteDrugType(int Id)
        {
            return DrugTypeDAL.DeleteDrugType(Id);
        }
        /// <summary> 
        /// 分页 
        ///</summary> 
        public static List<DrugType> PageSelectDrugType(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return DrugTypeDAL.PageSelectDrugType(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// 修改 
        ///</summary> 
        public static int UpdateDrugType(DrugType DrugTypeModel)
        {
            return DrugTypeDAL.UpdateDrugType(DrugTypeModel);
        }
        /// <summary> 
        /// 查询全部
        ///</summary>
        public static List<DrugType> AllData(string NewWHere)
        {
            return DrugTypeDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return DrugTypeDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// 根据主键查询实体 
        ///</summary> 
        public static DrugType GetIdByDrugType(int Id)
        {
            return DrugTypeDAL.GetIdByDrugType(Id);
        }
    }
}