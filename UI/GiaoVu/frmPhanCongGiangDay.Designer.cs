
namespace WinFormsApp1
{
    partial class frmPhanCongGiangDay
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
            this.lv_lop = new System.Windows.Forms.ListView();
            this.ch_stt = new System.Windows.Forms.ColumnHeader();
            this.ch_mamh = new System.Windows.Forms.ColumnHeader();
            this.ch_tenmh = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_gv = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.ch_magv = new System.Windows.Forms.ColumnHeader();
            this.ch_tengv1 = new System.Windows.Forms.ColumnHeader();
            this.tb_mamh = new System.Windows.Forms.TextBox();
            this.tb_magv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_xacNhan = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_lop
            // 
            this.lv_lop.CheckBoxes = true;
            this.lv_lop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_stt,
            this.ch_mamh,
            this.ch_tenmh});
            this.lv_lop.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lv_lop.FullRowSelect = true;
            this.lv_lop.GridLines = true;
            this.lv_lop.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_lop.HideSelection = false;
            this.lv_lop.Location = new System.Drawing.Point(7, 27);
            this.lv_lop.Margin = new System.Windows.Forms.Padding(4);
            this.lv_lop.Name = "lv_lop";
            this.lv_lop.Size = new System.Drawing.Size(435, 210);
            this.lv_lop.TabIndex = 13;
            this.lv_lop.TabStop = false;
            this.lv_lop.UseCompatibleStateImageBehavior = false;
            this.lv_lop.View = System.Windows.Forms.View.Details;
            this.lv_lop.SelectedIndexChanged += new System.EventHandler(this.lv_lop_SelectedIndexChanged);
            // 
            // ch_stt
            // 
            this.ch_stt.Text = "0";
            this.ch_stt.Width = 0;
            // 
            // ch_mamh
            // 
            this.ch_mamh.Text = "MÃ MÔN HỌC";
            this.ch_mamh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch_mamh.Width = 160;
            // 
            // ch_tenmh
            // 
            this.ch_tenmh.Text = "TÊN MÔN HỌC";
            this.ch_tenmh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch_tenmh.Width = 250;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lv_lop);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(28, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 257);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách lớp";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_gv);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(495, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 257);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách giáo viên";
            // 
            // lv_gv
            // 
            this.lv_gv.CheckBoxes = true;
            this.lv_gv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.ch_magv,
            this.ch_tengv1});
            this.lv_gv.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lv_gv.FullRowSelect = true;
            this.lv_gv.GridLines = true;
            this.lv_gv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_gv.HideSelection = false;
            this.lv_gv.Location = new System.Drawing.Point(7, 27);
            this.lv_gv.Margin = new System.Windows.Forms.Padding(4);
            this.lv_gv.Name = "lv_gv";
            this.lv_gv.Size = new System.Drawing.Size(435, 210);
            this.lv_gv.TabIndex = 13;
            this.lv_gv.TabStop = false;
            this.lv_gv.UseCompatibleStateImageBehavior = false;
            this.lv_gv.View = System.Windows.Forms.View.Details;
            this.lv_gv.SelectedIndexChanged += new System.EventHandler(this.lv_gv_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "0";
            this.columnHeader1.Width = 0;
            // 
            // ch_magv
            // 
            this.ch_magv.Text = "MÃ GIÁO VIÊN";
            this.ch_magv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch_magv.Width = 160;
            // 
            // ch_tengv1
            // 
            this.ch_tengv1.Text = "TÊN GIÁO VIÊN";
            this.ch_tengv1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch_tengv1.Width = 250;
            // 
            // tb_mamh
            // 
            this.tb_mamh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_mamh.Location = new System.Drawing.Point(163, 12);
            this.tb_mamh.Name = "tb_mamh";
            this.tb_mamh.Size = new System.Drawing.Size(150, 34);
            this.tb_mamh.TabIndex = 0;
            // 
            // tb_magv
            // 
            this.tb_magv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_magv.Location = new System.Drawing.Point(626, 12);
            this.tb_magv.Name = "tb_magv";
            this.tb_magv.Size = new System.Drawing.Size(150, 34);
            this.tb_magv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(495, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã giáo viên";
            // 
            // btn_xacNhan
            // 
            this.btn_xacNhan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_xacNhan.Location = new System.Drawing.Point(180, 329);
            this.btn_xacNhan.Name = "btn_xacNhan";
            this.btn_xacNhan.Size = new System.Drawing.Size(162, 40);
            this.btn_xacNhan.TabIndex = 21;
            this.btn_xacNhan.Text = "Xác nhận";
            this.btn_xacNhan.UseVisualStyleBackColor = true;
            this.btn_xacNhan.Click += new System.EventHandler(this.btn_xacNhan_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_huy.Location = new System.Drawing.Point(649, 329);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(162, 40);
            this.btn_huy.TabIndex = 22;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // frmPhanCongGiangDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 380);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_xacNhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_magv);
            this.Controls.Add(this.tb_mamh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPhanCongGiangDay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân công giảng dạy";
            this.Load += new System.EventHandler(this.frmPhanCongGiangDay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_lop;
        private System.Windows.Forms.ColumnHeader ch_stt;
        private System.Windows.Forms.ColumnHeader ch_mamh;
        private System.Windows.Forms.ColumnHeader ch_tenmh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lv_gv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader ch_magv;
        private System.Windows.Forms.ColumnHeader ch_tengv1;
        private System.Windows.Forms.ColumnHeader ch_tengv;
        private System.Windows.Forms.TextBox tb_mamh;
        private System.Windows.Forms.TextBox tb_magv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_xacNhan;
        private System.Windows.Forms.Button btn_huy;
    }
}