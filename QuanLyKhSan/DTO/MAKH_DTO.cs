using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhSan.DTO
{
    class MAKH_DTO
    {
        private int maKH;

        public int MaKH { get => maKH; set => maKH = value; }
        public MAKH_DTO(int maKH)
        {
            this.maKH = maKH;
        }
        public MAKH_DTO(DataRow row)
        {
            Int32.TryParse(row["MAKH"].ToString(), out this.maKH);
        }
    }
}
