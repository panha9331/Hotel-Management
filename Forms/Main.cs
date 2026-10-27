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

        private Label lbAccountHover;

        private PictureBox picAccountHover;

        public Main() {

            InitializeComponent();



            lbDate.Text = DateTime.Now.ToString("MMM, dd yyyy");

            _stateModel = new StateModel();

            _roomRepository = new RoomRepository();
            _roomService = new RoomService(_roomRepository, _stateModel);

            _customerRepository = new CustomerRepository();
            _customerService = new CustomerService(_customerRepository, _stateModel);

            _reservationRepository = new ReservationRepository();
            _reservationService = new ReservationService(_reservationRepository, _stateModel);


            LoadControl(new RoomControl(_roomService, _roomRepository));
            lblPageTitle.Text = "Room Management";

            //ConfigureMenuButton(btDashboard);
            //ConfigureMenuButton(btRoom);
            //ConfigureMenuButton(btCustomer);
            //ConfigureMenuButton(btReservation);
            ////DatabaseInitializer.TestConnection();
        }

        private void ConfigureMenuButton(MaterialSkin.Controls.MaterialButton btn) {
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.ImageAlign = ContentAlignment.MiddleLeft;
            btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn.Padding = new Padding(10, 0, 0, 0);
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
            LoadControl(new ReservationControl(_reservationService, _reservationRepository));
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
            if (lbAccountHover == null) {
                lbAccountHover = new Label();

                lbAccountHover.AutoSize = true;
                lbAccountHover.Font = new Font("Arial", 26, FontStyle.Bold);
                lbAccountHover.BackColor = Color.Navy;
                lbAccountHover.ForeColor = Color.White;
                lbAccountHover.BorderStyle = BorderStyle.None;

                this.Controls.Add(lbAccountHover);
                lbAccountHover.BringToFront();
            }

            lbAccountHover.Text = lbAccountName.Text;

            // Position the popup above the account name
            lbAccountHover.Location = new Point(
                lbAccountName.Left - 55,
                lbAccountName.Top + 500
            );

            lbAccountHover.Visible = true;
            lbAccountHover.BringToFront();
        }

        private void lbAccountName_MouseLeave(object sender, EventArgs e) {
            if (lbAccountHover != null) {
                lbAccountHover.Visible = false;
            }
        }

        private void picAccount_MouseHover(object sender, EventArgs e) {
            if (picAccountHover == null) {
                picAccountHover = new PictureBox();

                picAccountHover.Size = new Size(200, 200);
                picAccountHover.SizeMode = PictureBoxSizeMode.Zoom;
                picAccountHover.BackColor = Color.Navy;
                picAccountHover.BorderStyle = BorderStyle.None;

                this.Controls.Add(picAccountHover);
                picAccountHover.BringToFront();
            }

            // Display the same account image in a larger size
            picAccountHover.Image = picAccount.Image;

            // Position it above the account picture
            picAccountHover.Location = new Point(
                lbAccountName.Left - 40,
                picAccount.Top + 520
            );

            picAccountHover.Visible = true;
            picAccountHover.BringToFront();
        }

        private void picAccount_MouseLeave(object sender, EventArgs e) {
            if (picAccountHover != null) {
                picAccountHover.Visible = false;
            }
        }
    }
}
