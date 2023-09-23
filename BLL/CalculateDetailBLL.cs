using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class CalculateDetailBLL
    {
        /// <summary> 
        /// ��� 
        ///</summary> 
        public static int AddCalculateDetail(CalculateDetail CalculateDetailModel)
        {
            return CalculateDetailDAL.AddCalculateDetail(CalculateDetailModel);
        }
        /// <summary> 
        /// ��������ɾ�� 
        ///</summary> 
        public static int DeleteCalculateDetail(int Id)
        {
            return CalculateDetailDAL.DeleteCalculateDetail(Id);
        }
        /// <summary> 
        /// ��ҳ 
        ///</summary> 
        public static List<CalculateDetail> PageSelectCalculateDetail(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return CalculateDetailDAL.PageSelectCalculateDetail(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// �޸� 
        ///</summary> 
        public static int UpdateCalculateDetail(CalculateDetail CalculateDetailModel)
        {
            return CalculateDetailDAL.UpdateCalculateDetail(CalculateDetailModel);
        }
        /// <summary> 
        /// ��ѯȫ��
        ///</summary>
        public static List<CalculateDetail> AllData(string NewWHere)
        {
            return CalculateDetailDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return CalculateDetailDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// ����������ѯʵ�� 
        ///</summary> 
        public static CalculateDetail GetIdByCalculateDetail(int Id)
        {
            return CalculateDetailDAL.GetIdByCalculateDetail(Id);
        }
    }
}