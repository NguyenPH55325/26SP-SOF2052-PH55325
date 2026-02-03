using DemoDuAnMauCSharp.Utils;
using DuAnMauC_.DAO;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace DuAnMauC_.DAL
{
    public static class KhachHangDAL
    {
        // ===== READ =====
        public static DataTable SelectAll()
        {
            string sql = @"
                SELECT 
                    ma_kh      AS MaKhachHang,
                    ten_kh     AS TenKhachHang,
                    sdt        AS SoDienThoai,
                    trang_thai AS TrangThai
                FROM khach_hang
                ORDER BY ma_kh DESC
            ";

            return DBUtil.ExecuteQueryTable(sql, new List<SqlParameter>());
        }

        // ===== CREATE =====
        public static void TaoMoi(KhachHang kh)
        {
            string sql = @"
                INSERT INTO khach_hang(ma_kh, ten_kh, sdt, trang_thai)
                VALUES(@ma_kh, @ten_kh, @sdt, @trang_thai)
            ";

            Dictionary<string, object> param = new()
            {
                { "@ma_kh", kh.MaKhachHang },
                { "@ten_kh", kh.TenKhachHang },
                { "@sdt", kh.SoDienThoai },
                { "@trang_thai", kh.TrangThai ? 1 : 0 }
            };

            DBUtil.ExecuteNonQuery(sql, param);
        }

        // ===== UPDATE =====
        public static void CapNhat(KhachHang kh)
        {
            string sql = @"
                UPDATE khach_hang
                SET ten_kh = @ten_kh,
                    sdt = @sdt,
                    trang_thai = @trang_thai
                WHERE ma_kh = @ma_kh
            ";

            Dictionary<string, object> param = new()
            {
                { "@ma_kh", kh.MaKhachHang },
                { "@ten_kh", kh.TenKhachHang },
                { "@sdt", kh.SoDienThoai },
                { "@trang_thai", kh.TrangThai ? 1 : 0 }
            };

            DBUtil.ExecuteNonQuery(sql, param);
        }

        // ===== DELETE =====
        public static void Xoa(string maKh)
        {
            string sql = @"DELETE FROM khach_hang WHERE ma_kh = @ma_kh";

            Dictionary<string, object> param = new()
            {
                { "@ma_kh", maKh }
            };

            DBUtil.ExecuteNonQuery(sql, param);
        }

        // ===== AUTO ID =====
        public static string TaoMaTuDong()
        {
            string sql = @"SELECT TOP 1 ma_kh FROM khach_hang ORDER BY ma_kh DESC";
            DataTable dt = DBUtil.ExecuteQueryTable(sql, new List<SqlParameter>());

            if (dt.Rows.Count == 0) return "KH001";

            string maCu = dt.Rows[0]["ma_kh"].ToString(); // KH007
            int so = int.Parse(maCu.Substring(2)) + 1;
            return "KH" + so.ToString("D3");
        }
    }
}
