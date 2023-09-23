using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class UnitsDAL
    {


        /// <summary>
        /// ��� 
        ///</summary>
        public static int AddUnits(Units UnitsModel)
        {
            string sql = string.Format("insert into  Units (U_Name )values('{0}')",UnitsModel.U_Name);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// ����ID�޸� 
        ///</summary>
        public static int UpdateUnits(Units UnitsModel)
        {
            string sql = string.Format(" UPDATE Units  set U_Name='{0}' where U_Id={1} ",UnitsModel.U_Name  ,UnitsModel.U_Id);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// ��������ɾ�� 
        ///</summary>
        public static int DeleteUnits(int Id)
        {
            string sql = string.Format("delete from Units where U_Id={0}", Id);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
                sql = "select count(*) from Units where 1=1 " + NewWHere;
            }
            else
            {
                sql = "select count(*) from Units";

            }
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary>
        /// ��ҳ 
        ///</summary> 
        public static List<Units> PageSelectUnits(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            List<Units> list = new List<Units>(); 
	    string sql = string.Format("SELECT top {0} * FROM Units where U_Id not in( select top {1} U_Id from Units where 1=1 {2} order by {3} {4}) and 1=1 {2} order by {3} {4} ",pageSize, pageSize*pageIndex,WhereSrc, PXzd,PXType);
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                list = GetList(table);
            }
            return list;
        }

        /// <summary> 
        /// ����������ѯʵ�� 
        ///</summary>
        public static Units GetIdByUnits(int Id)
        {
            string sql = string.Format("SELECT * FROM Units where U_Id={0} ",Id);
            Units UnitsModel = new Units();
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                UnitsModel= GetMode(table);
            }
            return UnitsModel;
        }
        /// <summary>
        /// ��ѯȫ��
        /// </summary>
        public static List<Units> AllData(string NewWHere)
        {
            List<Units> list = new List<Units>();

             string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
               sql = "select * from Units where 1=1 "+NewWHere;
            }
            else
            {
               sql = "select * from Units";
            }
            using (DataTable table = DBHelper.GetDataSet(sql))
            {

                list = GetList(table);
            }
            return list;
        }
        /// <summary> 
        /// ˽�з��� 
        ///</summary>
        private static List<Units> GetList(DataTable table)
        {
            List<Units> list = new List<Units>();
            foreach (DataRow row in table.Rows)
            {
                Units UnitsModel = new Units(); 
                UnitsModel.U_Id = Convert.ToInt32(row["U_Id"]); 
                UnitsModel.U_Name = Convert.ToString(row["U_Name"]); 
                list.Add(UnitsModel);

            }
            return list;
        }
        /// <summary> 
        /// ˽�з��� 
        ///</summary>
        private static Units GetMode(DataTable table)
        {
            Units UnitsModel = new Units();
            foreach (DataRow row in table.Rows)
            {
                UnitsModel.U_Id = Convert.ToInt32(row["U_Id"]); 
                UnitsModel.U_Name = Convert.ToString(row["U_Name"]); 

            }
            return UnitsModel;
        }
    }
}