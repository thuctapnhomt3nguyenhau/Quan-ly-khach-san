using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhSan.DTO
{
    class HoaDonDTO
    {
        private int maHD;
        private int maTH;
        private int maNV;
        private DateTime ngayTT;
        private float thanhT;
        private string ghiChu;

        public int MaHD { get => maHD; set => maHD = value; }
        public int MaTH { get => maTH; set => maTH = value; }
        public int MaNV { get => maNV; set => maNV = value; }
        public DateTime NgayTT { get => ngayTT; set => ngayTT = value; }
        public float ThanhT { get => thanhT; set => thanhT = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }

        public HoaDonDTO(int maHD, int maTH, int maNV, DateTime ngayTT, float thanhT ,string ghiChu)
        {
            this.maHD = maHD;
            this.maTH = maTH;
            this.maNV = maNV;
            this.ngayTT = ngayTT;
            this.thanhT = thanhT;
            this.ghiChu = ghiChu;
        }
        public HoaDonDTO(DataRow row)
        {
            Int32.TryParse(row["MAHD"].ToString(), out maHD);
            Int32.TryParse(row["MATH"].ToString(), out maTH);
            Int32.TryParse(row["MANV"].ToString(), out maNV);
            this.ngayTT = (DateTime)row["NGAYTT"];
            float.TryParse(row["THANHTIEN"].ToString(), out thanhT);
            ghiChu = row["GHICHU"].ToString();

        }
    }
}
