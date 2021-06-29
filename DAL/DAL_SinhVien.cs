using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_SinhVien : DBConnect
    {
        static DataTable dt;

        public static DataTable hienDanhSachLopCC()
        {
            if (dt != null) return dt;
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from mon_hoc " +
                                                        "where id_hp = 'HP10004'" +
                                                        "or id_hp = 'HP10009'", con);
                dt = new DataTable();
                da.Fill(dt);
                dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            }

            return dt;
            
        }

    }
}
