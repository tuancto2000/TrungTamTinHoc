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
            string tenLop = cboLop.SelectedItem.ToString();
            cboMonHoc.DataSource = BUS_GiaoVien.GetTenLop(tenLop,_id);
            
            if (tenLop != "Chuyên đề")
            {
                cboMonHoc.DisplayMember = "Tên môn học";
                cboMonHoc.ValueMember = "id_mh";
                cboMonHoc.SelectedIndex = -1;
            }
            else
            {
                lblMH.Text = "Chuyên đề";
                cboMonHoc.DisplayMember = "Tên chuyên đề";
                cboMonHoc.ValueMember = "id_cd";
                cboMonHoc.SelectedIndex = -1;
            }
        }
        void ShowComBoBoxLop()
        {
            cboLop.Items.Add("Chứng chỉ");
            cboLop.Items.Add("Kỹ thuật");
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
                if (BUS_MonHoc.UpdateDiemThi(dk) == 0)
                {
                    MessageBox.Show("Điểm học sinh phải từ 0 --> 10 ");
                    btnSearch.PerformClick();
                }    
               

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string tenLop = cboLop.SelectedItem.ToString();

            BUS_MonHoc.SaveChange(tenLop);
            btnSearch.PerformClick();
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowComBoBoxMonHoc();
            dgvHV.Hide();
        }

        private void cboMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvHV.Hide();
        }
    }
}