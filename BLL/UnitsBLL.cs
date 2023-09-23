using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class UnitsBLL
    {
        /// <summary> 
        /// ��� 
        ///</summary> 
        public static int AddUnits(Units UnitsModel)
        {
            return UnitsDAL.AddUnits(UnitsModel);
        }
        /// <summary> 
        /// ��������ɾ�� 
        ///</summary> 
        public static int DeleteUnits(int Id)
        {
            return UnitsDAL.DeleteUnits(Id);
        }
        /// <summary> 
        /// ��ҳ 
        ///</summary> 
        public static List<Units> PageSelectUnits(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return UnitsDAL.PageSelectUnits(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// �޸� 
        ///</summary> 
        public static int UpdateUnits(Units UnitsModel)
        {
            return UnitsDAL.UpdateUnits(UnitsModel);
        }
        /// <summary> 
        /// ��ѯȫ��
        ///</summary>
        public static List<Units> AllData(string NewWHere)
        {
            return UnitsDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return UnitsDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// ����������ѯʵ�� 
        ///</summary> 
        public static Units GetIdByUnits(int Id)
        {
            return UnitsDAL.GetIdByUnits(Id);
        }
    }
}