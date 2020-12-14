
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtngaythutien = new System.Windows.Forms.DateTimePicker();
            this.txtsotien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmaphieuthu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.la = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.btnthoat.Location = new System.Drawing.Point(63, 139);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 48;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnthoat);
            this.groupBox3.Location = new System.Drawing.Point(453, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 215);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Các chức năng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtngaythutien);
            this.groupBox1.Controls.Add(this.txtsotien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtmaphieuthu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtmakh);
            this.groupBox1.Controls.Add(this.la);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 215);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin phiếu thu";
            // 
            // dtngaythutien
            // 
            this.dtngaythutien.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaythutien.Location = new System.Drawing.Point(170, 78);
            this.dtngaythutien.Name = "dtngaythutien";
            this.dtngaythutien.Size = new System.Drawing.Size(162, 20);
            this.dtngaythutien.TabIndex = 4;
            // 
            // txtsotien
            // 
            this.txtsotien.Location = new System.Drawing.Point(170, 104);
            this.txtsotien.Name = "txtsotien";
            this.txtsotien.Size = new System.Drawing.Size(162, 20);
            this.txtsotien.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số tiền thu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày thu tiền:";
            // 
            // txtmaphieuthu
            // 
            this.txtmaphieuthu.Location = new System.Drawing.Point(170, 27);
            this.txtmaphieuthu.Name = "txtmaphieuthu";
            this.txtmaphieuthu.ReadOnly = true;
            this.txtmaphieuthu.Size = new System.Drawing.Size(162, 20);
            this.txtmaphieuthu.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã phiếu thu(auto):";
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(170, 53);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.ReadOnly = true;
            this.txtmakh.Size = new System.Drawing.Size(162, 20);
            this.txtmakh.TabIndex = 3;
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Location = new System.Drawing.Point(49, 54);
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
            this.BackgroundImage = global::CSDL.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(690, 486);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Name = "PhieuThuTien";
            this.Text = "Phiếu Thu tiền";
            this.Load += new System.EventHandler(this.PhieuThuTien_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtngaythutien;
        private System.Windows.Forms.TextBox txtsotien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmaphieuthu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.Label label6;
    }
}