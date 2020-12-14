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
using CSDL.HeThongGiaoDien;

namespace CSDL
{
    public partial class Main : Form
    {
        SqlConnection cnn;
        string A, B, C, D, E, F, G, H;
        public Main()
        {
            InitializeComponent();
            cnn = new SqlConnection("Data Source=MyLaptop;Initial Catalog=QuanLyNhaSach;Integrated Security=True");
        }
        //xu ly nhap sach
        private void phiếuNhậpSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
             NhapSach nhapSach = new NhapSach();
            nhapSach.ShowDialog();
        }
        //Quan Ly Sach
        private void danhSáchSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            sach.ShowDialog();
        }
        //Tra Sách
        private void TraSachToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TraSach trasach = new TraSach();
            trasach.ShowDialog();
        }
        //Muon Sach
        private void MuonSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuonSach muonsach = new MuonSach();
            muonsach.ShowDialog();
        }
        //The loai Sach
        private void quảnLýThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TheLoaiSach theLoaiSach = new TheLoaiSach();
            theLoaiSach.ShowDialog();
        }

        

        //khách hàng độc giả
        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocGia docgia = new DocGia();
            docgia.ShowDialog();
        }

        //phieu thu tien
        private void lậpPhiếuThuTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuThuTien phieuThuTien = new PhieuThuTien();
            phieuThuTien.ShowDialog();
        }
        //Nhan viên
        private void NhanVientoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien = new NhanVien();
            nhanvien.ShowDialog();
        }
        //tra cuu danh sach sach
        private void danhSáchSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachSach danhSachSach = new DanhSachSach();
            danhSachSach.ShowDialog();
        }
        //Thoat chuong trinh
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Bạn thật sự muốn thoát không?", "Chú Ý!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void phânQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhanQuyen phanquyen = new PhanQuyen();
            phanquyen.ShowDialog();
        }
        //load from
        private void Main_Load(object sender, EventArgs e)
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
            
        }
        //hieu ung chay chu
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

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoiQuy noiquy = new NoiQuy();
            noiquy.ShowDialog();
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
