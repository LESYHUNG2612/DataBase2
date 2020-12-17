
namespace DoAnCoSo_CSDL2
{
    partial class frmSachMuon
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
            this.dtngayphaitra = new System.Windows.Forms.DateTimePicker();
            this.cbomapm = new System.Windows.Forms.ComboBox();
            this.dtngaytra = new System.Windows.Forms.GroupBox();
            this.cbomasach = new System.Windows.Forms.ComboBox();
            this.txttinhtrang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsoluongsm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblthongbaosm = new System.Windows.Forms.Label();
            this.btnthoatSM = new System.Windows.Forms.Button();
            this.btnluusm = new System.Windows.Forms.Button();
            this.btnsuasm = new System.Windows.Forms.Button();
            this.btnxoaSM = new System.Windows.Forms.Button();
            this.btnload = new System.Windows.Forms.Button();
            this.btnthemnv = new System.Windows.Forms.Button();
            this.dgvsachmuon = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtngaytra.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsachmuon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dtngayphaitra
            // 
            this.dtngayphaitra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngayphaitra.Location = new System.Drawing.Point(182, 308);
            this.dtngayphaitra.Name = "dtngayphaitra";
            this.dtngayphaitra.Size = new System.Drawing.Size(274, 20);
            this.dtngayphaitra.TabIndex = 7;
            // 
            // cbomapm
            // 
            this.cbomapm.FormattingEnabled = true;
            this.cbomapm.Location = new System.Drawing.Point(182, 97);
            this.cbomapm.Name = "cbomapm";
            this.cbomapm.Size = new System.Drawing.Size(274, 21);
            this.cbomapm.TabIndex = 6;
            // 
            // dtngaytra
            // 
            this.dtngaytra.BackColor = System.Drawing.Color.Transparent;
            this.dtngaytra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dtngaytra.Controls.Add(this.dtngayphaitra);
            this.dtngaytra.Controls.Add(this.cbomapm);
            this.dtngaytra.Controls.Add(this.cbomasach);
            this.dtngaytra.Controls.Add(this.txttinhtrang);
            this.dtngaytra.Controls.Add(this.label6);
            this.dtngaytra.Controls.Add(this.label3);
            this.dtngaytra.Controls.Add(this.txtsoluongsm);
            this.dtngaytra.Controls.Add(this.label7);
            this.dtngaytra.Controls.Add(this.label2);
            this.dtngaytra.Controls.Add(this.label1);
            this.dtngaytra.Location = new System.Drawing.Point(12, 55);
            this.dtngaytra.Name = "dtngaytra";
            this.dtngaytra.Size = new System.Drawing.Size(526, 352);
            this.dtngaytra.TabIndex = 30;
            this.dtngaytra.TabStop = false;
            this.dtngaytra.Text = "Thông Tin Sách Mượn";
            // 
            // cbomasach
            // 
            this.cbomasach.FormattingEnabled = true;
            this.cbomasach.Location = new System.Drawing.Point(182, 27);
            this.cbomasach.Name = "cbomasach";
            this.cbomasach.Size = new System.Drawing.Size(274, 21);
            this.cbomasach.TabIndex = 6;
            // 
            // txttinhtrang
            // 
            this.txttinhtrang.Location = new System.Drawing.Point(182, 171);
            this.txttinhtrang.Name = "txttinhtrang";
            this.txttinhtrang.Size = new System.Drawing.Size(252, 20);
            this.txttinhtrang.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "NgayTra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số Lượng SM";
            // 
            // txtsoluongsm
            // 
            this.txtsoluongsm.Location = new System.Drawing.Point(182, 243);
            this.txtsoluongsm.Name = "txtsoluongsm";
            this.txtsoluongsm.Size = new System.Drawing.Size(274, 20);
            this.txtsoluongsm.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã PM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tình Trạng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sách";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Colonna MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(483, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(293, 28);
            this.label9.TabIndex = 33;
            this.label9.Text = "DANH MỤC SÁCH MƯỢN";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lblthongbaosm);
            this.groupBox3.Controls.Add(this.btnthoatSM);
            this.groupBox3.Controls.Add(this.btnluusm);
            this.groupBox3.Controls.Add(this.btnsuasm);
            this.groupBox3.Controls.Add(this.btnxoaSM);
            this.groupBox3.Controls.Add(this.btnload);
            this.groupBox3.Controls.Add(this.btnthemnv);
            this.groupBox3.Location = new System.Drawing.Point(12, 413);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(526, 263);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xử Lý";
            // 
            // lblthongbaosm
            // 
            this.lblthongbaosm.AutoSize = true;
            this.lblthongbaosm.Location = new System.Drawing.Point(94, 29);
            this.lblthongbaosm.Name = "lblthongbaosm";
            this.lblthongbaosm.Size = new System.Drawing.Size(0, 13);
            this.lblthongbaosm.TabIndex = 2;
            // 
            // btnthoatSM
            // 
            this.btnthoatSM.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources.Actions_application_exit_icon1;
            this.btnthoatSM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnthoatSM.Location = new System.Drawing.Point(381, 172);
            this.btnthoatSM.Name = "btnthoatSM";
            this.btnthoatSM.Size = new System.Drawing.Size(123, 41);
            this.btnthoatSM.TabIndex = 0;
            this.btnthoatSM.Text = "Thoát";
            this.btnthoatSM.UseVisualStyleBackColor = true;
            this.btnthoatSM.Click += new System.EventHandler(this.btnthoatSM_Click);
            // 
            // btnluusm
            // 
            this.btnluusm.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources.accept_icon__1_2;
            this.btnluusm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnluusm.Location = new System.Drawing.Point(208, 50);
            this.btnluusm.Name = "btnluusm";
            this.btnluusm.Size = new System.Drawing.Size(123, 41);
            this.btnluusm.TabIndex = 0;
            this.btnluusm.Text = "Lưu";
            this.btnluusm.UseVisualStyleBackColor = true;
            this.btnluusm.Click += new System.EventHandler(this.btnluusm_Click);
            // 
            // btnsuasm
            // 
            this.btnsuasm.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources.application_form_edit_icon1;
            this.btnsuasm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsuasm.Location = new System.Drawing.Point(381, 50);
            this.btnsuasm.Name = "btnsuasm";
            this.btnsuasm.Size = new System.Drawing.Size(123, 41);
            this.btnsuasm.TabIndex = 0;
            this.btnsuasm.Text = "Sửa";
            this.btnsuasm.UseVisualStyleBackColor = true;
            this.btnsuasm.Click += new System.EventHandler(this.btnsuasm_Click);
            // 
            // btnxoaSM
            // 
            this.btnxoaSM.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources.delete_icon__1_1;
            this.btnxoaSM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnxoaSM.Location = new System.Drawing.Point(208, 172);
            this.btnxoaSM.Name = "btnxoaSM";
            this.btnxoaSM.Size = new System.Drawing.Size(123, 41);
            this.btnxoaSM.TabIndex = 0;
            this.btnxoaSM.Text = "Xóa";
            this.btnxoaSM.UseVisualStyleBackColor = true;
            this.btnxoaSM.Click += new System.EventHandler(this.btnxoaSM_Click);
            // 
            // btnload
            // 
            this.btnload.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources.p11;
            this.btnload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnload.Location = new System.Drawing.Point(28, 173);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(123, 41);
            this.btnload.TabIndex = 0;
            this.btnload.Text = "Xuất ";
            this.btnload.UseVisualStyleBackColor = true;
            // 
            // btnthemnv
            // 
            this.btnthemnv.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources.application_form_add_icon12;
            this.btnthemnv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnthemnv.Location = new System.Drawing.Point(28, 50);
            this.btnthemnv.Name = "btnthemnv";
            this.btnthemnv.Size = new System.Drawing.Size(123, 41);
            this.btnthemnv.TabIndex = 0;
            this.btnthemnv.Text = "Thêm";
            this.btnthemnv.UseVisualStyleBackColor = true;
            this.btnthemnv.Click += new System.EventHandler(this.btnthemnv_Click);
            // 
            // dgvsachmuon
            // 
            this.dgvsachmuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsachmuon.Location = new System.Drawing.Point(6, 19);
            this.dgvsachmuon.Name = "dgvsachmuon";
            this.dgvsachmuon.Size = new System.Drawing.Size(857, 588);
            this.dgvsachmuon.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvsachmuon);
            this.groupBox2.Location = new System.Drawing.Point(544, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(814, 620);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng Thông Tin Thẻ Thư Viện";
            // 
            // frmSachMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(1370, 688);
            this.Controls.Add(this.dtngaytra);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmSachMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSachMuon";
            this.Load += new System.EventHandler(this.frmSachMuon_Load);
            this.dtngaytra.ResumeLayout(false);
            this.dtngaytra.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsachmuon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dtngayphaitra;
        private System.Windows.Forms.ComboBox cbomapm;
        private System.Windows.Forms.GroupBox dtngaytra;
        private System.Windows.Forms.ComboBox cbomasach;
        private System.Windows.Forms.TextBox txttinhtrang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsoluongsm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblthongbaosm;
        private System.Windows.Forms.Button btnthoatSM;
        private System.Windows.Forms.Button btnluusm;
        private System.Windows.Forms.Button btnsuasm;
        private System.Windows.Forms.Button btnxoaSM;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnthemnv;
        private System.Windows.Forms.DataGridView dgvsachmuon;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}