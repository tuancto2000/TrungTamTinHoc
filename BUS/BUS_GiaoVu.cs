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
    public class BUS_GiaoVu
    {
        public static DataTable GetMH() => DAL_MonHoc.Get();
        public static DataTable GetGV() => DAL_GiaoVien.Get();
        public static void PhanCongGiangDay(string idMH, string idGV, out int check) 
            => DAL_MonHoc.PhanCongGiangDay(idMH, idGV, out check);
        public static DataTable GetHVTN() => DAL_HocVien.Get();
        public static void NhapDiemTotNghiep(string idHV, string diem)
            => DAL_HocVienTotNghiep.NhapDiemTotNghiep(idHV, diem);
    }
}
