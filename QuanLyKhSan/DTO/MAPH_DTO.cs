using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhSan.DTO
{
    class MAPH_DTO
    {
        private int maPH;

        public int MaPH { get => maPH; set => maPH = value; }
        public MAPH_DTO(int maPH)
        {
            this.maPH = maPH;
        }
        public MAPH_DTO(DataRow row)
        {
            Int32.TryParse(row["MAPH"].ToString(), out this.maPH);
        }
    }
}
