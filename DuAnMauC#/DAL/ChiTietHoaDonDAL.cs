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
    public static class ChiTietHoaDonDAL
    {

        public static DataTable SelectAll(string maHoaDon)
        {
            DBUtil.OpenConnection();

            string sql = @"
        SELECT 
            ma_hd      AS MaHoaDon,
            ma_sp      AS MaSanPham,
            so_luong   AS SoLuong,
            don_gia    AS DonGia,
            so_luong * don_gia AS ThanhTien
        FROM hoa_don_chi_tiet
        WHERE ma_hd = @0
    ";

            DataTable dt = DBUtil.ExecuteQueryTable(
                sql,
                new List<object> { maHoaDon }
            );

            DBUtil.CloseConnection();
            return dt;
        }
    }
}
