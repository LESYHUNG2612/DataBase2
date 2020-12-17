using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class frmPicture : Form
    {
        int count = 0;
        //Phương thức tạo lập frmPicture
        public frmPicture()
        {
            InitializeComponent();
        }
        public frmPicture(string fileName)
        {
            InitializeComponent();
        }
        //Sự kiện click cho menu item File --> New
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlg = this.openFileDialog1.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                frmPicture frm = new frmPicture(openFileDialog1.FileName);
                frm.MdiParent = this;
                count++;
                frm.Text = "Picture -" + count + "-" + openFileDialog1.FileName;
                frm.Show();
            }
            this.toolStripStatusLabel1.Text = "Tổng số Form con:" + count.ToString();
        }
        //Sự kiện click cho menu item File --> Save As
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlg = this.saveFileDialog1.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                frmPicture frm = this.ActiveMdiChild as frmPicture;
                try
                {
                    Image img = frm.pbHinh.Image;
                    img.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
                }
                catch
                {
                    MessageBox.Show("Lỗi lưu file");
                }
            }
        }
        //Sự kiện Click cho menu File --> Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Sự kiện Click cho menu View --> StatusBar
        private void statusStripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool check = this.saveAsToolStripMenuItem.Checked;
            if (check)
                this.statusStrip1.Visible = true;
            else
                this.statusStrip1.Visible = false;
        }
        //Sự kiện Click cho menu View --> ToolStrip
        private void toolStripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool check = this.toolStripToolStripMenuItem.Checked;
            if (check)
                this.toolStrip1.Visible = true;
            else
                this.toolStrip1.Visible = false;
        }
        //Sự kiện Click cho menu Layout --> Arrange Icons
        private void arrangeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }
        //Sự kiện Click cho menu Layout --> Cascade
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        //Sự kiện Click cho menu Layout --> Arrange Horizontal
        private void arrangeHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        //Sự kiện Click cho menu Layout --> Arrange Vertical
        private void arrangeVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        //Sự kiện Click cho menu Layout --> Maximize All
        private void maximizeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
                frm.WindowState = FormWindowState.Maximized;
        }
        //Sự kiện Click cho menu Layout --> Minimize All
        private void manimizeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
                frm.WindowState = FormWindowState.Minimized;
        }
    }
}
