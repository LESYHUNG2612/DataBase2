
namespace CSDL.HeThongGiaoDien
{
    partial class PhieuThuTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuThuTien));
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvphieuthutien = new System.Windows.Forms.DataGridView();
            this.colmaphieuthu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colngaythu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsotien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcmbkh = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtngaythutien = new System.Windows.Forms.DateTimePicker();
            this.txtsotien = new System.Windows.Forms.TextBox();
            this.btnkh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmaphieuthu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.la = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieuthutien)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthoat.BackgroundImage")));
            this.btnthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.White;
            this.btnthoat.Location = new System.Drawing.Point(484, 352);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 48;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvphieuthutien);
            this.groupBox2.Location = new System.Drawing.Point(12, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 175);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phiếu thu tiền";
            // 
            // dgvphieuthutien
            // 
            this.dgvphieuthutien.AllowUserToAddRows = false;
            this.dgvphieuthutien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphieuthutien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmaphieuthu,
            this.colngaythu,
            this.colsotien,
            this.colcmbkh});
            this.dgvphieuthutien.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvphieuthutien.Location = new System.Drawing.Point(7, 17);
            this.dgvphieuthutien.Name = "dgvphieuthutien";
            this.dgvphieuthutien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvphieuthutien.Size = new System.Drawing.Size(532, 150);
            this.dgvphieuthutien.TabIndex = 10;
            // 
            // colmaphieuthu
            // 
            this.colmaphieuthu.DataPropertyName = "MaPhieuThu";
            this.colmaphieuthu.HeaderText = "Mã phiếu thu";
            this.colmaphieuthu.Name = "colmaphieuthu";
            // 
            // colngaythu
            // 
            this.colngaythu.DataPropertyName = "NgayThu";
            this.colngaythu.HeaderText = "Ngày thu";
            this.colngaythu.Name = "colngaythu";
            // 
            // colsotien
            // 
            this.colsotien.DataPropertyName = "SoTienThu";
            this.colsotien.HeaderText = "Số tiền";
            this.colsotien.Name = "colsotien";
            // 
            // colcmbkh
            // 
            this.colcmbkh.DataPropertyName = "MaKhachHang";
            this.colcmbkh.HeaderText = "Khách hàng";
            this.colcmbkh.Name = "colcmbkh";
            this.colcmbkh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colcmbkh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnclear);
            this.groupBox3.Controls.Add(this.btnprint);
            this.groupBox3.Controls.Add(this.btnxoa);
            this.groupBox3.Controls.Add(this.btncapnhat);
            this.groupBox3.Controls.Add(this.btnthem);
            this.groupBox3.Location = new System.Drawing.Point(354, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(205, 121);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Các chức năng";
            // 
            // btnclear
            // 
            this.btnclear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclear.BackgroundImage")));
            this.btnclear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(111, 82);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "Xóa trắng";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btnprint
            // 
            this.btnprint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnprint.BackgroundImage")));
            this.btnprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.White;
            this.btnprint.Location = new System.Drawing.Point(63, 53);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 23);
            this.btnprint.TabIndex = 2;
            this.btnprint.Text = "In Phiếu";
            this.btnprint.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnxoa.BackgroundImage")));
            this.btnxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.Color.White;
            this.btnxoa.Location = new System.Drawing.Point(15, 82);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // btncapnhat
            // 
            this.btncapnhat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncapnhat.BackgroundImage")));
            this.btncapnhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncapnhat.ForeColor = System.Drawing.Color.White;
            this.btncapnhat.Location = new System.Drawing.Point(111, 24);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(75, 23);
            this.btncapnhat.TabIndex = 1;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            // 
            // btnthem
            // 
            this.btnthem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthem.BackgroundImage")));
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.Color.White;
            this.btnthem.Location = new System.Drawing.Point(15, 24);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtngaythutien);
            this.groupBox1.Controls.Add(this.txtsotien);
            this.groupBox1.Controls.Add(this.btnkh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtmaphieuthu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtmakh);
            this.groupBox1.Controls.Add(this.la);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 121);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin phiếu thu";
            // 
            // dtngaythutien
            // 
            this.dtngaythutien.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaythutien.Location = new System.Drawing.Point(130, 68);
            this.dtngaythutien.Name = "dtngaythutien";
            this.dtngaythutien.Size = new System.Drawing.Size(162, 20);
            this.dtngaythutien.TabIndex = 4;
            // 
            // txtsotien
            // 
            this.txtsotien.Location = new System.Drawing.Point(130, 94);
            this.txtsotien.Name = "txtsotien";
            this.txtsotien.Size = new System.Drawing.Size(162, 20);
            this.txtsotien.TabIndex = 3;
            // 
            // btnkh
            // 
            this.btnkh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnkh.BackgroundImage")));
            this.btnkh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkh.ForeColor = System.Drawing.Color.White;
            this.btnkh.Location = new System.Drawing.Point(298, 41);
            this.btnkh.Name = "btnkh";
            this.btnkh.Size = new System.Drawing.Size(22, 23);
            this.btnkh.TabIndex = 0;
            this.btnkh.Text = ">";
            this.btnkh.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số tiền thu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày thu tiền:";
            // 
            // txtmaphieuthu
            // 
            this.txtmaphieuthu.Location = new System.Drawing.Point(130, 17);
            this.txtmaphieuthu.Name = "txtmaphieuthu";
            this.txtmaphieuthu.ReadOnly = true;
            this.txtmaphieuthu.Size = new System.Drawing.Size(162, 20);
            this.txtmaphieuthu.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã phiếu thu(auto):";
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(130, 43);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.ReadOnly = true;
            this.txtmakh.Size = new System.Drawing.Size(162, 20);
            this.txtmakh.TabIndex = 3;
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Location = new System.Drawing.Point(9, 44);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(85, 13);
            this.la.TabIndex = 2;
            this.la.Text = "Mã khách hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(172, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 31);
            this.label6.TabIndex = 44;
            this.label6.Text = "PHIẾU THU TIỀN";
            // 
            // PhieuThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 387);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Name = "PhieuThuTien";
            this.Text = "Phiếu Thu tiền";
            this.Load += new System.EventHandler(this.PhieuThuTien_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieuthutien)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvphieuthutien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmaphieuthu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colngaythu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsotien;
        private System.Windows.Forms.DataGridViewComboBoxColumn colcmbkh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtngaythutien;
        private System.Windows.Forms.TextBox txtsotien;
        private System.Windows.Forms.Button btnkh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmaphieuthu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.Label label6;
    }
}