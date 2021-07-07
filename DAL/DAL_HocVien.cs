
﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HocVien : DBConnect
    {
        public static DataTable Get()
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
        public static  DataTable Login(string id , string password )
        {
            string query = "select * from Hoc_vien " +
                " where id_hv = '" + id + "' and " +
                " Mat_Khau = '" + password + "'";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
    }
}
