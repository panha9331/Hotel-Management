
using System.Data.SqlClient;

namespace Hotel_Management.Data {
    public static class DatabaseConnection {
        private static readonly string connectionString =
            @"Server=.\SQLEXPRESS;
              Database=StayEasy;
              Integrated Security=True;
              TrustServerCertificate=True;";

        public static SqlConnection GetConnection() {
            return new SqlConnection(connectionString);
        }

        // Connect to master when creating the database
        public static SqlConnection GetMasterConnection() {
            var builder =
                new SqlConnectionStringBuilder(connectionString);

            builder.InitialCatalog = "master";

            return new SqlConnection(builder.ConnectionString);
        }

        public static string Database => "StayEasy";
    }
}
