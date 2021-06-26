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
    public class DAL_Test : DbConnect
    {

        public static DataTable Get()
        {
            try
            {
                string query = "Slect * from test";
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Insert(Test _test)
        {
            
        }
        

    }
}
