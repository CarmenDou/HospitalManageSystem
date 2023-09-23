using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;
using System.Data;

namespace BLL
{
    public class DiagnosisBLL
    {
        /// <summary> 
        /// ��� 
        ///</summary> 
        public static int AddDiagnosis(Diagnosis DiagnosisModel)
        {
            return DiagnosisDAL.AddDiagnosis(DiagnosisModel);
        }
        /// <summary> 
        /// ��������ɾ�� 
        ///</summary> 
        public static int DeleteDiagnosis(int Id)
        {
            return DiagnosisDAL.DeleteDiagnosis(Id);
        }
        /// <summary> 
        /// ��ҳ 
        ///</summary> 
        public static List<Diagnosis> PageSelectDiagnosis(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return DiagnosisDAL.PageSelectDiagnosis(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// �޸� 
        ///</summary> 
        public static int UpdateDiagnosis(Diagnosis DiagnosisModel)
        {
            return DiagnosisDAL.UpdateDiagnosis(DiagnosisModel);
        }
        /// <summary> 
        /// ��ѯȫ��
        ///</summary>
        public static List<Diagnosis> AllData(string NewWHere)
        {
            return DiagnosisDAL.AllData(NewWHere);
        }
         /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber2(string NewWHere)
        {
            return DiagnosisDAL.CountNumber2(NewWHere);
        }
           /// <summary>
        /// ��ҳ 
        ///</summary> 
        public static DataTable PageSelectDiagnosis2(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return DiagnosisDAL.PageSelectDiagnosis2(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return DiagnosisDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// ����������ѯʵ�� 
        ///</summary> 
        public static Diagnosis GetIdByDiagnosis(int Id)
        {
            return DiagnosisDAL.GetIdByDiagnosis(Id);
        }
    }
}