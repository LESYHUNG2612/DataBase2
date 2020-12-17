
namespace DoAnCoSo_CSDL2
{
    partial class frmPhieuNhacTra
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbomanv = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbomasach = new System.Windows.Forms.ComboBox();
            this.cbomathe = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtngaplap = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdgp = new System.Windows.Forms.TextBox();
            this.txtmapnt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblhienthinv = new System.Windows.Forms.Label();
            this.lblthongbaopnt = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.btnluupnt = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnsuapnt = new System.Windows.Forms.Button();
            this.btnthempnt = new System.Windows.Forms.Button();
            this.btnxoapnt = new System.Windows.Forms.Button();
            this.dgvttpnt = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvttpnt)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(146, 257);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(208, 20);
            this.txtghichu.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ghi Chú";
            // 
            // cbomanv
            // 
            this.cbomanv.FormattingEnabled = true;
            this.cbomanv.Location = new System.Drawing.Point(146, 222);
            this.cbomanv.Name = "cbomanv";
            this.cbomanv.Size = new System.Drawing.Size(208, 21);
            this.cbomanv.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtghichu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbomanv);
            this.groupBox1.Controls.Add(this.cbomasach);
            this.groupBox1.Controls.Add(this.cbomathe);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtngaplap);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtdgp);
            this.groupBox1.Controls.Add(this.txtmapnt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 320);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Phiếu Nhắc Nhở";
            // 
            // cbomasach
            // 
            this.cbomasach.FormattingEnabled = true;
            this.cbomasach.Location = new System.Drawing.Point(146, 186);
            this.cbomasach.Name = "cbomasach";
            this.cbomasach.Size = new System.Drawing.Size(206, 21);
            this.cbomasach.TabIndex = 3;
            // 
            // cbomathe
            // 
            this.cbomathe.FormattingEnabled = true;
            this.cbomathe.Location = new System.Drawing.Point(146, 73);
            this.cbomathe.Name = "cbomathe";
            this.cbomathe.Size = new System.Drawing.Size(208, 21);
            this.cbomathe.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã NV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Thẻ";
            // 
            // dtngaplap
            // 
            this.dtngaplap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaplap.Location = new System.Drawing.Point(146, 107);
            this.dtngaplap.Name = "dtngaplap";
            this.dtngaplap.Size = new System.Drawing.Size(147, 20);
            this.dtngaplap.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã Sách";
            // 
            // txtdgp
            // 
            this.txtdgp.Location = new System.Drawing.Point(146, 150);
            this.txtdgp.Name = "txtdgp";
            this.txtdgp.Size = new System.Drawing.Size(104, 20);
            this.txtdgp.TabIndex = 1;
            this.txtdgp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdgp_KeyPress);
            // 
            // txtmapnt
            // 
            this.txtmapnt.Location = new System.Drawing.Point(146, 35);
            this.txtmapnt.Name = "txtmapnt";
            this.txtmapnt.Size = new System.Drawing.Size(99, 20);
            this.txtmapnt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đơn Gía Phạt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Lập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã PNT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Colonna MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(466, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(357, 28);
            this.label9.TabIndex = 32;
            this.label9.Text = "DANH MỤC PHIẾU NHẮC TRẢ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblhienthinv);
            this.groupBox3.Controls.Add(this.lblthongbaopnt);
            this.groupBox3.Controls.Add(this.btn);
            this.groupBox3.Controls.Add(this.btnluupnt);
            this.groupBox3.Controls.Add(this.btntimkiem);
            this.groupBox3.Controls.Add(this.btnsuapnt);
            this.groupBox3.Controls.Add(this.btnthempnt);
            this.groupBox3.Controls.Add(this.btnxoapnt);
            this.groupBox3.Location = new System.Drawing.Point(12, 380);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(464, 296);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xử Lý";
            // 
            // lblhienthinv
            // 
            this.lblhienthinv.AutoSize = true;
            this.lblhienthinv.Location = new System.Drawing.Point(129, 27);
            this.lblhienthinv.Name = "lblhienthinv";
            this.lblhienthinv.Size = new System.Drawing.Size(0, 13);
            this.lblhienthinv.TabIndex = 2;
            // 
            // lblthongbaopnt
            // 
            this.lblthongbaopnt.AutoSize = true;
            this.lblthongbaopnt.Location = new System.Drawing.Point(113, 16);
            this.lblthongbaopnt.Name = "lblthongbaopnt";
            this.lblthongbaopnt.Size = new System.Drawing.Size(0, 13);
            this.lblthongbaopnt.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources.Button_Close_icon1;
            this.btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn.Location = new System.Drawing.Point(286, 210);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(111, 37);
            this.btn.TabIndex = 0;
            this.btn.Text = "Thoát";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnluupnt
            // 
            this.btnluupnt.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources.accept_icon__1_22;
            this.btnluupnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnluupnt.Location = new System.Drawing.Point(286, 121);
            this.btnluupnt.Name = "btnluupnt";
            this.btnluupnt.Size = new System.Drawing.Size(111, 37);
            this.btnluupnt.TabIndex = 0;
            this.btnluupnt.Text = "Lưu";
            this.btnluupnt.UseVisualStyleBackColor = true;
            this.btnluupnt.Click += new System.EventHandler(this.btnluupnt_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources.application_form_magnify_icon__1_1;
            this.btntimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btntimkiem.Location = new System.Drawing.Point(289, 36);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(111, 37);
            this.btntimkiem.TabIndex = 0;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            // 
            // btnsuapnt
            // 
            this.btnsuapnt.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources.application_form_edit_icon1;
            this.btnsuapnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsuapnt.Location = new System.Drawing.Point(63, 210);
            this.btnsuapnt.Name = "btnsuapnt";
            this.btnsuapnt.Size = new System.Drawing.Size(109, 37);
            this.btnsuapnt.TabIndex = 0;
            this.btnsuapnt.Text = "Sửa";
            this.btnsuapnt.UseVisualStyleBackColor = true;
            this.btnsuapnt.Click += new System.EventHandler(this.btnsuapnt_Click);
            // 
            // btnthempnt
            // 
            this.btnthempnt.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources.application_form_add_icon1;
            this.btnthempnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnthempnt.Location = new System.Drawing.Point(63, 36);
            this.btnthempnt.Name = "btnthempnt";
            this.btnthempnt.Size = new System.Drawing.Size(109, 37);
            this.btnthempnt.TabIndex = 0;
            this.btnthempnt.Text = "Thêm";
            this.btnthempnt.UseVisualStyleBackColor = true;
            this.btnthempnt.Click += new System.EventHandler(this.btnthempnt_Click);
            // 
            // btnxoapnt
            // 
            this.btnxoapnt.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources.delete_icon__2_1;
            this.btnxoapnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnxoapnt.Location = new System.Drawing.Point(66, 121);
            this.btnxoapnt.Name = "btnxoapnt";
            this.btnxoapnt.Size = new System.Drawing.Size(109, 37);
            this.btnxoapnt.TabIndex = 0;
            this.btnxoapnt.Text = "Xóa";
            this.btnxoapnt.UseVisualStyleBackColor = true;
            this.btnxoapnt.Click += new System.EventHandler(this.btnxoapnt_Click);
            // 
            // dgvttpnt
            // 
            this.dgvttpnt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvttpnt.Location = new System.Drawing.Point(6, 19);
            this.dgvttpnt.Name = "dgvttpnt";
            this.dgvttpnt.Size = new System.Drawing.Size(858, 588);
            this.dgvttpnt.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvttpnt);
            this.groupBox2.Location = new System.Drawing.Point(488, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(870, 622);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng Thông Tin Phiếu Nhắc Nhở";
            // 
            // frmPhieuNhacTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(1370, 688);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmPhieuNhacTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu Nhắc Trả";
            this.Load += new System.EventHandler(this.frmPhieuNhacTra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvttpnt)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbomanv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbomasach;
        private System.Windows.Forms.ComboBox cbomathe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtngaplap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdgp;
        private System.Windows.Forms.TextBox txtmapnt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblhienthinv;
        private System.Windows.Forms.Label lblthongbaopnt;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnluupnt;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnsuapnt;
        private System.Windows.Forms.Button btnthempnt;
        private System.Windows.Forms.Button btnxoapnt;
        private System.Windows.Forms.DataGridView dgvttpnt;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}