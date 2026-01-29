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
        public static DataTable SelectByMaSPCT(string maSpct)
        {
            string sql = @"
                SELECT sp.ten_sp, ct.don_gia
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

    }
}
