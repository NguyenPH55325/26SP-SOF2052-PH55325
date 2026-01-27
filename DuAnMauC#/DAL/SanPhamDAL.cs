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
    public class SanPhamDAL
    {
        public static DataTable SelectAll()
        {
            DBUtil.OpenConnection();
            DataTable tmp = DBUtil.ExecuteQueryTable("SELECT * FROM San_Pham", null);
            DBUtil.CloseConnection();
            return tmp;
        }
    }
}
