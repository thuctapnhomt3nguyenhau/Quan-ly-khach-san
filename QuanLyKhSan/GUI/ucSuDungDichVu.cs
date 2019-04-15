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
    public partial class ucSuDungDichVu : Form
    {
        BindingSource SDDVList = new BindingSource();
        public ucSuDungDichVu()
        {
            InitializeComponent();
            Load();
        }
         void Load()
        {
            dgvSDDV.DataSource = SDDVList;
            LoadListSDDV();
            AddBinding();
            LoadIntoComBoBoxTH(cboMaThue);
            LoadIntoComBoBoxDV(cboMadichvu);

        }
        public void LoadListSDDV()
        {
            SDDVList.DataSource = SuDungDVDAO.Instance.GetAllDSSD();
            EditDataGridView();
          
        }
        public void LoadIntoComBoBoxTH(ComboBox cb)
        {
            cb.DataSource = SuDungDVDAO.Instance.GetListMaTH();
            cb.DisplayMember = "MATH";
        }
        public void LoadIntoComBoBoxDV(ComboBox cb)
        {
            cb.DataSource = SuDungDVDAO.Instance.GetListMaDV();
            cb.DisplayMember = "MADV";
        }
       
        public void AddBinding()
        {
            lblmasudung.DataBindings.Add(new Binding("Text", dgvSDDV.DataSource, "MASD", true, DataSourceUpdateMode.Never));
            cboMaThue.DataBindings.Add(new Binding("Text", dgvSDDV.DataSource, "MATH", true, DataSourceUpdateMode.Never));
            cboMadichvu.DataBindings.Add(new Binding("Text", dgvSDDV.DataSource, "MADV", true, DataSourceUpdateMode.Never));
            dtpNgaySD.DataBindings.Add(new Binding("Text", dgvSDDV.DataSource, "NGAYSD", true, DataSourceUpdateMode.Never));
            txtDonGia.DataBindings.Add(new Binding("Text", dgvSDDV.DataSource, "DATCOC", true, DataSourceUpdateMode.Never));


        }

        private void EditDataGridView()
        {
            dgvSDDV.Columns["MASD"].Visible = false;
            dgvSDDV.Columns["MATH"].HeaderText = "Mã Thuê";
            dgvSDDV.Columns["MATH"].Width = 200;
            dgvSDDV.Columns["MADV"].HeaderText = "Mã Dịch Vụ";
            dgvSDDV.Columns["MADV"].Width = 200;
            dgvSDDV.Columns["NGAYSD"].HeaderText = "Ngày Sử Dụng";
            dgvSDDV.Columns["NGAYSD"].Width = 300;
            dgvSDDV.Columns["DATCOC"].HeaderText = "Đặt Cọc";
            dgvSDDV.Columns["DATCOC"].Width = 258;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Reset()
        {
            label.Text = "";
            cboMaThue.Text = "";
            cboMadichvu.Text = "";
            dtpNgaySD.Text = "";
            txtDonGia.Text = "";
            txtSearch.Text = "";
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hủy các thao tac vừa nhập ", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Reset();
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadListSDDV();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            try
            {
                if (search == "")
                {
                    MessageBox.Show("Chưa nhập thông tin tìm kiếm");
                    return;
                }
                dgvSDDV.DataSource = SuDungDVDAO.Instance.SearchSDDichVu(search);
            }
            catch (Exception error)
            {
                MessageBox.Show("Xảy ra lỗi! Vui lòng thực hiện lại");
                Console.WriteLine(error);

            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa ", "Cảnh báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    int maSuDung;
                    Int32.TryParse(label.Text.ToString(), out maSuDung);
                    SuDungDVDAO.Instance.DeleteSDDichVu(maSuDung);
                    MessageBox.Show("Xóa dịch vụ sử dụng thành công!");
                    LoadListSDDV();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Xảy ra lỗi! Vui lòng thực hiện lại");
                    Console.WriteLine(error);
                    // Do something here if error
                }
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            double check;
            if (MessageBox.Show("Bạn có thật sự muốn thêm dịch vụ có mã là: " + lblmasudung.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (cboMaThue.Text == "" || cboMadichvu.Text == "" || dtpNgaySD.Text == "" || txtDonGia.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");

                }
                else
                {
                    int maSuDung;
                    Int32.TryParse(label.Text, out maSuDung);
                    int maThue;
                    Int32.TryParse(cboMaThue.Text, out maThue);
                    int maDV;
                    Int32.TryParse(cboMadichvu.Text, out maDV);
                    DateTime ngaySD;
                    DateTime.TryParse(dtpNgaySD.Text, out ngaySD);
                    float datCoc;
                    float.TryParse(txtDonGia.Text.ToString(), out datCoc);
                    if (SuDungDVDAO.Instance.InsertSDDichVu(maThue, maDV, ngaySD, datCoc))
                    {
                        MessageBox.Show("Thêm thông tin thành công! ");
                        LoadListSDDV();
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
            try
            {
                int maSDDV;
                Int32.TryParse(label.Text.ToString(), out maSDDV);
                int maThue;
                Int32.TryParse(lbMathue.Text.ToString(), out maThue);
                int maDV;
                Int32.TryParse(lblMadichvu.Text.ToString(), out maDV);
                DateTime ngaySD;
                DateTime.TryParse(dtpNgaySD.Text, out ngaySD);
                float datCoc;
                float.TryParse(txtDonGia.Text.ToString(), out datCoc);

                if (MessageBox.Show("Cập nhật dịch vụ có id là: " + maSDDV, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    SuDungDVDAO.Instance.UpdateSDDichVu(maSDDV, maThue, maDV, ngaySD, datCoc);
                    MessageBox.Show("Cập nhật dịch vụ thành công");
                    LoadListSDDV();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Xảy ra lỗi! Vui lòng thực hiện lại");
                Console.WriteLine(error);
                

            }
        }

       
    }
}
