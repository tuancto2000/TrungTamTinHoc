
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
            this.btnDongHocPhi = new System.Windows.Forms.Button();
            this.bntXemHocPhi = new System.Windows.Forms.Button();
            this.dgvHocPhi = new System.Windows.Forms.DataGridView();
            this.txbIDHV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTongHocPhi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocPhi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbTongHocPhi);
            this.groupBox1.Controls.Add(this.btnDongHocPhi);
            this.groupBox1.Controls.Add(this.bntXemHocPhi);
            this.groupBox1.Controls.Add(this.dgvHocPhi);
            this.groupBox1.Controls.Add(this.txbIDHV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 409);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thu học phí";
            // 
            // btnDongHocPhi
            // 
            this.btnDongHocPhi.Location = new System.Drawing.Point(545, 373);
            this.btnDongHocPhi.Name = "btnDongHocPhi";
            this.btnDongHocPhi.Size = new System.Drawing.Size(118, 40);
            this.btnDongHocPhi.TabIndex = 3;
            this.btnDongHocPhi.Text = "Đóng học phí";
            this.btnDongHocPhi.UseVisualStyleBackColor = true;
            this.btnDongHocPhi.Click += new System.EventHandler(this.btnDongHocPhi_Click);
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
            // dgvHocPhi
            // 
            this.dgvHocPhi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocPhi.Location = new System.Drawing.Point(32, 81);
            this.dgvHocPhi.Name = "dgvHocPhi";
            this.dgvHocPhi.RowHeadersWidth = 51;
            this.dgvHocPhi.RowTemplate.Height = 24;
            this.dgvHocPhi.Size = new System.Drawing.Size(631, 286);
            this.dgvHocPhi.TabIndex = 2;
            // 
            // txbIDHV
            // 
            this.txbIDHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDHV.Location = new System.Drawing.Point(172, 38);
            this.txbIDHV.Name = "txbIDHV";
            this.txbIDHV.Size = new System.Drawing.Size(119, 28);
            this.txbIDHV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng tiền";
            // 
            // txbTongHocPhi
            // 
            this.txbTongHocPhi.Location = new System.Drawing.Point(351, 381);
            this.txbTongHocPhi.Name = "txbTongHocPhi";
            this.txbTongHocPhi.Size = new System.Drawing.Size(100, 24);
            this.txbTongHocPhi.TabIndex = 4;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocPhi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDongHocPhi;
        private System.Windows.Forms.Button bntXemHocPhi;
        private System.Windows.Forms.DataGridView dgvHocPhi;
        private System.Windows.Forms.TextBox txbIDHV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTongHocPhi;
        private System.Windows.Forms.Label label2;
    }
}