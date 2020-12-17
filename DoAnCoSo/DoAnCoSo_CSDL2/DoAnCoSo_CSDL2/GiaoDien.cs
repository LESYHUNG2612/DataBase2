using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoAnCoSo_CSDL2
{
    public partial class Giaodien : Form
    {
        SqlDataAdapter dat;
        DataTable dt;
        string A, B, C, D, E,F,G,H;
        SqlConnection cnn;
        SqlCommand sqlCommand;
        public Giaodien()
        {
            InitializeComponent();
            cnn = new SqlConnection("Data Source=MyLaptop;Initial Catalog=QuanLyThuVienSachCaNhan;Integrated Security=True");
        }

        // xu ly nut su kien
        //su kien dang ky
        private void mnudk_Click(object sender, EventArgs e)
        {
            frmdangky f = new frmdangky();
            f.ShowDialog();
        }
        //su kien danh muc quan ly sinh vien
        private void mnudmqlsv_Click(object sender, EventArgs e)
        {
            frmthethuvien f = new frmthethuvien();
            f.ShowDialog();
        }
        //danh muc quan ly sach du lieu sach
        private void mnudlsach_Click(object sender, EventArgs e)
        {
            frmSach f = new frmSach();
            f.ShowDialog();
        }
        //danh muc bao cao
        private void mnubaocao_Click(object sender, EventArgs e)
        {
            thongtinsach f = new thongtinsach();
            f.ShowDialog();
        }
        //xu ly danh muc xuly
        private void mnuxuly_Click(object sender, EventArgs e)
        {
            muontrasach f = new muontrasach();
            f.ShowDialog();
        }

        //xu ly su kien nut dang xuat
        private void mnudx_Click(object sender, EventArgs e)
        {
            mnudanhmuc.Enabled = false;
            mnuxuly.Enabled = false;
            mnubaocao.Enabled = false;
        }
       
        //danh muc quan ly sach du lieu sach muon
        private void mnudlsachmuon_Click(object sender, EventArgs e)
        {
            frmSachMuon f = new frmSachMuon();
            f.ShowDialog();
        }

        //danh muc quan ly du lieu phieu muon
        private void mnudlphieumuon_Click(object sender, EventArgs e)
        {
            frmPhieuMuon f = new frmPhieuMuon();
            f.ShowDialog();
        }  
        //danh muc quan ly du lieu phieu nhac tra
        private void mnudlphieunhactra_Click(object sender, EventArgs e)
        {
            frmPhieuNhacTra f = new frmPhieuNhacTra();
            f.ShowDialog();
        }
        //xu ly su kien dang nhap
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            dangnhap();
        }

        //su kien nut tro giup
        private void mnutrogiup_Click(object sender, EventArgs e)
        {
           frmnoiquy f = new frmnoiquy();
            f.ShowDialog();
        }
        //dịnh nghia cac ham xu ly
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
        //load dao giao dien
        private void Giaodien_Load(object sender, EventArgs e)
        {
            txtmatkhau.PasswordChar = '*';
            A = text.Text;
            B = text1.Text;
            C = lbl1.Text;
            D = text2.Text;
            E = lbl2.Text;
            F = lbl3.Text;
            G = lbl4.Text;
            H = lbl5.Text;
           

            text.Text = "";
            text1.Text = "";
            text2.Text = "";
            lbl1.Text = "";
            lbl2.Text = "";
            lbl3.Text = "";
            lbl4.Text = "";
            lbl5.Text = "";
            timer1.Start();
            mnudanhmuc.Enabled = false;
            mnuxuly.Enabled = false;
            mnubaocao.Enabled = false;
        }
       
        //xu ly nhan vien
        private void mnudmqlnv_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            f.ShowDialog();
        }

        //dinh nghia ham xu ly dang nhap
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
                    mnudanhmuc.Enabled = true;
                    mnuxuly.Enabled = true;
                    mnubaocao.Enabled = true;
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
        //thoi gian
        private void timer1_Tick(object sender, EventArgs e)
        {
            int d = 0, x;
            x = A.Length;
            d++;
            string a = A.Substring(0, 1);
            A = A.Substring(1, A.Length - 1);
            text.Text = text.Text + a;
            if (d == x)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void mnutimkiem_Click(object sender, EventArgs e)
        {
            frmtimkiemsach f = new frmtimkiemsach();
            f.ShowDialog();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int d = 0, x;
            x = B.Length;
            d++;
            string a = B.Substring(0, 1);
            B = B.Substring(1, B.Length - 1);
            text1.Text = text1.Text + a;
            if (d == x)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int d = 0, x;
            x = C.Length;
            d++;
            string a = C.Substring(0, 1);
            C = C.Substring(1, C.Length - 1);
            lbl1.Text = lbl1.Text + a;
            if (d == x)
            {
                timer3.Stop();
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int d = 0, x;
            x = D.Length;
            d++;
            string a = D.Substring(0, 1);
            D = D.Substring(1, D.Length - 1);
            text2.Text = text2.Text + a;
            if (d == x)
            {
                timer4.Stop();
                timer5.Start();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            int d = 0, x;
            x = E.Length;
            d++;
            string a = E.Substring(0, 1);
            E = E.Substring(1, E.Length - 1);
            lbl2.Text = lbl2.Text + a;
            if (d == x)
            {
                timer5.Stop();
                timer6.Start();
            }
        }
        private void timer6_Tick(object sender, EventArgs e)
        {
            int d = 0, x;
            x = F.Length;
            d++;
            string a = F.Substring(0, 1);
            F = F.Substring(1, F.Length - 1);
            lbl3.Text = lbl3.Text + a;
            if (d == x)
            {
                timer6.Stop();
                timer7.Start();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            int d = 0, x;
            x = G.Length;
            d++;
            string a = G.Substring(0, 1);
            G = G.Substring(1, G.Length - 1);
            lbl4.Text = lbl4.Text + a;
            if (d == x)
            {
                timer7.Stop();
                timer8.Start();
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            int d = 0, x;
            x = H.Length;
            d++;
            string a = H.Substring(0, 1);
            H = H.Substring(1, H.Length - 1);
            lbl5.Text = lbl5.Text + a;
            if (d == x)
            {
                timer8.Stop();
            }

        }



    }
}
