using Hotel_Management.Models;
using Hotel_Management.Repositories;
using Hotel_Management.Services;
//using Microsoft.UI.Xaml.Controls;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Hotel_Management.RoomManagement
{
    public partial class RoomControl : UserControl
    {

        private readonly RoomService _roomService;
        private readonly RoomRepository _roomRepository;
        private readonly RoomModel roomModel = new RoomModel();
        public RoomControl(RoomService roomService, RoomRepository roomRepository)
        {
            InitializeComponent();
            _roomService = roomService;
            _roomRepository = roomRepository;
            roomType.SelectedIndexChanged += roomType_SelectedIndexChanged;
        }

        private void RoomControl_Load(object sender, EventArgs e)
        {
            _roomService.LoadRoom();

            pricePerNight.Minimum = 0;
            pricePerNight.Maximum = 1000000;
            pricePerNight.DecimalPlaces = 2;

            LoadComboBoxes();

            UpdateRoomSummary();

            GetNextRoomId();


            LoadDgvRooms();

        }

        private void btRoomAdd_Click(object sender, EventArgs e)
        {

            try
            {


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

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Please enter valid numeric values.");
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show(
                    "Database operation failed. Check the database and room data.");
            }

            // Optional: Clear fields after successful insert
            // ClearFormFields();

            //Console.WriteLine("==> Room ID: " + roomModel.RoomId);
            //Console.WriteLine("==> " + roomModel.RoomNumber);
            //Console.WriteLine("==> " + roomModel.RoomType);
            //Console.WriteLine("==> " + roomModel.Price);
            //Console.WriteLine("==> " + roomModel.Status);
        }


        private void GetPriceByRoomType()
        {
            if (roomType.SelectedItem is not RoomType selectedRoomType)
                return;

            decimal price = _roomService.GetPriceByRoomType(selectedRoomType);
            pricePerNight.Value = price;
        }

        private void GetNextRoomId()
        {
            int nextRoomId = _roomService.GetNextRoomId();
            roomId.Text = nextRoomId.ToString();
        }

        private void UpdateRoomSummary()
        {
            var summary = _roomService.GetRoomSummary();
            lbTotalRooms.Text = summary.totalRooms.ToString();
            lbAvailableRooms.Text = summary.availableRooms.ToString();
            lbOccupiedRooms.Text = summary.occupiedRooms.ToString();
            lbReservedRooms.Text = summary.reservedRooms.ToString();
        }

        private void LoadDgvRooms()
        {
            dgvRooms.DataSource = _roomService.GetRooms().ToList();




            // 2. Set custom column widths (in pixels)
            dgvRooms.Columns["RoomId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvRooms.Columns["RoomNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvRooms.Columns["RoomType"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Stretches to fill space
            dgvRooms.Columns["Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvRooms.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void LoadComboBoxes()
        {
            roomType.DataSource = Enum.GetValues(typeof(RoomType));
            roomStatus.DataSource = Enum.GetValues(typeof(RoomStatus));
            filterStatus.DataSource = Enum.GetValues(typeof(RoomStatus));
            filterType.DataSource = Enum.GetValues(typeof(RoomType));

        }

        private void roomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roomType.SelectedItem is RoomType selectedType)
            {
                GetPriceByRoomType();
            }
        }

    }
}
