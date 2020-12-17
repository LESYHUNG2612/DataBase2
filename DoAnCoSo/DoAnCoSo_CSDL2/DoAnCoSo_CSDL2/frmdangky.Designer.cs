
namespace DoAnCoSo_CSDL2
{
    partial class frmdangky
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
            this.lblthongbao = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btndangky = new System.Windows.Forms.Button();
            this.txtnlmk = new System.Windows.Forms.TextBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txttentk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblthongbao
            // 
            this.lblthongbao.AutoSize = true;
            this.lblthongbao.Location = new System.Drawing.Point(100, 40);
            this.lblthongbao.Name = "lblthongbao";
            this.lblthongbao.Size = new System.Drawing.Size(0, 13);
            this.lblthongbao.TabIndex = 43;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(103, 131);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 17);
            this.checkBox1.TabIndex = 42;
            this.checkBox1.Text = "Show PassWord";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(232, 155);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 24);
            this.btnThoat.TabIndex = 41;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btndangky
            // 
            this.btndangky.Location = new System.Drawing.Point(103, 155);
            this.btndangky.Name = "btndangky";
            this.btndangky.Size = new System.Drawing.Size(75, 24);
            this.btndangky.TabIndex = 36;
            this.btndangky.Text = "Đồng ý";
            this.btndangky.UseVisualStyleBackColor = true;
            this.btndangky.Click += new System.EventHandler(this.btndangky_Click);
            // 
            // txtnlmk
            // 
            this.txtnlmk.Location = new System.Drawing.Point(103, 105);
            this.txtnlmk.Name = "txtnlmk";
            this.txtnlmk.PasswordChar = '*';
            this.txtnlmk.Size = new System.Drawing.Size(260, 20);
            this.txtnlmk.TabIndex = 35;
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(103, 80);
            this.txtmk.Name = "txtmk";
            this.txtmk.PasswordChar = '*';
            this.txtmk.Size = new System.Drawing.Size(260, 20);
            this.txtmk.TabIndex = 34;
            // 
            // txttentk
            // 
            this.txttentk.Location = new System.Drawing.Point(103, 56);
            this.txttentk.Name = "txttentk";
            this.txttentk.Size = new System.Drawing.Size(260, 20);
            this.txttentk.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 14);
            this.label4.TabIndex = 40;
            this.label4.Text = "Xác Nhận Lại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 39;
            this.label3.Text = "Mật Khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 14);
            this.label2.TabIndex = 38;
            this.label2.Text = "Tên Tài Khoản:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tạo Tài Khoản";
            // 
            // frmdangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnCoSo_CSDL2.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(389, 198);
            this.Controls.Add(this.lblthongbao);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btndangky);
            this.Controls.Add(this.txtnlmk);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txttentk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmdangky";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmdangky";
            this.Load += new System.EventHandler(this.frmdangky_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmdangky_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblthongbao;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btndangky;
        private System.Windows.Forms.TextBox txtnlmk;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txttentk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}