using DemoDuAnMauCSharp.Utils;
using DuAnMauC_.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnMauC_.DAL
{
    public static class HoaDonDAL
    {
        public static DataTable SelectAll()
        {
            DBUtil.OpenConnection();

            DataTable dt = DBUtil.ExecuteQueryTable(
                "SELECT ma_hd, ngay_tao, trang_thai FROM hoa_don",
                new List<object>()
            );

            DBUtil.CloseConnection();
            return dt;
        }
        public static void TaoMoi(HoaDon hoaDon)
        {
            DBUtil.OpenConnection();
            DBUtil.ExecuteNonQuery(
                "INSERT INTO Hoa_Don (ma_hd, ngay_tao, trang_thai) VALUES (@0, @1, @2)",
                [
                    hoaDon.MaHoaDon,
                    hoaDon.NgayTao,
                    hoaDon.TrangThai ? 1 : 0
                ]
            );
            DBUtil.CloseConnection();
        }

        public static void CapNhat(HoaDon hoaDon)
        {
            DBUtil.OpenConnection();
            DBUtil.ExecuteNonQuery(
                "UPDATE Hoa_Don SET ngay_tao=@0, trang_thai=@1 WHERE ma_hd=@2",
                [
                    hoaDon.NgayTao,
                    hoaDon.TrangThai ? 1 : 0,
                    hoaDon.MaHoaDon
                ]
            );
            DBUtil.CloseConnection();
        }

        public static void ThanhToan(string maHoaDon)
        {
            DBUtil.OpenConnection();
            DBUtil.ExecuteNonQuery(
                "UPDATE Hoa_Don SET trang_thai=1 WHERE ma_hd=@0",
                [maHoaDon]
            );
            DBUtil.CloseConnection();
        }

        public static void Xoa(string maHoaDon)
        {
            DBUtil.OpenConnection();
            DBUtil.ExecuteNonQuery(
                "DELETE Hoa_Don WHERE ma_hd=@0",
                [maHoaDon]
            );
            DBUtil.ExecuteNonQuery(
                "DELETE Chi_Tiet_Hoa_Don WHERE ma_hd=@0",
                [maHoaDon]
            );
            DBUtil.CloseConnection();
        }
    }
}
