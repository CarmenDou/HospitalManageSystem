using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class CalculateDetailDAL
    {


        /// <summary>
        /// 添加 
        ///</summary>
        public static int AddCalculateDetail(CalculateDetail CalculateDetailModel)
        {
            string sql = string.Format("insert into  CalculateDetail (C_Id,Cd_Price,Cd_Count,Cd_Amount,D_Id )values({0},{1},{2},{3},{4})",CalculateDetailModel.C_Id,CalculateDetailModel.Cd_Price,CalculateDetailModel.Cd_Count,CalculateDetailModel.Cd_Amount,CalculateDetailModel.D_Id);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据ID修改 
        ///</summary>
        public static int UpdateCalculateDetail(CalculateDetail CalculateDetailModel)
        {
            string sql = string.Format(" UPDATE CalculateDetail  set C_Id={0},Cd_Price={1},Cd_Count={2},Cd_Amount={3},D_Id={4} where Cd_Id={5} ",CalculateDetailModel.C_Id,CalculateDetailModel.Cd_Price,CalculateDetailModel.Cd_Count,CalculateDetailModel.Cd_Amount,CalculateDetailModel.D_Id  ,CalculateDetailModel.Cd_Id);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据主键删除 
        ///</summary>
        public static int DeleteCalculateDetail(int Id)
        {
            string sql = string.Format("delete from CalculateDetail where Cd_Id={0}", Id);
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
                sql = "select count(*) from CalculateDetail where 1=1 " + NewWHere;
            }
            else
            {
                sql = "select count(*) from CalculateDetail";

            }
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary>
        /// 分页 
        ///</summary> 
        public static List<CalculateDetail> PageSelectCalculateDetail(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            List<CalculateDetail> list = new List<CalculateDetail>(); 
	    string sql = string.Format("SELECT top {0} * FROM CalculateDetail where Cd_Id not in( select top {1} Cd_Id from CalculateDetail where 1=1 {2} order by {3} {4}) and 1=1 {2} order by {3} {4} ",pageSize, pageSize*pageIndex,WhereSrc, PXzd,PXType);
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                list = GetList(table);
            }
            return list;
        }

        /// <summary> 
        /// 根据主键查询实体 
        ///</summary>
        public static CalculateDetail GetIdByCalculateDetail(int Id)
        {
            string sql = string.Format("SELECT * FROM CalculateDetail where Cd_Id={0} ",Id);
            CalculateDetail CalculateDetailModel = new CalculateDetail();
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                CalculateDetailModel= GetMode(table);
            }
            return CalculateDetailModel;
        }
        /// <summary>
        /// 查询全部
        /// </summary>
        public static List<CalculateDetail> AllData(string NewWHere)
        {
            List<CalculateDetail> list = new List<CalculateDetail>();

             string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
               sql = "select * from CalculateDetail where 1=1 "+NewWHere;
            }
            else
            {
               sql = "select * from CalculateDetail";
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
        private static List<CalculateDetail> GetList(DataTable table)
        {
            List<CalculateDetail> list = new List<CalculateDetail>();
            foreach (DataRow row in table.Rows)
            {
                CalculateDetail CalculateDetailModel = new CalculateDetail(); 
                CalculateDetailModel.Cd_Id = Convert.ToInt32(row["Cd_Id"]); 
                CalculateDetailModel.C_Id = Convert.ToInt32(row["C_Id"]); 
                CalculateDetailModel.Cd_Price = Convert.ToDecimal(row["Cd_Price"]); 
                CalculateDetailModel.Cd_Count = Convert.ToInt32(row["Cd_Count"]); 
                CalculateDetailModel.Cd_Amount = Convert.ToDecimal(row["Cd_Amount"]); 
                CalculateDetailModel.D_Id = Convert.ToInt32(row["D_Id"]); 
                list.Add(CalculateDetailModel);

            }
            return list;
        }
        /// <summary> 
        /// 私有方法 
        ///</summary>
        private static CalculateDetail GetMode(DataTable table)
        {
            CalculateDetail CalculateDetailModel = new CalculateDetail();
            foreach (DataRow row in table.Rows)
            {
                CalculateDetailModel.Cd_Id = Convert.ToInt32(row["Cd_Id"]); 
                CalculateDetailModel.C_Id = Convert.ToInt32(row["C_Id"]); 
                CalculateDetailModel.Cd_Price = Convert.ToDecimal(row["Cd_Price"]); 
                CalculateDetailModel.Cd_Count = Convert.ToInt32(row["Cd_Count"]); 
                CalculateDetailModel.Cd_Amount = Convert.ToDecimal(row["Cd_Amount"]); 
                CalculateDetailModel.D_Id = Convert.ToInt32(row["D_Id"]); 

            }
            return CalculateDetailModel;
        }
    }
}