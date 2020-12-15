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
    public partial class Sach : Form
    {
        SqlConnection cnn;
        public Sach()
        {
            InitializeComponent();
            cnn = new SqlConnection("Data Source=MyLaptop;Initial Catalog=QuanLyNhaSach;Integrated Security=True");
        }
        //tao ma nhan vien ngau nhien
        private string taomaSach()
        {
            string MaSach;
            Random r = new Random();
            MaSach = "MS" + r.Next(50, 999).ToString();
            return MaSach;
        }
        //doc du lieu len file
        private DataTable docdulieu()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LOADSACH";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            DataTable Sach = new DataTable();
            cnn.Open();
            Sach.Load(cmd.ExecuteReader());
            cnn.Close();
            return Sach;
        }
      
        //load Sachlen luoi
        private void loadSachlenluoi()
        {
            dgvDanhMucSach.DataSource = docdulieu();
        }
        //hien tieu de cot
        private void Hientieudecot()
        {
            dgvDanhMucSach.Columns[0].HeaderText = "Mã Sách";
            dgvDanhMucSach.Columns[1].HeaderText = "Mã Thể Loại";
            dgvDanhMucSach.Columns[2].HeaderText = "Tên Sách";
            dgvDanhMucSach.Columns[3].HeaderText = "Tác Giả";
            dgvDanhMucSach.Columns[4].HeaderText = "Nhà Xuất Bản";        
            dgvDanhMucSach.Columns[5].HeaderText = "Tồn Kho";
            dgvDanhMucSach.Columns[6].HeaderText = "Giá Bán";
        }
        private void Sach_Load(object sender, EventArgs e)
        {
            txtMaSach.Enabled = false;
            loadSachlenluoi();
            data_bingding();
            Hientieudecot();
        }
        #region xử lý bingding
        private void data_bingding()
        {
            txtMaSach.DataBindings.Add("Text", dgvDanhMucSach.DataSource, "MaSach");
            cboMaTheLoai.DataBindings.Add("Text", dgvDanhMucSach.DataSource, "MaTL");
            txtTenSach.DataBindings.Add("Text", dgvDanhMucSach.DataSource, "TenSach");
            txtTacGia.DataBindings.Add("Text", dgvDanhMucSach.DataSource, "TacGia");
            txtNXB.DataBindings.Add("Text", dgvDanhMucSach.DataSource, "NXB");         
            txtSachTon.DataBindings.Add("Text", dgvDanhMucSach.DataSource, "TonKho");
            txtGiaBan.DataBindings.Add("Text", dgvDanhMucSach.DataSource, "GiaBan");
        }
        private void Huy_bingding()
        {
            if (txtMaSach.DataBindings != null)
                txtMaSach.DataBindings.Clear();
            if (cboMaTheLoai.DataBindings != null)
                cboMaTheLoai.DataBindings.Clear();
            if (txtTenSach.DataBindings != null)
                txtTenSach.DataBindings.Clear();
            if (txtTacGia.DataBindings != null)
                txtTacGia.DataBindings.Clear();
            if (txtNXB.DataBindings != null)
                txtNXB.DataBindings.Clear();
            if (txtSachTon.DataBindings != null)
                txtSachTon.DataBindings.Clear();
            if (txtGiaBan.DataBindings != null)
                txtGiaBan.DataBindings.Clear();
        }
        #endregion
        //xu ly su kien cac nut
        private void btnThemSach_Click(object sender, EventArgs e)
        {
            txtMaSach.Clear();
            cboMaTheLoai.ResetText();
            txtTenSach.ResetText();
            txtNXB.ResetText();
            txtTacGia.ResetText();
            txtSachTon.ResetText();
            txtGiaBan.ResetText();
            txtMaSach.Text = taomaSach();
        }

        //dinh nghia ham xu ly luu nhan vien vao danh sach
        private void luuSach()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LUUSACH";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string MaSach, MaTL, TenSach, NXB, TacGia, TonKho,GiaBan;
            if (cboMaTheLoai.Text == "")
            {
                MessageBox.Show("Mã Thể Loại Không được trống!");
                cboMaTheLoai.Focus();
                return;
            }
            if (txtTenSach.Text == "")
            {
                MessageBox.Show("Tên Sách Không được trống!");
                txtTenSach.Focus();
                return;
            }
            if (txtNXB.Text == "")
            {
                MessageBox.Show("Nhà Xuất Bản Không được trống!");
                txtNXB.Focus();
                return;
            }
            if (txtTacGia.Text == "")
            {
                MessageBox.Show("Tác Giả Không được trống!");
                txtTacGia.Focus();
                return;
            }
            MaSach = txtMaSach.Text;
            MaTL = cboMaTheLoai.Text;
            TenSach = txtTenSach.Text;
            TacGia = txtTacGia.Text;
            NXB = txtNXB.Text;
            TonKho = txtSachTon.Text;
            GiaBan = txtGiaBan.Text;       
            cmd.Parameters.AddWithValue("@MaSach", MaSach);
            cmd.Parameters.AddWithValue("@MaTL", MaTL);
            cmd.Parameters.AddWithValue("@TenSach", TenSach);
            cmd.Parameters.AddWithValue("@TacGia", TacGia);
            cmd.Parameters.AddWithValue("@NXB", NXB);           
            cmd.Parameters.AddWithValue("@TonKho", TonKho);
            cmd.Parameters.AddWithValue("@GiaBan", GiaBan);
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
        //xu ly su kien click 
        private void btnLuuSach_Click(object sender, EventArgs e)
        {
            Huy_bingding();
            luuSach();
            loadSachlenluoi();
            data_bingding();
        }

        //dinh nghia ham xu ly sua Sach
        private void suaSach()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SUASACH";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string MaSach, MaTL, TenSach, NXB, TacGia, TonKho, GiaBan;
            if (cboMaTheLoai.Text == "")
            {
                MessageBox.Show("Mã Thể Loại Không được trống!");
                cboMaTheLoai.Focus();
                return;
            }
            if (txtTenSach.Text == "")
            {
                MessageBox.Show("Tên Sách Không được trống!");
                txtTenSach.Focus();
                return;
            }
            if (txtNXB.Text == "")
            {
                MessageBox.Show("Nhà Xuất Bản Không được trống!");
                txtNXB.Focus();
                return;
            }
            if (txtTacGia.Text == "")
            {
                MessageBox.Show("Tác Giả Không được trống!");
                txtTacGia.Focus();
                return;
            }
            MaSach = txtMaSach.Text;
            MaTL = cboMaTheLoai.Text;
            TenSach = txtTenSach.Text;
            TacGia = txtTacGia.Text;
            NXB = txtNXB.Text;
            TonKho = txtSachTon.Text;
            GiaBan = txtGiaBan.Text;
            cmd.Parameters.AddWithValue("@MaSach", MaSach);
            cmd.Parameters.AddWithValue("@MaTL", MaTL);
            cmd.Parameters.AddWithValue("@TenSach", TenSach);
            cmd.Parameters.AddWithValue("@TacGia", TacGia);
            cmd.Parameters.AddWithValue("@NXB", NXB);
            cmd.Parameters.AddWithValue("@TonKho", TonKho);
            cmd.Parameters.AddWithValue("@GiaBan", GiaBan);
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
        //goi ham xy ly nut sua Sach
        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            Huy_bingding();
            suaSach();
            loadSachlenluoi();
            data_bingding();
        }
        //xoa sach
        private void bntXoaSach_Click(object sender, EventArgs e)
        {
            cnn.Open();
            string sql = "";
            sql = "delete from Sach where MaSach='" + txtMaSach.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cnn.Close();

            try
            {
                txtMaSach.Clear();
                cboMaTheLoai.ResetText();
                txtTenSach.ResetText();
                txtNXB.ResetText();
                txtTacGia.ResetText();
                txtGiaBan.ResetText();
                txtSachTon.ResetText();
            }
            catch { }
            MessageBox.Show("Xoá thành công !");
            loadSachlenluoi();
        }
        private DataTable TimTheoTenSach(string TenSach)
        {
            string chuoikn = $"select * from SACH where TenSach='{TenSach}'";
            SqlCommand cmd = new SqlCommand(chuoikn, cnn);
            DataTable TimTheoTenSach = new DataTable();
            cnn.Open();
            TimTheoTenSach.Load(cmd.ExecuteReader());
            cnn.Close();
            return TimTheoTenSach;
        }
        //xu ly tim sach
        private void btnTS_Click(object sender, EventArgs e)
        {
            dgvDanhMucSach.DataSource = TimTheoTenSach(txtTimSach.Text);
        }
    }
}
