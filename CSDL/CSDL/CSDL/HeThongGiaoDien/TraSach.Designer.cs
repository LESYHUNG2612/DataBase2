
namespace CSDL
{
    partial class TraSach
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
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.NmUDThanhToan = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.cbbMaPM = new System.Windows.Forms.ComboBox();
            this.cbbMaDG = new System.Windows.Forms.ComboBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSachDaMuon = new System.Windows.Forms.DataGridView();
            this.txtTimTLSach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvSachMuonTra = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmUDThanhToan)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachDaMuon)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMuonTra)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThanhToan);
            this.groupBox1.Controls.Add(this.NmUDThanhToan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpNgayMuon);
            this.groupBox1.Controls.Add(this.cbbMaPM);
            this.groupBox1.Controls.Add(this.cbbMaDG);
            this.groupBox1.Controls.Add(this.btnXem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Mượn";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(168, 209);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(90, 29);
            this.btnThanhToan.TabIndex = 46;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // NmUDThanhToan
            // 
            this.NmUDThanhToan.Hexadecimal = true;
            this.NmUDThanhToan.Location = new System.Drawing.Point(143, 164);
            this.NmUDThanhToan.Name = "NmUDThanhToan";
            this.NmUDThanhToan.Size = new System.Drawing.Size(115, 20);
            this.NmUDThanhToan.TabIndex = 45;
            this.NmUDThanhToan.ThousandsSeparator = true;
            this.NmUDThanhToan.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(25, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Cần Phải Thanh Toán";
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMuon.Location = new System.Drawing.Point(101, 111);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(155, 20);
            this.dtpNgayMuon.TabIndex = 34;
            // 
            // cbbMaPM
            // 
            this.cbbMaPM.FormattingEnabled = true;
            this.cbbMaPM.Location = new System.Drawing.Point(101, 75);
            this.cbbMaPM.Name = "cbbMaPM";
            this.cbbMaPM.Size = new System.Drawing.Size(155, 21);
            this.cbbMaPM.TabIndex = 12;
            // 
            // cbbMaDG
            // 
            this.cbbMaDG.FormattingEnabled = true;
            this.cbbMaDG.Location = new System.Drawing.Point(101, 34);
            this.cbbMaDG.Name = "cbbMaDG";
            this.cbbMaDG.Size = new System.Drawing.Size(155, 21);
            this.cbbMaDG.TabIndex = 11;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(60, 209);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(90, 29);
            this.btnXem.TabIndex = 10;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã PM:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Độc Giả:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSachDaMuon);
            this.groupBox2.Controls.Add(this.txtTimTLSach);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 255);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sách Đã Mượn";
            // 
            // dgvSachDaMuon
            // 
            this.dgvSachDaMuon.AllowUserToOrderColumns = true;
            this.dgvSachDaMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachDaMuon.Location = new System.Drawing.Point(6, 55);
            this.dgvSachDaMuon.Name = "dgvSachDaMuon";
            this.dgvSachDaMuon.Size = new System.Drawing.Size(295, 239);
            this.dgvSachDaMuon.TabIndex = 32;
            // 
            // txtTimTLSach
            // 
            this.txtTimTLSach.Location = new System.Drawing.Point(92, 29);
            this.txtTimTLSach.Name = "txtTimTLSach";
            this.txtTimTLSach.Size = new System.Drawing.Size(164, 20);
            this.txtTimTLSach.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(21, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Tìm Sách :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvSachMuonTra);
            this.groupBox3.Location = new System.Drawing.Point(326, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(575, 428);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sách Muốn Trả";
            // 
            // dgvSachMuonTra
            // 
            this.dgvSachMuonTra.AllowUserToOrderColumns = true;
            this.dgvSachMuonTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachMuonTra.Location = new System.Drawing.Point(6, 19);
            this.dgvSachMuonTra.Name = "dgvSachMuonTra";
            this.dgvSachMuonTra.Size = new System.Drawing.Size(563, 403);
            this.dgvSachMuonTra.TabIndex = 31;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnTraSach);
            this.groupBox4.Controls.Add(this.btnXoa);
            this.groupBox4.Controls.Add(this.btnThem);
            this.groupBox4.Location = new System.Drawing.Point(326, 447);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(575, 85);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin Mượn";
            // 
            // btnTraSach
            // 
            this.btnTraSach.Location = new System.Drawing.Point(363, 24);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(106, 43);
            this.btnTraSach.TabIndex = 9;
            this.btnTraSach.Text = "Trả Sách";
            this.btnTraSach.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(87, 32);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(53, 26);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "<<";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(226, 32);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(53, 26);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = ">>";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // TraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 544);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TraSach";
            this.Text = "Trả Sách";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmUDThanhToan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachDaMuon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMuonTra)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbMaPM;
        private System.Windows.Forms.ComboBox cbbMaDG;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.TextBox txtTimTLSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvSachDaMuon;
        private System.Windows.Forms.DataGridView dgvSachMuonTra;
        private System.Windows.Forms.NumericUpDown NmUDThanhToan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThanhToan;
    }
}