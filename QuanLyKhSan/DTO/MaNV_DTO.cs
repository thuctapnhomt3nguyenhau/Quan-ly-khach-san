using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhSan.DTO
{
    class MaNV_DTO
    {
        private int maNV;

        public int MaNV { get => maNV; set => maNV = value; }

        public MaNV_DTO(int maNV)
        {
            this.maNV = maNV;
        }

        public MaNV_DTO(DataRow row)
        {
            Int32.TryParse(row["MANV"].ToString(), out this.maNV);
        }
    }
}
