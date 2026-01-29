using DemoDuAnMauCSharp.Utils;
using DuAnMauC_.DAO;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace DuAnMauC_.DAL
{
    public static class HoaDonDAL
    {
        // ===================== LẤY TẤT CẢ HÓA ĐƠN =====================
        public static DataTable SelectAll()
        {
            string sql = @"
                SELECT 
                    ma_hd AS MaHoaDon,
                    ngay_tao AS NgayTao,
                    trang_thai AS TrangThai
                FROM hoa_don
            ";

            return DBUtil.ExecuteQueryTable(sql, new List<SqlParameter>());
        }

        // ===================== TẠO HÓA ĐƠN =====================
        public static void TaoMoi(HoaDon hoaDon)
        {
            string sql = @"
                INSERT INTO hoa_don (ma_hd, ngay_tao, trang_thai)
                VALUES (@ma_hd, @ngay_tao, @trang_thai)
            ";

            Dictionary<string, object> param = new()
            {
                { "@ma_hd", hoaDon.MaHoaDon },
                { "@ngay_tao", hoaDon.NgayTao },
                { "@trang_thai", hoaDon.TrangThai ? 1 : 0 }
            };

            DBUtil.ExecuteNonQuery(sql, param);
        }

        // ===================== CẬP NHẬT HÓA ĐƠN =====================
        public static void CapNhat(HoaDon hoaDon)
        {
            string sql = @"
                UPDATE hoa_don
                SET ngay_tao = @ngay_tao,
                trang_thai = @trang_thai
                WHERE ma_hd = @ma_hd
            ";

            Dictionary<string, object> param = new()
            {
                { "@ma_hd", hoaDon.MaHoaDon },
                { "@ngay_tao", hoaDon.NgayTao },
                { "@trang_thai", hoaDon.TrangThai ? 1 : 0 }
            };

            DBUtil.ExecuteNonQuery(sql, param);
        }

        // ===================== THANH TOÁN =====================
        public static void ThanhToan(string maHoaDon)
        {
            string sql = @"
                UPDATE hoa_don
                SET trang_thai = 1
                WHERE ma_hd = @ma_hd
            ";

            Dictionary<string, object> param = new()
            {
                { "@ma_hd", maHoaDon }
            };

            DBUtil.ExecuteNonQuery(sql, param);
        }

        // ===================== XÓA HÓA ĐƠN =====================
        public static void Xoa(string maHoaDon)
        {
            string sqlCT = @"
                DELETE FROM hoa_don_chi_tiet
                WHERE ma_hd = @ma_hd
            ";

            string sqlHD = @"
                DELETE FROM hoa_don
                WHERE ma_hd = @ma_hd
            ";

            Dictionary<string, object> param = new()
            {
                { "@ma_hd", maHoaDon }
            };

            DBUtil.ExecuteNonQuery(sqlCT, param);
            DBUtil.ExecuteNonQuery(sqlHD, param);
        }
    }
}
