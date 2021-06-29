using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_NhanVien : DBConnect
    {
        public static DataTable GetGV()
        {
            SqlCommand cmd = new SqlCommand("select Id_nv, Ten_nv from Nhan_vien where Loai_nhan_vien = N'Giáo viên'", con);
            cmd.Connection.Open();
            var dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cmd.Connection.Close();
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            dt.Columns["Id_nv"].ColumnName = "Mã giáo viên";
            dt.Columns["Ten_nv"].ColumnName = "Tên giáo viên";

            return dt;
        }
        public static DataTable Login(string id, string password)
        {
            string query = "select * from Nhan_vien " +
                " where id_nv = '" + id + "' and " +
                " MatKhau = '" + password + "'";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
        public static string GetTenGV(string id)
        {
            string query = "select Ten_nv from Nhan_vien " +
                " where id_nv = '" + id + "'";
           
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Connection.Open();
            var dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cmd.Connection.Close();
           
            return dt.Rows[0]["Ten_nv"].ToString();
        }

    }
}
