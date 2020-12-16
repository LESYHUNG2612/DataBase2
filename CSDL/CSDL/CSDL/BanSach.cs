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

namespace CSDL
{
    public partial class BanSach : Form
    {
        SqlConnection cnn;
        public BanSach()
        {
            InitializeComponent();
            cnn = new SqlConnection("Data Source=MyLaptop;Initial Catalog=QuanLyNhaSach;Integrated Security=True");
        }
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
        //hien tieu de cot Sach
        private void Hientieudecot()
        {
            dgvDanhMucSach.Columns[0].HeaderText = "Mã Sách";
            dgvDanhMucSach.Columns[1].HeaderText = "Mã Thể Loại";
            dgvDanhMucSach.Columns[2].HeaderText = "Tên Sách";
            dgvDanhMucSach.Columns[3].HeaderText = "Tác Giả";
            dgvDanhMucSach.Columns[4].HeaderText = "Nhà Xuất Bản";
            dgvDanhMucSach.Columns[5].HeaderText = "Tồn Kho";

        }
       
        //tim sach
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
        //xu ly su kien tim sach
        private void btnTimSach_Click(object sender, EventArgs e)
        {
            dgvDanhMucSach.DataSource = TimTheoTenSach(txtTimTSach.Text); 
        }
        private DataTable docdulieuSachDaBan()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LOADSACHDABAN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            DataTable Sach = new DataTable();
            cnn.Open();
            Sach.Load(cmd.ExecuteReader());
            cnn.Close();
            return Sach;
        }

        //load Sachlen luoi
        private void loadSachlenluoiSachDaBan()
        {
            dgvDanhMucSachDaBan.DataSource = docdulieuSachDaBan();
        }
        //tao ma nhan vien ngau nhien
        private string taomaPB()
        {
            string maPB;
            Random r = new Random();
            maPB = "PB" + r.Next(50, 999).ToString();
            return maPB;
        }

        //load from
        private void MuonSach_Load(object sender, EventArgs e)
        {
            //hiên thi sach
            loadSachlenluoi();
            Hientieudecot();

            //hiên thi sach da ban
            loadSachlenluoiSachDaBan();
        }

        //dinh nghia ham doc du lieu tu dataGridViewSach lên thông tin ban sách
        private void dgvDanhMucSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgvDanhMucSach.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtMaSach.Text = row.Cells[0].Value.ToString();
                txtGiaBan.Text = row.Cells[6].Value.ToString();
                //Không cho phép sửa trường STT
                TxtMaPB.Enabled = false;
            }
            TxtMaPB.Text = taomaPB();
        }
        //=======================================//
        //dinh nghia ham xu ly luu nhan vien vao danh sach
        private void luuPhieuSachDaBan()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LUUPHIEUSACHDABAN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string MaPB,MaDG,MaNV,MaSach, SoLuong, GiaBan;
            DateTime Ngay;
            if (txtMaĐG.Text == "")
            {
                MessageBox.Show("Mã Độc Giả Không được trống!");
                txtMaĐG.Focus();
                return;
            }
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Mã Nhân viên không được trống!");
                txtMaNV.Focus();
                return;
            }
            if (nbSoLuong.Text == "")
            {
                MessageBox.Show("Số lượng không được trống!");
                nbSoLuong.Focus();
                return;
            }
            MaPB = TxtMaPB.Text;
            MaDG = txtMaĐG.Text;
            MaNV = txtMaNV.Text;
            MaSach = txtMaSach.Text;
            Ngay = DateTime.Parse(dptNgayTra.Value.ToString());
            SoLuong = nbSoLuong.Text;
            GiaBan = txtGiaBan.Text;
            cmd.Parameters.AddWithValue("@MaPB", MaPB);
            cmd.Parameters.AddWithValue("@MaDG", MaDG);
            cmd.Parameters.AddWithValue("@MaNV", MaNV);
            cmd.Parameters.AddWithValue("@MaSach", MaSach);
            cmd.Parameters.AddWithValue("@Ngay", Ngay);
            cmd.Parameters.AddWithValue("@SoLuong", SoLuong);
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
                    lblthongbao.ForeColor = Color.Red;
                    lblthongbao.Text = "Mã Trùng";
                    return;
                }
                else
                {
                    lblthongbao.ForeColor = Color.Red;
                    //lblthongbao.Text = "Lưu Thành Công";
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
        private DataTable docdulieuSachDanBan()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LOADSACHDABAN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            DataTable SachDaBan = new DataTable();
            cnn.Open();
            SachDaBan.Load(cmd.ExecuteReader());
            cnn.Close();
            return SachDaBan;
        }
        #region xử lý bingding
        private void data_bingding()
        {
            TxtMaPB.DataBindings.Add("Text", dgvDanhMucSachDaBan.DataSource, "MaPB");
            txtMaĐG.DataBindings.Add("Text", dgvDanhMucSachDaBan.DataSource, "MaDG");
            txtMaNV.DataBindings.Add("Text", dgvDanhMucSachDaBan.DataSource, "MaNV");
            txtMaSach.DataBindings.Add("Text", dgvDanhMucSachDaBan.DataSource, "MaSach");
            dptNgayTra.DataBindings.Add("Text", dgvDanhMucSachDaBan.DataSource, "Ngay");
            nbSoLuong.DataBindings.Add("Text", dgvDanhMucSachDaBan.DataSource, "SoLuong");
            txtGiaBan.DataBindings.Add("Text", dgvDanhMucSachDaBan.DataSource, "GiaBan");
        }
        private void Huy_bingding()
        {
            if (TxtMaPB.DataBindings != null)
                TxtMaPB.DataBindings.Clear();
            if (txtMaĐG.DataBindings != null)
                txtMaĐG.DataBindings.Clear();
            if (txtMaNV.DataBindings != null)
                txtMaNV.DataBindings.Clear();
            if (txtMaSach.DataBindings != null)
                txtMaSach.DataBindings.Clear();
            if (dptNgayTra.DataBindings != null)
                dptNgayTra.DataBindings.Clear();
            if (nbSoLuong.DataBindings != null)
                nbSoLuong.DataBindings.Clear();
            if (txtGiaBan.DataBindings != null)
                txtGiaBan.DataBindings.Clear();
        }
        #endregion
        //load Sachlen luoi
        private void loadSachDaBanlenluoi()
        {
            dgvDanhMucSachDaBan.DataSource = docdulieuSachDanBan();
        }
        //ban sach

        private void btnThemHoaDonBan_Click(object sender, EventArgs e)
        {
            Huy_bingding();
            luuPhieuSachDaBan();
            loadSachDaBanlenluoi();
            data_bingding();
        }

        //dinh nghia ham doc du lieu tu dataGridViewSach lên thông tin ban sách
      
        private void btnXoaHoaDonBan_Click(object sender, EventArgs e)
        {
            cnn.Open();
            string sql = "";
            sql = "delete from SACHDABAN where MaPB='" + TxtMaPB.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cnn.Close();
            try
            {
                TxtMaPB.Clear();
                txtMaĐG.ResetText();
                txtMaNV.ResetText();
                txtMaSach.ResetText();
                dptNgayTra.ResetText();
                nbSoLuong.ResetText();
                txtGiaBan.ResetText();
            }
            catch { }
            MessageBox.Show("Xoá thành công !");
            loadSachDaBanlenluoi();
        }

        private void dgvDanhMucSachDaBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgvDanhMucSachDaBan.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                TxtMaPB.Text = row.Cells[0].Value.ToString();
                txtMaĐG.Text = row.Cells[1].Value.ToString();
                txtMaNV.Text = row.Cells[2].Value.ToString();
                txtMaSach.Text = row.Cells[3].Value.ToString();
               // dptNgayTra.Text = row.Cells[4].Value.ToString();
                nbSoLuong.Text = row.Cells[5].Value.ToString();
                txtGiaBan.Text = row.Cells[6].Value.ToString();
                //Không cho phép sửa trường STT
                TxtMaPB.Enabled = false;
            }
        }

        private void SuaSachBan()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SUAPHIEUSACHDABAN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string MaPB, MaDG, MaNV, MaSach, SoLuong, GiaBan;
            DateTime Ngay;
            if (txtMaĐG.Text == "")
            {
                MessageBox.Show("Mã độc giả không được trống!");
                txtMaĐG.Focus();
                return;
            }
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Mã Nhân Viên không được trống!");
                txtMaNV.Focus();
                return;
            }
            if (txtMaSach.Text == "")
            {
                MessageBox.Show("Mã Sách không được trống!");
                txtMaSach.Focus();
                return;
            }
            if (nbSoLuong.Text == "")
            {
                MessageBox.Show("Số lượng không được trống!");
                nbSoLuong.Focus();
                return;
            }
            MaPB = TxtMaPB.Text;
            MaDG = txtMaĐG.Text;
            MaNV = txtMaNV.Text;
            MaSach = txtMaSach.Text;
            Ngay = DateTime.Parse(dptNgayTra.Value.ToString());
            SoLuong = nbSoLuong.Text;
            GiaBan = txtGiaBan.Text;
            cmd.Parameters.AddWithValue("@MaPB", MaPB);
            cmd.Parameters.AddWithValue("@MaDG", MaDG);
            cmd.Parameters.AddWithValue("@MaNV", MaNV);
            cmd.Parameters.AddWithValue("@MaSach", MaSach);
            cmd.Parameters.AddWithValue("@Ngay", Ngay);
            cmd.Parameters.AddWithValue("@SoLuong", SoLuong);
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
                    lblthongbao.ForeColor = Color.Red;
                    lblthongbao.Text = "Mã không tồn tại";
                    return;
                }
                else
                {
                    lblthongbao.ForeColor = Color.Red;
                    lblthongbao.Text = "Sửa Thành Công";
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
        //sua ban sach
        private void btnSuaHoaDonBan_Click(object sender, EventArgs e)
        {
            Huy_bingding();
            SuaSachBan();
            loadSachDaBanlenluoi();
            data_bingding();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadSachlenluoi();
            Hientieudecot();
        }
    }
}
