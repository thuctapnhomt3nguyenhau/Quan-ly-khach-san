using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhSan.DTO
{
    class MATH_DTO
    {
        private int maTH;

        public int MaTH { get => maTH; set => maTH = value; }
        public MATH_DTO(int maTH)
        {
            this.maTH = maTH;
        }
        public MATH_DTO(DataRow row)
        {
            Int32.TryParse(row["MATH"].ToString(), out this.maTH);
        }
    }
}
