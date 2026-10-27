using Hotel_Management.Models;
using Hotel_Management.Repositories;
using Hotel_Management.Services;
using Hotel_Management.State;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Hotel_Management.ReservationManagement {
    public partial class ReservationControl : UserControl {
        private readonly ReservationRepository _reservationRepository;
        private readonly ReservationService _reservationService;
        //private readonly StateModel _stateModel;

        public ReservationControl(ReservationService reservationService, ReservationRepository reservationReposotory) {
            InitializeComponent();

            _reservationService = reservationService;
            _reservationRepository = reservationReposotory;
        }

        private void ReservationControl_Load(object sender, EventArgs e) {
            LoadReservatioSelection();
            _reservationService.LoadReservation();
            LoadDgvReservation();
            CustomDgvReservation();
        }

        private void LoadDgvReservation() {
            dgvReservations.DataSource = null;

            dgvReservations.DataSource = _reservationService.GetReservations().ToList();

            CustomDgvReservation();
        }
        private void LoadReservatioSelection() {
            var customers = _reservationService.LoadCustomersSelection().ToList();

            var rooms = _reservationService.LoadRoomsSelection().ToList();

            // Customer selection
            cbCuctomerSelection.DataSource = null;
            cbCuctomerSelection.DataSource = customers;
            cbCuctomerSelection.DisplayMember = nameof(CustomerModel.CustomerDisplay);
            cbCuctomerSelection.ValueMember = nameof(CustomerModel.CustomerID);

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
            updateReservationStatus(status);

        }

        private void btCancel_Click(object sender, EventArgs e) {
            string status = "Cancelled";

            updateReservationStatus(status);
        }

        private void updateReservationStatus(string? status) {

            var selectedReservation = dgvReservations.CurrentRow?.DataBoundItem as ReservationModel;
            // Get the actual price from the selected room.
            var selectedRoom = cbRoomSelection.SelectedItem as RoomModel;

            if (selectedRoom == null) {
                MessageBox.Show("Unable to retrieve the selected room.");
                return;
            }

            decimal price = selectedRoom.Price;

            DateTime checkIn = checkInDate.Value.Date;
            DateTime checkOut = checkOutDate.Value.Date;

            if (checkOut <= checkIn) {
                MessageBox.Show("Check-out date must be after check-in date.");
                return;
            }

            try {
                _reservationService.UpdateReservation(
                    selectedReservation.ReservationId,
                    Convert.ToInt32(cbCuctomerSelection.SelectedValue),
                    Convert.ToInt32(cbRoomSelection.SelectedValue),
                    status,
                    price,
                    checkIn,
                    checkOut
                );

                _reservationService.LoadReservation();
                LoadDgvReservation();
                MessageBox.Show(status + " successfully.");

                //GetNextReservationId();
            } catch (ArgumentException ex) {
                MessageBox.Show(
                    ex.Message,
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            } catch (FormatException) {
                MessageBox.Show(
                    "Please enter valid numeric values.");
            }
            //catch (System.Data.SqlClient.SqlException) {
            //    MessageBox.Show(
            //        "Database operation failed. Check the database and Reservation data.");
            //}

            //UpdateCustomerSummary();
        }

        private void btBookRoom_Click_1(object sender, EventArgs e) {

            string status = cbReservationStatus.SelectedItem.ToString();

            // Get the actual price from the selected room.
            var selectedRoom = cbRoomSelection.SelectedItem as RoomModel;

            if (selectedRoom == null) {
                MessageBox.Show("Unable to retrieve the selected room.");
                return;
            }

            decimal price = selectedRoom.Price;

            DateTime checkIn = checkInDate.Value.Date;
            DateTime checkOut = checkOutDate.Value.Date;

            if (checkOut <= checkIn) {
                MessageBox.Show("Check-out date must be after check-in date.");
                return;
            }

            try {
                _reservationService.AddReservation(
                    Convert.ToInt32(cbCuctomerSelection.SelectedValue),
                    Convert.ToInt32(cbRoomSelection.SelectedValue),
                    status,
                    price,
                    checkIn,
                    checkOut

                );
                _reservationService.LoadReservation();
                LoadDgvReservation();
                MessageBox.Show("Booking added successfully.");

                //GetNextReservationId();
            } catch (ArgumentException ex) {
                MessageBox.Show(
                    ex.Message,
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            } catch (FormatException) {
                MessageBox.Show(
                    "Please enter valid numeric values.");
            }
            //catch (System.Data.SqlClient.SqlException) {
            //    MessageBox.Show(
            //        "Database operation failed. Check the database and Reservation data.");
            //}

            //UpdateCustomerSummary();
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

        private void btCheckOut_Click(object sender, EventArgs e) {
            string status = "Checked-Out";
            updateReservationStatus(status);

        }

        private void ReloadInputField() {
            var selectedReservation =
                dgvReservations.CurrentRow?.DataBoundItem as ReservationModel;

            if (selectedReservation == null)
                return;

            txtRoomId.Text = selectedReservation.ReservationId.ToString();

            cbReservationStatus.Text = selectedReservation.ReservationStatus.ToString();


            cbCuctomerSelection.SelectedValue = selectedReservation.CustomerId;


            cbRoomSelection.SelectedValue = selectedReservation.RoomId;

            checkInDate.Value = selectedReservation.CheckInDate;
            checkOutDate.Value = selectedReservation.CheckOutDate;
        }

        private void dgvReservations_SelectionChanged(object sender, EventArgs e) {
            ReloadInputField();
        }
    }
}
