using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_ChuyenDe : DBConnect
    {
        public static DataTable GiaoVienGetHVCD(string idChuyenDe)
        {
            try
            {
                string query = "Select Hoc_vien.id_hv , Ten_hv   " +
                                  "from DKCD join Hoc_vien " +
                                  "on DKCD.Id_hv = Hoc_vien.Id_hv " +
                                  "where id_cd = '" + idChuyenDe + "'";

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
        public static DataTable XemHocPhi(string idHocVien)
        {
            try
            {
                string query = "select Ten_cd as ten , hoc_phi from Chuyen_De " +

                                 "join DKCD on Chuyen_de.Id_cd = DKCD.Id_cd " +

                                   "where DKCD.id_hv = '" + idHocVien + "' and Chuyen_de.IsOpen = 1 ";

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
        public static void DongHocPhi(string idKeToan ,string idHocVien)
        {
            try
            {
                con.Open();
                string query = "UpdateHocPhiCD";
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
        public static DataTable GetTenLop(string idGiaoVien)
        {
            try
            {
                string query = "select id_cd from ChuyenDe " +


                                 "where DKCD.id_gv = '" + idGiaoVien + "'";

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
    }
}
