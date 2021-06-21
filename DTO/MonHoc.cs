using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class MonHoc
	{

        public string IdMonHoc { get; set; }
		public string IdHocPhan { get; set; }
		public string IdNhanVien { get; set; }
		public string Ten { get; set; }
		public string LichHoc { get; set; }
		public string PhongHoc { get; set; }
		public int SoLuongHocVien { get; set; }
		public double HocPhi { get; set; }
		public int IsOpen { get; set; }
        public MonHoc(string idMonHoc, string idHocPhan, string idNhanVien, string ten, string lichHoc, string phongHoc, int soLuongHocVien, double hocPhi, int isOpen)
        {
            IdMonHoc = idMonHoc;
            IdHocPhan = idHocPhan;
            IdNhanVien = idNhanVien;
            Ten = ten;
            LichHoc = lichHoc;
            PhongHoc = phongHoc;
            SoLuongHocVien = soLuongHocVien;
            HocPhi = hocPhi;
            IsOpen = isOpen;
        }


    }
}
