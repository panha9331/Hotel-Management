using Hotel_Management.Services;
using Hotel_Management.State;
using Hotel_Management.Models;
using Hotel_Management.Repositories;


namespace Hotel_Management.Controls
{
    public partial class CustomerControl : UserControl {

        private readonly CustomerService _customerService;
        private readonly CustomerRepository _customerRepositoty;
        private readonly StateModel _stateModel;
        public CustomerControl(CustomerService customerService, CustomerRepository customerRepository) {
            InitializeComponent();
            _customerService = customerService;
            _customerRepositoty = customerRepository;
        }

        private void CustomerControl_Load(object sender, EventArgs e) {
            _customerService.LoadCustomer();
            _customerService.GetNextCustomerId();
            LoadDgvCustomer();
            UpdateCustomerSummary();

        }

        public void LoadDgvCustomer() {
            dgvCustomers.DataSource = _customerService.GetCustomers().ToList();
            CustomDgvCustomer();

        }
        private void btAddCustomer_Click(object sender, EventArgs e) {
            try {
                _customerService.AddCustomer(
                    txtCustomerName.Text,
                    cbGender.Text.Trim(),
                    txtPhone.Text.Trim(),
                    txtEmail.Text.Trim()
                );

                _customerService.LoadCustomer();
                LoadDgvCustomer();
                MessageBox.Show("Customer added successfully.");


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
                    "Database operation failed. Check the database and customer data.");
            }

            UpdateCustomerSummary();
        }
        private void btUpdateCustomer_Click(object sender, EventArgs e) {

            var selectedCustomer = dgvCustomers.CurrentRow?.DataBoundItem as CustomerModel;

            try {
                _customerService.UpdateCustomer(
                    selectedCustomer.CustomerID,
                    txtCustomerName.Text,
                    cbGender.Text.Trim(),
                    txtPhone.Text.Trim(),
                    txtEmail.Text.Trim()
                );

                _customerService.LoadCustomer();
                LoadDgvCustomer();
                UpdateCustomerSummary();

            }catch(Exception ex) {
                Console.WriteLine("[UPDATING ERROR]: " + ex);
            }
        }

        private void btDeleteCustomer_Click(object sender, EventArgs e) {
            var selectedCustomer = dgvCustomers.CurrentRow?.DataBoundItem as CustomerModel;
            try {
                _customerService.DeleteCustomer(selectedCustomer.CustomerID);

                _customerService.LoadCustomer();
                LoadDgvCustomer();
                UpdateCustomerSummary();
            }catch(ArgumentException ex) {
                Console.WriteLine("[UPDATING ERROR]: " + ex);
            }
        }

        private void btClear_Click(object sender, EventArgs e) {
            ClearInputFiled();
        }

        private void btFilterRest_Click(object sender, EventArgs e) {

        }

        private void UpdateCustomerSummary() {
            var summary = _customerService.GetCustomerSummary();

            lbTotalCustomer.Text = summary.TotalCustomers.ToString();
            lbTotalMale.Text = summary.TotalCustomerMale.ToString();
            lbTotalFemale.Text = summary.TotalCustomerFemale.ToString();

        }

        private void CustomDgvCustomer() {
            dgvCustomers.Columns ["CustomerId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCustomers.Columns ["CustomerName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvCustomers.Columns ["Gender"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Stretches to fill space
            dgvCustomers.Columns ["Phone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCustomers.Columns ["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //dgvRooms.Columns["Status"].
        }

        private void ClearInputFiled() {
            txtCustomerName.Clear();
            cbGender.SelectedIndex = 1;
            txtPhone.Clear();
            txtEmail.Clear();
        }
    }
}
