using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;
using System.Data;

namespace BLL
{
    public class CalculateBLL
    {
        /// <summary> 
        /// 添加 
        ///</summary> 
        public static int AddCalculate(Calculate CalculateModel)
        {
            return CalculateDAL.AddCalculate(CalculateModel);
        }
        /// <summary> 
        /// 根据主键删除 
        ///</summary> 
        public static int DeleteCalculate(int Id)
        {
            return CalculateDAL.DeleteCalculate(Id);
        }
        /// <summary> 
        /// 分页 
        ///</summary> 
        public static List<Calculate> PageSelectCalculate(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return CalculateDAL.PageSelectCalculate(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }


        /// <summary> 
        /// 分页 
        ///</summary> 
        public static DataTable PageSelectCalculate2(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return CalculateDAL.PageSelectCalculate2(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }

        /// <summary> 
        /// 修改 
        ///</summary> 
        public static int UpdateCalculate(Calculate CalculateModel)
        {
            return CalculateDAL.UpdateCalculate(CalculateModel);
        }
        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber2(string NewWHere)
        {
            return CalculateDAL.CountNumber2(NewWHere);
        }
        /// <summary> 
        /// 查询全部
        ///</summary>
        public static List<Calculate> AllData(string NewWHere)
        {
            return CalculateDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return CalculateDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// 根据主键查询实体 
        ///</summary> 
        public static Calculate GetIdByCalculate(int Id)
        {
            return CalculateDAL.GetIdByCalculate(Id);
        }
    }
}