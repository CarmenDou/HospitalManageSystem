using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class DrugTypeBLL
    {
        /// <summary> 
        /// ��� 
        ///</summary> 
        public static int AddDrugType(DrugType DrugTypeModel)
        {
            return DrugTypeDAL.AddDrugType(DrugTypeModel);
        }
        /// <summary> 
        /// ��������ɾ�� 
        ///</summary> 
        public static int DeleteDrugType(int Id)
        {
            return DrugTypeDAL.DeleteDrugType(Id);
        }
        /// <summary> 
        /// ��ҳ 
        ///</summary> 
        public static List<DrugType> PageSelectDrugType(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return DrugTypeDAL.PageSelectDrugType(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// �޸� 
        ///</summary> 
        public static int UpdateDrugType(DrugType DrugTypeModel)
        {
            return DrugTypeDAL.UpdateDrugType(DrugTypeModel);
        }
        /// <summary> 
        /// ��ѯȫ��
        ///</summary>
        public static List<DrugType> AllData(string NewWHere)
        {
            return DrugTypeDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return DrugTypeDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// ����������ѯʵ�� 
        ///</summary> 
        public static DrugType GetIdByDrugType(int Id)
        {
            return DrugTypeDAL.GetIdByDrugType(Id);
        }
    }
}