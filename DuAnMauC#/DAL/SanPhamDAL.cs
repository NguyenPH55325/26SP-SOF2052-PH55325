using DemoDuAnMauCSharp.Utils;
using DuAnMauC_.DAO;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DuAnMauC_.DAL
{
    public static class SanPhamDAL
    {
        public static DataTable SelectAll()
        {
            string sql = @"
                SELECT 
                    ma_sp AS MaSanPham,
                    ten_sp AS TenSanPham,
                    trang_thai AS TrangThai
                FROM san_pham
            ";

            return DBUtil.ExecuteQueryTable(sql, new List<SqlParameter>());
        }

        // ===================== TẠO SẢN PHẨM =====================
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

        // ===================== CẬP NHẬT SẢN PHẨM =====================
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

        // ===================== ĐỔI TRẠNG THÁI (BẬT/TẮT) =====================
        public static void DoiTrangThai(string maSanPham, bool trangThai)
        {
            string sql = @"
                UPDATE san_pham
                SET trang_thai = @trang_thai
                WHERE ma_sp = @ma_sp
            ";

            Dictionary<string, object> param = new()
            {
                { "@ma_sp", maSanPham },
                { "@trang_thai", trangThai ? 1 : 0 }
            };

            DBUtil.ExecuteNonQuery(sql, param);
        }

        // ===================== XÓA SẢN PHẨM =====================
        // Lưu ý: do bảng san_pham_chi_tiet có FK => phải xóa SPCT trước
        public static void Xoa(string maSanPham)
        {
            string sqlCT = @"
                DELETE FROM san_pham_chi_tiet
                WHERE ma_sp = @ma_sp
            ";

            string sqlSP = @"
                DELETE FROM san_pham
                WHERE ma_sp = @ma_sp
            ";

            Dictionary<string, object> param = new()
            {
                { "@ma_sp", maSanPham }
            };

            DBUtil.ExecuteNonQuery(sqlCT, param);
            DBUtil.ExecuteNonQuery(sqlSP, param);
        }
    }
}
