using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class CalculateDetailBLL
    {
        /// <summary> 
        /// 添加 
        ///</summary> 
        public static int AddCalculateDetail(CalculateDetail CalculateDetailModel)
        {
            return CalculateDetailDAL.AddCalculateDetail(CalculateDetailModel);
        }
        /// <summary> 
        /// 根据主键删除 
        ///</summary> 
        public static int DeleteCalculateDetail(int Id)
        {
            return CalculateDetailDAL.DeleteCalculateDetail(Id);
        }
        /// <summary> 
        /// 分页 
        ///</summary> 
        public static List<CalculateDetail> PageSelectCalculateDetail(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return CalculateDetailDAL.PageSelectCalculateDetail(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// 修改 
        ///</summary> 
        public static int UpdateCalculateDetail(CalculateDetail CalculateDetailModel)
        {
            return CalculateDetailDAL.UpdateCalculateDetail(CalculateDetailModel);
        }
        /// <summary> 
        /// 查询全部
        ///</summary>
        public static List<CalculateDetail> AllData(string NewWHere)
        {
            return CalculateDetailDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return CalculateDetailDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// 根据主键查询实体 
        ///</summary> 
        public static CalculateDetail GetIdByCalculateDetail(int Id)
        {
            return CalculateDetailDAL.GetIdByCalculateDetail(Id);
        }
    }
}