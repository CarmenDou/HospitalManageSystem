using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;
using System.Data;

namespace BLL
{
    public class RecordBLL
    {
        /// <summary> 
        /// 添加 
        ///</summary> 
        public static int AddRecord(Record RecordModel)
        {
            return RecordDAL.AddRecord(RecordModel);
        }
        /// <summary> 
        /// 根据主键删除 
        ///</summary> 
        public static int DeleteRecord(int Id)
        {
            return RecordDAL.DeleteRecord(Id);
        }
        /// <summary> 
        /// 分页 
        ///</summary> 
        public static DataTable PageSelectRecord2(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return RecordDAL.PageSelectRecord2(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// 分页 
        ///</summary> 
        public static List<Record> PageSelectRecord(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return RecordDAL.PageSelectRecord(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// 修改 
        ///</summary> 
        public static int UpdateRecord(Record RecordModel)
        {
            return RecordDAL.UpdateRecord(RecordModel);
        }
        /// <summary> 
        /// 查询全部
        ///</summary>
        public static List<Record> AllData(string NewWHere)
        {
            return RecordDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return RecordDAL.CountNumber(NewWHere);
        }
         /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber2(string NewWHere)
        {
            return RecordDAL.CountNumber2(NewWHere);
        }
        /// <summary> 
        /// 根据主键查询实体 
        ///</summary> 
        public static Record GetIdByRecord(int Id)
        {
            return RecordDAL.GetIdByRecord(Id);
        }
    }
}