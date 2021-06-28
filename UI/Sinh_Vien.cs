using BUS;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class Sinh_Vien : Form
    {
        public Sinh_Vien()
        {
            InitializeComponent();
        }

        private void hienLopCC_Click(object sender, EventArgs e)
        {

            lopCC_dtgv.DataSource = BUS_SinhVien.hienThiMonHocChungChi("HV100015");
        }

        private void hienLopKT_Click(object sender, EventArgs e)
        {
            lopKT_dtgv.DataSource = BUS_SinhVien.hienThiMonHocKyThuat("HV100015");

        }


        private void hienLopCCDaDK_Click(object sender, EventArgs e)
        {
            monHoc_dtgv.DataSource = BUS_SinhVien.hienThiMonHocChungChiDaDK("HV100015");
        }

        private void hienLopKTDaDK_Click(object sender, EventArgs e)
        {
            monHoc_dtgv.DataSource = BUS_SinhVien.hienThiMonHocKyThuatDaDK("HV100015");
        }

        private void dkChungChiA_Click(object sender, EventArgs e)
        {
            int check = -1;
            BUS_SinhVien.dangKyChungChi("HV100015", "CC A", out check);

            if (check == 0)
                MessageBox.Show("Sinh viên đã đăng ký chuyên đề rồi");
            else
                MessageBox.Show("Đăng ký thành công!");
            maMHCC_txtBox.Clear();
        }

        private void dkChungChiB_Click(object sender, EventArgs e)
        {
            int check = -1;
            BUS_SinhVien.dangKyChungChi("HV100015", "CC B", out check);

            if (check == 0)
                MessageBox.Show("Sinh viên đã đăng ký chuyên đề rồi");
            else
                MessageBox.Show("Đăng ký thành công!");
            maMHCC_txtBox.Clear();
        }

        private void dkTotNghiep_Click(object sender, EventArgs e)
        {
            int check = -2;
            BUS_SinhVien.dangKyThiTotNghiep("HV100015", out check);

            if (check == -1)
                MessageBox.Show("Chỉ có học viên lớp kỹ thuật mới được đăng ký tốt nghiệp");
            else if (check == 0)
                MessageBox.Show("Bạn đã đăng ký tốt nghiệp rồi");
            else if (check == 1)
                MessageBox.Show("Bạn chưa đủ điều kiện đăng ký tốt nghiệp");
            else
                MessageBox.Show("Đăng ký tốt nghiệp thành công");
        }


    }
}
