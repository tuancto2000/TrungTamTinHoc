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

namespace UI
{
    public partial class frmGiaoVien : Form
    {
        public string _id { get; set; }
        public frmGiaoVien()
        {
            InitializeComponent();
        }
        void ShowComBoBoxMonHoc()
        {
            try
            {
                cboMonHoc.DataSource = BUS_MonHoc.GetTenLop(_id);
                cboMonHoc.DisplayMember = "Tên môn học";
                cboMonHoc.ValueMember = "id_mh";
                cboMonHoc.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        void ShowComBoBoxLop()
        {
            cboLop.Items.Add("Chứng Chỉ");
            cboLop.Items.Add("Kĩ thuật");
            cboLop.Items.Add("Chuyên đề");
        }
        void ShowTenGiaoVien()
        {
            lblManv.Text = _id;
            lblTenNV.Text = BUS_GiaoVien.GetTenGV(_id);
        }



        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            cboLop.SelectedIndex = -1;


            this.ShowComBoBoxMonHoc();
            this.ShowComBoBoxLop();
            dgvHV.Hide();
            this.ShowTenGiaoVien();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvHV.Show();
            string tenLop = cboLop.SelectedItem.ToString();
            string idMonHoc = cboMonHoc.SelectedValue.ToString();
            dgvHV.DataSource = BUS_GiaoVien.GetHVfromMH(tenLop,idMonHoc);
            if (cboLop.SelectedItem.ToString() == "Chuyên đề") btnUpdate.Enabled = false;
            else btnUpdate.Enabled = true; 
        }



        private void dgvHV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvHV.CurrentRow;
            if (r != null)
            {
                string idMonHoc = cboMonHoc.SelectedValue.ToString();
                string idHocVien = r.Cells["Mã học viên"].Value.ToString();
                double diem = double.Parse(r.Cells["Điểm"].Value.ToString());
                DangKy dk= new DangKy(idMonHoc , idHocVien ,null, diem);
                BUS_MonHoc.UpdateDiemThi(dk);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string tenLop = cboLop.SelectedItem.ToString();
            BUS_MonHoc.SaveChange(tenLop);
        }
    }
}