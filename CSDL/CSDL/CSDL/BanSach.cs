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
    
        //load from
        private void MuonSach_Load(object sender, EventArgs e)
        {
            //hiên thi sach
            loadSachlenluoi();
            Hientieudecot();

            //hiên thi sach da ban
            loadSachlenluoiSachDaBan();
        }
        //dinh nghia ham tinh gia ban

        private void dgvDanhMucSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgvDanhMucSach.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtMaSach.Text = row.Cells[0].Value.ToString();
                NmUDGiaBan.Text = row.Cells[1].Value.ToString();

                //Không cho phép sửa trường STT
                TxtMaPB.Enabled = false;
            }
        }
        //=======================================//
        //dinh nghia ham doc du lieu tu dataGridViewSach lên thông tin ban sách
        private void btnThemHoaDonBan_Click(object sender, EventArgs e)
        {

        }
    }
}
