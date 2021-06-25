
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
            this.btnHuyTab1 = new System.Windows.Forms.Button();
            this.btnXacNhanTab1 = new System.Windows.Forms.Button();
            this.txtMaGiaoVien = new System.Windows.Forms.TextBox();
            this.txtMaMonHoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSGiaoVien = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSLop = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnHuyTab2 = new System.Windows.Forms.Button();
            this.btnXacNhanTab2 = new System.Windows.Forms.Button();
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
            this.tabGiaoVu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGiaoVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLop)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHocVien)).BeginInit();
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
            this.tabGiaoVu.Size = new System.Drawing.Size(1072, 418);
            this.tabGiaoVu.TabIndex = 0;
            this.tabGiaoVu.SelectedIndexChanged += new System.EventHandler(this.tabGiaoVu_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnHuyTab1);
            this.tabPage1.Controls.Add(this.btnXacNhanTab1);
            this.tabPage1.Controls.Add(this.txtMaGiaoVien);
            this.tabPage1.Controls.Add(this.txtMaMonHoc);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1064, 383);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phân công giảng dạy";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnHuyTab1
            // 
            this.btnHuyTab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHuyTab1.Location = new System.Drawing.Point(625, 341);
            this.btnHuyTab1.Name = "btnHuyTab1";
            this.btnHuyTab1.Size = new System.Drawing.Size(122, 35);
            this.btnHuyTab1.TabIndex = 7;
            this.btnHuyTab1.Text = "Hủy";
            this.btnHuyTab1.UseVisualStyleBackColor = true;
            this.btnHuyTab1.Click += new System.EventHandler(this.btnHuyTab1_Click);
            // 
            // btnXacNhanTab1
            // 
            this.btnXacNhanTab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnXacNhanTab1.Location = new System.Drawing.Point(246, 341);
            this.btnXacNhanTab1.Name = "btnXacNhanTab1";
            this.btnXacNhanTab1.Size = new System.Drawing.Size(117, 35);
            this.btnXacNhanTab1.TabIndex = 6;
            this.btnXacNhanTab1.Text = "Xác nhận";
            this.btnXacNhanTab1.UseVisualStyleBackColor = true;
            this.btnXacNhanTab1.Click += new System.EventHandler(this.btnXacNhanTab1_Click);
            // 
            // txtMaGiaoVien
            // 
            this.txtMaGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMaGiaoVien.Location = new System.Drawing.Point(738, 12);
            this.txtMaGiaoVien.Name = "txtMaGiaoVien";
            this.txtMaGiaoVien.Size = new System.Drawing.Size(154, 30);
            this.txtMaGiaoVien.TabIndex = 3;
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMonHoc.Location = new System.Drawing.Point(134, 10);
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.Size = new System.Drawing.Size(154, 30);
            this.txtMaMonHoc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(609, 15);
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
            this.groupBox2.Location = new System.Drawing.Point(608, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 249);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách giáo viên";
            // 
            // dgvDSGiaoVien
            // 
            this.dgvDSGiaoVien.AllowUserToAddRows = false;
            this.dgvDSGiaoVien.AllowUserToDeleteRows = false;
            this.dgvDSGiaoVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSGiaoVien.Location = new System.Drawing.Point(6, 28);
            this.dgvDSGiaoVien.Name = "dgvDSGiaoVien";
            this.dgvDSGiaoVien.ReadOnly = true;
            this.dgvDSGiaoVien.RowHeadersWidth = 51;
            this.dgvDSGiaoVien.RowTemplate.Height = 24;
            this.dgvDSGiaoVien.Size = new System.Drawing.Size(436, 216);
            this.dgvDSGiaoVien.TabIndex = 1;
            this.dgvDSGiaoVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSGiaoVien_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSLop);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 249);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách lớp";
            // 
            // dgvDSLop
            // 
            this.dgvDSLop.AllowUserToAddRows = false;
            this.dgvDSLop.AllowUserToDeleteRows = false;
            this.dgvDSLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSLop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDSLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLop.Location = new System.Drawing.Point(6, 28);
            this.dgvDSLop.Name = "dgvDSLop";
            this.dgvDSLop.ReadOnly = true;
            this.dgvDSLop.RowHeadersWidth = 51;
            this.dgvDSLop.RowTemplate.Height = 24;
            this.dgvDSLop.Size = new System.Drawing.Size(582, 216);
            this.dgvDSLop.TabIndex = 0;
            this.dgvDSLop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSLop_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnHuyTab2);
            this.tabPage2.Controls.Add(this.btnXacNhanTab2);
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
            this.tabPage2.Size = new System.Drawing.Size(1064, 383);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Xếp loại, cấp chứng chỉ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnHuyTab2
            // 
            this.btnHuyTab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHuyTab2.Location = new System.Drawing.Point(625, 340);
            this.btnHuyTab2.Name = "btnHuyTab2";
            this.btnHuyTab2.Size = new System.Drawing.Size(117, 35);
            this.btnHuyTab2.TabIndex = 12;
            this.btnHuyTab2.Text = "Hủy";
            this.btnHuyTab2.UseVisualStyleBackColor = true;
            this.btnHuyTab2.Click += new System.EventHandler(this.btnHuyTab2_Click);
            // 
            // btnXacNhanTab2
            // 
            this.btnXacNhanTab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnXacNhanTab2.Location = new System.Drawing.Point(274, 340);
            this.btnXacNhanTab2.Name = "btnXacNhanTab2";
            this.btnXacNhanTab2.Size = new System.Drawing.Size(117, 35);
            this.btnXacNhanTab2.TabIndex = 11;
            this.btnXacNhanTab2.Text = "Xác nhận";
            this.btnXacNhanTab2.UseVisualStyleBackColor = true;
            this.btnXacNhanTab2.Click += new System.EventHandler(this.btnXacNhanTab2_Click);
            // 
            // txtDiem
            // 
            this.txtDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiem.Location = new System.Drawing.Point(466, 54);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(154, 30);
            this.txtDiem.TabIndex = 10;
            this.txtDiem.TextChanged += new System.EventHandler(this.txtDiem_TextChanged);
            // 
            // txtTenHocVien
            // 
            this.txtTenHocVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHocVien.Location = new System.Drawing.Point(825, 11);
            this.txtTenHocVien.Name = "txtTenHocVien";
            this.txtTenHocVien.Size = new System.Drawing.Size(231, 30);
            this.txtTenHocVien.TabIndex = 9;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Location = new System.Drawing.Point(466, 11);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(154, 30);
            this.txtMaLop.TabIndex = 8;
            // 
            // txtMaHocVien
            // 
            this.txtMaHocVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHocVien.Location = new System.Drawing.Point(132, 11);
            this.txtMaHocVien.Name = "txtMaHocVien";
            this.txtMaHocVien.Size = new System.Drawing.Size(154, 30);
            this.txtMaHocVien.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Điểm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(694, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tên học viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã học viên";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDSHocVien);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(132, 85);
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
            this.dgvDSHocVien.TabIndex = 0;
            this.dgvDSHocVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHocVien_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1064, 383);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Xếp lịch thi";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // frmGiaoVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 418);
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
        private System.Windows.Forms.TextBox txtMaMonHoc;
        private System.Windows.Forms.Button btnXacNhanTab1;
        private System.Windows.Forms.Button btnHuyTab1;
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
        private System.Windows.Forms.Button btnHuyTab2;
        private System.Windows.Forms.Button btnXacNhanTab2;
    }
}