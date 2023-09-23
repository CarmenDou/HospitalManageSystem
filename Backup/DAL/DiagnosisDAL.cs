using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DiagnosisDAL
    {


        /// <summary>
        /// 添加 
        ///</summary>
        public static int AddDiagnosis(Diagnosis DiagnosisModel)
        {
            string sql = string.Format("insert into  Diagnosis (D_No,P_Id,D_Describe,D_Prescription,D_Results,D_Time,U_Id )values('{0}',{1},'{2}','{3}','{4}','{5}',{6})",DiagnosisModel.D_No,DiagnosisModel.P_Id,DiagnosisModel.D_Describe,DiagnosisModel.D_Prescription,DiagnosisModel.D_Results,DiagnosisModel.D_Time,DiagnosisModel.U_Id);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据ID修改 
        ///</summary>
        public static int UpdateDiagnosis(Diagnosis DiagnosisModel)
        {
            string sql = string.Format(" UPDATE Diagnosis  set D_No='{0}',P_Id={1},D_Describe='{2}',D_Prescription='{3}',D_Results='{4}',D_Time='{5}',U_Id={6} where D_Id={7} ",DiagnosisModel.D_No,DiagnosisModel.P_Id,DiagnosisModel.D_Describe,DiagnosisModel.D_Prescription,DiagnosisModel.D_Results,DiagnosisModel.D_Time,DiagnosisModel.U_Id  ,DiagnosisModel.D_Id);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据主键删除 
        ///</summary>
        public static int DeleteDiagnosis(int Id)
        {
            string sql = string.Format("delete from Diagnosis where D_Id={0}", Id);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber2(string NewWHere)
        {
            string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
                sql = @"select count(*) from Diagnosis INNER JOIN
       Patient ON Diagnosis.P_Id = Patient.P_Id where 1=1 " + NewWHere;
            }
            else
            {
                sql = @"select count(*) from Diagnosis INNER JOIN
       Patient ON Diagnosis.P_Id = Patient.P_Id";

            }
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary>
        /// 分页 
        ///</summary> 
        public static DataTable PageSelectDiagnosis2(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            string sql = string.Format(@"SELECT top {0} * FROM Diagnosis INNER JOIN
       Patient ON Diagnosis.P_Id = Patient.P_Id where D_Id not in( select top {1} D_Id from Diagnosis INNER JOIN
       Patient ON Diagnosis.P_Id = Patient.P_Id where 1=1 {2} order by {3} {4}) and 1=1 {2} order by {3} {4} ", pageSize, pageSize * pageIndex, WhereSrc, PXzd, PXType);

            return DBHelper.GetDataSet(sql);
        }

        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
                sql = "select count(*) from Diagnosis where 1=1 " + NewWHere;
            }
            else
            {
                sql = "select count(*) from Diagnosis";

            }
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary>
        /// 分页 
        ///</summary> 
        public static List<Diagnosis> PageSelectDiagnosis(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            List<Diagnosis> list = new List<Diagnosis>(); 
	    string sql = string.Format("SELECT top {0} * FROM Diagnosis where D_Id not in( select top {1} D_Id from Diagnosis where 1=1 {2} order by {3} {4}) and 1=1 {2} order by {3} {4} ",pageSize, pageSize*pageIndex,WhereSrc, PXzd,PXType);
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                list = GetList(table);
            }
            return list;
        }

        /// <summary> 
        /// 根据主键查询实体 
        ///</summary>
        public static Diagnosis GetIdByDiagnosis(int Id)
        {
            string sql = string.Format("SELECT * FROM Diagnosis where D_Id={0} ",Id);
            Diagnosis DiagnosisModel = new Diagnosis();
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                DiagnosisModel= GetMode(table);
            }
            return DiagnosisModel;
        }
        /// <summary>
        /// 查询全部
        /// </summary>
        public static List<Diagnosis> AllData(string NewWHere)
        {
            List<Diagnosis> list = new List<Diagnosis>();

             string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
               sql = "select * from Diagnosis where 1=1 "+NewWHere;
            }
            else
            {
               sql = "select * from Diagnosis";
            }
            using (DataTable table = DBHelper.GetDataSet(sql))
            {

                list = GetList(table);
            }
            return list;
        }
        /// <summary> 
        /// 私有方法 
        ///</summary>
        private static List<Diagnosis> GetList(DataTable table)
        {
            List<Diagnosis> list = new List<Diagnosis>();
            foreach (DataRow row in table.Rows)
            {
                Diagnosis DiagnosisModel = new Diagnosis(); 
                DiagnosisModel.D_Id = Convert.ToInt32(row["D_Id"]); 
                DiagnosisModel.D_No = Convert.ToString(row["D_No"]); 
                DiagnosisModel.P_Id = Convert.ToInt32(row["P_Id"]); 
                DiagnosisModel.D_Describe = Convert.ToString(row["D_Describe"]); 
                DiagnosisModel.D_Prescription = Convert.ToString(row["D_Prescription"]); 
                DiagnosisModel.D_Results = Convert.ToString(row["D_Results"]); 
                DiagnosisModel.D_Time = Convert.ToDateTime(row["D_Time"]); 
                DiagnosisModel.U_Id = Convert.ToInt32(row["U_Id"]); 
                list.Add(DiagnosisModel);

            }
            return list;
        }
        /// <summary> 
        /// 私有方法 
        ///</summary>
        private static Diagnosis GetMode(DataTable table)
        {
            Diagnosis DiagnosisModel = new Diagnosis();
            foreach (DataRow row in table.Rows)
            {
                DiagnosisModel.D_Id = Convert.ToInt32(row["D_Id"]); 
                DiagnosisModel.D_No = Convert.ToString(row["D_No"]); 
                DiagnosisModel.P_Id = Convert.ToInt32(row["P_Id"]); 
                DiagnosisModel.D_Describe = Convert.ToString(row["D_Describe"]); 
                DiagnosisModel.D_Prescription = Convert.ToString(row["D_Prescription"]); 
                DiagnosisModel.D_Results = Convert.ToString(row["D_Results"]); 
                DiagnosisModel.D_Time = Convert.ToDateTime(row["D_Time"]); 
                DiagnosisModel.U_Id = Convert.ToInt32(row["U_Id"]); 

            }
            return DiagnosisModel;
        }
    }
}