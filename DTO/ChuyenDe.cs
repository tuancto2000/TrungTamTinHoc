using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChuyenDe
    {
        public string IdChuyenDe { get; set; }
        public string IdNhanVien { get; set; }
        public string Ten { get; set; }
        public string Lichhoc { get; set; }
        public string Phonghoc { get; set; }
        public int SoLuongHocVien { get; set; }
        public double HocPhi { get; set; } 
        
        public ChuyenDe(string idChuyenDe, string idNhanVien, string ten, string lichhoc, string phonghoc, int soLuongHocVien, double hocPhi)
        {
            IdChuyenDe = idChuyenDe;
            IdNhanVien = idNhanVien;
            Ten = ten;
            Lichhoc = lichhoc;
            Phonghoc = phonghoc;
            SoLuongHocVien = soLuongHocVien;
            HocPhi = hocPhi;
        }


    }
}
