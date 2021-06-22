
namespace WinFormsApp1
{
    partial class frmGiaoVu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPhanCongGiangDay = new System.Windows.Forms.Button();
            this.btn_ToChucThi = new System.Windows.Forms.Button();
            this.btn_XepLoai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPhanCongGiangDay
            // 
            this.btnPhanCongGiangDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPhanCongGiangDay.Location = new System.Drawing.Point(60, 12);
            this.btnPhanCongGiangDay.Name = "btnPhanCongGiangDay";
            this.btnPhanCongGiangDay.Size = new System.Drawing.Size(260, 60);
            this.btnPhanCongGiangDay.TabIndex = 0;
            this.btnPhanCongGiangDay.Text = "Phân công giảng dạy";
            this.btnPhanCongGiangDay.UseVisualStyleBackColor = true;
            this.btnPhanCongGiangDay.Click += new System.EventHandler(this.btnPhanCongGiangDay_Click);
            // 
            // btn_ToChucThi
            // 
            this.btn_ToChucThi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ToChucThi.Location = new System.Drawing.Point(60, 188);
            this.btn_ToChucThi.Name = "btn_ToChucThi";
            this.btn_ToChucThi.Size = new System.Drawing.Size(260, 60);
            this.btn_ToChucThi.TabIndex = 2;
            this.btn_ToChucThi.Text = "Tổ chức thi";
            this.btn_ToChucThi.UseVisualStyleBackColor = true;
            this.btn_ToChucThi.Click += new System.EventHandler(this.btn_ToChucThi_Click);
            // 
            // btn_XepLoai
            // 
            this.btn_XepLoai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_XepLoai.Location = new System.Drawing.Point(60, 101);
            this.btn_XepLoai.Name = "btn_XepLoai";
            this.btn_XepLoai.Size = new System.Drawing.Size(260, 60);
            this.btn_XepLoai.TabIndex = 1;
            this.btn_XepLoai.Text = "Xếp loại, cấp chứng chỉ";
            this.btn_XepLoai.UseVisualStyleBackColor = true;
            this.btn_XepLoai.Click += new System.EventHandler(this.btn_XepLoai_Click);
            // 
            // frmGiaoVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 266);
            this.Controls.Add(this.btn_XepLoai);
            this.Controls.Add(this.btn_ToChucThi);
            this.Controls.Add(this.btnPhanCongGiangDay);
            this.Name = "frmGiaoVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn hình quản lý";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPhanCongGiangDay;
        private System.Windows.Forms.Button btn_ToChucThi;
        private System.Windows.Forms.Button btn_XepLoai;
    }
}

