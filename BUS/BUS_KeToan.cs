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
            dt.Columns["ten"].ColumnName = "Tên môn học / chuyên đề";
            dt.Columns["hoc_phi"].ColumnName = "Học phí ";
            return dt;
        }
        public static int DongHocPhi(string idKeToan , string idHocVien)
        {
            try
            {
                BUS_ChuyenDe.DongHocPhi(idKeToan, idHocVien);
                BUS_MonHoc.DongHocPhi(idKeToan, idHocVien);
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
            return 1;
            
        }
        public static int TongHocPhi(DataTable dt)
        {
            int sum = 0;
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dt.Rows[i][1]);
            }
            return sum;
        }
    }
}
