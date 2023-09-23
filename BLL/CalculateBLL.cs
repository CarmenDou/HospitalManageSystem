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
        /// ��� 
        ///</summary> 
        public static int AddCalculate(Calculate CalculateModel)
        {
            return CalculateDAL.AddCalculate(CalculateModel);
        }
        /// <summary> 
        /// ��������ɾ�� 
        ///</summary> 
        public static int DeleteCalculate(int Id)
        {
            return CalculateDAL.DeleteCalculate(Id);
        }
        /// <summary> 
        /// ��ҳ 
        ///</summary> 
        public static List<Calculate> PageSelectCalculate(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return CalculateDAL.PageSelectCalculate(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }


        /// <summary> 
        /// ��ҳ 
        ///</summary> 
        public static DataTable PageSelectCalculate2(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return CalculateDAL.PageSelectCalculate2(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }

        /// <summary> 
        /// �޸� 
        ///</summary> 
        public static int UpdateCalculate(Calculate CalculateModel)
        {
            return CalculateDAL.UpdateCalculate(CalculateModel);
        }
        /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber2(string NewWHere)
        {
            return CalculateDAL.CountNumber2(NewWHere);
        }
        /// <summary> 
        /// ��ѯȫ��
        ///</summary>
        public static List<Calculate> AllData(string NewWHere)
        {
            return CalculateDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return CalculateDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// ����������ѯʵ�� 
        ///</summary> 
        public static Calculate GetIdByCalculate(int Id)
        {
            return CalculateDAL.GetIdByCalculate(Id);
        }
    }
}