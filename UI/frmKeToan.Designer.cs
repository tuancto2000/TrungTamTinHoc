
namespace UI
{
    partial class frmKeToan
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDHV = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bntXemHocPhi = new System.Windows.Forms.Button();
            this.btnDongHocPhi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDongHocPhi);
            this.groupBox1.Controls.Add(this.bntXemHocPhi);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.txtIDHV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 409);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thu học phí";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học viên";
            // 
            // txtIDHV
            // 
            this.txtIDHV.Location = new System.Drawing.Point(172, 38);
            this.txtIDHV.Name = "txtIDHV";
            this.txtIDHV.Size = new System.Drawing.Size(100, 24);
            this.txtIDHV.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(631, 286);
            this.dataGridView1.TabIndex = 2;
            // 
            // bntXemHocPhi
            // 
            this.bntXemHocPhi.Location = new System.Drawing.Point(545, 38);
            this.bntXemHocPhi.Name = "bntXemHocPhi";
            this.bntXemHocPhi.Size = new System.Drawing.Size(118, 37);
            this.bntXemHocPhi.TabIndex = 3;
            this.bntXemHocPhi.Text = "Xem học phí";
            this.bntXemHocPhi.UseVisualStyleBackColor = true;
            this.bntXemHocPhi.Click += new System.EventHandler(this.bntXemHocPhi_Click);
            // 
            // btnDongHocPhi
            // 
            this.btnDongHocPhi.Location = new System.Drawing.Point(545, 373);
            this.btnDongHocPhi.Name = "btnDongHocPhi";
            this.btnDongHocPhi.Size = new System.Drawing.Size(118, 40);
            this.btnDongHocPhi.TabIndex = 3;
            this.btnDongHocPhi.Text = "Đóng học phí";
            this.btnDongHocPhi.UseVisualStyleBackColor = true;
            // 
            // frmKeToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKeToan";
            this.Text = "Kế toán";
            this.Load += new System.EventHandler(this.frmKeToan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDongHocPhi;
        private System.Windows.Forms.Button bntXemHocPhi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtIDHV;
        private System.Windows.Forms.Label label1;
    }
}