using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap_Trang60
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Listview_load();
            LoadImage();
        }
        void LoadImage()
        {
            List<string> listimage = new List<string>() { "1.png", "2.png","3.png" };
            cbAddImage.DataSource = listimage;  
        }

        private void Listview_load()
        {
            lvInfo.Columns.Add("");
            lvInfo.Columns.Add("Mã NV");
            lvInfo.Columns.Add("Họ và Tên");
            lvInfo.Columns.Add("Ngày sinh");
            lvInfo.Columns.Add("Phái");
            lvInfo.Columns.Add("Địa chỉ");
            lvInfo.Columns.Add("Email");
            lvInfo.Columns.Add("Số ĐT");
            lvInfo.Columns.Add("Phòng ban");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var manv = this.mtbNV.Text;
            var hoten = this.tbTen.Text;
            var ngaysinh = this.dtpkNgaySinh.Text;
            string gt = "Nam";
            if (rbNu.Checked) gt = "Nữ";
            var diachi = this.tbDiaChi.Text;
            var email = this.tbEmail.Text;
            var sodt = this.mtbSodt.Text;
            var phong = this.cbPhongban.Text;

            ListViewItem item = new ListViewItem();
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = manv });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = hoten });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = ngaysinh });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = gt });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = diachi });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = email });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = sodt });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = phong });

            lvInfo.Items.Add(item);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn thoát không ?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

       private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvInfo.SelectedItems.Count; i++)
            {
                lvInfo.Items.Remove(lvInfo.SelectedItems[i]);
            }
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            this.mtbNV.Text = "";
            this.tbTen.Text = "";
            this.dtpkNgaySinh.Text = "";
            this.tbDiaChi.Text = "";
            this.tbEmail.Text = "";
            this.mtbSodt.Text = "";
            this.cbPhongban.Text = "";
        }

        private void cbAddImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if(cb.SelectedValue != null)
            {
                Bitmap bm = new Bitmap(Application.StartupPath + "\\Resource\\" + cb.SelectedValue.ToString());
                ptbImage.Image = bm;
            }
        }
    }
}
