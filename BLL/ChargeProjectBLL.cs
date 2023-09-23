using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class ChargeProjectBLL
    {
        /// <summary> 
        /// ��� 
        ///</summary> 
        public static int AddChargeProject(ChargeProject ChargeProjectModel)
        {
            return ChargeProjectDAL.AddChargeProject(ChargeProjectModel);
        }
        /// <summary> 
        /// ��������ɾ�� 
        ///</summary> 
        public static int DeleteChargeProject(int Id)
        {
            return ChargeProjectDAL.DeleteChargeProject(Id);
        }
        /// <summary> 
        /// ��ҳ 
        ///</summary> 
        public static List<ChargeProject> PageSelectChargeProject(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return ChargeProjectDAL.PageSelectChargeProject(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// �޸� 
        ///</summary> 
        public static int UpdateChargeProject(ChargeProject ChargeProjectModel)
        {
            return ChargeProjectDAL.UpdateChargeProject(ChargeProjectModel);
        }
        /// <summary> 
        /// ��ѯȫ��
        ///</summary>
        public static List<ChargeProject> AllData(string NewWHere)
        {
            return ChargeProjectDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return ChargeProjectDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// ����������ѯʵ�� 
        ///</summary> 
        public static ChargeProject GetIdByChargeProject(int Id)
        {
            return ChargeProjectDAL.GetIdByChargeProject(Id);
        }
    }
}