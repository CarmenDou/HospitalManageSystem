using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class RegisterTypeBLL
    {
        /// <summary> 
        /// ��� 
        ///</summary> 
        public static int AddRegisterType(RegisterType RegisterTypeModel)
        {
            return RegisterTypeDAL.AddRegisterType(RegisterTypeModel);
        }
        /// <summary> 
        /// ��������ɾ�� 
        ///</summary> 
        public static int DeleteRegisterType(int Id)
        {
            return RegisterTypeDAL.DeleteRegisterType(Id);
        }
        /// <summary> 
        /// ��ҳ 
        ///</summary> 
        public static List<RegisterType> PageSelectRegisterType(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return RegisterTypeDAL.PageSelectRegisterType(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// �޸� 
        ///</summary> 
        public static int UpdateRegisterType(RegisterType RegisterTypeModel)
        {
            return RegisterTypeDAL.UpdateRegisterType(RegisterTypeModel);
        }
        /// <summary> 
        /// ��ѯȫ��
        ///</summary>
        public static List<RegisterType> AllData(string NewWHere)
        {
            return RegisterTypeDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return RegisterTypeDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// ����������ѯʵ�� 
        ///</summary> 
        public static RegisterType GetIdByRegisterType(int Id)
        {
            return RegisterTypeDAL.GetIdByRegisterType(Id);
        }
    }
}