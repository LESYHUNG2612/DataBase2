using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class frmPicture : Form
    {
        Point p = new Point();

        public frmPicture()
        {
            InitializeComponent();
        }
        //Phương thức tạo lập frmPicture có tham số
        public frmPicture(string name)
        {
            InitializeComponent();
            this.pbHinh.ImageLocation = name;
            this.toolStripStatusLabel1.Text = name;
        }
        // load image
        private void frmPicture_Load(object sender, EventArgs e)
        {
            p = this.pbHinh.Location;
        }
        //reload file cho hinh
        private void reLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlg = this.openFileDialog1.ShowDialog();
            string title = "";
            if (dlg == DialogResult.OK)
            {
                title = openFileDialog1.FileName;
                this.Text = title;
                this.pbHinh.ImageLocation = openFileDialog1.FileName;
            }
            
        }
        //phóng to hình
        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pbHinh.Width += 50;
            this.pbHinh.Height += 50;
        }
        // thu nho hình
        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pbHinh.Width -= 50;
            this.pbHinh.Height -= 50;
        }
        // su kiên scro;; trên thanh cuộn
        private void vScrollBar_Scroll(object sender,ScrollEventArgs e)
        {
            this.pbHinh.Location = new Point(p.X, p.Y - e.NewValue);
        }
        private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            this.pbHinh.Location = new Point(p.X - e.NewValue, p.Y );
        }
        // mo trinh sua hinh
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint", this.pbHinh.ImageLocation);
        }
    }
}
