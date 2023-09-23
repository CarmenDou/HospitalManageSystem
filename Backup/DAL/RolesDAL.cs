using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class RolesDAL
    {


        /// <summary>
        /// 添加 
        ///</summary>
        public static int AddRoles(Roles RolesModel)
        {
            string sql = string.Format("insert into  Roles (R_Name )values('{0}')",RolesModel.R_Name);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据ID修改 
        ///</summary>
        public static int UpdateRoles(Roles RolesModel)
        {
            string sql = string.Format(" UPDATE Roles  set R_Name='{0}' where R_Id={1} ",RolesModel.R_Name  ,RolesModel.R_Id);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据主键删除 
        ///</summary>
        public static int DeleteRoles(int Id)
        {
            string sql = string.Format("delete from Roles where R_Id={0}", Id);
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
                sql = "select count(*) from Roles where 1=1 " + NewWHere;
            }
            else
            {
                sql = "select count(*) from Roles";

            }
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary>
        /// 分页 
        ///</summary> 
        public static List<Roles> PageSelectRoles(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            List<Roles> list = new List<Roles>(); 
	    string sql = string.Format("SELECT top {0} * FROM Roles where R_Id not in( select top {1} R_Id from Roles where 1=1 {2} order by {3} {4}) and 1=1 {2} order by {3} {4} ",pageSize, pageSize*pageIndex,WhereSrc, PXzd,PXType);
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                list = GetList(table);
            }
            return list;
        }

        /// <summary> 
        /// 根据主键查询实体 
        ///</summary>
        public static Roles GetIdByRoles(int Id)
        {
            string sql = string.Format("SELECT * FROM Roles where R_Id={0} ",Id);
            Roles RolesModel = new Roles();
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                RolesModel= GetMode(table);
            }
            return RolesModel;
        }
        /// <summary>
        /// 查询全部
        /// </summary>
        public static List<Roles> AllData(string NewWHere)
        {
            List<Roles> list = new List<Roles>();

             string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
               sql = "select * from Roles where 1=1 "+NewWHere;
            }
            else
            {
               sql = "select * from Roles";
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
        private static List<Roles> GetList(DataTable table)
        {
            List<Roles> list = new List<Roles>();
            foreach (DataRow row in table.Rows)
            {
                Roles RolesModel = new Roles(); 
                RolesModel.R_Id = Convert.ToInt32(row["R_Id"]); 
                RolesModel.R_Name = Convert.ToString(row["R_Name"]); 
                list.Add(RolesModel);

            }
            return list;
        }
        /// <summary> 
        /// 私有方法 
        ///</summary>
        private static Roles GetMode(DataTable table)
        {
            Roles RolesModel = new Roles();
            foreach (DataRow row in table.Rows)
            {
                RolesModel.R_Id = Convert.ToInt32(row["R_Id"]); 
                RolesModel.R_Name = Convert.ToString(row["R_Name"]); 

            }
            return RolesModel;
        }
    }
}