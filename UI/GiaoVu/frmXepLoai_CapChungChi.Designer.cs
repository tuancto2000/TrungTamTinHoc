
namespace WinFormsApp1
{
    partial class frmXepLoai_CapChungChi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lv_hv = new System.Windows.Forms.ListView();
            this.ch_stt = new System.Windows.Forms.ColumnHeader();
            this.ch_mahv = new System.Windows.Forms.ColumnHeader();
            this.ch_malop1 = new System.Windows.Forms.ColumnHeader();
            this.ch_tenhv1 = new System.Windows.Forms.ColumnHeader();
            this.ch_dtb = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_mahv = new System.Windows.Forms.TextBox();
            this.tb_malop = new System.Windows.Forms.TextBox();
            this.tb_tenhv = new System.Windows.Forms.TextBox();
            this.tb_diem = new System.Windows.Forms.TextBox();
            this.btn_xacNhan = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lv_hv);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 257);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách học viên";
            // 
            // lv_hv
            // 
            this.lv_hv.CheckBoxes = true;
            this.lv_hv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_stt,
            this.ch_mahv,
            this.ch_malop1,
            this.ch_tenhv1,
            this.ch_dtb});
            this.lv_hv.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lv_hv.FullRowSelect = true;
            this.lv_hv.GridLines = true;
            this.lv_hv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_hv.HideSelection = false;
            this.lv_hv.Location = new System.Drawing.Point(7, 27);
            this.lv_hv.Margin = new System.Windows.Forms.Padding(4);
            this.lv_hv.Name = "lv_hv";
            this.lv_hv.Size = new System.Drawing.Size(615, 210);
            this.lv_hv.TabIndex = 13;
            this.lv_hv.TabStop = false;
            this.lv_hv.UseCompatibleStateImageBehavior = false;
            this.lv_hv.View = System.Windows.Forms.View.Details;
            this.lv_hv.SelectedIndexChanged += new System.EventHandler(this.lv_hv_SelectedIndexChanged);
            // 
            // ch_stt
            // 
            this.ch_stt.Text = "0";
            this.ch_stt.Width = 0;
            // 
            // ch_mahv
            // 
            this.ch_mahv.Text = "MÃ HỌC VIÊN";
            this.ch_mahv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch_mahv.Width = 160;
            // 
            // ch_malop1
            // 
            this.ch_malop1.Text = "MÃ LỚP";
            this.ch_malop1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch_malop1.Width = 100;
            // 
            // ch_tenhv1
            // 
            this.ch_tenhv1.Text = "TÊN HỌC VIÊN";
            this.ch_tenhv1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch_tenhv1.Width = 250;
            // 
            // ch_dtb
            // 
            this.ch_dtb.Text = "ĐIỂM TB";
            this.ch_dtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch_dtb.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã học viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(410, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tên học viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(410, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "Điểm";
            // 
            // tb_mahv
            // 
            this.tb_mahv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_mahv.Location = new System.Drawing.Point(136, 9);
            this.tb_mahv.Name = "tb_mahv";
            this.tb_mahv.Size = new System.Drawing.Size(130, 34);
            this.tb_mahv.TabIndex = 20;
            // 
            // tb_malop
            // 
            this.tb_malop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_malop.Location = new System.Drawing.Point(490, 12);
            this.tb_malop.Name = "tb_malop";
            this.tb_malop.Size = new System.Drawing.Size(144, 34);
            this.tb_malop.TabIndex = 21;
            // 
            // tb_tenhv
            // 
            this.tb_tenhv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_tenhv.Location = new System.Drawing.Point(136, 57);
            this.tb_tenhv.Name = "tb_tenhv";
            this.tb_tenhv.Size = new System.Drawing.Size(238, 34);
            this.tb_tenhv.TabIndex = 22;
            // 
            // tb_diem
            // 
            this.tb_diem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_diem.Location = new System.Drawing.Point(490, 57);
            this.tb_diem.Name = "tb_diem";
            this.tb_diem.Size = new System.Drawing.Size(144, 34);
            this.tb_diem.TabIndex = 23;
            this.tb_diem.TextChanged += new System.EventHandler(this.tb_diem_TextChanged);
            // 
            // btn_xacNhan
            // 
            this.btn_xacNhan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_xacNhan.Location = new System.Drawing.Point(104, 384);
            this.btn_xacNhan.Name = "btn_xacNhan";
            this.btn_xacNhan.Size = new System.Drawing.Size(162, 40);
            this.btn_xacNhan.TabIndex = 24;
            this.btn_xacNhan.Text = "Xác nhận";
            this.btn_xacNhan.UseVisualStyleBackColor = true;
            this.btn_xacNhan.Click += new System.EventHandler(this.btn_xacNhan_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_huy.Location = new System.Drawing.Point(380, 384);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(162, 40);
            this.btn_huy.TabIndex = 25;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // frmXepLoai_CapChungChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 438);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_xacNhan);
            this.Controls.Add(this.tb_diem);
            this.Controls.Add(this.tb_tenhv);
            this.Controls.Add(this.tb_malop);
            this.Controls.Add(this.tb_mahv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmXepLoai_CapChungChi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xếp loại - Cấp chứng chỉ";
            this.Load += new System.EventHandler(this.frmXepLoai_CapChungChi_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lv_hv;
        private System.Windows.Forms.ColumnHeader ch_stt;
        private System.Windows.Forms.ColumnHeader ch_mahv;
        private System.Windows.Forms.ColumnHeader ch_tenhv1;
        private System.Windows.Forms.ColumnHeader ch_malop;
        private System.Windows.Forms.ColumnHeader ch_tenhv;
        private System.Windows.Forms.ColumnHeader ch_malop1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_mahv;
        private System.Windows.Forms.TextBox tb_malop;
        private System.Windows.Forms.TextBox tb_tenhv;
        private System.Windows.Forms.TextBox tb_diem;
        private System.Windows.Forms.Button btn_xacNhan;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.ColumnHeader ch_dtb;
    }
}