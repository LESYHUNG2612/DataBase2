using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CSDL
{
    public partial class DangNhap : Form
    {
        SqlConnection cnn;
        SqlCommand sqlCommand;
        public DangNhap()
        {
            InitializeComponent();
            cnn = new SqlConnection("Data Source=MyLaptop;Initial Catalog=QuanLyNhaSach;Integrated Security=True");
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            dangnhap();
        }
        private void dangnhap()
        {
            lblthongbao.Text = "";
            label1.Text = "";
            string ten, mk;
            ten = txttaikhoan.Text;
            mk = txtmatkhau.Text;
            if (txttaikhoan.Text == "")
            {
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Tên không được trống";
                txttaikhoan.Focus();
                return;
            }
            if (txtmatkhau.Text == "")
            {
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "mk không được trống";
                txtmatkhau.Focus();
                return;
            }
            if (ten != "")
            {
                object Q = layGiaTri("select * from taikhoan where tendn='" + ten + "' and mk='" + mk + "'");
                if (Q == null)
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "sai tai khoan";
                }
                else
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "Thành Công";
                    txttaikhoan.Text = "";
                    txtmatkhau.Text = "";
                    Main main = new Main();
                    main.ShowDialog();
                }
            }
            
        }
        public Object layGiaTri(string sql) //lay gia tri cua  cot dau tien trong bang 
        {
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = sql;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = cnn;
            cnn.Open();
            //CHi can lay ve gia tri cua mot truong thoi thi dung pt nao ? - ExecuteScalar
            Object obj = sqlCommand.ExecuteScalar(); //neu co loi thi phai xem lai cua lenh SQL o ben kia
            cnn.Close();
            return obj;
            //Ket qua de dau ? - de trong obj
        }
        private void DangNhap_Load(object sender, EventArgs e)
        {
            txtmatkhau.PasswordChar = '*';
        }
        #region hienpass
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {   
            if (checkBox1.Checked)
            {
                txttaikhoan.PasswordChar = '\0';
                txtmatkhau.PasswordChar = '\0';
            }
            else
            {
                txttaikhoan.PasswordChar = '\0';
                txtmatkhau.PasswordChar = '*';
            }
        }
        #endregion
    }
}
