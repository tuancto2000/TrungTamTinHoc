using DAL;
using DTO;

namespace BUS
{
    public class BUS_LichThi
    {
        public static bool CheckExistsLichThi(string idMH) => DAL_LichThi.CheckExists(idMH);
        public static bool CheckTrungLichCoiThi(string ngayThi, string idNV) => DAL_LichThi.CheckTrungLichCoiThi(ngayThi, idNV);
        public static void ThemLichThi(LichThi lichThi)
            => DAL_LichThi.ThemLichThi(lichThi);
    }
}
