using Hotel_Management.Helpers;
using Hotel_Management.Models;
using Hotel_Management.Repositories;
using Hotel_Management.Services;
using Hotel_Management.State;



namespace Hotel_Management.ReservationManagement {
    public partial class ReservationControl : UserControl {
        private readonly ReservationRepository _reservationRepository;
        private readonly ReservationService _reservationService;

        private readonly RoomService _roomService;
        private readonly CustomerService _customerService;


        //private readonly StateModel _stateModel;

        public ReservationControl(
                ReservationService reservationService,
                ReservationRepository reservationReposotory,
                RoomService roomService,
                CustomerService customerService
            ) {
            InitializeComponent();

            _reservationService = reservationService;
            _reservationRepository = reservationReposotory;
            _roomService = roomService;
            _customerService = customerService;

            // Attach the DataBindingComplete event handler
            dgvReservations.DataBindingComplete += dgvReservations_DataBindingComplete;
        }

        private void ReservationControl_Load(object sender, EventArgs e) {
            _customerService.LoadCustomer();
            _roomService.LoadRoom();
            LoadReservatioSelection();
            _reservationService.LoadReservation();
            UpdateReservationSummary();
            GetNextReservationId();

            LoadDgvReservation();


            cbReservationStatus.SelectedIndex = 3;

            filterByStatus.SelectedIndex = 0;
            checkInDate.Value = DateTime.Today;
            checkOutDate.Value = DateTime.Today.AddDays(1);
        }

        public void UpdateTotalPayment() {
            var selectedRoom = cbRoomSelection.SelectedItem as RoomModel;

            if (selectedRoom == null) {
                AppMessageBox.Show(
                    this,
                    "Room Required",
                    "Unable to retrieve the selected room.",
                    MessageType.Warning);
                return;
            }

            decimal price = selectedRoom.Price;

            int nights = (checkOutDate.Value - checkInDate.Value).Days;


            lbNight.Text = nights.ToString();
            lbTotalPayment.Text = (price * nights).ToString();

        }
        public void UpdateReservationSummary() {
            var summary = _reservationService.GetReservationSummary();
            lbTotalReservations.Text = summary.TotalReservation.ToString();
            lbTotalReservedStatus.Text = summary.TotalReserved.ToString();
            lbTotalCheckedIn.Text = summary.TotalCheckedIn.ToString();
            lbTotalCheckedOut.Text = summary.TotalCheckedOut.ToString();
        }
        private void GetNextReservationId() {
            var nextId = _reservationService.GetNextReservationId();
            txtReservationId.Text = nextId.ToString();
        }
        private void LoadDgvReservation() {
            dgvReservations.DataSource = null;

            dgvReservations.DataSource = _reservationService.GetReservations().ToList();


            dgvReservations.ClearSelection();
            dgvReservations.CurrentCell = null;

            CustomDgvReservation();
        }
        private void LoadReservatioSelection() {
            var customers = _reservationService.LoadCustomersSelection().ToList();

            var rooms = _reservationService.LoadRoomsSelection().ToList();

            // Customer selection
            cbCuctomerSelection.DataSource = null;
            cbCuctomerSelection.DataSource = customers;
            cbCuctomerSelection.DisplayMember = nameof(CustomerModel.CustomerDisplay);
            cbCuctomerSelection.ValueMember = nameof(CustomerModel.CustomerId);

            // Room selection
            cbRoomSelection.DataSource = null;
            cbRoomSelection.DataSource = rooms;
            cbRoomSelection.DisplayMember = nameof(RoomModel.RoomDisplay);
            cbRoomSelection.ValueMember = nameof(RoomModel.RoomId);

        }
        private void btBookRoom_Click(object sender, EventArgs e) {


        }

        private void btCheckIn_Click(object sender, EventArgs e) {
            string status = "Checked-In";

            UpdateReservationStatus(status);
        }

        private void btCheckOut_Click(object sender, EventArgs e) {
            string status = "Checked-Out";
            UpdateReservationStatus(status);

        }
        private void btCancel_Click(object sender, EventArgs e) {
            string status = "Cancelled";

            UpdateReservationStatus(status);
        }
        private void UpdateReservationStatus(string newStatus) {
            // 1. Get selected reservation
            var selectedReservation =
                dgvReservations.CurrentRow?.DataBoundItem as ReservationModel;

            if (selectedReservation == null) {
                AppMessageBox.Show(
                    this,
                    "Reservation Required",
                    "Please select a reservation first.",
                    MessageType.Warning);
                return;
            }

            // 2. Get the room associated with the reservation
            var selectedRoom = cbRoomSelection.SelectedItem as RoomModel;

            if (selectedRoom == null ||
                selectedRoom.RoomId != selectedReservation.RoomId) {
                AppMessageBox.Show(
                    this,
                    "Room Unavailable",
                    "Unable to retrieve the reservation's room.",
                    MessageType.Warning);
                return;
            }

            // 3. Validate reservation status transitions
            string currentStatus =
                selectedReservation.ReservationStatus;

            if (newStatus == "Checked-In" &&
                currentStatus != "Reserved") {
                AppMessageBox.Show(
                    this,
                    "Invalid Status",
                    "Only reserved reservations can be checked in.",
                    MessageType.Warning);
                return;
            }

            if (newStatus == "Checked-Out" && currentStatus != "Checked-In") {
                AppMessageBox.Show(
                    this,
                    "Invalid Status",
                    "Only checked-in reservations can be checked out.",
                    MessageType.Warning);
                return;
            }

            if (newStatus == "Cancelled" && currentStatus != "Reserved") {
                AppMessageBox.Show(
                    this,
                    "Invalid Status",
                    "Only reserved reservations can be cancelled.",
                    MessageType.Warning);
                return;
            }

            // 4. Validate dates
            DateTime checkIn = selectedReservation.CheckInDate.Date;
            DateTime checkOut = selectedReservation.CheckOutDate.Date;

            if (checkOut <= checkIn) {
                AppMessageBox.Show(
                    this,
                    "Invalid Dates",
                    "Check-out date must be after check-in date.",
                    MessageType.Warning);
                return;
            }

            // 5. Determine room status separately
            RoomStatus? newRoomStatus = null;

            if (newStatus == "Checked-In") {
                if (selectedRoom.Status != RoomStatus.Available) {
                    AppMessageBox.Show(
                        this,
                        "Room Unavailable",
                        "This room is not available.",
                        MessageType.Warning);
                    return;
                }

                newRoomStatus = RoomStatus.Occupied;
            } else if (newStatus == "Checked-Out") {
                newRoomStatus = RoomStatus.Available;
            }

            try {
                // 6. Update reservation status
                _reservationService.UpdateReservation(
                    selectedReservation.ReservationId,
                    selectedReservation.CustomerId,
                    selectedReservation.RoomId,
                    newStatus,
                    selectedReservation.PricePerNight,
                    checkIn,
                    checkOut
                );

                // 7. Update room status only when necessary
                if (newRoomStatus.HasValue) {
                    _roomService.UpdateRoom(
                        selectedRoom.RoomId,
                        selectedRoom.RoomNumber,
                        selectedRoom.RoomType.ToString(),
                        selectedRoom.Price,
                        newRoomStatus.Value.ToString()
                    );
                }

                // 8. Refresh data
                _reservationService.LoadReservation();

                LoadDgvReservation();
                UpdateReservationSummary();

                AppMessageBox.Show(
                    this,
                    $"Reservation {newStatus}",
                    $"Reservation was successfully {newStatus.ToLowerInvariant()}.",
                    MessageType.Success
                );
                LoadReservatioSelection();
            } catch (ArgumentException ex) {
                AppMessageBox.Show(
                    this,
                    "Validation Error",
                    ex.Message,
                    MessageType.Warning
                );
            } catch (Exception ex) {
                AppMessageBox.Show(
                    this,
                    "Error",
                    "An error occurred: " + ex.Message,
                    MessageType.Error
                );
            }
        }


        private void btBookRoom_Click_1(object sender, EventArgs e) {

            string status = cbReservationStatus.SelectedItem?.ToString() ?? string.Empty;

            // Get the actual price from the selected room.
            var selectedRoom = cbRoomSelection.SelectedItem as RoomModel;
            var selectedCustomer = cbCuctomerSelection.SelectedItem as CustomerModel;


            if (selectedRoom == null) {
                AppMessageBox.Show(
                    this,
                    "Room Required",
                    "Unable to retrieve the selected room.",
                    MessageType.Warning);
                return;
            }

            if (selectedCustomer == null) {
                AppMessageBox.Show(
                    this,
                    "Customer Required",
                    "Please select a customer for the reservation.",
                    MessageType.Warning);
                return;
            }

            if (selectedRoom.Status != RoomStatus.Available) {
                AppMessageBox.Show(
                    this,
                    "Room Unavailable",
                    "Selected room is not available for booking.",
                    MessageType.Warning);
                return;
            }

            decimal price = selectedRoom.Price;

            DateTime checkIn = checkInDate.Value.Date;
            DateTime checkOut = checkOutDate.Value.Date;

            if (checkOut <= checkIn) {
                AppMessageBox.Show(
                    this,
                    "Invalid Dates",
                    "Check-out date must be after check-in date.",
                    MessageType.Warning);
                return;
            }



            try {
                _reservationService.AddReservation(
                    selectedCustomer.CustomerId,
                    selectedRoom.RoomId,
                    status,
                    price,
                    checkIn,
                    checkOut

                );

                AppMessageBox.Show(
                    this,
                    "Reservation Successful",
                    "The room has been reserved successfully!",
                    MessageType.Success
                 );

                LoadReservatioSelection();

                _reservationService.LoadReservation();
                LoadDgvReservation();
                GetNextReservationId();
                UpdateReservationSummary();
            } catch (ArgumentException ex) {
                AppMessageBox.Show(
                    this,
                    "Validation Error",
                    ex.Message,
                    MessageType.Warning
                 );
            } catch (FormatException) {
                AppMessageBox.Show(
                    this,
                    "Validation Error",
                    "Please enter valid numeric values.",
                    MessageType.Warning);
            } catch (Exception ex) {
                AppMessageBox.Show(
                    this,
                    "Reservation Error",
                    ex.Message,
                    MessageType.Error);
            }
        }

        private void CustomDgvReservation() {
            dgvReservations.Columns["ReservationId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReservations.Columns["CustomerId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvReservations.Columns["RoomId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvReservations.Columns["ReservationStatus"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells; // Stretches to fill space
            dgvReservations.Columns["PricePerNight"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReservations.Columns["CheckInDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvReservations.Columns["CheckOutDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvReservations.Columns["TotalPrice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void ReloadInputField() {
            var selectedReservation =
                dgvReservations.CurrentRow?.DataBoundItem as ReservationModel;

            if (selectedReservation == null)
                return;

            // Update reservation status
            cbReservationStatus.Text =
                selectedReservation.ReservationStatus.ToString();

            // Automatically select customer
            cbCuctomerSelection.SelectedItem =
                cbCuctomerSelection.Items
                    .Cast<CustomerModel>()
                    .FirstOrDefault(c => c.CustomerId == selectedReservation.CustomerId);

            // Automatically select room
            cbRoomSelection.SelectedItem =
                cbRoomSelection.Items
                    .Cast<RoomModel>()
                    .FirstOrDefault(r =>
                        r.RoomId == selectedReservation.RoomId);

            // Update dates
            checkInDate.Value = selectedReservation.CheckInDate;
            checkOutDate.Value = selectedReservation.CheckOutDate;
        }

        private void dgvReservations_SelectionChanged(object sender, EventArgs e) {
            if (dgvReservations.SelectedRows.Count == 0 || !dgvReservations.Focused)
                return;
            ReloadInputField();
        }

        private void checkInDate_ValueChanged(object sender, EventArgs e) {
            UpdateTotalPayment();
        }

        private void checkOutDate_ValueChanged(object sender, EventArgs e) {
            UpdateTotalPayment();

        }

        private void cbRoomSelection_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateTotalPayment();
        }

        private void filterByStatus_SelectedIndexChanged(object sender, EventArgs e) {
            ApplyReservationFilter();
        }
        private void ApplyReservationFilter() {
            string? status = filterByStatus.SelectedIndex <= 0 ? null :
                filterByStatus.SelectedItem?.ToString();

            dgvReservations.DataSource = null;
            dgvReservations.DataSource = _reservationService.FilterByStatus(status).ToList();

            CustomDgvReservation();
        }

        private void btRest_Click(object sender, EventArgs e) {
            filterByStatus.SelectedIndex = 0;
        }

        private void txtSearch_Enter(object sender, EventArgs e) {
            if (txtSearch.Text == "Search by Reservaion ID, Customer, Room ...") {
                txtSearch.Clear();
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(txtSearch.Text)) {

                txtSearch.Text = "Search by Reservaion ID, Customer, Room ...";
                LoadDgvReservation();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            SearchReservation();
        }

        private void SearchReservation() {
            if (string.IsNullOrWhiteSpace(txtSearch.Text)) {
                LoadDgvReservation();
                return;
            }

            dgvReservations.DataSource = null;

            dgvReservations.DataSource = _reservationService.SearchReservations(txtSearch.Text).ToList();
            CustomDgvReservation();
        }

        private void dgvReservations_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            dgvReservations.ClearSelection();
            dgvReservations.CurrentCell = null;
        }

    }
}
