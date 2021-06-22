using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmPhanCongGiangDay : Form
    {
        public frmPhanCongGiangDay()
        {
            InitializeComponent();
        }

        private void frmPhanCongGiangDay_Load(object sender, EventArgs e)
        {
            tb_mamh.Enabled = false;
            tb_magv.Enabled = false;
            btn_xacNhan.Enabled = false;

            Provider provider = new Provider();
            provider.getConnect();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT ID_MH, TEN_MH FROM MON_HOC", provider.Connect);
                provider.Connect.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                lv_lop.Items.Clear();

                while (rd.Read())
                {
                    ListViewItem lv = new ListViewItem();
                    lv.SubItems.Add(rd.GetString(0));
                    lv.SubItems.Add(rd.GetString(1));
                    lv_lop.Items.Add(lv);
                }
                rd.Close();

                cmd = new SqlCommand("SELECT ID_NV, TEN_NV FROM NHAN_VIEN WHERE LOAI_NHAN_VIEN = N'Giáo viên'", provider.Connect);
                rd = cmd.ExecuteReader();
                lv_gv.Items.Clear();

                while (rd.Read())
                {
                    ListViewItem lv = new ListViewItem();
                    lv.SubItems.Add(rd.GetString(0));
                    lv.SubItems.Add(rd.GetString(1));
                    lv_gv.Items.Add(lv);
                }
                rd.Close();
                provider.Connect.Dispose();
                provider.Connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                provider.disConnect();
            }
        }

        private void lv_lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem items in lv_lop.SelectedItems)
            {
                tb_mamh.Text = items.SubItems[1].Text;
            }
            if (tb_magv.Text != "")
                btn_xacNhan.Enabled = true;
        }

        private void lv_gv_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem items in lv_gv.SelectedItems)
            {
                tb_magv.Text = items.SubItems[1].Text;
            }
            if (tb_mamh.Text != "")
                btn_xacNhan.Enabled = true;
        }

        private void btn_xacNhan_Click(object sender, EventArgs e)
        {
            Provider provider = new Provider();
            provider.getConnect();
            try
            {
                int check = 0;
                SqlCommand cmd = new SqlCommand("EXEC SP_PHAN_CONG_GIANG_DAY @MAMH, @MAGV, @CHECK OUT", provider.Connect);
                cmd.Parameters.Add(new SqlParameter("@MAMH", tb_mamh.Text));
                cmd.Parameters.Add(new SqlParameter("@MAGV", tb_magv.Text));
                cmd.Parameters.Add(new SqlParameter("@CHECK", check)).Direction = ParameterDirection.Output;

                provider.Connect.Open();
                cmd.ExecuteReader();
                check = Convert.ToInt32(cmd.Parameters["@CHECK"].Value);

                if (check == -1)
                    MessageBox.Show("Cập nhật không thành công! Môn học đã có giáo viên phụ trách.");
                else if (check == -2)
                    MessageBox.Show("Cập nhật không thành công! Giáo viên bị trùng lịch dạy");
                else
                    MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                provider.disConnect();
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            tb_mamh.Clear();
            tb_magv.Clear();
            btn_xacNhan.Enabled = false;
        }
    }
}
