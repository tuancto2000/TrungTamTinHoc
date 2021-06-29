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
    public class BUS_Login
    {
        public static string Login(string id , string password)
        {
            string type = id.Substring(0, 2).ToUpper();
            DataTable dt = new DataTable();
            if (type == "HV")
            {
                dt = DAL_HocVien.Login(id, password);
                if (dt.Rows.Count == 1)
                    return "HocVien";
                else return "incorrect";
            }
            else if (type == "NV")
            {
                dt = DAL_NhanVien.Login(id, password);
                if (dt.Rows.Count == 1)
                {
                    string typeNhanVien = dt.Rows[0]["Loai_nhan_vien"].ToString();
                    switch (typeNhanVien)
                    {
                        case "Giáo vụ":
                            return "GiaoVu";
                        case "Giáo viên":
                            return "GiaoVien";
                        case "Kế toán":
                            return "KeToan";
                        default:
                            return "incorrect";
                    }
                }
                else return "incorrect";
            }
            else return "incorrect";
        }

    }
}
