using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class AuthorityBLL
    {
        /// <summary> 
        /// 添加 
        ///</summary> 
        public static int AddAuthority(Authority AuthorityModel)
        {
            return AuthorityDAL.AddAuthority(AuthorityModel);
        }
        /// <summary> 
        /// 根据主键删除 
        ///</summary> 
        public static int DeleteAuthority(int Id)
        {
            return AuthorityDAL.DeleteAuthority(Id);
        }
        /// <summary> 
        /// 分页 
        ///</summary> 
        public static List<Authority> PageSelectAuthority(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return AuthorityDAL.PageSelectAuthority(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// 修改 
        ///</summary> 
        public static int UpdateAuthority(Authority AuthorityModel)
        {
            return AuthorityDAL.UpdateAuthority(AuthorityModel);
        }
        /// <summary> 
        /// 查询全部
        ///</summary>
        public static List<Authority> AllData(string NewWHere)
        {
            return AuthorityDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return AuthorityDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// 根据主键查询实体 
        ///</summary> 
        public static Authority GetIdByAuthority(int Id)
        {
            return AuthorityDAL.GetIdByAuthority(Id);
        }

        /// <summary> 
        /// 根据RoleId删除 
        ///</summary>
        public static int DeleteAuthorityByRoleId(int RoleId)
        {
            return AuthorityDAL.DeleteAuthorityByRoleId(RoleId);
        }


        /// <summary>
        /// roleId角色是否存在funcUnitId权限
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="funcUnitId"></param>
        /// <returns></returns>
        public static bool RoleIsExistModuleId(int RoleId, int ModuleId)
        {

            if (AuthorityDAL.RoleIsExistModuleId(RoleId, ModuleId) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}