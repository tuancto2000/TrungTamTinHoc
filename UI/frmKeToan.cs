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
namespace UI
{

    public partial class frmKeToan : Form
    {
        public string _id { get; set; }
        public frmKeToan()
        {
            InitializeComponent();
        }

        private void bntXemHocPhi_Click(object sender, EventArgs e)
        {
            dgvHocPhi.Show();
            DataTable hocphi = new DataTable();
            hocphi = BUS_KeToan.XemHocPhi(txbIDHV.Text.ToString());

            dgvHocPhi.DataSource = hocphi;
            txbTongHocPhi.Text = BUS_KeToan.TongHocPhi(hocphi).ToString();

        }

        private void frmKeToan_Load(object sender, EventArgs e)
        {
            dgvHocPhi.Hide();
        }

        private void btnDongHocPhi_Click(object sender, EventArgs e)
        {
            if(BUS_KeToan.DongHocPhi(_id, txbIDHV.Text.ToString()) == 1)
            {
                MessageBox.Show("Đóng " + txbTongHocPhi.Text.ToString() + " cho học viên "
                    + txbIDHV.Text.ToString() + " thành công ");
                txbIDHV.Text = null;
                txbTongHocPhi.Text = null;
                dgvHocPhi.Hide();
            }
            else
            {
                MessageBox.Show("Có lỗi trong quá trình , xin vui lòng thử lại !!!");
            } 
                
            
            

        }
    }
}
