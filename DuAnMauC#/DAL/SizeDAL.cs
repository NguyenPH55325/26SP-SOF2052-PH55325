using DemoDuAnMauCSharp.Utils;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace DuAnMauC_.DAL
{
    public static class SizeDAL
    {
        public static DataTable SelectAll()
        {
            string sql = @"SELECT ma_size AS MaSize, ten_size AS TenSize FROM size";
            return DBUtil.ExecuteQueryTable(sql, new List<SqlParameter>());
        }
    }
}
