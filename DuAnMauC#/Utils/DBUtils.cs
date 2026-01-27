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

        public static DataTable ExecuteQueryTable(string sql, List<object> parameters)
        {
            SqlCommand command = new(sql, _connection);

            if (parameters != null)
            {
                int i = -1;
                parameters.ForEach(prm =>
                {
                    i++;
                    command.Parameters.AddWithValue($"@{i}", prm ?? DBNull.Value);
                });
            }

            SqlDataAdapter adapter = new(command);
            DataTable dt = new();
            adapter.Fill(dt);

            return dt;
        }

        public static void ExecuteNonQuery(string sql, List<object> parameters)
        {
            if (parameters != null)
            {
                SqlCommand command = new(sql, _connection);
                int i = -1;
                parameters.ForEach((prm) =>
                {
                    i++;
                    command.Parameters.AddWithValue($"@{i}", prm ?? DBNull.Value);
                });
                command.ExecuteNonQuery();
            }
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
