using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DangKyMonHocCC
    {


        public string IdMonHoc { get ; set; }
        public string IdHocVien { get ; set ; }
        public string IdNhanVien { get; set; }
        public double Diem { get; set ; }
        public DangKyMonHocCC(string idMonHoc, string idHocVien, string idNhanVien, double diem)
        {
            IdMonHoc = idMonHoc;
            IdHocVien = idHocVien;
            IdNhanVien = idNhanVien;
            Diem = diem;
        }
    }
}
