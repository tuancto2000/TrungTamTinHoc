using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HocVien:DBConnect
    {
        static DataTable dt;

        public static DataTable Get()
        {

            if (dt != null) return dt;

            else
            {

                SqlDataAdapter da = new SqlDataAdapter("select * from HocVien", con);
                dt = new DataTable();
                da.Fill(dt);
                dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            }

            return dt;
        }
        public static DataTable  GetHVfromLop(string idLop)
        {
            //return dt.Select("Id_")
            return null;
        }
    }
}
