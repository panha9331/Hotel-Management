using Hotel_Management.Models;
using Hotel_Management.Services;
using Hotel_Management.Repositories;    
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Hotel_Management.RoomManagement
{
    public partial class RoomControl : UserControl
    {

        private readonly RoomService _roomService;
        private readonly RoomRepository _roomRepository;
        public RoomControl(RoomService roomService, RoomRepository roomRepository)
        {
            InitializeComponent();
            _roomService = roomService;
            _roomRepository = roomRepository;
        }

        private void RoomControl_Load(object sender, EventArgs e)
        {
            _roomService.LoadRoom();

            dgvRooms.DataSource = _roomService.GetRooms().ToList();


            // 2. Set custom column widths (in pixels)
            dgvRooms.Columns["RoomId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvRooms.Columns["RoomNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvRooms.Columns["RoomType"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Stretches to fill space
            dgvRooms.Columns["Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvRooms.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btRoomAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _roomService.AddRoom(
                    int.Parse(roomId.Text),
                    int.Parse(roomNumber.Text),
                    roomType.Text,
                    decimal.Parse(pricePerNight.Text),
                    roomStatus.Text
                );

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

        //out lets a method return two or more values.
        private bool ValidateRoomInput(out string errorMessage) // Returns true if all inputs are valid, false otherwise
                                                                // the out keyword requires value to be assigned before the method returns.
        {//the out_ keyword do not need to return a value, Tell C# you don't care about the value.   
            var errors = new List<string>();

            // 1. Validate Room ID
            if (string.IsNullOrWhiteSpace(roomId.Text))
            {
                errors.Add("Room ID cannot be empty.");
            }
            else if (!int.TryParse(roomId.Text, out _))
            {
                errors.Add("Room ID must be a valid integer (Number).");
            }

            // 2. Validate Room Number
            if (string.IsNullOrWhiteSpace(roomNumber.Text))
            {
                errors.Add("Room Number cannot be empty.");
            }
            else if (!int.TryParse(roomNumber.Text, out _))
            {
                errors.Add("Room Number must be a valid integer (Number).");
            }

            // 3. Validate Room Type selection
            if (roomType.SelectedIndex == -1 || string.IsNullOrWhiteSpace(roomType.Text))
            {
                errors.Add("Please select a valid Room Type.");
            }

            // 4. Validate Price Per Night (Safe Parsing)
            if (string.IsNullOrWhiteSpace(pricePerNight.Text))
            {
                errors.Add("Price Per Night cannot be empty.");
            }
            else if (!decimal.TryParse(pricePerNight.Text, out decimal price) || price <= 0)
            {
                errors.Add("Price Per Night must be a valid positive number.");
            }

            // 5. Validate Status selection
            if (roomStatus.SelectedIndex == -1 || string.IsNullOrWhiteSpace(roomStatus.Text))
            {
                errors.Add("Please select a Status.");
            }

            // If any errors exist, join them into a list for the alert box
            if (errors.Count > 0)
            {
                errorMessage = "Please fix the following issues before submitting:\n\n• " + string.Join("\n• ", errors);
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }
    }
}
