using DemoDuAnMauCSharp.Utils;
using DuAnMauC_.DAO;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace DuAnMauC_.DAL
{
    public static class NhanVienDAL
    {
        // =============== READ: ALL ===============
        public static DataTable SelectAll()
        {
            string sql = @"
                SELECT 
                    ma_nv       AS MaNhanVien,
                    ten_nv      AS TenNhanVien,
                    gioi_tinh   AS GioiTinh,
                    sdt         AS SoDienThoai,
                    trang_thai  AS TrangThai
                FROM nhan_vien
                ORDER BY ma_nv DESC
            ";

            return DBUtil.ExecuteQueryTable(sql, new List<SqlParameter>());
        }

        // =============== READ: BY ID ===============
        public static DataTable SelectById(string maNv)
        {
            string sql = @"
                SELECT 
                    ma_nv       AS MaNhanVien,
                    ten_nv      AS TenNhanVien,
                    gioi_tinh   AS GioiTinh,
                    sdt         AS SoDienThoai,
                    trang_thai  AS TrangThai
                FROM nhan_vien
                WHERE ma_nv = @ma_nv
            ";

            List<SqlParameter> param = new()
            {
                new SqlParameter("@ma_nv", maNv)
            };

            return DBUtil.ExecuteQueryTable(sql, param);
        }

        // =============== CREATE ===============
        public static void TaoMoi(NhanVien nv)
        {
            string sql = @"
                INSERT INTO nhan_vien(ma_nv, ten_nv, gioi_tinh, sdt, trang_thai)
                VALUES(@ma_nv, @ten_nv, @gioi_tinh, @sdt, @trang_thai)
            ";

            Dictionary<string, object> param = new()
            {
                { "@ma_nv", nv.MaNhanVien },
                { "@ten_nv", nv.TenNhanVien },
                { "@gioi_tinh", nv.GioiTinh ? 1 : 0 },
                { "@sdt", nv.SoDienThoai },
                { "@trang_thai", nv.TrangThai ? 1 : 0 }
            };

            DBUtil.ExecuteNonQuery(sql, param);
        }

        // =============== UPDATE ===============
        public static void CapNhat(NhanVien nv)
        {
            string sql = @"
                UPDATE nhan_vien
                SET ten_nv = @ten_nv,
                    gioi_tinh = @gioi_tinh,
                    sdt = @sdt,
                    trang_thai = @trang_thai
                WHERE ma_nv = @ma_nv
            ";

            Dictionary<string, object> param = new()
            {
                { "@ma_nv", nv.MaNhanVien },
                { "@ten_nv", nv.TenNhanVien },
                { "@gioi_tinh", nv.GioiTinh ? 1 : 0 },
                { "@sdt", nv.SoDienThoai },
                { "@trang_thai", nv.TrangThai ? 1 : 0 }
            };

            DBUtil.ExecuteNonQuery(sql, param);
        }

        // =============== DELETE ===============
        public static void Xoa(string maNv)
        {
            string sql = @"DELETE FROM nhan_vien WHERE ma_nv = @ma_nv";

            Dictionary<string, object> param = new()
            {
                { "@ma_nv", maNv }
            };

            DBUtil.ExecuteNonQuery(sql, param);
        }

        // =============== AUTO ID: NV001... ===============
        public static string TaoMaTuDong()
        {
            string sql = @"SELECT TOP 1 ma_nv FROM nhan_vien ORDER BY ma_nv DESC";
            DataTable dt = DBUtil.ExecuteQueryTable(sql, new List<SqlParameter>());

            if (dt.Rows.Count == 0) return "NV001";

            string maCu = dt.Rows[0]["ma_nv"]?.ToString() ?? "NV000";
            // expect: NV007
            string so = maCu.Length >= 3 ? maCu.Substring(2) : "000";

            int soMoi = int.Parse(so) + 1;
            return "NV" + soMoi.ToString("D3");
        }
    }
}
