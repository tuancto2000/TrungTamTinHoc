using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using DTO;

namespace DAL
{

    public class DAL_DangKyMonHoc_CC: DBConnect
    {
        public static DataTable GiaoVienGet(string tenMonHoc)
        {
            try
            {
                string query = "Select Hoc_vien.id_hv  , Ten_hv  , diem_mon_hoc   " +
                                  "from DKMH_CC join Hoc_vien " +
                                  "on DKMH_CC.Id_hv = Hoc_vien.Id_hv " +
                                  "where id_mh = '" + tenMonHoc + "'";
                                
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
                con.Open();
                dt.Load(cmd.ExecuteReader());
                dt.Columns["id_hv"].ColumnName = "Mã học viên";
                dt.Columns["Ten_hv"].ColumnName = "Tên học viên";
                dt.Columns["diem_mon_hoc"].ColumnName = "Điểm";


                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public static void SaveChange(Queue<DangKyMonHocCC> ketQua)
        {
            try
            {
                con.Open();
                foreach (DangKyMonHocCC item in ketQua)
                {
                    string query = "UpdateDKCC";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idMonHoc", item.IdMonHoc);
                    cmd.Parameters.AddWithValue("@idHocVien", item.IdHocVien);
                    cmd.Parameters.AddWithValue("@diem", item.Diem);
                    //con.Open();
                    //cmd.Parameters.Add("@id_mh",SqlDbType.VarChar, 10,item.IdMonHoc);
                    //cmd.Parameters.Add("@id_hv", SqlDbType.VarChar,10,item.IdHocVien);
                    //cmd.Parameters.Add("@diem", SqlDbType.Float,0,item.Diem.ToString());

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                //con.Close();
                throw ex;
                
            }
            finally
            {
                con.Close();

            }
        }

    }
}
