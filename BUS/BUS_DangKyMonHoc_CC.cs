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
    public class BUS_KetQuaDangKyCC
    {
        public static Queue<DangKyMonHocCC> KetQuaHocVien = new Queue<DangKyMonHocCC>();
        public static DataTable GiaoVienGet(string idMonHoc) => DAL_DangKyMonHoc_CC.GiaoVienGet(idMonHoc);
        public  static void UpdateDiemThi(DangKyMonHocCC dkmh)
        {
            KetQuaHocVien.Enqueue(dkmh);
        }
        public static void SaveChange()
        {
            DAL_DangKyMonHoc_CC.SaveChange(KetQuaHocVien);
            KetQuaHocVien.Clear();
        }
    }
}
