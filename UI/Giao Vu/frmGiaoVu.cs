using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmGiaoVu : Form
    {
        public frmGiaoVu()
        {
            InitializeComponent();
        }

        private void btnPhanCongGiangDay_Click(object sender, EventArgs e)
        {
            frmPhanCongGiangDay frmPhanCongGiangDay = new frmPhanCongGiangDay();
            this.Hide();
            frmPhanCongGiangDay.ShowDialog();
            this.Show();
        }

        private void btn_XepLoai_Click(object sender, EventArgs e)
        {
            frmXepLoai_CapChungChi frmXepLoai_CapChungChi = new frmXepLoai_CapChungChi();
            this.Hide();
            frmXepLoai_CapChungChi.ShowDialog();
            this.Show();
        }

        private void btn_ToChucThi_Click(object sender, EventArgs e)
        {
            frmToChucThi frmToChucThi = new frmToChucThi();
            this.Hide();
            frmToChucThi.ShowDialog();
            //this.Show();
            this.Close();
        }
    }
}
