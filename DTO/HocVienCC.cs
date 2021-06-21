using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocVienCC:HocVien
    {
        public string LoaiChungChi { get; set; }
        public HocVienCC(string idHocVien, string idLop, string tenHocVien, DateTime ngaySinh, string email, string sDT, string diaChi, string loaiChungChi)
            : base(idHocVien, idLop, tenHocVien, ngaySinh, email, sDT, diaChi)
        {
            LoaiChungChi = loaiChungChi;
        }
    }
}
