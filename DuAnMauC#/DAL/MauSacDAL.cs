using DemoDuAnMauCSharp.Utils;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace DuAnMauC_.DAL
{
    public static class MauSacDAL
    {
        public static DataTable SelectAll()
        {
            string sql = @"SELECT ma_mau AS MaMau, ten_mau AS TenMau FROM mau_sac";
            return DBUtil.ExecuteQueryTable(sql, new List<SqlParameter>());
        }
    }
}
