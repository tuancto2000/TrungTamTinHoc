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
namespace TrungTamTinHoc
{
    public partial class frmTest : Form
    {

        public frmTest()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            
            if (BUS_Test.CheckExist(txtID.Text) == false)
            {
                Test test = new Test(txtID.Text, float.Parse(txtPoint.Text));

                BUS_Test.Insert(test);
            }
            else MessageBox.Show("Test da ton tai");
                
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dtgvTest.DataSource = BUS_Test.Get();
        }
    }
}
