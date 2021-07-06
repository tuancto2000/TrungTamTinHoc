using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUS_KeToan
    {
        public static DataTable XemHocPhi ( string idHocVien)
        {
            DataTable dt = new DataTable();
            dt = BUS_MonHoc.XemHocPhi(idHocVien);
            dt.Merge(BUS_ChuyenDe.XemHocPhi(idHocVien));
            return dt;
        }
        public static void DongHocPhi(string idKeToan , string idHocVien)
        {
            BUS_ChuyenDe.DongHocPhi(idKeToan, idHocVien);
            BUS_MonHoc.DongHocPhi(idKeToan, idHocVien);
        }
    }
}
