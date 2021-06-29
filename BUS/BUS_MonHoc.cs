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
    public class BUS_MonHoc
    {
        public static DataTable GetTenLop(string _id) => DAL_MonHoc.GetTenLop(_id);

    }
}
