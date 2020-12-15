
namespace CSDL.HeThongGiaoDien
{
    partial class Sach
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDanhMucSach = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGiaBan = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.lblthongbaonv = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.cboMaTheLoai = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtSachTon = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLuuSach = new System.Windows.Forms.Button();
            this.btnSuaSach = new System.Windows.Forms.Button();
            this.bntXoaSach = new System.Windows.Forms.Button();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTimSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.btnTS = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaBan)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::CSDL.Properties.Resources._1;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvDanhMucSach, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
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
            // dgvDanhMucSach
            // 
            this.dgvDanhMucSach.AllowUserToOrderColumns = true;
            this.dgvDanhMucSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMucSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhMucSach.Location = new System.Drawing.Point(3, 273);
            this.dgvDanhMucSach.Name = "dgvDanhMucSach";
            this.dgvDanhMucSach.Size = new System.Drawing.Size(726, 224);
            this.dgvDanhMucSach.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTacGia);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblthongbaonv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNXB);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.cboMaTheLoai);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.txtMaSach);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txtSachTon);
            this.groupBox1.Controls.Add(this.txtTenSach);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 144);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sách";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(464, 99);
            this.txtGiaBan.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtGiaBan.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(157, 20);
            this.txtGiaBan.TabIndex = 60;
            this.txtGiaBan.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(375, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Giá Bán";
            // 
            // lblthongbaonv
            // 
            this.lblthongbaonv.AutoSize = true;
            this.lblthongbaonv.Location = new System.Drawing.Point(100, 121);
            this.lblthongbaonv.Name = "lblthongbaonv";
            this.lblthongbaonv.Size = new System.Drawing.Size(16, 13);
            this.lblthongbaonv.TabIndex = 24;
            this.lblthongbaonv.Text = "...";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(373, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "NXB";
            // 
            // txtNXB
            // 
            this.txtNXB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNXB.Location = new System.Drawing.Point(464, 47);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(122, 20);
            this.txtNXB.TabIndex = 23;
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Location = new System.Drawing.Point(28, 21);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(50, 13);
            this.label28.TabIndex = 11;
            this.label28.Text = "Mã Sách";
            // 
            // cboMaTheLoai
            // 
            this.cboMaTheLoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboMaTheLoai.FormattingEnabled = true;
            this.cboMaTheLoai.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboMaTheLoai.Location = new System.Drawing.Point(103, 53);
            this.cboMaTheLoai.Name = "cboMaTheLoai";
            this.cboMaTheLoai.Size = new System.Drawing.Size(178, 21);
            this.cboMaTheLoai.TabIndex = 19;
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Location = new System.Drawing.Point(22, 91);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(54, 13);
            this.label27.TabIndex = 10;
            this.label27.Text = "Tên Sách";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaSach.Location = new System.Drawing.Point(103, 21);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(178, 20);
            this.txtMaSach.TabIndex = 16;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(24, 59);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 13);
            this.label21.TabIndex = 4;
            this.label21.Text = "Mã Thể Loại";
            // 
            // txtSachTon
            // 
            this.txtSachTon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSachTon.Location = new System.Drawing.Point(464, 73);
            this.txtSachTon.Name = "txtSachTon";
            this.txtSachTon.Size = new System.Drawing.Size(180, 20);
            this.txtSachTon.TabIndex = 12;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenSach.Location = new System.Drawing.Point(103, 88);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(178, 20);
            this.txtTenSach.TabIndex = 15;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(373, 80);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(48, 13);
            this.label23.TabIndex = 6;
            this.label23.Text = "Tồn Kho";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnLuuSach);
            this.groupBox2.Controls.Add(this.btnSuaSach);
            this.groupBox2.Controls.Add(this.bntXoaSach);
            this.groupBox2.Controls.Add(this.btnThemSach);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(726, 54);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnLuuSach
            // 
            this.btnLuuSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuuSach.Location = new System.Drawing.Point(232, 16);
            this.btnLuuSach.Name = "btnLuuSach";
            this.btnLuuSach.Size = new System.Drawing.Size(91, 32);
            this.btnLuuSach.TabIndex = 3;
            this.btnLuuSach.Text = "Lưu Sách Mới";
            this.btnLuuSach.UseVisualStyleBackColor = true;
            this.btnLuuSach.Click += new System.EventHandler(this.btnLuuSach_Click);
            // 
            // btnSuaSach
            // 
            this.btnSuaSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSuaSach.Location = new System.Drawing.Point(391, 16);
            this.btnSuaSach.Name = "btnSuaSach";
            this.btnSuaSach.Size = new System.Drawing.Size(121, 32);
            this.btnSuaSach.TabIndex = 2;
            this.btnSuaSach.Text = "Sửa(Nhập Giá Sách)";
            this.btnSuaSach.UseVisualStyleBackColor = true;
            this.btnSuaSach.Click += new System.EventHandler(this.btnSuaSach_Click);
            // 
            // bntXoaSach
            // 
            this.bntXoaSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bntXoaSach.Location = new System.Drawing.Point(582, 16);
            this.bntXoaSach.Name = "bntXoaSach";
            this.bntXoaSach.Size = new System.Drawing.Size(91, 32);
            this.bntXoaSach.TabIndex = 1;
            this.bntXoaSach.Text = "Xóa sách";
            this.bntXoaSach.UseVisualStyleBackColor = true;
            this.bntXoaSach.Click += new System.EventHandler(this.bntXoaSach_Click);
            // 
            // btnThemSach
            // 
            this.btnThemSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemSach.Location = new System.Drawing.Point(66, 16);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(91, 32);
            this.btnThemSach.TabIndex = 0;
            this.btnThemSach.Text = "Tạo Mã Sách";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnTS);
            this.groupBox3.Controls.Add(this.txtTimSach);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(726, 54);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm sách";
            // 
            // txtTimSach
            // 
            this.txtTimSach.Location = new System.Drawing.Point(103, 19);
            this.txtTimSach.Name = "txtTimSach";
            this.txtTimSach.Size = new System.Drawing.Size(262, 20);
            this.txtTimSach.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(32, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tìm Sách :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(373, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Tác giả";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTacGia.Location = new System.Drawing.Point(464, 14);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(178, 20);
            this.txtTacGia.TabIndex = 62;
            // 
            // btnTS
            // 
            this.btnTS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTS.BackColor = System.Drawing.Color.Teal;
            this.btnTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTS.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTS.ForeColor = System.Drawing.Color.White;
            this.btnTS.Location = new System.Drawing.Point(391, 15);
            this.btnTS.Name = "btnTS";
            this.btnTS.Size = new System.Drawing.Size(75, 26);
            this.btnTS.TabIndex = 33;
            this.btnTS.Text = "Tìm Sách";
            this.btnTS.UseVisualStyleBackColor = false;
            this.btnTS.Click += new System.EventHandler(this.btnTS_Click);
            // 
            // Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSDL.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(732, 488);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Sach";
            this.Text = "Danh Mục Sách";
            this.Load += new System.EventHandler(this.Sach_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaBan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvDanhMucSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblthongbaonv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox cboMaTheLoai;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtSachTon;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLuuSach;
        private System.Windows.Forms.Button btnSuaSach;
        private System.Windows.Forms.Button bntXoaSach;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTimSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtGiaBan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Button btnTS;
    }
}