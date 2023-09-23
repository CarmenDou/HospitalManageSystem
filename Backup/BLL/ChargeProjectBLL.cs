using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class ChargeProjectBLL
    {
        /// <summary> 
        /// 添加 
        ///</summary> 
        public static int AddChargeProject(ChargeProject ChargeProjectModel)
        {
            return ChargeProjectDAL.AddChargeProject(ChargeProjectModel);
        }
        /// <summary> 
        /// 根据主键删除 
        ///</summary> 
        public static int DeleteChargeProject(int Id)
        {
            return ChargeProjectDAL.DeleteChargeProject(Id);
        }
        /// <summary> 
        /// 分页 
        ///</summary> 
        public static List<ChargeProject> PageSelectChargeProject(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return ChargeProjectDAL.PageSelectChargeProject(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// 修改 
        ///</summary> 
        public static int UpdateChargeProject(ChargeProject ChargeProjectModel)
        {
            return ChargeProjectDAL.UpdateChargeProject(ChargeProjectModel);
        }
        /// <summary> 
        /// 查询全部
        ///</summary>
        public static List<ChargeProject> AllData(string NewWHere)
        {
            return ChargeProjectDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return ChargeProjectDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// 根据主键查询实体 
        ///</summary> 
        public static ChargeProject GetIdByChargeProject(int Id)
        {
            return ChargeProjectDAL.GetIdByChargeProject(Id);
        }
    }
}