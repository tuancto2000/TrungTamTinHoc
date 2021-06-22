using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_Test
    {
        public static void Insert(Test _test) => DAL_Test.Insert(_test);
        public static DataTable Get() => DAL_Test.Get();
        public static bool CheckExist(string id) => DAL_Test.CheckExist(id);

    }

}
