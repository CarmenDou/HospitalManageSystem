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
        /// ��� 
        ///</summary> 
        public static int AddRoles(Roles RolesModel)
        {
            return RolesDAL.AddRoles(RolesModel);
        }
        /// <summary> 
        /// ��������ɾ�� 
        ///</summary> 
        public static int DeleteRoles(int Id)
        {
            return RolesDAL.DeleteRoles(Id);
        }
        /// <summary> 
        /// ��ҳ 
        ///</summary> 
        public static List<Roles> PageSelectRoles(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return RolesDAL.PageSelectRoles(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// �޸� 
        ///</summary> 
        public static int UpdateRoles(Roles RolesModel)
        {
            return RolesDAL.UpdateRoles(RolesModel);
        }
        /// <summary> 
        /// ��ѯȫ��
        ///</summary>
        public static List<Roles> AllData(string NewWHere)
        {
            return RolesDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return RolesDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// ����������ѯʵ�� 
        ///</summary> 
        public static Roles GetIdByRoles(int Id)
        {
            return RolesDAL.GetIdByRoles(Id);
        }
    }
}