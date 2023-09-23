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
        /// ��� 
        ///</summary> 
        public static int AddAuthority(Authority AuthorityModel)
        {
            return AuthorityDAL.AddAuthority(AuthorityModel);
        }
        /// <summary> 
        /// ��������ɾ�� 
        ///</summary> 
        public static int DeleteAuthority(int Id)
        {
            return AuthorityDAL.DeleteAuthority(Id);
        }
        /// <summary> 
        /// ��ҳ 
        ///</summary> 
        public static List<Authority> PageSelectAuthority(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return AuthorityDAL.PageSelectAuthority(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// �޸� 
        ///</summary> 
        public static int UpdateAuthority(Authority AuthorityModel)
        {
            return AuthorityDAL.UpdateAuthority(AuthorityModel);
        }
        /// <summary> 
        /// ��ѯȫ��
        ///</summary>
        public static List<Authority> AllData(string NewWHere)
        {
            return AuthorityDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return AuthorityDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// ����������ѯʵ�� 
        ///</summary> 
        public static Authority GetIdByAuthority(int Id)
        {
            return AuthorityDAL.GetIdByAuthority(Id);
        }

        /// <summary> 
        /// ����RoleIdɾ�� 
        ///</summary>
        public static int DeleteAuthorityByRoleId(int RoleId)
        {
            return AuthorityDAL.DeleteAuthorityByRoleId(RoleId);
        }


        /// <summary>
        /// roleId��ɫ�Ƿ����funcUnitIdȨ��
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