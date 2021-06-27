using System;

namespace DTO
{
    public class LichThi
    {

        public string IdMonHoc { get; set; }
        public string IdGVCoiThi { get; set; }
        public DateTime NgayThi { get; set; }
        public string PhongThi { get; set; }
        public LichThi(string idMonHoc, string idGVCoiThi, DateTime ngayThi, string phongThi)
        {
            IdMonHoc = idMonHoc;
            IdGVCoiThi = idGVCoiThi;
            NgayThi = ngayThi;
            PhongThi = phongThi;
        }
    }
}
