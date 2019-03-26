using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhSan.DTO
{
    class ThuePhongDTO
    {
        private int maTH;
        private int maKH;
        private string tenKH;
        private int maPH;
        private DateTime ngayBD;
        private DateTime ngayTr;
        private double datCoc;

        public int MaTH { get => maTH; set => maTH = value; }
        public int MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public int MaPH { get => maPH; set => maPH = value; }
        public DateTime NgayBD { get => ngayBD; set => ngayBD = value; }
        public DateTime NgayTr { get => ngayTr; set => ngayTr = value; }
        public double DatCoc { get => datCoc; set => datCoc = value; }


        public ThuePhongDTO(int maTH,int maKH,string tenKH,int maPH,DateTime ngayBD,DateTime ngayTr,double datCoc)
        {
            this.maTH = maTH;
            this.maKH = maKH;
            this.tenKH = tenKH;
            this.maPH = maPH;
            this.ngayBD = ngayBD;
            this.ngayTr = ngayTr;
            this.datCoc = datCoc;
        }

        public ThuePhongDTO(DataRow row)
        {
            Int32.TryParse(row["MATH"].ToString(), out this.maTH);
            Int32.TryParse(row["MAKH"].ToString(), out this.maKH);
            this.tenKH = row["TENKH"].ToString();
            Int32.TryParse(row["MAPH"].ToString(), out this.maPH);
            DateTime.TryParse(row["NGAYBDTHUE"].ToString(), out this.ngayBD);
            DateTime.TryParse(row["NGAYTRA"].ToString(), out this.ngayTr);
            double.TryParse(row["DATCOC"].ToString(), out this.datCoc);
        }
    }
}
