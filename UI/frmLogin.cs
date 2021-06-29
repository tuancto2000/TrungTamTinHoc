using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
// nv test giao vu NV100021
namespace UI
{
    public partial class frmLogin : Form
    {
        public static String _id = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            _id = txt_taikhoan.Text;
            string idType = BUS_Login.Login(_id, txt_matkhau.Text);

            if ( idType == "incorrect")
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu, Hãy Thử Lại");
            }
            else
            {
                MessageBox.Show("Dang nhap " + _id + " thanh cong");

                switch (idType)
                {
                    case "GiaoVien":
                        frmGiaoVien giaoVien = new frmGiaoVien();
                        giaoVien._id = _id;
                        giaoVien.FormClosing += frm2_FormClosed;
                        giaoVien.Show();
                        break;
                    //case "HocVien":
                    //    frmHocVien giaoVien = new frmGiaoVien();
                    //    break;

                }
                this.Hide();
        
                

            }
        }
        private void frm2_FormClosed(object sender, FormClosingEventArgs e)
        {
            txt_matkhau.Text = "";
            txt_taikhoan.Text = "";
            this.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
