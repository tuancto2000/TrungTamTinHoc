using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmToChucThi : Form
    {
        public frmToChucThi()
        {
            InitializeComponent();
        }

        private void frmToChucThi_Load(object sender, EventArgs e)
        {
            tb_mamh.Enabled = false;
            tb_tenmh.Enabled = false;
            btn_xacNhan.Enabled = false;
        }

        private void lv_mh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_xacNhan_Click(object sender, EventArgs e)
        {

        }

        private void btn_huy_Click(object sender, EventArgs e)
        {

        }
    }
}
