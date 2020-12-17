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
    public partial class frmSachMuon : Form
    {

        string A;
        SqlConnection cnn;
        public frmSachMuon()
        {
            InitializeComponent();
            cnn = new SqlConnection("Data Source=MyLaptop;Initial Catalog=QuanLyThuVienSachCaNhan;Integrated Security=True");
        }
        //load from sach
        private void frmSachMuon_Load(object sender, EventArgs e)
        {
            loaddllenfile();
            hiendlphieumuon();
            hiendlsach();
            A = label9.Text;
            label9.Text = "";
            timer1.Start();
            hientieudecot();
            data_bingding();
        }
        #region bingding
        private void data_bingding()
        {
            txttinhtrang.DataBindings.Add("Text", dgvsachmuon.DataSource, "TinhTrang");
            txtsoluongsm.DataBindings.Add("Text", dgvsachmuon.DataSource, "SLSachMuon");
        }
        private void huy_bingding()
        {
            if (cbomapm.DataBindings != null)
                cbomapm.DataBindings.Clear();
            if (cbomasach.DataBindings != null)
                cbomasach.DataBindings.Clear();
            if (dtngaytra.DataBindings != null)
                dtngaytra.DataBindings.Clear();
            if (txttinhtrang.DataBindings != null)
                txttinhtrang.DataBindings.Clear();
            if (txtsoluongsm.DataBindings != null)
                txtsoluongsm.DataBindings.Clear();
        }
        #endregion
        //hien tieu de cot
        private void hientieudecot()
        {
            dgvsachmuon.Columns[0].HeaderText = "Mã PM";
            dgvsachmuon.Columns[1].HeaderText = "Mã Sách";
            dgvsachmuon.Columns[2].HeaderText = "Tình Trạng";
            dgvsachmuon.Columns[3].HeaderText = "SL Sách Mượn";
            dgvsachmuon.Columns[4].HeaderText = "Ngày Trả";
        }
        //LOAD SACH LEN FROM
        private DataTable loadsach()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_LOADSACH";
            cmd.Connection = cnn;
            DataTable sach = new DataTable();
            cnn.Open();
            sach.Load(cmd.ExecuteReader());
            cnn.Close();
            return sach;
        }
        //hiện du lieu len from
        private void hiendlsach()
        {
            cbomasach.DataSource = loadsach();
            cbomasach.ValueMember = "MaSach";
            cbomasach.DisplayMember = "TenSach";
        }
        //load phieu muon
        private DataTable loadPM()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_LOADPHIEUMUON";
            cmd.Connection = cnn;
            DataTable phieumuon = new DataTable();
            cnn.Open();
            phieumuon.Load(cmd.ExecuteReader());
            cnn.Close();
            return phieumuon;
        }
        //hien du lieu phieu muon len from
        private void hiendlphieumuon()
        {
            cbomapm.DataSource = loadPM();
            cbomapm.ValueMember = "MaPM";
            cbomapm.DisplayMember = "TenPM";
        }
        //doc du lieu sach len file
        private DataTable docsachmuon()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LOADSACHMUON";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            DataTable sachmuon = new DataTable();
            cnn.Open();
            sachmuon.Load(cmd.ExecuteReader());
            cnn.Close();
            return sachmuon;
        }
        //hien du leu sach lên file
        private void loaddllenfile()
        {
            dgvsachmuon.DataSource = docsachmuon();
        }
        //xu ly su kien them
        private void btnthemnv_Click(object sender, EventArgs e)
        {
            huy_bingding();
            txtsoluongsm.Clear();
            txttinhtrang.Clear();
            data_bingding();
        }
        //dinh ngghia ham xu ly luu sach
        private void luusachmuon()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LUUSACHMUON";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string mapm, masach, tinhtrang;
            int slm;
            DateTime ngaytra;
            mapm = cbomapm.SelectedValue.ToString(); ;
            masach = cbomasach.SelectedValue.ToString();
            slm = int.Parse(txtsoluongsm.Text);
            if (slm > 3 || slm < 1)
            {
                lblthongbaosm.ForeColor = Color.Red;
                lblthongbaosm.Text = "Chỉ có thể mượn tối đa 3 và tối thiểu 1";
                txtsoluongsm.Focus();
                return;
            }
            if (cbomapm.Text == "")
            {
                lblthongbaosm.ForeColor = Color.Red;
                lblthongbaosm.Text = "Phải chọn pm";
                cbomapm.Focus();
                return;
            }
            if (cbomasach.Text == "")
            {
                lblthongbaosm.ForeColor = Color.Red;
                lblthongbaosm.Text = "Phải chọn Sách";
                cbomapm.Focus();
                return;
            }
            tinhtrang = txttinhtrang.Text;
            ngaytra = DateTime.Parse(dtngayphaitra.Value.ToString());
            cmd.Parameters.Add("@MaPM", mapm);
            cmd.Parameters.Add("@MaSach", masach);
            cmd.Parameters.Add("@TinhTrang", tinhtrang);
            cmd.Parameters.Add("@SLSachMuon", slm);
            cmd.Parameters.Add("@NgayTra", ngaytra);
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
                    lblthongbaosm.ForeColor = Color.Red;
                    lblthongbaosm.Text = "Không tồn tại sách";
                    return;
                }
                else if (kq == 2)
                {
                    lblthongbaosm.ForeColor = Color.Red;
                    lblthongbaosm.Text = "Không tồn tại phiếu mượn";
                    return;
                }
                else
                {
                    lblthongbaosm.ForeColor = Color.Red;
                    lblthongbaosm.Text = "Lưu Thành Công";
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
        //lu sach muon
        private void btnluusm_Click(object sender, EventArgs e)
        {
            huy_bingding();
            luusachmuon();
            loaddllenfile();
            data_bingding();
        }
        //dinh nghia ham sua sach  muon
        private void suasachmuon()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SUASACHMUON";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string mapm, masach, tinhtrang;
            int slm;
            DateTime ngaytra;
            mapm = cbomapm.SelectedValue.ToString(); ;
            masach = cbomasach.SelectedValue.ToString();
            slm = int.Parse(txtsoluongsm.Text);
            tinhtrang = txttinhtrang.Text;
            ngaytra = DateTime.Parse(dtngayphaitra.Value.ToString());
            if (slm > 3 || slm < 1)
            {
                lblthongbaosm.ForeColor = Color.Red;
                lblthongbaosm.Text = "Chỉ có thể mượn tối đa 3 và tối thiểu 1";
                txtsoluongsm.Focus();
                return;
            }
            if (cbomapm.Text == "")
            {
                lblthongbaosm.ForeColor = Color.Red;
                lblthongbaosm.Text = "Phải chọn pm";
                cbomapm.Focus();
                return;
            }
            if (cbomasach.Text == "")
            {
                lblthongbaosm.ForeColor = Color.Red;
                lblthongbaosm.Text = "Phải chọn Sách";
                cbomapm.Focus();
                return;
            }
            cmd.Parameters.Add("@MaPM", mapm);
            cmd.Parameters.Add("@MaSach", masach);
            cmd.Parameters.Add("@TinhTrang", tinhtrang);
            cmd.Parameters.Add("@SLSachMuon", slm);
            cmd.Parameters.Add("@NgayTra", ngaytra);
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
                    lblthongbaosm.ForeColor = Color.Red;
                    lblthongbaosm.Text = "tồn tại sách";
                    return;
                }
                else if (kq == 2)
                {
                    lblthongbaosm.ForeColor = Color.Red;
                    lblthongbaosm.Text = "tồn tại phiếu mượn";
                    return;
                }
                else
                {
                    lblthongbaosm.ForeColor = Color.Red;
                    lblthongbaosm.Text = "Sửa Thành Công";
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
        //xu ly sua sach muon
        private void btnsuasm_Click(object sender, EventArgs e)
        {
            huy_bingding();
            suasachmuon();
            loaddllenfile();
            data_bingding();
        }
        //dinh nghia ham xoa sach muon
        private void xoasachmuon()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_XOASACHMUON";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string mapm, masach;
            mapm = cbomapm.SelectedValue.ToString();
            masach = cbomasach.SelectedValue.ToString();
            cmd.Parameters.AddWithValue("@MaPM", mapm);
            cmd.Parameters.AddWithValue("@MaSach", masach);
            DialogResult kq1;
            kq1 = MessageBox.Show("Bạn Thật Sự Muốn Xóa", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq1 == DialogResult.Yes)
            {
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
                        lblthongbaosm.ForeColor = Color.Red;
                        lblthongbaosm.Text = "Không tồn tại PM";
                        return;
                    }
                    else if (kq == 2)
                    {
                        lblthongbaosm.ForeColor = Color.Red;
                        lblthongbaosm.Text = "Không tồn tại sách ";
                        return;
                    }
                    else
                    {
                        lblthongbaosm.ForeColor = Color.Red;
                        lblthongbaosm.Text = "Xóa Thành Công";
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
        //xu ly su kien xoa sach muon
        private void btnxoaSM_Click(object sender, EventArgs e)
        {
            huy_bingding();
            xoasachmuon();
            loaddllenfile();
            data_bingding();
        }
        //xu ly nut thoat 
        private void btnthoatSM_Click(object sender, EventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Bạn Thật Sự Muốn Thoát không?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //chay chu tieu de
        private void timer1_Tick(object sender, EventArgs e)
        {
            int d = 0, x;
            x = A.Length;
            d++;
            string a = A.Substring(0, 1);
            A = A.Substring(1, A.Length - 1);
            label9.Text = label9.Text + a;
            if (d == x)
            {
                timer1.Stop();
            }
        }
    }
}
