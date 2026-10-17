using Hotel_Management.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Management.Repositories
{
    public class RoomRepository
    {
        public void AddRoom(string roomNumber,
                            string roomType,
                            decimal pricePerNight)
        {
            using var connection =
                DatabaseConnection.GetConnection();

            connection.Open();

            using var command = connection.CreateCommand();

            command.CommandText = @"
                INSERT INTO Rooms
                    (RoomNumber, RoomType, PricePerNight, Status)
                VALUES
                    ($number, $type, $price, 'Available');";

            command.Parameters.AddWithValue(
                "$number", roomNumber);

            command.Parameters.AddWithValue(
                "$type", roomType);

            command.Parameters.AddWithValue(
                "$price", pricePerNight);

            command.ExecuteNonQuery();
        }
    }
}
