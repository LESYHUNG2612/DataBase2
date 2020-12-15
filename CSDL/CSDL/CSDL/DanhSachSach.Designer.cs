
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
            this.rbtnTimTheoTenSach = new System.Windows.Forms.RadioButton();
            this.rbtnTimTheoMaTL = new System.Windows.Forms.RadioButton();
            this.rbTimTheoMa = new System.Windows.Forms.RadioButton();
            this.txtMaTK = new System.Windows.Forms.TextBox();
            this.btnTimSach = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucSach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhMucSach
            // 
            this.dgvDanhMucSach.AllowUserToOrderColumns = true;
            this.dgvDanhMucSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMucSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvDanhMucSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhMucSach.Location = new System.Drawing.Point(3, 163);
            this.dgvDanhMucSach.MultiSelect = false;
            this.dgvDanhMucSach.Name = "dgvDanhMucSach";
            this.dgvDanhMucSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhMucSach.ShowCellToolTips = false;
            this.dgvDanhMucSach.Size = new System.Drawing.Size(794, 284);
            this.dgvDanhMucSach.TabIndex = 31;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.rbtnTimTheoTenSach);
            this.groupBox2.Controls.Add(this.rbtnTimTheoMaTL);
            this.groupBox2.Controls.Add(this.rbTimTheoMa);
            this.groupBox2.Controls.Add(this.txtMaTK);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(794, 74);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // rbtnTimTheoTenSach
            // 
            this.rbtnTimTheoTenSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtnTimTheoTenSach.AutoSize = true;
            this.rbtnTimTheoTenSach.Location = new System.Drawing.Point(612, 21);
            this.rbtnTimTheoTenSach.Name = "rbtnTimTheoTenSach";
            this.rbtnTimTheoTenSach.Size = new System.Drawing.Size(120, 17);
            this.rbtnTimTheoTenSach.TabIndex = 38;
            this.rbtnTimTheoTenSach.Text = "Tìm Theo Tên Sách";
            this.rbtnTimTheoTenSach.UseVisualStyleBackColor = true;
            // 
            // rbtnTimTheoMaTL
            // 
            this.rbtnTimTheoMaTL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtnTimTheoMaTL.AutoSize = true;
            this.rbtnTimTheoMaTL.Location = new System.Drawing.Point(451, 21);
            this.rbtnTimTheoMaTL.Name = "rbtnTimTheoMaTL";
            this.rbtnTimTheoMaTL.Size = new System.Drawing.Size(133, 17);
            this.rbtnTimTheoMaTL.TabIndex = 37;
            this.rbtnTimTheoMaTL.Text = "Tìm Theo Mã Thể Loại";
            this.rbtnTimTheoMaTL.UseVisualStyleBackColor = true;
            // 
            // rbTimTheoMa
            // 
            this.rbTimTheoMa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbTimTheoMa.AutoSize = true;
            this.rbTimTheoMa.Checked = true;
            this.rbTimTheoMa.Location = new System.Drawing.Point(281, 20);
            this.rbTimTheoMa.Name = "rbTimTheoMa";
            this.rbTimTheoMa.Size = new System.Drawing.Size(88, 17);
            this.rbTimTheoMa.TabIndex = 36;
            this.rbTimTheoMa.TabStop = true;
            this.rbTimTheoMa.Text = "Tìm Theo Mã";
            this.rbTimTheoMa.UseVisualStyleBackColor = true;
            // 
            // txtMaTK
            // 
            this.txtMaTK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaTK.Location = new System.Drawing.Point(63, 18);
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.Size = new System.Drawing.Size(152, 20);
            this.txtMaTK.TabIndex = 32;
            // 
            // btnTimSach
            // 
            this.btnTimSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimSach.Location = new System.Drawing.Point(255, 22);
            this.btnTimSach.Name = "btnTimSach";
            this.btnTimSach.Size = new System.Drawing.Size(91, 32);
            this.btnTimSach.TabIndex = 29;
            this.btnTimSach.Text = "Tìm Sách";
            this.btnTimSach.UseVisualStyleBackColor = true;
            this.btnTimSach.Click += new System.EventHandler(this.btnTimSach_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvDanhMucSach, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.btnTimSach);
            this.panel1.Location = new System.Drawing.Point(3, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 74);
            this.panel1.TabIndex = 32;
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLoad.Location = new System.Drawing.Point(482, 22);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(91, 32);
            this.btnLoad.TabIndex = 30;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // DanhSachSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSDL.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DanhSachSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhSachSach";
            this.Load += new System.EventHandler(this.DanhSachSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucSach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhMucSach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimSach;
        private System.Windows.Forms.TextBox txtMaTK;
        private System.Windows.Forms.RadioButton rbtnTimTheoTenSach;
        private System.Windows.Forms.RadioButton rbtnTimTheoMaTL;
        private System.Windows.Forms.RadioButton rbTimTheoMa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoad;
    }
}