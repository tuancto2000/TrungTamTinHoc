using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_HocVien
    {
        public static DataTable GetHVfromMH(string idMonHoc)
        {
            // xem trong DKCC vs DKKT => lay ra id hoc vien
            BUS_DangKyMonHocKT.GetHVbyIdMonHoc( idMonHoc).Rows["Id_M"]


            // select trong hocvien 


            // gan vao hocvien[] trong monhoc
            return null;
        }
    }
}
