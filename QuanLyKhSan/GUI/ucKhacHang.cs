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
    public partial class ucKhacHang : Form
    {
        BindingSource KhachHangList = new BindingSource();
        public ucKhacHang()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            dgvKhachHang.DataSource = KhachHangList;
            LoadListKhachHang();
            AddBinding();
        }

        private void AddBinding()
        {
            lblMakhach.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "MAKH", true, DataSourceUpdateMode.Never));
            txtTenKH.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "TENKH", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "DIACHI", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "SDT", true, DataSourceUpdateMode.Never));
        }

        private void LoadListKhachHang()
        {
            KhachHangList.DataSource = KhachHangDAO.Instance.GetKhachHang();
            EditDataGridView();
        }

        private void EditDataGridView()
        {
            dgvKhachHang.Columns["MAKH"].Visible = false;
            dgvKhachHang.Columns["TENKH"].HeaderText = "Họ Tên khách hàng";
            dgvKhachHang.Columns["TENKH"].Width = 300;
            dgvKhachHang.Columns["DIACHI"].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns["DIACHI"].Width = 500;
            dgvKhachHang.Columns["SDT"].HeaderText = "Số điện thoại";
            dgvKhachHang.Columns["SDT"].Width = 200;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            long check;
            if (MessageBox.Show("Bạn có thật sự muốn thêm khách hàng có tên là: " + txtTenKH.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtTenKH.Text == "" || txtSDT.Text == "" || txtDiaChi.Text == "" || Int64.TryParse(txtSDT.Text, out check) == false || txtSDT.Text.Length != 10)
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                    //                    LoadListNV();
                }
                else
                {
                    string tenkh = txtTenKH.Text;
                    string diachi = txtDiaChi.Text;
                    string sdt = txtSDT.Text;
                    if (KhachHangDAO.Instance.InsertKhachHang(tenkh, diachi, sdt))
                    {
                        MessageBox.Show("Thêm thông tin thành công! ");
                        LoadListKhachHang();
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
            long check;
            if (MessageBox.Show("Bạn có thật sự muốn sửa khách hàng có tên là: " + txtTenKH.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtTenKH.Text == "" || txtSDT.Text == "" || txtDiaChi.Text == "" || Int64.TryParse(txtSDT.Text, out check) == false || txtSDT.Text.Length != 10)
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                    //                    LoadListNV();
                }
                else
                {
                    int makh;
                    Int32.TryParse(lblMakhach.Text, out makh);
                    string tenkh = txtTenKH.Text;
                    string diachi = txtDiaChi.Text;
                    string sdt = txtSDT.Text;
                    if (KhachHangDAO.Instance.UpdateKhachHang(makh,tenkh, diachi, sdt))
                    {
                        MessageBox.Show("Sửa thông tin thành công! ");
                        LoadListKhachHang();
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
            if (MessageBox.Show("Bạn có thật sự muốn xóa khách hàng có tên là: " + txtTenKH.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int makh;
                Int32.TryParse(lblMakhach.Text, out makh);
                if (KhachHangDAO.Instance.DeleteKhachHang(makh))
                {
                    MessageBox.Show("Xóa thông tin thành công! ");
                    LoadListKhachHang();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa thông tin! ");
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            LoadListKhachHang();
        }

        void Reset()
        {
            lblMakhach.Text = null;
            txtTenKH.Text = null;
            txtDiaChi.Text = null;
            txtSDT.Text = null;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") MessageBox.Show("Chưa nhập thông tin tìm kiếm");
            string str = txtSearch.Text;
            dgvKhachHang.DataSource = KhachHangList;
            KhachHangList.DataSource = KhachHangDAO.Instance.SearchKhachHang(str);
        }
    }
}
