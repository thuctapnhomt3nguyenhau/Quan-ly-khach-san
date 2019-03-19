using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhSan.GUI;

namespace QuanLyKhSan.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ucNhanVien f = new ucNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            ucPhong f = new ucPhong();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ucKhacHang f = new ucKhacHang();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void btnThuePhong_Click(object sender, EventArgs e)
        {
            ucThuePhong f = new ucThuePhong();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void btnLoaiPhong_Click(object sender, EventArgs e)
        {
            ucLoaiPhong f = new ucLoaiPhong();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            ucDichVu f = new ucDichVu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnSuDungDichVu_Click(object sender, EventArgs e)
        {
            ucSuDungDichVu f = new ucSuDungDichVu();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            ucHoaDon f = new ucHoaDon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
