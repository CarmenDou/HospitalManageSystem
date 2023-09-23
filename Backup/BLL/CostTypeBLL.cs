using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class CostTypeBLL
    {
        /// <summary> 
        /// ��� 
        ///</summary> 
        public static int AddCostType(CostType CostTypeModel)
        {
            return CostTypeDAL.AddCostType(CostTypeModel);
        }
        /// <summary> 
        /// ��������ɾ�� 
        ///</summary> 
        public static int DeleteCostType(int Id)
        {
            return CostTypeDAL.DeleteCostType(Id);
        }
        /// <summary> 
        /// ��ҳ 
        ///</summary> 
        public static List<CostType> PageSelectCostType(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return CostTypeDAL.PageSelectCostType(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// �޸� 
        ///</summary> 
        public static int UpdateCostType(CostType CostTypeModel)
        {
            return CostTypeDAL.UpdateCostType(CostTypeModel);
        }
        /// <summary> 
        /// ��ѯȫ��
        ///</summary>
        public static List<CostType> AllData(string NewWHere)
        {
            return CostTypeDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return CostTypeDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// ����������ѯʵ�� 
        ///</summary> 
        public static CostType GetIdByCostType(int Id)
        {
            return CostTypeDAL.GetIdByCostType(Id);
        }
    }
}