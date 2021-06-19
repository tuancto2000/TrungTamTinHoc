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
        DAL_Test dal_test = new DAL_Test();
        public void Insert(Test _test) =>  dal_test.Insert(_test);
        public DataTable Get() => dal_test.Get();

    }

}
