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
    public partial class frmthethuvien : Form
    {
        SqlConnection cnn;
        DataTable vtttv;
        int vt;
        public frmthethuvien()
        {
            InitializeComponent();
            cnn = new SqlConnection("Data Source=MyLaptop;Initial Catalog=QuanLyThuVienSachCaNhan;Integrated Security=True");
        }
        //load the thu vien
        private void frmthethuvien_Load(object sender, EventArgs e)
        {
            txtMa.Enabled = false;
            loaddllenfile();
            hientieudecot();
            //hiensvdautien();
            data_bingding();
        }
        //tao ma the 
        private string taomathe()
        {
            string mapthe;
            Random r = new Random();
            mapthe = "NV" + r.Next(50, 999).ToString();
            return mapthe;
        }
        #region bingding
        private void data_bingding()
        {
            txtMa.DataBindings.Add("Text", dgvttttv.DataSource, "MaThe");
            txtTensv.DataBindings.Add("Text", dgvttttv.DataSource, "TenSV");
            txtdiachisv.DataBindings.Add("Text", dgvttttv.DataSource, "DiaChiSV");
            txtdt.DataBindings.Add("Text", dgvttttv.DataSource, "DienThoaiSV");
        }
        private void huy_bingding()
        {
            if (dtngaysinh.DataBindings != null)
                dtngaysinh.DataBindings.Clear();
            if (txtdt.DataBindings != null)
                txtdt.DataBindings.Clear();
            if (txtMa.DataBindings != null)
                txtMa.DataBindings.Clear();
            if (txtTensv.DataBindings != null)
                txtTensv.DataBindings.Clear();
            if (dtngaytao.DataBindings != null)
                dtngaytao.DataBindings.Clear();
            if (dtngayhethan.DataBindings != null)
                dtngayhethan.DataBindings.Clear();
            if (txtdiachisv.DataBindings != null)
                txtdiachisv.DataBindings.Clear();
            if (cboGioitinh.DataBindings != null)
                cboGioitinh.DataBindings.Clear();
        }
        #endregion
        //hien tieu de cot
        private void hientieudecot()
        {
            dgvttttv.Columns[0].HeaderText = "Mã The";
            dgvttttv.Columns[1].HeaderText = "Tên SV";
            dgvttttv.Columns[2].HeaderText = "Giới Tính";
            dgvttttv.Columns[3].HeaderText = "Ngày Sinh";
            dgvttttv.Columns[4].HeaderText = "Địa Chỉ Sv";
            dgvttttv.Columns[5].HeaderText = "Điện Thoại";
            dgvttttv.Columns[6].HeaderText = "Ngày Tạo";
            dgvttttv.Columns[7].HeaderText = "Ngày Hết Hạn";
        }
        //doa du lieu len file
        public DataTable docthethuvien()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_RELOADTHETHUVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            DataTable thethuvien = new DataTable();
            cnn.Open();
            thethuvien.Load(cmd.ExecuteReader());
            cnn.Close();
            return thethuvien;
        }
        //hien thi du lieu ken from
        private void loaddllenfile()
        {
            dgvttttv.DataSource = docthethuvien();
            lbltong.ForeColor = Color.Red;
            lbltong.Text = (dgvttttv.Rows.Count).ToString();
        }
        //them the thu vien
        private void btnthemttv_Click(object sender, EventArgs e)
        {
            txtdt.Clear();
            txtMa.Clear();
            txtTensv.Clear();
            txtdiachisv.Clear();
            txtMa.Text = taomathe();
        }
        //dinh nghia ham xu ly luu the thu vien
        private void luuthethuvien()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LUUTHETHUVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string ma, ten, diachi, dt;
            DateTime ngaytao, ngayhethan, ngaysinh;
            bool gioitinh;
            ma = txtMa.Text;
            ten = txtTensv.Text;
            diachi = txtdiachisv.Text;
            dt = txtdt.Text;
            ngayhethan = DateTime.Parse(dtngayhethan.Value.ToString());
            ngaytao = DateTime.Parse(dtngaytao.Value.ToString());
            ngaysinh = DateTime.Parse(dtngaysinh.Value.ToString());
            if (DateTime.Now.Year - ngaysinh.Year > 85 || DateTime.Now.Year - ngaysinh.Year < 18)
            {
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "sinh viên phải đủ tuổi từ 18-85";
                dtngaysinh.Focus();
                return;
            }
            if (txtTensv.Text == "")
            {
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Tên không được để trống";
                txtTensv.Focus();
                return;
            }
            if (txtdiachisv.Text == "")
            {
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Địa chỉ không được để trống";
                txtdiachisv.Focus();
                return;
            }
            if (cboGioitinh.Text == "Nam")
            {
                gioitinh = true;
            }
            else gioitinh = false;
            cmd.Parameters.Add("@MaThe", ma);
            cmd.Parameters.Add("@TenSV", ten);
            cmd.Parameters.Add("@GioiTinh", gioitinh);
            cmd.Parameters.Add("@NgaySinh", ngaysinh);
            cmd.Parameters.Add("@DiaChiSV", diachi);
            cmd.Parameters.Add("@DienThoai", dt);
            cmd.Parameters.Add("@NgayTao", ngaytao);
            cmd.Parameters.Add("@NgayHetHan", ngayhethan);
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
                    lblthongbao.Text = "đã tồn tại TheThuViện";
                    return;
                }
                else
                {
                    lblthongbao.ForeColor = Color.Red;
                    lblthongbao.Text = "Lưu Thành Công";
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

        private void btnluuttv_Click(object sender, EventArgs e)
        {
            huy_bingding();
            luuthethuvien();
            loaddllenfile();
            data_bingding();
        }
        //dinh nghia ham sua the thu vien 
        private void suathethuvien()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SUATHETHUVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string ma, ten, diachi, dt;
            DateTime ngaytao, ngayhethan, ngaysinh;
            bool gioitinh;
            ma = txtMa.Text;
            ten = txtTensv.Text;
            diachi = txtdiachisv.Text;
            dt = txtdt.Text;
            ngayhethan = DateTime.Parse(dtngayhethan.Value.ToString());
            ngaytao = DateTime.Parse(dtngaytao.Value.ToString());
            ngaysinh = DateTime.Parse(dtngaysinh.Value.ToString());
            if (cboGioitinh.Text == "Nam")
            {
                gioitinh = true;
            }
            else gioitinh = false;
            SqlParameter sqlParameter = cmd.Parameters.Add("@MaThe", ma);
            cmd.Parameters.Add("@TenSV", ten);
            cmd.Parameters.Add("@GioiTinh", gioitinh);
            cmd.Parameters.Add("@NgaySinh", ngaysinh);
            cmd.Parameters.Add("@DiaChiSV", diachi);
            cmd.Parameters.Add("@DienThoai", dt);
            cmd.Parameters.Add("@NgayTao", ngaytao);
            cmd.Parameters.Add("@NgayHetHan", ngayhethan);
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
                    lblthongbao.Text = "không tồn tại The Thu Viện";
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
        //xu ly sua the thu vien
        private void btnsuattv_Click(object sender, EventArgs e)
        {
            huy_bingding();
            suathethuvien();
            loaddllenfile();
            data_bingding();
        }
        //dinh nghia hM XOA THE THU VIEN
        private void xoathethuvien()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_XOATHETHUVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string ma;
            ma = txtMa.Text;
            cmd.Parameters.AddWithValue("@MATHE", ma);
            DialogResult kq;
            kq = MessageBox.Show("Bạn Thật Sự Muốn Thoát kg?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    cmd.Parameters.Add("@kq",
                    SqlDbType.Int).Direction =
                        ParameterDirection.ReturnValue;
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    int kq1 = (int)cmd.Parameters["@kq"].Value;
                    if (kq1 == 1)
                    {
                        lblthongbao.ForeColor = Color.Red;
                        lblthongbao.Text = "đã tồn tại TheThuViện trong phieu muon";
                        return;
                    }
                    if (kq1 == 2)
                    {
                        lblthongbao.ForeColor = Color.Red;
                        lblthongbao.Text = "đã tồn tại TheThuViện trong phieu nhac tra";
                        return;
                    }
                    else
                    {
                        lblthongbao.ForeColor = Color.Red;
                        lblthongbao.Text = "Lưu Thành Công";
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
        }
        //xu ly su kien xoa the thu vien
        private void btnxoattv_Click(object sender, EventArgs e)
        {
            huy_bingding();
            xoathethuvien();
            loaddllenfile();
            data_bingding();
        }
        //xu ly thoat the thu vien
        private void btnthoatttv_Click(object sender, EventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Bạn Thật Sự Muốn Thoát không?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //rang buoc khong nhap chu
        private void txtdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 45 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 45 && e.KeyChar != 46)
            {
                e.Handled = true;
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Không được nhập chữ";
            }
        }
        //khong duoc nhap so
        private void txtTensv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 45 && e.KeyChar < 57)
            {
                e.Handled = true;
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Không được nhập số";
            }
        }
    }

}
