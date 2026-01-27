using DemoDuAnMauCSharp.Utils;
using DuAnMauC_.DAL;
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
        public static DataTable SelectAll()
        {
            DBUtil.OpenConnection();
            DataTable tmp = DBUtil.ExecuteQueryTable("SELECT * FROM San_Pham_chi_tiet", null);
            DBUtil.CloseConnection();
            return tmp;
        }
    }
}
