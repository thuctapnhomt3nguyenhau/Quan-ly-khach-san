using System;
using System.Data;
using QuanLyKhSan.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhSan.DAO
{
    class HoaDonDAO
    {
        private static HoaDonDAO instance;

        internal static HoaDonDAO Instance
        {
            get { if (instance == null) instance = new HoaDonDAO(); return instance; }
            private set { instance = value; }
        }
        public List<HoaDonDTO> GetDSHD()
        {
            List<HoaDonDTO> list = new List<HoaDonDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.USP_HOADON_GETALL");
            foreach (DataRow item in data.Rows)
            {
                HoaDonDTO hd = new HoaDonDTO(item);
                list.Add(hd);
            }
            return list;
        }
        public List<MaNV_DTO> GetListMaNV()
        {
            List<MaNV_DTO> maNVList = new List<MaNV_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT MANV FROM dbo.NHANVIEN");
            foreach (DataRow item in data.Rows)
            {
                MaNV_DTO manv = new MaNV_DTO(item);
                maNVList.Add(manv);
            }
            return maNVList;
        }
        public List<MATH_DTO> GetListMaTH()
        {
            List<MATH_DTO> maThueList = new List<MATH_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT MATH FROM dbo.THUEPHONG");
            foreach (DataRow item in data.Rows)
            {
                MATH_DTO maThue = new MATH_DTO(item);
                maThueList.Add(maThue);
            }
            return maThueList;
        }
        public bool InsertHD(int maTH , int maNV , DateTime ngayTT ,float thanhT , string ghiChu)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_HOADON_INSERT @maTH , @maNV , @ngayTT , @thanhT , @ghiChu ", new object[] { maTH, maNV, ngayTT , thanhT , ghiChu });

            return result > 0;
        }
        public bool UpdateHD(int maHD,int maTH , int maNV, DateTime ngayTT, float thanhT, string ghiChu)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_HOADON_UPDATE @maHD , @maTH , @maNV , @ngayTT , @thanhT , @ghiChu ", new object[] { maHD, maTH, maNV, ngayTT, thanhT, ghiChu });

            return result > 0;
        }
        public bool DeleteHD(int maHD)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_HOADON_DELETE @maHD ", new object[] { maHD });

            return result > 0;
        }
        public List<HoaDonDTO> SearchHD(string str)
        {
            List<HoaDonDTO> HDList = new List<HoaDonDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_HOADON_SREACH @search ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                HoaDonDTO hoadon = new HoaDonDTO(item);
                HDList.Add(hoadon);
            }
            return HDList;
        }
    }
}
