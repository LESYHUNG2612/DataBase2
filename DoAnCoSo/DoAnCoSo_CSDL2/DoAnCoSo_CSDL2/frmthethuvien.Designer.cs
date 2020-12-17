
namespace DoAnCoSo_CSDL2
{
    partial class frmthethuvien
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbltong = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.dgvttttv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboGioitinh = new System.Windows.Forms.ComboBox();
            this.txtdiachisv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtngaysinh = new System.Windows.Forms.DateTimePicker();
            this.dtngayhethan = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtngaytao = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdt = new System.Windows.Forms.TextBox();
            this.txtTensv = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblthongbao = new System.Windows.Forms.Label();
            this.lblthongbaottv = new System.Windows.Forms.Label();
            this.btnthoatttv = new System.Windows.Forms.Button();
            this.btntimkiemttv = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnxoattv = new System.Windows.Forms.Button();
            this.btnsuattv = new System.Windows.Forms.Button();
            this.btnin = new System.Windows.Forms.Button();
            this.btnluuttv = new System.Windows.Forms.Button();
            this.btnthemttv = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvttttv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lbltong);
            this.groupBox2.Controls.Add(this.lbl);
            this.groupBox2.Controls.Add(this.dgvttttv);
            this.groupBox2.Location = new System.Drawing.Point(12, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(936, 482);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng Thông Tin Thẻ Thư Viện";
            // 
            // lbltong
            // 
            this.lbltong.AutoSize = true;
            this.lbltong.Location = new System.Drawing.Point(107, 455);
            this.lbltong.Name = "lbltong";
            this.lbltong.Size = new System.Drawing.Size(16, 13);
            this.lbltong.TabIndex = 2;
            this.lbltong.Text = "...";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(18, 455);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(83, 13);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Tổng Sinh Viên:";
            // 
            // dgvttttv
            // 
            this.dgvttttv.AllowUserToAddRows = false;
            this.dgvttttv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvttttv.Location = new System.Drawing.Point(21, 19);
            this.dgvttttv.Name = "dgvttttv";
            this.dgvttttv.Size = new System.Drawing.Size(894, 425);
            this.dgvttttv.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cboGioitinh);
            this.groupBox1.Controls.Add(this.txtdiachisv);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtngaysinh);
            this.groupBox1.Controls.Add(this.dtngayhethan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtngaytao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtdt);
            this.groupBox1.Controls.Add(this.txtTensv);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1322, 138);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // cboGioitinh
            // 
            this.cboGioitinh.FormattingEnabled = true;
            this.cboGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioitinh.Location = new System.Drawing.Point(251, 15);
            this.cboGioitinh.Name = "cboGioitinh";
            this.cboGioitinh.Size = new System.Drawing.Size(75, 21);
            this.cboGioitinh.TabIndex = 6;
            // 
            // txtdiachisv
            // 
            this.txtdiachisv.Location = new System.Drawing.Point(1058, 26);
            this.txtdiachisv.Multiline = true;
            this.txtdiachisv.Name = "txtdiachisv";
            this.txtdiachisv.Size = new System.Drawing.Size(199, 90);
            this.txtdiachisv.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(984, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa Chỉ SV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gioi Tính";
            // 
            // dtngaysinh
            // 
            this.dtngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaysinh.Location = new System.Drawing.Point(605, 17);
            this.dtngaysinh.Name = "dtngaysinh";
            this.dtngaysinh.Size = new System.Drawing.Size(200, 20);
            this.dtngaysinh.TabIndex = 4;
            // 
            // dtngayhethan
            // 
            this.dtngayhethan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngayhethan.Location = new System.Drawing.Point(605, 51);
            this.dtngayhethan.Name = "dtngayhethan";
            this.dtngayhethan.Size = new System.Drawing.Size(200, 20);
            this.dtngayhethan.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(512, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày Hết Hạn";
            // 
            // dtngaytao
            // 
            this.dtngaytao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaytao.Location = new System.Drawing.Point(605, 86);
            this.dtngaytao.Name = "dtngaytao";
            this.dtngaytao.Size = new System.Drawing.Size(200, 20);
            this.dtngaytao.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Tạo";
            // 
            // txtdt
            // 
            this.txtdt.Location = new System.Drawing.Point(79, 91);
            this.txtdt.Name = "txtdt";
            this.txtdt.Size = new System.Drawing.Size(247, 20);
            this.txtdt.TabIndex = 1;
            this.txtdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdt_KeyPress);
            // 
            // txtTensv
            // 
            this.txtTensv.Location = new System.Drawing.Point(79, 55);
            this.txtTensv.Name = "txtTensv";
            this.txtTensv.Size = new System.Drawing.Size(247, 20);
            this.txtTensv.TabIndex = 1;
            this.txtTensv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTensv_KeyPress);
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(79, 18);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(75, 20);
            this.txtMa.TabIndex = 1;
            this.txtMa.Text = "7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Điện Thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên SV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Thẻ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Colonna MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(530, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(322, 28);
            this.label9.TabIndex = 33;
            this.label9.Text = "DANH MỤC THẺ THƯ VIỆN";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblthongbao);
            this.groupBox3.Controls.Add(this.lblthongbaottv);
            this.groupBox3.Controls.Add(this.btnthoatttv);
            this.groupBox3.Controls.Add(this.btntimkiemttv);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.btnxoattv);
            this.groupBox3.Controls.Add(this.btnsuattv);
            this.groupBox3.Controls.Add(this.btnin);
            this.groupBox3.Controls.Add(this.btnluuttv);
            this.groupBox3.Controls.Add(this.btnthemttv);
            this.groupBox3.Location = new System.Drawing.Point(954, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(390, 482);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xử Lý";
            // 
            // lblthongbao
            // 
            this.lblthongbao.AutoSize = true;
            this.lblthongbao.Location = new System.Drawing.Point(88, 35);
            this.lblthongbao.Name = "lblthongbao";
            this.lblthongbao.Size = new System.Drawing.Size(0, 13);
            this.lblthongbao.TabIndex = 2;
            // 
            // lblthongbaottv
            // 
            this.lblthongbaottv.AutoSize = true;
            this.lblthongbaottv.Location = new System.Drawing.Point(533, 380);
            this.lblthongbaottv.Name = "lblthongbaottv";
            this.lblthongbaottv.Size = new System.Drawing.Size(0, 13);
            this.lblthongbaottv.TabIndex = 1;
            // 
            // btnthoatttv
            // 
            this.btnthoatttv.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources.Button_Close_icon1;
            this.btnthoatttv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnthoatttv.Location = new System.Drawing.Point(226, 277);
            this.btnthoatttv.Name = "btnthoatttv";
            this.btnthoatttv.Size = new System.Drawing.Size(123, 41);
            this.btnthoatttv.TabIndex = 0;
            this.btnthoatttv.Text = "      Thoát";
            this.btnthoatttv.UseVisualStyleBackColor = true;
            this.btnthoatttv.Click += new System.EventHandler(this.btnthoatttv_Click);
            // 
            // btntimkiemttv
            // 
            this.btntimkiemttv.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources.Folder_saved_search_icon;
            this.btntimkiemttv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btntimkiemttv.Location = new System.Drawing.Point(240, 403);
            this.btntimkiemttv.Name = "btntimkiemttv";
            this.btntimkiemttv.Size = new System.Drawing.Size(123, 26);
            this.btntimkiemttv.TabIndex = 0;
            this.btntimkiemttv.Text = "      Tìm Kiếm";
            this.btntimkiemttv.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 407);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnxoattv
            // 
            this.btnxoattv.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources.delete_icon__1_1;
            this.btnxoattv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnxoattv.Location = new System.Drawing.Point(35, 277);
            this.btnxoattv.Name = "btnxoattv";
            this.btnxoattv.Size = new System.Drawing.Size(123, 41);
            this.btnxoattv.TabIndex = 0;
            this.btnxoattv.Text = "       Xóa";
            this.btnxoattv.UseVisualStyleBackColor = true;
            this.btnxoattv.Click += new System.EventHandler(this.btnxoattv_Click);
            // 
            // btnsuattv
            // 
            this.btnsuattv.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources.application_form_edit_icon;
            this.btnsuattv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsuattv.Location = new System.Drawing.Point(226, 187);
            this.btnsuattv.Name = "btnsuattv";
            this.btnsuattv.Size = new System.Drawing.Size(123, 41);
            this.btnsuattv.TabIndex = 0;
            this.btnsuattv.Text = "     Sửa";
            this.btnsuattv.UseVisualStyleBackColor = true;
            this.btnsuattv.Click += new System.EventHandler(this.btnsuattv_Click);
            // 
            // btnin
            // 
            this.btnin.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources.p11;
            this.btnin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnin.Location = new System.Drawing.Point(226, 79);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(123, 41);
            this.btnin.TabIndex = 0;
            this.btnin.Text = "    In";
            this.btnin.UseVisualStyleBackColor = true;
            // 
            // btnluuttv
            // 
            this.btnluuttv.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources.accept_icon__1_2;
            this.btnluuttv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnluuttv.Location = new System.Drawing.Point(35, 187);
            this.btnluuttv.Name = "btnluuttv";
            this.btnluuttv.Size = new System.Drawing.Size(123, 41);
            this.btnluuttv.TabIndex = 0;
            this.btnluuttv.Text = "       Lưu";
            this.btnluuttv.UseVisualStyleBackColor = true;
            this.btnluuttv.Click += new System.EventHandler(this.btnluuttv_Click);
            // 
            // btnthemttv
            // 
            this.btnthemttv.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources.application_form_add_icon;
            this.btnthemttv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnthemttv.Location = new System.Drawing.Point(35, 79);
            this.btnthemttv.Name = "btnthemttv";
            this.btnthemttv.Size = new System.Drawing.Size(123, 41);
            this.btnthemttv.TabIndex = 0;
            this.btnthemttv.Text = "      Thêm";
            this.btnthemttv.UseVisualStyleBackColor = true;
            this.btnthemttv.Click += new System.EventHandler(this.btnthemttv_Click);
            // 
            // frmthethuvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(1370, 688);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmthethuvien";
            this.Text = "frmthethuvien";
            this.Load += new System.EventHandler(this.frmthethuvien_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvttttv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbltong;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.DataGridView dgvttttv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboGioitinh;
        private System.Windows.Forms.TextBox txtdiachisv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtngaysinh;
        private System.Windows.Forms.DateTimePicker dtngayhethan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtngaytao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdt;
        private System.Windows.Forms.TextBox txtTensv;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblthongbao;
        private System.Windows.Forms.Label lblthongbaottv;
        private System.Windows.Forms.Button btnthoatttv;
        private System.Windows.Forms.Button btntimkiemttv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnxoattv;
        private System.Windows.Forms.Button btnsuattv;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.Button btnluuttv;
        private System.Windows.Forms.Button btnthemttv;
    }
}