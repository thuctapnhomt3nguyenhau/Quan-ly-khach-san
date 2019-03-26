using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhSan.DTO;
namespace QuanLyKhSan.DAO
{
    class DichVuDAO
    {
        private static DichVuDAO instance;

        internal static DichVuDAO Instance
        {
            get { if (instance == null) instance = new DichVuDAO(); return instance; }
            private set { instance = value; }
        }

        /// <summary>
        /// Lấy danh sách dịch vụ
        /// </summary>
        /// <returns>Danh sách dịch vụ</returns>
        public List<DichVuDTO> GetAllDichVu ()
        {
            List<DichVuDTO> list = new List<DichVuDTO>();
            try
            {
                DataTable data = DataProvider.Instance.ExecuteQuery("SP_DichVu_GetAll");
                foreach(DataRow row in data.Rows)
                {
                    DichVuDTO dv = new DichVuDTO(row);
                    list.Add(dv);
                } 

            } catch (Exception e)
            {
                // Do some thing here if error
                Console.WriteLine(e);
            }
            return list;
        }

        /// <summary>
        /// Thêm một dịch vụ
        /// </summary>
        /// <param name="tenDichVu">Tên dịch vụ</param>
        /// <param name="giaTien">Giá tiền</param>
        /// <returns>True or False</returns>
        public bool InsertDichVu( string tenDichVu, float giaTien)
        {
            try
            {
                DataProvider.Instance.ExecuteNonQuery("SP_DichVu_Insert @tenDichVu , @giaTien", new object[] { tenDichVu, giaTien });
                return true;
            } catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        /// <summary>
        /// Xóa một dịch vụ
        /// </summary>
        /// <param name="maDichVu">Mã dịch vụ</param>
        /// <returns>True nếu được và False nếu không</returns>
        public bool DeleteDichVu(int maDichVu)
        {
            try
            {
                DataProvider.Instance.ExecuteNonQuery("SP_DichVu_Delete @maDichVu", new object[] { maDichVu });
                return true;
            } catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        /// <summary>
        /// Cập nhật dịch vụ
        /// </summary>
        /// <param name="maDichVu">Mã dịch vụ</param>
        /// <param name="tenDichVu">Tên dịch vụ mới</param>
        /// <param name="giaTien">Giá tiền mới</param>
        /// <returns>True nếu được và False nếu không</returns>
        public bool UpdateDichVu(int maDichVu, string tenDichVu, float giaTien)
        {
            try
            {
                DataProvider.Instance.ExecuteNonQuery("SP_DichVu_Update @maDichVu , @tenDichVu , @giaDichVu", new object[] { maDichVu, tenDichVu, giaTien });
                return true;
            } catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        /// <summary>
        /// Search dịch vụ theo giá trị
        /// </summary>
        /// <param name="searchValue">giá trị cần tìm kiếm</param>
        /// <returns>Danh sách dịch vụ có chuỗi trùng với giá trị cần tìm</returns>
        public List<DichVuDTO> SearchDichVu (string searchValue)
        {
            List<DichVuDTO> list = new List<DichVuDTO>();
            try
            {
                DataTable data = DataProvider.Instance.ExecuteQuery("SP_DichVu_Search @searchValue", new object[] { searchValue });
                foreach(DataRow row in data.Rows)
                {
                    DichVuDTO dv = new DichVuDTO(row);
                    list.Add(dv);
                }
            } catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return list;
        }
    }
}
