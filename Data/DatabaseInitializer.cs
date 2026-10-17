
using Microsoft.Data.SqlClient;
using System;
using System.IO;

namespace Hotel_Management.Data
{
    public static class DatabaseInitializer
    {
        public static void Initialize()
        {
            CreateDatabase();
            CreateTables();
        }

        private static void CreateDatabase()
        {
            using var connection =
                DatabaseConnection.GetMasterConnection();

            connection.Open();

            string sql = $@"
                IF DB_ID(N'{DatabaseConnection.Database}') IS NULL
                BEGIN
                    CREATE DATABASE
                        [{DatabaseConnection.Database}];
                END;";

            using var command = new SqlCommand(sql, connection);

            command.CommandTimeout = 60;
            command.ExecuteNonQuery();
        }

        private static void CreateTables()
        {
            string schemaPath = Path.Combine(
                AppContext.BaseDirectory,
                "Data",
                "Sql",
                "Schema.sql");

            if (!File.Exists(schemaPath))
            {
                throw new FileNotFoundException(
                    "Database schema file was not found.",
                    schemaPath);
            }

            string schema = File.ReadAllText(schemaPath);

            using var connection =
                DatabaseConnection.GetConnection();

            connection.Open();

            using var command =
                new SqlCommand(schema, connection);

            command.CommandTimeout = 60;
            command.ExecuteNonQuery();
        }

        public static bool TestConnection()
        {
            try
            {
                using var connection =
                    DatabaseConnection.GetConnection();

                connection.Open();

                using var command = new SqlCommand(
                    "SELECT DB_NAME();",
                    connection);

                return string.Equals(
                    command.ExecuteScalar()?.ToString(),
                    DatabaseConnection.Database,
                    StringComparison.OrdinalIgnoreCase);
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}
