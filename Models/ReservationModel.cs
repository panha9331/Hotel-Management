using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Management.Models
{
    public class ReservationModel
    {
        public int ReservationId { get; set; }
        public int CustomerId { get; set; }
        public int RoomId { get; set; }

        public Decimal PricePerNight { get; set; }


        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        // Computed property: automatically calculates when requested
        public decimal TotalPrice => (decimal)(CheckOutDate - CheckInDate).TotalDays * PricePerNight;
    }
}
