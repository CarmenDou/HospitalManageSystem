using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class ModulesDAL
    {


        /// <summary>
        /// 添加 
        ///</summary>
        public static int AddModules(Modules ModulesModel)
        {
            string sql = string.Format("insert into  Modules (M_SubName,M_ParentId,M_Url )values('{0}',{1},'{2}')",ModulesModel.M_SubName,ModulesModel.M_ParentId,ModulesModel.M_Url);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据ID修改 
        ///</summary>
        public static int UpdateModules(Modules ModulesModel)
        {
            string sql = string.Format(" UPDATE Modules  set M_SubName='{0}',M_ParentId={1},M_Url='{2}' where M_Id={3} ",ModulesModel.M_SubName,ModulesModel.M_ParentId,ModulesModel.M_Url  ,ModulesModel.M_Id);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据主键删除 
        ///</summary>
        public static int DeleteModules(int Id)
        {
            string sql = string.Format("delete from Modules where M_Id={0}", Id);
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
                sql = "select count(*) from Modules where 1=1 " + NewWHere;
            }
            else
            {
                sql = "select count(*) from Modules";

            }
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary>
        /// 分页 
        ///</summary> 
        public static List<Modules> PageSelectModules(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            List<Modules> list = new List<Modules>(); 
	    string sql = string.Format("SELECT top {0} * FROM Modules where M_Id not in( select top {1} M_Id from Modules where 1=1 {2} order by {3} {4}) and 1=1 {2} order by {3} {4} ",pageSize, pageSize*pageIndex,WhereSrc, PXzd,PXType);
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                list = GetList(table);
            }
            return list;
        }

        /// <summary> 
        /// 根据主键查询实体 
        ///</summary>
        public static Modules GetIdByModules(int Id)
        {
            string sql = string.Format("SELECT * FROM Modules where M_Id={0} ",Id);
            Modules ModulesModel = new Modules();
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                ModulesModel= GetMode(table);
            }
            return ModulesModel;
        }
        /// <summary>
        /// 查询全部
        /// </summary>
        public static List<Modules> AllData(string NewWHere)
        {
            List<Modules> list = new List<Modules>();

             string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
               sql = "select * from Modules where 1=1 "+NewWHere;
            }
            else
            {
               sql = "select * from Modules";
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
        private static List<Modules> GetList(DataTable table)
        {
            List<Modules> list = new List<Modules>();
            foreach (DataRow row in table.Rows)
            {
                Modules ModulesModel = new Modules(); 
                ModulesModel.M_Id = Convert.ToInt32(row["M_Id"]); 
                ModulesModel.M_SubName = Convert.ToString(row["M_SubName"]); 
                ModulesModel.M_ParentId = Convert.ToInt32(row["M_ParentId"]); 
                ModulesModel.M_Url = Convert.ToString(row["M_Url"]); 
                list.Add(ModulesModel);

            }
            return list;
        }
        /// <summary> 
        /// 私有方法 
        ///</summary>
        private static Modules GetMode(DataTable table)
        {
            Modules ModulesModel = new Modules();
            foreach (DataRow row in table.Rows)
            {
                ModulesModel.M_Id = Convert.ToInt32(row["M_Id"]); 
                ModulesModel.M_SubName = Convert.ToString(row["M_SubName"]); 
                ModulesModel.M_ParentId = Convert.ToInt32(row["M_ParentId"]); 
                ModulesModel.M_Url = Convert.ToString(row["M_Url"]); 

            }
            return ModulesModel;
        }
    }
}