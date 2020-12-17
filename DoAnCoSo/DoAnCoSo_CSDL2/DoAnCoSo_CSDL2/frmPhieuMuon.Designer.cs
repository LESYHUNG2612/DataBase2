
namespace DoAnCoSo_CSDL2
{
    partial class frmPhieuMuon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuMuon));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbomathe = new System.Windows.Forms.ComboBox();
            this.cbomasach = new System.Windows.Forms.ComboBox();
            this.dtpNgaymuon = new System.Windows.Forms.DateTimePicker();
            this.txtMapm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvttpm = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblthongbaopm = new System.Windows.Forms.Label();
            this.btnin = new System.Windows.Forms.Button();
            this.btntimkiempm = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txttimkiemmapm = new System.Windows.Forms.TextBox();
            this.btnxoapm = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthempm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvttpm)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.cbomathe);
            this.groupBox1.Controls.Add(this.cbomasach);
            this.groupBox1.Controls.Add(this.dtpNgaymuon);
            this.groupBox1.Controls.Add(this.txtMapm);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 323);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Phiếu Mượn";
            // 
            // cbomathe
            // 
            this.cbomathe.FormattingEnabled = true;
            this.cbomathe.Location = new System.Drawing.Point(126, 101);
            this.cbomathe.Name = "cbomathe";
            this.cbomathe.Size = new System.Drawing.Size(218, 21);
            this.cbomathe.TabIndex = 2;
            // 
            // cbomasach
            // 
            this.cbomasach.FormattingEnabled = true;
            this.cbomasach.Location = new System.Drawing.Point(126, 179);
            this.cbomasach.Name = "cbomasach";
            this.cbomasach.Size = new System.Drawing.Size(218, 21);
            this.cbomasach.TabIndex = 2;
            // 
            // dtpNgaymuon
            // 
            this.dtpNgaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaymuon.Location = new System.Drawing.Point(126, 255);
            this.dtpNgaymuon.Name = "dtpNgaymuon";
            this.dtpNgaymuon.Size = new System.Drawing.Size(218, 20);
            this.dtpNgaymuon.TabIndex = 2;
            // 
            // txtMapm
            // 
            this.txtMapm.Location = new System.Drawing.Point(126, 33);
            this.txtMapm.Name = "txtMapm";
            this.txtMapm.Size = new System.Drawing.Size(218, 20);
            this.txtMapm.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Mượn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Thẻ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã PM";
            // 
            // dgvttpm
            // 
            this.dgvttpm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvttpm.Location = new System.Drawing.Point(24, 21);
            this.dgvttpm.Name = "dgvttpm";
            this.dgvttpm.Size = new System.Drawing.Size(875, 599);
            this.dgvttpm.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvttpm);
            this.groupBox2.Location = new System.Drawing.Point(501, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(857, 626);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng Thông Tin Nhân Viên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Colonna MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(392, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(411, 25);
            this.label9.TabIndex = 31;
            this.label9.Text = "DANH MỤC DANH SÁCH PHIẾU MƯỢN";
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.lblthongbaopm);
            this.groupBox3.Controls.Add(this.btnin);
            this.groupBox3.Controls.Add(this.btntimkiempm);
            this.groupBox3.Controls.Add(this.btnthoat);
            this.groupBox3.Controls.Add(this.txttimkiemmapm);
            this.groupBox3.Controls.Add(this.btnxoapm);
            this.groupBox3.Controls.Add(this.btnsua);
            this.groupBox3.Controls.Add(this.btnluu);
            this.groupBox3.Controls.Add(this.btnthempm);
            this.groupBox3.Location = new System.Drawing.Point(12, 379);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(483, 297);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xử Lý";
            // 
            // lblthongbaopm
            // 
            this.lblthongbaopm.AutoSize = true;
            this.lblthongbaopm.Location = new System.Drawing.Point(99, 25);
            this.lblthongbaopm.Name = "lblthongbaopm";
            this.lblthongbaopm.Size = new System.Drawing.Size(0, 13);
            this.lblthongbaopm.TabIndex = 1;
            // 
            // btnin
            // 
            this.btnin.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources.p1;
            this.btnin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnin.Location = new System.Drawing.Point(343, 41);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(110, 45);
            this.btnin.TabIndex = 0;
            this.btnin.Text = "In";
            this.btnin.UseVisualStyleBackColor = true;
            // 
            // btntimkiempm
            // 
            this.btntimkiempm.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources.application_form_magnify_icon__1_;
            this.btntimkiempm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btntimkiempm.Location = new System.Drawing.Point(277, 248);
            this.btntimkiempm.Name = "btntimkiempm";
            this.btntimkiempm.Size = new System.Drawing.Size(128, 29);
            this.btntimkiempm.TabIndex = 0;
            this.btntimkiempm.Text = "Tìm Kiếm";
            this.btntimkiempm.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            this.btnthoat.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources.Button_Close_icon;
            this.btnthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnthoat.Location = new System.Drawing.Point(343, 152);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(110, 42);
            this.btnthoat.TabIndex = 0;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txttimkiemmapm
            // 
            this.txttimkiemmapm.Location = new System.Drawing.Point(39, 253);
            this.txttimkiemmapm.Name = "txttimkiemmapm";
            this.txttimkiemmapm.Size = new System.Drawing.Size(219, 20);
            this.txttimkiemmapm.TabIndex = 1;
            this.txttimkiemmapm.Text = "Tìm mã pm";
            // 
            // btnxoapm
            // 
            this.btnxoapm.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources.Actions_application_exit_icon1;
            this.btnxoapm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnxoapm.Location = new System.Drawing.Point(177, 41);
            this.btnxoapm.Name = "btnxoapm";
            this.btnxoapm.Size = new System.Drawing.Size(110, 45);
            this.btnxoapm.TabIndex = 0;
            this.btnxoapm.Text = "Xóa";
            this.btnxoapm.UseVisualStyleBackColor = true;
            this.btnxoapm.Click += new System.EventHandler(this.btnxoapm_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources.application_form_edit_icon;
            this.btnsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsua.Location = new System.Drawing.Point(177, 152);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(110, 46);
            this.btnsua.TabIndex = 0;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluu
            // 
            this.btnluu.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources.accept_icon__1_21;
            this.btnluu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnluu.Location = new System.Drawing.Point(18, 150);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(112, 48);
            this.btnluu.TabIndex = 0;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthempm
            // 
            this.btnthempm.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources.application_form_add_icon;
            this.btnthempm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnthempm.Location = new System.Drawing.Point(18, 41);
            this.btnthempm.Name = "btnthempm";
            this.btnthempm.Size = new System.Drawing.Size(112, 45);
            this.btnthempm.TabIndex = 0;
            this.btnthempm.Text = "Thêm";
            this.btnthempm.UseVisualStyleBackColor = true;
            this.btnthempm.Click += new System.EventHandler(this.btnthempm_Click);
            // 
            // frmPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(1370, 688);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmPhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu Mượn";
            this.Load += new System.EventHandler(this.frmPhieuMuon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvttpm)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbomathe;
        private System.Windows.Forms.ComboBox cbomasach;
        private System.Windows.Forms.DateTimePicker dtpNgaymuon;
        private System.Windows.Forms.TextBox txtMapm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvttpm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblthongbaopm;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.Button btntimkiempm;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txttimkiemmapm;
        private System.Windows.Forms.Button btnxoapm;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthempm;
    }
}