using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class frmXepLichThi : Form
    {
        private string _maMH;
        private string _tenMH;
        public frmXepLichThi(string maMH, string tenMH)
        {
            _maMH = maMH;
            _tenMH = tenMH;
            InitializeComponent();
        }

        private void frmXepLichThi_Load(object sender, EventArgs e)
        {
            txtMaMonHoc.Enabled = false;
            txtTenMonHoc.Enabled = false;
            txtMaNhanVien.Enabled = false;
            txtTenNhanVien.Enabled = false;
            txtMaMonHoc.Text = _maMH;
            txtTenMonHoc.Text = _tenMH;

            dgvDSGiaoVien.DataSource = BUS_GiaoVu.GetNV();
        }

        private void dgvDSGiaoVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDSGiaoVien.Rows[e.RowIndex];
                txtMaNhanVien.Text = row.Cells["Mã giáo viên"].Value.ToString();
                txtTenNhanVien.Text = row.Cells["Tên giáo viên"].Value.ToString();
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == "" || txtPhongThi.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            if (!BUS_GiaoVu.CheckTrungLichCoiThi(dtmNgayThi.Value.ToShortDateString(), txtMaNhanVien.Text))
            {
                MessageBox.Show("Nhân viên đã có lịch coi thi vào ngày " + dtmNgayThi.Value.ToShortDateString());
                return;
            }

            var lichThi = new LichThi(txtMaMonHoc.Text, txtMaNhanVien.Text, dtmNgayThi.Value, txtPhongThi.Text);
            BUS_GiaoVu.ThemLichThi(lichThi);
            MessageBox.Show("Thêm lịch thi thành công");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Clear();
            txtTenNhanVien.Clear();
            txtPhongThi.Clear();
        }
    }
}
