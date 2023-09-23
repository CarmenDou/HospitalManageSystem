using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;
using System.Data;

namespace BLL
{
    public class RegisterBLL
    {
        /// <summary> 
        /// ��� 
        ///</summary> 
        public static int AddRegister(Register RegisterModel)
        {
            return RegisterDAL.AddRegister(RegisterModel);
        }
        /// <summary> 
        /// ��������ɾ�� 
        ///</summary> 
        public static int DeleteRegister(int Id)
        {
            return RegisterDAL.DeleteRegister(Id);
        }
        /// <summary> 
        /// ��ҳ 
        ///</summary> 
        public static List<Register> PageSelectRegister(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return RegisterDAL.PageSelectRegister(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
          /// <summary>
        /// ��ҳ 
        ///</summary> 
        public static DataTable PageSelectRegister2(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        { 
             pageIndex = pageIndex - 1;
             return RegisterDAL.PageSelectRegister2(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// �޸� 
        ///</summary> 
        public static int UpdateRegister(Register RegisterModel)
        {
            return RegisterDAL.UpdateRegister(RegisterModel);
        }
        /// <summary> 
        /// ��ѯȫ��
        ///</summary>
        public static List<Register> AllData(string NewWHere)
        {
            return RegisterDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return RegisterDAL.CountNumber(NewWHere);
        }
        
        /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber2(string NewWHere)
        {
            return RegisterDAL.CountNumber2(NewWHere);
        }
        /// <summary> 
        /// ����������ѯʵ�� 
        ///</summary> 
        public static Register GetIdByRegister(int Id)
        {
            return RegisterDAL.GetIdByRegister(Id);
        }
    }
}