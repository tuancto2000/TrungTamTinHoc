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
        BUS_Test bus_test = new BUS_Test();
        public frmTest()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            

        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (bus_test.CheckExist(txtID.Text) == true)
            {
                Test test = new Test(txtID.Text, float.Parse(txtPoint.Text));

                bus_test.Insert(test);
            }
            else MessageBox.Show("Test da ton tai");
                
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dtgvTest.DataSource = bus_test.Get();
        }
    }
}
