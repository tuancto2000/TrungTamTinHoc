using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DangKy
    {
        public string IdMonHoc { get; set; }
        public string IdHocVien { get; set; }
        public string IdNhanVien { get; set; }
        public double Diem { get; set; }
        public int SoLanThiLai { get; set; }

        public DangKy(string idMonHoc, string idHocVien, string idNhanVien, double diem)
        {
            IdMonHoc = idMonHoc;
            IdHocVien = idHocVien;
            IdNhanVien = idNhanVien;
            Diem = diem;
        }

        public DangKy(string idMonHoc, string idHocVien, string idNhanVien, double diem, int soLanThiLai)
        {
            IdMonHoc = idMonHoc;
            IdHocVien = idHocVien;
            IdNhanVien = idNhanVien;
            Diem = diem;
            SoLanThiLai = soLanThiLai;
        }
    }
}
