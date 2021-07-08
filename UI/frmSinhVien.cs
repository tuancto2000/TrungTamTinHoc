using BUS;
using System;
using System.Windows.Forms;

namespace UI
{

    public partial class frmSinhVien : Form
    {
        public string _id { get; set; }
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void hienLopCC_Click(object sender, EventArgs e)
        {

            lopCC_dtgv.DataSource = BUS_HocVien.hienThiLopChungChi(_id);
        }

        private void hienLopKT_Click(object sender, EventArgs e)
        {
            lopKT_dtgv.DataSource = BUS_HocVien.hienThiLopKyThuat(_id);

        }


        private void hienLopCCDaDK_Click(object sender, EventArgs e)
        {
            monHoc_dtgv.DataSource = BUS_HocVien.hienThiLopChungChiDaDK(_id);
        }

        private void hienLopKTDaDK_Click(object sender, EventArgs e)
        {
            monHoc_dtgv.DataSource = BUS_HocVien.hienThiMonHocKyThuatDaDK(_id);
        }

        private void dkChungChiA_Click(object sender, EventArgs e)
        {
            int check = -1;
            BUS_HocVien.dangKyChungChi(_id, "CC A", out check);

            if (check == 0)
                MessageBox.Show("Sinh viên đã đăng ký chuyên đề rồi");
            else
                MessageBox.Show("Đăng ký thành công!");
        }

        private void dkChungChiB_Click(object sender, EventArgs e)
        {
            int check = -1;
            BUS_HocVien.dangKyChungChi(_id, "CC B", out check);

            if (check == 0)
                MessageBox.Show("Sinh viên đã đăng ký chuyên đề rồi");
            else
                MessageBox.Show("Đăng ký thành công!");
        }

        private void dkTotNghiep_Click(object sender, EventArgs e)
        {
            int check = -2;
            BUS_HocVien.dangKyThiTotNghiep(_id, out check);

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
            BUS_HocVien.dangKyLopChungChi(_id, maMH, out check);
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
            BUS_HocVien.dangKyLopKyThuat(_id, maMH, out check);
            if (check == 0)
                MessageBox.Show("Bạn đã đăng ký môn này rồi");
            else if (check == 1)
                MessageBox.Show("Đăng ký môn học thành công");
            else
                MessageBox.Show("Học viên lớp chứng chỉ không được đăng ký lớp kỹ thuật");
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

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            int loaiHV = BUS_MonHoc.LoaiHocVien(_id);
            if (loaiHV == 1)
                hienLopKT.Enabled = false;
        }
    }
}
