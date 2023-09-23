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
        /// ��� 
        ///</summary> 
        public static int AddRecord(Record RecordModel)
        {
            return RecordDAL.AddRecord(RecordModel);
        }
        /// <summary> 
        /// ��������ɾ�� 
        ///</summary> 
        public static int DeleteRecord(int Id)
        {
            return RecordDAL.DeleteRecord(Id);
        }
        /// <summary> 
        /// ��ҳ 
        ///</summary> 
        public static DataTable PageSelectRecord2(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return RecordDAL.PageSelectRecord2(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// ��ҳ 
        ///</summary> 
        public static List<Record> PageSelectRecord(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return RecordDAL.PageSelectRecord(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// �޸� 
        ///</summary> 
        public static int UpdateRecord(Record RecordModel)
        {
            return RecordDAL.UpdateRecord(RecordModel);
        }
        /// <summary> 
        /// ��ѯȫ��
        ///</summary>
        public static List<Record> AllData(string NewWHere)
        {
            return RecordDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return RecordDAL.CountNumber(NewWHere);
        }
         /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber2(string NewWHere)
        {
            return RecordDAL.CountNumber2(NewWHere);
        }
        /// <summary> 
        /// ����������ѯʵ�� 
        ///</summary> 
        public static Record GetIdByRecord(int Id)
        {
            return RecordDAL.GetIdByRecord(Id);
        }
    }
}