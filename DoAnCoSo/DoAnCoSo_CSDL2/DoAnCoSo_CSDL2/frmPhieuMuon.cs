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

namespace DoAnCoSo_CSDL2
{
    public partial class frmPhieuMuon : Form
    {
        string A;
        DataTable dtpm;
        int vt;
        SqlConnection cnn;
        public frmPhieuMuon()
        {
            InitializeComponent();
            cnn = new SqlConnection("Data Source=MyLaptop;Initial Catalog=QuanLyThuVienSachCaNhan;Integrated Security=True");
        }
        //load from
        private void frmPhieuMuon_Load(object sender, EventArgs e)
        {
            txtMapm.Enabled = false;
            loaddlphieumuon();
            hienthitieudecot();
            loaddlsach();
            loaddlthethuvien();
            A = label9.Text;
            label9.Text = "";
            timer1.Start();
            data_bingding();
            hienphieumuondautien();
        }
        //tao ma phieu muon
        private string taomapm()
        {
            string mapm;
            Random r = new Random();
            mapm = "NV" + r.Next(50, 999).ToString();
            return mapm;
        }
        #region bingding
        private void data_bingding()
        {
            txtMapm.DataBindings.Add("Text", dgvttpm.DataSource, "MaPM");
            cbomasach.DataBindings.Add("Selectedvalue", dgvttpm.DataSource, "MaSach");
            cbomathe.DataBindings.Add("Selectedvalue", dgvttpm.DataSource, "MaThe");
        }
        private void huy_bingding()
        {
            if (txtMapm.DataBindings != null)
                txtMapm.DataBindings.Clear();
            if (cbomasach.DataBindings != null)
                cbomasach.DataBindings.Clear();
            if (cbomathe.DataBindings != null)
                cbomathe.DataBindings.Clear();
            if (dtpNgaymuon.DataBindings != null)
                dtpNgaymuon.DataBindings.Clear();
        }
        #endregion
        //hien tieu de cot
        private void hienthitieudecot()
        {
            dgvttpm.Columns[0].HeaderText = "Mã PM";
            dgvttpm.Columns[1].HeaderText = "Mã Sách";
            dgvttpm.Columns[2].HeaderText = "Mã Thẻ";
            dgvttpm.Columns[3].HeaderText = "Ngày Mượn";
        }
        //load sách
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
        //load du lieu sach
        private void loaddlsach()
        {
            cbomasach.DataSource = loadsach();
            cbomasach.ValueMember = "MaSach";
            cbomasach.DisplayMember = "TenSach";
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
        private void loaddlthethuvien()
        {
            cbomathe.DataSource = loadTheThuVien();
            cbomathe.ValueMember = "MaThe";
            cbomathe.DisplayMember = "TenSV";
        }
        #endregion
        //doc du lieu phieu muon
        private DataTable docphieumuon()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LOADPHIEUMUON";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            DataTable phieumuon = new DataTable();
            cnn.Open();
            phieumuon.Load(cmd.ExecuteReader());
            cnn.Close();
            return phieumuon;
        }
        //load du lieu phieu muon
        private void loaddlphieumuon()
        {
            dgvttpm.DataSource = docphieumuon();
        }
        //dinh nghia ham luu phieu muon
        private void luuphieumuon()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LUUPHIEUMUON";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string mapm, mathe, masach;
            DateTime ngaymuon;
            mapm = txtMapm.Text;
            masach = cbomasach.SelectedValue.ToString();
            mathe = cbomathe.SelectedValue.ToString();
            ngaymuon = DateTime.Parse(dtpNgaymuon.Value.ToString());
            cmd.Parameters.AddWithValue("@MaPM", mapm);
            cmd.Parameters.AddWithValue("@MaSach", masach);
            cmd.Parameters.AddWithValue("@MaThe", mathe);
            cmd.Parameters.AddWithValue("@NgayMuon", ngaymuon);
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
                    lblthongbaopm.ForeColor = Color.Red;
                    lblthongbaopm.Text = "Đã tồn tại phiếu mượn";
                    return;
                }
                else if (kq == 1)
                {
                    lblthongbaopm.ForeColor = Color.Red;
                    lblthongbaopm.Text = "Không tồn tại sách ";
                    return;
                }
                else if (kq == 1)
                {
                    lblthongbaopm.ForeColor = Color.Red;
                    lblthongbaopm.Text = "Không tồn tại Sinh Viên";
                    return;
                }
                else
                {
                    lblthongbaopm.ForeColor = Color.Red;
                    lblthongbaopm.Text = "Luu Thành Công";
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
        //xu ly su kien
        private void btnluu_Click(object sender, EventArgs e)
        {
            huy_bingding();
            luuphieumuon();
            loaddlphieumuon();
            data_bingding();
        }
        //xu ly su kien them phieu muon
        private void btnthempm_Click(object sender, EventArgs e)
        {
            txtMapm.Clear();
            txtMapm.Text = taomapm();
        }
        //dinh nghia ham sua phieu muon
        private void suaphieumuon()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SUAPHIEUMUON";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string mapm, mathe, masach;
            DateTime ngaymuon;
            mapm = txtMapm.Text;
            masach = cbomasach.SelectedValue.ToString();
            mathe = cbomathe.SelectedValue.ToString();
            ngaymuon = DateTime.Parse(dtpNgaymuon.Value.ToString());
            cmd.Parameters.Add("@MaPM", mapm);
            cmd.Parameters.Add("@MaSach", masach);
            cmd.Parameters.Add("@MaThe", mathe);
            cmd.Parameters.Add("@NgayMuon", ngaymuon);
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
                    lblthongbaopm.ForeColor = Color.Red;
                    lblthongbaopm.Text = "không tồn tại phiếu mượn";
                    return;
                }
                else if (kq == 1)
                {
                    lblthongbaopm.ForeColor = Color.Red;
                    lblthongbaopm.Text = "Không tồn tại sách ";
                    return;
                }
                else if (kq == 1)
                {
                    lblthongbaopm.ForeColor = Color.Red;
                    lblthongbaopm.Text = "Không tồn tại Sinh Viên";
                    return;
                }
                else
                {
                    lblthongbaopm.ForeColor = Color.Red;
                    lblthongbaopm.Text = "Sửa Thành Công";
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
        //su kiem sua phieu muon
        private void btnsua_Click(object sender, EventArgs e)
        {
            huy_bingding();
            suaphieumuon();
            loaddlphieumuon();
            data_bingding();
        }
        //dinh nghia ham xoa phieu muon
        private void xoaphieumuon()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_XOAPHIEUMUON";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string mapm;
            mapm = txtMapm.Text;
            cmd.Parameters.Add("@MaPM", mapm);
            DialogResult kq1;
            kq1 = MessageBox.Show("Bạn Thật Sự Muốn Xóa", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    lblthongbaopm.ForeColor = Color.Red;
                    lblthongbaopm.Text = "Đã tồn tại PM trong sách mượn";
                    return;
                }
                else if (kq == 1)
                {
                    lblthongbaopm.ForeColor = Color.Red;
                    lblthongbaopm.Text = "Xóa Thành Công";
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
        //xu ly xoa phieu muon
        private void btnxoapm_Click(object sender, EventArgs e)
        {
            huy_bingding();
            xoaphieumuon();
            loaddlphieumuon();
            data_bingding();
        }
        //thoat phieu muon
        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Bạn Thật Sự Muốn Thoát kg?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //hien phieu muon dau tien
        private void hienphieumuondautien()
        {
           // txtpage.Text = vt.ToString();
            dtpm = new DataTable();
            dtpm = docphieumuon();
            DataRow r = dtpm.Rows[vt];
            txtMapm.Text = r[0].ToString();
            cbomasach.SelectedValue = r[1].ToString();
            cbomathe.SelectedValue = r[2].ToString();
            dtpNgaymuon.Text = r[3].ToString();
           // txtpage.Text = (1 + vt).ToString() + "/" + dtpm.Rows.Count.ToString();
        }

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
    }
}
