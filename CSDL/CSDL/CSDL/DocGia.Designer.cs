
namespace CSDL.HeThongGiaoDien
{
    partial class DocGia
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvdg = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblthongbaodg = new System.Windows.Forms.Label();
            this.txtEmailDG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.cboGioitinhDG = new System.Windows.Forms.ComboBox();
            this.txtDiachiDG = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtDienthoaiDG = new System.Windows.Forms.TextBox();
            this.dtpNgaysinhDG = new System.Windows.Forms.DateTimePicker();
            this.txtTenDG = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLuuĐG = new System.Windows.Forms.Button();
            this.btnSuaĐG = new System.Windows.Forms.Button();
            this.bntXoaĐG = new System.Windows.Forms.Button();
            this.btnThemĐG = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::CSDL.Properties.Resources._1;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvdg, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(797, 488);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvdg
            // 
            this.dgvdg.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvdg.AllowUserToOrderColumns = true;
            this.dgvdg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdg.GridColor = System.Drawing.SystemColors.Control;
            this.dgvdg.Location = new System.Drawing.Point(3, 218);
            this.dgvdg.Name = "dgvdg";
            this.dgvdg.Size = new System.Drawing.Size(791, 267);
            this.dgvdg.TabIndex = 33;
            this.dgvdg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdg_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.lblthongbaodg);
            this.groupBox1.Controls.Add(this.txtEmailDG);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.cboGioitinhDG);
            this.groupBox1.Controls.Add(this.txtDiachiDG);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.txtMaDG);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txtDienthoaiDG);
            this.groupBox1.Controls.Add(this.dtpNgaysinhDG);
            this.groupBox1.Controls.Add(this.txtTenDG);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 129);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin độc giả";
            // 
            // lblthongbaodg
            // 
            this.lblthongbaodg.AutoSize = true;
            this.lblthongbaodg.Location = new System.Drawing.Point(203, 7);
            this.lblthongbaodg.Name = "lblthongbaodg";
            this.lblthongbaodg.Size = new System.Drawing.Size(0, 13);
            this.lblthongbaodg.TabIndex = 34;
            // 
            // txtEmailDG
            // 
            this.txtEmailDG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmailDG.Location = new System.Drawing.Point(343, 89);
            this.txtEmailDG.Name = "txtEmailDG";
            this.txtEmailDG.Size = new System.Drawing.Size(148, 20);
            this.txtEmailDG.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(255, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Email ĐG";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Location = new System.Drawing.Point(38, 23);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(41, 13);
            this.label28.TabIndex = 25;
            this.label28.Text = "Mã ĐG";
            // 
            // cboGioitinhDG
            // 
            this.cboGioitinhDG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboGioitinhDG.FormattingEnabled = true;
            this.cboGioitinhDG.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioitinhDG.Location = new System.Drawing.Point(95, 90);
            this.cboGioitinhDG.Name = "cboGioitinhDG";
            this.cboGioitinhDG.Size = new System.Drawing.Size(124, 21);
            this.cboGioitinhDG.TabIndex = 31;
            // 
            // txtDiachiDG
            // 
            this.txtDiachiDG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDiachiDG.Location = new System.Drawing.Point(602, 20);
            this.txtDiachiDG.Multiline = true;
            this.txtDiachiDG.Name = "txtDiachiDG";
            this.txtDiachiDG.Size = new System.Drawing.Size(139, 91);
            this.txtDiachiDG.TabIndex = 27;
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Location = new System.Drawing.Point(32, 63);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(45, 13);
            this.label27.TabIndex = 24;
            this.label27.Text = "Tên ĐG";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(524, 23);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 13);
            this.label25.TabIndex = 23;
            this.label25.Text = "Địa Chỉ  ĐG";
            // 
            // txtMaDG
            // 
            this.txtMaDG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaDG.Location = new System.Drawing.Point(95, 23);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(94, 20);
            this.txtMaDG.TabIndex = 29;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(34, 96);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 13);
            this.label21.TabIndex = 20;
            this.label21.Text = "Giới Tính";
            // 
            // txtDienthoaiDG
            // 
            this.txtDienthoaiDG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDienthoaiDG.Location = new System.Drawing.Point(343, 53);
            this.txtDienthoaiDG.Name = "txtDienthoaiDG";
            this.txtDienthoaiDG.Size = new System.Drawing.Size(148, 20);
            this.txtDienthoaiDG.TabIndex = 26;
            // 
            // dtpNgaysinhDG
            // 
            this.dtpNgaysinhDG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgaysinhDG.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaysinhDG.Location = new System.Drawing.Point(343, 20);
            this.dtpNgaysinhDG.Name = "dtpNgaysinhDG";
            this.dtpNgaysinhDG.Size = new System.Drawing.Size(148, 20);
            this.dtpNgaysinhDG.TabIndex = 30;
            // 
            // txtTenDG
            // 
            this.txtTenDG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenDG.Location = new System.Drawing.Point(95, 60);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.Size = new System.Drawing.Size(124, 20);
            this.txtTenDG.TabIndex = 28;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(250, 23);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(56, 13);
            this.label24.TabIndex = 22;
            this.label24.Text = "Ngày Sinh";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(250, 60);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(81, 13);
            this.label23.TabIndex = 21;
            this.label23.Text = "Điện Thoại  ĐG";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.btnLuuĐG);
            this.groupBox2.Controls.Add(this.btnSuaĐG);
            this.groupBox2.Controls.Add(this.bntXoaĐG);
            this.groupBox2.Controls.Add(this.btnThemĐG);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(791, 74);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnLuuĐG
            // 
            this.btnLuuĐG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuuĐG.Location = new System.Drawing.Point(254, 19);
            this.btnLuuĐG.Name = "btnLuuĐG";
            this.btnLuuĐG.Size = new System.Drawing.Size(91, 32);
            this.btnLuuĐG.TabIndex = 3;
            this.btnLuuĐG.Text = "Lưu";
            this.btnLuuĐG.UseVisualStyleBackColor = true;
            // 
            // btnSuaĐG
            // 
            this.btnSuaĐG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSuaĐG.Location = new System.Drawing.Point(432, 19);
            this.btnSuaĐG.Name = "btnSuaĐG";
            this.btnSuaĐG.Size = new System.Drawing.Size(91, 32);
            this.btnSuaĐG.TabIndex = 2;
            this.btnSuaĐG.Text = "Sữa";
            this.btnSuaĐG.UseVisualStyleBackColor = true;
            // 
            // bntXoaĐG
            // 
            this.bntXoaĐG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bntXoaĐG.Location = new System.Drawing.Point(603, 19);
            this.bntXoaĐG.Name = "bntXoaĐG";
            this.bntXoaĐG.Size = new System.Drawing.Size(91, 32);
            this.bntXoaĐG.TabIndex = 1;
            this.bntXoaĐG.Text = "Xóa";
            this.bntXoaĐG.UseVisualStyleBackColor = true;
            // 
            // btnThemĐG
            // 
            this.btnThemĐG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemĐG.Location = new System.Drawing.Point(78, 19);
            this.btnThemĐG.Name = "btnThemĐG";
            this.btnThemĐG.Size = new System.Drawing.Size(91, 32);
            this.btnThemĐG.TabIndex = 0;
            this.btnThemĐG.Text = "Thêm";
            this.btnThemĐG.UseVisualStyleBackColor = true;
            // 
            // DocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSDL.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(797, 488);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin độc giả";
            this.Load += new System.EventHandler(this.DocGia_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvdg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblthongbaodg;
        private System.Windows.Forms.TextBox txtEmailDG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox cboGioitinhDG;
        private System.Windows.Forms.TextBox txtDiachiDG;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtDienthoaiDG;
        private System.Windows.Forms.DateTimePicker dtpNgaysinhDG;
        private System.Windows.Forms.TextBox txtTenDG;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLuuĐG;
        private System.Windows.Forms.Button btnSuaĐG;
        private System.Windows.Forms.Button bntXoaĐG;
        private System.Windows.Forms.Button btnThemĐG;
    }
}