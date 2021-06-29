
namespace UI
{
    partial class frmGiaoVu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabGiaoVu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnHuy1 = new System.Windows.Forms.Button();
            this.btnXacNhan1 = new System.Windows.Forms.Button();
            this.txtMaGiaoVien = new System.Windows.Forms.TextBox();
            this.txtMaMonHoc1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSGiaoVien = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSLop = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnHuy2 = new System.Windows.Forms.Button();
            this.btnXacNhan2 = new System.Windows.Forms.Button();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtTenHocVien = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtMaHocVien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDSHocVien = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnHuy3 = new System.Windows.Forms.Button();
            this.btnXepLichThi = new System.Windows.Forms.Button();
            this.txtTenMonHoc = new System.Windows.Forms.TextBox();
            this.txtMaHocPhan = new System.Windows.Forms.TextBox();
            this.txtMaMonHoc3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvMonHoc = new System.Windows.Forms.GroupBox();
            this.dgvDSMonHoc = new System.Windows.Forms.DataGridView();
            this.tabGiaoVu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGiaoVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLop)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHocVien)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.dgvMonHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // tabGiaoVu
            // 
            this.tabGiaoVu.Controls.Add(this.tabPage1);
            this.tabGiaoVu.Controls.Add(this.tabPage2);
            this.tabGiaoVu.Controls.Add(this.tabPage3);
            this.tabGiaoVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabGiaoVu.Location = new System.Drawing.Point(0, 0);
            this.tabGiaoVu.Margin = new System.Windows.Forms.Padding(4);
            this.tabGiaoVu.Name = "tabGiaoVu";
            this.tabGiaoVu.SelectedIndex = 0;
            this.tabGiaoVu.Size = new System.Drawing.Size(967, 418);
            this.tabGiaoVu.TabIndex = 0;
            this.tabGiaoVu.SelectedIndexChanged += new System.EventHandler(this.tabGiaoVu_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnHuy1);
            this.tabPage1.Controls.Add(this.btnXacNhan1);
            this.tabPage1.Controls.Add(this.txtMaGiaoVien);
            this.tabPage1.Controls.Add(this.txtMaMonHoc1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(959, 383);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phân công giảng dạy";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnHuy1
            // 
            this.btnHuy1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHuy1.Location = new System.Drawing.Point(646, 341);
            this.btnHuy1.Name = "btnHuy1";
            this.btnHuy1.Size = new System.Drawing.Size(122, 35);
            this.btnHuy1.TabIndex = 7;
            this.btnHuy1.Text = "Hủy";
            this.btnHuy1.UseVisualStyleBackColor = true;
            this.btnHuy1.Click += new System.EventHandler(this.btnHuyTab1_Click);
            // 
            // btnXacNhan1
            // 
            this.btnXacNhan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnXacNhan1.Location = new System.Drawing.Point(246, 341);
            this.btnXacNhan1.Name = "btnXacNhan1";
            this.btnXacNhan1.Size = new System.Drawing.Size(117, 35);
            this.btnXacNhan1.TabIndex = 6;
            this.btnXacNhan1.Text = "Xác nhận";
            this.btnXacNhan1.UseVisualStyleBackColor = true;
            this.btnXacNhan1.Click += new System.EventHandler(this.btnXacNhanTab1_Click);
            // 
            // txtMaGiaoVien
            // 
            this.txtMaGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMaGiaoVien.Location = new System.Drawing.Point(646, 12);
            this.txtMaGiaoVien.Name = "txtMaGiaoVien";
            this.txtMaGiaoVien.Size = new System.Drawing.Size(154, 30);
            this.txtMaGiaoVien.TabIndex = 3;
            // 
            // txtMaMonHoc1
            // 
            this.txtMaMonHoc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMonHoc1.Location = new System.Drawing.Point(134, 10);
            this.txtMaMonHoc1.Name = "txtMaMonHoc1";
            this.txtMaMonHoc1.Size = new System.Drawing.Size(154, 30);
            this.txtMaMonHoc1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(517, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã giáo viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn học";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSGiaoVien);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(516, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 249);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách giáo viên";
            // 
            // dgvDSGiaoVien
            // 
            this.dgvDSGiaoVien.AllowUserToAddRows = false;
            this.dgvDSGiaoVien.AllowUserToDeleteRows = false;
            this.dgvDSGiaoVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDSGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSGiaoVien.Location = new System.Drawing.Point(6, 28);
            this.dgvDSGiaoVien.Name = "dgvDSGiaoVien";
            this.dgvDSGiaoVien.ReadOnly = true;
            this.dgvDSGiaoVien.RowHeadersWidth = 51;
            this.dgvDSGiaoVien.RowTemplate.Height = 24;
            this.dgvDSGiaoVien.Size = new System.Drawing.Size(409, 216);
            this.dgvDSGiaoVien.TabIndex = 1;
            this.dgvDSGiaoVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSGiaoVien_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSLop);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 249);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách lớp";
            // 
            // dgvDSLop
            // 
            this.dgvDSLop.AllowUserToAddRows = false;
            this.dgvDSLop.AllowUserToDeleteRows = false;
            this.dgvDSLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDSLop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDSLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLop.Location = new System.Drawing.Point(6, 28);
            this.dgvDSLop.Name = "dgvDSLop";
            this.dgvDSLop.ReadOnly = true;
            this.dgvDSLop.RowHeadersWidth = 51;
            this.dgvDSLop.RowTemplate.Height = 24;
            this.dgvDSLop.Size = new System.Drawing.Size(487, 216);
            this.dgvDSLop.TabIndex = 0;
            this.dgvDSLop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSLop_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnHuy2);
            this.tabPage2.Controls.Add(this.btnXacNhan2);
            this.tabPage2.Controls.Add(this.txtDiem);
            this.tabPage2.Controls.Add(this.txtTenHocVien);
            this.tabPage2.Controls.Add(this.txtMaLop);
            this.tabPage2.Controls.Add(this.txtMaHocVien);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(959, 383);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Xếp loại, cấp chứng chỉ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnHuy2
            // 
            this.btnHuy2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHuy2.Location = new System.Drawing.Point(625, 340);
            this.btnHuy2.Name = "btnHuy2";
            this.btnHuy2.Size = new System.Drawing.Size(117, 35);
            this.btnHuy2.TabIndex = 10;
            this.btnHuy2.Text = "Hủy";
            this.btnHuy2.UseVisualStyleBackColor = true;
            this.btnHuy2.Click += new System.EventHandler(this.btnHuyTab2_Click);
            // 
            // btnXacNhan2
            // 
            this.btnXacNhan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnXacNhan2.Location = new System.Drawing.Point(274, 340);
            this.btnXacNhan2.Name = "btnXacNhan2";
            this.btnXacNhan2.Size = new System.Drawing.Size(117, 35);
            this.btnXacNhan2.TabIndex = 9;
            this.btnXacNhan2.Text = "Xác nhận";
            this.btnXacNhan2.UseVisualStyleBackColor = true;
            this.btnXacNhan2.Click += new System.EventHandler(this.btnXacNhanTab2_Click);
            // 
            // txtDiem
            // 
            this.txtDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiem.Location = new System.Drawing.Point(397, 54);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(154, 30);
            this.txtDiem.TabIndex = 7;
            this.txtDiem.TextChanged += new System.EventHandler(this.txtDiem_TextChanged);
            // 
            // txtTenHocVien
            // 
            this.txtTenHocVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHocVien.Location = new System.Drawing.Point(720, 11);
            this.txtTenHocVien.Name = "txtTenHocVien";
            this.txtTenHocVien.Size = new System.Drawing.Size(231, 30);
            this.txtTenHocVien.TabIndex = 5;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Location = new System.Drawing.Point(397, 11);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(154, 30);
            this.txtMaLop.TabIndex = 3;
            // 
            // txtMaHocVien
            // 
            this.txtMaHocVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHocVien.Location = new System.Drawing.Point(132, 9);
            this.txtMaHocVien.Name = "txtMaHocVien";
            this.txtMaHocVien.Size = new System.Drawing.Size(154, 30);
            this.txtMaHocVien.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(320, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Điểm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(589, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên học viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã học viên";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDSHocVien);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(105, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(787, 249);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách học viên";
            // 
            // dgvDSHocVien
            // 
            this.dgvDSHocVien.AllowUserToAddRows = false;
            this.dgvDSHocVien.AllowUserToDeleteRows = false;
            this.dgvDSHocVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSHocVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDSHocVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHocVien.Location = new System.Drawing.Point(6, 28);
            this.dgvDSHocVien.Name = "dgvDSHocVien";
            this.dgvDSHocVien.ReadOnly = true;
            this.dgvDSHocVien.RowHeadersWidth = 51;
            this.dgvDSHocVien.RowTemplate.Height = 24;
            this.dgvDSHocVien.Size = new System.Drawing.Size(775, 216);
            this.dgvDSHocVien.TabIndex = 8;
            this.dgvDSHocVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHocVien_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnHuy3);
            this.tabPage3.Controls.Add(this.btnXepLichThi);
            this.tabPage3.Controls.Add(this.txtTenMonHoc);
            this.tabPage3.Controls.Add(this.txtMaHocPhan);
            this.tabPage3.Controls.Add(this.txtMaMonHoc3);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.dgvMonHoc);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(959, 383);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tổ chức thi";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnHuy3
            // 
            this.btnHuy3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHuy3.Location = new System.Drawing.Point(597, 331);
            this.btnHuy3.Name = "btnHuy3";
            this.btnHuy3.Size = new System.Drawing.Size(117, 35);
            this.btnHuy3.TabIndex = 8;
            this.btnHuy3.Text = "Hủy";
            this.btnHuy3.UseVisualStyleBackColor = true;
            this.btnHuy3.Click += new System.EventHandler(this.btnHuy3_Click);
            // 
            // btnXepLichThi
            // 
            this.btnXepLichThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnXepLichThi.Location = new System.Drawing.Point(287, 331);
            this.btnXepLichThi.Name = "btnXepLichThi";
            this.btnXepLichThi.Size = new System.Drawing.Size(134, 35);
            this.btnXepLichThi.TabIndex = 7;
            this.btnXepLichThi.Text = "Xếp lịch thi";
            this.btnXepLichThi.UseVisualStyleBackColor = true;
            this.btnXepLichThi.Click += new System.EventHandler(this.btnXepLichThi_Click);
            // 
            // txtTenMonHoc
            // 
            this.txtTenMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMonHoc.Location = new System.Drawing.Point(720, 8);
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.Size = new System.Drawing.Size(231, 30);
            this.txtTenMonHoc.TabIndex = 5;
            // 
            // txtMaHocPhan
            // 
            this.txtMaHocPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHocPhan.Location = new System.Drawing.Point(427, 10);
            this.txtMaHocPhan.Name = "txtMaHocPhan";
            this.txtMaHocPhan.Size = new System.Drawing.Size(154, 30);
            this.txtMaHocPhan.TabIndex = 3;
            // 
            // txtMaMonHoc3
            // 
            this.txtMaMonHoc3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMonHoc3.Location = new System.Drawing.Point(134, 10);
            this.txtMaMonHoc3.Name = "txtMaMonHoc3";
            this.txtMaMonHoc3.Size = new System.Drawing.Size(154, 30);
            this.txtMaMonHoc3.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(587, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tên môn học";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(295, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Mã học phần";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã môn học";
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.Controls.Add(this.dgvDSMonHoc);
            this.dgvMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMonHoc.Location = new System.Drawing.Point(111, 76);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.Size = new System.Drawing.Size(787, 249);
            this.dgvMonHoc.TabIndex = 3;
            this.dgvMonHoc.TabStop = false;
            this.dgvMonHoc.Text = "Danh sách môn học";
            // 
            // dgvDSMonHoc
            // 
            this.dgvDSMonHoc.AllowUserToAddRows = false;
            this.dgvDSMonHoc.AllowUserToDeleteRows = false;
            this.dgvDSMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSMonHoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDSMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMonHoc.Location = new System.Drawing.Point(6, 28);
            this.dgvDSMonHoc.Name = "dgvDSMonHoc";
            this.dgvDSMonHoc.ReadOnly = true;
            this.dgvDSMonHoc.RowHeadersWidth = 51;
            this.dgvDSMonHoc.RowTemplate.Height = 24;
            this.dgvDSMonHoc.Size = new System.Drawing.Size(775, 216);
            this.dgvDSMonHoc.TabIndex = 6;
            this.dgvDSMonHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSMonHoc_CellContentClick);
            // 
            // frmGiaoVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 418);
            this.Controls.Add(this.tabGiaoVu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGiaoVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giáo Vụ";
            this.Load += new System.EventHandler(this.frmGiaoVu_Load);
            this.tabGiaoVu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGiaoVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLop)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHocVien)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.dgvMonHoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGiaoVu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaGiaoVien;
        private System.Windows.Forms.TextBox txtMaMonHoc1;
        private System.Windows.Forms.Button btnXacNhan1;
        private System.Windows.Forms.Button btnHuy1;
        private System.Windows.Forms.DataGridView dgvDSGiaoVien;
        private System.Windows.Forms.DataGridView dgvDSLop;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDSHocVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaHocVien;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtTenHocVien;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Button btnHuy2;
        private System.Windows.Forms.Button btnXacNhan2;
        private System.Windows.Forms.GroupBox dgvMonHoc;
        private System.Windows.Forms.DataGridView dgvDSMonHoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenMonHoc;
        private System.Windows.Forms.TextBox txtMaHocPhan;
        private System.Windows.Forms.TextBox txtMaMonHoc3;
        private System.Windows.Forms.Button btnXepLichThi;
        private System.Windows.Forms.Button btnHuy3;
    }
}