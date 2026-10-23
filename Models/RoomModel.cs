using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Management.Models

{
    public class RoomSummary
    {
        public int totalRooms { get; set; }
        public int availableRooms { get; set; }
        public int occupiedRooms { get; set; }
        public int reservedRooms { get; set; }
    }
    public enum RoomStatus
    {
        Available,
        Occupied,
        Reserved,
        Maintenance 
    }
    public enum RoomType
    {
        Single,
        Double,
        Suite,
        Vip,
        Twin,
        Family
    }
    public class RoomModel
    {
        public int RoomId { get; set; }
        public int RoomNumber { get; set; }
        public RoomType RoomType { get; set; } = RoomType.Single;

        public Decimal Price { get; set; } = new Decimal(0);
        public RoomStatus Status { get; set; } = RoomStatus.Available;

        
    }
}
