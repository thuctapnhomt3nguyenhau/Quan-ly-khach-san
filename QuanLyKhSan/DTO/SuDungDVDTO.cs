using System;
using System.Data;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhSan.DTO
{
    class SuDungDVDTO
    {
        private int maSD;
        private int maTH;
        private int maDV;
        private DateTime ngaySD;
        private float datCoc;

        public int MaSD { get => maSD; set => maSD = value; }
        public int MaTH { get => maTH; set => maTH = value; }
        public int MaDV { get => maDV; set => maDV = value; }
        public DateTime NgaySD { get => ngaySD; set => ngaySD = value; }
        public float DatCoc { get => datCoc; set => datCoc = value; }

        public SuDungDVDTO(int maSD , int maTH , int maDV , DateTime ngaySD , float datCoc)
        {
            this.maSD = maSD;
            this.maTH = maTH;
            this.maDV = maDV;
            this.ngaySD = ngaySD;
            this.datCoc = datCoc;
        } 
        public SuDungDVDTO(DataRow row)
        {
            Int32.TryParse(row["MASD"].ToString(), out this.maSD);
            Int32.TryParse(row["MATH"].ToString(), out this.maTH);
            Int32.TryParse(row["MADV"].ToString(), out this.maDV);
            this.ngaySD = (DateTime)row["NGAYSD"];
            float.TryParse(row["DATCOC"].ToString(), out this.datCoc);
        }
    }

}
