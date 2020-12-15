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
	public partial class DocGia : Form
    {
		SqlConnection cnn;
		public DocGia()
        {
            InitializeComponent();
			cnn = new SqlConnection("Data Source=MyLaptop;Initial Catalog=QuanLyNhaSach;Integrated Security=True");
		}
		//dinh nghia cac ham su dung
		//tao ma nhan vien ngau nhien
		private string taomaDG()
		{
			string maDG;
			Random r = new Random();
			maDG = "DG" + r.Next(50, 999).ToString();
			return maDG;
		}
		//doc du lieu tu file
		private DataTable docdulieu()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "sp_LOADDOCGIA";
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Connection = cnn;
			DataTable DOCGIA = new DataTable();
			cnn.Open();
			DOCGIA.Load(cmd.ExecuteReader());
			cnn.Close();
			return DOCGIA;

		}
		private void loadDGlenluoi()
		{
			dgvdg.DataSource = docdulieu();
		}
		private void HienThiTieuDeCot()
		{
			dgvdg.Columns[0].HeaderText = "Mã DG";
			dgvdg.Columns[1].HeaderText = "Tên DG";
			dgvdg.Columns[2].HeaderText = "Ngày Sinh";
			dgvdg.Columns[3].HeaderText = "Giới Tính";
			dgvdg.Columns[4].HeaderText = "Địa Chỉ";
			dgvdg.Columns[5].HeaderText = "ĐiệnThoại";
			dgvdg.Columns[6].HeaderText = "Email";
		}
		private void DocGia_Load(object sender, EventArgs e)
        {
			txtMaDG.Enabled = false;
			loadDGlenluoi();
			data_bingding();
			HienThiTieuDeCot();
		}
		private void data_bingding()
		{
			txtMaDG.DataBindings.Add("Text", dgvdg.DataSource, "MaDG");
			txtTenDG.DataBindings.Add("Text", dgvdg.DataSource, "TenDG");
			//dtpNgaysinhDG.DataBindings.Add("Text", dgvdg.DataSource, "Ngày Sinh ");
			cboGioitinhDG.DataBindings.Add("Text", dgvdg.DataSource, "GioiTinh");
			txtDiachiDG.DataBindings.Add("Text", dgvdg.DataSource, "DiaChiDG");
			txtDienthoaiDG.DataBindings.Add("Text", dgvdg.DataSource, "DienThoaiDG");
			txtEmailDG.DataBindings.Add("Text", dgvdg.DataSource, "EmailDG");
		}
		private void Huy_bingding()
		{
			if (txtMaDG.DataBindings != null)
				txtMaDG.DataBindings.Clear();
			if (txtTenDG.DataBindings != null)
				txtTenDG.DataBindings.Clear();
			if (cboGioitinhDG.DataBindings != null)
				cboGioitinhDG.DataBindings.Clear();
			if (dtpNgaysinhDG.DataBindings != null)
				dtpNgaysinhDG.DataBindings.Clear();
			if (txtDiachiDG.DataBindings != null)
				txtDiachiDG.DataBindings.Clear();
			if (txtDienthoaiDG.DataBindings != null)
				txtDienthoaiDG.DataBindings.Clear();
			if (txtEmailDG.DataBindings != null)
				txtEmailDG.DataBindings.Clear();
		}

        private void btnThemĐG_Click(object sender, EventArgs e)
        {
			txtMaDG.Clear();
			txtTenDG.Clear();
			cboGioitinhDG.ResetText();
			txtDiachiDG.Clear();
			txtDienthoaiDG.Clear();
			txtEmailDG.Clear();
			txtMaDG.Text = taomaDG();
		}
		//dinh nghia ham xu ly luu doc gia vao danh sach
		private void LuuDocGia()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "sp_LUUDOCGIA";
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Connection = cnn;
			String madg, tendg, diachi, dienthoai, email;
			bool gioitinh;
			DateTime ngaysinh;
			if (txtTenDG.Text == "")
			{
				MessageBox.Show("Tên kg được trống!");
				txtTenDG.Focus();
				return;
			}
			if (txtDiachiDG.Text == "")
			{
				MessageBox.Show("Địa chỉ kg được trống!");
				txtDiachiDG.Focus();
				return;
			}
			if (txtDienthoaiDG.Text.Length < 0 || txtDienthoaiDG.Text.Length > 12)
			{
				MessageBox.Show("Điện thoại kg hợp lệ!");
				txtDienthoaiDG.Focus();
				return;
			}
			madg = txtMaDG.Text;
			tendg = txtTenDG.Text;
			ngaysinh = DateTime.Parse(dtpNgaysinhDG.Value.ToString());
			if (cboGioitinhDG.Text == "Nam")
			{
				gioitinh = true;
			}
			else gioitinh = false;
			diachi = txtDiachiDG.Text;
			dienthoai = txtDienthoaiDG.Text;
			email = txtEmailDG.Text;
			cmd.Parameters.AddWithValue("@MaDG", madg);
			cmd.Parameters.AddWithValue("@TenDG", tendg);
			cmd.Parameters.AddWithValue("@NgaySinh", ngaysinh);
			cmd.Parameters.AddWithValue("@Gioitinh", gioitinh);
			cmd.Parameters.AddWithValue("@DiaChiDG", diachi);
			cmd.Parameters.AddWithValue("@DienThoaiDG", dienthoai);
			cmd.Parameters.AddWithValue("@EmailDG", email);
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
					lblthongbaodg.ForeColor = Color.Red;
					lblthongbaodg.Text = "Mã Trùng";
					return;
				}
				else
				{
					lblthongbaodg.ForeColor = Color.Red;
					lblthongbaodg.Text = "Lưu Thành Công";
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
		//xu ly nut luu
		private void btnLuuĐG_Click(object sender, EventArgs e)
        {
			Huy_bingding();
			LuuDocGia();
			loadDGlenluoi();
			data_bingding();
		}
		private void SuaDG()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "sp_SUADOCGIA";
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Connection = cnn;
			String madg, tendg, diachi, dienthoai, email;
			bool gioitinh;
			DateTime ngaysinh;
			if (txtTenDG.Text == "")
			{
				MessageBox.Show("Tên kg được trống!");
				txtTenDG.Focus();
				return;
			}
			if (txtDiachiDG.Text == "")
			{
				MessageBox.Show("Địa chỉ kg được trống!");
				txtDiachiDG.Focus();
				return;
			}
			if (txtDienthoaiDG.Text.Length < 0 || txtDienthoaiDG.Text.Length > 12)
			{
				MessageBox.Show("Điện thoại kg hợp lệ!");
				txtDienthoaiDG.Focus();
				return;
			}
			madg = txtMaDG.Text;
			tendg = txtTenDG.Text;
			ngaysinh = DateTime.Parse(dtpNgaysinhDG.Value.ToString());
			if (cboGioitinhDG.Text == "Nam")
			{
				gioitinh = true;
			}
			else gioitinh = false;
			diachi = txtDiachiDG.Text;
			dienthoai = txtDienthoaiDG.Text;
			email = txtEmailDG.Text;
			cmd.Parameters.AddWithValue("@MaDG", madg);
			cmd.Parameters.AddWithValue("@TenDG", tendg);
			cmd.Parameters.AddWithValue("@NgaySinh", ngaysinh);
			cmd.Parameters.AddWithValue("@Gioitinh", gioitinh);
			cmd.Parameters.AddWithValue("@DiaChiDG", diachi);
			cmd.Parameters.AddWithValue("@DienThoaiDG", dienthoai);
			cmd.Parameters.AddWithValue("@EmailDG", email);
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
					lblthongbaodg.ForeColor = Color.Red;
					lblthongbaodg.Text = "Mã Trùng";
					return;
				}
				else
				{
					lblthongbaodg.ForeColor = Color.Red;
					lblthongbaodg.Text = "Lưu Thành Công";
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

        private void btnSuaĐG_Click(object sender, EventArgs e)
        {
			Huy_bingding();
			SuaDG();
			loadDGlenluoi();
			data_bingding();
		}

        private void bntXoaĐG_Click(object sender, EventArgs e)
        {
			cnn.Open();
			string sql = "";
			sql = "delete from DocGia where MaDG='" + txtMaDG.Text + "'";
			SqlCommand cmd = new SqlCommand(sql, cnn);
			cmd.CommandText = sql;
			cmd.ExecuteNonQuery();
			cnn.Close();

			try
			{
				txtMaDG.Clear();
				txtTenDG.Clear();
				dtpNgaysinhDG.ResetText();
				cboGioitinhDG.ResetText();
				txtDiachiDG.Clear();
				txtDienthoaiDG.Clear();
				txtEmailDG.Clear();
			}
			catch { }
			MessageBox.Show("Xoá thành công !");
			loadDGlenluoi();
		}

        private void dgvdg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
