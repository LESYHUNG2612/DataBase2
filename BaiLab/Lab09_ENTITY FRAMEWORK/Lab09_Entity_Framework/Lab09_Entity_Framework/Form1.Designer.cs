
namespace Lab09_Entity_Framework
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tvwCategory = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReloadCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.lvwFood = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReloadFood = new System.Windows.Forms.Button();
            this.TaiLaiDanhSachMonAn = new System.Windows.Forms.ToolTip(this.components);
            this.XoaMonAnDuocChon = new System.Windows.Forms.ToolTip(this.components);
            this.ThemMonAnMoi = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // tvwCategory
            // 
            this.tvwCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvwCategory.Location = new System.Drawing.Point(12, 56);
            this.tvwCategory.Name = "tvwCategory";
            this.tvwCategory.Size = new System.Drawing.Size(251, 382);
            this.tvwCategory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh mục";
            // 
            // btnReloadCategory
            // 
            this.btnReloadCategory.Location = new System.Drawing.Point(157, 22);
            this.btnReloadCategory.Name = "btnReloadCategory";
            this.btnReloadCategory.Size = new System.Drawing.Size(46, 23);
            this.btnReloadCategory.TabIndex = 2;
            this.btnReloadCategory.Text = "R";
            this.btnReloadCategory.UseVisualStyleBackColor = true;
            this.btnReloadCategory.Click += new System.EventHandler(this.btnReloadCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(209, 22);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(46, 23);
            this.btnAddCategory.TabIndex = 3;
            this.btnAddCategory.Text = "+";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // lvwFood
            // 
            this.lvwFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwFood.FullRowSelect = true;
            this.lvwFood.GridLines = true;
            this.lvwFood.HideSelection = false;
            this.lvwFood.Location = new System.Drawing.Point(287, 56);
            this.lvwFood.MultiSelect = false;
            this.lvwFood.Name = "lvwFood";
            this.lvwFood.Size = new System.Drawing.Size(501, 382);
            this.lvwFood.TabIndex = 4;
            this.lvwFood.UseCompatibleStateImageBehavior = false;
            this.lvwFood.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thực đơn";
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(715, 27);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(46, 23);
            this.btnAddFood.TabIndex = 6;
            this.btnAddFood.Text = "+";
            this.btnAddFood.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(663, 27);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(46, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "--";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnReloadFood
            // 
            this.btnReloadFood.Location = new System.Drawing.Point(611, 27);
            this.btnReloadFood.Name = "btnReloadFood";
            this.btnReloadFood.Size = new System.Drawing.Size(46, 23);
            this.btnReloadFood.TabIndex = 8;
            this.btnReloadFood.Text = "R";
            this.btnReloadFood.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReloadFood);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvwFood);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.btnReloadCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvwCategory);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà hàng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvwCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReloadCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.ListView lvwFood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReloadFood;
        private System.Windows.Forms.ToolTip TaiLaiDanhSachMonAn;
        private System.Windows.Forms.ToolTip XoaMonAnDuocChon;
        private System.Windows.Forms.ToolTip ThemMonAnMoi;
    }
}

