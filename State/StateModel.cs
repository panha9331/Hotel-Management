using Hotel_Management.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Management.State
{
    public class StateModel
    {
        public List<RoomModel> Rooms { get; set; } = [];
        public List<CustomerModel> Customers { get; set; } = [];
        public List<ReservationModel> Reservations { get; set; } = [];
    }
}
