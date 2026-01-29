using System.Data;
using Microsoft.Data.SqlClient; //NuGet

namespace DemoDuAnMauCSharp.Utils
{
    public static class DBUtil
    {
        private static readonly string _connectionString = "Server=LAPTOP-NGKLVTQV;" +

            "Database=duanmau_nguyenktph55325;" +
            "Integrated Security=True;" +
            "Encrypt=True;" +
            "TrustServerCertificate=True;";

        private static SqlConnection? _connection = null;

        public static string? OpenConnection()
        {
            try
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection(_connectionString);
                }

                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }

                return null;
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
        }

        //public static SqlDataReader ExecuteQueryReader(string sql, List<object> parameters)
        //{
        //    SqlCommand command = new(sql, _connection);
        //    if (parameters != null)
        //    {
        //        for (int i = 0; i < parameters.Count; i++)
        //        {
        //            command.Parameters.AddWithValue($"@p{i}", parameters[i] ?? DBNull.Value);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    return reader;
        //}

        public static DataTable ExecuteQueryTable(string sql, List<SqlParameter> parameters)
        {
            OpenConnection();

            SqlCommand command = new(sql, _connection);

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters.ToArray());
            }

            SqlDataAdapter adapter = new(command);
            DataTable dt = new();
            adapter.Fill(dt);

            CloseConnection();
            return dt;
        }

        public static void ExecuteNonQuery(string sql, Dictionary<string, object> parameters)
        {
            OpenConnection();

            SqlCommand command = new SqlCommand(sql, _connection);

            if (parameters != null)
            {
                foreach (var prm in parameters)
                {
                    command.Parameters.AddWithValue(prm.Key, prm.Value ?? DBNull.Value);
                }
            }

            command.ExecuteNonQuery();
            CloseConnection();
        }

        public static string? CloseConnection()
        {
            try
            {
                if (_connection != null && _connection.State != ConnectionState.Closed)
                {
                    _connection.Close();
                }
                return null;
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
        }
    }
}
