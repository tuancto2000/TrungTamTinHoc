using System.Data;
using DAL;

namespace BUS
{
    public class BUS_MonHoc
    {
        public static DataTable GetTenLop(string _id) => DAL_MonHoc.GetTenLop(_id);
        public static bool CheckExistsLichDay(string idMH, string idGV) => DAL_MonHoc.CheckExistsLichDay(idMH, idGV);
        public static void PhanCongGiangDay(string idMH, string idGV) => DAL_MonHoc.PhanCongGiangDay(idMH, idGV);
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
    }
}
