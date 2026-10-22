using Hotel_Management.Controls;
using Hotel_Management.State;
using Hotel_Management.Services;
using Hotel_Management.Repositories;
using Hotel_Management.ReservationManagement;
using Hotel_Management.RoomManagement;

namespace Hotel_Management
{
    public partial class Main : Form
    {

        private readonly RoomService _roomService;
        private readonly RoomRepository _roomRepository;
        private readonly StateModel _stateModel;
        public Main()
        {
            InitializeComponent();

            lbDate.Text = DateTime.Now.ToString("MMM, dd yyyy");


            _roomRepository = new RoomRepository();
            _stateModel = new StateModel();
            _roomService = new RoomService(_roomRepository, _stateModel);

            LoadControl(new RoomControl(_roomService, _roomRepository));
            lblPageTitle.Text = "Room Management";

            //DatabaseInitializer.TestConnection();
        }

        private void LoadControl(UserControl control)
        {
            pnlContent.Controls.Clear();

            control.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(control);
        }



        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void lblPageTitle_Click(object sender, EventArgs e)
        {

        }

        private void btRoom_Click(object sender, EventArgs e)
        {
            LoadControl(new RoomControl(_roomService, _roomRepository));
            lblPageTitle.Text = "Room Management";

        }

        private void btCustomer_Click(object sender, EventArgs e)
        {
            LoadControl(new CustomerControl());
            lblPageTitle.Text = "Customer Management";
        }

        private void btReservation_Click(object sender, EventArgs e)
        {
            LoadControl(new ReservationControl());
            lblPageTitle.Text = "Reservation Management";
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Load_1(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbTime.Text = $"System : {DateTime.Now.ToString("hh:mm:ss tt")}";
        }
    }
}
