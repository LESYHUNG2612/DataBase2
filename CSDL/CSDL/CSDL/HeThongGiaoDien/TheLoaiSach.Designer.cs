
namespace CSDL.HeThongGiaoDien
{
    partial class TheLoaiSach
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
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtMaTL = new System.Windows.Forms.TextBox();
            this.txtTenTL = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSuaTL = new System.Windows.Forms.Button();
            this.bntXoaTL = new System.Windows.Forms.Button();
            this.btnThemTL = new System.Windows.Forms.Button();
            this.dgvTheLoaiSach = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoaiSach)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.txtMaTL);
            this.groupBox1.Controls.Add(this.txtTenTL);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 68);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Thể Loại Sách";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Location = new System.Drawing.Point(28, 21);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(38, 13);
            this.label28.TabIndex = 11;
            this.label28.Text = "Mã TL";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Location = new System.Drawing.Point(354, 24);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(42, 13);
            this.label27.TabIndex = 10;
            this.label27.Text = "Tên TL";
            // 
            // txtMaTL
            // 
            this.txtMaTL.Location = new System.Drawing.Point(103, 21);
            this.txtMaTL.Name = "txtMaTL";
            this.txtMaTL.Size = new System.Drawing.Size(187, 20);
            this.txtMaTL.TabIndex = 16;
            // 
            // txtTenTL
            // 
            this.txtTenTL.Location = new System.Drawing.Point(435, 21);
            this.txtTenTL.Name = "txtTenTL";
            this.txtTenTL.Size = new System.Drawing.Size(221, 20);
            this.txtTenTL.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSuaTL);
            this.groupBox2.Controls.Add(this.bntXoaTL);
            this.groupBox2.Controls.Add(this.btnThemTL);
            this.groupBox2.Location = new System.Drawing.Point(12, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(706, 100);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnSuaTL
            // 
            this.btnSuaTL.Location = new System.Drawing.Point(290, 31);
            this.btnSuaTL.Name = "btnSuaTL";
            this.btnSuaTL.Size = new System.Drawing.Size(91, 48);
            this.btnSuaTL.TabIndex = 2;
            this.btnSuaTL.Text = "Sữa";
            this.btnSuaTL.UseVisualStyleBackColor = true;
            // 
            // bntXoaTL
            // 
            this.bntXoaTL.Location = new System.Drawing.Point(501, 31);
            this.bntXoaTL.Name = "bntXoaTL";
            this.bntXoaTL.Size = new System.Drawing.Size(91, 48);
            this.bntXoaTL.TabIndex = 1;
            this.bntXoaTL.Text = "Xóa";
            this.bntXoaTL.UseVisualStyleBackColor = true;
            // 
            // btnThemTL
            // 
            this.btnThemTL.Location = new System.Drawing.Point(73, 31);
            this.btnThemTL.Name = "btnThemTL";
            this.btnThemTL.Size = new System.Drawing.Size(91, 48);
            this.btnThemTL.TabIndex = 0;
            this.btnThemTL.Text = "Thêm";
            this.btnThemTL.UseVisualStyleBackColor = true;
            // 
            // dgvTheLoaiSach
            // 
            this.dgvTheLoaiSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheLoaiSach.Location = new System.Drawing.Point(12, 219);
            this.dgvTheLoaiSach.Name = "dgvTheLoaiSach";
            this.dgvTheLoaiSach.Size = new System.Drawing.Size(706, 257);
            this.dgvTheLoaiSach.TabIndex = 23;
            // 
            // TheLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 488);
            this.Controls.Add(this.dgvTheLoaiSach);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TheLoaiSach";
            this.Text = "Thể Loại Sách";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoaiSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtMaTL;
        private System.Windows.Forms.TextBox txtTenTL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSuaTL;
        private System.Windows.Forms.Button bntXoaTL;
        private System.Windows.Forms.Button btnThemTL;
        private System.Windows.Forms.DataGridView dgvTheLoaiSach;
    }
}