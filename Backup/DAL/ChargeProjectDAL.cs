using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class ChargeProjectDAL
    {


        /// <summary>
        /// 添加 
        ///</summary>
        public static int AddChargeProject(ChargeProject ChargeProjectModel)
        {
            string sql = string.Format("insert into  ChargeProject (Cp_No,Cp_Name,Cp_Cost,Ct_Id,Cp_Note )values('{0}','{1}',{2},{3},'{4}')",ChargeProjectModel.Cp_No,ChargeProjectModel.Cp_Name,ChargeProjectModel.Cp_Cost,ChargeProjectModel.Ct_Id,ChargeProjectModel.Cp_Note);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据ID修改 
        ///</summary>
        public static int UpdateChargeProject(ChargeProject ChargeProjectModel)
        {
            string sql = string.Format(" UPDATE ChargeProject  set Cp_No='{0}',Cp_Name='{1}',Cp_Cost={2},Ct_Id={3},Cp_Note='{4}' where Cp_Id={5} ",ChargeProjectModel.Cp_No,ChargeProjectModel.Cp_Name,ChargeProjectModel.Cp_Cost,ChargeProjectModel.Ct_Id,ChargeProjectModel.Cp_Note  ,ChargeProjectModel.Cp_Id);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据主键删除 
        ///</summary>
        public static int DeleteChargeProject(int Id)
        {
            string sql = string.Format("delete from ChargeProject where Cp_Id={0}", Id);
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
                sql = "select count(*) from ChargeProject where 1=1 " + NewWHere;
            }
            else
            {
                sql = "select count(*) from ChargeProject";

            }
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary>
        /// 分页 
        ///</summary> 
        public static List<ChargeProject> PageSelectChargeProject(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            List<ChargeProject> list = new List<ChargeProject>(); 
	    string sql = string.Format("SELECT top {0} * FROM ChargeProject where Cp_Id not in( select top {1} Cp_Id from ChargeProject where 1=1 {2} order by {3} {4}) and 1=1 {2} order by {3} {4} ",pageSize, pageSize*pageIndex,WhereSrc, PXzd,PXType);
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                list = GetList(table);
            }
            return list;
        }

        /// <summary> 
        /// 根据主键查询实体 
        ///</summary>
        public static ChargeProject GetIdByChargeProject(int Id)
        {
            string sql = string.Format("SELECT * FROM ChargeProject where Cp_Id={0} ",Id);
            ChargeProject ChargeProjectModel = new ChargeProject();
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                ChargeProjectModel= GetMode(table);
            }
            return ChargeProjectModel;
        }
        /// <summary>
        /// 查询全部
        /// </summary>
        public static List<ChargeProject> AllData(string NewWHere)
        {
            List<ChargeProject> list = new List<ChargeProject>();

             string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
               sql = "select * from ChargeProject where 1=1 "+NewWHere;
            }
            else
            {
               sql = "select * from ChargeProject";
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
        private static List<ChargeProject> GetList(DataTable table)
        {
            List<ChargeProject> list = new List<ChargeProject>();
            foreach (DataRow row in table.Rows)
            {
                ChargeProject ChargeProjectModel = new ChargeProject(); 
                ChargeProjectModel.Cp_Id = Convert.ToInt32(row["Cp_Id"]); 
                ChargeProjectModel.Cp_No = Convert.ToString(row["Cp_No"]); 
                ChargeProjectModel.Cp_Name = Convert.ToString(row["Cp_Name"]); 
                ChargeProjectModel.Cp_Cost = Convert.ToDecimal(row["Cp_Cost"]); 
                ChargeProjectModel.Ct_Id = Convert.ToInt32(row["Ct_Id"]); 
                ChargeProjectModel.Cp_Note = Convert.ToString(row["Cp_Note"]); 
                list.Add(ChargeProjectModel);

            }
            return list;
        }
        /// <summary> 
        /// 私有方法 
        ///</summary>
        private static ChargeProject GetMode(DataTable table)
        {
            ChargeProject ChargeProjectModel = new ChargeProject();
            foreach (DataRow row in table.Rows)
            {
                ChargeProjectModel.Cp_Id = Convert.ToInt32(row["Cp_Id"]); 
                ChargeProjectModel.Cp_No = Convert.ToString(row["Cp_No"]); 
                ChargeProjectModel.Cp_Name = Convert.ToString(row["Cp_Name"]); 
                ChargeProjectModel.Cp_Cost = Convert.ToDecimal(row["Cp_Cost"]); 
                ChargeProjectModel.Ct_Id = Convert.ToInt32(row["Ct_Id"]); 
                ChargeProjectModel.Cp_Note = Convert.ToString(row["Cp_Note"]); 

            }
            return ChargeProjectModel;
        }
    }
}