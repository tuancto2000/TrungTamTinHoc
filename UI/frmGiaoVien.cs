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

namespace TrungTamTinHoc
{
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien()
        {
            InitializeComponent();
        }
        void ShowComBoBox()
        {
            try
            {
                 cboLop.DataSource =  BUS_MonHoc.GetTenLop();
                cboLop.DisplayMember = "Ten_mh";
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

            
        }


        private void txtDiachiGV_TextChanged(object sender, EventArgs e)
        {
            
        }



        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            this.ShowComBoBox();

        }

        private void XemDSHV_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string idLop = cboLop.SelectedIndex.ToString();
            dgvHV.DataSource = BUS_HocVien.GetHVfromMH(idLop);
        }
    }
}