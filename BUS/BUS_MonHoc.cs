using System.Collections.Generic;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_MonHoc
    {
        public static Queue<DangKy> KetQuaHocVien = new Queue<DangKy>();

        public static DataTable GetTenLop(string tenLop , string _id)
        {
            if (tenLop == "Chứng chỉ")
            {
                return DAL_MonHoc.GetTenLopCC(_id);
            }
            else if (tenLop == "Kỹ thuật")
            {
                return DAL_MonHoc.GetTenLopKT(_id);
            }
            else return null;

        }
            
        public static bool CheckExistsLichDay(string idMH, string idGV) => DAL_MonHoc.CheckExistsLichDay(idMH, idGV);
        public static void PhanCongGiangDay(string idMH, string idGV) => DAL_MonHoc.PhanCongGiangDay(idMH, idGV);
        public static DataTable GetMH_PCGD()
        {
            DataTable dt = DAL_MonHoc.Get();

            dt.Columns.Remove("Id_hp");
            dt.Columns.Remove("Id_nv");
            dt.Columns.Remove("Phong_hoc");
            dt.Columns.Remove("So_luong_hv");
            dt.Columns.Remove("Hoc_phi");
            dt.Columns.Remove("isOpen");
            dt.Columns["Id_mh"].ColumnName = "Mã môn học";
            dt.Columns["Ten_mh"].ColumnName = "Tên môn học";
            dt.Columns["lich_hoc"].ColumnName = "Lịch học";
            return dt;
        }
        public static DataTable GetMH_TTT()
        {
            DataTable dt = DAL_MonHoc.Get();

            dt.Columns.Remove("lich_hoc");
            dt.Columns.Remove("Id_nv");
            dt.Columns.Remove("Phong_hoc");
            dt.Columns.Remove("So_luong_hv");
            dt.Columns.Remove("Hoc_phi");
            dt.Columns.Remove("isOpen");
            dt.Columns["Id_mh"].ColumnName = "Mã môn học";
            dt.Columns["Ten_mh"].ColumnName = "Tên môn học";
            dt.Columns["Id_hp"].ColumnName = "Mã học phần";
            return dt;
        }
        public static DataTable GiaoVienGetHVCC(string idMonHoc)
        {
            DataTable dt = DAL_MonHoc.GiaoVienGetHVCC(idMonHoc);
            dt.Columns["id_hv"].ColumnName = "Mã học viên";
            dt.Columns["Ten_hv"].ColumnName = "Tên học viên";
            dt.Columns["diem_mon_hoc"].ColumnName = "Điểm";

            return dt;
        }
        public static DataTable GiaoVienGetHVKT(string idMonHoc)
        {
            DataTable dt = DAL_MonHoc.GiaoVienGetHVKT(idMonHoc);
            dt.Columns["id_hv"].ColumnName = "Mã học viên";
            dt.Columns["Ten_hv"].ColumnName = "Tên học viên";
            dt.Columns["diem_mon_hoc"].ColumnName = "Điểm";
            dt.Columns["So_lan_thi_lai"].ColumnName = "Số lần thi lại ";
            return dt;
        }
        public static void UpdateDiemThi(DangKy dk)
        {
            if( dk.SoLanThiLai <= 2 && dk.Diem >= 0 && dk.Diem <= 10)
            KetQuaHocVien.Enqueue(dk);
        }
        public static void  SaveChange(string tenLop)
        {
            try
            {
                if (tenLop == "Chứng chỉ")
                {
                    DAL_MonHoc.SaveChangeDKCC(KetQuaHocVien);
                }
                else if (tenLop == "Kỹ thuật")
                {
                    DAL_MonHoc.SaveChangeDKKT(KetQuaHocVien);
                }
                
            }
            catch (System.Exception)
            {

                throw;
            }
            KetQuaHocVien.Clear();

        }
        public static int LoaiHocVien(string idHocVien)
        {
            /* 0 : false
             * 1 : hoc vien chung chi
             * 2 : hoc vien ky thuat
             * */
            if (DAL_HocVien.IsHocVienCC(idHocVien) == 1)
            {
                return 1;
            }
            else if (DAL_HocVien.IsHocVienKT(idHocVien) == 1)
                return 2;
            else return 0;
        }

        public static DataTable XemHocPhi(string idHocVien)
        {
            if (LoaiHocVien(idHocVien) == 1)
            {
                return DAL_MonHoc.XemHocPhiCC(idHocVien);
            }
            else if (LoaiHocVien(idHocVien) == 2)
            {
                return DAL_MonHoc.XemHocPhiKT(idHocVien);
            }
            else return null;
        }

        public static void DongHocPhi(string idKeToan , string idHocVien)
        {
            if (LoaiHocVien(idHocVien) == 1)
            {
                DAL_MonHoc.DongHocPhiCC(idKeToan,idHocVien);
            }
            else if (LoaiHocVien(idHocVien) == 2)
            {
                DAL_MonHoc.DongHocPhiKT(idKeToan , idHocVien);
            }
        }


    }
}
