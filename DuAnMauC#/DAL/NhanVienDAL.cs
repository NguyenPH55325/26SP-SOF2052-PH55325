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
    public class NhanVienDAL
    {
        public static DataTable SelectAll()
        {
            DBUtil.OpenConnection();
            DataTable tmp = DBUtil.ExecuteQueryTable("SELECT * FROM Nhan_Vien", null);
            DBUtil.CloseConnection();
            return tmp;
        }
    }
}
