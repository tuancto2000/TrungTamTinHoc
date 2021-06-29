
namespace UI
{
    partial class Sinh_Vien
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.maMHCC_txtBox = new System.Windows.Forms.TextBox();
            this.dkLopCC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hienLopCC = new System.Windows.Forms.Button();
            this.lopCC_dtgv = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.hienLopKT = new System.Windows.Forms.Button();
            this.maMHKT_txtBox = new System.Windows.Forms.TextBox();
            this.dkLopKT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lopKT_dtgv = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.hienLopKTDaDK = new System.Windows.Forms.Button();
            this.hienLopCCDaDK = new System.Windows.Forms.Button();
            this.monHoc_dtgv = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dkTotNghiep = new System.Windows.Forms.Button();
            this.dkChungChiB = new System.Windows.Forms.Button();
            this.dkChungChiA = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lopCC_dtgv)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lopKT_dtgv)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monHoc_dtgv)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.maMHCC_txtBox);
            this.tabPage1.Controls.Add(this.dkLopCC);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.hienLopCC);
            this.tabPage1.Controls.Add(this.lopCC_dtgv);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 405);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Đăng ký lớp chứng chỉ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // maMHCC_txtBox
            // 
            this.maMHCC_txtBox.Location = new System.Drawing.Point(451, 305);
            this.maMHCC_txtBox.Name = "maMHCC_txtBox";
            this.maMHCC_txtBox.Size = new System.Drawing.Size(119, 22);
            this.maMHCC_txtBox.TabIndex = 4;
            // 
            // dkLopCC
            // 
            this.dkLopCC.Location = new System.Drawing.Point(474, 333);
            this.dkLopCC.Name = "dkLopCC";
            this.dkLopCC.Size = new System.Drawing.Size(96, 33);
            this.dkLopCC.TabIndex = 3;
            this.dkLopCC.Text = "Đăng ký";
            this.dkLopCC.UseVisualStyleBackColor = true;
            this.dkLopCC.Click += new System.EventHandler(this.dkLopCC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã môn học:";
            // 
            // hienLopCC
            // 
            this.hienLopCC.Location = new System.Drawing.Point(626, 305);
            this.hienLopCC.Name = "hienLopCC";
            this.hienLopCC.Size = new System.Drawing.Size(154, 49);
            this.hienLopCC.TabIndex = 1;
            this.hienLopCC.Text = "Hiện danh sách lớp";
            this.hienLopCC.UseVisualStyleBackColor = true;
            this.hienLopCC.Click += new System.EventHandler(this.hienLopCC_Click);
            // 
            // lopCC_dtgv
            // 
            this.lopCC_dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lopCC_dtgv.Location = new System.Drawing.Point(6, 6);
            this.lopCC_dtgv.Name = "lopCC_dtgv";
            this.lopCC_dtgv.RowHeadersWidth = 51;
            this.lopCC_dtgv.RowTemplate.Height = 24;
            this.lopCC_dtgv.Size = new System.Drawing.Size(774, 293);
            this.lopCC_dtgv.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.hienLopKT);
            this.tabPage2.Controls.Add(this.maMHKT_txtBox);
            this.tabPage2.Controls.Add(this.dkLopKT);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.lopKT_dtgv);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 405);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Đăng ký lớp kĩ thuật";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // hienLopKT
            // 
            this.hienLopKT.Location = new System.Drawing.Point(626, 305);
            this.hienLopKT.Name = "hienLopKT";
            this.hienLopKT.Size = new System.Drawing.Size(154, 49);
            this.hienLopKT.TabIndex = 8;
            this.hienLopKT.Text = "Hiện danh sách lớp";
            this.hienLopKT.UseVisualStyleBackColor = true;
            this.hienLopKT.Click += new System.EventHandler(this.hienLopKT_Click);
            // 
            // maMHKT_txtBox
            // 
            this.maMHKT_txtBox.Location = new System.Drawing.Point(449, 305);
            this.maMHKT_txtBox.Name = "maMHKT_txtBox";
            this.maMHKT_txtBox.Size = new System.Drawing.Size(119, 22);
            this.maMHKT_txtBox.TabIndex = 7;
            // 
            // dkLopKT
            // 
            this.dkLopKT.Location = new System.Drawing.Point(472, 333);
            this.dkLopKT.Name = "dkLopKT";
            this.dkLopKT.Size = new System.Drawing.Size(96, 33);
            this.dkLopKT.TabIndex = 6;
            this.dkLopKT.Text = "Đăng ký";
            this.dkLopKT.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã môn học:";
            // 
            // lopKT_dtgv
            // 
            this.lopKT_dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lopKT_dtgv.Location = new System.Drawing.Point(6, 6);
            this.lopKT_dtgv.Name = "lopKT_dtgv";
            this.lopKT_dtgv.RowHeadersWidth = 51;
            this.lopKT_dtgv.RowTemplate.Height = 24;
            this.lopKT_dtgv.Size = new System.Drawing.Size(774, 293);
            this.lopKT_dtgv.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.hienLopKTDaDK);
            this.tabPage3.Controls.Add(this.hienLopCCDaDK);
            this.tabPage3.Controls.Add(this.monHoc_dtgv);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(786, 405);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Xem môn học đã đăng ký";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // hienLopKTDaDK
            // 
            this.hienLopKTDaDK.Location = new System.Drawing.Point(625, 302);
            this.hienLopKTDaDK.Name = "hienLopKTDaDK";
            this.hienLopKTDaDK.Size = new System.Drawing.Size(154, 49);
            this.hienLopKTDaDK.TabIndex = 3;
            this.hienLopKTDaDK.Text = "Hiện danh sách lớp KT";
            this.hienLopKTDaDK.UseVisualStyleBackColor = true;
            this.hienLopKTDaDK.Click += new System.EventHandler(this.hienLopKTDaDK_Click);
            // 
            // hienLopCCDaDK
            // 
            this.hienLopCCDaDK.Location = new System.Drawing.Point(465, 302);
            this.hienLopCCDaDK.Name = "hienLopCCDaDK";
            this.hienLopCCDaDK.Size = new System.Drawing.Size(154, 49);
            this.hienLopCCDaDK.TabIndex = 2;
            this.hienLopCCDaDK.Text = "Hiện danh sách lớp CC";
            this.hienLopCCDaDK.UseVisualStyleBackColor = true;
            this.hienLopCCDaDK.Click += new System.EventHandler(this.hienLopCCDaDK_Click);
            // 
            // monHoc_dtgv
            // 
            this.monHoc_dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monHoc_dtgv.Location = new System.Drawing.Point(5, 3);
            this.monHoc_dtgv.Name = "monHoc_dtgv";
            this.monHoc_dtgv.RowHeadersWidth = 51;
            this.monHoc_dtgv.RowTemplate.Height = 24;
            this.monHoc_dtgv.Size = new System.Drawing.Size(774, 293);
            this.monHoc_dtgv.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 434);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dkTotNghiep);
            this.tabPage4.Controls.Add(this.dkChungChiB);
            this.tabPage4.Controls.Add(this.dkChungChiA);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(786, 405);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Đăng ký CC và tốt nghiệp";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dkTotNghiep
            // 
            this.dkTotNghiep.Location = new System.Drawing.Point(263, 152);
            this.dkTotNghiep.Name = "dkTotNghiep";
            this.dkTotNghiep.Size = new System.Drawing.Size(138, 49);
            this.dkTotNghiep.TabIndex = 4;
            this.dkTotNghiep.Text = "Đăng ký thi tốt nghiệp";
            this.dkTotNghiep.UseVisualStyleBackColor = true;
            this.dkTotNghiep.Click += new System.EventHandler(this.dkTotNghiep_Click);
            // 
            // dkChungChiB
            // 
            this.dkChungChiB.Location = new System.Drawing.Point(425, 86);
            this.dkChungChiB.Name = "dkChungChiB";
            this.dkChungChiB.Size = new System.Drawing.Size(126, 32);
            this.dkChungChiB.TabIndex = 3;
            this.dkChungChiB.Text = "Chứng chỉ B";
            this.dkChungChiB.UseVisualStyleBackColor = true;
            this.dkChungChiB.Click += new System.EventHandler(this.dkChungChiB_Click);
            // 
            // dkChungChiA
            // 
            this.dkChungChiA.Location = new System.Drawing.Point(263, 86);
            this.dkChungChiA.Name = "dkChungChiA";
            this.dkChungChiA.Size = new System.Drawing.Size(126, 32);
            this.dkChungChiA.TabIndex = 2;
            this.dkChungChiA.Text = "Chứng chỉ A";
            this.dkChungChiA.UseVisualStyleBackColor = true;
            this.dkChungChiA.Click += new System.EventHandler(this.dkChungChiA_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Đăng ký tốt nghiệp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đăng ký chứng chỉ:";
            // 
            // Sinh_Vien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Sinh_Vien";
            this.Text = "Sinh_Vien";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lopCC_dtgv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lopKT_dtgv)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monHoc_dtgv)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox maMHCC_txtBox;
        private System.Windows.Forms.Button dkLopCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hienLopCC;
        private System.Windows.Forms.DataGridView lopCC_dtgv;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button hienLopKT;
        private System.Windows.Forms.TextBox maMHKT_txtBox;
        private System.Windows.Forms.Button dkLopKT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView lopKT_dtgv;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button dkTotNghiep;
        private System.Windows.Forms.Button dkChungChiB;
        private System.Windows.Forms.Button dkChungChiA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button hienLopKTDaDK;
        private System.Windows.Forms.Button hienLopCCDaDK;
        private System.Windows.Forms.DataGridView monHoc_dtgv;
    }
}