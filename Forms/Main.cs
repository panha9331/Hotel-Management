using Hotel_Management.Controls;
using Hotel_Management.State;
using Hotel_Management.Services;
using Hotel_Management.Repositories;
using Hotel_Management.ReservationManagement;
using Hotel_Management.RoomManagement;

namespace Hotel_Management {
    public partial class Main : Form {

        private readonly RoomService _roomService;
        private readonly CustomerService _customerService;
        private readonly ReservationService _reservationService;
        private readonly RoomRepository _roomRepository;
        private readonly CustomerRepository _customerRepository;
        private readonly ReservationRepository _reservationRepository;

        private readonly StateModel _stateModel;
        public Main() {
            InitializeComponent();

            lbDate.Text = DateTime.Now.ToString("MMM, dd yyyy");

            _stateModel = new StateModel();

            _roomRepository = new RoomRepository();
            _roomService = new RoomService(_roomRepository, _stateModel);

            _customerRepository = new CustomerRepository();
            _customerService = new CustomerService(_customerRepository, _stateModel);


            LoadControl(new RoomControl(_roomService, _roomRepository));
            lblPageTitle.Text = "Room Management";

            //DatabaseInitializer.TestConnection();
        }

        private void LoadControl(UserControl control) {
            pnlContent.Controls.Clear();

            control.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(control);
        }



        private void Main_Load(object sender, EventArgs e) {
        }

        private void materialButton1_Click(object sender, EventArgs e) {

        }

        private void lblPageTitle_Click(object sender, EventArgs e) {

        }

        private void btRoom_Click(object sender, EventArgs e) {
            LoadControl(new RoomControl(_roomService, _roomRepository));
            lblPageTitle.Text = "Room Management";

        }

        private void btCustomer_Click(object sender, EventArgs e) {
            LoadControl(new CustomerControl(_customerService, _customerRepository));
            lblPageTitle.Text = "Customer Management";
        }

        private void btReservation_Click(object sender, EventArgs e) {
            LoadControl(new ReservationControl());
            lblPageTitle.Text = "Reservation Management";
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e) {

        }

        private void Main_Load_1(object sender, EventArgs e) {

        }

        private void timer_Tick(object sender, EventArgs e) {
            lbTime.Text = $"System : {DateTime.Now.ToString("hh:mm:ss tt")}";
        }

        private void globalSearch_TextChanged(object sender, EventArgs e) {

        }

        private void globalSearch_Leave(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(globalSearch.Text)) {
                globalSearch.Text = "Global Search (Ctrl + /)...";
            }
        }

        private void globalSearch_Enter(object sender, EventArgs e) {
            if (globalSearch.Text == "Global Search (Ctrl + /)...") {
                globalSearch.Clear();
            }
        }

        private void btLogout_Click(object sender, EventArgs e) {
            MessageBox.Show("This feature is not avalaible now!");
        }

        private void lbAccountName_MouseHover(object sender, EventArgs e) {
            if (lblBigAccountName == null) {
                lblBigAccountName = new Label();

                lblBigAccountName.AutoSize = true;
                lblBigAccountName.Font = new Font("Arial", 16, FontStyle.Bold);
                lblBigAccountName.BackColor = Color.White;
                lblBigAccountName.ForeColor = Color.Black;
                lblBigAccountName.BorderStyle = BorderStyle.FixedSingle;

                this.Controls.Add(lblBigAccountName);
                lblBigAccountName.BringToFront();
            }

            lblBigAccountName.Text = lbAccountName.Text;

            // Position the popup above the account name
            lblBigAccountName.Location = new Point(
                lbAccountName.Left,
                lbAccountName.Top - lblBigAccountName.PreferredHeight - 5
            );

            lblBigAccountName.Visible = true;
            lblBigAccountName.BringToFront();
        }

        private void lbAccountName_MouseLeave(object sender, EventArgs e) {
            if (lblBigAccountName != null) {
                lblBigAccountName.Visible = false;
            }
        }
    }
}
