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
        // ===================== TẠO MÃ TỰ ĐỘNG =====================
        public static string TaoMaTuDong()
        {
            string sql = @"
        SELECT TOP 1 ma_hd
        FROM hoa_don
        WHERE ma_hd LIKE 'HD+%'
        ORDER BY CAST(SUBSTRING(ma_hd, 4, 10) AS INT) DESC
    ";

            DataTable dt = DBUtil.ExecuteQueryTable(sql, new List<SqlParameter>());

            if (dt.Rows.Count == 0) return "HD001";

            string maCu = dt.Rows[0]["ma_hd"].ToString(); // ví dụ: HD+007
            string so = maCu.Substring(3);                // "007"
            if (!int.TryParse(so, out int n)) return "HD001";

            int soMoi = n + 1;
            return "HD+" + soMoi.ToString("D3");          // HD+008
        }

    }
}
