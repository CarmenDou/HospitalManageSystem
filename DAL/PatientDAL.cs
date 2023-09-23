using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class PatientDAL
    {


        /// <summary>
        /// ��� 
        ///</summary>
        public static int AddPatient(Patient PatientModel)
        {
            string sql = string.Format("insert into  Patient (P_No,P_Name,P_Sex,P_Age,P_Phone )values('{0}','{1}','{2}',{3},'{4}')",PatientModel.P_No,PatientModel.P_Name,PatientModel.P_Sex,PatientModel.P_Age,PatientModel.P_Phone);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// ����ID�޸� 
        ///</summary>
        public static int UpdatePatient(Patient PatientModel)
        {
            string sql = string.Format(" UPDATE Patient  set P_No='{0}',P_Name='{1}',P_Sex='{2}',P_Age={3},P_Phone='{4}' where P_Id={5} ",PatientModel.P_No,PatientModel.P_Name,PatientModel.P_Sex,PatientModel.P_Age,PatientModel.P_Phone  ,PatientModel.P_Id);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// ��������ɾ�� 
        ///</summary>
        public static int DeletePatient(int Id)
        {
            string sql = string.Format("delete from Patient where P_Id={0}", Id);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
                sql = "select count(*) from Patient where 1=1 " + NewWHere;
            }
            else
            {
                sql = "select count(*) from Patient";

            }
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary>
        /// ��ҳ 
        ///</summary> 
        public static List<Patient> PageSelectPatient(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            List<Patient> list = new List<Patient>(); 
	    string sql = string.Format("SELECT top {0} * FROM Patient where P_Id not in( select top {1} P_Id from Patient where 1=1 {2} order by {3} {4}) and 1=1 {2} order by {3} {4} ",pageSize, pageSize*pageIndex,WhereSrc, PXzd,PXType);
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                list = GetList(table);
            }
            return list;
        }

        /// <summary> 
        /// ����������ѯʵ�� 
        ///</summary>
        public static Patient GetIdByPatient(int Id)
        {
            string sql = string.Format("SELECT * FROM Patient where P_Id={0} ",Id);
            Patient PatientModel = new Patient();
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                PatientModel= GetMode(table);
            }
            return PatientModel;
        }
        /// <summary>
        /// ��ѯȫ��
        /// </summary>
        public static List<Patient> AllData(string NewWHere)
        {
            List<Patient> list = new List<Patient>();

             string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
               sql = "select * from Patient where 1=1 "+NewWHere;
            }
            else
            {
               sql = "select * from Patient";
            }
            using (DataTable table = DBHelper.GetDataSet(sql))
            {

                list = GetList(table);
            }
            return list;
        }
        /// <summary> 
        /// ˽�з��� 
        ///</summary>
        private static List<Patient> GetList(DataTable table)
        {
            List<Patient> list = new List<Patient>();
            foreach (DataRow row in table.Rows)
            {
                Patient PatientModel = new Patient(); 
                PatientModel.P_Id = Convert.ToInt32(row["P_Id"]); 
                PatientModel.P_No = Convert.ToString(row["P_No"]); 
                PatientModel.P_Name = Convert.ToString(row["P_Name"]); 
                PatientModel.P_Sex = Convert.ToString(row["P_Sex"]); 
                PatientModel.P_Age = Convert.ToInt32(row["P_Age"]); 
                PatientModel.P_Phone = Convert.ToString(row["P_Phone"]); 
                list.Add(PatientModel);

            }
            return list;
        }
        /// <summary> 
        /// ˽�з��� 
        ///</summary>
        private static Patient GetMode(DataTable table)
        {
            Patient PatientModel = new Patient();
            foreach (DataRow row in table.Rows)
            {
                PatientModel.P_Id = Convert.ToInt32(row["P_Id"]); 
                PatientModel.P_No = Convert.ToString(row["P_No"]); 
                PatientModel.P_Name = Convert.ToString(row["P_Name"]); 
                PatientModel.P_Sex = Convert.ToString(row["P_Sex"]); 
                PatientModel.P_Age = Convert.ToInt32(row["P_Age"]); 
                PatientModel.P_Phone = Convert.ToString(row["P_Phone"]); 

            }
            return PatientModel;
        }
    }
}