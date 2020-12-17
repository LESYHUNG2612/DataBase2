namespace ThucHanh
{
    partial class frmThongbao
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
            this.lbThongBao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbThongBao
            // 
            this.lbThongBao.AutoSize = true;
            this.lbThongBao.Location = new System.Drawing.Point(59, 29);
            this.lbThongBao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(35, 13);
            this.lbThongBao.TabIndex = 1;
            this.lbThongBao.Text = "label1";
            // 
            // frmThongbao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 252);
            this.Controls.Add(this.lbThongBao);
            this.Name = "frmThongbao";
            this.Text = "frmThongbao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbThongBao;
    }
}