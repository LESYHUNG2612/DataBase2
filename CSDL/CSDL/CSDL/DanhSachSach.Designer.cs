
namespace CSDL
{
    partial class DanhSachSach
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
            this.dgvDanhMucSach = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chsachkbd = new System.Windows.Forms.CheckBox();
            this.chTimMaTL = new System.Windows.Forms.CheckBox();
            this.chMaSach = new System.Windows.Forms.CheckBox();
            this.txtMaTK = new System.Windows.Forms.TextBox();
            this.btnTimSach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucSach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhMucSach
            // 
            this.dgvDanhMucSach.AllowUserToOrderColumns = true;
            this.dgvDanhMucSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucSach.Location = new System.Drawing.Point(13, 115);
            this.dgvDanhMucSach.Name = "dgvDanhMucSach";
            this.dgvDanhMucSach.Size = new System.Drawing.Size(775, 323);
            this.dgvDanhMucSach.TabIndex = 31;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chsachkbd);
            this.groupBox2.Controls.Add(this.chTimMaTL);
            this.groupBox2.Controls.Add(this.chMaSach);
            this.groupBox2.Controls.Add(this.txtMaTK);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 59);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // chsachkbd
            // 
            this.chsachkbd.AutoSize = true;
            this.chsachkbd.BackColor = System.Drawing.Color.Transparent;
            this.chsachkbd.ForeColor = System.Drawing.Color.Black;
            this.chsachkbd.Location = new System.Drawing.Point(599, 21);
            this.chsachkbd.Name = "chsachkbd";
            this.chsachkbd.Size = new System.Drawing.Size(155, 17);
            this.chsachkbd.TabIndex = 33;
            this.chsachkbd.Text = "Số sách không được mượn";
            this.chsachkbd.UseVisualStyleBackColor = false;
            // 
            // chTimMaTL
            // 
            this.chTimMaTL.AutoSize = true;
            this.chTimMaTL.BackColor = System.Drawing.Color.Transparent;
            this.chTimMaTL.ForeColor = System.Drawing.Color.Black;
            this.chTimMaTL.Location = new System.Drawing.Point(400, 20);
            this.chTimMaTL.Name = "chTimMaTL";
            this.chTimMaTL.Size = new System.Drawing.Size(134, 17);
            this.chTimMaTL.TabIndex = 34;
            this.chTimMaTL.Text = "Tìm Theo Mã Thể Loại";
            this.chTimMaTL.UseVisualStyleBackColor = false;
            // 
            // chMaSach
            // 
            this.chMaSach.AutoSize = true;
            this.chMaSach.BackColor = System.Drawing.Color.Transparent;
            this.chMaSach.ForeColor = System.Drawing.Color.Black;
            this.chMaSach.Location = new System.Drawing.Point(256, 19);
            this.chMaSach.Name = "chMaSach";
            this.chMaSach.Size = new System.Drawing.Size(117, 17);
            this.chMaSach.TabIndex = 35;
            this.chMaSach.Text = "Tìm Theo Mã Sách";
            this.chMaSach.UseVisualStyleBackColor = false;
            // 
            // txtMaTK
            // 
            this.txtMaTK.Location = new System.Drawing.Point(63, 18);
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.Size = new System.Drawing.Size(152, 20);
            this.txtMaTK.TabIndex = 32;
            // 
            // btnTimSach
            // 
            this.btnTimSach.Location = new System.Drawing.Point(330, 77);
            this.btnTimSach.Name = "btnTimSach";
            this.btnTimSach.Size = new System.Drawing.Size(91, 32);
            this.btnTimSach.TabIndex = 29;
            this.btnTimSach.Text = "Tìm Sách";
            this.btnTimSach.UseVisualStyleBackColor = true;
            this.btnTimSach.Click += new System.EventHandler(this.btnTimSach_Click);
            // 
            // DanhSachSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSDL.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDanhMucSach);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnTimSach);
            this.Name = "DanhSachSach";
            this.Text = "DanhSachSach";
            this.Load += new System.EventHandler(this.DanhSachSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucSach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhMucSach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimSach;
        private System.Windows.Forms.TextBox txtMaTK;
        private System.Windows.Forms.CheckBox chsachkbd;
        private System.Windows.Forms.CheckBox chTimMaTL;
        private System.Windows.Forms.CheckBox chMaSach;
    }
}