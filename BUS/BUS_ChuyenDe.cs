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
    public class BUS_ChuyenDe
    {
        public static DataTable GiaoVienGetHVCD(string idChuyenDe)
        {
            DataTable dt = DAL_ChuyenDe.GiaoVienGetHVCD(idChuyenDe);
            dt.Columns["id_hv"].ColumnName = "Mã học viên";
            dt.Columns["Ten_hv"].ColumnName = "Tên học viên";
            return dt;
        }
    }
}
