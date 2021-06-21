using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocVienTotNghiep : HocVien
    {
        public double DiemTrungBinh { get; set; }
        public string LoaiTotNghiep { get; set; }
        public HocVienTotNghiep(string idHocVien, string idLop, string tenHocVien, DateTime ngaySinh, string email, string sDT, string diaChi, double diemTrungBinh, string loaiTotNghiep)
            : base(idHocVien, idLop, tenHocVien, ngaySinh, email, sDT, diaChi)
        {
            DiemTrungBinh = diemTrungBinh;
            LoaiTotNghiep = loaiTotNghiep;
        }

    }
}
