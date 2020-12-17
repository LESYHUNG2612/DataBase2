
namespace DoAnCoSo_CSDL2
{
    partial class frmtimkiemsach
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
            this.dgvthongtin = new System.Windows.Forms.DataGridView();
            this.PICHINH = new System.Windows.Forms.PictureBox();
            this.txtnxb = new System.Windows.Forms.TextBox();
            this.txttinhtrang = new System.Windows.Forms.TextBox();
            this.txtnamxb = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txtMasach = new System.Windows.Forms.TextBox();
            this.txttg = new System.Windows.Forms.TextBox();
            this.txtTensach = new System.Windows.Forms.TextBox();
            this.txttheloaisach = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btntensach = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltong = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongtin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICHINH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvthongtin);
            this.groupBox2.Location = new System.Drawing.Point(22, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1326, 401);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // dgvthongtin
            // 
            this.dgvthongtin.AllowUserToAddRows = false;
            this.dgvthongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthongtin.Location = new System.Drawing.Point(9, 19);
            this.dgvthongtin.Name = "dgvthongtin";
            this.dgvthongtin.Size = new System.Drawing.Size(1295, 376);
            this.dgvthongtin.TabIndex = 0;
            // 
            // PICHINH
            // 
            this.PICHINH.Location = new System.Drawing.Point(1083, 16);
            this.PICHINH.Name = "PICHINH";
            this.PICHINH.Size = new System.Drawing.Size(186, 173);
            this.PICHINH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICHINH.TabIndex = 2;
            this.PICHINH.TabStop = false;
            this.PICHINH.Click += new System.EventHandler(this.PICHINH_Click);
            // 
            // txtnxb
            // 
            this.txtnxb.Location = new System.Drawing.Point(251, 154);
            this.txtnxb.Name = "txtnxb";
            this.txtnxb.Size = new System.Drawing.Size(127, 20);
            this.txtnxb.TabIndex = 1;
            // 
            // txttinhtrang
            // 
            this.txttinhtrang.Location = new System.Drawing.Point(729, 16);
            this.txttinhtrang.Name = "txttinhtrang";
            this.txttinhtrang.Size = new System.Drawing.Size(203, 20);
            this.txttinhtrang.TabIndex = 1;
            // 
            // txtnamxb
            // 
            this.txtnamxb.Location = new System.Drawing.Point(251, 109);
            this.txtnamxb.Name = "txtnamxb";
            this.txtnamxb.Size = new System.Drawing.Size(127, 20);
            this.txtnamxb.TabIndex = 1;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(251, 62);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(127, 20);
            this.txtsoluong.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Năm NXB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(145, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số Lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(28, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Hiện có:";
            // 
            // btnthoat
            // 
            this.btnthoat.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources.Button_Close_icon;
            this.btnthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnthoat.Location = new System.Drawing.Point(1170, 225);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(134, 45);
            this.btnthoat.TabIndex = 22;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources.Folder_saved_search_icon;
            this.btntimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btntimkiem.Location = new System.Drawing.Point(609, 233);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(146, 28);
            this.btntimkiem.TabIndex = 23;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txtMasach
            // 
            this.txtMasach.Location = new System.Drawing.Point(251, 21);
            this.txtMasach.Name = "txtMasach";
            this.txtMasach.Size = new System.Drawing.Size(127, 20);
            this.txtMasach.TabIndex = 1;
            // 
            // txttg
            // 
            this.txttg.Location = new System.Drawing.Point(729, 154);
            this.txttg.Name = "txttg";
            this.txttg.Size = new System.Drawing.Size(201, 20);
            this.txttg.TabIndex = 1;
            // 
            // txtTensach
            // 
            this.txtTensach.Location = new System.Drawing.Point(729, 113);
            this.txtTensach.Name = "txtTensach";
            this.txtTensach.Size = new System.Drawing.Size(203, 20);
            this.txtTensach.TabIndex = 1;
            // 
            // txttheloaisach
            // 
            this.txttheloaisach.Location = new System.Drawing.Point(729, 62);
            this.txttheloaisach.Name = "txttheloaisach";
            this.txttheloaisach.Size = new System.Drawing.Size(201, 20);
            this.txttheloaisach.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(617, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tình Trạng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "NXB";
            // 
            // btntensach
            // 
            this.btntensach.AutoSize = true;
            this.btntensach.Location = new System.Drawing.Point(615, 113);
            this.btntensach.Name = "btntensach";
            this.btntensach.Size = new System.Drawing.Size(54, 13);
            this.btntensach.TabIndex = 0;
            this.btntensach.Text = "Tên Sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(615, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thể Loại Sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sách";
            // 
            // lbltong
            // 
            this.lbltong.AutoSize = true;
            this.lbltong.BackColor = System.Drawing.Color.Transparent;
            this.lbltong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltong.ForeColor = System.Drawing.Color.Cyan;
            this.lbltong.Location = new System.Drawing.Point(104, 239);
            this.lbltong.Name = "lbltong";
            this.lbltong.Size = new System.Drawing.Size(19, 15);
            this.lbltong.TabIndex = 25;
            this.lbltong.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(617, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "TG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PICHINH);
            this.groupBox1.Controls.Add(this.txtnxb);
            this.groupBox1.Controls.Add(this.txttinhtrang);
            this.groupBox1.Controls.Add(this.txtnamxb);
            this.groupBox1.Controls.Add(this.txtsoluong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMasach);
            this.groupBox1.Controls.Add(this.txttg);
            this.groupBox1.Controls.Add(this.txtTensach);
            this.groupBox1.Controls.Add(this.txttheloaisach);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btntensach);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(22, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1326, 195);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sách";
            // 
            // frmtimkiemsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(1370, 688);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.lbltong);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmtimkiemsach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmtimkiemsach";
            this.Load += new System.EventHandler(this.frmtimkiemsach_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongtin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICHINH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvthongtin;
        private System.Windows.Forms.PictureBox PICHINH;
        private System.Windows.Forms.TextBox txtnxb;
        private System.Windows.Forms.TextBox txttinhtrang;
        private System.Windows.Forms.TextBox txtnamxb;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txtMasach;
        private System.Windows.Forms.TextBox txttg;
        private System.Windows.Forms.TextBox txtTensach;
        private System.Windows.Forms.TextBox txttheloaisach;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label btntensach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}