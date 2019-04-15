using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhSan.DTO
{
    class PhongDTO
    {
        private int maPhong;
        private string tenPhong;
        private int maLoaiPhong;
        private int giaThue;

        public int MaPhong { get => maPhong; set => maPhong = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public int MaLoaiPhong { get => maLoaiPhong; set => maLoaiPhong = value; }
        public int GiaThue { get => giaThue; set => giaThue = value; }

        public PhongDTO(int maPhong, string tenPhong, int maLoaiPhong, int giaThue)
        {
            this.MaPhong = maPhong;
            this.TenPhong = tenPhong;
            this.MaLoaiPhong = maLoaiPhong;
            this.GiaThue = giaThue;
        }
        public PhongDTO(DataRow row)
        {
            Int32.TryParse(row["MAPH"].ToString(), out this.maPhong);

            this.TenPhong = row["TENPH"].ToString();

            Int32.TryParse(row["MAL"].ToString(), out this.maLoaiPhong);

            Int32.TryParse(row["GIATHUE"].ToString(), out this.giaThue);    
        }

    }
}

