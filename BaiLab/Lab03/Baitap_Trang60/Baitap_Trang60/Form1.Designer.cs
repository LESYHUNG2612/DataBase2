namespace Baitap_Trang60
{
    partial class Form1
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
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.cbPhongban = new System.Windows.Forms.ComboBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.mtbSodt = new System.Windows.Forms.MaskedTextBox();
            this.dtpkNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.mtbNV = new System.Windows.Forms.MaskedTextBox();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.lbHinh = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPhongban = new System.Windows.Forms.Label();
            this.lbDiachi = new System.Windows.Forms.Label();
            this.lbSodt = new System.Windows.Forms.Label();
            this.lbNgaysinh = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbGoitinh = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lvInfo = new System.Windows.Forms.ListView();
            this.ptbImage = new System.Windows.Forms.PictureBox();
            this.cbAddImage = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAddImage);
            this.groupBox1.Controls.Add(this.ptbImage);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.cbPhongban);
            this.groupBox1.Controls.Add(this.tbDiaChi);
            this.groupBox1.Controls.Add(this.mtbSodt);
            this.groupBox1.Controls.Add(this.dtpkNgaySinh);
            this.groupBox1.Controls.Add(this.tbTen);
            this.groupBox1.Controls.Add(this.mtbNV);
            this.groupBox1.Controls.Add(this.rbNu);
            this.groupBox1.Controls.Add(this.rbNam);
            this.groupBox1.Controls.Add(this.lbHinh);
            this.groupBox1.Controls.Add(this.lbEmail);
            this.groupBox1.Controls.Add(this.lbPhongban);
            this.groupBox1.Controls.Add(this.lbDiachi);
            this.groupBox1.Controls.Add(this.lbSodt);
            this.groupBox1.Controls.Add(this.lbNgaysinh);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.lbGoitinh);
            this.groupBox1.Controls.Add(this.lbMaNV);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1003, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(740, 206);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(179, 22);
            this.tbEmail.TabIndex = 12;
            // 
            // cbPhongban
            // 
            this.cbPhongban.FormattingEnabled = true;
            this.cbPhongban.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04"});
            this.cbPhongban.Location = new System.Drawing.Point(458, 206);
            this.cbPhongban.Name = "cbPhongban";
            this.cbPhongban.Size = new System.Drawing.Size(121, 24);
            this.cbPhongban.TabIndex = 11;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(458, 157);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(276, 22);
            this.tbDiaChi.TabIndex = 10;
            // 
            // mtbSodt
            // 
            this.mtbSodt.Location = new System.Drawing.Point(740, 114);
            this.mtbSodt.Mask = "\\0633. 000 . 000";
            this.mtbSodt.Name = "mtbSodt";
            this.mtbSodt.Size = new System.Drawing.Size(179, 22);
            this.mtbSodt.TabIndex = 9;
            // 
            // dtpkNgaySinh
            // 
            this.dtpkNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgaySinh.Location = new System.Drawing.Point(458, 112);
            this.dtpkNgaySinh.Name = "dtpkNgaySinh";
            this.dtpkNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dtpkNgaySinh.TabIndex = 8;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(458, 69);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(276, 22);
            this.tbTen.TabIndex = 7;
            // 
            // mtbNV
            // 
            this.mtbNV.Location = new System.Drawing.Point(458, 32);
            this.mtbNV.Mask = "NV. 000";
            this.mtbNV.Name = "mtbNV";
            this.mtbNV.Size = new System.Drawing.Size(131, 22);
            this.mtbNV.TabIndex = 1;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(872, 33);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(47, 21);
            this.rbNu.TabIndex = 1;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(779, 33);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(58, 21);
            this.rbNam.TabIndex = 0;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // lbHinh
            // 
            this.lbHinh.AutoSize = true;
            this.lbHinh.Location = new System.Drawing.Point(336, 243);
            this.lbHinh.Name = "lbHinh";
            this.lbHinh.Size = new System.Drawing.Size(37, 17);
            this.lbHinh.TabIndex = 6;
            this.lbHinh.Text = "Hình";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(686, 206);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(42, 17);
            this.lbEmail.TabIndex = 5;
            this.lbEmail.Text = "Email";
            // 
            // lbPhongban
            // 
            this.lbPhongban.AutoSize = true;
            this.lbPhongban.Location = new System.Drawing.Point(336, 206);
            this.lbPhongban.Name = "lbPhongban";
            this.lbPhongban.Size = new System.Drawing.Size(77, 17);
            this.lbPhongban.TabIndex = 4;
            this.lbPhongban.Text = "Phòng ban";
            // 
            // lbDiachi
            // 
            this.lbDiachi.AutoSize = true;
            this.lbDiachi.Location = new System.Drawing.Point(336, 157);
            this.lbDiachi.Name = "lbDiachi";
            this.lbDiachi.Size = new System.Drawing.Size(51, 17);
            this.lbDiachi.TabIndex = 2;
            this.lbDiachi.Text = "Địa chỉ";
            // 
            // lbSodt
            // 
            this.lbSodt.AutoSize = true;
            this.lbSodt.Location = new System.Drawing.Point(686, 117);
            this.lbSodt.Name = "lbSodt";
            this.lbSodt.Size = new System.Drawing.Size(48, 17);
            this.lbSodt.TabIndex = 2;
            this.lbSodt.Text = "Số ĐT";
            // 
            // lbNgaysinh
            // 
            this.lbNgaysinh.AutoSize = true;
            this.lbNgaysinh.Location = new System.Drawing.Point(336, 112);
            this.lbNgaysinh.Name = "lbNgaysinh";
            this.lbNgaysinh.Size = new System.Drawing.Size(71, 17);
            this.lbNgaysinh.TabIndex = 3;
            this.lbNgaysinh.Text = "Ngày sinh";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(336, 72);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(69, 17);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Họ và tên";
            // 
            // lbGoitinh
            // 
            this.lbGoitinh.AutoSize = true;
            this.lbGoitinh.Location = new System.Drawing.Point(686, 33);
            this.lbGoitinh.Name = "lbGoitinh";
            this.lbGoitinh.Size = new System.Drawing.Size(65, 17);
            this.lbGoitinh.TabIndex = 1;
            this.lbGoitinh.Text = "Giới Tính";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(336, 35);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(97, 17);
            this.lbMaNV.TabIndex = 0;
            this.lbMaNV.Text = "Mã Nhân Viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvInfo);
            this.groupBox2.Location = new System.Drawing.Point(12, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1003, 237);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(115, 549);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 33);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(243, 549);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(113, 33);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(385, 549);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 33);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(525, 549);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(113, 33);
            this.btnDefault.TabIndex = 5;
            this.btnDefault.Text = "Mặc Định";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(666, 549);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 33);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lvInfo
            // 
            this.lvInfo.FullRowSelect = true;
            this.lvInfo.HideSelection = false;
            this.lvInfo.Location = new System.Drawing.Point(6, 21);
            this.lvInfo.Name = "lvInfo";
            this.lvInfo.Size = new System.Drawing.Size(991, 210);
            this.lvInfo.TabIndex = 0;
            this.lvInfo.UseCompatibleStateImageBehavior = false;
            this.lvInfo.View = System.Windows.Forms.View.Details;
            // 
            // ptbImage
            // 
            this.ptbImage.Location = new System.Drawing.Point(20, 32);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(272, 228);
            this.ptbImage.TabIndex = 13;
            this.ptbImage.TabStop = false;
            // 
            // cbAddImage
            // 
            this.cbAddImage.FormattingEnabled = true;
            this.cbAddImage.Location = new System.Drawing.Point(458, 243);
            this.cbAddImage.Name = "cbAddImage";
            this.cbAddImage.Size = new System.Drawing.Size(121, 24);
            this.cbAddImage.TabIndex = 14;
            this.cbAddImage.SelectedIndexChanged += new System.EventHandler(this.cbAddImage_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 594);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.Label lbHinh;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPhongban;
        private System.Windows.Forms.Label lbDiachi;
        private System.Windows.Forms.Label lbSodt;
        private System.Windows.Forms.Label lbNgaysinh;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbGoitinh;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.ComboBox cbPhongban;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.MaskedTextBox mtbSodt;
        private System.Windows.Forms.DateTimePicker dtpkNgaySinh;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.MaskedTextBox mtbNV;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView lvInfo;
        private System.Windows.Forms.ComboBox cbAddImage;
        private System.Windows.Forms.PictureBox ptbImage;
    }
}

