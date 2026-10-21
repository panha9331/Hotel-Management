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
}
