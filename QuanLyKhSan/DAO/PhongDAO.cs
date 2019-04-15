using QuanLyKhSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhSan.DAO
{
    class PhongDAO
    {
        private static PhongDAO instance;

        internal static PhongDAO Instance
        {
            get { if (instance == null) instance = new PhongDAO(); return instance; }
            private set { instance = value; }

        }
        public List<PhongDTO> GetP()
        {
            List<PhongDTO> list = new List<PhongDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.SP_GetDSP");
            foreach (DataRow item in data.Rows)
            {
                PhongDTO P = new PhongDTO(item);
                list.Add(P);
            }
            return list;
        }


        public List<MAL_DTO> GetlistMaL()
        {
            List<MAL_DTO> maLlist = new List<MAL_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery(" SELECT MAL FROM dbo.LOAIPH");
            foreach (DataRow item in data.Rows)
            {
                MAL_DTO maL = new MAL_DTO(item);
                maLlist.Add(maL);
            }
            return maLlist;
        }
        public bool InsertP( string TENPH, int MAL, int GIATHUE)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC SP_InsertP  @TENPH , @MAL , @GIATHUE ", new object[] { TENPH, MAL, GIATHUE });
            return result > 0;
        }

        public bool UpdateP(int MAPH, string TENPH, int MAL, int GIATHUE)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC SP_UpdateP @MAPH , @TENPH , @MAL , @GIATHUE ", new object[] { MAPH, TENPH, MAL, GIATHUE });
            return result > 0;
        }
        public bool DeleteP(int MAPH)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC SP_DeleteP @MAPH ", new object[] { MAPH });

            return result > 0;
        }
        public List<PhongDTO> SearchP(string str)
        {
            List<PhongDTO> PList = new List<PhongDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC SP_SearchP @SEARCHVALUE ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                PhongDTO phong = new PhongDTO(item);
                PList.Add(phong);
            }
            return PList;
        }

        
    }
}
