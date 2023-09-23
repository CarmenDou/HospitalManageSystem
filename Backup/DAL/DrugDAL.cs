using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DrugDAL
    {


        /// <summary>
        /// 添加 
        ///</summary>
        public static int AddDrug(Drug DrugModel)
        {
            string sql = string.Format("insert into  Drug (D_Name,D_Price,U_Id,D_Approval,D_Composition,D_Efficacy,D_Methods,Dt_Id,D_No )values('{0}',{1},{2},'{3}','{4}','{5}','{6}',{7},'{8}')", DrugModel.D_Name, DrugModel.D_Price, DrugModel.U_Id, DrugModel.D_Approval, DrugModel.D_Composition, DrugModel.D_Efficacy, DrugModel.D_Methods, DrugModel.Dt_Id,DrugModel.D_No);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据ID修改 
        ///</summary>
        public static int UpdateDrug(Drug DrugModel)
        {
            string sql = string.Format(" UPDATE Drug  set D_Name='{0}',D_Price={1},U_Id={2},D_Approval='{3}',D_Composition='{4}',D_Efficacy='{5}',D_Methods='{6}',Dt_Id={7},D_No='{8}' where D_Id={9} ", DrugModel.D_Name, DrugModel.D_Price, DrugModel.U_Id, DrugModel.D_Approval, DrugModel.D_Composition, DrugModel.D_Efficacy, DrugModel.D_Methods, DrugModel.Dt_Id, DrugModel.D_No, DrugModel.D_Id);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据主键删除 
        ///</summary>
        public static int DeleteDrug(int Id)
        {
            string sql = string.Format("delete from Drug where D_Id={0}", Id);
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
                sql = "select count(*) from Drug where 1=1 " + NewWHere;
            }
            else
            {
                sql = "select count(*) from Drug";

            }
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary>
        /// 分页 
        ///</summary> 
        public static List<Drug> PageSelectDrug(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            List<Drug> list = new List<Drug>(); 
	    string sql = string.Format("SELECT top {0} * FROM Drug where D_Id not in( select top {1} D_Id from Drug where 1=1 {2} order by {3} {4}) and 1=1 {2} order by {3} {4} ",pageSize, pageSize*pageIndex,WhereSrc, PXzd,PXType);
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                list = GetList(table);
            }
            return list;
        }

        /// <summary> 
        /// 根据主键查询实体 
        ///</summary>
        public static Drug GetIdByDrug(int Id)
        {
            string sql = string.Format("SELECT * FROM Drug where D_Id={0} ",Id);
            Drug DrugModel = new Drug();
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                DrugModel= GetMode(table);
            }
            return DrugModel;
        }
        /// <summary>
        /// 查询全部
        /// </summary>
        public static List<Drug> AllData(string NewWHere)
        {
            List<Drug> list = new List<Drug>();

             string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
               sql = "select * from Drug where 1=1 "+NewWHere;
            }
            else
            {
               sql = "select * from Drug";
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
        private static List<Drug> GetList(DataTable table)
        {
            List<Drug> list = new List<Drug>();
            foreach (DataRow row in table.Rows)
            {
                Drug DrugModel = new Drug(); 
                DrugModel.D_Id = Convert.ToInt32(row["D_Id"]); 
                DrugModel.D_Name = Convert.ToString(row["D_Name"]); 
                DrugModel.D_Price = Convert.ToDecimal(row["D_Price"]); 
                DrugModel.U_Id = Convert.ToInt32(row["U_Id"]); 
                DrugModel.D_Approval = Convert.ToString(row["D_Approval"]); 
                DrugModel.D_Composition = Convert.ToString(row["D_Composition"]); 
                DrugModel.D_Efficacy = Convert.ToString(row["D_Efficacy"]); 
                DrugModel.D_Methods = Convert.ToString(row["D_Methods"]); 
                DrugModel.Dt_Id = Convert.ToInt32(row["Dt_Id"]);
                DrugModel.D_No = Convert.ToString(row["D_No"]); 
                list.Add(DrugModel);

            }
            return list;
        }
        /// <summary> 
        /// 私有方法 
        ///</summary>
        private static Drug GetMode(DataTable table)
        {
            Drug DrugModel = new Drug();
            foreach (DataRow row in table.Rows)
            {
                DrugModel.D_Id = Convert.ToInt32(row["D_Id"]); 
                DrugModel.D_Name = Convert.ToString(row["D_Name"]); 
                DrugModel.D_Price = Convert.ToDecimal(row["D_Price"]); 
                DrugModel.U_Id = Convert.ToInt32(row["U_Id"]); 
                DrugModel.D_Approval = Convert.ToString(row["D_Approval"]); 
                DrugModel.D_Composition = Convert.ToString(row["D_Composition"]); 
                DrugModel.D_Efficacy = Convert.ToString(row["D_Efficacy"]); 
                DrugModel.D_Methods = Convert.ToString(row["D_Methods"]); 
                DrugModel.Dt_Id = Convert.ToInt32(row["Dt_Id"]);
                DrugModel.D_No = Convert.ToString(row["D_No"]); 

            }
            return DrugModel;
        }
    }
}