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
        static DataTable dt;

        public static DataTable GetTenLop()
        {

            if (dt != null) return dt;

            else
            {

                SqlDataAdapter da = new SqlDataAdapter("select Ten_mh from Mon_hoc where ID_nv = 'NV100010' ", con);
                dt = new DataTable();
                da.Fill(dt);
            }

            return dt;
        }
    }
}
