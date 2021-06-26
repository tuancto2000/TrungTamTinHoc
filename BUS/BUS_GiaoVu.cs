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
        public static DataTable GetMH1() => DAL_MonHoc.Get1();
        public static DataTable GetGV() => DAL_NhanVien.GetGV();
        public static void PhanCongGiangDay(string idMH, string idGV, out int check) 
            => DAL_MonHoc.PhanCongGiangDay(idMH, idGV, out check);
        public static DataTable GetHVTN() => DAL_HocVien.Get();
        public static void NhapDiemTotNghiep(string idHV, string diem)
            => DAL_HocVienTotNghiep.NhapDiemTotNghiep(idHV, diem);
        public static DataTable GetMH2() => DAL_MonHoc.Get2();
        public static bool CheckExistsLichThi(string idMH) => DAL_LichThi.CheckExists(idMH);
        public static DataTable GetNV() => DAL_NhanVien.Get();
        public static bool CheckTrungLichCoiThi(string ngayThi, string idNV) => DAL_LichThi.CheckTrungLichCoiThi(ngayThi, idNV);
        public static void ThemLichThi(string idMH, string idNV, string ngayThi, string lichThi)
            => DAL_LichThi.ThemLichThi(idMH, idNV, ngayThi, lichThi);
    }
}
