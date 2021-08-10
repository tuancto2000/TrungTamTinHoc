using BUS;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class frmGiaoVu : Form
    {
        public string _id { get; set; }
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
                txtMaMonHoc1.Enabled = false;
                txtMaGiaoVien.Enabled = false;
                btnXacNhan1.Enabled = false;
                dgvDSLop.DataSource = BUS_MonHoc.GetMH_PCGD();
                dgvDSGiaoVien.DataSource = BUS_NhanVien.GetGV();
            }
            else if (tabGiaoVu.SelectedIndex == 1)
            {
                txtMaHocVien.Clear();
                txtMaLop.Clear();
                txtTenHocVien.Clear();
                txtDiem.Clear();
                btnXacNhan2.Enabled = false;
                dgvDSHocVien.DataSource = BUS_HocVien.GetHVTN();
            }
            else if (tabGiaoVu.SelectedIndex == 2)
            {
                txtMaMonHoc3.Clear();
                txtMaHocPhan.Clear();
                txtTenMonHoc.Clear();
                btnXepLichThi.Enabled = false;
                dgvDSMonHoc.DataSource = BUS_MonHoc.GetMH_TTT();
            }
        }


        // Tab1
        private void btnXacNhanTab1_Click(object sender, EventArgs e)
        {
            if (BUS_MonHoc.CheckExistsLichDay(txtMaMonHoc1.Text, txtMaGiaoVien.Text))
                MessageBox.Show("Cập nhật không thành công! Giáo viên bị trùng lịch dạy");
            else
            {
                BUS_MonHoc.PhanCongGiangDay(txtMaMonHoc1.Text, txtMaGiaoVien.Text);
                MessageBox.Show("Cập nhật thành công!");
                dgvDSLop.DataSource = BUS_MonHoc.GetMH_PCGD();
            }
        }

        private void btnHuyTab1_Click(object sender, EventArgs e)
        {
            txtMaMonHoc1.Clear();
            txtMaGiaoVien.Clear();
            btnXacNhan1.Enabled = false;
        }

        private void frmGiaoVu_Load(object sender, EventArgs e)
        {
            txtMaMonHoc1.Enabled = false;
            txtMaGiaoVien.Enabled = false;
            btnXacNhan1.Enabled = false;
            dgvDSLop.DataSource = BUS_MonHoc.GetMH_PCGD();
            dgvDSGiaoVien.DataSource = BUS_NhanVien.GetGV();
        }

        private void dgvDSLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDSLop.Rows[e.RowIndex];
                txtMaMonHoc1.Text = row.Cells["Mã môn học"].Value.ToString();
            }
            if (txtMaGiaoVien.Text != "")
                btnXacNhan1.Enabled = true;
        }

        private void dgvDSGiaoVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDSGiaoVien.Rows[e.RowIndex];
                txtMaGiaoVien.Text = row.Cells["Mã giáo viên"].Value.ToString();
            }
            if (txtMaMonHoc1.Text != "")
                btnXacNhan1.Enabled = true;
        }
        // End Tab1

        // Tab2
        private void btnXacNhanTab2_Click(object sender, EventArgs e)
        {
            if (txtDiem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập điểm!");
                return;
            }

            try
            {
                BUS_HocVien.NhapDiemTotNghiep(txtMaHocVien.Text, txtDiem.Text);
                MessageBox.Show("Cập nhật thành công!");
                dgvDSHocVien.DataSource = BUS_HocVien.GetHVTN();
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
            btnXacNhan2.Enabled = false;
        }

        private void btnHuyTab2_Click(object sender, EventArgs e)
        {
            txtMaHocVien.Clear();
            txtMaLop.Clear();
            txtTenHocVien.Clear();
            txtDiem.Clear();
            txtDiem.Enabled = false;
            btnXacNhan2.Enabled = false;
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
            btnXacNhan2.Enabled = true;
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
        // End Tab2

        // Tab3
        private void btnXepLichThi_Click(object sender, EventArgs e)
        {
            if(BUS_LichThi.CheckExistsLichThi(txtMaMonHoc3.Text))
            {
                MessageBox.Show("Môn học đã được xếp lịch thi");
                return;
            }    

            var frmXepLichThi = new frmXepLichThi(txtMaMonHoc3.Text, txtTenMonHoc.Text);
            this.Hide();
            frmXepLichThi.ShowDialog();
            this.Show();
        }

        private void btnHuy3_Click(object sender, EventArgs e)
        {
            txtMaMonHoc3.Clear();
            txtMaHocPhan.Clear();
            txtTenMonHoc.Clear();
            btnXepLichThi.Enabled = false;
        }

        private void dgvDSMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDSMonHoc.Rows[e.RowIndex];
                txtMaMonHoc3.Text = row.Cells["Mã môn học"].Value.ToString();
                txtMaHocPhan.Text = row.Cells["Mã học phần"].Value.ToString();
                txtTenMonHoc.Text = row.Cells["Tên môn học"].Value.ToString();
            }
            btnXepLichThi.Enabled = true;
        }
        // End Tab3
    }
}
