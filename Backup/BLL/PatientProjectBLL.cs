using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;
using System.Data;

namespace BLL
{
    public class PatientProjectBLL
    {
        /// <summary> 
        /// ��� 
        ///</summary> 
        public static int AddPatientProject(PatientProject PatientProjectModel)
        {
            return PatientProjectDAL.AddPatientProject(PatientProjectModel);
        }
        /// <summary> 
        /// ��������ɾ�� 
        ///</summary> 
        public static int DeletePatientProject(int Id)
        {
            return PatientProjectDAL.DeletePatientProject(Id);
        }
        /// <summary> 
        /// ��ҳ 
        ///</summary> 
        public static List<PatientProject> PageSelectPatientProject(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return PatientProjectDAL.PageSelectPatientProject(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// �޸� 
        ///</summary> 
        public static int UpdatePatientProject(PatientProject PatientProjectModel)
        {
            return PatientProjectDAL.UpdatePatientProject(PatientProjectModel);
        }
        /// <summary> 
        /// ��ѯȫ��
        ///</summary>
        public static List<PatientProject> AllData(string NewWHere)
        {
            return PatientProjectDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return PatientProjectDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// ����������ѯʵ�� 
        ///</summary> 
        public static PatientProject GetIdByPatientProject(int Id)
        {
            return PatientProjectDAL.GetIdByPatientProject(Id);
        }

        /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber2(string NewWHere)
        {
            return PatientProjectDAL.CountNumber2(NewWHere);
        }

        /// <summary> 
        /// ��ҳ 
        ///</summary> 
        public static DataTable PageSelectPatientProject2(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return PatientProjectDAL.PageSelectPatientProject2(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
    }
}