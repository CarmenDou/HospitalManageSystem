using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class DrugBLL
    {
        /// <summary> 
        /// ��� 
        ///</summary> 
        public static int AddDrug(Drug DrugModel)
        {
            return DrugDAL.AddDrug(DrugModel);
        }
        /// <summary> 
        /// ��������ɾ�� 
        ///</summary> 
        public static int DeleteDrug(int Id)
        {
            return DrugDAL.DeleteDrug(Id);
        }
        /// <summary> 
        /// ��ҳ 
        ///</summary> 
        public static List<Drug> PageSelectDrug(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return DrugDAL.PageSelectDrug(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// �޸� 
        ///</summary> 
        public static int UpdateDrug(Drug DrugModel)
        {
            return DrugDAL.UpdateDrug(DrugModel);
        }
        /// <summary> 
        /// ��ѯȫ��
        ///</summary>
        public static List<Drug> AllData(string NewWHere)
        {
            return DrugDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return DrugDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// ����������ѯʵ�� 
        ///</summary> 
        public static Drug GetIdByDrug(int Id)
        {
            return DrugDAL.GetIdByDrug(Id);
        }
    }
}