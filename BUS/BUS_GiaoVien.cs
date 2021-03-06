using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_GiaoVien
    {
        public static DataTable GetHVfromMH(string tenLop , string idMonHoc)
        {
            if(tenLop != null && idMonHoc != null )
            switch (tenLop)
            {
                case "Chứng chỉ":
                    return GetHVCCfromMH(idMonHoc);
                case "Kỹ thuật":
                    return GetHVKTfromMH(idMonHoc);
                case "Chuyên đề":
                    return GetHVCDfromMH(idMonHoc);
            }
            return null;
        }
        public static DataTable GetHVCCfromMH(string idMonHoc)
        {
            return BUS_MonHoc.GiaoVienGetHVCC(idMonHoc);
        }
        public static DataTable GetHVKTfromMH(string idMonHoc)
        {
            return BUS_MonHoc.GiaoVienGetHVKT(idMonHoc);
        }
        public static DataTable GetHVCDfromMH(string idChuyenDe)
        {
            return BUS_ChuyenDe.GiaoVienGetHVCD(idChuyenDe);
        }
        public static string GetTenGV(string id) => DAL_NhanVien.GetTenGV( id);
        public static DataTable GetTenLop(string tenLop, string idGiaoVien)
        {
            if (tenLop == "Chuyên đề")
            {
                return BUS_ChuyenDe.GetTenLop(idGiaoVien);
            }
            else
            {
                return BUS_MonHoc.GetTenLop(tenLop, idGiaoVien);
            }
        }
    }
}
