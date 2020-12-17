using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void bntCancel_Click(object sender, EventArgs e)
        {
            this.Reset();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Reset()
        {
            this.cboMaHV.Text = "";
            this.txtHoTen.Text = "";
            this.dtpNgayDangKy.Value = DateTime.Now;
            this.chkTiengAnhA.Checked = false;
            this.chkTiengAnhA.Checked = false;
            this.chkTinHocA.Checked = false;
            this.chkTinHocB.Checked = false;
            this.txtTongTien.Text = "";
        }
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (chkTinHocA.Checked)
                s += int.Parse(IblTHA.Text.Split('.')[0]);
            if (chkTinHocB.Checked)
                s += int.Parse(IblTHB.Text.Split('.')[0]);
            if (chkTiengAnhA.Checked)
                s += int.Parse(IblTAA.Text.Split('.')[0]);
            if (chkTiengAnhB.Checked)
                s += int.Parse(IblTAB.Text.Split('.')[0]);
            this.txtTongTien.Text = s + ".000 đồng";
        }
    }
}
