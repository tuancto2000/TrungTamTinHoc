
namespace WinFormsApp1
{
    partial class frmToChucThi
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
            this.lv_mh = new System.Windows.Forms.ListView();
            this.ch_stt = new System.Windows.Forms.ColumnHeader();
            this.ch_mamh = new System.Windows.Forms.ColumnHeader();
            this.ch_tenmh = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_mamh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_tenmh = new System.Windows.Forms.TextBox();
            this.btn_xacNhan = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lv_mh);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(19, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 257);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách môn học";
            // 
            // lv_mh
            // 
            this.lv_mh.CheckBoxes = true;
            this.lv_mh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_stt,
            this.ch_mamh,
            this.ch_tenmh});
            this.lv_mh.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lv_mh.FullRowSelect = true;
            this.lv_mh.GridLines = true;
            this.lv_mh.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_mh.HideSelection = false;
            this.lv_mh.Location = new System.Drawing.Point(7, 27);
            this.lv_mh.Margin = new System.Windows.Forms.Padding(4);
            this.lv_mh.Name = "lv_mh";
            this.lv_mh.Size = new System.Drawing.Size(435, 210);
            this.lv_mh.TabIndex = 13;
            this.lv_mh.TabStop = false;
            this.lv_mh.UseCompatibleStateImageBehavior = false;
            this.lv_mh.View = System.Windows.Forms.View.Details;
            this.lv_mh.SelectedIndexChanged += new System.EventHandler(this.lv_mh_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã môn học";
            // 
            // tb_mamh
            // 
            this.tb_mamh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_mamh.Location = new System.Drawing.Point(147, 12);
            this.tb_mamh.Name = "tb_mamh";
            this.tb_mamh.Size = new System.Drawing.Size(194, 34);
            this.tb_mamh.TabIndex = 17;
            this.tb_mamh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên môn học";
            // 
            // tb_tenmh
            // 
            this.tb_tenmh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_tenmh.Location = new System.Drawing.Point(147, 63);
            this.tb_tenmh.Name = "tb_tenmh";
            this.tb_tenmh.Size = new System.Drawing.Size(194, 34);
            this.tb_tenmh.TabIndex = 19;
            // 
            // btn_xacNhan
            // 
            this.btn_xacNhan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_xacNhan.Location = new System.Drawing.Point(72, 389);
            this.btn_xacNhan.Name = "btn_xacNhan";
            this.btn_xacNhan.Size = new System.Drawing.Size(162, 40);
            this.btn_xacNhan.TabIndex = 22;
            this.btn_xacNhan.Text = "Xác nhận";
            this.btn_xacNhan.UseVisualStyleBackColor = true;
            this.btn_xacNhan.Click += new System.EventHandler(this.btn_xacNhan_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_huy.Location = new System.Drawing.Point(268, 389);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(162, 40);
            this.btn_huy.TabIndex = 23;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // frmToChucThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 441);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_xacNhan);
            this.Controls.Add(this.tb_tenmh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_mamh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmToChucThi";
            this.Text = "Tổ chức thi";
            this.Load += new System.EventHandler(this.frmToChucThi_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lv_mh;
        private System.Windows.Forms.ColumnHeader ch_stt;
        private System.Windows.Forms.ColumnHeader ch_mamh;
        private System.Windows.Forms.ColumnHeader ch_tenmh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_mamh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_tenmh;
        private System.Windows.Forms.Button btn_xacNhan;
        private System.Windows.Forms.Button btn_huy;
    }
}