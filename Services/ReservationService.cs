using Hotel_Management.Models;
using Hotel_Management.Repositories;
using Hotel_Management.State;
using System;
using System.Collections.Generic;
using System.Text;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;

namespace Hotel_Management.Services {
    public class ReservationService {
        private readonly StateModel _stateModel;
        private readonly ReservationRepository _reservationRepository;
        public ReservationService(ReservationRepository reservationRepository, StateModel stateModel) {
            _stateModel = stateModel;
            _reservationRepository = reservationRepository;
        }

        public IEnumerable<ReservationModel> SearchReservations(string? keyword) {
            IEnumerable<ReservationModel> reservations = _stateModel.Reservations;

            if (string.IsNullOrWhiteSpace(keyword)) {
                return reservations;
            }

            keyword = keyword.Trim();

            return reservations.Where(r => r.ReservationId.ToString().Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                    r.RoomId.ToString().Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                    r.CustomerId.ToString().Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                    r.ReservationStatus.ToString().Contains(keyword, StringComparison.OrdinalIgnoreCase)
                                    //r.RoomId.ToString().Contains(keyword, StringComparison.OrdinalIgnoreCase)
            );
        }
        public IEnumerable<ReservationModel> FilterByStatus(string? status) {
            IEnumerable<ReservationModel> reservations = _stateModel.Reservations;

            if(!string.IsNullOrWhiteSpace(status) && status != "All Statuses") {
                reservations = reservations.Where(r => r.ReservationStatus == status);
            }

            return reservations.ToList();   
        }
        public ReservationSummary GetReservationSummary() {
            var reservations = _stateModel.Reservations;


            var summary = new ReservationSummary {
                TotalReservation = reservations.Count(),
                TotalReserved = reservations.Count(r => r.ReservationStatus.Equals("Reserved", StringComparison.OrdinalIgnoreCase)),
                TotalCheckedIn = reservations.Count(r => r.ReservationStatus.Equals("Checked-In", StringComparison.OrdinalIgnoreCase)),
                TotalCheckedOut = reservations.Count(r => r.ReservationStatus.Equals("Checked-Out", StringComparison.OrdinalIgnoreCase) ||
                                                          r.ReservationStatus.Equals("Cancelled", StringComparison.OrdinalIgnoreCase)),
                
            };

            return summary;
        }
        public int GetNextReservationId() {
            var reservations = _stateModel.Reservations;
            var nextReservations = reservations.Any() ? reservations.Max(r => r.ReservationId) + 1 : 1;
            return nextReservations;
        }

        public void ChcekInOut(int reservationId, string? status) {
            ValidateCheckInOut(reservationId, status);
            _reservationRepository.CheckInOut(reservationId, status);
        }
        public IEnumerable<CustomerModel> LoadCustomersSelection() {
            //Load customers to selection 
            return _stateModel.Customers.ToList();
        }

        public IEnumerable<RoomModel> LoadAvialableRoom() {
            //Load available rooms to selection 
            IEnumerable<RoomModel> rooms = _stateModel.Rooms;
            return rooms.Where(r => r.Status.Equals(RoomStatus.Available)).ToList();
        }
        public IEnumerable<RoomModel> LoadRoomsSelection() {
            //Load customers to selection 
            IEnumerable<RoomModel> rooms = _stateModel.Rooms;
            return rooms;
        }

        public IReadOnlyList<ReservationModel> GetReservations() {
            return _stateModel.Reservations.AsReadOnly();
        }

        public void LoadReservation() {
            _stateModel.Reservations = _reservationRepository.GetAllReservation();
        }

        public void DeleteReservation(int reservationId) {
            if (reservationId <= 0) {
                throw new ArgumentException(
                    "Invalid reservation ID.");
            }
            _reservationRepository.DeleteReservation(reservationId);
        }
        public void UpdateReservation(
            int reservationId,
            int customerId,
            int roomId,
            string reservationStatus,
            decimal price,
            DateTime checkInDate,
            DateTime checkOutDate
        ) {
            ValidateReservation(
                customerId,
                roomId,
                reservationStatus,
                price,
                checkInDate,
                checkOutDate
            );

            _reservationRepository.UpdateReservation(
                reservationId,
                customerId,
                roomId,
                reservationStatus,
                price,
                checkInDate,
                checkOutDate
            );
        }

        public void AddReservation(
            int customerId,
            int roomId,
            string reservationStatus,
            decimal price,
            DateTime checkInDate,
            DateTime checkOutDate
        ) {
            ValidateReservation(
                customerId,
                roomId,
                reservationStatus,
                price,
                checkInDate,
                checkOutDate
            );

            _reservationRepository.AddReservation(
                customerId,
                roomId,
                reservationStatus,
                price,
                checkInDate,
                checkOutDate
            );
        }

        private void ValidateCheckInOut(int reservationId, string? status) {
            if (reservationId <= 0) {
                throw new ArgumentException(
                    "Please select Reservation first!");
            }

            string[] statuses = {
                "Check-In",
                "Check-Out"
            };

            Boolean validate = false;

            foreach (string s in statuses) {
                if (status.Equals(s.Trim(), StringComparison.OrdinalIgnoreCase)) {
                    validate = true;
                    break;
                }

            }

            if (!validate) {
                throw new ArgumentException(
                    "Error case check in string!");
            }

        }

        private void ValidateReservation(
            int customerId,
            int roomId,
            string reservationStatus,
            decimal price,
            DateTime checkInDate,
            DateTime checkOutDate

        ) {
            // Validate Customer ID
            if (customerId <= 0) {
                throw new ArgumentException(
                    "Customer ID must be greater than 0."
                );
            }

            // Validate Room ID
            if (roomId <= 0) {
                throw new ArgumentException(
                    "Room ID must be greater than 0."
                );
            }

            // Validate Reservation Status
            string[] validStatuses = {
                "Reserved",
                "Cancelled",
                "Checked-In",
                "Checked-Out",
            };

            if (string.IsNullOrWhiteSpace(reservationStatus)) {
                throw new ArgumentException(
                    "Reservation status is required."
                );
            }

            bool isValidStatus = false;

            foreach (string status in validStatuses) {
                if (status.Equals(
                    reservationStatus.Trim(),
                    StringComparison.OrdinalIgnoreCase
                )) {
                    isValidStatus = true;
                    break;
                }
            }

            if (!isValidStatus) {
                throw new ArgumentException(
                    "Invalid reservation status."
                );
            }

            // Validate Price
            if (price < 0) {
                throw new ArgumentException(
                    "Price cannot be negative."
                );
            }

            // Validate Check-in Date
            if (checkInDate == DateTime.MinValue) {
                throw new ArgumentException(
                    "Check-in date is required."
                );
            }

            // Validate Check-out Date
            if (checkOutDate == DateTime.MinValue) {
                throw new ArgumentException(
                    "Check-out date is required."
                );
            }

            // Check-out must be after check-in
            if (checkOutDate <= checkInDate) {
                throw new ArgumentException(
                    "Check-out date must be after check-in date."
                );
            }
        }
    }
}

