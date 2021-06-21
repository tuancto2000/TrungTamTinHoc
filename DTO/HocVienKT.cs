using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocVienKT : HocVien
    {
       public int SoHocPhanHoanThanh { get; set;  }
        public HocVienKT(string idHocVien, string idLop, string tenHocVien, DateTime ngaySinh, string email, string sDT, string diaChi, int soHocPhanHoanThanh)
            :base(idHocVien, idLop, tenHocVien, ngaySinh,email,sDT,diaChi)
        {
            SoHocPhanHoanThanh = soHocPhanHoanThanh;
        }

    }
}
