using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhSan.DAO;
using QuanLyKhSan.GUI;

namespace QuanLyKhSan.GUI
{
    public partial class ucLoaiPhong : Form
    {
        BindingSource LpList = new BindingSource();
        public ucLoaiPhong()
        {
            InitializeComponent();
            Load();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Load()
        {
            dgvLoaiPhong.DataSource = LpList;
            LoadListLP();
            AddBinding();
        }

        void LoadListLP()
        {
            LpList.DataSource = LoaiPhongDAO.Instance.GetLP();
        }

        void AddBinding()
        {
            lblmaloaiphong.DataBindings.Add(new Binding("Text", dgvLoaiPhong.DataSource, "maLoai", true, DataSourceUpdateMode.Never));
            txtTenLoai.DataBindings.Add(new Binding("Text", dgvLoaiPhong.DataSource, "tenLoai", true, DataSourceUpdateMode.Never));
            txtGhiChu.DataBindings.Add(new Binding("Text", dgvLoaiPhong.DataSource, "ghiChu", true, DataSourceUpdateMode.Never));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            long check;
            if (MessageBox.Show("Bạn có thật sự muốn thêm loại phòng có tên là: " + txtTenLoai.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtTenLoai.Text == "" || txtGhiChu.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                    //                    LoadListNV();
                }
                else
                {
                    string tenLoai = txtTenLoai.Text;
                    string ghiChu = txtGhiChu.Text;
                    if (LoaiPhongDAO.Instance.InseartLP(tenLoai, ghiChu))
                    {
                        MessageBox.Show("Thêm 1 loại phòng thành công! ");
                        LoadListLP();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm loại phòng! ");
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa loại phòng có tên là: " + txtTenLoai.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int maLoai;
                Int32.TryParse(lblMaLoai.Text, out maLoai);
                if (LoaiPhongDAO.Instance.DeleteLP(maLoai))
                {
                    MessageBox.Show("Xóa loại phòng thành công! ");
                    LoadListLP();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa loại phòng! ");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            long check;
            if (MessageBox.Show("Bạn có thật sự muốn sửa loại phòng có tên là: " + txtTenLoai.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtTenLoai.Text == "" || txtGhiChu.Text == "" )
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                }
                else
                {
                    int maLoai;
                    Int32.TryParse(lblmaloaiphong.Text, out maLoai);
                    string tenLoai = txtTenLoai.Text;
                    string ghiChu = txtGhiChu.Text;
                    if (LoaiPhongDAO.Instance.UpdateLP(maLoai, tenLoai, ghiChu))
                    {
                        MessageBox.Show("Sửa thông tin loại phòng thành công! ");
                        LoadListLP();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi sửa thông tin loại phòng! ");
                    }
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            LoadListLP();
        }

        void Reset()
        {
            lblmaloaiphong.Text = "";
            txtTenLoai.Text = "";
            txtGhiChu.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn hủy các thao tác vừa nhập ", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Reset();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") MessageBox.Show("Chưa nhập thông tin tìm kiếm");
            string str = txtSearch.Text;
            dgvLoaiPhong.DataSource = LpList;
            LpList.DataSource = LoaiPhongDAO.Instance.SearchLP(str);
        }
    }
}
