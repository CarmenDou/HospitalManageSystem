using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class RegisterDAL
    {


        /// <summary>
        /// 添加 
        ///</summary>
        public static int AddRegister(Register RegisterModel)
        {
            string sql = string.Format("insert into  Register (R_No,R_Name,D_Id,Rt_Id,R_Cost,U_Id )values('{0}','{1}',{2},{3},{4},{5})",RegisterModel.R_No,RegisterModel.R_Name,RegisterModel.D_Id,RegisterModel.Rt_Id,RegisterModel.R_Cost,RegisterModel.U_Id);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据ID修改 
        ///</summary>
        public static int UpdateRegister(Register RegisterModel)
        {
            string sql = string.Format(" UPDATE Register  set R_No='{0}',R_Name='{1}',D_Id={2},Rt_Id={3},R_Cost={4},U_Id={5} where R_Id={6} ",RegisterModel.R_No,RegisterModel.R_Name,RegisterModel.D_Id,RegisterModel.Rt_Id,RegisterModel.R_Cost,RegisterModel.U_Id  ,RegisterModel.R_Id);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据主键删除 
        ///</summary>
        public static int DeleteRegister(int Id)
        {
            string sql = string.Format("delete from Register where R_Id={0}", Id);
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
                sql = "select count(*) from Register where 1=1 " + NewWHere;
            }
            else
            {
                sql = "select count(*) from Register";

            }
            return DBHelper.GetIntScalar(sql);
        }


        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber2(string NewWHere)
        {
            string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
                sql = @"select count(*) from Register INNER JOIN
           Users ON Register.U_Id = Users.U_Id where 1=1 " + NewWHere;
            }
            else
            {
                sql = @"select count(*) from  Register INNER JOIN
           Users ON Register.U_Id = Users.U_Id";

            }
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary>
        /// 分页 
        ///</summary> 
        public static List<Register> PageSelectRegister(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            List<Register> list = new List<Register>(); 
	    string sql = string.Format("SELECT top {0} * FROM Register where R_Id not in( select top {1} R_Id from Register where 1=1 {2} order by {3} {4}) and 1=1 {2} order by {3} {4} ",pageSize, pageSize*pageIndex,WhereSrc, PXzd,PXType);
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                list = GetList(table);
            }
            return list;
        }
        /// <summary>
        /// 分页 
        ///</summary> 
        public static DataTable PageSelectRegister2(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {

            string sql = string.Format(@"SELECT top {0} * FROM Register INNER JOIN
           Users ON Register.U_Id = Users.U_Id where Register.R_Id not in( select top {1} Register.R_Id from Register INNER JOIN
           Users ON Register.U_Id = Users.U_Id where 1=1 {2} order by {3} {4}) and 1=1 {2} order by {3} {4} ", pageSize, pageSize * pageIndex, WhereSrc, PXzd, PXType);
            
            return DBHelper.GetDataSet(sql);
        }

        /// <summary> 
        /// 根据主键查询实体 
        ///</summary>
        public static Register GetIdByRegister(int Id)
        {
            string sql = string.Format("SELECT * FROM Register where R_Id={0} ",Id);
            Register RegisterModel = new Register();
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                RegisterModel= GetMode(table);
            }
            return RegisterModel;
        }
        /// <summary>
        /// 查询全部
        /// </summary>
        public static List<Register> AllData(string NewWHere)
        {
            List<Register> list = new List<Register>();

             string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
               sql = "select * from Register where 1=1 "+NewWHere;
            }
            else
            {
               sql = "select * from Register";
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
        private static List<Register> GetList(DataTable table)
        {
            List<Register> list = new List<Register>();
            foreach (DataRow row in table.Rows)
            {
                Register RegisterModel = new Register(); 
                RegisterModel.R_Id = Convert.ToInt32(row["R_Id"]);
                RegisterModel.R_No = Convert.ToString(row["R_No"]);  
                RegisterModel.R_Name = Convert.ToString(row["R_Name"]); 
                RegisterModel.D_Id = Convert.ToInt32(row["D_Id"]); 
                RegisterModel.Rt_Id = Convert.ToInt32(row["Rt_Id"]); 
                RegisterModel.R_Cost = Convert.ToDecimal(row["R_Cost"]); 
                RegisterModel.U_Id = Convert.ToInt32(row["U_Id"]); 
                list.Add(RegisterModel);

            }
            return list;
        }
        /// <summary> 
        /// 私有方法 
        ///</summary>
        private static Register GetMode(DataTable table)
        {
            Register RegisterModel = new Register();
            foreach (DataRow row in table.Rows)
            {
                RegisterModel.R_Id = Convert.ToInt32(row["R_Id"]);
                RegisterModel.R_No = Convert.ToString(row["R_No"]); 
                RegisterModel.R_Name = Convert.ToString(row["R_Name"]); 
                RegisterModel.D_Id = Convert.ToInt32(row["D_Id"]); 
                RegisterModel.Rt_Id = Convert.ToInt32(row["Rt_Id"]); 
                RegisterModel.R_Cost = Convert.ToDecimal(row["R_Cost"]); 
                RegisterModel.U_Id = Convert.ToInt32(row["U_Id"]); 

            }
            return RegisterModel;
        }
    }
}