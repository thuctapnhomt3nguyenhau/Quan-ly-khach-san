using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhSan.DTO
{
    class MADV_DTO
    {
        private int maDV;

        public int MaDV { get => maDV; set => maDV = value; }
        public MADV_DTO(int maDV)
        {
            this.maDV = maDV;
        }
        public MADV_DTO(DataRow row)
        {
            Int32.TryParse(row["MADV"].ToString(), out this.maDV);
        }
    }
}
