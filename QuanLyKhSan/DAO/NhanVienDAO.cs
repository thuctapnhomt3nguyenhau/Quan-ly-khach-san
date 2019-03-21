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
        private static NhanVienDAO instance;

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
                NhanVienDTO sv = new NhanVienDTO(item);
                list.Add(sv);
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
    }
}
