using System.Data;

namespace QuanLyKhSan.DAO
{
    internal class MaNV_DTO
    {
        private DataRow item;

        public MaNV_DTO(DataRow item)
        {
            this.item = item;
        }
    }
}