
using System;
using System.Data.SqlClient;

namespace Hotel_Management.Data {
    public static class DatabaseInitializer {
        public static void Initialize() {
            try {
                // STEP 1: Create database if it doesn't exist

                using (var connection =
                    DatabaseConnection.GetMasterConnection()) {
                    connection.Open();

                    string checkDatabase = @"
                        IF DB_ID(N'StayEasy') IS NULL
                            BEGIN
                            DECLARE @DataPath NVARCHAR(4000);

                        SET @DataPath =
                            CAST(SERVERPROPERTY('InstanceDefaultDataPath')
                            AS NVARCHAR(4000));

                        IF @DataPath IS NOT NULL
                            AND EXISTS (
                            SELECT 1
                            FROM sys.dm_os_file_exists(
                                @DataPath + N'StayEasy.mdf'
                            )
                        WHERE file_exists = 1
                        )
                        BEGIN
                            THROW 50001,
                            'StayEasy.mdf already exists but the database is not attached. Please inspect or attach the existing database.',
                                1;
                        END

                            CREATE DATABASE StayEasy;
                        END";

                    using (var cmd =
                        new SqlCommand(checkDatabase, connection)) {
                        cmd.ExecuteNonQuery();
                    }
                }


                // STEP 2: Connect to StayEasy
                using (var connection =
                    DatabaseConnection.GetConnection()) {
                    connection.Open();

                    // STEP 3: Create ROOMS table if missing
                    string createRooms = @"
                        IF OBJECT_ID(N'dbo.ROOMS', N'U') IS NULL
                        BEGIN
                            CREATE TABLE dbo.ROOMS
                            (
                                room_id INT IDENTITY(1,1) NOT NULL,
                                room_number INT NOT NULL,
                                room_type VARCHAR(25),
                                price DECIMAL(10,2),
                                room_status VARCHAR(36),
                                createAt DATETIME2 DEFAULT CURRENT_TIMESTAMP,

                                CONSTRAINT pk_rooms_room_id
                                    PRIMARY KEY (room_id),

                                CONSTRAINT uq_rooms_room_number
                                    UNIQUE (room_number),

                                CONSTRAINT chk_rooms_room_status
                                    CHECK (room_status IN
                                    ('Available', 'Reserved',
                                     'Occupied', 'Maintenance')),

                                CONSTRAINT chk_rooms_room_type
                                    CHECK (room_type IN
                                    ('Single', 'Double', 'Twin',
                                     'Vip', 'Suite', 'Family'))
                            );
                        END";

                    ExecuteSql(connection, createRooms);

                    // STEP 4: Create CUSTOMERS table if missing
                    string createCustomers = @"
                        IF OBJECT_ID(N'dbo.CUSTOMERS', N'U') IS NULL
                        BEGIN
                            CREATE TABLE dbo.CUSTOMERS
                            (
                                customer_id INT IDENTITY(1,1) NOT NULL,
                                name VARCHAR(36) NOT NULL,
                                gender VARCHAR(10),
                                phone VARCHAR(20),
                                email VARCHAR(100),
                                createAt DATETIME2 DEFAULT CURRENT_TIMESTAMP,

                                CONSTRAINT pk_customers_customer_id
                                    PRIMARY KEY (customer_id)
                            );
                        END";

                    ExecuteSql(connection, createCustomers);

                    // STEP 5: Create RESERVATIONS table if missing
                    string createReservations = @"
                        IF OBJECT_ID(N'dbo.RESERVATIONS', N'U') IS NULL
                        BEGIN
                            CREATE TABLE dbo.RESERVATIONS
                            (
                                reservation_id INT IDENTITY(1,1) NOT NULL,
                                room_id INT NOT NULL,
                                customer_id INT NOT NULL,
                                reservation_status VARCHAR(36) NOT NULL,
                                check_in_date DATETIME2 NOT NULL,
                                check_out_date DATETIME2 NOT NULL,
                                price_per_night DECIMAL(10,2) NOT NULL,

                                total_price AS
                                (
                                    DATEDIFF(DAY, check_in_date, check_out_date)
                                    * price_per_night
                                ),

                                CONSTRAINT pk_reservation_reservation_id
                                    PRIMARY KEY (reservation_id),

                                CONSTRAINT fk_reservation_room_id
                                    FOREIGN KEY (room_id)
                                    REFERENCES dbo.ROOMS(room_id),

                                CONSTRAINT fk_reservation_customer_id
                                    FOREIGN KEY (customer_id)
                                    REFERENCES dbo.CUSTOMERS(customer_id),

                                CONSTRAINT chk_reservation_date
                                    CHECK (check_out_date > check_in_date),

                                CONSTRAINT chk_reservation_reservation_status
                                    CHECK (reservation_status IN
                                    ('Reserved', 'Cancelled',
                                     'Checked-In', 'Check-Out'))
                            );
                        END";

                    ExecuteSql(connection, createReservations);
                }
            } catch (Exception ex) {
                throw new Exception(
                    "Database initialization failed: " + ex.Message, ex);
            }
        }

        private static void ExecuteSql(
            SqlConnection connection,
            string query) {
            using (var cmd = new SqlCommand(query, connection)) {
                cmd.ExecuteNonQuery();
            }
        }
    }
}
