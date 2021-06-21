using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichThi
    {

        public string IdMonHoc { get; set; }
        public string IdGVCoiThi { get; set; }
        public DateTime NgayThi { get; set; }
        public string PhongThi { get; set; }

        public LichThi(string idMonHoc, string idGVCoiThi, DateTime ngayThi, string phongThi)
        {
            IdMonHoc = idMonHoc;
            IdGVCoiThi = idGVCoiThi;
            NgayThi = ngayThi;
            PhongThi = phongThi;
        }
    }
}
