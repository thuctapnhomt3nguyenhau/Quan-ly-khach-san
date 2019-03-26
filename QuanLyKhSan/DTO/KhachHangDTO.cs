using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhSan.DTO
{
    class KhachHangDTO
    {
        private int makh;
        private string tenkh;
        private string diachi;
        private string sdt;

        public int Makh { get => makh; set => makh = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }

        public KhachHangDTO(int makh, string tenkh, string daichi, string sdt)
        {
            this.makh = makh;
            this.tenkh = tenkh;
            this.diachi = daichi;
            this.sdt = sdt;
        }
        public KhachHangDTO(DataRow row)
        {
            Int32.TryParse(row["MAKH"].ToString(), out this.makh);
            this.tenkh = row["TENKH"].ToString();
            this.diachi = row["DIACHI"].ToString();
            this.sdt = row["SDT"].ToString();
        }
    }
}
