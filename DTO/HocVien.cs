using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocVien
    {
        
        public string IdHocVien { get; set; }
        public string IdLop { get; set; }
        public string TenHocVien { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }

        public HocVien(string idHocVien, string idLop, string tenHocVien, DateTime ngaySinh, string email, string sDT, string diaChi)
        {
            IdHocVien = idHocVien;
            IdLop = idLop;
            TenHocVien = tenHocVien;
            NgaySinh = ngaySinh;
            Email = email;
            SDT = sDT;
            DiaChi = diaChi;
        }
    }
}
