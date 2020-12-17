using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ThucHanh
{
    public partial class frmSinhVien : Form
    {
        QuanLySinhVien qlsv;
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            qlsv.DocTuFile();
            LoadListView();
        }
        //Lấy thông tin sinh viên từ dòng item của ListView
        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool gt = true;
            List<string> mh = new List<string>();
            sv.MSSV  = this.mtxtMaSo.Text;
            sv.Hotenlot = this.mtxtHovatenlot.Text;
            sv.Ten = this.mtxtTen.Text;
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.SoCMND = this.mtxtCMND.Text;
            sv.DiaChi = this.txtDiaChi.Text;
            sv.Lop = this.cboLop.Text;
            sv.SDT = this.mtxtSDT.Text;
            if (rdNu.Checked)
                gt = false;
            sv.GioiTinh = gt;
            for (int i = 0; i < this.clbMonhoc.Items.Count; i++)
                if (clbMonhoc.GetItemChecked(i))
                    mh.Add(clbMonhoc.Items[i].ToString());
            sv.Monhocdangky = mh;
            return sv;
        }
        private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.MSSV = lvitem.SubItems[0].Text;
            sv.Hotenlot = lvitem.SubItems[1].Text;
            sv.Ten = lvitem.SubItems[2].Text;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[3].Text);
            sv.SoCMND = lvitem.SubItems[4].Text;
            sv.DiaChi = lvitem.SubItems[5].Text;
            sv.Lop = lvitem.SubItems[6].Text;
            sv.SDT = lvitem.SubItems[7].Text;
            sv.GioiTinh = false;
            if (lvitem.SubItems[8].Text == "Nam")
                sv.GioiTinh = true;
            List<string> mh = new List<string>();
            string[] s = lvitem.SubItems[9].Text.Split(',');
            foreach (string t in s)
                mh.Add(t);
            sv.Monhocdangky = mh;
            return sv;
        }
       
        //Thiết lập các thông tin lên controls sinh viên
        private void ThietLapThongTin(SinhVien sv)
        {
            this.mtxtMaSo.Text = sv.MSSV;
            this.mtxtHovatenlot.Text = sv.Hotenlot;
            this.mtxtTen.Text = sv.Ten;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.mtxtCMND.Text = sv.SoCMND;
            this.txtDiaChi.Text = sv.DiaChi;
            this.cboLop.Text = sv.Lop;
            this.mtxtSDT.Text = sv.SDT;
            if (sv.GioiTinh)
                this.rdNam.Checked = true;
            else
                this.rdNu.Checked = true;
            for (int i = 0; i < this.clbMonhoc.Items.Count; i++)
                this.clbMonhoc.SetItemChecked(i, false);
            foreach (string s in sv.Monhocdangky)
            {
                for (int i = 0; i < this.clbMonhoc.Items.Count; i++)
                    if (s.CompareTo(this.clbMonhoc.Items[i]) == 0)
                        this.clbMonhoc.SetItemChecked(i, true);
            }
        }
        
        //Thêm sinh viên vào ListView
        private void ThemSV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MSSV);
            lvitem.SubItems.Add(sv.Hotenlot);
            lvitem.SubItems.Add(sv.Ten);
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvitem.SubItems.Add(sv.SoCMND);
            lvitem.SubItems.Add(sv.DiaChi);
            lvitem.SubItems.Add(sv.Lop);
            lvitem.SubItems.Add(sv.SDT);
            string gt = "Nữ";
            if (sv.GioiTinh)
                gt = "Nam";
            lvitem.SubItems.Add(gt);
            string mh = "";
            foreach (string s in sv.Monhocdangky)
                mh += s + ",";
            mh = mh.Substring(0, mh.Length - 1);
            lvitem.SubItems.Add(mh);
            this.lvSinhVien.Items.Add(lvitem);
        }
        //lay thong tin sv tu controls them vao danhsachsv
        public SinhVien GetSVConTrols()
        {
            //public SinhVien(string ms, string ho, string ten, bool gt,
            //    DateTime ngaysinh, string lop, string socmnd,
            //    string sodt, string diachi, List<String> cn)
            SinhVien sv = new SinhVien();

            sv.MSSV = mtxtMaSo.Text;
            sv.Hotenlot = mtxtHovatenlot.Text;
            sv.Ten = mtxtTen.Text;
            sv.NgaySinh = dtpNgaySinh.Value;
            sv.SoCMND = mtxtCMND.Text;
            sv.DiaChi = txtDiaChi.Text;
            sv.Lop = cboLop.Text;
            sv.SDT = mtxtSDT.Text;
            sv.GioiTinh = false;
            if (rdNam.Checked)
                sv.GioiTinh = true;                                               
            for (int i = 0; i < clbMonhoc.Items.Count; i++)
            {
                if (clbMonhoc.GetItemChecked(i))
                {
                    sv.Monhocdangky.Add(clbMonhoc.Items[i].ToString());
                }
            }

            return sv;
        }
        //Hiển thị các sinh viên trong qlsv lên ListView
        private void LoadListView()
        {
            this.lvSinhVien.Items.Clear();
            foreach (SinhVien sv in qlsv.DanhSach)
            {
                ThemSV(sv);
            }
        }
      
        //Thoát chương trình
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Chức năng thêm sinh viên
        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            SinhVien kq = qlsv.Tim(sv.MSSV, delegate (object obj1, object obj2)
            {
                return (obj2 as SinhVien).MSSV.CompareTo(obj1.ToString());
            });
            if (kq != null)
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi thêm dữ liệu",

                MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.qlsv.Them(sv);
                this.LoadListView();
            }
        }
        private int SoSanhTheoMa(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.MSSV.CompareTo(obj1);
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            SinhVien kq = qlsv.Tim(sv.MSSV, delegate (object obj1, object obj2)
            {
                return (obj2 as SinhVien).MSSV.CompareTo(obj1.ToString());
            });
            if (kq != null)
                MessageBox.Show("Sinh viên không tồn tại");
            else
            {
                //xuat sinh vien ra
            }
        }
        
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSVConTrols();
            bool kq = qlsv.Sua(sv);
            if (kq)
            {
                MessageBox.Show("Sửa thành công !", "Thông Báo");
                LoadListView();
                qlsv.GhiFile();
            }
            else
                MessageBox.Show("Mã số SV không hợp lệ !", "Thông Báo");
        }
        
    public class SinhVien
        {
            public string MSSV { get; set; }
            public string Hotenlot { get; set; }
            public string Ten { get; set; }
            public DateTime NgaySinh { get; set; }
            public string SoCMND { get; set; }
            public string DiaChi { get; set; }
            public string Lop { get; set; }
            public string SDT { get; set; }
            public bool GioiTinh { get; set; }
            public List<string> Monhocdangky { get; set; }

            public SinhVien()
            {
                Monhocdangky = new List<string>();

            }

            public SinhVien(string ms, string ht, string T, DateTime ngay, string CMND,
            string dc, string lop, string sdt, bool gt, List<string> mh)
            {
                this.MSSV = ms;
                this.Hotenlot = ht;
                this.Ten = T;
                this.NgaySinh = ngay;
                this.SoCMND = CMND;
                this.DiaChi = dc;
                this.Lop = lop;
                this.SDT = sdt;
                this.GioiTinh = gt;
                this.Monhocdangky = mh;
            }
        }
        public delegate int SoSanh(object sv1, object sv2);
        public class QuanLySinhVien
        {
            public List<SinhVien> DanhSach;
            public QuanLySinhVien()
            {
                DanhSach = new List<SinhVien>();
            }
            public void Them(SinhVien sv)
            {
                this.DanhSach.Add(sv);
            }
            public SinhVien this[int index]
            {
                get { return DanhSach[index]; }
                set { DanhSach[index] = value; }
            }
            public void Xoa(object obj, SoSanh ss)
            {
                int i = DanhSach.Count - 1;
                for (; i >= 0; i--)
                    if (ss(obj, this[i]) == 0)
                        this.DanhSach.RemoveAt(i);
            }
            public SinhVien Tim(object obj, SoSanh ss)
            {
                SinhVien svresult = null;
                foreach (SinhVien sv in DanhSach)
                    if (ss(obj, sv) == 0)
                    {
                        svresult = sv;
                        break;
                    }
                return svresult;
            }
            public bool Sua(SinhVien sv)
            {
                bool kq = false;
                int count = DanhSach.Count;
                for (int i = 0; i < count; i++)
                {
                    if (sv.MSSV == DanhSach[i].MSSV)
                    {
                        DanhSach[i] = sv;
                        kq = true;
                        break;
                    }
                }
                return kq;
            }
            
            public void GhiFile()
            {
                string filename = "DanhSach.txt";
                StreamWriter sw = new StreamWriter(new FileStream(filename, FileMode.Open));
                foreach (SinhVien item in DanhSach)
                {
                    string mssv = item.MSSV;
                    string gt = "Nữ";
                    if (item.GioiTinh)
                        gt = "Nam";
                    string holot = item.Hotenlot;
                    string ten = item.Ten;
                    string ngaysinh = item.NgaySinh.ToString();
                    string lop = item.Lop;
                    string socmnd = item.SoCMND;
                    string sodt = item.SDT;
                    string diachi = item.DiaChi;
                    string cntotal = "";
                    foreach (string mh in item.Monhocdangky)
                    {
                        cntotal += mh + ",";
                    }
                    cntotal = cntotal.Substring(0, cntotal.Length - 1);
                    string sinhvien = mssv + "*" + holot + "*" + ten + "*" + gt + "*" + ngaysinh + "*" + lop + "*" + socmnd + "*" + sodt + "*" + diachi + "*" + cntotal;
                    sw.WriteLine(sinhvien);
                }
                sw.Close();
            }

            public void DocTuFile()
            {
                string filename = "DanhSachSV.txt", t;
                string[] s;
                SinhVien sv;
                StreamReader sr = new StreamReader(
                    new FileStream(filename, FileMode.Open));
                while ((t = sr.ReadLine()) != null)
                {
                    s = t.Split('\t');
                    sv = new SinhVien();
                    sv.MSSV = s[0];
                    sv.Hotenlot = s[1];
                    sv.Ten = s[2];
                    sv.NgaySinh = DateTime.Parse(s[3]);
                    sv.SoCMND = s[4];
                    sv.DiaChi = s[5];
                    sv.Lop = s[6];
                    sv.SDT = s[7];
                    sv.GioiTinh = false;
                    if (s[8] == "1")
                        sv.GioiTinh = true;
                    string[] mh = (s[9].Split(','));
                    foreach (string c in mh)
                        sv.Monhocdangky.Add(c);
                    this.Them(sv);
                }
            }                  
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int count = lvSinhVien.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem = lvSinhVien.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lvitem);
                SinhVien sv2 = null;
                bool kt = false;
                if ((MessageBox.Show("Bạn có thực sự muốn xóa sinh viên ms: " + sv.MSSV, "Thông báo", MessageBoxButtons.OKCancel)) == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (SinhVien item in qlsv.DanhSach)
                    {
                        if (sv.MSSV == item.MSSV)
                            kt = true;
                        sv2 = item;
                    }
                    if (kt)
                    {
                        qlsv.DanhSach.Remove(sv2);
                        LoadListView();
                        qlsv.GhiFile();
                    }
                }
            }
            else
                MessageBox.Show("Bạn chưa chọn Sinh Viên để xóa !");
        }
    }
    
}
