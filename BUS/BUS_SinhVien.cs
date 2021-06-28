using System.Data;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_SinhVien
    {
        // Lớp chứng chỉ
        public static void dangKyChungChi(string idHV, string loaiCC, out int flag)
            => DAL_MonHoc.dangKyChungChi(idHV, loaiCC, out flag);
        public static DataTable hienThiMonHocChungChi(string idHV)
            => DAL_MonHoc.hienThiMonHocChungChi(idHV);
        public static void dangKyLopChungChi(string idHV, string maMH)
            => DAL_MonHoc.dangKyLopChungChi(idHV, maMH);
        public static DataTable hienThiMonHocChungChiDaDK(string idHV)
            => DAL_MonHoc.hienThiMonHocChungChiDaDK(idHV);

        // Lớp kỹ thuật
        public static DataTable hienThiMonHocKyThuat(string idHV)
            => DAL_MonHoc.hienThiMonHocKyThuat(idHV);
        public static DataTable hienThiMonHocKyThuatDaDK(string idHV)
            => DAL_MonHoc.hienThiMonHocKyThuatDaDK(idHV);
        public static void dangKyThiTotNghiep(string idHV, out int flag)
            => DAL_MonHoc.dangKyThiTotNghiep(idHV, out flag);

    }
}
