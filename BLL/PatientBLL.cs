using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class PatientBLL
    {
        /// <summary> 
        /// 添加 
        ///</summary> 
        public static int AddPatient(Patient PatientModel)
        {
            return PatientDAL.AddPatient(PatientModel);
        }
        /// <summary> 
        /// 根据主键删除 
        ///</summary> 
        public static int DeletePatient(int Id)
        {
            return PatientDAL.DeletePatient(Id);
        }
        /// <summary> 
        /// 分页 
        ///</summary> 
        public static List<Patient> PageSelectPatient(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return PatientDAL.PageSelectPatient(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// 修改 
        ///</summary> 
        public static int UpdatePatient(Patient PatientModel)
        {
            return PatientDAL.UpdatePatient(PatientModel);
        }
        /// <summary> 
        /// 查询全部
        ///</summary>
        public static List<Patient> AllData(string NewWHere)
        {
            return PatientDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return PatientDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// 根据主键查询实体 
        ///</summary> 
        public static Patient GetIdByPatient(int Id)
        {
            return PatientDAL.GetIdByPatient(Id);
        }
    }
}