
namespace CSDL.HeThongGiaoDien
{
    partial class NhanVien
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
            this.cboGioitinhnv = new System.Windows.Forms.ComboBox();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDienthoainv = new System.Windows.Forms.TextBox();
            this.txtDiachinv = new System.Windows.Forms.TextBox();
            this.txtTennv = new System.Windows.Forms.TextBox();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblthongbaonv = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLuuNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.bntXoaNV = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimNV = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // cboGioitinhnv
            // 
            this.cboGioitinhnv.FormattingEnabled = true;
            this.cboGioitinhnv.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioitinhnv.Location = new System.Drawing.Point(103, 88);
            this.cboGioitinhnv.Name = "cboGioitinhnv";
            this.cboGioitinhnv.Size = new System.Drawing.Size(150, 21);
            this.cboGioitinhnv.TabIndex = 19;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaySinh.Location = new System.Drawing.Point(465, 21);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(180, 20);
            this.dtNgaySinh.TabIndex = 18;
            // 
            // txtDienthoainv
            // 
            this.txtDienthoainv.Location = new System.Drawing.Point(465, 54);
            this.txtDienthoainv.Name = "txtDienthoainv";
            this.txtDienthoainv.Size = new System.Drawing.Size(180, 20);
            this.txtDienthoainv.TabIndex = 12;
            // 
            // txtDiachinv
            // 
            this.txtDiachinv.Location = new System.Drawing.Point(465, 85);
            this.txtDiachinv.Multiline = true;
            this.txtDiachinv.Name = "txtDiachinv";
            this.txtDiachinv.Size = new System.Drawing.Size(204, 48);
            this.txtDiachinv.TabIndex = 13;
            // 
            // txtTennv
            // 
            this.txtTennv.Location = new System.Drawing.Point(103, 58);
            this.txtTennv.Name = "txtTennv";
            this.txtTennv.Size = new System.Drawing.Size(145, 20);
            this.txtTennv.TabIndex = 15;
            // 
            // txtManv
            // 
            this.txtManv.Location = new System.Drawing.Point(103, 21);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(122, 20);
            this.txtManv.TabIndex = 16;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(24, 94);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 13);
            this.label21.TabIndex = 4;
            this.label21.Text = "Gioi Tính";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(374, 61);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(80, 13);
            this.label23.TabIndex = 6;
            this.label23.Text = "Điện Thoại  NV";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(374, 21);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(56, 13);
            this.label24.TabIndex = 7;
            this.label24.Text = "Ngày Sinh";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(374, 88);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(62, 13);
            this.label25.TabIndex = 8;
            this.label25.Text = "Địa Chỉ  NV";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Location = new System.Drawing.Point(22, 61);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(44, 13);
            this.label27.TabIndex = 10;
            this.label27.Text = "Tên NV";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Location = new System.Drawing.Point(28, 21);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(40, 13);
            this.label28.TabIndex = 11;
            this.label28.Text = "Mã NV";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblthongbaonv);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.cboGioitinhnv);
            this.groupBox1.Controls.Add(this.txtDiachinv);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.txtManv);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txtDienthoainv);
            this.groupBox1.Controls.Add(this.dtNgaySinh);
            this.groupBox1.Controls.Add(this.txtTennv);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 140);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhân Viên";
            // 
            // lblthongbaonv
            // 
            this.lblthongbaonv.AutoSize = true;
            this.lblthongbaonv.Location = new System.Drawing.Point(249, 24);
            this.lblthongbaonv.Name = "lblthongbaonv";
            this.lblthongbaonv.Size = new System.Drawing.Size(16, 13);
            this.lblthongbaonv.TabIndex = 20;
            this.lblthongbaonv.Text = "...";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLuuNV);
            this.groupBox2.Controls.Add(this.btnSuaNV);
            this.groupBox2.Controls.Add(this.bntXoaNV);
            this.groupBox2.Controls.Add(this.btnThemNV);
            this.groupBox2.Location = new System.Drawing.Point(12, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(706, 68);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnLuuNV
            // 
            this.btnLuuNV.Location = new System.Drawing.Point(242, 19);
            this.btnLuuNV.Name = "btnLuuNV";
            this.btnLuuNV.Size = new System.Drawing.Size(91, 32);
            this.btnLuuNV.TabIndex = 3;
            this.btnLuuNV.Text = "Lưu";
            this.btnLuuNV.UseVisualStyleBackColor = true;
            this.btnLuuNV.Click += new System.EventHandler(this.btnLuuNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Location = new System.Drawing.Point(393, 19);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(91, 32);
            this.btnSuaNV.TabIndex = 2;
            this.btnSuaNV.Text = "Sữa";
            this.btnSuaNV.UseVisualStyleBackColor = true;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // bntXoaNV
            // 
            this.bntXoaNV.Location = new System.Drawing.Point(538, 19);
            this.bntXoaNV.Name = "bntXoaNV";
            this.bntXoaNV.Size = new System.Drawing.Size(91, 32);
            this.bntXoaNV.TabIndex = 1;
            this.bntXoaNV.Text = "Xóa";
            this.bntXoaNV.UseVisualStyleBackColor = true;
            this.bntXoaNV.Click += new System.EventHandler(this.bntXoaNV_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(78, 19);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(91, 32);
            this.btnThemNV.TabIndex = 0;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToOrderColumns = true;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(12, 274);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(705, 212);
            this.dgvNhanVien.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tìm Nhân Viên :";
            // 
            // btnTimNV
            // 
            this.btnTimNV.Location = new System.Drawing.Point(101, 230);
            this.btnTimNV.Name = "btnTimNV";
            this.btnTimNV.Size = new System.Drawing.Size(262, 20);
            this.btnTimNV.TabIndex = 24;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 488);
            this.Controls.Add(this.btnTimNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NhanVien";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboGioitinhnv;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.TextBox txtDienthoainv;
        private System.Windows.Forms.TextBox txtDiachinv;
        private System.Windows.Forms.TextBox txtTennv;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLuuNV;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button bntXoaNV;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox btnTimNV;
        private System.Windows.Forms.Label lblthongbaonv;
    }
}