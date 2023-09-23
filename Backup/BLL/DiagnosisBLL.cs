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
        /// 添加 
        ///</summary> 
        public static int AddDiagnosis(Diagnosis DiagnosisModel)
        {
            return DiagnosisDAL.AddDiagnosis(DiagnosisModel);
        }
        /// <summary> 
        /// 根据主键删除 
        ///</summary> 
        public static int DeleteDiagnosis(int Id)
        {
            return DiagnosisDAL.DeleteDiagnosis(Id);
        }
        /// <summary> 
        /// 分页 
        ///</summary> 
        public static List<Diagnosis> PageSelectDiagnosis(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return DiagnosisDAL.PageSelectDiagnosis(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// 修改 
        ///</summary> 
        public static int UpdateDiagnosis(Diagnosis DiagnosisModel)
        {
            return DiagnosisDAL.UpdateDiagnosis(DiagnosisModel);
        }
        /// <summary> 
        /// 查询全部
        ///</summary>
        public static List<Diagnosis> AllData(string NewWHere)
        {
            return DiagnosisDAL.AllData(NewWHere);
        }
         /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber2(string NewWHere)
        {
            return DiagnosisDAL.CountNumber2(NewWHere);
        }
           /// <summary>
        /// 分页 
        ///</summary> 
        public static DataTable PageSelectDiagnosis2(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return DiagnosisDAL.PageSelectDiagnosis2(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return DiagnosisDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// 根据主键查询实体 
        ///</summary> 
        public static Diagnosis GetIdByDiagnosis(int Id)
        {
            return DiagnosisDAL.GetIdByDiagnosis(Id);
        }
    }
}