using System;
using System.Collections.Generic;
using Hotel_Management.Data;
using System.Data.SqlClient;
using Hotel_Management.Models;


namespace Hotel_Management.Repositories {
    public class ReservationRepository {

        public void CheckInOut(
            int reservationId,
            string? status
        ) {
            
            string query = @"
                        UPDATE dbo.RESERVATIONS
                        SET reservation_status = @Status
                        WHERE reservation_id = @ReservationId";

            using var connection = DatabaseConnection.GetConnection();
            using (var cmd = new SqlCommand(query, connection)) {
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@ReservationId", reservationId);

                try {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }catch(Exception ex) {
                    Console.WriteLine("[ERROR CHECKIN/OUT" + ex);
                    throw;
                }
            }

        }
        public List<ReservationModel> GetAllReservation() {
            string query = @"
        SELECT
            reservation_id,
            customer_id,
            room_id,
            reservation_status,
            price_per_night,
            check_in_date,
            check_out_date
        FROM dbo.RESERVATIONS
        ORDER BY reservation_id;";

            var reservations = new List<ReservationModel>();

            using var connection = DatabaseConnection.GetConnection();
            using var cmd = new SqlCommand(query, connection);

            connection.Open();

            using var reader = cmd.ExecuteReader();

            while (reader.Read()) {
                reservations.Add(new ReservationModel {
                    ReservationId = Convert.ToInt32(reader["reservation_id"]),
                    CustomerId = Convert.ToInt32(reader["customer_id"]),
                    RoomId = Convert.ToInt32(reader["room_id"]),

                    ReservationStatus = reader["reservation_status"].ToString()!,

                    PricePerNight = Convert.ToDecimal(reader["price_per_night"]),

                    CheckInDate = Convert.ToDateTime(reader["check_in_date"]),
                    CheckOutDate = Convert.ToDateTime(reader["check_out_date"])
                });
            }

            return reservations;
        }

        public void AddReservation(
            int customerId,
            int roomId,
            string reservationStatus,
            decimal pricePerNight,
            DateTime checkInDate,
            DateTime checkOutDate
        ) {
            string query = @"
                    INSERT INTO dbo.RESERVATIONS (customer_id, room_id, reservation_status, price_per_night, check_in_date, check_out_date)
                    VALUES (@CustomerId, @RoomId, @ReservationStatus, @PricePerNight, @CheckInDate, @CheckOutDate)";


            using var connection = DatabaseConnection.GetConnection();
            using (SqlCommand command = new SqlCommand(query, connection)) {
                command.Parameters.AddWithValue("@CustomerId", customerId);
                command.Parameters.AddWithValue("@RoomId", roomId);
                command.Parameters.AddWithValue("@ReservationStatus", reservationStatus);
                command.Parameters.AddWithValue("@PricePerNight", pricePerNight);
                command.Parameters.AddWithValue("@CheckInDate", checkInDate);
                command.Parameters.AddWithValue("@CheckOutDate", checkOutDate);

                try {
                    connection.Open();
                    command.ExecuteNonQuery();
                } catch (Exception ex) {
                    Console.WriteLine($"Error adding reservation: {ex.Message}");
                    throw;
                }

            }

        }
        public void UpdateReservation(
            int reservationId,
            int customerId,
            int roomId,
            string reservationStatus,
            decimal pricePerNight,
            DateTime checkInDate,
            DateTime checkOutDate
        ) {
            string query = @"
                    UPDATE dbo.RESERVATIONS
                    SET customer_id = @CustomerId,
                        room_id = @RoomId,
                        reservation_status = @ReservationStatus,
                        price_per_night = @PricePerNight,
                        check_in_date = @CheckInDate,
                        check_out_date = @CheckOutDate
                    WHERE reservation_id = @ReservationId";

            using var connection = DatabaseConnection.GetConnection();
            using (SqlCommand command = new SqlCommand(query, connection)) {
                command.Parameters.AddWithValue("@ReservationId", reservationId);
                command.Parameters.AddWithValue("@CustomerId", customerId);
                command.Parameters.AddWithValue("@RoomId", roomId);
                command.Parameters.AddWithValue("@ReservationStatus", reservationStatus);
                command.Parameters.AddWithValue("@PricePerNight", pricePerNight);
                command.Parameters.AddWithValue("@CheckInDate", checkInDate);
                command.Parameters.AddWithValue("@CheckOutDate", checkOutDate);
                try {
                    connection.Open();
                    command.ExecuteNonQuery();
                } catch (Exception ex) {
                    Console.WriteLine($"Error updating reservation: {ex.Message}");
                    throw;
                }
            }

        }

        public void DeleteReservation(int reservationId) {
            string query = @"
                    DELETE FROM dbo.RESERVATIONS
                    WHERE reservation_id = @ReservationId";
            using var connection = DatabaseConnection.GetConnection();
            using (SqlCommand command = new SqlCommand(query, connection)) {
                command.Parameters.AddWithValue("@ReservationId", reservationId);
                try {
                    connection.Open();
                    command.ExecuteNonQuery();
                } catch (Exception ex) {
                    Console.WriteLine($"Error deleting reservation: {ex.Message}");
                    throw;
                }
            }

        }

    }

}
