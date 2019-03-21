using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhSan.DTO;

namespace QuanLyKhSan.DAO
{
    class LoaiPhongDAO
    {
        private static LoaiPhongDAO instance;

        internal static LoaiPhongDAO Instance
        {
            get { if (instance == null) instance = new LoaiPhongDAO(); return instance; }
            private set { instance = value; }
        }

        public List<LoaiPhongDTO> GetLP()
        {
            List<LoaiPhongDTO> list = new List<LoaiPhongDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.SP_LOAIPHONG_GETALL");
            foreach (DataRow item in data.Rows)
            {
                LoaiPhongDTO lp = new LoaiPhongDTO(item);
                list.Add(lp);
            }
            return list;
        }

        public bool InseartLP(string TENLOAI, string GHICHU)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC SP_LOAIPHONG_INSERT @TENLOAI , @GHICHU", new object[] { TENLOAI, GHICHU });
            return result > 0;
        }

        public bool UpdateLP(int MAL, string TENLOAI, string GHICHU)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC SP_LOAIPHONG_UPDATE @MAL , @TENLOAI , @GHICHU", new object[] { MAL, TENLOAI, GHICHU });
            return result > 0;
        }

        public bool DeleteLP(int MAL)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC SP_LOAIPHONG_DELETE @MAL ", new object[] { MAL });

            return result > 0;
        }

        public List<LoaiPhongDTO> SearchLP(string str)
        {
            List<LoaiPhongDTO> LpList = new List<LoaiPhongDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC SP_LOAIPHONG_TIMKIEM @SEARCHVALUE ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                LoaiPhongDTO LoaiPhong = new LoaiPhongDTO(item);
                LpList.Add(LoaiPhong);
            }
            return LpList;
        }
    }
}
