
using QuanLyKhSan.DTO;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhSan.DAO
{
    class SuDungDVDAO
    {
        private static SuDungDVDAO instance;

        internal static SuDungDVDAO Instance
        {
            get { if (instance == null) instance = new SuDungDVDAO(); return instance; }
            private set { instance = value; }
        }
        //lấy danh sách 
        // danh sách sử dụng Dv
        public List<SuDungDVDTO> GetAllDSSD()
        {
            List<SuDungDVDTO> list = new List<SuDungDVDTO>();
            try
            {
                DataTable data = DataProvider.Instance.ExecuteQuery("USP_SUDUNGDV_GetDS");
                foreach (DataRow row in data.Rows)
                {
                    SuDungDVDTO sddv = new SuDungDVDTO(row);
                    list.Add(sddv);
                }

            }
            catch (Exception e)
            {
                // Do some thing here if error
                Console.WriteLine(e);
            }
            return list;
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
        public List<MADV_DTO> GetListMaDV()
        {
            List<MADV_DTO> maDichVuList = new List<MADV_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT MADV FROM dbo.DICHVU");
            foreach (DataRow item in data.Rows)
            {
                MADV_DTO maDichVu = new MADV_DTO(item);
                maDichVuList.Add(maDichVu);
            }
            return maDichVuList;
        }
        // thêm 1 dịch vụ su dụng
        public bool InsertSDDichVu(int maTH, int maDV ,DateTime ngaySD, float datCoc)
        {

                int result = DataProvider.Instance.ExecuteNonQuery("EXEC USP_SUDUNGDV_Insert @maTH , @maDV , @ngaySD , @datCoc", new object[] { maTH, maDV, ngaySD, datCoc });
                return result > 0;

        }
        //xóa 1 dịch vụ sử dụng
        public bool DeleteSDDichVu(int maSuDung)
        {
            try
            {
                DataProvider.Instance.ExecuteNonQuery("USP_SUDUNGDV_Delete @maSuDung", new object[] { maSuDung });
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
        //cập nhật 
        public bool UpdateSDDichVu(int maSuDung, int maTH, int maDV, DateTime ngaySD, float datCoc)
        {
            try
            {
                DataProvider.Instance.ExecuteNonQuery("USP_SUDUNGDV_Update @maSuDung , @maTH , @maDV , @ngaySD , @datCoc", new object[] { maSuDung, maTH, maDV, ngaySD, datCoc });
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
        //searech 
        public List<SuDungDVDTO> SearchSDDichVu(string search)
        {
            List<SuDungDVDTO> list = new List<SuDungDVDTO>();
            try
            {
                DataTable data = DataProvider.Instance.ExecuteQuery("USP_SUDUNGDV_Search @search", new object[] { search });
                foreach (DataRow row in data.Rows)
                {
                    SuDungDVDTO sddv = new SuDungDVDTO(row);
                    list.Add(sddv);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return list;
        }
    }
}
