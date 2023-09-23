using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DepartmentDAL
    {


        /// <summary>
        /// 添加 
        ///</summary>
        public static int AddDepartment(Department DepartmentModel)
        {
            string sql = string.Format("insert into  Department (D_Name )values('{0}')",DepartmentModel.D_Name);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据ID修改 
        ///</summary>
        public static int UpdateDepartment(Department DepartmentModel)
        {
            string sql = string.Format(" UPDATE Department  set D_Name='{0}' where D_Id={1} ",DepartmentModel.D_Name  ,DepartmentModel.D_Id);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据主键删除 
        ///</summary>
        public static int DeleteDepartment(int Id)
        {
            string sql = string.Format("delete from Department where D_Id={0}", Id);
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
                sql = "select count(*) from Department where 1=1 " + NewWHere;
            }
            else
            {
                sql = "select count(*) from Department";

            }
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary>
        /// 分页 
        ///</summary> 
        public static List<Department> PageSelectDepartment(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            List<Department> list = new List<Department>(); 
	    string sql = string.Format("SELECT top {0} * FROM Department where D_Id not in( select top {1} D_Id from Department where 1=1 {2} order by {3} {4}) and 1=1 {2} order by {3} {4} ",pageSize, pageSize*pageIndex,WhereSrc, PXzd,PXType);
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                list = GetList(table);
            }
            return list;
        }

        /// <summary> 
        /// 根据主键查询实体 
        ///</summary>
        public static Department GetIdByDepartment(int Id)
        {
            string sql = string.Format("SELECT * FROM Department where D_Id={0} ",Id);
            Department DepartmentModel = new Department();
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                DepartmentModel= GetMode(table);
            }
            return DepartmentModel;
        }
        /// <summary>
        /// 查询全部
        /// </summary>
        public static List<Department> AllData(string NewWHere)
        {
            List<Department> list = new List<Department>();

             string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
               sql = "select * from Department where 1=1 "+NewWHere;
            }
            else
            {
               sql = "select * from Department";
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
        private static List<Department> GetList(DataTable table)
        {
            List<Department> list = new List<Department>();
            foreach (DataRow row in table.Rows)
            {
                Department DepartmentModel = new Department(); 
                DepartmentModel.D_Id = Convert.ToInt32(row["D_Id"]); 
                DepartmentModel.D_Name = Convert.ToString(row["D_Name"]); 
                list.Add(DepartmentModel);

            }
            return list;
        }
        /// <summary> 
        /// 私有方法 
        ///</summary>
        private static Department GetMode(DataTable table)
        {
            Department DepartmentModel = new Department();
            foreach (DataRow row in table.Rows)
            {
                DepartmentModel.D_Id = Convert.ToInt32(row["D_Id"]); 
                DepartmentModel.D_Name = Convert.ToString(row["D_Name"]); 

            }
            return DepartmentModel;
        }
    }
}