
using Hotel_Management.Repositories;
using Hotel_Management.State;
using Hotel_Management.Models;

namespace Hotel_Management.Services
{
    public class RoomService
    {
        private readonly RoomRepository _roomRepository;
        private readonly StateModel _state;
        public RoomService(
            RoomRepository roomRepository,
            StateModel state
            )
        {
            _roomRepository = roomRepository;
            _state = state;
        }

        //Reads the current in-memory collection
        public IReadOnlyList<RoomModel> GetRooms()
        {
            return _state.Rooms.AsReadOnly();
        }

        //Queries the database and populates AppState
        public void LoadRoom()
        {
            //calls GetAllRooms() and stores the results in AppState so other forms can reuse them.
            _state.Rooms = _roomRepository.GetAllRoom();
        
        }

        public void AddRoom(
            int roomId,
            int roomNumber,
            string roomType,
            decimal pricePerNight,
            string roomStatus)
        {
            ValidateRoom(
                roomId,
                roomNumber,
                roomType,
                pricePerNight,
                roomStatus);

            _roomRepository.AddRoom(
                roomId,
                roomNumber,
                roomType.Trim(),
                pricePerNight,
                roomStatus.Trim());
        }

        public void UpdateRoom(
            int roomId,
            int roomNumber,
            string roomType,
            decimal pricePerNight,
            string roomStatus)
        {
            ValidateRoom(
                roomId,
                roomNumber,
                roomType,
                pricePerNight,
                roomStatus);

            _roomRepository.UpdateRoom(
                roomId,
                roomNumber,
                roomType.Trim(),
                pricePerNight,
                roomStatus.Trim());
        }

        public void DeleteRoom(int roomId)
        {
            if (roomId <= 0)
            {
                throw new ArgumentException(
                    "Invalid room ID.");
            }

            _roomRepository.DeleteRoom(roomId);
        }

        private static void ValidateRoom(
            int roomId,
            int roomNumber,
            string roomType,
            decimal pricePerNight,
            string roomStatus)
        {
            if (roomId <= 0)
                throw new ArgumentException(
                    "Room ID must be greater than zero.");

            if (roomNumber <= 0)
                throw new ArgumentException(
                    "Room number must be greater than zero.");

            if (string.IsNullOrWhiteSpace(roomType))
                throw new ArgumentException(
                    "Room type is required.");

            if (pricePerNight <= 0)
                throw new ArgumentException(
                    "Price per night must be greater than zero.");

            string[] allowedStatuses =
            {
                "Available",
                "Occupied",
                "Maintenance",
                "Reserved",
            };

            if (string.IsNullOrWhiteSpace(roomStatus) ||
                !allowedStatuses.Contains(
                    roomStatus.Trim(),
                    StringComparer.OrdinalIgnoreCase))
            {
                throw new ArgumentException(
                    "Invalid room status.");
            }
        }
    }
}
