using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class DAL_MonHoc : DBConnect
    {
        public static DataTable GetTenLopCC(string idGiaoVien)
        {
            try
            {
                DataTable dt = new DataTable();
                string query = "select id_mh from Mon_hoc " +
                    "where ID_nv = '" + idGiaoVien + "' and isOpen = 1 " +
                    " and  (id_hp = 'HP10004' or id_hp = 'HP10009')";
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
        public static DataTable GetTenLopKT(string idGiaoVien)
        {
            try
            {
                DataTable dt = new DataTable();
                string query = "select id_mh from Mon_hoc " +
                    "where ID_nv = '" + idGiaoVien + "' and isOpen = 1 " +
                    " and  id_hp != 'HP10004' and id_hp != 'HP10009'";
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
        // x tuan
        public static DataTable GiaoVienGetHVCC(string idMonHoc)
        {
            try
            {
                string query = "Select Hoc_vien.id_hv  , Ten_hv  , diem_mon_hoc   " +
                                  "from DKMH_CC join Hoc_vien " +
                                  "on DKMH_CC.Id_hv = Hoc_vien.Id_hv " +
                                  "where id_mh = '" + idMonHoc + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
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
        public static DataTable GiaoVienGetHVKT(string idMonHoc)
        {
            try
            {
                string query = "Select Hoc_vien.id_hv  , Ten_hv  , diem_mon_hoc , So_lan_thi_lai   " +
                                  "from DKMH_KT join Hoc_vien " +
                                  "on DKMH_KT.Id_hv = Hoc_vien.Id_hv " +
                                  "where id_mh = '" + idMonHoc + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
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
        public static void SaveChangeDKCC(Queue<DangKy> ketQua)
        {
            try
            {
                con.Open();
                foreach (DangKy item in ketQua)
                {
                    string query = "UpdateDKCC";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idMonHoc", item.IdMonHoc);
                    cmd.Parameters.AddWithValue("@idHocVien", item.IdHocVien);
                    cmd.Parameters.AddWithValue("@diem", item.Diem);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                con.Close();

            }
        }
        public static void SaveChangeDKKT(Queue<DangKy> ketQua)
        {
            try
            {
                con.Open();
                foreach (DangKy item in ketQua)
                {
                    string query = "UpdateDKKT";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idMonHoc", item.IdMonHoc);
                    cmd.Parameters.AddWithValue("@idHocVien", item.IdHocVien);
                    cmd.Parameters.AddWithValue("@diem", item.Diem);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                con.Close();

            }
        }
        public static DataTable XemHocPhiCC(string idHocVien)
        {
            try
            {
                string query = "select Ten_mh as ten , hoc_phi from Mon_hoc " +

                                 "join DKMH_CC on Mon_hoc.Id_mh = DKMH_CC.Id_mh " +

                                 "where DKMH_CC.id_hv = '" + idHocVien +
                                  "' and Mon_hoc.IsOpen = 1 and DKMH_CC.id_nv is null ";

                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
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
        public static DataTable XemHocPhiKT(string idHocVien)
        {
            try
            {
                string query = "select Ten_mh as ten , hoc_phi from Mon_hoc " +

                                 "join DKMH_KT on Mon_hoc.Id_mh = DKMH_KT.Id_mh " +

                                 "where DKMH_KT.id_hv = '" + idHocVien +
                                 "' and Mon_hoc.IsOpen = 1 and DKMH_KT.id_nv is null ";

                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
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
        public static void DongHocPhiCC(string idKeToan , string idHocVien)
        {
            try
            {
                con.Open();
                string query = "UpdateHocPhiCC";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idKeToan", idKeToan);
                cmd.Parameters.AddWithValue("@idHocVien", idHocVien);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                con.Close();

            }
        }
        public static void DongHocPhiKT(string idKeToan, string idHocVien)
        {
            try
            {
                con.Open();
                string query = "UpdateHocPhiKT";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idKeToan", idKeToan);
                cmd.Parameters.AddWithValue("@idHocVien", idHocVien);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                con.Close();

            }
        }

    }
}
