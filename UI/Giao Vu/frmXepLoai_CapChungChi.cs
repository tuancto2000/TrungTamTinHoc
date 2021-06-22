using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmXepLoai_CapChungChi : Form
    {
        public frmXepLoai_CapChungChi()
        {
            InitializeComponent();
        }

        private void frmXepLoai_CapChungChi_Load(object sender, EventArgs e)
        {
            tb_mahv.Enabled = false;
            tb_malop.Enabled = false;
            tb_tenhv.Enabled = false;
            tb_diem.Enabled = false;
            btn_xacNhan.Enabled = false;

            Provider provider = new Provider();
            provider.getConnect();
            try
            {
                SqlCommand cmd = new SqlCommand("EXEC SP_SELECT_HVTN", provider.Connect);
                provider.Connect.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                lv_hv.Items.Clear();

                while (rd.Read())
                {
                    ListViewItem lv = new ListViewItem();
                    lv.SubItems.Add(rd.GetString(0));
                    lv.SubItems.Add(rd.GetString(1));
                    lv.SubItems.Add(rd.GetString(2));
                    if (!rd.IsDBNull(3))
                        lv.SubItems.Add(rd.GetDouble(3).ToString());
                    //lv.SubItems.Add(rd.GetString(3));
                    lv_hv.Items.Add(lv);
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

        private void lv_hv_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem items in lv_hv.SelectedItems)
            {
                tb_mahv.Text = items.SubItems[1].Text;
                tb_malop.Text = items.SubItems[2].Text;
                tb_tenhv.Text = items.SubItems[3].Text;
            }

            tb_diem.Enabled = true;
            btn_xacNhan.Enabled = true;
        }

        private void btn_xacNhan_Click(object sender, EventArgs e)
        {
            if (tb_diem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập điểm!");
                return;
            }

            Provider provider = new Provider();
            provider.getConnect();
            try
            {
                int check = 0;
                SqlCommand cmd = new SqlCommand("EXEC SP_NHAP_DIEM_TOT_NGHIEP @MAHV, @DIEM", provider.Connect);
                cmd.Parameters.Add(new SqlParameter("@MAHV", tb_mahv.Text));
                cmd.Parameters.Add(new SqlParameter("@DIEM", tb_diem.Text));

                provider.Connect.Open();
                cmd.ExecuteReader();

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
            tb_mahv.Clear();
            tb_malop.Clear();
            tb_tenhv.Clear();
            tb_diem.Clear();
            tb_diem.Enabled = false;
            btn_xacNhan.Enabled = false;
        }

        private void tb_diem_TextChanged(object sender, EventArgs e)
        {
            if (tb_diem.Text != "")
            {
                try
                {
                    if (double.Parse(tb_diem.Text) > 10)
                    {
                        tb_diem.Text = "10";
                        MessageBox.Show("Điểm trung bình tối đa là 10");
                    }
                    else if ((double.Parse(tb_diem.Text) < 5) && (tb_diem.Text[0] != '1'))
                    {
                        tb_diem.Text = "5";
                        MessageBox.Show("Điểm trung bình tối thiểu là 5");
                    }
                    else if (tb_diem.Text.Contains("1."))
                    {
                        tb_diem.Text = "5";
                        MessageBox.Show("Điểm trung bình tối thiểu là 5");
                    }
                    else if (tb_diem.Text.Length > 4)
                    {
                        tb_diem.Text = tb_diem.Text.Substring(0, 4);
                        MessageBox.Show("Điểm trung bình được làm tròn 2 chữ số thập phân");
                    }
                }
                catch(Exception)
                {
                    tb_diem.Clear();
                    MessageBox.Show("Vui lòng nhập đúng định dạng chữ số");
                }
            }
        }
    }
}
