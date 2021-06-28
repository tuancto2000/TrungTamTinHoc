<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
﻿using System.Data.SqlClient;
>>>>>>> 795ac4f288adab26cb69d77cee52a3bfc16b7cf7

namespace DAL
{
    public class DBConnect
    {
<<<<<<< HEAD
        static protected SqlConnection con = new SqlConnection("Data Source=DESKTOP-G5N68VN;Initial Catalog=TrungtamTinhoc;Integrated Security=True");

        
=======
        //static protected SqlConnection con = new SqlConnection("Data Source=DESKTOP-G5N68VN;Initial Catalog=TrungtamTinhoc;Integrated Security=True");
        //static protected SqlConnection con = new SqlConnection("Data Source=HOANGPHUC;Initial Catalog=TTTH;Integrated Security=True");
        static protected SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLExpress;Initial Catalog=pttk;Integrated Security=True");

>>>>>>> 795ac4f288adab26cb69d77cee52a3bfc16b7cf7
    }
}
