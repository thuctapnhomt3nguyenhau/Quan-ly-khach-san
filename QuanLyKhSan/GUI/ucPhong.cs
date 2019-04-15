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

namespace QuanLyKhSan.GUI
{
    public partial class ucPhong : Form
    {
        BindingSource PList = new BindingSource();
        public ucPhong()
        {
            InitializeComponent();
            Load();
        }

        void Load()
        {
            dgvPhong.DataSource = PList;
            LoadListP();
            AddBinding();
            LoadIntoComBoBoxMaL(cboMaL);
        }

        private void LoadIntoComBoBoxMaL(ComboBox cboMaL)
        {
            cboMaL.DataSource = PhongDAO.Instance.GetlistMaL();
            cboMaL.DisplayMember = "MAL";
        }

        private void LoadListP()
        {
            PList.DataSource = PhongDAO.Instance.GetP();
            EditDataGridView();
        }
        void AddBinding()
        {
            lblMaphong.DataBindings.Add(new Binding("Text", dgvPhong.DataSource, "MAPHONG", true, DataSourceUpdateMode.Never));
            txtTenPhong.DataBindings.Add(new Binding("Text", dgvPhong.DataSource, "TENPHONG", true, DataSourceUpdateMode.Never));
            cboMaL.DataBindings.Add(new Binding("Text", dgvPhong.DataSource, "MALOAIPHONG", true, DataSourceUpdateMode.Never));
            txtGiaThue.DataBindings.Add(new Binding("Text", dgvPhong.DataSource, "GIATHUE", true, DataSourceUpdateMode.Never));
        }
        private void EditDataGridView()
        {
            dgvPhong.Columns["MAPHONG"].Visible = true;
            dgvPhong.Columns["TENPHONG"].HeaderText = "Tên Phòng";
            dgvPhong.Columns["MALOAIPHONG"].HeaderText = "Mã loại Phòng";
            dgvPhong.Columns["GIATHUE"].HeaderText = "Giá Phòng";
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") MessageBox.Show("Chưa nhập thông tin tìm kiếm");
            string str = txtSearch.Text;
            dgvPhong.DataSource = PList;
            PList.DataSource = PhongDAO.Instance.SearchP(str);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            long check;
            if (MessageBox.Show("Bạn có thật sự muốn thêm phòng có tên là: " + txtTenPhong.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtTenPhong.Text == "" || cboMaL.Text == "" || txtGiaThue.Text == "" || Int64.TryParse(txtGiaThue.Text, out check) == false)
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");

                }
                else
                {
                    string tenPhong = txtTenPhong.Text;
                    int maL;
                    Int32.TryParse(cboMaL.Text, out maL);
                    int giaThue;
                    Int32.TryParse(txtGiaThue.Text, out giaThue);
                    if (PhongDAO.Instance.InsertP(tenPhong, maL, giaThue))
                    {
                        MessageBox.Show("Thêm phòng thành công! ");
                        LoadListP();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm phòng! ");
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            long check;
            if (MessageBox.Show("Bạn có thật sự muốn sửa phòng có tên là: " + txtTenPhong.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (lblMaphong.Text == "" || txtTenPhong.Text == "" || cboMaL.Text == "" || txtGiaThue.Text == "" || Int64.TryParse(txtGiaThue.Text, out check) == false)
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                }
                else
                {
                    int maP;
                    Int32.TryParse(lblMaP.Text, out maP);
                    string tenPhong = txtTenPhong.Text;
                    int maL;
                    Int32.TryParse(cboMaL.Text, out maL);
                    int giaThue;
                    Int32.TryParse(txtGiaThue.Text, out giaThue);
                    if (PhongDAO.Instance.UpdateP(maP, tenPhong, maL, giaThue))
                    {
                        MessageBox.Show("Sửa nhân phòng công! ");
                        LoadListP();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi sửa phòng! ");
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa phòng có mã là: " + txtTenPhong.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int maP;
                Int32.TryParse(lblMaphong.Text, out maP);
                if (PhongDAO.Instance.DeleteP(maP))
                {
                    MessageBox.Show("Xóa phòng thành công! ");
                    LoadListP();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa phòng! ");
                }
            }
        }
        void Reset()
        {
            lblMaphong.Text = "";
            txtTenPhong.Text = "";
            cboMaL.Text = "";
            txtGiaThue.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadListP();
        }

        private void btnHuy1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có thật sự muốn hủy các thao tac vừa nhập ", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Reset();
            }

        }
    }
}
 


