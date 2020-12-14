
namespace CSDL.HeThongGiaoDien
{
    partial class NhapSach
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
            this.latieude1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnSuaPN = new System.Windows.Forms.Button();
            this.btnXoaPN = new System.Windows.Forms.Button();
            this.btnThemMaNS = new System.Windows.Forms.Button();
            this.btnLuuPN = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblthongbaoPNS = new System.Windows.Forms.Label();
            this.cbbMaNV = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.cbbMaSach = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvNhapSach = new System.Windows.Forms.DataGridView();
            this.txtSoLuong = new System.Windows.Forms.NumericUpDown();
            this.txtGiaSach = new System.Windows.Forms.NumericUpDown();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaSach)).BeginInit();
            this.SuspendLayout();
            // 
            // latieude1
            // 
            this.latieude1.AutoSize = true;
            this.latieude1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latieude1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.latieude1.Location = new System.Drawing.Point(286, 11);
            this.latieude1.Name = "latieude1";
            this.latieude1.Size = new System.Drawing.Size(264, 31);
            this.latieude1.TabIndex = 17;
            this.latieude1.Text = "PHIẾU NHẬP SÁCH";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnSuaPN);
            this.groupBox6.Controls.Add(this.btnXoaPN);
            this.groupBox6.Controls.Add(this.btnThemMaNS);
            this.groupBox6.Controls.Add(this.btnLuuPN);
            this.groupBox6.Location = new System.Drawing.Point(15, 349);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(468, 91);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Các chức năng";
            // 
            // btnSuaPN
            // 
            this.btnSuaPN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuaPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaPN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSuaPN.Location = new System.Drawing.Point(252, 34);
            this.btnSuaPN.Name = "btnSuaPN";
            this.btnSuaPN.Size = new System.Drawing.Size(84, 23);
            this.btnSuaPN.TabIndex = 4;
            this.btnSuaPN.Text = "Sửa PN";
            this.btnSuaPN.UseVisualStyleBackColor = true;
            this.btnSuaPN.Click += new System.EventHandler(this.btnSuaPN_Click);
            // 
            // btnXoaPN
            // 
            this.btnXoaPN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoaPN.Location = new System.Drawing.Point(361, 34);
            this.btnXoaPN.Name = "btnXoaPN";
            this.btnXoaPN.Size = new System.Drawing.Size(84, 23);
            this.btnXoaPN.TabIndex = 3;
            this.btnXoaPN.Text = "Xóa PN";
            this.btnXoaPN.UseVisualStyleBackColor = true;
            this.btnXoaPN.Click += new System.EventHandler(this.btnXoaPN_Click);
            // 
            // btnThemMaNS
            // 
            this.btnThemMaNS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemMaNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMaNS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThemMaNS.Location = new System.Drawing.Point(37, 34);
            this.btnThemMaNS.Name = "btnThemMaNS";
            this.btnThemMaNS.Size = new System.Drawing.Size(84, 23);
            this.btnThemMaNS.TabIndex = 2;
            this.btnThemMaNS.Text = "Thêm MaNS";
            this.btnThemMaNS.UseVisualStyleBackColor = true;
            this.btnThemMaNS.Click += new System.EventHandler(this.btnThemMaNS_Click);
            // 
            // btnLuuPN
            // 
            this.btnLuuPN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuuPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuPN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLuuPN.Location = new System.Drawing.Point(150, 34);
            this.btnLuuPN.Name = "btnLuuPN";
            this.btnLuuPN.Size = new System.Drawing.Size(84, 23);
            this.btnLuuPN.TabIndex = 0;
            this.btnLuuPN.Text = "LưuPN";
            this.btnLuuPN.UseVisualStyleBackColor = true;
            this.btnLuuPN.Click += new System.EventHandler(this.btnLuuPN_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGiaSach);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.lblthongbaoPNS);
            this.groupBox2.Controls.Add(this.cbbMaNV);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.cbbMaSach);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMaPN);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(15, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 298);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sách nhập";
            // 
            // lblthongbaoPNS
            // 
            this.lblthongbaoPNS.AutoSize = true;
            this.lblthongbaoPNS.Location = new System.Drawing.Point(130, 16);
            this.lblthongbaoPNS.Name = "lblthongbaoPNS";
            this.lblthongbaoPNS.Size = new System.Drawing.Size(16, 13);
            this.lblthongbaoPNS.TabIndex = 21;
            this.lblthongbaoPNS.Text = "...";
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.FormattingEnabled = true;
            this.cbbMaNV.Location = new System.Drawing.Point(185, 142);
            this.cbbMaNV.Name = "cbbMaNV";
            this.cbbMaNV.Size = new System.Drawing.Size(162, 21);
            this.cbbMaNV.TabIndex = 18;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Location = new System.Drawing.Point(94, 150);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(40, 13);
            this.label28.TabIndex = 17;
            this.label28.Text = "Mã NV";
            // 
            // cbbMaSach
            // 
            this.cbbMaSach.FormattingEnabled = true;
            this.cbbMaSach.Location = new System.Drawing.Point(185, 87);
            this.cbbMaSach.Name = "cbbMaSach";
            this.cbbMaSach.Size = new System.Drawing.Size(162, 21);
            this.cbbMaSach.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Giá Sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã sách:";
            // 
            // txtMaPN
            // 
            this.txtMaPN.Location = new System.Drawing.Point(185, 34);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.ReadOnly = true;
            this.txtMaPN.Size = new System.Drawing.Size(162, 20);
            this.txtMaPN.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã phiếu nhập:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNhapSach);
            this.groupBox1.Location = new System.Drawing.Point(489, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 395);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu nhập chi tiết";
            // 
            // dgvNhapSach
            // 
            this.dgvNhapSach.AllowUserToOrderColumns = true;
            this.dgvNhapSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapSach.Location = new System.Drawing.Point(6, 16);
            this.dgvNhapSach.Name = "dgvNhapSach";
            this.dgvNhapSach.Size = new System.Drawing.Size(502, 373);
            this.dgvNhapSach.TabIndex = 23;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(185, 207);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(169, 20);
            this.txtSoLuong.TabIndex = 22;
            // 
            // txtGiaSach
            // 
            this.txtGiaSach.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtGiaSach.Location = new System.Drawing.Point(185, 257);
            this.txtGiaSach.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtGiaSach.Name = "txtGiaSach";
            this.txtGiaSach.Size = new System.Drawing.Size(169, 20);
            this.txtGiaSach.TabIndex = 23;
            // 
            // NhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 450);
            this.Controls.Add(this.latieude1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NhapSach";
            this.Text = "NhapSach";
            this.Load += new System.EventHandler(this.NhapSach_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label latieude1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnLuuPN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbMaSach;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox cbbMaNV;
        private System.Windows.Forms.Button btnThemMaNS;
        private System.Windows.Forms.Button btnXoaPN;
        private System.Windows.Forms.Button btnSuaPN;
        private System.Windows.Forms.Label lblthongbaoPNS;
        private System.Windows.Forms.DataGridView dgvNhapSach;
        private System.Windows.Forms.NumericUpDown txtGiaSach;
        private System.Windows.Forms.NumericUpDown txtSoLuong;
    }
}