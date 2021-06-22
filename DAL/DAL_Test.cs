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
        public DAL_Test()
        {
            try
            {
                string query = "Select * from test";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        public DataTable Get()
        {
            return dt;
        }

        public void Insert(Test _test)
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
        public void Update(Test _test)
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
        public void Delete(Test _test)
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
        public bool CheckExist(string id)
        {
            DataRow r = dt.Rows.Find(id);
            if (r != null)
                return true;
            else return false;
        }

    }
}
