using QuanLyKhSan.DTO;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhSan.DAO
{
    class NhanVienDAO
    {
        public static NhanVienDAO instance;

        internal static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
            private set { instance = value; }
        }
        public List<NhanVienDTO> GetNV()
        {
            List<NhanVienDTO> list = new List<NhanVienDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.USP_GetDSNV");
            foreach (DataRow item in data.Rows)
            {
                NhanVienDTO nv = new NhanVienDTO(item);
                list.Add(nv);
            }
            return list;

        }
        public List<MaNV_DTO> GetListMaNV()
        {
            List<MaNV_DTO> maLopList = new List<MaNV_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT MANV FROM dbo.NHANVIEN");
            foreach (DataRow item in data.Rows)
            {
                MaNV_DTO maLop = new MaNV_DTO(item);
                maLopList.Add(maLop);
            }
            return maLopList;
        }
        public bool InsertNv(string hoten, DateTime ngsinh, string gioitinh, string diachi , string sdt, int luong)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_InsertNV @hoten , @ngsinh  , @gioitinh , @diachi , @sdt , @luong ", new object[] { hoten, ngsinh, gioitinh, diachi, sdt, luong });

            return result > 0;
        }
        public bool UpdateNV(string hoten, DateTime ngsinh, string gioitinh, string diachi, string sdt, int luong, int manv)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_UpdateNV @manv , @hoten , @ngsinh , @gioitinh , @diachi , @sdt , @luong ", new object[] { manv,hoten, ngsinh, gioitinh, diachi, sdt, luong });

            return result > 0;
        }
        public bool DeleteNV(int manv)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_DeleteNV @manv ", new object[] { manv });

            return result > 0;
        }
        public List<NhanVienDTO> SearchNV(string str)
        {
            List<NhanVienDTO> NvList = new List<NhanVienDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_SearchNV @search ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                NhanVienDTO NhanVien = new NhanVienDTO(item);
                NvList.Add(NhanVien);
            }
            return NvList;
        }

    }
}
