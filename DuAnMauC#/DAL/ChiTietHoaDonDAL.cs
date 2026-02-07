using DemoDuAnMauCSharp.Utils;
using DuAnMauC_.DAO;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace DuAnMauC_.DAL
{
    public static class ChiTietHoaDonDAL
    {
        // ===================== SELECT THEO MÃ HÓA ĐƠN =====================
        public static DataTable SelectAll(string maHoaDon)
        {
            string sql = @"
                SELECT 
                    ma_hd      AS MaHoaDon,
                    ma_spct    AS MaSanPhamChiTiet,
                    so_luong   AS SoLuong,
                    don_gia    AS DonGia,
                    so_luong * don_gia AS ThanhTien
                FROM hoa_don_chi_tiet
                WHERE ma_hd = @ma_hd
            ";

            List<SqlParameter> param = new()
            {
                new SqlParameter("@ma_hd", maHoaDon)
            };

            return DBUtil.ExecuteQueryTable(sql, param);
        }

        // ===================== THÊM CHI TIẾT HÓA ĐƠN =====================
        public static void TaoMoi(ChiTietHoaDon ct)
        {
            string sql = @"
                INSERT INTO hoa_don_chi_tiet
                (ma_hd, ma_spct, don_gia, so_luong)
                VALUES (@ma_hd, @ma_spct, @don_gia, @so_luong)
            ";

            Dictionary<string, object> param = new()
            {
                { "@ma_hd", ct.MaHoaDon },
                { "@ma_spct", ct.MaSanPhamChiTiet },
                { "@don_gia", ct.DonGia },
                { "@so_luong", ct.SoLuong }
            };

            DBUtil.ExecuteNonQuery(sql, param);
        }

        // ===================== SỬA CHI TIẾT HÓA ĐƠN =====================
        public static void CapNhat(ChiTietHoaDon ct)
        {
            string sql = @"
                UPDATE hoa_don_chi_tiet
                SET don_gia = @don_gia,
                    so_luong = @so_luong
                WHERE ma_hd = @ma_hd
                  AND ma_spct = @ma_spct
            ";

            Dictionary<string, object> param = new()
            {
                { "@ma_hd", ct.MaHoaDon },
                { "@ma_spct", ct.MaSanPhamChiTiet },
                { "@don_gia", ct.DonGia },
                { "@so_luong", ct.SoLuong }
            };

            DBUtil.ExecuteNonQuery(sql, param);
        }

        // ===================== XÓA CHI TIẾT HÓA ĐƠN =====================
        public static void Xoa(string maHoaDon, string maSpct)
        {
            string sql = @"
                DELETE FROM hoa_don_chi_tiet
                WHERE ma_hd = @ma_hd
                  AND ma_spct = @ma_spct
            ";

            Dictionary<string, object> param = new()
            {
                { "@ma_hd", maHoaDon },
                { "@ma_spct", maSpct }
            };

            DBUtil.ExecuteNonQuery(sql, param);
        }
        // ===================== THÊM HOẶC CẬP NHẬT CHI TIẾT HÓA ĐƠN =====================
        public static void AddOrUpdate(ChiTietHoaDon ct)
        {
            string sql = @"
        IF EXISTS (SELECT 1 FROM hoa_don_chi_tiet WHERE ma_hd = @ma_hd AND ma_spct = @ma_spct)
        BEGIN
            UPDATE hoa_don_chi_tiet
            SET so_luong = so_luong + @so_luong,
                don_gia = @don_gia
            WHERE ma_hd = @ma_hd AND ma_spct = @ma_spct
        END
        ELSE
        BEGIN
            INSERT INTO hoa_don_chi_tiet(ma_hd, ma_spct, don_gia, so_luong)
            VALUES(@ma_hd, @ma_spct, @don_gia, @so_luong)
        END
    ";

            Dictionary<string, object> param = new()
    {
        {"@ma_hd", ct.MaHoaDon},
        {"@ma_spct", ct.MaSanPhamChiTiet},
        {"@don_gia", ct.DonGia},
        {"@so_luong", ct.SoLuong},
    };

            DBUtil.ExecuteNonQuery(sql, param);
        }

    }
}