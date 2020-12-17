using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;


namespace QuanLyGiaoVien
{
	public partial class frmGiaoVien : Form
	{
		public frmGiaoVien()
		{
			InitializeComponent();
		}
		private void fromGiaoVien_Load(object sender, EventArgs e)
		{
			string lienhe = "http://it.dlu.edu.vn/e-learning/Default.aspx";
			this.linklbLienHe.Links.Add(0, lienhe.Length, lienhe);
			this.cboMaSo.SelectedItem = this.cboMaSo.Items[0];
		}

		private void btnChon_Click(object sender, EventArgs e)
		{
			int i = this.lbDanhSachMH.SelectedItems.Count - 1;
			while ( i>= 0)
			{
				this.lbMonHocDay.Items.Add(lbDanhSachMH.SelectedItems[i]);
				this.lbDanhSachMH.Items.Remove(lbDanhSachMH.SelectedItems[i]);
				i--;
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			int i = this.lbMonHocDay.SelectedItems.Count - 1;
			while(i>=0)
			{
				this.lbDanhSachMH.Items.Add(lbMonHocDay.SelectedItems[i]);
				this.lbMonHocDay.Items.Remove(lbMonHocDay.SelectedItems[i]);
				i--;
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Reset();
		}
		public void Reset()
		{
			this.cboMaSo.Text = "";
			this.txtHoTen.Text = "";
			this.txtMail.Text = "";
			this.mtxtSoDT.Text = "";
			this.rdNam.Checked = true;
			//Bỏ Chọn Trên Bảng Ngoại Ngữ
			for (int i = 0; i < chklbNgoaiNgu.Items.Count-1; i++)
			{
				chklbNgoaiNgu.SetItemChecked(i, false);
			}
			//Chuyển các môn từ danh sách môn dạy sang danh sách các môn học
			foreach (object ob in this.lbMonHocDay.Items)
				this.lbDanhSachMH.Items.Add(ob);
			this.lbMonHocDay.Items.Clear();
		}

		private void linklbLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string s = e.Link.LinkData.ToString();
			Process.Start(s);
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			frmTBGiaoVien frm = new frmTBGiaoVien();
			frm.SetText(GetGiaoVien().ToString());
			frm.ShowDialog();
		}
		public GiaoVien GetGiaoVien()
		{
			string gt = "Nam";
			if (rdNu.Checked)
				gt = "Nữ";
			GiaoVien gv = new GiaoVien();
			gv.MaSo = this.cboMaSo.Text;
			gv.GioiTinh = gt;
			gv.HoTen = this.txtHoTen.Text;
			gv.NgaySinh = this.dtpNgaySinh.Value;
			gv.Mail = this.txtMail.Text;
			gv.SoDT = this.mtxtSoDT.Text;
			//Lấy Thông Tin ngoại ngữ
			string ngoaingu = "";
			for (int i = 0; i < chklbNgoaiNgu.Items.Count-1; i++)
			{
				if (chklbNgoaiNgu.GetItemChecked(i))
					ngoaingu += chklbNgoaiNgu.Items[i] + ";";
				//Lấy thông tin danh sách môn học
				DanhMucMonHoc mh = new DanhMucMonHoc();
				foreach (object ob in lbMonHocDay.Items)
					mh.Them(new MonHoc(ob.ToString()));
				gv.dsMonHoc = mh;
			}
			return gv;
		}
        private void btnCancel_Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    public class GiaoVien
	{
		public string MaSo { get; set; }
		public string HoTen { get; set; }
		public DateTime NgaySinh;
		public DanhMucMonHoc dsMonHoc;
		public string GioiTinh;
		public string[] NgoaiNgu;
		public string SoDT;
		public string Mail;
		public GiaoVien()
		{
			dsMonHoc = new DanhMucMonHoc();
			NgoaiNgu = new string[10];
		}
		public GiaoVien(string maso, string hoten, DateTime ngaySinh, DanhMucMonHoc ds,string gt,string []nn,string sdt,string mail)
		{
			this.MaSo = maso;
			this.HoTen = hoten;
			this.NgaySinh = ngaySinh;
			this.dsMonHoc = ds;
			this.GioiTinh = gt;
			this.NgoaiNgu = nn;
			this.SoDT = sdt;
			this.Mail = mail;
		}
		public override string ToString()
		{
			string s = "Mã Số " + MaSo + "\n" + "Họ Tên" + HoTen + "\n"
				+ "Ngày Sinh" + NgaySinh.ToString() + "\n"
				+ "Giới Tính" + GioiTinh + "\n"
				+ "Số ĐT" + SoDT + "\n"
				+ "Mail:" + Mail + "\n";
			string sngoaingu = "Ngoại Ngữ:";
			foreach (string t in NgoaiNgu)
				sngoaingu += t + ";";
			string MonDay = "Danh Sách Môn Dạy: ";
			foreach (MonHoc mh in dsMonHoc.ds)
				MonDay += mh + ";";
			s += "\n" + sngoaingu +"\n"+ MonDay;
			return s;
		}
													
	}
	public class DanhMucMonHoc
	{
		public ArrayList ds;
		public DanhMucMonHoc()
		{
			ds = new ArrayList();
		}
		public MonHoc this[int index]
		{
			get { return ds[index] as MonHoc; }
			set {ds[index] = value;}
		}
		public void Them (MonHoc mh )
		{
			ds.Add(mh);
		}
		public override string ToString()
		{
			string s = "Danh Sách Môn Học : ";
			foreach (object mh in ds)
			{
				s += mh as MonHoc + ";";
			}
			return s;
		}
	}
	public class MonHoc
	{
		public int Id { get; set; }
		public string TenMH { get; set; }
		public int SoTC { get; set; }
		public MonHoc()
		{
		}
		public MonHoc(string ten)
		{
			this.TenMH = ten;
		}
		public MonHoc(int id, string ten, int tc)
		{
			this.Id = id;
			this.TenMH = ten;
			this.SoTC = tc;
		}
		public override string ToString()
		{
			return TenMH;
		}
	}
	
}
