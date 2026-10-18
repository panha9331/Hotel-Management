
using System;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Linq;

namespace Hotel_Management.Data
{
    public static class DatabaseInitializer
    {

        public static void InitializeDatabase()
        {
            // 1. Connect to 'master' to check/create the database
            string masterConnectionString = "Server=.\\SQLEXPRESS\\MSSQLLocalDB;Database=master;Trusted_Connection=True;";
            string dbName = "StayEasy";

            using (var connection = new SqlConnection(masterConnectionString))
            {
                connection.Open();

                // Check if database exists
                string checkQuery = $"SELECT database_id FROM sys.databases WHERE Name = '{dbName}'";
                using (var cmd = new SqlCommand(checkQuery, connection))
                {
                    var result = cmd.ExecuteScalar();
                    if (result == null)
                    {
                        // Database does not exist, create it!
                        string createQuery = $"CREATE DATABASE [{dbName}]";
                        using (var createCmd = new SqlCommand(createQuery, connection))
                        {
                            createCmd.ExecuteNonQuery();
                        }
                    }
                }
            }

            // 2. Now connect to your specific database and create tables if needed
            string appConnectionString = $"Server=(localdb)\\MSSQLLocalDB;Database={dbName};Trusted_Connection=True;";
            using (var appConnection = new SqlConnection(appConnectionString))
            {
                appConnection.Open();

                string tableQuery = @"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Users' and xtype='U')
                    CREATE TABLE ROOMS(
	                    room_id INT,
	                    room_number INT,
	                    room_type VARCHAR(25),
	                    price DECIMAL(10, 2),
	                    room_status VARCHAR(36),
	                    createAt DATETIME2 DEFAULT CURRENT_TIMESTAMP, 

	                    --TABLE CONSTRAINTS
	                    CONSTRAINT pk_rooms_room_id PRIMARY KEY(room_id),
	                    CONSTRAINT uq_rooms_room_number UNIQUE(room_number),
	                    CONSTRAINT chk_rooms_room_status CHECK(room_status IN ('Available', 'Reserved', 'Occupied',  'Maintenance')),
	                    CONSTRAINT chk_rooms_room_type CHECK(room_type IN ('Single', 'Double', 'Twin',  'Vip', 'Suit')),
                    )
         
	                CREATE TABLE CUSTOMERS(
		                customer_id INT,
		                name VARCHAR(36) NOT NULL,
		                gender VARCHAR(10),
		                phone VARCHAR(20),
		                email	VARCHAR(100),
		                createAt DATETIME2 DEFAULT CURRENT_TIMESTAMP,

		                CONSTRAINT pk_customers_customer_id PRIMARY KEY(customer_id),
		
	                )

	                CREATE TABLE RESERVATIONS (
                        reservation_id INT,
                        room_id INT,
                        customer_id INT,
                        check_in_date DATETIME2 DEFAULT CURRENT_TIMESTAMP,
                        check_out_date DATETIME2 DEFAULT CURRENT_TIMESTAMP,
                        price_per_night DECIMAL(10, 2),
                        [reservation_id]
                        -- Computed column using DATEDIFF
                        total_price AS (DATEDIFF(DAY, check_in_date, check_out_date) * price_per_night),

                        CONSTRAINT pk_reservation_reservation_id PRIMARY KEY (reservation_id),
                        CONSTRAINT fk_reservation_room_id FOREIGN KEY (room_id) REFERENCES ROOMS(room_id),
                        CONSTRAINT fk_reservation_customer_id FOREIGN KEY (customer_id) REFERENCES CUSTOMERS(customer_id),
	                    CONSTRAINT chk_reservation_date CHECK(check_out_date > check_in_date)
                    );
                    ";

                using (var tableCmd = new SqlCommand(tableQuery, appConnection))
                {
                    tableCmd.ExecuteNonQuery();
                }
            }
        }

        public static bool TestConnection()
        {
            try
            {
                using var connection =
                    DatabaseConnection.GetConnection();

                connection.Open();

                using var command = new SqlCommand($"SELECT dbName = '{DatabaseConnection.Database}';", connection);

                return string.Equals(
                    command.ExecuteScalar()?.ToString(),
                    DatabaseConnection.Database,
                    StringComparison.OrdinalIgnoreCase);
            }
            catch (SqlException se)
            {
                Console.WriteLine($"SQL Error: {se.Message}");
                return false;
            }
        }
    }
}
