using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class AuthorityDAL
    {


        /// <summary>
        /// 添加 
        ///</summary>
        public static int AddAuthority(Authority AuthorityModel)
        {
            string sql = string.Format("insert into  Authority (M_Id,R_Id )values({0},{1})",AuthorityModel.M_Id,AuthorityModel.R_Id);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据ID修改 
        ///</summary>
        public static int UpdateAuthority(Authority AuthorityModel)
        {
            string sql = string.Format(" UPDATE Authority  set M_Id={0},R_Id={1} where A_Id={2} ",AuthorityModel.M_Id,AuthorityModel.R_Id  ,AuthorityModel.A_Id);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据主键删除 
        ///</summary>
        public static int DeleteAuthority(int Id)
        {
            string sql = string.Format("delete from Authority where A_Id={0}", Id);
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
                sql = "select count(*) from Authority where 1=1 " + NewWHere;
            }
            else
            {
                sql = "select count(*) from Authority";

            }
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary> 
        /// 根据RoleId删除 
        ///</summary>
        public static int DeleteAuthorityByRoleId(int RoleId)
        {
            string sql = string.Format("delete from Authority where R_Id={0}", RoleId);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary>
        /// RoleId角色是否存在ModuleId权限
        /// </summary>
        /// <param name="RoleId"></param>
        /// <param name="ModuleId"></param>
        /// <returns></returns>
        public static int RoleIsExistModuleId(int RoleId, int ModuleId)
        {
            string sql = "select count(*) from Authority where R_Id=" + RoleId + " and M_Id=" + ModuleId;
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary>
        /// 分页 
        ///</summary> 
        public static List<Authority> PageSelectAuthority(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            List<Authority> list = new List<Authority>(); 
	    string sql = string.Format("SELECT top {0} * FROM Authority where A_Id not in( select top {1} A_Id from Authority where 1=1 {2} order by {3} {4}) and 1=1 {2} order by {3} {4} ",pageSize, pageSize*pageIndex,WhereSrc, PXzd,PXType);
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                list = GetList(table);
            }
            return list;
        }

        /// <summary> 
        /// 根据主键查询实体 
        ///</summary>
        public static Authority GetIdByAuthority(int Id)
        {
            string sql = string.Format("SELECT * FROM Authority where A_Id={0} ",Id);
            Authority AuthorityModel = new Authority();
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                AuthorityModel= GetMode(table);
            }
            return AuthorityModel;
        }
        /// <summary>
        /// 查询全部
        /// </summary>
        public static List<Authority> AllData(string NewWHere)
        {
            List<Authority> list = new List<Authority>();

             string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
               sql = "select * from Authority where 1=1 "+NewWHere;
            }
            else
            {
               sql = "select * from Authority";
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
        private static List<Authority> GetList(DataTable table)
        {
            List<Authority> list = new List<Authority>();
            foreach (DataRow row in table.Rows)
            {
                Authority AuthorityModel = new Authority(); 
                AuthorityModel.A_Id = Convert.ToInt32(row["A_Id"]); 
                AuthorityModel.M_Id = Convert.ToInt32(row["M_Id"]); 
                AuthorityModel.R_Id = Convert.ToInt32(row["R_Id"]); 
                list.Add(AuthorityModel);

            }
            return list;
        }
        /// <summary> 
        /// 私有方法 
        ///</summary>
        private static Authority GetMode(DataTable table)
        {
            Authority AuthorityModel = new Authority();
            foreach (DataRow row in table.Rows)
            {
                AuthorityModel.A_Id = Convert.ToInt32(row["A_Id"]); 
                AuthorityModel.M_Id = Convert.ToInt32(row["M_Id"]); 
                AuthorityModel.R_Id = Convert.ToInt32(row["R_Id"]); 

            }
            return AuthorityModel;
        }
    }
}