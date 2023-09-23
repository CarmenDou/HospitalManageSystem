using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class RecordDAL
    {


        /// <summary>
        /// 添加 
        ///</summary>
        public static int AddRecord(Record RecordModel)
        {
            string sql = string.Format("insert into  Record (P_Id,R_Room,R_Bed,R_Enter,R_Out,R_State,U_Id ,R_No)values({0},{1},{2},'{3}','{4}','{5}',{6},'{7}')", RecordModel.P_Id, RecordModel.R_Room, RecordModel.R_Bed, RecordModel.R_Enter, RecordModel.R_Out, RecordModel.R_State, RecordModel.U_Id,RecordModel.R_No);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据ID修改 
        ///</summary>
        public static int UpdateRecord(Record RecordModel)
        {
            string sql = string.Format(" UPDATE Record  set P_Id={0},R_Room={1},R_Bed={2},R_Enter='{3}',R_Out='{4}',R_State='{5}',U_Id={6},R_No='{7}' where R_Id={8} ", RecordModel.P_Id, RecordModel.R_Room, RecordModel.R_Bed, RecordModel.R_Enter, RecordModel.R_Out, RecordModel.R_State, RecordModel.U_Id, RecordModel.R_No, RecordModel.R_Id);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据主键删除 
        ///</summary>
        public static int DeleteRecord(int Id)
        {
            string sql = string.Format("delete from Record where R_Id={0}", Id);
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
                sql = "select count(*) from Record where 1=1 " + NewWHere;
            }
            else
            {
                sql = "select count(*) from Record";

            }
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber2(string NewWHere)
        {
            string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
                sql = @"select count(*) from Record INNER JOIN
       Patient ON Record.P_Id = Patient.P_Id where 1=1 " + NewWHere;
            }
            else
            {
                sql = @"select count(*) from Record INNER JOIN
       Patient ON Record.P_Id = Patient.P_Id";

            }
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary>
        /// 分页 
        ///</summary> 
        public static List<Record> PageSelectRecord(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            List<Record> list = new List<Record>();
            string sql = string.Format("SELECT top {0} * FROM Record where R_Id not in( select top {1} R_Id from Record where 1=1 {2} order by {3} {4}) and 1=1 {2} order by {3} {4} ", pageSize, pageSize * pageIndex, WhereSrc, PXzd, PXType);
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                list = GetList(table);
            }
            return list;
        }
        /// <summary>
        /// 分页 
        ///</summary> 
        public static DataTable PageSelectRecord2(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            string sql = string.Format(@"SELECT top {0} * FROM Record INNER JOIN
       Patient ON Record.P_Id = Patient.P_Id where R_Id not in( select top {1} R_Id from Record INNER JOIN
       Patient ON Record.P_Id = Patient.P_Id where 1=1 {2} order by {3} {4}) and 1=1 {2} order by {3} {4} ", pageSize, pageSize * pageIndex, WhereSrc, PXzd, PXType);
          
            return DBHelper.GetDataSet(sql);
        }

        /// <summary> 
        /// 根据主键查询实体 
        ///</summary>
        public static Record GetIdByRecord(int Id)
        {
            string sql = string.Format("SELECT * FROM Record where R_Id={0} ",Id);
            Record RecordModel = new Record();
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                RecordModel= GetMode(table);
            }
            return RecordModel;
        }
        /// <summary>
        /// 查询全部
        /// </summary>
        public static List<Record> AllData(string NewWHere)
        {
            List<Record> list = new List<Record>();

             string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
               sql = "select * from Record where 1=1 "+NewWHere;
            }
            else
            {
               sql = "select * from Record";
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
        private static List<Record> GetList(DataTable table)
        {
            List<Record> list = new List<Record>();
            foreach (DataRow row in table.Rows)
            {
                Record RecordModel = new Record(); 
                RecordModel.R_Id = Convert.ToInt32(row["R_Id"]); 
                RecordModel.P_Id = Convert.ToInt32(row["P_Id"]); 
                RecordModel.R_Room = Convert.ToInt32(row["R_Room"]); 
                RecordModel.R_Bed = Convert.ToInt32(row["R_Bed"]); 
                RecordModel.R_Enter = Convert.ToDateTime(row["R_Enter"]); 
                RecordModel.R_Out = Convert.ToDateTime(row["R_Out"]); 
                RecordModel.R_State = Convert.ToString(row["R_State"]); 
                RecordModel.U_Id = Convert.ToInt32(row["U_Id"]);
                RecordModel.R_No = Convert.ToString(row["R_No"]); 
                list.Add(RecordModel);

            }
            return list;
        }
        /// <summary> 
        /// 私有方法 
        ///</summary>
        private static Record GetMode(DataTable table)
        {
            Record RecordModel = new Record();
            foreach (DataRow row in table.Rows)
            {
                RecordModel.R_Id = Convert.ToInt32(row["R_Id"]); 
                RecordModel.P_Id = Convert.ToInt32(row["P_Id"]); 
                RecordModel.R_Room = Convert.ToInt32(row["R_Room"]); 
                RecordModel.R_Bed = Convert.ToInt32(row["R_Bed"]); 
                RecordModel.R_Enter = Convert.ToDateTime(row["R_Enter"]); 
                RecordModel.R_Out = Convert.ToDateTime(row["R_Out"]); 
                RecordModel.R_State = Convert.ToString(row["R_State"]); 
                RecordModel.U_Id = Convert.ToInt32(row["U_Id"]);
                RecordModel.R_No = Convert.ToString(row["R_No"]); 
            }
            return RecordModel;
        }
    }
}