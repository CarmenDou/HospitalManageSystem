using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class CalculateDAL
    {


        /// <summary>
        /// 添加 
        ///</summary>
        public static int AddCalculate(Calculate CalculateModel)
        {
            string sql = string.Format("insert into  Calculate (C_No,P_Id,C_Amount,C_Time,U_Id )values('{0}',{1},{2},'{3}',{4}) select @@identity", CalculateModel.C_No, CalculateModel.P_Id, CalculateModel.C_Amount, CalculateModel.C_Time, CalculateModel.U_Id);
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary> 
        /// 根据ID修改 
        ///</summary>
        public static int UpdateCalculate(Calculate CalculateModel)
        {
            string sql = string.Format(" UPDATE Calculate  set C_No='{0}',P_Id={1},C_Amount={2},C_Time='{3}',U_Id={4} where C_Id={5} ",CalculateModel.C_No,CalculateModel.P_Id,CalculateModel.C_Amount,CalculateModel.C_Time,CalculateModel.U_Id  ,CalculateModel.C_Id);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据主键删除 
        ///</summary>
        public static int DeleteCalculate(int Id)
        {
            string sql = string.Format("delete from Calculate where C_Id={0}", Id);
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
                sql = "select count(*) from Calculate where 1=1 " + NewWHere;
            }
            else
            {
                sql = "select count(*) from Calculate";

            }
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary>
        /// 分页 
        ///</summary> 
        public static List<Calculate> PageSelectCalculate(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            List<Calculate> list = new List<Calculate>(); 
	    string sql = string.Format("SELECT top {0} * FROM Calculate where C_Id not in( select top {1} C_Id from Calculate where 1=1 {2} order by {3} {4}) and 1=1 {2} order by {3} {4} ",pageSize, pageSize*pageIndex,WhereSrc, PXzd,PXType);
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
                sql = @"select count(*) from Calculate INNER JOIN
       Patient ON Calculate.P_Id = Patient.P_Id where 1=1 " + NewWHere;
            }
            else
            {
                sql = @"select count(*) from Calculate INNER JOIN
       Patient ON Calculate.P_Id = Patient.P_Id";

            }
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary>
        /// 分页 
        ///</summary> 
        public static DataTable PageSelectCalculate2(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            string sql = string.Format(@"SELECT top {0} * FROM Calculate INNER JOIN
       Patient ON Calculate.P_Id = Patient.P_Id where C_Id not in( select top {1} C_Id from Calculate INNER JOIN
       Patient ON Calculate.P_Id = Patient.P_Id where 1=1 {2} order by {3} {4}) and 1=1 {2} order by {3} {4} ", pageSize, pageSize * pageIndex, WhereSrc, PXzd, PXType);

            return DBHelper.GetDataSet(sql);
        }


        /// <summary> 
        /// 根据主键查询实体 
        ///</summary>
        public static Calculate GetIdByCalculate(int Id)
        {
            string sql = string.Format("SELECT * FROM Calculate where C_Id={0} ",Id);
            Calculate CalculateModel = new Calculate();
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                CalculateModel= GetMode(table);
            }
            return CalculateModel;
        }
        /// <summary>
        /// 查询全部
        /// </summary>
        public static List<Calculate> AllData(string NewWHere)
        {
            List<Calculate> list = new List<Calculate>();

             string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
               sql = "select * from Calculate where 1=1 "+NewWHere;
            }
            else
            {
               sql = "select * from Calculate";
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
        private static List<Calculate> GetList(DataTable table)
        {
            List<Calculate> list = new List<Calculate>();
            foreach (DataRow row in table.Rows)
            {
                Calculate CalculateModel = new Calculate(); 
                CalculateModel.C_Id = Convert.ToInt32(row["C_Id"]); 
                CalculateModel.C_No = Convert.ToString(row["C_No"]); 
                CalculateModel.P_Id = Convert.ToInt32(row["P_Id"]); 
                CalculateModel.C_Amount = Convert.ToDecimal(row["C_Amount"]); 
                CalculateModel.C_Time = Convert.ToDateTime(row["C_Time"]); 
                CalculateModel.U_Id = Convert.ToInt32(row["U_Id"]); 
                list.Add(CalculateModel);

            }
            return list;
        }
        /// <summary> 
        /// 私有方法 
        ///</summary>
        private static Calculate GetMode(DataTable table)
        {
            Calculate CalculateModel = new Calculate();
            foreach (DataRow row in table.Rows)
            {
                CalculateModel.C_Id = Convert.ToInt32(row["C_Id"]); 
                CalculateModel.C_No = Convert.ToString(row["C_No"]); 
                CalculateModel.P_Id = Convert.ToInt32(row["P_Id"]); 
                CalculateModel.C_Amount = Convert.ToDecimal(row["C_Amount"]); 
                CalculateModel.C_Time = Convert.ToDateTime(row["C_Time"]); 
                CalculateModel.U_Id = Convert.ToInt32(row["U_Id"]); 

            }
            return CalculateModel;
        }
    }
}