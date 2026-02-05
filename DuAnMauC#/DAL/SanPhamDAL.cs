using DemoDuAnMauCSharp.Utils;
using DuAnMauC_.DAO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DuAnMauC_.DAL
{
    public static class SanPhamDAL
    {
        // ===== READ ALL =====
        public static DataTable SelectAll()
        {
            string sql = @"
                SELECT 
                    ma_sp       AS MaSanPham,
                    ten_sp      AS TenSanPham,
                    trang_thai  AS TrangThai
                FROM san_pham
                ORDER BY ma_sp DESC
            ";

            return DBUtil.ExecuteQueryTable(sql, new List<SqlParameter>());
        }

        // ===== READ BY ID (phục vụ lọc/chi tiết nếu cần) =====
        public static DataTable SelectById(string maSp)
        {
            string sql = @"
                SELECT 
                    ma_sp       AS MaSanPham,
                    ten_sp      AS TenSanPham,
                    trang_thai  AS TrangThai
                FROM san_pham
                WHERE ma_sp = @ma_sp
            ";

            return DBUtil.ExecuteQueryTable(sql, new List<SqlParameter>
            {
                new SqlParameter("@ma_sp", maSp)
            });
        }

        // ===== CREATE =====
        public static void TaoMoi(SanPham sp)
        {
            string sql = @"
                INSERT INTO san_pham (ma_sp, ten_sp, trang_thai)
                VALUES (@ma_sp, @ten_sp, @trang_thai)
            ";

            Dictionary<string, object> param = new()
            {
                { "@ma_sp", sp.MaSanPham },
                { "@ten_sp", sp.TenSanPham },
                { "@trang_thai", sp.TrangThai ? 1 : 0 }
            };

            DBUtil.ExecuteNonQuery(sql, param);
        }

        // ===== UPDATE =====
        public static void CapNhat(SanPham sp)
        {
            string sql = @"
                UPDATE san_pham
                SET ten_sp = @ten_sp,
                    trang_thai = @trang_thai
                WHERE ma_sp = @ma_sp
            ";

            Dictionary<string, object> param = new()
            {
                { "@ma_sp", sp.MaSanPham },
                { "@ten_sp", sp.TenSanPham },
                { "@trang_thai", sp.TrangThai ? 1 : 0 }
            };

            DBUtil.ExecuteNonQuery(sql, param);
        }

        // ===== SOFT DELETE: NGỪNG BÁN (khuyên dùng) =====
        public static void NgungBan(string maSp)
        {
            string sqlSp = @"UPDATE san_pham SET trang_thai = 0 WHERE ma_sp = @ma_sp";
            string sqlSpct = @"UPDATE san_pham_chi_tiet SET trang_thai = 0 WHERE ma_sp = @ma_sp";

            Dictionary<string, object> param = new()
            {
                { "@ma_sp", maSp }
            };

            // tắt trước ở SPCT rồi tắt SP
            DBUtil.ExecuteNonQuery(sqlSpct, param);
            DBUtil.ExecuteNonQuery(sqlSp, param);
        }

        // ===== AUTO ID: SP001... (bản MAX chắc kèo) =====
        public static string TaoMaTuDong()
        {
            string sql = @"
                SELECT MAX(CAST(SUBSTRING(ma_sp, 3, 10) AS INT)) AS MaxSo
                FROM san_pham
                WHERE ma_sp LIKE 'SP%'
            ";

            DataTable dt = DBUtil.ExecuteQueryTable(sql, new List<SqlParameter>());

            int max = 0;
            if (dt.Rows.Count > 0 && dt.Rows[0]["MaxSo"] != DBNull.Value)
                max = Convert.ToInt32(dt.Rows[0]["MaxSo"]);

            int next = max + 1;
            return "SP" + next.ToString("D3");
        }

        // ===== COMBO: chỉ lấy SP đang hoạt động =====
        public static DataTable SelectForCombo()
        {
            string sql = @"
                SELECT ma_sp AS MaSP, ten_sp AS TenSP
                FROM san_pham
                WHERE trang_thai = 1
                ORDER BY ten_sp
            ";

            return DBUtil.ExecuteQueryTable(sql, new List<SqlParameter>());
        }
    }
}
