using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhSan.DTO
{
    class NhanVienDTO
    {
        private int maNV;
        private string tenNV;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string diaChi;
        private string soDT;
        private int luong;

        public int MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public int Luong { get => luong; set => luong = value; }

        public NhanVienDTO(int maNV, string tenNV, DateTime ngaySinh, string gioiTinh, string diaChi,  string soDT , int luong)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.SoDT = soDT;
            this.Luong = luong;
        }
        public NhanVienDTO(DataRow row)
        {
            Int32.TryParse(row["MANV"].ToString(), out this.maNV);
            this.tenNV = row["HOTEN"].ToString();
            this.ngaySinh = (DateTime)row["NGAYSINH"];
            this.gioiTinh = row["GIOITINH"].ToString();
            this.diaChi = row["DIACHI"].ToString();
            this.soDT = row["SDT"].ToString();
            Int32.TryParse(row["LUONG"].ToString(), out this.luong);



        }
    }
    
}
