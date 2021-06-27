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
    }
}
