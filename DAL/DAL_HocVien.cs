
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
        public static int IsHocVienCC(string idHocVien)
        {
            string query = "select count(*) from Hoc_vien_lop_chung_chi " +
                " where id_hv = '" + idHocVien + "'";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            if (dt.Rows.Count == 1) return 1;
            else return 0;
        }
        public static int IsHocVienKT(string idHocVien)
        {
            string query = "select count(*) from Hoc_vien_lop_ky_thuat " +
                " where id_hv = '" + idHocVien + "'";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();

            if (dt.Rows.Count == 1) return 1;
            else return 0;
        }

    }
}
