using System.Data;
using DAL;
namespace BUS
{
    public class BUS_HocVien
    {
        // Lớp chứng chỉ
        public static void dangKyChungChi(string idHV, string loaiCC, out int flag)
            => DAL_MonHoc.dangKyChungChi(idHV, loaiCC, out flag);
        public static DataTable hienThiLopChungChi(string idHV)
            => DAL_MonHoc.hienThiLopChungChi(idHV);
        public static void dangKyLopChungChi(string idHV, string maMH, out int flag)
            => DAL_MonHoc.dangKyLopChungChi(idHV, maMH, out flag);
        public static DataTable hienThiLopChungChiDaDK(string idHV)
            => DAL_MonHoc.hienThiLopChungChiDaDK(idHV);

        // Lớp kỹ thuật
        public static DataTable hienThiLopKyThuat(string idHV)
            => DAL_MonHoc.hienThiLopKyThuat(idHV);
        public static DataTable hienThiMonHocKyThuatDaDK(string idHV)
            => DAL_MonHoc.hienThiMonHocKyThuatDaDK(idHV);
        public static void dangKyLopKyThuat(string idHV, string maMH, out int flag)
        {
            DAL_MonHoc.dangKyKyThuat(idHV, out flag);
            DAL_MonHoc.dangKyLopKyThuat(idHV, maMH, out flag);
        }
        public static void dangKyThiTotNghiep(string idHV, out int flag)
            => DAL_MonHoc.dangKyThiTotNghiep(idHV, out flag);
        public static DataTable GetHVTN() => DAL_HocVienTotNghiep.GetHVTN();
        public static void NhapDiemTotNghiep(string idHV, string diem)
            => DAL_HocVienTotNghiep.NhapDiemTotNghiep(idHV, diem);
    }

}
