using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhSan.DTO
{
    class LoaiPhongDTO
    {
        private int maLoai;
        private string tenLoai;
        private string ghiChu;

        public int MaLoai { get => maLoai; set => maLoai = value; }
        public string TenLoai { get => tenLoai; set => tenLoai = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }

        public LoaiPhongDTO(int maLoai, string tenLoai, string ghiChu)
        {
            this.maLoai = maLoai;
            this.tenLoai = tenLoai;
            this.ghiChu = ghiChu;
        }

        public LoaiPhongDTO(DataRow row)
        {
            Int32.TryParse(row["MAL"].ToString(), out this.maLoai);
            this.tenLoai = row["TENLOAI"].ToString();
            this.ghiChu = row["GHICHU"].ToString();
        }


    }
}
