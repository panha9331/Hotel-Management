using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Hotel_Management.Models
{
    public class ReservationModel
    {

        [DisplayName("ID")]
        public int ReservationId { get; set; }
        [DisplayName("C ID")]
        public int CustomerId { get; set; }
        [DisplayName("R ID")]
        public int RoomId { get; set; }
        [DisplayName("STATUS")]
        public string ReservationStatus { get; set; } = "Reserved";
        [DisplayName("PRICE")]
        public Decimal PricePerNight { get; set; }

        [DisplayName("C_IN")]
        public DateTime CheckInDate { get; set; }
        [DisplayName("C_OUT")]
        public DateTime CheckOutDate { get; set; }
        // Computed property: automatically calculates when requested
        [DisplayName("PAYMENT")]
        public decimal TotalPrice => (decimal)(CheckOutDate - CheckInDate).TotalDays * PricePerNight;
    }
}
