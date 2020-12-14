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

namespace CSDL.HeThongGiaoDien
{
    public partial class NhapSach : Form
    {
        SqlConnection cnn;
        public NhapSach()
        {
            InitializeComponent();
            cnn = new SqlConnection("Data Source=MyLaptop;Initial Catalog=QuanLyNhaSach;Integrated Security=True");
        }
        //tao ma Nhap Sach
        private string taomaPNS()
        {
            string MaPN;
            Random r = new Random();
            MaPN = "PN" + r.Next(50, 999).ToString();
            return MaPN;
        }
        //doc du lieu len file
        private DataTable docdulieu()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LoadNhapSach";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            DataTable NhapSach = new DataTable();
            cnn.Open();
            NhapSach.Load(cmd.ExecuteReader());
            cnn.Close();
            return NhapSach;
        }
        //load nhan vien len luoi
        private void loadPNlenluoi()
        {
            dgvNhapSach.DataSource = docdulieu();
        }
        //hien tieu de cot
        private void Hientieudecot()
        {
            dgvNhapSach.Columns[0].HeaderText = "Mã PN";
            dgvNhapSach.Columns[1].HeaderText = "Mã Sách";
            dgvNhapSach.Columns[2].HeaderText = "Mã NV";
            dgvNhapSach.Columns[3].HeaderText = "Số Lượng";
            dgvNhapSach.Columns[4].HeaderText = "Giá Sách";
        }
        private void NhapSach_Load(object sender, EventArgs e)
        {
            txtMaPN.Enabled = false;
            loadPNlenluoi();
            data_bingding();
            Hientieudecot();
        }
        #region xử lý bingding
        private void data_bingding()
        {
            txtMaPN.DataBindings.Add("Text", dgvNhapSach.DataSource, "MaPN");
            cbbMaSach.DataBindings.Add("Text", dgvNhapSach.DataSource, "MaSach");
            cbbMaNV.DataBindings.Add("Text", dgvNhapSach.DataSource, "MaNV");
            txtSoLuong.DataBindings.Add("Value", dgvNhapSach.DataSource, "SoLuong");
            txtGiaSach.DataBindings.Add("Value", dgvNhapSach.DataSource, "GiaSach");
        }
        private void Huy_bingding()
        {
            if (txtMaPN.DataBindings != null)
                txtMaPN.DataBindings.Clear();
            if (cbbMaSach.DataBindings != null)
                cbbMaSach.DataBindings.Clear();
            if (cbbMaNV.DataBindings != null)
                cbbMaNV.DataBindings.Clear();
            if (txtSoLuong.DataBindings != null)
                txtSoLuong.DataBindings.Clear();
            if (txtGiaSach.DataBindings != null)
                txtGiaSach.DataBindings.Clear();
        }

        #endregion
        //xu ly them ma Nhap sách
        private void btnThemMaNS_Click(object sender, EventArgs e)
        {
            txtMaPN.Clear();
            cbbMaNV.ResetText();
            cbbMaSach.ResetText();
            txtGiaSach.ResetText();
            txtSoLuong.ResetText();
            txtMaPN.Text = taomaPNS();
        }
        //dinh nghia ham xu ly luu nhan vien vao danh sach
        private void LuuPhieuNhapSach()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LUUPHIEUNHAPSACH";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string MaPN, MaSach,MaNV,SoLuong, GiaSach;
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Số Lượng không được trống!");
                txtSoLuong.Focus();
                return;
            }
            if (txtGiaSach.Text == "")
            {
                MessageBox.Show("Giá Sách Không được trống!");
                txtGiaSach.Focus();
                return;
            }
            MaPN = txtMaPN.Text;
            MaSach = cbbMaSach.Text;
            MaNV = cbbMaNV.Text;
            SoLuong = txtSoLuong.Text;
            GiaSach = txtGiaSach.Text;
            cmd.Parameters.AddWithValue("@MaPN", MaPN);
            cmd.Parameters.AddWithValue("@MaSach", MaSach);
            cmd.Parameters.AddWithValue("@MaNV", MaNV);
            cmd.Parameters.AddWithValue("@SoLuong", SoLuong);
            cmd.Parameters.AddWithValue("@GiaSach", GiaSach);
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
                    lblthongbaoPNS.ForeColor = Color.Red;
                    lblthongbaoPNS.Text = "Mã Trùng";
                    return;
                }
                else
                {
                    lblthongbaoPNS.ForeColor = Color.Red;
                    lblthongbaoPNS.Text = "Lưu Thành Công";
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
        private void btnLuuPN_Click(object sender, EventArgs e)
        {
            Huy_bingding();
            LuuPhieuNhapSach();
            loadPNlenluoi();
            data_bingding();
        }
        //Ham Sua Phieu Nhap Sach
        private void suanPNS()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SUANHAPSACH";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string MaPN, MaSach, MaNV, SoLuong, GiaSach;
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Số Lượng không được trống!");
                txtSoLuong.Focus();
                return;
            }
            if (txtGiaSach.Text == "")
            {
                MessageBox.Show("Giá Sách Không được trống!");
                txtGiaSach.Focus();
                return;
            }
            MaPN = txtMaPN.Text;
            MaSach = cbbMaSach.Text;
            MaNV = cbbMaNV.Text;
            SoLuong = txtSoLuong.Text;
            GiaSach = txtGiaSach.Text;
            cmd.Parameters.AddWithValue("@MaPN", MaPN);
            cmd.Parameters.AddWithValue("@MaSach", MaSach);
            cmd.Parameters.AddWithValue("@MaNV", MaNV);
            cmd.Parameters.AddWithValue("@SoLuong", SoLuong);
            cmd.Parameters.AddWithValue("@GiaSach", GiaSach);
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
                    lblthongbaoPNS.ForeColor = Color.Red;
                    lblthongbaoPNS.Text = "Mã Trùng";
                    return;
                }
                else
                {
                    lblthongbaoPNS.ForeColor = Color.Red;
                    lblthongbaoPNS.Text = "Lưu Thành Công";
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
        private void btnSuaPN_Click(object sender, EventArgs e)
        {
            Huy_bingding();
            suanPNS();
            loadPNlenluoi();
            data_bingding();
        }
        //xu ly su kien click nut xoa nv
        private void btnXoaPN_Click(object sender, EventArgs e)
        {
            cnn.Open();
            string sql = "";
            sql = "delete from NHAPSACH where MaPN='" + txtMaPN.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cnn.Close();

            try
            {
                txtMaPN.ResetText();
                cbbMaSach.ResetText();
                cbbMaNV.ResetText();
                txtSoLuong.ResetText();
                txtGiaSach.ResetText();

            }
            catch { }
            MessageBox.Show("Xoá thành công !");
            loadPNlenluoi();
        }
    }
}
