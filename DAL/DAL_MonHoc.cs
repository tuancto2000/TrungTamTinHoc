using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
        // TRƯỜNG
        public static void dangKyChungChi(string idHV, string loaiCC, out int flag)
        {
            flag = -1;
            SqlCommand cmd = new SqlCommand("dbo.DANG_KY_CHUNG_CHI", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID_HV", idHV));
            cmd.Parameters.Add(new SqlParameter("@LOAI_CC", loaiCC));
            cmd.Parameters.Add(new SqlParameter("@FLAG", flag)).Direction = ParameterDirection.Output;

            cmd.Connection.Open();
            cmd.ExecuteReader();
            flag = Convert.ToInt32(cmd.Parameters["@FLAG"].Value);
            cmd.Connection.Close();
        }
        public static DataTable hienThiLopChungChi(string idHV)
        {
            SqlCommand cmd = new SqlCommand("dbo.HIEN_THI_LOP_CHUNG_CHI", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID_HV", idHV)).Value = idHV;

            cmd.Connection.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());          
            cmd.Connection.Close();
            return dt;
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
