using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_MonHoc:DBConnect
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
    }
}
