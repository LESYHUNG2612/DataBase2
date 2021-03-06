﻿using System;
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
        //dinh nghia cac ham tim kiem sach
        private DataTable TimTheoMaSach(string MaSach)
        {
            string chuoikn = $"select * from SACH where MaSach='{MaSach}'";
            SqlCommand cmd = new SqlCommand(chuoikn, cnn);
            DataTable TimTheoMaSach = new DataTable();
            cnn.Open();
            TimTheoMaSach.Load(cmd.ExecuteReader());
            cnn.Close();
            return TimTheoMaSach;
        }
        private DataTable TimTheoMaTheLoai(string MaTL)
        {
            string chuoikn = $"select * from SACH where MaTL='{MaTL}'";
            SqlCommand cmd = new SqlCommand(chuoikn, cnn);
            DataTable TimTheoMaTheLoai = new DataTable();
            cnn.Open();
            TimTheoMaTheLoai.Load(cmd.ExecuteReader());
            cnn.Close();
            return TimTheoMaTheLoai;
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
        private void btnTimSach_Click(object sender, EventArgs e)
        {
            if (rbTimTheoMa.Checked)
            {
                dgvDanhMucSach.DataSource = TimTheoMaSach(txtMaTK.Text);
                txtMaTK.ForeColor = Color.Red;
                txtMaTK.Text = (dgvDanhMucSach.Rows.Count).ToString();
            }
            if (rbtnTimTheoMaTL.Checked)
            {
                dgvDanhMucSach.DataSource = TimTheoMaTheLoai(txtMaTK.Text);
                txtMaTK.ForeColor = Color.Red;
                txtMaTK.Text = (dgvDanhMucSach.Rows.Count).ToString();
            }
            if (rbtnTimTheoTenSach.Checked)
            {
                dgvDanhMucSach.DataSource = TimTheoTenSach(txtMaTK.Text);
                txtMaTK.ForeColor = Color.Red;
                txtMaTK.Text = (dgvDanhMucSach.Rows.Count).ToString();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadSachlenluoi();
            Hientieudecot();
        }
    }
}
