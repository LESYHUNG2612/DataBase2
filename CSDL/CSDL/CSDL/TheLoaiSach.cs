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
    public partial class TheLoaiSach : Form
    {
        SqlConnection cnn;
        public TheLoaiSach()
        {
            InitializeComponent();
            cnn = new SqlConnection("Data Source=MyLaptop;Initial Catalog=QuanLyNhaSach;Integrated Security=True");
        }
        //tao ma Nhap Sach
        private string taomaTL()
        {
            string MaTL;
            Random r = new Random();
            MaTL = "TL" + r.Next(50, 999).ToString();
            return MaTL;
        }
        //doc du lieu len file
        private DataTable docdulieu()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LOADTHELOAISACH";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            DataTable THELOAISACH = new DataTable();
            cnn.Open();
            THELOAISACH.Load(cmd.ExecuteReader());
            cnn.Close();
            return THELOAISACH;
        }
        //load nhan vien len luoi
        private void loadTLlenluoi()
        {
            dgvTheLoaiSach.DataSource = docdulieu();
        }
        //hien tieu de cot
        private void Hientieudecot()
        {
            dgvTheLoaiSach.Columns[0].HeaderText = "Mã TL";
            dgvTheLoaiSach.Columns[1].HeaderText = "Tên TL";          
        }
        private void NhapSach_Load(object sender, EventArgs e)
        {
            txtMaTheLoai.Enabled = false;
            loadTLlenluoi();
            data_bingding();
            Hientieudecot();
        }
        #region xử lý bingding
        private void data_bingding()
        {
            txtMaTheLoai.DataBindings.Add("Text", dgvTheLoaiSach.DataSource, "MaTL");
            cboTheLoai.DataBindings.Add("Text", dgvTheLoaiSach.DataSource, "TenTL");
        }
        private void Huy_bingding()
        {
            if (txtMaTheLoai.DataBindings != null)
                txtMaTheLoai.DataBindings.Clear();
            if (cboTheLoai.DataBindings != null)
                cboTheLoai.DataBindings.Clear();
        }
        #endregion
        //xu ly them ma the loai
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaTheLoai.Clear();
            cboTheLoai.ResetText();
            txtMaTheLoai.Text = taomaTL();
        }
        //dinh nghia ham xu ly luu nhan vien vao danh sach
        private void LuuMaTL()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LUUTHELOAISACH";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string MaTL ,TenTL;
            if (cboTheLoai.Text == "")
            {
                MessageBox.Show("Thể loại không được trống!");
                cboTheLoai.Focus();
                return;
            }          
            MaTL = txtMaTheLoai.Text;
            TenTL = cboTheLoai.Text;
            cmd.Parameters.AddWithValue("@MaTL", MaTL);
            cmd.Parameters.AddWithValue("@TenTL", TenTL);
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
                MessageBox.Show("Loi không them duoc vi" + ex.Message);
            }
            finally
            {
                if (cnn != null)
                    cnn.Close();
            }
        }
        //xu ly su kien
        private void btnLuu_Click(object sender, EventArgs e)
        {
            Huy_bingding();
            LuuMaTL();
            loadTLlenluoi();
            data_bingding();
        }
        //Ham Sua Nhap The Loại
        private void suaTHELOAISACH()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SUATHELOAISACH";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string MaTL, TenTL;
            if (cboTheLoai.Text == "")
            {
                MessageBox.Show("Tên Thể Loại không được trống!");
                cboTheLoai.Focus();
                return;
            }
            MaTL = txtMaTheLoai.Text;
            TenTL = cboTheLoai.Text;
            cmd.Parameters.AddWithValue("@MaTL", MaTL);
            cmd.Parameters.AddWithValue("@TenTL", TenTL);
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
        private void btnSua_Click(object sender, EventArgs e)
        {
            Huy_bingding();
            suaTHELOAISACH();
            loadTLlenluoi();
            data_bingding();
        }
        //xu ly su kien
        private void btnXoa_Click(object sender, EventArgs e)
        {
            cnn.Open();
            string sql = "";
            sql = "delete from THELOAISACH where MaTL='" + txtMaTheLoai.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cnn.Close();

            try
            {
                txtMaTheLoai.ResetText();
                cboTheLoai.ResetText();
            }
            catch { }
            MessageBox.Show("Xoá thành công !");
            loadTLlenluoi();
        }
        //load the loai sach

        private void TheLoaiSach_Load(object sender, EventArgs e)
        {
            txtMaTheLoai.Enabled = false;
            loadTLlenluoi();
            data_bingding();
            Hientieudecot();
        }

       
    }
}
