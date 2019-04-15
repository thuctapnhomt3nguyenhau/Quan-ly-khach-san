using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhSan.DTO
{
    class MAL_DTO
    {
        private int maL;
        public int MaL { get => maL; set => maL = value; }
        public MAL_DTO(int maL)
        {
            this.maL = maL;
        }
        public MAL_DTO(DataRow row)
        {
            Int32.TryParse(row["MAL"].ToString(), out this.maL);
        }
    }
  
}
