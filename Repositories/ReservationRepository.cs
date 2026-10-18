using System;
using System.Collections.Generic;
using Hotel_Management.Data;
using System.Data.SqlClient;


namespace Hotel_Management.Repositories
{
    public class ReservationRepository
    {
        public void AddReservation(int reservationId,
            int customerId,
            int roomId,
            decimal pricePerNight,
            DateTime checkInDate,
            DateTime checkOutDate
        )
        {
            string query = @"
                    INSERT INTO dbo.RESERVATIONS (reservation_id, customer_id, room_id, price_per_night, check_in_date, check_out_date)
                    VALUES (@ReservationId, @CustomerId, @RoomId, @PricePerNight, @CheckInDate, @CheckOutDate)";


            using var connection = DatabaseConnection.GetConnection();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ReservationId", reservationId);
                command.Parameters.AddWithValue("@CustomerId", customerId);
                command.Parameters.AddWithValue("@RoomId", roomId);
                command.Parameters.AddWithValue("@PricePerNight", pricePerNight);
                command.Parameters.AddWithValue("@CheckInDate", checkInDate);
                command.Parameters.AddWithValue("@CheckOutDate", checkOutDate);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error adding reservation: {ex.Message}");
                    throw;
                }

            }

        }
        public void UpdateReservation(
            int reservationId,
            int customerId,
            int roomId,
            decimal pricePerNight,
            DateTime checkInDate,
            DateTime checkOutDate
        )
        {
            string query = @"
                    UPDATE dbo.RESERVATIONS
                    SET customer_id = @CustomerId,
                        room_id = @RoomId,
                        price_per_night = @PricePerNight,
                        check_in_date = @CheckInDate,
                        check_out_date = @CheckOutDate
                    WHERE reservation_id = @ReservationId";

            using var connection = DatabaseConnection.GetConnection();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ReservationId", reservationId);
                command.Parameters.AddWithValue("@CustomerId", customerId);
                command.Parameters.AddWithValue("@RoomId", roomId);
                command.Parameters.AddWithValue("@PricePerNight", pricePerNight);
                command.Parameters.AddWithValue("@CheckInDate", checkInDate);
                command.Parameters.AddWithValue("@CheckOutDate", checkOutDate);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error updating reservation: {ex.Message}");
                    throw;
                }
            }

        }

        public void DeleteReservation(int reservationId)
        {
            string query = @"
                    DELETE FROM dbo.RESERVATIONS
                    WHERE reservation_id = @ReservationId";
            using var connection = DatabaseConnection.GetConnection();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ReservationId", reservationId);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error deleting reservation: {ex.Message}");
                    throw;
                }
            }

        }

    }

}
