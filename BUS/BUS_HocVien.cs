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
        public static DataTable GetHVfromMH(string tenLop , string idMonHoc)
        {
            if(tenLop != null && idMonHoc != null )
            switch (tenLop)
            {
                case "Chứng Chỉ":
                    return GetHVCCfromMH(idMonHoc);
                case "Kĩ thuật":
                    return GetHVCCfromMH(idMonHoc);
                case "Chuyên đề":
                    return GetHVCCfromMH(idMonHoc);
            }
            return null;
        }
        public static DataTable GetHVCCfromMH(string idMonHoc)
        {
            // datatable : id hoc sinh, ten hoc vien , diem , lan thi lai
            return BUS_KetQuaDangKyCC.GiaoVienGet(idMonHoc);
        }
        public static DataTable GetKTfromMH(string idMonHoc)
        {

            return null;
        }
        public static DataTable GetHVCDfromMH(string idMonHoc)
        {

            return null;
        }
    }
}
