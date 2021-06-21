using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        
        public string IDdNhanVien { get; set; }
		public string Ten { get; set; }
		public string Email { get; set; }
		public string SDT { get; set; }
		public string DiaChi { get; set; }
		public DateTime NgaySinh { get; set; }
		public string Loai { get; set; }

        public NhanVien(string iDdNhanVien, string ten, string email, string sDT, string diaChi, DateTime ngaySinh, string loai)
        {
            IDdNhanVien = iDdNhanVien;
            Ten = ten;
            Email = email;
            SDT = sDT;
            DiaChi = diaChi;
            NgaySinh = ngaySinh;
            Loai = loai;
        }


    }
}
