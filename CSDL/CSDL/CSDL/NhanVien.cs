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
    public partial class NhanVien : Form
    {
        SqlConnection cnn;
        public NhanVien()
        {
            InitializeComponent();
            cnn = new SqlConnection("Data Source=MyLaptop;Initial Catalog=QuanLyNhaSach;Integrated Security=True");
        }
        //tao ma nhan vien ngau nhien
        private string taomanv()
        {
            string manv;
            Random r = new Random();
            manv = "NV" + r.Next(50, 999).ToString();
            return manv;
        }
        //doc du lieu len file
        private DataTable docdulieu()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LOADNHANVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            DataTable nhanvien = new DataTable();
            cnn.Open();
            nhanvien.Load(cmd.ExecuteReader());
            cnn.Close();
            return nhanvien;
        }
        //load nhan vien len luoi
        private void loadnvlenluoi()
        {
            dgvNhanVien.DataSource = docdulieu();
        }
        private void Hientieudecot()
        {
            dgvNhanVien.Columns[0].HeaderText = "Mã NV";
            dgvNhanVien.Columns[1].HeaderText = "Tên NV";
            dgvNhanVien.Columns[2].HeaderText = "Giới Tính";
            dgvNhanVien.Columns[3].HeaderText = "Ngày Sinh";
            dgvNhanVien.Columns[4].HeaderText = "Địa Chỉ NV";
            dgvNhanVien.Columns[5].HeaderText = "Điện Thoại NV";
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            txtManv.Enabled = false;
            loadnvlenluoi();
            data_bingding();
            Hientieudecot();
        }
        #region xử lý bingding
        private void data_bingding()
        {
            txtManv.DataBindings.Add("Text", dgvNhanVien.DataSource, "MaNV");
            txtTennv.DataBindings.Add("Text", dgvNhanVien.DataSource, "TenNV");
            cboGioitinhnv.DataBindings.Add("Text", dgvNhanVien.DataSource, "Gioitinh");
            dtNgaySinh.DataBindings.Add("Text", dgvNhanVien.DataSource, "NgaySinh");
            txtDiachinv.DataBindings.Add("Text", dgvNhanVien.DataSource, "DiaChiNV");
            txtDienthoainv.DataBindings.Add("Text", dgvNhanVien.DataSource, "DienThoai");
        }
        private void Huy_bingding()
        {
            if (txtManv.DataBindings != null)
                txtManv.DataBindings.Clear();
            if (txtTennv.DataBindings != null)
                txtTennv.DataBindings.Clear();
            if (cboGioitinhnv.DataBindings != null)
                cboGioitinhnv.DataBindings.Clear();
            if (dtNgaySinh.DataBindings != null)
                dtNgaySinh.DataBindings.Clear();
            if (txtDiachinv.DataBindings != null)
                txtDiachinv.DataBindings.Clear();
            if (txtDienthoainv.DataBindings != null)
                txtDienthoainv.DataBindings.Clear();
        }
        #endregion
        //xu ly su kien cac nut

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            txtManv.Clear();
            txtTennv.Clear();
            txtDiachinv.Clear();
            txtDienthoainv.Clear();
            txtManv.Text = taomanv();
        }
        //dinh nghia ham xu ly luu nhan vien vao danh sach
        private void luunhanvien()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LUUNHANVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string manv, tennv, diachi, dienthoai;
            bool gioitinh;
            DateTime ngaysinh;
            if (txtTennv.Text == "")
            {
                MessageBox.Show("Tên kg được trống!");
                txtTennv.Focus();
                return;
            }
            if (txtDiachinv.Text == "")
            {
                MessageBox.Show("Địa chỉ kg được trống!");
                txtDiachinv.Focus();
                return;
            }
            if (txtDienthoainv.Text.Length < 0 || txtDienthoainv.Text.Length > 12)
            {
                MessageBox.Show("Điện thoại kg hợp lệ!");
                txtDienthoainv.Focus();
                return;
            }
            manv = txtManv.Text;
            tennv = txtTennv.Text;
            ngaysinh = DateTime.Parse(dtNgaySinh.Value.ToString());
            if (cboGioitinhnv.Text == "Nam")
            {
                gioitinh = true;
            }
            else gioitinh = false;
            diachi = txtDiachinv.Text;
            dienthoai = txtDienthoainv.Text;
            cmd.Parameters.AddWithValue("@MaNV", manv);
            cmd.Parameters.AddWithValue("@TenNV", tennv);
            cmd.Parameters.AddWithValue("@NgaySinh", ngaysinh);
            cmd.Parameters.AddWithValue("@Gioitinh", gioitinh);
            cmd.Parameters.AddWithValue("@DiaChiNV", diachi);
            cmd.Parameters.AddWithValue("@DienThoai", dienthoai);
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
                    lblthongbaonv.ForeColor = Color.Red;
                    lblthongbaonv.Text = "Mã Trùng";
                    return;
                }
                else
                {
                    lblthongbaonv.ForeColor = Color.Red;
                    lblthongbaonv.Text = "Lưu Thành Công";
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
        //xu ly su kien click luu nhan vien
        private void btnLuuNV_Click(object sender, EventArgs e)
        {
            Huy_bingding();
            luunhanvien();
            loadnvlenluoi();
            data_bingding();
        }
        //dinh nghia ham xu ly sua nhan viên
        private void suanv()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SUANHANVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string manv, tennv, diachi, dienthoai;
            bool gioitinh;
            if (txtTennv.Text == "")
            {
                MessageBox.Show("Tên kg được trống!");
                txtTennv.Focus();
                return;
            }
            if (txtDiachinv.Text == "")
            {
                MessageBox.Show("Địa chỉ kg được trống!");
                txtDiachinv.Focus();
                return;
            }
            if (txtDienthoainv.Text.Length < 0 || txtDienthoainv.Text.Length > 12)
            {
                MessageBox.Show("Điện thoại kg hợp lệ!");
                txtDienthoainv.Focus();
                return;
            }
            DateTime ngaysinh;
            manv = txtManv.Text;
            tennv = txtTennv.Text;
            ngaysinh = DateTime.Parse(dtNgaySinh.Value.ToString());
            if (cboGioitinhnv.Text == "Nam")
            {
                gioitinh = true;
            }
            else gioitinh = false;
            diachi = txtDiachinv.Text;
            dienthoai = txtDienthoainv.Text;
            cmd.Parameters.AddWithValue("@MaNV", manv);
            cmd.Parameters.AddWithValue("@TenNV", tennv);
            cmd.Parameters.AddWithValue("@NgaySinh", ngaysinh);
            cmd.Parameters.AddWithValue("@Gioitinh", gioitinh);
            cmd.Parameters.AddWithValue("@DiaChiNV", diachi);
            cmd.Parameters.AddWithValue("@DienThoai", dienthoai);
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
                    lblthongbaonv.ForeColor = Color.Red;
                    lblthongbaonv.Text = "Mã không tồn tại";
                    return;
                }
                else
                {
                    lblthongbaonv.ForeColor = Color.Red;
                    lblthongbaonv.Text = "Sửa Thành Công";
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
        //goi ham xy ly nut sua nhan vien
        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            Huy_bingding();
            suanv();
            loadnvlenluoi();
            data_bingding();
        }
        //dinh nghia ham xu ly xoa nhan viên
        //xu ly su kien click nut xoa nv
        private void bntXoaNV_Click(object sender, EventArgs e)
        {
            cnn.Open();
            string sql = "";
            sql = "delete from NhanVien where MaNV='" + txtManv.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cnn.Close();

            try
            {
                txtManv.Clear();
                txtTennv.Clear();
                dtNgaySinh.ResetText();
                cboGioitinhnv.ResetText();
                txtDiachinv.Clear();
                txtDienthoainv.Clear();
            }
            catch { }
            MessageBox.Show("Xoá thành công !");
            loadnvlenluoi();
        }
        private DataTable TimTheoMaNV(string MaNV)
        {
            string chuoikn = $"select * from NHANVIEN where MaNV='{MaNV}'";
            SqlCommand cmd = new SqlCommand(chuoikn, cnn);
            DataTable TimTheoMaNV = new DataTable();
            cnn.Open();
            TimTheoMaNV.Load(cmd.ExecuteReader());
            cnn.Close();
            return TimTheoMaNV;
        }
        
        private void btnTimNhanVien_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = TimTheoMaNV(btnTimNV.Text);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        { 
            loadnvlenluoi();
            Hientieudecot();
        }

      
    }
}
