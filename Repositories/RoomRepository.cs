using Hotel_Management.Data;
using System;
using System.Data.SqlClient;

namespace Hotel_Management.Repositories
{
    public class RoomRepository
    {
        public void AddRoom(
            int roomId,
            int roomNumber,
            string roomType,
            decimal pricePerNight,
            string roomStatus
        )
        {
            string query = @"
                INSERT INTO dbo.ROOMS (room_id, room_number, room_type, price, room_status)
                VALUES (@id, @number, @type, @price, @status);";

            using var connection = DatabaseConnection.GetConnection();
            using var cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@id", roomId);
            cmd.Parameters.AddWithValue("@number", roomNumber);
            cmd.Parameters.AddWithValue("@type", roomType);
            cmd.Parameters.AddWithValue("@price", pricePerNight);
            cmd.Parameters.AddWithValue("@status", roomStatus);

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("[CREATE ERROR] " + ex.Message);
            }
        }

        public void UpdateRoom(
            int roomId,
            int roomNumber,
            string roomType,
            decimal pricePerNight,
            string roomStatus
        )
        {
            string query = @"
                UPDATE dbo.ROOMS 
                SET room_number = @number, 
                    room_type = @roomType, 
                    price_per_night = @price, 
                    room_status = @status 
                WHERE room_id = @id";

            using var connection = DatabaseConnection.GetConnection();
            using var cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@id", roomId);
            cmd.Parameters.AddWithValue("@number", roomNumber);
            cmd.Parameters.AddWithValue("@roomType", roomType);
            cmd.Parameters.AddWithValue("@price", pricePerNight);
            cmd.Parameters.AddWithValue("@status", roomStatus);

            try
            {
                connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    Console.WriteLine("[UPDATE WARNING] No record found with room_id: " + roomId);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[UPDATE ERROR] " + ex.Message);
            }
        }

        public void DeleteRoom(int roomId)
        {
            string query = "DELETE FROM dbo.ROOMS WHERE room_id = @id";

            using var connection = DatabaseConnection.GetConnection();
            using var cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@id", roomId);

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("[DELETE ERROR] " + ex.Message);
            }
        }
    }
}