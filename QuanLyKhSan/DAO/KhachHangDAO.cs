using QuanLyKhSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhSan.DAO
{
    class KhachHangDAO
    {
        private static KhachHangDAO instance;

        internal static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return instance; }
            private set { instance = value; }
        }
        public List<KhachHangDTO> GetKhachHang()
        {
            List<KhachHangDTO> list = new List<KhachHangDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.USP_GetListKhachHang");
            foreach (DataRow item in data.Rows)
            {
                KhachHangDTO khachhang = new KhachHangDTO(item);
                list.Add(khachhang);
            }
            return list;
        }

        public bool InsertKhachHang(string tenkh, string diachi, string sdt)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_InsertKhachHang @tenkh , @diachi , @sdt ", new object[] { tenkh, diachi, sdt });

            return result > 0;
        }
        public bool UpdateKhachHang(int makh, string tenkh, string diachi, string sdt)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_UpdateKhachHang @makh , @tenkh , @diachi , @sdt ", new object[] { makh, tenkh, diachi, sdt });

            return result > 0;
        }
        public bool DeleteKhachHang(int makh)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_DeleteKhachHang @makh ", new object[] { makh });

            return result > 0;
        }
        public List<KhachHangDTO> SearchKhachHang(string str)
        {
            List<KhachHangDTO> KhachHangList = new List<KhachHangDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_SearchKhachHang @search ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                KhachHangDTO Khach = new KhachHangDTO(item);
                KhachHangList.Add(Khach);
            }
            return KhachHangList;
        }
    }
}
