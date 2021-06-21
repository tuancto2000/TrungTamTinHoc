using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DangKyChuyenDe
    {

        public string IdChuyenDe { get; set; }
        public string IdHocVien { get; set; }
        public string IdNhanVien { get; set; }

        public DangKyChuyenDe(string idChuyenDe, string idHocVien, string idNhanVien)
        {
            IdChuyenDe = idChuyenDe;
            IdHocVien = idHocVien;
            IdNhanVien = idNhanVien;
        }


    }
}
