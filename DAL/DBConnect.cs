using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection con = new SqlConnection("Data Source=DESKTOP-G5N68VN;Initial Catalog=TrungtamTinhoc;Integrated Security=True");
    }
}
