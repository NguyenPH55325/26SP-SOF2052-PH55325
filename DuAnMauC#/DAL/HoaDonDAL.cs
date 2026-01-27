using DemoDuAnMauCSharp.Utils;
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
    }
}
