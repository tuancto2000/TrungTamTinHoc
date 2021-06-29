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

            lopCC_dtgv.DataSource = BUS_SinhVien.hienThiLopChungChi("HV100015");
        }

        private void hienLopKT_Click(object sender, EventArgs e)
        {
            lopKT_dtgv.DataSource = BUS_SinhVien.hienThiMonHocKyThuat("HV100015");

        }


        private void hienLopCCDaDK_Click(object sender, EventArgs e)
        {
            monHoc_dtgv.DataSource = BUS_SinhVien.hienThiLopChungChiDaDK("HV100015");
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
        }

        private void dkChungChiB_Click(object sender, EventArgs e)
        {
            int check = -1;
            BUS_SinhVien.dangKyChungChi("HV100015", "CC B", out check);

            if (check == 0)
                MessageBox.Show("Sinh viên đã đăng ký chuyên đề rồi");
            else
                MessageBox.Show("Đăng ký thành công!");
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

        private void dkLopCC_Click(object sender, EventArgs e)
        {
            int check = -1;
            BUS_SinhVien.dangKyLopChungChi("HV100015", maMH, out check);
            if (check == 0)
                MessageBox.Show("Bạn đã đăng ký môn này rồi");
            else if (check == 1)
                MessageBox.Show("Đăng ký môn học thành công");
            else
                MessageBox.Show("loi");
        }

        private void dkLopKT_Click(object sender, EventArgs e)
        {
            int check = -1;
            BUS_SinhVien.dangKyLopKyThuat("HV100015", maMH, out check);
            if (check == 0)
                MessageBox.Show("Bạn đã đăng ký môn này rồi");
            else if (check == 1)
                MessageBox.Show("Đăng ký môn học thành công");
            else
                MessageBox.Show("loi");
        }
        public string maMH = "";
        private void lopCC_dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = lopCC_dtgv.Rows[index];
            maMH = selectedRow.Cells[0].Value.ToString();
        }

        private void lopKT_dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = lopKT_dtgv.Rows[index];
            maMH = selectedRow.Cells[0].Value.ToString();
        }
    }
}
