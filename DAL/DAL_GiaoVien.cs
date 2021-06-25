using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_GiaoVien : DBConnect
    {
        public static DataTable Get()
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
    }
}
