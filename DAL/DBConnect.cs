using System.Data.SqlClient;

namespace DAL
{
    public class DBConnect
    {
        //static protected SqlConnection con = new SqlConnection("Data Source=DESKTOP-G5N68VN;Initial Catalog=TrungtamTinhoc;Integrated Security=True");
        //static protected SqlConnection con = new SqlConnection("Data Source=HOANGPHUC;Initial Catalog=TTTH;Integrated Security=True");
        static protected SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLExpress;Initial Catalog=pttk;Integrated Security=True");
    }
}
