using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhSan.DAO;
namespace QuanLyKhSan.GUI
{
    public partial class ucDichVu : Form
    {
        BindingSource dichVuList = new BindingSource();
        public ucDichVu()
        {
            InitializeComponent();
            LoadingFirstTime();
        }
        ////////////////////////////// LOADING FOR FIRST TIME ////////////////////////////

        public void LoadingFirstTime()
        {
            dgvDichVu.DataSource = dichVuList;
            LoadListDichVu();
            EditDataGridView();
            BindingDataToFrom();
        }

        public void LoadListDichVu()
        {
            try
            {
                dichVuList.DataSource = DichVuDAO.Instance.GetAllDichVu();
            }
            catch (Exception err)
            {
                MessageBox.Show("Không tìm thấy danh sách dịch vụ. Vui lòng khởi động lại!");
                Console.WriteLine(err);
            }
        }

        public void EditDataGridView()
        {
            dgvDichVu.Columns["maDichVu"].HeaderText = "Mã dịch vụ";
            dgvDichVu.Columns["tenDichVu"].HeaderText = "Tên dịch vụ";
            dgvDichVu.Columns["giaTien"].HeaderText = "Giá tiền";

        }

        public void BindingDataToFrom()
        {
            txtGiatien.DataBindings.Add(new Binding("Text", dgvDichVu.DataSource, "giaTien", true, DataSourceUpdateMode.Never));
            lblMaDV.DataBindings.Add(new Binding("Text", dgvDichVu.DataSource, "maDichVu", true, DataSourceUpdateMode.Never));
            txtTenDV.DataBindings.Add(new Binding("Text", dgvDichVu.DataSource, "tenDichVu", true, DataSourceUpdateMode.Never));

        }

        ////////////////////////////// Handle Event Click ////////////////////////////
        
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reset()
        {
            lblMaDV.Text = "";
            txtTenDV.Text = "";
            txtGiatien.Text = "";
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
            LoadListDichVu();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            try
            {
                if (searchValue == "") {
                    MessageBox.Show("Chưa nhập thông tin tìm kiếm");
                    return;
                }
                dgvDichVu.DataSource = DichVuDAO.Instance.SearchDichVu(searchValue);
            } catch (Exception error)
            {
                MessageBox.Show("Xảy ra lỗi! Vui lòng thực hiện lại");
                Console.WriteLine(error);
                // Do something here if error
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa ", "Cảnh báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    int maDichVu;
                    Int32.TryParse(lblMaDV.Text.ToString(), out maDichVu);
                    DichVuDAO.Instance.DeleteDichVu(maDichVu);
                    MessageBox.Show("Xóa dịch vụ thành công!");
                    LoadListDichVu(); 
                } catch (Exception error)
                {
                    MessageBox.Show("Xảy ra lỗi! Vui lòng thực hiện lại");
                    Console.WriteLine(error);
                    // Do something here if error
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                float giaDichVu;
                string tenDichVu = txtTenDV.Text;
                float.TryParse(txtGiatien.Text.ToString(), out giaDichVu);
                if (MessageBox.Show("Bạn có thật sự muốn thêm dịch vụ có tên là: " + tenDichVu, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    DichVuDAO.Instance.InsertDichVu(tenDichVu, giaDichVu);
                    MessageBox.Show("Thêm dịch vụ thành công");
                    LoadListDichVu();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Xảy ra lỗi! Vui lòng thực hiện lại");
                Console.WriteLine(error);
                // Do something here if error
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int maDichVu;
                float giaDichVu;
                string tenDichVu = txtTenDV.Text;
                float.TryParse(txtGiatien.Text.ToString(), out giaDichVu);
                Int32.TryParse(lblMaDV.Text.ToString(), out maDichVu);
                if (MessageBox.Show("Cập nhật dịch vụ có id là: " + maDichVu, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    DichVuDAO.Instance.UpdateDichVu(maDichVu, tenDichVu, giaDichVu);
                    MessageBox.Show("Cập nhật dịch vụ thành công");
                    LoadListDichVu();
                }
            } catch (Exception error)
            {
                MessageBox.Show("Xảy ra lỗi! Vui lòng thực hiện lại");
                Console.WriteLine(error);
                // Do something here if error

            }
        }
    }
}
