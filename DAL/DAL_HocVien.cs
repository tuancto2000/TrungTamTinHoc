<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HocVien:DBConnect
    {
        static DataTable dt;

        public static DataTable Get()
        {

            if (dt != null) return dt;

            else
            {

                SqlDataAdapter da = new SqlDataAdapter("select * from HocVien", con);
                dt = new DataTable();
                da.Fill(dt);
                dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            }

            return dt;
        }
        public static DataTable  GetHVfromLop(string idLop)
        {
            //return dt.Select("Id_")
            return null;
        }
=======
﻿using System.Data;
using System.Data.SqlClient;

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
>>>>>>> 795ac4f288adab26cb69d77cee52a3bfc16b7cf7
    }
}
