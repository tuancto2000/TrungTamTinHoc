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
    public class DAL_Test : DBConnect
    {
         DataTable dt = new DataTable();
        public DataTable Get()
        {
            try
            {
                string query = "Select * from test";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public void Insert(Test _test)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = new SqlCommand("InsertToTest", con);
                da.InsertCommand.CommandType = CommandType.StoredProcedure;
                da.InsertCommand.Parameters.Add("@ID", SqlDbType.NChar, 10, "ID");
                da.InsertCommand.Parameters.Add("@point", SqlDbType.Float, 0, "point");

                DataRow r = dt.NewRow();
                r["id"] = _test.Id;
                r["point"] = _test.Point;
                dt.Rows.Add(r);
                da.Update(dt);

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
