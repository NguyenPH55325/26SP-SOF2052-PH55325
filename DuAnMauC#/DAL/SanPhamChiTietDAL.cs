using DemoDuAnMauCSharp.Utils;
using DuAnMauC_.DAL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnMauC_.DAL
{
    public class SanPhamChiTietDAL
    {
        //public static DataTable SelectAll()
        //{
        //    DBUtil.OpenConnection();
        //    DataTable tmp = DBUtil.ExecuteQueryTable("SELECT * FROM San_Pham_chi_tiet", null);
        //    DBUtil.CloseConnection();
        //    return tmp;
        //}
        public static DataTable SelectAll()
        {
            string sql = @"
                SELECT 
                    ct.ma_spct   AS MaSPCT,
                    ct.ma_sp     AS MaSP,
                    sp.ten_sp    AS TenSanPham,
                    ms.ma_mau    AS MaMau,
                    ms.ten_mau   AS TenMau,
                    sz.ma_size   AS MaSize,
                    sz.ten_size  AS TenSize,
                    ct.don_gia   AS DonGia,
                    ct.so_luong  AS SoLuong,
                    ct.trang_thai AS TrangThai
                FROM san_pham_chi_tiet ct
                JOIN san_pham sp  ON ct.ma_sp   = sp.ma_sp
                JOIN mau_sac ms   ON ct.ma_mau  = ms.ma_mau
                JOIN size sz      ON ct.ma_size = sz.ma_size
                ORDER BY ct.ma_spct DESC
            ";

            return DBUtil.ExecuteQueryTable(sql, new List<SqlParameter>());
        }

        public static DataTable SelectByMaSPCT(string maSpct)
        {
            string sql = @"
        SELECT 
            ct.ma_spct AS MaSPCT,
            sp.ten_sp  AS TenSanPham,
            ct.don_gia AS DonGia,
            ct.so_luong AS SoLuongTon
        FROM san_pham_chi_tiet ct
        JOIN san_pham sp ON ct.ma_sp = sp.ma_sp
        WHERE ct.ma_spct = @ma_spct
    ";

            List<SqlParameter> param = new()
    {
        new SqlParameter("@ma_spct", maSpct)
    };

            return DBUtil.ExecuteQueryTable(sql, param);
        }

        public static DataTable SelectByMaSP(string maSp)
        {
            string sql = @"
                SELECT 
                    ct.ma_spct   AS MaSPCT,
                    ct.ma_sp     AS MaSP,
                    sp.ten_sp    AS TenSanPham,
                    ct.ma_mau    AS MaMau,
                    ms.ten_mau   AS TenMau,
                    ct.ma_size   AS MaSize,
                    sz.ten_size  AS TenSize,
                    ct.don_gia   AS DonGia,
                    ct.so_luong  AS SoLuong,
                    ct.trang_thai AS TrangThai
                FROM san_pham_chi_tiet ct
                JOIN san_pham sp  ON ct.ma_sp   = sp.ma_sp
                JOIN mau_sac ms   ON ct.ma_mau  = ms.ma_mau
                JOIN size sz      ON ct.ma_size = sz.ma_size
                WHERE ct.ma_sp = @ma_sp
                ORDER BY ct.ma_spct DESC
            ";

            List<SqlParameter> param = new()
            {
                new SqlParameter("@ma_sp", maSp)
            };

            return DBUtil.ExecuteQueryTable(sql, param);
        }

        // ===================== CREATE: THÊM SPCT =====================
        public static void TaoMoi(string maSpct, string maSp, string maMau, string maSize,
                                  decimal donGia, int soLuong, bool trangThai)
        {
            string sql = @"
                INSERT INTO san_pham_chi_tiet
                    (ma_spct, ma_sp, ma_mau, ma_size, don_gia, so_luong, trang_thai)
                VALUES
                    (@ma_spct, @ma_sp, @ma_mau, @ma_size, @don_gia, @so_luong, @trang_thai)
            ";

            Dictionary<string, object> param = new()
            {
                { "@ma_spct", maSpct },
                { "@ma_sp", maSp },
                { "@ma_mau", maMau },
                { "@ma_size", maSize },
                { "@don_gia", donGia },
                { "@so_luong", soLuong },
                { "@trang_thai", trangThai ? 1 : 0 }
            };

            DBUtil.ExecuteNonQuery(sql, param);
        }

        // ===================== UPDATE: SỬA SPCT =====================
        public static void CapNhat(string maSpct, string maSp, string maMau, string maSize,
                                   decimal donGia, int soLuong, bool trangThai)
        {
            string sql = @"
                UPDATE san_pham_chi_tiet
                SET ma_sp = @ma_sp,
                    ma_mau = @ma_mau,
                    ma_size = @ma_size,
                    don_gia = @don_gia,
                    so_luong = @so_luong,
                    trang_thai = @trang_thai
                WHERE ma_spct = @ma_spct
            ";

            Dictionary<string, object> param = new()
            {
                { "@ma_spct", maSpct },
                { "@ma_sp", maSp },
                { "@ma_mau", maMau },
                { "@ma_size", maSize },
                { "@don_gia", donGia },
                { "@so_luong", soLuong },
                { "@trang_thai", trangThai ? 1 : 0 }
            };

            DBUtil.ExecuteNonQuery(sql, param);
        }

        // ===================== UPDATE: CỘNG/TRỪ SỐ LƯỢNG (tiện cho bán hàng) =====================
        public static void CapNhatSoLuong(string maSpct, int soLuongMoi)
        {
            string sql = @"
                UPDATE san_pham_chi_tiet
                SET so_luong = @so_luong
                WHERE ma_spct = @ma_spct
            ";

            Dictionary<string, object> param = new()
            {
                { "@ma_spct", maSpct },
                { "@so_luong", soLuongMoi }
            };

            DBUtil.ExecuteNonQuery(sql, param);
        }

        // ===================== UPDATE: ĐỔI TRẠNG THÁI =====================
        public static void DoiTrangThai(string maSpct, bool trangThai)
        {
            string sql = @"
                UPDATE san_pham_chi_tiet
                SET trang_thai = @trang_thai
                WHERE ma_spct = @ma_spct
            ";

            Dictionary<string, object> param = new()
            {
                { "@ma_spct", maSpct },
                { "@trang_thai", trangThai ? 1 : 0 }
            };

            DBUtil.ExecuteNonQuery(sql, param);
        }

        public static void TruTon(string maSpct, int sl)
        {
            string sql = @"
        UPDATE san_pham_chi_tiet
        SET so_luong = so_luong - @sl
        WHERE ma_spct = @ma_spct
    ";

            Dictionary<string, object> param = new()
    {
        {"@ma_spct", maSpct},
        {"@sl", sl}
    };

            DBUtil.ExecuteNonQuery(sql, param);
        }

        // ===================== DELETE: XÓA SPCT =====================
        public static void XoaMem(string maSpct)
        {
            string sql = @"
        UPDATE san_pham_chi_tiet
        SET trang_thai = 0
        WHERE ma_spct = @ma_spct
    ";

            Dictionary<string, object> param = new()
    {
        { "@ma_spct", maSpct }
    };

            DBUtil.ExecuteNonQuery(sql, param);
        }

        // ===================== CHECK: TRÙNG BIẾN THỂ (SP + MÀU + SIZE) =====================
        public static DataTable KiemTraTrungBienThe(string maSp, string maMau, string maSize)
        {
            string sql = @"
                SELECT ma_spct
                FROM san_pham_chi_tiet
                WHERE ma_sp = @ma_sp AND ma_mau = @ma_mau AND ma_size = @ma_size
            ";

            List<SqlParameter> param = new()
            {
                new SqlParameter("@ma_sp", maSp),
                new SqlParameter("@ma_mau", maMau),
                new SqlParameter("@ma_size", maSize)
            };

            return DBUtil.ExecuteQueryTable(sql, param);
        }
        // ===================== AUTO ID: SPCT001... =====================
        public static string TaoMaTuDong()
        {
            string sql = @"
        SELECT MAX(CAST(SUBSTRING(ma_spct, 5, 10) AS INT)) AS MaxSo
        FROM san_pham_chi_tiet
        WHERE ma_spct LIKE 'SPCT%'
    ";

            DataTable dt = DBUtil.ExecuteQueryTable(sql, new List<SqlParameter>());

            int max = 0;
            if (dt.Rows.Count > 0 && dt.Rows[0]["MaxSo"] != DBNull.Value)
                max = Convert.ToInt32(dt.Rows[0]["MaxSo"]);

            int next = max + 1;
            return "SPCT" + next.ToString("D3");
        }

    }
}
