using System;
using System.Data.SqlClient;

namespace Hotel_Management.Data
{
    public static class DatabaseConnection
    {
        private static readonly string connectionString = @"Server=.\SQLEXPRESS;Database=StayEasy;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        static void Main(string[] args)
        {
            // The 'using' statement automatically opens and properly disposes/closes the connection
            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Connection successful!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            } // conn.Close() and conn.Dispose() are called automatically here
        }
    }
}