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
    }
}
