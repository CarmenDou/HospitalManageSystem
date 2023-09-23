using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class PatientProjectDAL
    {


        /// <summary>
        /// 添加 
        ///</summary>
        public static int AddPatientProject(PatientProject PatientProjectModel)
        {
            string sql = string.Format("insert into  PatientProject (Pp_Count,Pp_Price,Pp_Amount,P_Id,Cp_Id,Pp_Time,U_Id )values({0},{1},{2},{3},{4},'{5}',{6})",PatientProjectModel.Pp_Count,PatientProjectModel.Pp_Price,PatientProjectModel.Pp_Amount,PatientProjectModel.P_Id,PatientProjectModel.Cp_Id,PatientProjectModel.Pp_Time,PatientProjectModel.U_Id);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据ID修改 
        ///</summary>
        public static int UpdatePatientProject(PatientProject PatientProjectModel)
        {
            string sql = string.Format(" UPDATE PatientProject  set Pp_Count={0},Pp_Price={1},Pp_Amount={2},P_Id={3},Cp_Id={4},Pp_Time='{5}',U_Id={6} where Pp_Id={7} ",PatientProjectModel.Pp_Count,PatientProjectModel.Pp_Price,PatientProjectModel.Pp_Amount,PatientProjectModel.P_Id,PatientProjectModel.Cp_Id,PatientProjectModel.Pp_Time,PatientProjectModel.U_Id  ,PatientProjectModel.Pp_Id);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据主键删除 
        ///</summary>
        public static int DeletePatientProject(int Id)
        {
            string sql = string.Format("delete from PatientProject where Pp_Id={0}", Id);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
                sql = "select count(*) from PatientProject where 1=1 " + NewWHere;
            }
            else
            {
                sql = "select count(*) from PatientProject";

            }
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary>
        /// 分页 
        ///</summary> 
        public static List<PatientProject> PageSelectPatientProject(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            List<PatientProject> list = new List<PatientProject>(); 
	    string sql = string.Format("SELECT top {0} * FROM PatientProject where Pp_Id not in( select top {1} Pp_Id from PatientProject where 1=1 {2} order by {3} {4}) and 1=1 {2} order by {3} {4} ",pageSize, pageSize*pageIndex,WhereSrc, PXzd,PXType);
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                list = GetList(table);
            }
            return list;
        }


        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber2(string NewWHere)
        {
            string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
                sql = @"select count(*) from PatientProject INNER JOIN
       Patient ON PatientProject.P_Id = Patient.P_Id where 1=1 " + NewWHere;
            }
            else
            {
                sql = @"select count(*) from PatientProject INNER JOIN
       Patient ON PatientProject.P_Id = Patient.P_Id";

            }
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary>
        /// 分页 
        ///</summary> 
        public static DataTable PageSelectPatientProject2(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            string sql = string.Format(@"SELECT top {0} * FROM PatientProject INNER JOIN
       Patient ON PatientProject.P_Id = Patient.P_Id where Pp_Id not in( select top {1} Pp_Id from PatientProject INNER JOIN
       Patient ON PatientProject.P_Id = Patient.P_Id where 1=1 {2} order by {3} {4}) and 1=1 {2} order by {3} {4} ", pageSize, pageSize * pageIndex, WhereSrc, PXzd, PXType);

            return DBHelper.GetDataSet(sql);
        }


        /// <summary> 
        /// 根据主键查询实体 
        ///</summary>
        public static PatientProject GetIdByPatientProject(int Id)
        {
            string sql = string.Format("SELECT * FROM PatientProject where Pp_Id={0} ",Id);
            PatientProject PatientProjectModel = new PatientProject();
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                PatientProjectModel= GetMode(table);
            }
            return PatientProjectModel;
        }
        /// <summary>
        /// 查询全部
        /// </summary>
        public static List<PatientProject> AllData(string NewWHere)
        {
            List<PatientProject> list = new List<PatientProject>();

             string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
               sql = "select * from PatientProject where 1=1 "+NewWHere;
            }
            else
            {
               sql = "select * from PatientProject";
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
        private static List<PatientProject> GetList(DataTable table)
        {
            List<PatientProject> list = new List<PatientProject>();
            foreach (DataRow row in table.Rows)
            {
                PatientProject PatientProjectModel = new PatientProject(); 
                PatientProjectModel.Pp_Id = Convert.ToInt32(row["Pp_Id"]); 
                PatientProjectModel.Pp_Count = Convert.ToInt32(row["Pp_Count"]); 
                PatientProjectModel.Pp_Price = Convert.ToDecimal(row["Pp_Price"]); 
                PatientProjectModel.Pp_Amount = Convert.ToDecimal(row["Pp_Amount"]); 
                PatientProjectModel.P_Id = Convert.ToInt32(row["P_Id"]); 
                PatientProjectModel.Cp_Id = Convert.ToInt32(row["Cp_Id"]); 
                PatientProjectModel.Pp_Time = Convert.ToDateTime(row["Pp_Time"]); 
                PatientProjectModel.U_Id = Convert.ToInt32(row["U_Id"]); 
                list.Add(PatientProjectModel);

            }
            return list;
        }
        /// <summary> 
        /// 私有方法 
        ///</summary>
        private static PatientProject GetMode(DataTable table)
        {
            PatientProject PatientProjectModel = new PatientProject();
            foreach (DataRow row in table.Rows)
            {
                PatientProjectModel.Pp_Id = Convert.ToInt32(row["Pp_Id"]); 
                PatientProjectModel.Pp_Count = Convert.ToInt32(row["Pp_Count"]); 
                PatientProjectModel.Pp_Price = Convert.ToDecimal(row["Pp_Price"]); 
                PatientProjectModel.Pp_Amount = Convert.ToDecimal(row["Pp_Amount"]); 
                PatientProjectModel.P_Id = Convert.ToInt32(row["P_Id"]); 
                PatientProjectModel.Cp_Id = Convert.ToInt32(row["Cp_Id"]); 
                PatientProjectModel.Pp_Time = Convert.ToDateTime(row["Pp_Time"]); 
                PatientProjectModel.U_Id = Convert.ToInt32(row["U_Id"]); 

            }
            return PatientProjectModel;
        }
    }
}