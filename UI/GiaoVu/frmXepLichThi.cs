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

            dgvDSNhanVien.DataSource = BUS_GiaoVu.GetNV();
        }

        private void dgvDSNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDSNhanVien.Rows[e.RowIndex];
                txtMaNhanVien.Text = row.Cells["Mã nhân viên"].Value.ToString();
                txtTenNhanVien.Text = row.Cells["Tên nhân viên"].Value.ToString();
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

            BUS_GiaoVu.ThemLichThi(txtMaMonHoc.Text, txtMaNhanVien.Text, dtmNgayThi.Value.ToShortDateString(), txtPhongThi.Text);
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
