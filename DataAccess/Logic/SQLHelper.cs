using Dapper;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataAccess.Logic
{
    public static class SQLHelper
    {
        public static void SaveLog(Log log)
        {
            using (var conn = DbConnection())
            {
                string query = "INSERT INTO Logs(UserId, Date, Info) " +
                    "VALUES(@UserId, @Date, @Info);";

                var command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("UserId", log.UserId);
                command.Parameters.AddWithValue("Date", log.Date);
                command.Parameters.AddWithValue("Info", log.Info);

                command.ExecuteNonQuery();
            }
        }

        public static List<Log> GetLogs()
        {
            using (var conn = DbConnection())
            {
                string query = "SELECT * FROM Logs ORDER BY Id DESC;";

                return conn.Query<Log>(query).ToList();
            }
        }

        private static SqlConnection DbConnection()
        {
            string connStr = "Server=tcp:honsdb.database.windows.net,1433;" +
                "Initial Catalog=TeachingCompanionDB;" +
                "Persist Security Info=False;" +
                "User ID=sysop;" +
                "Password=yw9uhGeRLPYPHQ2;" +
                "MultipleActiveResultSets=False;" +
                "Encrypt=True;" +
                "TrustServerCertificate=False;" +
                "Connection Timeout=120;";

            var conn = new SqlConnection(connStr);
            conn.Open();
            return conn;
        }
    }
}
