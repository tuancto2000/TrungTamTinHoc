using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_LichThi : DBConnect
    {
        public static bool CheckExists(string idMH)
        {
            SqlCommand cmd = new SqlCommand("select * from Lich_thi where id_MH = '" + idMH + "'", con);
            cmd.Connection.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                cmd.Connection.Close();
                return true;
            }
            cmd.Connection.Close();
            return false;
        }

        public static bool CheckTrungLichCoiThi(string ngayThi, string idNV)
        {
            SqlCommand cmd = new SqlCommand("select * from Lich_thi where ngay_thi = cast('" + ngayThi + "' as date)" +
                " and gv_coi_thi = '" + idNV + "'", con);
            cmd.Connection.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                cmd.Connection.Close();
                return false;
            }
            cmd.Connection.Close();
            return true;
        }

        public static void ThemLichThi(LichThi lichThi)
        {
            SqlCommand cmd = new SqlCommand("insert into lich_thi values('" + lichThi.IdMonHoc + "', '" + lichThi.IdGVCoiThi 
                + "', " + "cast('" + lichThi.NgayThi + "' as date), '" + lichThi.PhongThi + "')", con);
            cmd.Connection.Open();
            cmd.ExecuteReader();
        }
    }
}
