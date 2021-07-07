using BUS;
using System;
using System.Windows.Forms;

namespace UI
{

    public partial class Sinh_Vien : Form
    {
        public string _id { get; set; }
        public Sinh_Vien()
        {
            InitializeComponent();
        }

        private void hienLopCC_Click(object sender, EventArgs e)
        {
            try
            {
                lopCC_dtgv.DataSource = BUS_HocVien.hienThiLopChungChi(_id);
            }
            catch
            {
                MessageBox.Show("Bạn chưa đăng ký CC");
            }
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
            else if (check == 1)
                MessageBox.Show("Đăng ký thành công!");
              else if (check == 2)
                MessageBox.Show("Học viên lớp KT k được đk CC");
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
            else if (check == 2)
                MessageBox.Show("Học viên lớp KT k được đk lớp CC");
        }

        private void dkLopKT_Click(object sender, EventArgs e)
        {
            int check = -1;
            BUS_HocVien.dangKyLopKyThuat(_id, maMH, out check);
            if (check == 0)
                MessageBox.Show("Bạn đã đăng ký môn này rồi");
            else if (check == 1)
                MessageBox.Show("Đăng ký môn học thành công");
            else if (check == 2)
                MessageBox.Show("Học viên lớp CC k được đk lớp KT");
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
    }
}
