using QuanLyKhSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhSan.DAO
{
    class ThuePhongDAO
    {
        private static ThuePhongDAO instance;

        internal static ThuePhongDAO Instance
        {
            get { if (instance == null) instance = new ThuePhongDAO(); return instance; }
            private set { instance = value; }
        }
        public List<ThuePhongDTO> GetThuePhong()
        {
            List<ThuePhongDTO> list = new List<ThuePhongDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.USP_GetDSThuePhong");
            foreach (DataRow item in data.Rows)
            {
                ThuePhongDTO thuephong = new ThuePhongDTO(item);
                list.Add(thuephong);
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
        public List<MAPH_DTO> GetListMaPH()
        {
            List<MAPH_DTO> maPhongList = new List<MAPH_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT MAPH FROM dbo.PHONG");
            foreach (DataRow item in data.Rows)
            {
                MAPH_DTO maPhong = new MAPH_DTO(item);
                maPhongList.Add(maPhong);
            }
            return maPhongList;
        }
        public List<MAKH_DTO> GetListMaKH()
        {
            List<MAKH_DTO> maKhachList = new List<MAKH_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT MAKH FROM dbo.KHACHHANG");
            foreach (DataRow item in data.Rows)
            {
                MAKH_DTO maKhach = new MAKH_DTO(item);
                maKhachList.Add(maKhach);
            }
            return maKhachList;
        }
        public bool InsertThuePhong(int makh, int maph, DateTime ngaybd, DateTime ngaytr, double datcoc)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_InsertThuePhong @makh , @maph , @ngaybdthue , @ngaytra , @datcoc ", new object[] { makh, maph, ngaybd, ngaytr, datcoc });

            return result > 0;
        }
        public bool UpdateThuePhong(int math,int makh, int maph, DateTime ngaybd, DateTime ngaytr, double datcoc)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_UpdateThuePhong @math , @makh , @maph , @ngaybdthue , @ngaytra , @datcoc ", new object[] { math, makh, maph, ngaybd, ngaytr, datcoc });

            return result > 0;
        }
        public bool DeleteThuePhong(int math)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_DeleteThuePhong @math ", new object[] { math });

            return result > 0;
        }
        public List<ThuePhongDTO> SearchThuePhong(string str)
        {
            List<ThuePhongDTO> ThuePhongList = new List<ThuePhongDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_SearchThuePhong @search ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                ThuePhongDTO ThuePhong = new ThuePhongDTO(item);
                ThuePhongList.Add(ThuePhong);
            }
            return ThuePhongList;
        }
    }
}
