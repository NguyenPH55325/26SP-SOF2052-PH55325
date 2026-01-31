using DemoDuAnMauCSharp.Utils;
using DuAnMauC_.DAL;
using DuAnMauC_.DAO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnMauC_.DAL
{
    public class SanPhamDAL
    {
        public static DataTable SelectAll()
        {
            DBUtil.OpenConnection();
            DataTable tmp = DBUtil.ExecuteQueryTable("SELECT * FROM San_Pham", null);
            DBUtil.CloseConnection();
            return tmp;
        }
        public static void TaoMoi(SanPham sanPham)
        {
            string sql = @"
                INSERT INTO hoa_don (ma_hd, ngay_tao, trang_thai)
                VALUES (@ma_hd, @ngay_tao, @trang_thai)
            ";

            Dictionary<string, object> param = new()
            {
                { "@ma_sp", sanPham.MaSanPham },
                { "@ten_sp", sanPham.TenSanPham },
                { "@trang_thai", sanPham.TrangThai ? 1 : 0 }
            };

            DBUtil.ExecuteNonQuery(sql, param);
        }

    }
}
