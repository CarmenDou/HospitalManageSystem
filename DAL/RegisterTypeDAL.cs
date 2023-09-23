using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class RegisterTypeDAL
    {


        /// <summary>
        /// 添加 
        ///</summary>
        public static int AddRegisterType(RegisterType RegisterTypeModel)
        {
            string sql = string.Format("insert into  RegisterType (Rt_Name,Rt_Cost )values('{0}',{1})",RegisterTypeModel.Rt_Name,RegisterTypeModel.Rt_Cost);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据ID修改 
        ///</summary>
        public static int UpdateRegisterType(RegisterType RegisterTypeModel)
        {
            string sql = string.Format(" UPDATE RegisterType  set Rt_Name='{0}',Rt_Cost={1} where Rt_Id={2} ",RegisterTypeModel.Rt_Name,RegisterTypeModel.Rt_Cost  ,RegisterTypeModel.Rt_Id);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据主键删除 
        ///</summary>
        public static int DeleteRegisterType(int Id)
        {
            string sql = string.Format("delete from RegisterType where Rt_Id={0}", Id);
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
                sql = "select count(*) from RegisterType where 1=1 " + NewWHere;
            }
            else
            {
                sql = "select count(*) from RegisterType";

            }
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary>
        /// 分页 
        ///</summary> 
        public static List<RegisterType> PageSelectRegisterType(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            List<RegisterType> list = new List<RegisterType>(); 
	    string sql = string.Format("SELECT top {0} * FROM RegisterType where Rt_Id not in( select top {1} Rt_Id from RegisterType where 1=1 {2} order by {3} {4}) and 1=1 {2} order by {3} {4} ",pageSize, pageSize*pageIndex,WhereSrc, PXzd,PXType);
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                list = GetList(table);
            }
            return list;
        }

        /// <summary> 
        /// 根据主键查询实体 
        ///</summary>
        public static RegisterType GetIdByRegisterType(int Id)
        {
            string sql = string.Format("SELECT * FROM RegisterType where Rt_Id={0} ",Id);
            RegisterType RegisterTypeModel = new RegisterType();
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                RegisterTypeModel= GetMode(table);
            }
            return RegisterTypeModel;
        }
        /// <summary>
        /// 查询全部
        /// </summary>
        public static List<RegisterType> AllData(string NewWHere)
        {
            List<RegisterType> list = new List<RegisterType>();

             string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
               sql = "select * from RegisterType where 1=1 "+NewWHere;
            }
            else
            {
               sql = "select * from RegisterType";
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
        private static List<RegisterType> GetList(DataTable table)
        {
            List<RegisterType> list = new List<RegisterType>();
            foreach (DataRow row in table.Rows)
            {
                RegisterType RegisterTypeModel = new RegisterType(); 
                RegisterTypeModel.Rt_Id = Convert.ToInt32(row["Rt_Id"]); 
                RegisterTypeModel.Rt_Name = Convert.ToString(row["Rt_Name"]); 
                RegisterTypeModel.Rt_Cost = Convert.ToDecimal(row["Rt_Cost"]); 
                list.Add(RegisterTypeModel);

            }
            return list;
        }
        /// <summary> 
        /// 私有方法 
        ///</summary>
        private static RegisterType GetMode(DataTable table)
        {
            RegisterType RegisterTypeModel = new RegisterType();
            foreach (DataRow row in table.Rows)
            {
                RegisterTypeModel.Rt_Id = Convert.ToInt32(row["Rt_Id"]); 
                RegisterTypeModel.Rt_Name = Convert.ToString(row["Rt_Name"]); 
                RegisterTypeModel.Rt_Cost = Convert.ToDecimal(row["Rt_Cost"]); 

            }
            return RegisterTypeModel;
        }
    }
}