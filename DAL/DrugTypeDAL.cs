using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DrugTypeDAL
    {


        /// <summary>
        /// 添加 
        ///</summary>
        public static int AddDrugType(DrugType DrugTypeModel)
        {
            string sql = string.Format("insert into  DrugType (Dt_Name )values('{0}')",DrugTypeModel.Dt_Name);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据ID修改 
        ///</summary>
        public static int UpdateDrugType(DrugType DrugTypeModel)
        {
            string sql = string.Format(" UPDATE DrugType  set Dt_Name='{0}' where Dt_Id={1} ",DrugTypeModel.Dt_Name  ,DrugTypeModel.Dt_Id);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据主键删除 
        ///</summary>
        public static int DeleteDrugType(int Id)
        {
            string sql = string.Format("delete from DrugType where Dt_Id={0}", Id);
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
                sql = "select count(*) from DrugType where 1=1 " + NewWHere;
            }
            else
            {
                sql = "select count(*) from DrugType";

            }
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary>
        /// 分页 
        ///</summary> 
        public static List<DrugType> PageSelectDrugType(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            List<DrugType> list = new List<DrugType>(); 
	    string sql = string.Format("SELECT top {0} * FROM DrugType where Dt_Id not in( select top {1} Dt_Id from DrugType where 1=1 {2} order by {3} {4}) and 1=1 {2} order by {3} {4} ",pageSize, pageSize*pageIndex,WhereSrc, PXzd,PXType);
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                list = GetList(table);
            }
            return list;
        }

        /// <summary> 
        /// 根据主键查询实体 
        ///</summary>
        public static DrugType GetIdByDrugType(int Id)
        {
            string sql = string.Format("SELECT * FROM DrugType where Dt_Id={0} ",Id);
            DrugType DrugTypeModel = new DrugType();
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                DrugTypeModel= GetMode(table);
            }
            return DrugTypeModel;
        }
        /// <summary>
        /// 查询全部
        /// </summary>
        public static List<DrugType> AllData(string NewWHere)
        {
            List<DrugType> list = new List<DrugType>();

             string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
               sql = "select * from DrugType where 1=1 "+NewWHere;
            }
            else
            {
               sql = "select * from DrugType";
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
        private static List<DrugType> GetList(DataTable table)
        {
            List<DrugType> list = new List<DrugType>();
            foreach (DataRow row in table.Rows)
            {
                DrugType DrugTypeModel = new DrugType(); 
                DrugTypeModel.Dt_Id = Convert.ToInt32(row["Dt_Id"]); 
                DrugTypeModel.Dt_Name = Convert.ToString(row["Dt_Name"]); 
                list.Add(DrugTypeModel);

            }
            return list;
        }
        /// <summary> 
        /// 私有方法 
        ///</summary>
        private static DrugType GetMode(DataTable table)
        {
            DrugType DrugTypeModel = new DrugType();
            foreach (DataRow row in table.Rows)
            {
                DrugTypeModel.Dt_Id = Convert.ToInt32(row["Dt_Id"]); 
                DrugTypeModel.Dt_Name = Convert.ToString(row["Dt_Name"]); 

            }
            return DrugTypeModel;
        }
    }
}