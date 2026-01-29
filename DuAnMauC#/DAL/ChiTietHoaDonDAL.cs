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
            ma_spct      AS MaSanPham,
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
        public static void TaoMoi(ChiTietHoaDon chiTietHoaDon)
        {
            DBUtil.OpenConnection();
            DBUtil.ExecuteNonQuery(
                "INSERT INTO Chi_Tiet_Hoa_Don (ma_hd, ma_spct, don_gia, so_luong, thanh_tien) VALUES (@0, @1, @2, @3,@4,@5)",
                [
                    chiTietHoaDon.MaHoaDon,
                    chiTietHoaDon.MaSanPhamChiTiet,
                    chiTietHoaDon.DonGia,
                    chiTietHoaDon.SoLuong,
                    chiTietHoaDon.ThanhTien
                ]
            );
            DBUtil.CloseConnection();
        }

        public static void CapNhat(ChiTietHoaDon chiTietHoaDon)
        {
            DBUtil.OpenConnection();
            DBUtil.ExecuteNonQuery(
                "Update Chi_Tiet_Hoa_Don (ma_hd, ma_spct, don_gia, so_luong, thanh_tien) VALUES (@0, @1, @2, @3,@4,@5)",
                [
                    chiTietHoaDon.MaHoaDon,
                    chiTietHoaDon.MaSanPhamChiTiet,
                    chiTietHoaDon.DonGia,
                    chiTietHoaDon.SoLuong,
                    chiTietHoaDon.ThanhTien
                ]
            );
            DBUtil.CloseConnection();
        }

        public static void Xoa(string maHoaDon, string maSanPham)
        {
            DBUtil.OpenConnection();
            DBUtil.ExecuteNonQuery(
                "DELETE Chi_Tiet_Hoa_Don WHERE ma_hd=@0 AND ma_spct=@1",
                [
                    maHoaDon,
                    maSanPham
                ]
            );
            DBUtil.CloseConnection();
        }
    }
}
