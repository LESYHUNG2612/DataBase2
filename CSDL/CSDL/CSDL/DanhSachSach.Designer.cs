
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimTheoTenSach = new System.Windows.Forms.RadioButton();
            this.btnTimMaTL = new System.Windows.Forms.RadioButton();
            this.btnTimMaSach = new System.Windows.Forms.RadioButton();
            this.btnTimSach = new System.Windows.Forms.Button();
            this.dgvDanhMucSach = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucSach)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimTheoTenSach);
            this.groupBox2.Controls.Add(this.btnTimMaTL);
            this.groupBox2.Controls.Add(this.btnTimMaSach);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 59);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnTimTheoTenSach
            // 
            this.btnTimTheoTenSach.AutoSize = true;
            this.btnTimTheoTenSach.Location = new System.Drawing.Point(524, 21);
            this.btnTimTheoTenSach.Name = "btnTimTheoTenSach";
            this.btnTimTheoTenSach.Size = new System.Drawing.Size(120, 17);
            this.btnTimTheoTenSach.TabIndex = 2;
            this.btnTimTheoTenSach.TabStop = true;
            this.btnTimTheoTenSach.Text = "Tìm Theo Tên Sách";
            this.btnTimTheoTenSach.UseVisualStyleBackColor = true;
            // 
            // btnTimMaTL
            // 
            this.btnTimMaTL.AutoSize = true;
            this.btnTimMaTL.Location = new System.Drawing.Point(346, 21);
            this.btnTimMaTL.Name = "btnTimMaTL";
            this.btnTimMaTL.Size = new System.Drawing.Size(104, 17);
            this.btnTimMaTL.TabIndex = 1;
            this.btnTimMaTL.TabStop = true;
            this.btnTimMaTL.Text = "Tìm Theo Mã TL";
            this.btnTimMaTL.UseVisualStyleBackColor = true;
            // 
            // btnTimMaSach
            // 
            this.btnTimMaSach.AutoSize = true;
            this.btnTimMaSach.Location = new System.Drawing.Point(145, 19);
            this.btnTimMaSach.Name = "btnTimMaSach";
            this.btnTimMaSach.Size = new System.Drawing.Size(116, 17);
            this.btnTimMaSach.TabIndex = 0;
            this.btnTimMaSach.TabStop = true;
            this.btnTimMaSach.Text = "Tìm Theo Mã Sách";
            this.btnTimMaSach.UseVisualStyleBackColor = true;
            // 
            // btnTimSach
            // 
            this.btnTimSach.Location = new System.Drawing.Point(330, 77);
            this.btnTimSach.Name = "btnTimSach";
            this.btnTimSach.Size = new System.Drawing.Size(91, 32);
            this.btnTimSach.TabIndex = 0;
            this.btnTimSach.Text = "Tìm Sách";
            this.btnTimSach.UseVisualStyleBackColor = true;
            // 
            // dgvDanhMucSach
            // 
            this.dgvDanhMucSach.AllowUserToOrderColumns = true;
            this.dgvDanhMucSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucSach.Location = new System.Drawing.Point(13, 115);
            this.dgvDanhMucSach.Name = "dgvDanhMucSach";
            this.dgvDanhMucSach.Size = new System.Drawing.Size(775, 323);
            this.dgvDanhMucSach.TabIndex = 28;
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimSach;
        private System.Windows.Forms.RadioButton btnTimTheoTenSach;
        private System.Windows.Forms.RadioButton btnTimMaTL;
        private System.Windows.Forms.RadioButton btnTimMaSach;
        private System.Windows.Forms.DataGridView dgvDanhMucSach;
    }
}