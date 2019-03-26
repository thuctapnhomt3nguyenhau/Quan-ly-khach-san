using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhSan.DTO
{
    class DichVuDTO
    {
        private int maDichVu;
        private string tenDichVu;
        private float giaTien;

        public int MaDichVu { get => maDichVu; set => maDichVu = value; }
        public string TenDichVu { get => tenDichVu; set => tenDichVu = value; }
        public float GiaTien { get => giaTien; set => giaTien = value; }

        public DichVuDTO()
        {
            // Default constructor
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maDichVu">Mã dịch vụ</param>
        /// <param name="tenDichVu">Tên dịch vụ</param>
        /// <param name="giaTien">Giá tiền</param>
        public DichVuDTO(int maDichVu, string tenDichVu, float giaTien)
        {
            this.maDichVu = maDichVu;
            this.tenDichVu = tenDichVu;
            this.giaTien = giaTien;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="row">row khi lấy dữ liệu từ Database</param>
        public DichVuDTO(DataRow row)
        {
            Int32.TryParse(row["MADV"].ToString(), out maDichVu);
            tenDichVu = row["TENDV"].ToString();
            float.TryParse(row["GIATIEN"].ToString(), out giaTien);
        }

    }
}
