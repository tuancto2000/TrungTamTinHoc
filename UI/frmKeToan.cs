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
            BUS_KeToan.XemHocPhi(txtIDHV.Text.ToString());
        }

        private void frmKeToan_Load(object sender, EventArgs e)
        {
            BUS_KeToan.DongHocPhi(_id, txtIDHV.Text.ToString());
        }
    }
}
