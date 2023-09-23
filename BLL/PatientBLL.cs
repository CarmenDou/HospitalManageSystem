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
        /// ��� 
        ///</summary> 
        public static int AddPatient(Patient PatientModel)
        {
            return PatientDAL.AddPatient(PatientModel);
        }
        /// <summary> 
        /// ��������ɾ�� 
        ///</summary> 
        public static int DeletePatient(int Id)
        {
            return PatientDAL.DeletePatient(Id);
        }
        /// <summary> 
        /// ��ҳ 
        ///</summary> 
        public static List<Patient> PageSelectPatient(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return PatientDAL.PageSelectPatient(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// �޸� 
        ///</summary> 
        public static int UpdatePatient(Patient PatientModel)
        {
            return PatientDAL.UpdatePatient(PatientModel);
        }
        /// <summary> 
        /// ��ѯȫ��
        ///</summary>
        public static List<Patient> AllData(string NewWHere)
        {
            return PatientDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return PatientDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// ����������ѯʵ�� 
        ///</summary> 
        public static Patient GetIdByPatient(int Id)
        {
            return PatientDAL.GetIdByPatient(Id);
        }
    }
}