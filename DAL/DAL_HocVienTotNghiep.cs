using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_HocVienTotNghiep : DBConnect
    {
        public static void NhapDiemTotNghiep(string idHV, string diem)
        {
            SqlCommand cmd = new SqlCommand("EXEC SP_NHAP_DIEM_TOT_NGHIEP @MAHV, @DIEM", con);
            cmd.Parameters.Add(new SqlParameter("@MAHV", idHV));
            cmd.Parameters.Add(new SqlParameter("@DIEM", diem));
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public static DataTable GetHVTN()
        {
            SqlCommand cmd = new SqlCommand("EXEC SP_SELECT_HVTN", con);
            cmd.Connection.Open();
            var dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cmd.Connection.Close();

            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            dt.Columns["Id_hv"].ColumnName = "Mã học viên";
            dt.Columns["Id_lop"].ColumnName = "Mã lớp";
            dt.Columns["Ten_hv"].ColumnName = "Tên học viên";

            return dt;
        }
    }
}
