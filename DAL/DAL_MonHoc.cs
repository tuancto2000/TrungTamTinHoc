using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_MonHoc : DBConnect
    {
        public static DataTable GetTenLop()
        {
            try
            {
                DataTable dt = new DataTable();
                string query = "select id_mh from Mon_hoc where ID_nv = 'NV100021'";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
        }
        public static DataTable Get1()
        {
            SqlCommand cmd = new SqlCommand("select Id_mh, Ten_mh, lich_hoc from Mon_hoc where Id_nv is null", con);
            cmd.Connection.Open();
            var dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cmd.Connection.Close();
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            dt.Columns["Id_mh"].ColumnName = "Mã môn học";
            dt.Columns["Ten_mh"].ColumnName = "Tên môn học";
            dt.Columns["lich_hoc"].ColumnName = "Lịch học";

            return dt;
        }

        public static void PhanCongGiangDay(string idMH, string idGV, out int check)
        {
            check = 0;
            SqlCommand cmd = new SqlCommand("EXEC SP_PHAN_CONG_GIANG_DAY @MAMH, @MAGV, @CHECK OUT", con);
            cmd.Parameters.Add(new SqlParameter("@MAMH", idMH));
            cmd.Parameters.Add(new SqlParameter("@MAGV", idGV));
            cmd.Parameters.Add(new SqlParameter("@CHECK", check)).Direction = ParameterDirection.Output;

            cmd.Connection.Open();
            cmd.ExecuteReader();
            check = Convert.ToInt32(cmd.Parameters["@CHECK"].Value);
            cmd.Connection.Close();
        }

        public static DataTable Get2()
        {
            SqlCommand cmd = new SqlCommand("select Id_mh, Id_hp, Ten_mh from Mon_hoc where IsOpen = 1", con);
            cmd.Connection.Open();
            var dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cmd.Connection.Close();
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            dt.Columns["Id_mh"].ColumnName = "Mã môn học";
            dt.Columns["Id_hp"].ColumnName = "Mã học phần";
            dt.Columns["Ten_mh"].ColumnName = "Tên môn học";

            return dt;
        }
    }
}
