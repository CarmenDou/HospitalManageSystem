using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class ModulesBLL
    {
        /// <summary> 
        /// ��� 
        ///</summary> 
        public static int AddModules(Modules ModulesModel)
        {
            return ModulesDAL.AddModules(ModulesModel);
        }
        /// <summary> 
        /// ��������ɾ�� 
        ///</summary> 
        public static int DeleteModules(int Id)
        {
            return ModulesDAL.DeleteModules(Id);
        }
        /// <summary> 
        /// ��ҳ 
        ///</summary> 
        public static List<Modules> PageSelectModules(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return ModulesDAL.PageSelectModules(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// �޸� 
        ///</summary> 
        public static int UpdateModules(Modules ModulesModel)
        {
            return ModulesDAL.UpdateModules(ModulesModel);
        }
        /// <summary> 
        /// ��ѯȫ��
        ///</summary>
        public static List<Modules> AllData(string NewWHere)
        {
            return ModulesDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return ModulesDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// ����������ѯʵ�� 
        ///</summary> 
        public static Modules GetIdByModules(int Id)
        {
            return ModulesDAL.GetIdByModules(Id);
        }
    }
}