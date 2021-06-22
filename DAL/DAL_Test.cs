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
        static DataTable dt;

        public static DataTable Get()
        {

            if (dt != null) return dt;

            else
            {

                SqlDataAdapter da = new SqlDataAdapter("select * from test", con);
                dt = new DataTable();
                da.Fill(dt);
                dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            }    

            return dt;
        }

        public static void Insert(Test _test)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from test",con);
                DataRow r = dt.NewRow();
                r["id"] = _test.Id;
                r["point"] = _test.Point;
                dt.Rows.Add(r);
                SqlCommandBuilder cm = new SqlCommandBuilder(da);
                da.Update(dt);

            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Update(Test _test)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from test", con);

                DataRow r = dt.Rows.Find(_test.Id);
                dt.Rows.Add(r);
                r["point"] = _test.Point;
                SqlCommandBuilder cm = new SqlCommandBuilder(da);
                da.Update(dt);

            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Delete(Test _test)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from test", con);
                DataRow r = dt.Rows.Find(_test.Id);
                r.Delete();
                SqlCommandBuilder cm = new SqlCommandBuilder(da);
                da.Update(dt);

            }
            catch (Exception)
            {
                throw;
            }
        }
        public static bool CheckExist(string id)
        {
            if (dt == null)
            {
                dt = new DataTable();
                dt = Get();
                
            }
            DataRow r = dt.Rows.Find(id);
            if (r != null)
                return true;
            else return false;
        }

    }
}
