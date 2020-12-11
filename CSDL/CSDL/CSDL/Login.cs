using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            NguoiDungDTO nd = new NguoiDungDTO();
            nd.TenNguoiDung = txtTaiKhoan.Text;
            nd.MatKhau = txtMatKhau.Text;
            nd.PhanQuyen = cmbphanquyen.Text;
            bool isLogin = NguoiDungDAO.KiemTraNguoiDung(nd);
            if (isLogin == false)
            {
                this.Hide();
                frmmain f1 = new frmmain();
                f1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai tên người dùng, mật khẩu hoặc quyền đăng nhập!", "Cảnh báo");
                txtTaiKhoan.Text = "";
                txtMatKhau.Text = "";
            }
        }
    }
}
