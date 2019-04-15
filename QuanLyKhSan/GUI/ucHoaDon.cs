using System;
using QuanLyKhSan.DAO;
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
    public partial class ucHoaDon : Form
    {
        BindingSource HDList = new BindingSource();

        public ucHoaDon()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            dgvHoaDon.DataSource = HDList;
            LoadListHD();
            AddBinding();
            LoadIntoComBoBoxTH(cboMathue);
            LoadIntoComBoBoxNV(cboMaNV);
        }
        public void LoadListHD()
        {
            HDList.DataSource = HoaDonDAO.Instance.GetDSHD();
            
        }
        public void LoadIntoComBoBoxTH(ComboBox cb)
        {
            cb.DataSource = HoaDonDAO.Instance.GetListMaTH();
            cb.DisplayMember = "MATH";
        }
        public void LoadIntoComBoBoxNV(ComboBox cb)
        {
            cb.DataSource = HoaDonDAO.Instance.GetListMaNV();
            cb.DisplayMember = "MANV";
        }
        public void AddBinding()
        {
            lblMaHD.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "MAHD", true, DataSourceUpdateMode.Never));
            cboMathue.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "MATH", true, DataSourceUpdateMode.Never));
            cboMaNV.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "MANV", true, DataSourceUpdateMode.Never));
            dtpNgayTT.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "NGAYTT", true, DataSourceUpdateMode.Never));
            txtThanhtien.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "THANHT", true, DataSourceUpdateMode.Never));
            txtGhiChu.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "GHICHU", true, DataSourceUpdateMode.Never));

        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            double check;
            if (MessageBox.Show("Bạn có thật sự muốn thêm hóa đơn có mã là: " + lblMaHD.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (cboMathue.Text == "" || cboMaNV.Text == "" || dtpNgayTT.Text == "" || txtGhiChu.Text == "" || txtThanhtien.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");

                }
                else
                {
                    int maHD;
                    Int32.TryParse(lblMaHD.Text, out maHD);
                    int maThue;
                    Int32.TryParse(cboMathue.Text, out maThue);
                    int maNV;
                    Int32.TryParse(cboMaNV.Text, out maNV);
                    DateTime ngayTT;
                    DateTime.TryParse(dtpNgayTT.Text, out ngayTT);
                    float thanhT;
                    float.TryParse(txtThanhtien.Text.ToString(), out thanhT);
                    string ghiChu = txtGhiChu.Text;
                    if (HoaDonDAO.Instance.InsertHD(maThue, maNV, ngayTT, thanhT , ghiChu))
                    {
                        MessageBox.Show("Thêm thông tin thành công! ");
                        LoadListHD();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm thông tin! ");
                    }
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            Double check;
            if (MessageBox.Show("Bạn có thật sự muốn sửa hóa đơn có mã là: " + lblMaHD.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (cboMathue.Text == "" || cboMaNV.Text == "" || dtpNgayTT.Text == "" || txtGhiChu.Text == "" || txtThanhtien.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                    //                    LoadListNV();
                }
                else
                {
                    int maHD;
                    Int32.TryParse(lblMaHD.Text, out maHD);
                    int maThue;
                    Int32.TryParse(cboMathue.Text, out maThue);
                    int maNV;
                    Int32.TryParse(cboMaNV.Text, out maNV);
                    DateTime ngayTT;
                    DateTime.TryParse(dtpNgayTT.Text, out ngayTT);
                    float thanhT;
                    float.TryParse(txtThanhtien.Text.ToString(), out thanhT);
                    string ghiChu = txtGhiChu.Text;
                    if (HoaDonDAO.Instance.UpdateHD(maHD, maThue, maNV, ngayTT , thanhT , ghiChu))
                    {
                        MessageBox.Show("Sửa thông tin thành công! ");
                        LoadListHD();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi sửa thông tin! ");
                    }
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa hóa đơn có mã là: " + lblMaHD.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int maHD;
                Int32.TryParse(lblMaHD.Text, out maHD);
                if (HoaDonDAO.Instance.DeleteHD(maHD))
                {
                    MessageBox.Show("Xóa thông tin thành công! ");
                    LoadListHD();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa thông tin! ");
                }
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            LoadListHD();
        }
        void Reset()
        {
            lblMaHD.Text = null;
            cboMathue.Text = null;
            cboMaNV.Text = null;
            dtpNgayTT.Text = null;
            txtThanhtien.Text = null;
            txtGhiChu.Text = null;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") MessageBox.Show("Chưa nhập thông tin tìm kiếm");
            string str = txtSearch.Text;
            dgvHoaDon.DataSource = HDList;
            HDList.DataSource = HoaDonDAO.Instance.SearchHD(str);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
