using Hotel_Management.Models;
using Hotel_Management.Repositories;
using Hotel_Management.Services;
//using Microsoft.UI.Xaml.Controls;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Hotel_Management.RoomManagement {
    public partial class RoomControl : UserControl {

        private readonly RoomService _roomService;
        private readonly RoomRepository _roomRepository;
        private readonly RoomModel roomModel = new RoomModel();
        public RoomControl(RoomService roomService, RoomRepository roomRepository) {
            InitializeComponent();
            _roomService = roomService;
            _roomRepository = roomRepository;
            roomType.SelectedIndexChanged += roomType_SelectedIndexChanged;
        }

        private void RoomControl_Load(object sender, EventArgs e) {
            _roomService.LoadRoom();

            pricePerNight.Minimum = 0;
            pricePerNight.Maximum = 1000000;
            pricePerNight.DecimalPlaces = 2;

            LoadComboBoxes();

            UpdateRoomSummary();

            GetNextRoomId();


            LoadDgvRooms();

        }

        private void btRoomAdd_Click(object sender, EventArgs e) {
            try {
                // Assign to model
                RoomType roomTypeSelected = (RoomType)roomType.SelectedItem!;
                RoomStatus roomStatusSelected = (RoomStatus)roomStatus.SelectedItem!;

                // 3. Pass clean data to service layer
                _roomService.AddRoom(
                    //int.Parse(roomId.Text),
                    int.Parse(roomNumber.Text),
                    roomTypeSelected.ToString(),
                    decimal.Parse(pricePerNight.Text),
                    roomStatusSelected.ToString() // Converts enum cleanly to string for DB insertion
                );

                _roomService.LoadRoom();

                UpdateRoomSummary();

                LoadDgvRooms();
                MessageBox.Show("Room added successfully.");
            } catch (ArgumentException ex) {
                MessageBox.Show(
                    ex.Message,
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            } catch (FormatException) {
                MessageBox.Show(
                    "Please enter valid numeric values.");
            } catch (System.Data.SqlClient.SqlException) {
                MessageBox.Show(
                    "Database operation failed. Check the database and room data.");
            }
        }
        private void GetPriceByRoomType() {
            if (roomType.SelectedItem is not RoomType selectedRoomType)
                return;

            decimal price = _roomService.GetPriceByRoomType(selectedRoomType);
            pricePerNight.Value = price;
        }

        private void GetNextRoomId() {
            int nextRoomId = _roomService.GetNextRoomId();
            roomId.Text = nextRoomId.ToString();
        }

        private void UpdateRoomSummary() {
            var summary = _roomService.GetRoomSummary();
            lbTotalRooms.Text = summary.totalRooms.ToString();
            lbAvailableRooms.Text = summary.availableRooms.ToString();
            lbOccupiedRooms.Text = summary.occupiedRooms.ToString();
            lbReservedRooms.Text = summary.reservedRooms.ToString();
        }

        private void LoadDgvRooms() {
            dgvRooms.DataSource = _roomService.GetRooms().ToList();
            CustomDgvRoom();
        }

        private void LoadComboBoxes() {
            roomType.DataSource = Enum.GetValues(typeof(RoomType));
            roomStatus.DataSource = Enum.GetValues(typeof(RoomStatus));

            var statusList = Enum.GetNames(typeof(RoomStatus)).ToList();

            statusList.Insert(0, "All Statuses");

            var typeList = Enum.GetNames(typeof(RoomType)).ToList();
            typeList.Insert(0, "All Types");

            filterStatus.DataSource = statusList;
            filterType.DataSource = typeList;



        }

        private void roomType_SelectedIndexChanged(object sender, EventArgs e) {
            if (roomType.SelectedItem is RoomType selectedType) {
                GetPriceByRoomType();
            }
        }

        private void btRoomDelete_Click(object sender, EventArgs e) {
            var selectedRoom = dgvRooms.CurrentRow?.DataBoundItem as RoomModel;
            try {
                _roomService.DeleteRoom(selectedRoom.RoomId);
                _roomService.LoadRoom();
                LoadDgvRooms();
                UpdateRoomSummary();
            } catch (Exception ex) {
                MessageBox.Show("Error occurred while deleting room: " + ex.Message);
            }
        }

        private void btRoomUpdate_Click(object sender, EventArgs e) {
            var selectedRoom = dgvRooms.CurrentRow?.DataBoundItem as RoomModel;

            RoomType roomTypeSelected = (RoomType)roomType.SelectedItem!;
            RoomStatus roomStatusSelected = (RoomStatus)roomStatus.SelectedItem!;

            try {
                _roomService.UpdateRoom(
                    selectedRoom.RoomId,
                    int.Parse(roomNumber.Text),
                    roomTypeSelected.ToString(),
                    decimal.Parse(pricePerNight.Text),
                    roomStatusSelected.ToString()
                );
                _roomService.LoadRoom();
                LoadDgvRooms();
                UpdateRoomSummary();
            } catch (Exception ex) {
                MessageBox.Show("Error occurred while updating room: " + ex.Message);
            }
        }
        public void ClearFormFields() {
            roomNumber.Clear();
            roomType.SelectedIndex = 2;
            pricePerNight.Value = 0;
            roomStatus.SelectedIndex = 0;
        }

        private void Clear_Click(object sender, EventArgs e) {
            ClearFormFields();
        }

        private void ReloadInputFiled() {
            var selectedRoom = dgvRooms.CurrentRow?.DataBoundItem as RoomModel;

            roomNumber.Text = selectedRoom?.RoomNumber.ToString();
            roomType.Text = selectedRoom?.RoomType.ToString();
            roomStatus.Text = selectedRoom?.Status.ToString();
            pricePerNight.Value = selectedRoom.Price;

        }

        private void dgvRooms_SelectionChanged(object sender, EventArgs e) {
            ReloadInputFiled();
        }

        private void filterType_SelectedIndexChanged(object sender, EventArgs e) {
            //Console.WriteLine(filterType.Text);
            ApplyRoomFilter();
        }

        private void ApplyRoomFilter() {
            string? roomType =
                filterType.SelectedIndex <= 0
                    ? null
                    : filterType.SelectedItem?.ToString();

            string? roomStatus =
                filterStatus.SelectedIndex <= 0
                    ? null
                    : filterStatus.SelectedItem?.ToString();


            dgvRooms.DataSource = null;
            dgvRooms.DataSource = _roomService
                .FilterRooms(roomType, roomStatus)
                .ToList();

            CustomDgvRoom();


        }

        private void filterStatus_SelectedIndexChanged(object sender, EventArgs e) {
            ApplyRoomFilter();
        }

        private void btRoomRest_Click(object sender, EventArgs e) {
            filterStatus.SelectedIndex = 0;
            filterType.SelectedIndex = 0;
        }

        private void CustomDgvRoom() {
            dgvRooms.Columns["RoomId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvRooms.Columns["RoomNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvRooms.Columns["RoomType"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Stretches to fill space
            dgvRooms.Columns["Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvRooms.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //dgvRooms.Columns["Status"].
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {

            if (string.IsNullOrWhiteSpace(txtSearch.Text)) {
                LoadDgvRooms();
                return;
            }

            dgvRooms.DataSource = null;

            dgvRooms.DataSource = _roomService.SearchRooms(txtSearch.Text).ToList();
            CustomDgvRoom();
        }

        private void txtSearch_Enter(object sender, EventArgs e) {
            if (txtSearch.Text == "Search by Room ID or Number...") {
                txtSearch.Clear();
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(txtSearch.Text)) {
                txtSearch.Text = "Search by Room ID or Number...";
                LoadDgvRooms();
            }
        }
    }
}
