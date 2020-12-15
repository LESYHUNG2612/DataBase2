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
    public partial class DanhSachSach : Form
    {
        //DataTable dssach;
        SqlConnection cnn;
        public DanhSachSach()
        {
            InitializeComponent();
            cnn = new SqlConnection("Data Source=MyLaptop;Initial Catalog=QuanLyNhaSach;Integrated Security=True");
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
        }
        //load from
        private void DanhSachSach_Load(object sender, EventArgs e)
        {
            loadSachlenluoi();
            Hientieudecot();
        }


        private void btnTimMaSach_CheckedChanged(object sender, EventArgs e)
        {

        }
        //dinh nghia cac ham tim kiem sach
        private DataTable TimTheoMaSach()
        {
            string chuoikn = "select * from SACH where @MaSach=MaSach";
            SqlCommand cmd = new SqlCommand(chuoikn, cnn);
            DataTable sachhu = new DataTable();
            cnn.Open();
            sachhu.Load(cmd.ExecuteReader());
            cnn.Close();
            return sachhu;
        }
        private DataTable TimTheoMaTheLoai()
        {
            string chuoikn = "select * from SACH WHERE MaTL=@MaTL";
            SqlCommand cmd = new SqlCommand(chuoikn, cnn);
            DataTable sach = new DataTable();
            cnn.Open();
            sach.Load(cmd.ExecuteReader());
            cnn.Close();
            return sach;
        }
        private DataTable TimTheoTenSach()
        {
            string chuoikn = "select * from SACH where TenSach=@TenSach";
            SqlCommand cmd = new SqlCommand(chuoikn, cnn);
            DataTable sach = new DataTable();
            cnn.Open();
            sach.Load(cmd.ExecuteReader());
            cnn.Close();
            return sach;
        }

        private void btnTimSach_Click(object sender, EventArgs e)
        {
            if (chMaSach.Checked)
            {
                dgvDanhMucSach.DataSource = TimTheoMaSach();
                txttong.ForeColor = Color.Red;
                txttong.Text = (dgvDanhMucSach.Rows.Count).ToString();
            }
            if (chsachkbd.Checked)
            {
                dgvDanhMucSach.DataSource = TimTheoMaTheLoai();
                txttong.ForeColor = Color.Red;
                txttong.Text = (dgvDanhMucSach.Rows.Count).ToString();
            }
            if (chTimMaTL.Checked)
            {
                dgvDanhMucSach.DataSource = docsachbanchay();
                txttong.ForeColor = Color.Red;
                txttong.Text = (dgvDanhMucSach.Rows.Count).ToString();
            }
        }
    }
}
