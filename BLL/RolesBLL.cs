using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class RolesBLL
    {
        /// <summary> 
        /// 添加 
        ///</summary> 
        public static int AddRoles(Roles RolesModel)
        {
            return RolesDAL.AddRoles(RolesModel);
        }
        /// <summary> 
        /// 根据主键删除 
        ///</summary> 
        public static int DeleteRoles(int Id)
        {
            return RolesDAL.DeleteRoles(Id);
        }
        /// <summary> 
        /// 分页 
        ///</summary> 
        public static List<Roles> PageSelectRoles(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return RolesDAL.PageSelectRoles(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// 修改 
        ///</summary> 
        public static int UpdateRoles(Roles RolesModel)
        {
            return RolesDAL.UpdateRoles(RolesModel);
        }
        /// <summary> 
        /// 查询全部
        ///</summary>
        public static List<Roles> AllData(string NewWHere)
        {
            return RolesDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return RolesDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// 根据主键查询实体 
        ///</summary> 
        public static Roles GetIdByRoles(int Id)
        {
            return RolesDAL.GetIdByRoles(Id);
        }
    }
}