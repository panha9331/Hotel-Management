using System;
//using Microsoft.Data.SqlClient;
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
        
        public static string Database => "StayEasy";
    }
}