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
    public partial class ucThuePhong : Form
    {

        BindingSource ThuePhongList = new BindingSource();

        public ucThuePhong()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            dgvThuePhong.DataSource = ThuePhongList;
            LoadListThuePhong();
            AddBinding();
            LoadIntoComBoBoxPH(cboMaPhong);
            LoadIntoComBoBoxKH(cboMaKhach);
        }

        void LoadListThuePhong()
        {
            ThuePhongList.DataSource = ThuePhongDAO.Instance.GetThuePhong();
            EditDataGridView();
        }

        void LoadIntoComBoBoxPH(ComboBox cb)
        {
            cb.DataSource = ThuePhongDAO.Instance.GetListMaPH();
            cb.DisplayMember = "MAPH";
        }
        void LoadIntoComBoBoxKH(ComboBox cb)
        {
            cb.DataSource = ThuePhongDAO.Instance.GetListMaKH();
            cb.DisplayMember = "MAKH";
        }

        void AddBinding()
        {
            lblmathuephong.DataBindings.Add(new Binding("Text", dgvThuePhong.DataSource, "MATH", true, DataSourceUpdateMode.Never));
            cboMaKhach.DataBindings.Add(new Binding("Text", dgvThuePhong.DataSource, "MAKH", true, DataSourceUpdateMode.Never));
            cboMaPhong.DataBindings.Add(new Binding("Text", dgvThuePhong.DataSource, "MAPH", true, DataSourceUpdateMode.Never));
            txtDatCoc.DataBindings.Add(new Binding("Text", dgvThuePhong.DataSource, "DATCOC", true, DataSourceUpdateMode.Never));
            dtpNgayVao.DataBindings.Add(new Binding("Text", dgvThuePhong.DataSource, "NGAYBD", true, DataSourceUpdateMode.Never));
            dtpNgayRa.DataBindings.Add(new Binding("Text", dgvThuePhong.DataSource, "NGAYTR", true, DataSourceUpdateMode.Never));
        }

        private void EditDataGridView()
        {
            dgvThuePhong.Columns["MATH"].Visible = false;
            dgvThuePhong.Columns["MAKH"].Visible = false;
            dgvThuePhong.Columns["TENKH"].HeaderText = "Họ Tên khách hàng";
            dgvThuePhong.Columns["TENKH"].Width = 280;
            dgvThuePhong.Columns["MAPH"].HeaderText = "Mã phòng";
            dgvThuePhong.Columns["MAPH"].Width = 150;
            dgvThuePhong.Columns["DATCOC"].HeaderText = "Tiền đặt cọc";
            dgvThuePhong.Columns["DATCOC"].Width = 200;
            dgvThuePhong.Columns["NGAYBD"].HeaderText = "Ngày bắt đầu thuê";
            dgvThuePhong.Columns["NGAYBD"].Width = 170;
            dgvThuePhong.Columns["NGAYTR"].HeaderText = "Ngày trả";
            dgvThuePhong.Columns["NGAYTR"].Width = 170;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            double check;
            if (MessageBox.Show("Bạn có thật sự muốn thuê phòng cho khách hàng có mã là: " + cboMaKhach.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (cboMaPhong.Text == "" || cboMaKhach.Text == "" || txtDatCoc.Text == "" || double.TryParse(txtDatCoc.Text, out check) == false)
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                    //                    LoadListNV();
                }
                else
                {
                    int makh;
                    Int32.TryParse(cboMaKhach.Text, out makh);
                    DateTime ngaybd;
                    DateTime.TryParse(dtpNgayVao.Text, out ngaybd);
                    DateTime ngaytr;
                    DateTime.TryParse(dtpNgayRa.Text, out ngaytr);
                    int maph;
                    Int32.TryParse(cboMaPhong.Text, out maph);
                    double datcoc;
                    double.TryParse(txtDatCoc.Text, out datcoc);
                    if (ThuePhongDAO.Instance.InsertThuePhong(makh, maph, ngaybd, ngaytr, datcoc))
                    {
                        MessageBox.Show("Thêm thông tin thành công! ");
                        LoadListThuePhong();
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
            double check;
            if (MessageBox.Show("Bạn có thật sự muốn sửa thông tin thuê phòng có mã là: " + lblmathuephong.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (cboMaPhong.Text == "" || cboMaKhach.Text == "" || txtDatCoc.Text == "" || double.TryParse(txtDatCoc.Text, out check) == false)
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                    //                    LoadListNV();
                }
                else
                {
                    int math;
                    int.TryParse(lblmathuephong.Text, out math);
                    int makh;
                    Int32.TryParse(cboMaKhach.Text, out makh);
                    DateTime ngaybd;
                    DateTime.TryParse(dtpNgayVao.Text, out ngaybd);
                    DateTime ngaytr;
                    DateTime.TryParse(dtpNgayRa.Text, out ngaytr);
                    int maph;
                    Int32.TryParse(cboMaPhong.Text, out maph);
                    double datcoc;
                    double.TryParse(txtDatCoc.Text, out datcoc);
                    if (ThuePhongDAO.Instance.UpdateThuePhong(math,makh, maph, ngaybd, ngaytr, datcoc))
                    {
                        MessageBox.Show("Sửa thông tin thành công! ");
                        LoadListThuePhong();
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
            if (MessageBox.Show("Bạn có thật sự muốn xóa thông tin thuê phòng có mã là: " + lblmathuephong.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int math;
                Int32.TryParse(lblmathuephong.Text, out math);
                if (ThuePhongDAO.Instance.DeleteThuePhong(math))
                {
                    MessageBox.Show("Xóa thông tin thành công! ");
                    LoadListThuePhong();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa thông tin! ");
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            LoadListThuePhong();
        }

        void Reset()
        {
            lblmathuephong.Text = "";
            txtDatCoc.Text = "";
            dtpNgayVao.Value = DateTime.Now;
            dtpNgayRa.Value = DateTime.Now;
            LoadIntoComBoBoxPH(cboMaPhong);
            LoadIntoComBoBoxKH(cboMaKhach);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") MessageBox.Show("Chưa nhập thông tin tìm kiếm");
            string str = txtSearch.Text;
            dgvThuePhong.DataSource = ThuePhongList;
            ThuePhongList.DataSource = ThuePhongDAO.Instance.SearchThuePhong(str);
        }

       
    }
}
