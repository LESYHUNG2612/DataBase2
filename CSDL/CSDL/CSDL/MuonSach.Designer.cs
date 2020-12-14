
namespace CSDL
{
    partial class MuonSach
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
            this.NmUDGiaThue = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.NmUDTienCoc = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMaPM = new System.Windows.Forms.TextBox();
            this.dptNgayTra = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtMaĐG = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvTheLoaiSach = new System.Windows.Forms.DataGridView();
            this.txtTimTLSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMaTLDuocChon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDanhMucSach = new System.Windows.Forms.DataGridView();
            this.txtTimDanhMucSach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnMuonSach = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmUDGiaThue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmUDTienCoc)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoaiSach)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.NmUDGiaThue);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.NmUDTienCoc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtMaPM);
            this.groupBox1.Controls.Add(this.dptNgayTra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpNgayMuon);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.txtMaĐG);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Mượn";
            // 
            // NmUDGiaThue
            // 
            this.NmUDGiaThue.Hexadecimal = true;
            this.NmUDGiaThue.Location = new System.Drawing.Point(105, 212);
            this.NmUDGiaThue.Name = "NmUDGiaThue";
            this.NmUDGiaThue.Size = new System.Drawing.Size(157, 20);
            this.NmUDGiaThue.TabIndex = 41;
            this.NmUDGiaThue.ThousandsSeparator = true;
            this.NmUDGiaThue.Visible = false;
            this.NmUDGiaThue.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(16, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Giá Thuê";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // NmUDTienCoc
            // 
            this.NmUDTienCoc.Location = new System.Drawing.Point(105, 180);
            this.NmUDTienCoc.Name = "NmUDTienCoc";
            this.NmUDTienCoc.Size = new System.Drawing.Size(157, 20);
            this.NmUDTienCoc.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(16, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Cọc Tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(16, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Mã PM";
            // 
            // TxtMaPM
            // 
            this.TxtMaPM.Location = new System.Drawing.Point(105, 122);
            this.TxtMaPM.Name = "TxtMaPM";
            this.TxtMaPM.Size = new System.Drawing.Size(157, 20);
            this.TxtMaPM.TabIndex = 37;
            // 
            // dptNgayTra
            // 
            this.dptNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dptNgayTra.Location = new System.Drawing.Point(105, 90);
            this.dptNgayTra.Name = "dptNgayTra";
            this.dptNgayTra.Size = new System.Drawing.Size(157, 20);
            this.dptNgayTra.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(16, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Ngày Trả";
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMuon.Location = new System.Drawing.Point(105, 57);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(139, 20);
            this.dtpNgayMuon.TabIndex = 33;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(16, 58);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(62, 13);
            this.label24.TabIndex = 32;
            this.label24.Text = "Ngày Mượn";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Location = new System.Drawing.Point(16, 25);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(41, 13);
            this.label28.TabIndex = 30;
            this.label28.Text = "Mã ĐG";
            // 
            // txtMaĐG
            // 
            this.txtMaĐG.Location = new System.Drawing.Point(105, 22);
            this.txtMaĐG.Name = "txtMaĐG";
            this.txtMaĐG.Size = new System.Drawing.Size(122, 20);
            this.txtMaĐG.TabIndex = 31;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSach);
            this.groupBox2.Location = new System.Drawing.Point(462, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 239);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sách Được Chọn";
            // 
            // dgvSach
            // 
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(7, 20);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.Size = new System.Drawing.Size(456, 213);
            this.dgvSach.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvTheLoaiSach);
            this.groupBox3.Controls.Add(this.txtTimTLSach);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 303);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thể Loại Sách";
            // 
            // dgvTheLoaiSach
            // 
            this.dgvTheLoaiSach.AllowUserToOrderColumns = true;
            this.dgvTheLoaiSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheLoaiSach.Location = new System.Drawing.Point(9, 45);
            this.dgvTheLoaiSach.Name = "dgvTheLoaiSach";
            this.dgvTheLoaiSach.Size = new System.Drawing.Size(314, 252);
            this.dgvTheLoaiSach.TabIndex = 30;
            // 
            // txtTimTLSach
            // 
            this.txtTimTLSach.Location = new System.Drawing.Point(80, 19);
            this.txtTimTLSach.Name = "txtTimTLSach";
            this.txtTimTLSach.Size = new System.Drawing.Size(164, 20);
            this.txtTimTLSach.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(9, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tìm Sách :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtMaTLDuocChon);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.dgvDanhMucSach);
            this.groupBox4.Controls.Add(this.txtTimDanhMucSach);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(350, 257);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(589, 303);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh Mục Sách";
            // 
            // txtMaTLDuocChon
            // 
            this.txtMaTLDuocChon.Location = new System.Drawing.Point(151, 58);
            this.txtMaTLDuocChon.Name = "txtMaTLDuocChon";
            this.txtMaTLDuocChon.Size = new System.Drawing.Size(262, 20);
            this.txtMaTLDuocChon.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(15, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Mã Thể Loại Được Chọn :";
            // 
            // dgvDanhMucSach
            // 
            this.dgvDanhMucSach.AllowUserToOrderColumns = true;
            this.dgvDanhMucSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucSach.Location = new System.Drawing.Point(15, 94);
            this.dgvDanhMucSach.Name = "dgvDanhMucSach";
            this.dgvDanhMucSach.Size = new System.Drawing.Size(560, 203);
            this.dgvDanhMucSach.TabIndex = 30;
            // 
            // txtTimDanhMucSach
            // 
            this.txtTimDanhMucSach.Location = new System.Drawing.Point(86, 22);
            this.txtTimDanhMucSach.Name = "txtTimDanhMucSach";
            this.txtTimDanhMucSach.Size = new System.Drawing.Size(262, 20);
            this.txtTimDanhMucSach.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(15, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tìm Sách :";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(382, 70);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(53, 26);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "<<";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(382, 102);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(53, 26);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = ">>";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnMuonSach
            // 
            this.btnMuonSach.Location = new System.Drawing.Point(352, 141);
            this.btnMuonSach.Name = "btnMuonSach";
            this.btnMuonSach.Size = new System.Drawing.Size(106, 43);
            this.btnMuonSach.TabIndex = 6;
            this.btnMuonSach.Text = "Mượn";
            this.btnMuonSach.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(105, 152);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(157, 20);
            this.numericUpDown1.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(16, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Số Lượng";
            // 
            // MuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 572);
            this.Controls.Add(this.btnMuonSach);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MuonSach";
            this.Text = "Mượn Sách";
            this.Load += new System.EventHandler(this.MuonSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmUDGiaThue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmUDTienCoc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoaiSach)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnMuonSach;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtMaĐG;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DateTimePicker dptNgayTra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMaPM;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.DataGridView dgvTheLoaiSach;
        private System.Windows.Forms.TextBox txtTimTLSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDanhMucSach;
        private System.Windows.Forms.TextBox txtTimDanhMucSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaTLDuocChon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NmUDGiaThue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NmUDTienCoc;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
    }
}