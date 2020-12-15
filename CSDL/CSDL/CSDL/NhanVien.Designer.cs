
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblthongbaonv = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.cboGioitinhnv = new System.Windows.Forms.ComboBox();
            this.txtDiachinv = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtDienthoainv = new System.Windows.Forms.TextBox();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtTennv = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLuuNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.bntXoaNV = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimNV = new System.Windows.Forms.TextBox();
            this.btnTimNhanVien = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::CSDL.Properties.Resources._1;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvNhanVien, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(732, 488);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToOrderColumns = true;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(3, 273);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(726, 212);
            this.dgvNhanVien.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
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
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 144);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhân Viên";
            // 
            // lblthongbaonv
            // 
            this.lblthongbaonv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblthongbaonv.AutoSize = true;
            this.lblthongbaonv.Location = new System.Drawing.Point(249, 24);
            this.lblthongbaonv.Name = "lblthongbaonv";
            this.lblthongbaonv.Size = new System.Drawing.Size(16, 13);
            this.lblthongbaonv.TabIndex = 20;
            this.lblthongbaonv.Text = "...";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Location = new System.Drawing.Point(28, 21);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(40, 13);
            this.label28.TabIndex = 11;
            this.label28.Text = "Mã NV";
            // 
            // cboGioitinhnv
            // 
            this.cboGioitinhnv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboGioitinhnv.FormattingEnabled = true;
            this.cboGioitinhnv.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioitinhnv.Location = new System.Drawing.Point(103, 88);
            this.cboGioitinhnv.Name = "cboGioitinhnv";
            this.cboGioitinhnv.Size = new System.Drawing.Size(150, 21);
            this.cboGioitinhnv.TabIndex = 19;
            // 
            // txtDiachinv
            // 
            this.txtDiachinv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDiachinv.Location = new System.Drawing.Point(465, 85);
            this.txtDiachinv.Multiline = true;
            this.txtDiachinv.Name = "txtDiachinv";
            this.txtDiachinv.Size = new System.Drawing.Size(204, 48);
            this.txtDiachinv.TabIndex = 13;
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Location = new System.Drawing.Point(22, 61);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(44, 13);
            this.label27.TabIndex = 10;
            this.label27.Text = "Tên NV";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(374, 88);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(62, 13);
            this.label25.TabIndex = 8;
            this.label25.Text = "Địa Chỉ  NV";
            // 
            // txtManv
            // 
            this.txtManv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtManv.Location = new System.Drawing.Point(103, 21);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(122, 20);
            this.txtManv.TabIndex = 16;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(24, 94);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 13);
            this.label21.TabIndex = 4;
            this.label21.Text = "Gioi Tính";
            // 
            // txtDienthoainv
            // 
            this.txtDienthoainv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDienthoainv.Location = new System.Drawing.Point(465, 54);
            this.txtDienthoainv.Name = "txtDienthoainv";
            this.txtDienthoainv.Size = new System.Drawing.Size(180, 20);
            this.txtDienthoainv.TabIndex = 12;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaySinh.Location = new System.Drawing.Point(465, 21);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(180, 20);
            this.dtNgaySinh.TabIndex = 18;
            // 
            // txtTennv
            // 
            this.txtTennv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTennv.Location = new System.Drawing.Point(103, 58);
            this.txtTennv.Name = "txtTennv";
            this.txtTennv.Size = new System.Drawing.Size(145, 20);
            this.txtTennv.TabIndex = 15;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(374, 21);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(56, 13);
            this.label24.TabIndex = 7;
            this.label24.Text = "Ngày Sinh";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(374, 61);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(80, 13);
            this.label23.TabIndex = 6;
            this.label23.Text = "Điện Thoại  NV";
            // 
            // groupBox2
            // 
            this.groupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnLuuNV);
            this.groupBox2.Controls.Add(this.btnSuaNV);
            this.groupBox2.Controls.Add(this.bntXoaNV);
            this.groupBox2.Controls.Add(this.btnThemNV);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(726, 54);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnLuuNV
            // 
            this.btnLuuNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuuNV.Location = new System.Drawing.Point(247, 16);
            this.btnLuuNV.Name = "btnLuuNV";
            this.btnLuuNV.Size = new System.Drawing.Size(91, 32);
            this.btnLuuNV.TabIndex = 3;
            this.btnLuuNV.Text = "Lưu NV Mới";
            this.btnLuuNV.UseVisualStyleBackColor = true;
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSuaNV.Location = new System.Drawing.Point(398, 16);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(91, 32);
            this.btnSuaNV.TabIndex = 2;
            this.btnSuaNV.Text = "Sữa";
            this.btnSuaNV.UseVisualStyleBackColor = true;
            // 
            // bntXoaNV
            // 
            this.bntXoaNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bntXoaNV.Location = new System.Drawing.Point(543, 16);
            this.bntXoaNV.Name = "bntXoaNV";
            this.bntXoaNV.Size = new System.Drawing.Size(91, 32);
            this.bntXoaNV.TabIndex = 1;
            this.bntXoaNV.Text = "Xóa";
            this.bntXoaNV.UseVisualStyleBackColor = true;
            // 
            // btnThemNV
            // 
            this.btnThemNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemNV.Location = new System.Drawing.Point(83, 16);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(91, 32);
            this.btnThemNV.TabIndex = 0;
            this.btnThemNV.Text = "Thêm Mã NV";
            this.btnThemNV.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btnLoad);
            this.groupBox4.Controls.Add(this.btnTimNhanVien);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btnTimNV);
            this.groupBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 213);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(726, 54);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm Kiếm Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tìm Nhân Viên Theo Mã :";
            // 
            // btnTimNV
            // 
            this.btnTimNV.Location = new System.Drawing.Point(162, 23);
            this.btnTimNV.Name = "btnTimNV";
            this.btnTimNV.Size = new System.Drawing.Size(216, 20);
            this.btnTimNV.TabIndex = 32;
            // 
            // btnTimNhanVien
            // 
            this.btnTimNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimNhanVien.BackColor = System.Drawing.Color.Teal;
            this.btnTimNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimNhanVien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnTimNhanVien.Location = new System.Drawing.Point(414, 19);
            this.btnTimNhanVien.Name = "btnTimNhanVien";
            this.btnTimNhanVien.Size = new System.Drawing.Size(116, 26);
            this.btnTimNhanVien.TabIndex = 34;
            this.btnTimNhanVien.Text = "Tìm Nhân Viên";
            this.btnTimNhanVien.UseVisualStyleBackColor = false;
            this.btnTimNhanVien.Click += new System.EventHandler(this.btnTimNhanVien_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLoad.BackColor = System.Drawing.Color.Teal;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(568, 19);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(116, 26);
            this.btnLoad.TabIndex = 35;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSDL.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(732, 488);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblthongbaonv;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox cboGioitinhnv;
        private System.Windows.Forms.TextBox txtDiachinv;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtDienthoainv;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.TextBox txtTennv;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLuuNV;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button bntXoaNV;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox btnTimNV;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Button btnTimNhanVien;
        private System.Windows.Forms.Button btnLoad;
    }
}