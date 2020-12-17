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
    public partial class frmPhieuNhacTra : Form
    {
        string A;
        SqlConnection cnn;
        public frmPhieuNhacTra()
        {
            InitializeComponent();
            cnn = new SqlConnection("Data Source=MyLaptop;Initial Catalog=QuanLyThuVienSachCaNhan;Integrated Security=True");
        }
            //load from
        private void frmPhieuNhacTra_Load(object sender, EventArgs e)
        {
            loaddllenfile();
            txtmapnt.Enabled = false;
            hiendlnv();
            hiendlsach();
            hiendlthethuvien();
            A = label9.Text;
            label9.Text = "";
            timer1.Start();
            hientieudecot();
            data_bingding();
        }
        //tao ma phieu nhac tra
        private string taomapnt()
        {
            string mapnt;
            Random r = new Random();
            mapnt = "NV" + r.Next(50, 999).ToString();
            return mapnt;
        }
        #region bingding
        private void data_bingding()
        {
            txtmapnt.DataBindings.Add("Text", dgvttpnt.DataSource, "MaPNT");
            cbomanv.DataBindings.Add("Selectedvalue", dgvttpnt.DataSource, "MaNV");
            cbomasach.DataBindings.Add("Selectedvalue", dgvttpnt.DataSource, "MaSach");
            cbomathe.DataBindings.Add("Selectedvalue", dgvttpnt.DataSource, "MaThe");
            txtdgp.DataBindings.Add("Text", dgvttpnt.DataSource, "DonGiaPhat");
            txtghichu.DataBindings.Add("Text", dgvttpnt.DataSource, "GhiChu");
        }
        private void huy_bingding()
        {
            if (txtmapnt.DataBindings != null)
                txtmapnt.DataBindings.Clear();
            if (txtghichu.DataBindings != null)
                txtghichu.DataBindings.Clear();
            if (dtngaplap.DataBindings != null)
                dtngaplap.DataBindings.Clear();
            if (txtdgp.DataBindings != null)
                txtdgp.DataBindings.Clear();
            if (cbomasach.DataBindings != null)
                cbomasach.DataBindings.Clear();
            if (cbomanv.DataBindings != null)
                cbomanv.DataBindings.Clear();
            if (cbomathe.DataBindings != null)
                cbomathe.DataBindings.Clear();
        }
        #endregion
        //hien tieu de cot
        private void hientieudecot()
        {
            dgvttpnt.Columns[0].HeaderText = "Mã PNT";
            dgvttpnt.Columns[1].HeaderText = "Mã The";
            dgvttpnt.Columns[2].HeaderText = "Ngày Lập";
            dgvttpnt.Columns[3].HeaderText = "Đơn Giám Phạt";
            dgvttpnt.Columns[4].HeaderText = "Mã NV";
            dgvttpnt.Columns[5].HeaderText = "Mã Sách";
        }
        //load sach tu du lieu
        private DataTable loadsach()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_LOADSACH";
            cmd.Connection = cnn;
            DataTable sach = new DataTable();
            cnn.Open();
            sach.Load(cmd.ExecuteReader());
            cnn.Close();
            return sach;
        }
        //hien thi dach len
        private void hiendlsach()
        {
            cbomasach.DataSource = loadsach();
            cbomasach.ValueMember = "MaSach";
            cbomasach.DisplayMember = "TenSach";
        }
        //load nhan vien len
        private DataTable loadnv()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_LOADNHANVIEN";
            cmd.Connection = cnn;
            DataTable nv = new DataTable();
            cnn.Open();
            nv.Load(cmd.ExecuteReader());
            cnn.Close();
            return nv;
        }
        //hien thi du lieu nhan vien
        private void hiendlnv()
        {
            cbomanv.DataSource = loadnv();
            cbomanv.ValueMember = "MaNV";
            cbomanv.DisplayMember = "TenNV";
        }
        //load du lieu the thu vien
        #region load thẻ thư viện
        private DataTable loadTheThuVien()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_RELOADTHETHUVIEN";
            cmd.Connection = cnn;
            DataTable thethuvien = new DataTable();
            cnn.Open();
            thethuvien.Load(cmd.ExecuteReader());
            cnn.Close();
            return thethuvien;
        }
        private void hiendlthethuvien()
        {
            cbomathe.DataSource = loadTheThuVien();
            cbomathe.ValueMember = "MaThe";
            cbomathe.DisplayMember = "TenSV";
        }
        #endregion
        //doc phieu nhac tra len file
        private DataTable docphieunhactra()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_RELOADPHIEUNHACTRA";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            DataTable phieumuon = new DataTable();
            cnn.Open();
            phieumuon.Load(cmd.ExecuteReader());
            cnn.Close();
            return phieumuon;
        }
        //hien thi phieu nhac tra len
        private void loaddllenfile()
        {
            dgvttpnt.DataSource = docphieunhactra();
        }
        //xu ly su kien them phieu nhac tra
        private void btnthempnt_Click(object sender, EventArgs e)
        {
            txtmapnt.Clear();
            txtghichu.Clear();
            //txttennv.Clear();
            txtdgp.Clear();
            txtmapnt.Text = taomapnt();
        }
        //dinh nghia ham luu phieu nhac tra
        private void luuphieunhactra()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LUUPHIEUNHACTRA";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string mapnt, manv, mathe, masach, ghichu;
            double dongiaphat;
            DateTime ngaylap;
            mapnt = txtmapnt.Text;
            manv = cbomanv.SelectedValue.ToString();
            mathe = cbomathe.SelectedValue.ToString();
            masach = cbomasach.SelectedValue.ToString();
            ghichu = txtghichu.Text;
            ngaylap = DateTime.Parse(dtngaplap.Value.ToString());
            if (txtdgp.Text == "")
            {
                dongiaphat = 0;
            }
            else dongiaphat = double.Parse(txtdgp.Text);
            cmd.Parameters.Add("@MaPNT", mapnt);
            cmd.Parameters.Add("@NgayLap", ngaylap);
            cmd.Parameters.Add("@DonGiaPhat", dongiaphat);
            cmd.Parameters.Add("@MaNV", manv);
            cmd.Parameters.Add("@MaSach", masach);
            cmd.Parameters.Add("@MaThe", mathe);
            cmd.Parameters.Add("@GhiChu", ghichu);
            try
            {
                cmd.Parameters.Add("@kq",
                SqlDbType.Int).Direction =
                    ParameterDirection.ReturnValue;
                cnn.Open();
                cmd.ExecuteNonQuery();
                int kq = (int)cmd.Parameters["@kq"].Value;
                if (kq == 1)
                {
                    lblthongbaopnt.ForeColor = Color.Red;
                    lblthongbaopnt.Text = "Đã tồn tại PNT";
                    return;
                }
                else if (kq == 2)
                {
                    lblthongbaopnt.ForeColor = Color.Red;
                    lblthongbaopnt.Text = "Không tồn tại nhân viên";
                    return;
                }
                else if (kq == 3)
                {
                    lblthongbaopnt.ForeColor = Color.Red;
                    lblthongbaopnt.Text = "Không tồn tại Sinh Viên";
                    return;
                }
                else if (kq == 4)
                {
                    lblthongbaopnt.ForeColor = Color.Red;
                    lblthongbaopnt.Text = "Không tồn tại Sách";
                    return;
                }
                else
                {
                    lblthongbaopnt.ForeColor = Color.Red;
                    lblthongbaopnt.Text = "Lưu Thành công";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi kg them duoc vi" + ex.Message);
            }
            finally
            {
                if (cnn != null)
                    cnn.Close();
            }

        }
        // xu ly su kien luu phieu nhac tra
        private void btnluupnt_Click(object sender, EventArgs e)
        {
            huy_bingding();
            luuphieunhactra();
            loaddllenfile();
            data_bingding();
        }
        //dinh nghia ham xu ly sua phieu nhac tra
        private void suaphieunhactra()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SUAPHIEUNHACTRA";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string mapnt, manv, mathe, masach, ghichu;
            double dongiaphat;
            DateTime ngaylap;
            mapnt = txtmapnt.Text;
            ghichu = txtghichu.Text;
            manv = cbomanv.SelectedValue.ToString();
            mathe = cbomathe.SelectedValue.ToString();
            masach = cbomasach.SelectedValue.ToString();
            ngaylap = DateTime.Parse(dtngaplap.Value.ToString());
            if (txtdgp.Text == "")
            {
                dongiaphat = 0;
            }
            else dongiaphat = double.Parse(txtdgp.Text);
            cmd.Parameters.Add("@MaPNT", mapnt);
            cmd.Parameters.Add("@NgayLap", ngaylap);
            cmd.Parameters.Add("@DonGiaPhat", dongiaphat);
            cmd.Parameters.Add("@MaNV", manv);
            cmd.Parameters.Add("@MaSach", masach);
            cmd.Parameters.Add("@MaThe", mathe);
            cmd.Parameters.Add("@GhiChu", ghichu);
            try
            {
                cmd.Parameters.Add("@kq",
                SqlDbType.Int).Direction =
                    ParameterDirection.ReturnValue;
                cnn.Open();
                cmd.ExecuteNonQuery();
                int kq = (int)cmd.Parameters["@kq"].Value;
                if (kq == 1)
                {
                    lblthongbaopnt.ForeColor = Color.Red;
                    lblthongbaopnt.Text = "Không tồn tại PNT";
                    return;
                }
                else if (kq == 2)
                {
                    lblthongbaopnt.ForeColor = Color.Red;
                    lblthongbaopnt.Text = "Không tồn tại nhân viên";
                    return;
                }
                else if (kq == 3)
                {
                    lblthongbaopnt.ForeColor = Color.Red;
                    lblthongbaopnt.Text = "Không tồn tại Sinh Viên";
                    return;
                }
                else if (kq == 4)
                {
                    lblthongbaopnt.ForeColor = Color.Red;
                    lblthongbaopnt.Text = "Không tồn tại Sách";
                    return;
                }
                else
                {
                    lblthongbaopnt.ForeColor = Color.Red;
                    lblthongbaopnt.Text = "Sửa Thành công";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi kg them duoc vi" + ex.Message);
            }
            finally
            {
                if (cnn != null)
                    cnn.Close();
            }
        }
        //xu ly su kien sua phieu nhac tra
        private void btnsuapnt_Click(object sender, EventArgs e)
        {
            huy_bingding();
            suaphieunhactra();
            loaddllenfile();
            data_bingding();
        }
        //dinh nghia ham xoa phieu nhac tra
        private void xoaphieumuon()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_XOAPHIEUNHACTRA";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string mapnt;
            mapnt = txtmapnt.Text;
            cmd.Parameters.Add("@MaPNT", mapnt);
            DialogResult kq;
            kq = MessageBox.Show("Bạn Thật Sự Muốn Xóa", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            lblthongbaopnt.ForeColor = Color.Red;
            lblthongbaopnt.Text = "Xóa Thành Công";
        }
        //xu ly su kien xoa phieu nhac tra
        private void btnxoapnt_Click(object sender, EventArgs e)
        {
            huy_bingding();
            xoaphieumuon();
            loaddllenfile();
            data_bingding();
        }
        //xu ly su kien thoat
        private void btn_Click(object sender, EventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Bạn Thật Sự Muốn Xóa", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //xu ly hieu ung thoi gia
        private void timer1_Tick(object sender, EventArgs e)
        {
            int d = 0, x;
            x = A.Length;
            d++;
            string a = A.Substring(0, 1);
            A = A.Substring(1, A.Length - 1);
            label9.Text = label9.Text + a;
            if (d == x)
            {
                timer1.Stop();
            }
        }
        //rang buoc khong duoc nhap chuu don gia phat
        private void txtdgp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 45 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 45 && e.KeyChar != 46)
            {
                e.Handled = true;
                lblthongbaopnt.ForeColor = Color.Red;
                lblthongbaopnt.Text = "Không được nhập chữ";
            }
        }
    }
}
