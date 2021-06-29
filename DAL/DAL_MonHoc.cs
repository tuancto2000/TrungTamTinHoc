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
      
        public static void dangKyLopChungChi(string idHV, string maMH, out int flag)
        {
            flag = -1;
            SqlCommand cmd = new SqlCommand("dbo.DANG_KY_LOP_CHUNG_CHI", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID_HV", idHV));
            cmd.Parameters.Add(new SqlParameter("@ID_MH", maMH));
            cmd.Parameters.Add(new SqlParameter("@FLAG", flag)).Direction = ParameterDirection.Output;

            cmd.Connection.Open();
            cmd.ExecuteReader();
            flag = Convert.ToInt32(cmd.Parameters["@FLAG"].Value);
            cmd.Connection.Close();
        }
        public static DataTable hienThiLopChungChiDaDK(string idHV)
        {
            SqlCommand cmd = new SqlCommand("select * from DKMH_CC where Id_hv = '" + idHV + "'", con);
            cmd.Connection.Open();
            var dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cmd.Connection.Close();

            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            dt.Columns["Id_mh"].ColumnName = "Mã môn học";
            dt.Columns["Id_nv"].ColumnName = "Mã giáo viên";
            dt.Columns["Id_hv"].ColumnName = "Mã học viên";
            dt.Columns["Diem_mon_hoc"].ColumnName = "Điểm môn học";
            return dt;
        }
        public static DataTable hienThiMonHocKyThuat(string idHV)
        {
            SqlCommand cmd = new SqlCommand("dbo.HIEN_THI_MON_HOC_KY_THUAT", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID_HV", idHV)).Value = idHV;

            cmd.Connection.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cmd.Connection.Close();
            return dt;
        }
        public static void dangKyKyThuat(string idHV)
        {
            SqlCommand cmd = new SqlCommand("dbo.DANG_KY_KY_THUAT", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID_HV", idHV));
            cmd.Connection.Open();
            cmd.ExecuteReader();
            cmd.Connection.Close();
        }
        public static void dangKyLopKyThuat(string idHV, string maMH, out int flag)
        {
            flag = -1;
            SqlCommand cmd = new SqlCommand("dbo.DANG_KY_LOP_KY_THUAT", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID_HV", idHV));
            cmd.Parameters.Add(new SqlParameter("@ID_MH", maMH));
            cmd.Parameters.Add(new SqlParameter("@FLAG", flag)).Direction = ParameterDirection.Output;

            cmd.Connection.Open();
            cmd.ExecuteReader();
            flag = Convert.ToInt32(cmd.Parameters["@FLAG"].Value);
            cmd.Connection.Close();
        }

        public static DataTable hienThiMonHocKyThuatDaDK(string idHV)
        {
            SqlCommand cmd = new SqlCommand("select * from DKMH_KT where Id_hv = '" + idHV + "'", con);
            cmd.Connection.Open();
            var dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cmd.Connection.Close();

            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            dt.Columns["Id_mh"].ColumnName = "Mã môn học";
            dt.Columns["Id_nv"].ColumnName = "Mã giáo viên";
            dt.Columns["Id_hv"].ColumnName = "Mã học viên";
            dt.Columns["Diem_mon_hoc"].ColumnName = "Điểm môn học";
            dt.Columns["So_lan_thi_lai"].ColumnName = "Số lần thi lại";

            return dt;
        }

        public static void dangKyThiTotNghiep(string idHV, out int flag)
        {
            flag = -2;
            SqlCommand cmd = new SqlCommand("dbo.DANG_KY_TOT_NGHIEP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID_HV", idHV));
            cmd.Parameters.Add(new SqlParameter("@FLAG", flag)).Direction = ParameterDirection.Output;

            cmd.Connection.Open();
            cmd.ExecuteReader();
            flag = Convert.ToInt32(cmd.Parameters["@FLAG"].Value);
            cmd.Connection.Close();
        }
    }
}
