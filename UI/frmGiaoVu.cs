using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmGiaoVu : Form
    {
        public frmGiaoVu()
        {
            InitializeComponent();
        }

        private void tabGiaoVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabGiaoVu.SelectedIndex == 0)
            {
                txtMaLop.Clear();
                txtMaGiaoVien.Clear();
                txtMaMonHoc.Enabled = false;
                txtMaGiaoVien.Enabled = false;
                btnXacNhanTab1.Enabled = false;
                dgvDSLop.DataSource = BUS_GiaoVu.GetMH();
                dgvDSGiaoVien.DataSource = BUS_GiaoVu.GetGV();
            }
            else if (tabGiaoVu.SelectedIndex == 1)
            {
                txtMaHocVien.Clear();
                txtMaLop.Clear();
                txtTenHocVien.Clear();
                txtDiem.Clear();
                btnXacNhanTab2.Enabled = false;
                dgvDSHocVien.DataSource = BUS_GiaoVu.GetHVTN();
            }
        }

        private void btnXacNhanTab1_Click(object sender, EventArgs e)
        {
            int check = 0;
            BUS_GiaoVu.PhanCongGiangDay(txtMaMonHoc.Text, txtMaGiaoVien.Text, out check);

            if (check == 0)
                MessageBox.Show("Cập nhật không thành công! Giáo viên bị trùng lịch dạy");
            else
            {
                MessageBox.Show("Cập nhật thành công!");
                dgvDSLop.DataSource = BUS_GiaoVu.GetMH();
            }

            txtMaMonHoc.Clear();
            txtMaGiaoVien.Clear();
            btnXacNhanTab1.Enabled = false;
        }

        private void btnHuyTab1_Click(object sender, EventArgs e)
        {
            txtMaMonHoc.Clear();
            txtMaGiaoVien.Clear();
            btnXacNhanTab1.Enabled = false;
        }

        private void frmGiaoVu_Load(object sender, EventArgs e)
        {
            txtMaMonHoc.Enabled = false;
            txtMaGiaoVien.Enabled = false;
            btnXacNhanTab1.Enabled = false;
            dgvDSLop.DataSource = BUS_GiaoVu.GetMH();
            dgvDSGiaoVien.DataSource = BUS_GiaoVu.GetGV();
        }

        private void dgvDSLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDSLop.Rows[e.RowIndex];
                txtMaMonHoc.Text = row.Cells["Mã môn học"].Value.ToString();
            }
            if (txtMaGiaoVien.Text != "")
                btnXacNhanTab1.Enabled = true;
        }

        private void dgvDSGiaoVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDSGiaoVien.Rows[e.RowIndex];
                txtMaGiaoVien.Text = row.Cells["Mã giáo viên"].Value.ToString();
            }
            if (txtMaMonHoc.Text != "")
                btnXacNhanTab1.Enabled = true;
        }

        private void btnXacNhanTab2_Click(object sender, EventArgs e)
        {
            if (txtDiem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập điểm!");
                return;
            }

            try
            {
                BUS_GiaoVu.NhapDiemTotNghiep(txtMaHocVien.Text, txtDiem.Text);
                MessageBox.Show("Cập nhật thành công!");
                dgvDSHocVien.DataSource = BUS_GiaoVu.GetHVTN();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtMaHocVien.Clear();
            txtMaLop.Clear();
            txtTenHocVien.Clear();
            txtDiem.Clear();
            txtDiem.Enabled = false;
            btnXacNhanTab2.Enabled = false;
        }

        private void btnHuyTab2_Click(object sender, EventArgs e)
        {
            txtMaHocVien.Clear();
            txtMaLop.Clear();
            txtTenHocVien.Clear();
            txtDiem.Clear();
            txtDiem.Enabled = false;
            btnXacNhanTab2.Enabled = false;
        }

        private void dgvDSHocVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDSHocVien.Rows[e.RowIndex];
                txtMaHocVien.Text = row.Cells["Mã học viên"].Value.ToString();
                txtMaLop.Text = row.Cells["Mã lớp"].Value.ToString();
                txtTenHocVien.Text = row.Cells["Tên học viên"].Value.ToString();
            }
            txtDiem.Enabled = true;
            btnXacNhanTab2.Enabled = true;
        }

        private void txtDiem_TextChanged(object sender, EventArgs e)
        {
            if (txtDiem.Text != "")
            {
                try
                {
                    if (double.Parse(txtDiem.Text) > 10)
                    {
                        txtDiem.Text = "10";
                        MessageBox.Show("Điểm trung bình tối đa là 10");
                    }
                    else if ((double.Parse(txtDiem.Text) < 5) && (txtDiem.Text[0] != '1'))
                    {
                        txtDiem.Text = "5";
                        MessageBox.Show("Điểm trung bình tối thiểu là 5");
                    }
                    else if (txtDiem.Text.Contains("1."))
                    {
                        txtDiem.Text = "5";
                        MessageBox.Show("Điểm trung bình tối thiểu là 5");
                    }
                    else if (txtDiem.Text.Length > 4)
                    {
                        txtDiem.Text = txtDiem.Text.Substring(0, 4);
                        MessageBox.Show("Điểm trung bình được làm tròn 2 chữ số thập phân");
                    }
                }
                catch (Exception)
                {
                    txtDiem.Clear();
                    MessageBox.Show("Vui lòng nhập đúng định dạng chữ số");
                }
            }
        }
    }
}
