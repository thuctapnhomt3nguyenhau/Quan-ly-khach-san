using QuanLyKhSan.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhSan.GUI
{
    public partial class ucNhanVien : Form
    {
       BindingSource NvList = new BindingSource();
        public ucNhanVien()
        {
           InitializeComponent();
            LoadFistTime();
        }
        private void LoadFistTime()
        {
            dgvNhanVien.DataSource = NvList;
            LoadListNV();
            AddBinding();

        }
        void LoadListNV()
        {
            //try
            //{
                NvList.DataSource = NhanVienDAO.Instance.GetNV();
            //}
            //catch (Exception err)
            //{
               // MessageBox.Show("Không tìm thấy danh sách thân nhân. Vui lòng khởi động lại!");
               // Console.WriteLine(err);
            //}
        }
        void AddBinding()
        {
            lblMaNhanVien.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "MANV", true, DataSourceUpdateMode.Never));
            txtHoTen.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "HOTEN", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            dtpNgaySinh.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "NGAYSINH", true, DataSourceUpdateMode.Never));
            txtDiachi.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "DIACHI", true, DataSourceUpdateMode.Never));
            txtLuong.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "LUONG", true, DataSourceUpdateMode.Never));
            var fmaleBinding = new Binding("Checked", dgvNhanVien.DataSource, "GIOITINH", true, DataSourceUpdateMode.Never);
            fmaleBinding.Format += (s, args) => args.Value = ((string)args.Value) == "Nữ";
            fmaleBinding.Parse += (s, args) => args.Value = (bool)args.Value ? "Nữ" : "Nam";
            radNu.DataBindings.Add(fmaleBinding);
            radNu.CheckedChanged += (s, args) => radNam.Checked = !radNu.Checked;
        }
      
      

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") MessageBox.Show("Chưa nhập thông tin tìm kiếm");
            string str = txtSearch.Text;
            dgvNhanVien.DataSource = NvList;
        //    NvList.DataSource = NhanVienDAO.Instance.SearchNV(str);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            long check;
            if (MessageBox.Show("Bạn có thật sự muốn thêm nhân viên có tên là: " + txtHoTen.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtHoTen.Text == "" || txtDiachi.Text == "" || txtLuong.Text == "" || txtSDT.Text == "" || Int64.TryParse(txtSDT.Text, out check) == false)
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                    //                    LoadListNV();
                }
                else
                {
                    string hoTen = txtHoTen.Text;
                    DateTime ngaySinh;
                    DateTime.TryParse(dtpNgaySinh.Text, out ngaySinh);
                    string diaChi = txtDiachi.Text;
                    string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
                    int luong;
                    Int32.TryParse(txtLuong.Text, out luong);
                    string sDT = txtSDT.Text; ;
                    //if (NhanVienDAO.Instance.InsertNV(hoTen, ngaySinh, gioiTinh, diaChi , sDT, luong))
                    //{
                    //    MessageBox.Show("Thêm nhân viên thành công! ");
                    //    LoadListNV();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Có lỗi khi thêm nhân viên! ");
                    //}
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LoadListNV();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên có tên là: " + txtHoTen.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int maNV;
                Int32.TryParse(lblMaNhanVien.Text, out maNV);
                //if (NhanVienDAO.Instance.DeleteNV(maNV))
                //{
                //    MessageBox.Show("Xóa nhân viên thành công! ");
                //    LoadListNV();
                //}
                //else
                //{
                //    MessageBox.Show("Có lỗi khi xóa nhân viên! ");
                //}
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") MessageBox.Show("Chưa nhập thông tin tìm kiếm");
            string str = txtSearch.Text;
            dgvNhanVien.DataSource = NvList;
            //NvList.DataSource = NhanVienDAO.Instance.SearchNV(str);
        }
        void Reset()
        {
            lblMaNhanVien.Text = "";
            txtHoTen.Text = "";
            txtLuong.Text = "";
            txtDiachi.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            txtSDT.Text = "";
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn hủy các thao tac vừa nhập ", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Reset();
            }
        }

        
    }
}
