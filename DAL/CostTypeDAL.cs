using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class CostTypeDAL
    {


        /// <summary>
        /// 添加 
        ///</summary>
        public static int AddCostType(CostType CostTypeModel)
        {
            string sql = string.Format("insert into  CostType (Ct_Name )values('{0}')",CostTypeModel.Ct_Name);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据ID修改 
        ///</summary>
        public static int UpdateCostType(CostType CostTypeModel)
        {
            string sql = string.Format(" UPDATE CostType  set Ct_Name='{0}' where Ct_Id={1} ",CostTypeModel.Ct_Name  ,CostTypeModel.Ct_Id);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据主键删除 
        ///</summary>
        public static int DeleteCostType(int Id)
        {
            string sql = string.Format("delete from CostType where Ct_Id={0}", Id);
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
                sql = "select count(*) from CostType where 1=1 " + NewWHere;
            }
            else
            {
                sql = "select count(*) from CostType";

            }
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary>
        /// 分页 
        ///</summary> 
        public static List<CostType> PageSelectCostType(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            List<CostType> list = new List<CostType>(); 
	    string sql = string.Format("SELECT top {0} * FROM CostType where Ct_Id not in( select top {1} Ct_Id from CostType where 1=1 {2} order by {3} {4}) and 1=1 {2} order by {3} {4} ",pageSize, pageSize*pageIndex,WhereSrc, PXzd,PXType);
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                list = GetList(table);
            }
            return list;
        }

        /// <summary> 
        /// 根据主键查询实体 
        ///</summary>
        public static CostType GetIdByCostType(int Id)
        {
            string sql = string.Format("SELECT * FROM CostType where Ct_Id={0} ",Id);
            CostType CostTypeModel = new CostType();
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                CostTypeModel= GetMode(table);
            }
            return CostTypeModel;
        }
        /// <summary>
        /// 查询全部
        /// </summary>
        public static List<CostType> AllData(string NewWHere)
        {
            List<CostType> list = new List<CostType>();

             string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
               sql = "select * from CostType where 1=1 "+NewWHere;
            }
            else
            {
               sql = "select * from CostType";
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
        private static List<CostType> GetList(DataTable table)
        {
            List<CostType> list = new List<CostType>();
            foreach (DataRow row in table.Rows)
            {
                CostType CostTypeModel = new CostType(); 
                CostTypeModel.Ct_Id = Convert.ToInt32(row["Ct_Id"]); 
                CostTypeModel.Ct_Name = Convert.ToString(row["Ct_Name"]); 
                list.Add(CostTypeModel);

            }
            return list;
        }
        /// <summary> 
        /// 私有方法 
        ///</summary>
        private static CostType GetMode(DataTable table)
        {
            CostType CostTypeModel = new CostType();
            foreach (DataRow row in table.Rows)
            {
                CostTypeModel.Ct_Id = Convert.ToInt32(row["Ct_Id"]); 
                CostTypeModel.Ct_Name = Convert.ToString(row["Ct_Name"]); 

            }
            return CostTypeModel;
        }
    }
}