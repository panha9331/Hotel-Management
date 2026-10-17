using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Management.Models
{
    public enum RoomStatus
    {
        Available,
        Occupied,
        Reserved,
        Maintenance 
    }
    public class Room
    {
        public int RoomId { get; set; }
        public int RoomNumber { get; set; }

        public Decimal Price { get; set; } = new Decimal(0);
        public int Capacity { get; set; } = 1;
        public RoomStatus Status { get; set; } = RoomStatus.Available;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}
