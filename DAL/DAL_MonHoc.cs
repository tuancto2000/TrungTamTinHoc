using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_MonHoc : DBConnect
    {
        public static DataTable Get()
        {
            SqlCommand cmd = new SqlCommand("select * from Mon_hoc where Id_nv is null", con);
            cmd.Connection.Open();
            var dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cmd.Connection.Close();
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };

            return dt;
        }

        public static bool CheckExistsLichDay(string idMH, string idGV)
        {
            SqlCommand cmd = new SqlCommand("EXEC SP_CHECK_EXISTS_LD @MAMH, @MAGV", con);
            cmd.Parameters.Add(new SqlParameter("@MAMH", idMH));
            cmd.Parameters.Add(new SqlParameter("@MAGV", idGV));
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

        public static void PhanCongGiangDay(string idMH, string idGV)
        {
            SqlCommand cmd = new SqlCommand("update Mon_hoc set id_nv = '" + idGV + "' " +
                                                 "where id_mh = '" + idMH +"'", con);
            cmd.Parameters.Add(new SqlParameter("@MAMH", idMH));
            cmd.Parameters.Add(new SqlParameter("@MAGV", idGV));
            cmd.Connection.Open();
            cmd.ExecuteReader();
            cmd.Connection.Close();
        }
    }
}
