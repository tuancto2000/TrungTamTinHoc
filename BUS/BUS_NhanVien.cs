using System.Data;
using DAL;

namespace BUS
{
    public class BUS_NhanVien
    {
        public static DataTable GetGV() => DAL_NhanVien.GetGV();
    }
}
