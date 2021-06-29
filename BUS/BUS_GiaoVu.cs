using System.Data;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_GiaoVu
    {
        public static DataTable GetMH_PCGD()
        {
            DataTable dt = DAL_MonHoc.Get();

            dt.Columns.Remove("Id_hp");
            dt.Columns.Remove("Id_nv");
            dt.Columns.Remove("Phong_hoc");
            dt.Columns.Remove("So_luong_hv");
            dt.Columns.Remove("Hoc_phi");
            dt.Columns.Remove("isOpen");
            dt.Columns["Id_mh"].ColumnName = "Mã môn học";
            dt.Columns["Ten_mh"].ColumnName = "Tên môn học";
            dt.Columns["lich_hoc"].ColumnName = "Lịch học";
            return dt;
        }

        public static DataTable GetGV() => DAL_NhanVien.GetGV();
        public static bool CheckExistsLichDay(string idMH, string idGV) => DAL_MonHoc.CheckExistsLichDay(idMH, idGV);
        public static void PhanCongGiangDay(string idMH, string idGV) => DAL_MonHoc.PhanCongGiangDay(idMH, idGV);
        public static DataTable GetHVTN() => DAL_HocVien.Get();
        public static void NhapDiemTotNghiep(string idHV, string diem)
            => DAL_HocVienTotNghiep.NhapDiemTotNghiep(idHV, diem);
        public static DataTable GetMH_TTT()
        {
            DataTable dt = DAL_MonHoc.Get();

            dt.Columns.Remove("lich_hoc");
            dt.Columns.Remove("Id_nv");
            dt.Columns.Remove("Phong_hoc");
            dt.Columns.Remove("So_luong_hv");
            dt.Columns.Remove("Hoc_phi");
            dt.Columns.Remove("isOpen");
            dt.Columns["Id_mh"].ColumnName = "Mã môn học";
            dt.Columns["Ten_mh"].ColumnName = "Tên môn học";
            dt.Columns["Id_hp"].ColumnName = "Mã học phần";
            return dt;
        }

        public static bool CheckExistsLichThi(string idMH) => DAL_LichThi.CheckExists(idMH);
        public static DataTable GetNV() => DAL_NhanVien.GetGV();
        public static bool CheckTrungLichCoiThi(string ngayThi, string idNV) => DAL_LichThi.CheckTrungLichCoiThi(ngayThi, idNV);
        public static void ThemLichThi(LichThi lichThi)
            => DAL_LichThi.ThemLichThi(lichThi);
    }
}
