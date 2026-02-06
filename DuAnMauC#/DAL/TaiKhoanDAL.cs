using DemoDuAnMauCSharp.Utils;
using DuAnMauC_.DAO;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace DuAnMauC_.DAL
{
    public static class TaiKhoanDAL
    {
        public static TaiKhoan DangNhap(string user, string pass)
        {
            string sql = @"
                SELECT username, vai_tro, trang_thai
                FROM tai_khoan
                WHERE username = @u 
                  AND mat_khau = @p
                  AND trang_thai = 1
            ";
            // user: admin    ;   pw: 123 

            DataTable dt = DBUtil.ExecuteQueryTable(sql, new List<SqlParameter>
            {
                new SqlParameter("@u", user),
                new SqlParameter("@p", pass)
            });

            if (dt.Rows.Count == 0) return null;

            return new TaiKhoan
            {
                Username = dt.Rows[0]["username"].ToString(),
                VaiTro = dt.Rows[0]["vai_tro"].ToString(),
                TrangThai = Convert.ToBoolean(dt.Rows[0]["trang_thai"])
            };
        }
    }
}
