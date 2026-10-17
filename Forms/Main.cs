using Hotel_Management.Controls;
using Hotel_Management.ReservationManagement;
using Hotel_Management.RoomManagement;

namespace Hotel_Management
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            LoadControl(new RoomControl());
            lblPageTitle.Text = "Room Management";
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
            LoadControl(new RoomControl());
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
    }
}
