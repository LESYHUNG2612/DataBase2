
namespace DoAnCoSo_CSDL2
{
    partial class thongtinsach
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
            this.btnin = new System.Windows.Forms.Button();
            this.btnthongtin = new System.Windows.Forms.Button();
            this.chsachkbd = new System.Windows.Forms.CheckBox();
            this.chsachbandc = new System.Windows.Forms.CheckBox();
            this.chsachhu = new System.Windows.Forms.CheckBox();
            this.dgvthongtin = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongtin)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnin);
            this.groupBox1.Controls.Add(this.btnthongtin);
            this.groupBox1.Controls.Add(this.chsachkbd);
            this.groupBox1.Controls.Add(this.chsachbandc);
            this.groupBox1.Controls.Add(this.chsachhu);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(29, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 139);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xử Lý Thông Tin";
            // 
            // btnin
            // 
            this.btnin.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources.p11;
            this.btnin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnin.ForeColor = System.Drawing.Color.Black;
            this.btnin.Location = new System.Drawing.Point(421, 80);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(129, 36);
            this.btnin.TabIndex = 1;
            this.btnin.Text = "In";
            this.btnin.UseVisualStyleBackColor = true;
            // 
            // btnthongtin
            // 
            this.btnthongtin.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources.FAQ_icon;
            this.btnthongtin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnthongtin.ForeColor = System.Drawing.Color.Black;
            this.btnthongtin.Location = new System.Drawing.Point(178, 80);
            this.btnthongtin.Name = "btnthongtin";
            this.btnthongtin.Size = new System.Drawing.Size(129, 36);
            this.btnthongtin.TabIndex = 1;
            this.btnthongtin.Text = "Thông Tin";
            this.btnthongtin.UseVisualStyleBackColor = true;
            this.btnthongtin.Click += new System.EventHandler(this.btnthongtin_Click);
            // 
            // chsachkbd
            // 
            this.chsachkbd.AutoSize = true;
            this.chsachkbd.BackColor = System.Drawing.Color.Transparent;
            this.chsachkbd.ForeColor = System.Drawing.Color.Black;
            this.chsachkbd.Location = new System.Drawing.Point(520, 33);
            this.chsachkbd.Name = "chsachkbd";
            this.chsachkbd.Size = new System.Drawing.Size(155, 17);
            this.chsachkbd.TabIndex = 0;
            this.chsachkbd.Text = "Số sách không được mượn";
            this.chsachkbd.UseVisualStyleBackColor = false;
            // 
            // chsachbandc
            // 
            this.chsachbandc.AutoSize = true;
            this.chsachbandc.BackColor = System.Drawing.Color.Transparent;
            this.chsachbandc.ForeColor = System.Drawing.Color.Black;
            this.chsachbandc.Location = new System.Drawing.Point(263, 33);
            this.chsachbandc.Name = "chsachbandc";
            this.chsachbandc.Size = new System.Drawing.Size(175, 17);
            this.chsachbandc.TabIndex = 0;
            this.chsachbandc.Text = "Số sách được mượn nhiều nhất";
            this.chsachbandc.UseVisualStyleBackColor = false;
            // 
            // chsachhu
            // 
            this.chsachhu.AutoSize = true;
            this.chsachhu.BackColor = System.Drawing.Color.Transparent;
            this.chsachhu.ForeColor = System.Drawing.Color.Black;
            this.chsachhu.Location = new System.Drawing.Point(65, 33);
            this.chsachhu.Name = "chsachhu";
            this.chsachhu.Size = new System.Drawing.Size(124, 17);
            this.chsachhu.TabIndex = 0;
            this.chsachhu.Text = "Số sách hư cần thay";
            this.chsachhu.UseVisualStyleBackColor = false;
            // 
            // dgvthongtin
            // 
            this.dgvthongtin.AllowUserToAddRows = false;
            this.dgvthongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthongtin.Location = new System.Drawing.Point(6, 19);
            this.dgvthongtin.Name = "dgvthongtin";
            this.dgvthongtin.Size = new System.Drawing.Size(752, 286);
            this.dgvthongtin.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Colonna MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(231, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Thống Kê Danh Sách Sách";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvthongtin);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(29, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 311);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // txttong
            // 
            this.txttong.Location = new System.Drawing.Point(100, 185);
            this.txttong.Name = "txttong";
            this.txttong.Size = new System.Drawing.Size(77, 20);
            this.txttong.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hiện có:";
            // 
            // thongtinsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(822, 531);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txttong);
            this.Controls.Add(this.label1);
            this.Name = "thongtinsach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "thongtinsach";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongtin)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.Button btnthongtin;
        private System.Windows.Forms.CheckBox chsachkbd;
        private System.Windows.Forms.CheckBox chsachbandc;
        private System.Windows.Forms.CheckBox chsachhu;
        private System.Windows.Forms.DataGridView dgvthongtin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txttong;
        private System.Windows.Forms.Label label1;
    }
}