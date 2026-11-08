using Hotel_Management.Helpers;
using Hotel_Management.Models;
using Hotel_Management.Repositories;
using Hotel_Management.Services;
using Hotel_Management.State;
using static System.Windows.Forms.AxHost;


namespace Hotel_Management.Controls {
    public partial class CustomerControl : UserControl {

        private readonly CustomerService _customerService;
        private readonly CustomerRepository _customerRepositoty;
        private readonly StateModel? _stateModel;
        public CustomerControl(CustomerService customerService, CustomerRepository customerRepository) {
            InitializeComponent();
            _customerService = customerService;
            _customerRepositoty = customerRepository;
        }

        private void CustomerControl_Load(object sender, EventArgs e) {
            _customerService.LoadCustomer();

            GetNextCustomerId();

            LoadDgvCustomer();

            UpdateCustomerSummary();

        }

        private void GetNextCustomerId() {
            int nextCustomerId = _customerService.GetNextCustomerId();
            txtCustomerId.Text = nextCustomerId.ToString();
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
                AppMessageBox.Show(
                    this,
                    "Customer Added",
                    "Customer added successfully.",
                    MessageType.Success);

                GetNextCustomerId();
            } catch (ArgumentException ex) {
                AppMessageBox.Show(
                    this,
                    "Validation Error",
                    ex.Message,
                    MessageType.Warning);
            } catch (FormatException) {
                AppMessageBox.Show(
                    this,
                    "Validation Error",
                    "Please enter valid numeric values.",
                    MessageType.Warning);
            } catch (System.Data.SqlClient.SqlException) {
                AppMessageBox.Show(
                    this,
                    "Database Error",
                    "Database operation failed. Check the database and customer data.",
                    MessageType.Error);
            } catch (Exception ex) {
                AppMessageBox.Show(
                    this,
                    "Customer Error",
                    ex.Message,
                    MessageType.Error);
            }

            UpdateCustomerSummary();
        }
        private void btUpdateCustomer_Click(object sender, EventArgs e) {

            var selectedCustomer = dgvCustomers.CurrentRow?.DataBoundItem as CustomerModel;
            if (selectedCustomer == null) {
                AppMessageBox.Show(
                    this,
                    "Select a Customer",
                    "Please select a customer to update.",
                    MessageType.Warning);
                return;
            }

            try {
                _customerService.UpdateCustomer(
                    selectedCustomer.CustomerId,
                    txtCustomerName.Text,
                    cbGender.Text.Trim(),
                    txtPhone.Text.Trim(),
                    txtEmail.Text.Trim()
                );

                _customerService.LoadCustomer();
                LoadDgvCustomer();
                UpdateCustomerSummary();

                AppMessageBox.Show(
                    this,
                    "Customer Updated",
                    "Customer updated successfully.",
                    MessageType.Success);
            } catch (ArgumentException ex) {
                AppMessageBox.Show(
                    this,
                    "Validation Error",
                    ex.Message,
                    MessageType.Warning);
            } catch (Exception ex) {
                AppMessageBox.Show(
                    this,
                    "Customer Error",
                    "Error occurred while updating customer: " + ex.Message,
                    MessageType.Error);
            }
        }

        private void btDeleteCustomer_Click(object sender, EventArgs e) {
            var selectedCustomer = dgvCustomers.CurrentRow?.DataBoundItem as CustomerModel;
            if (selectedCustomer == null) {
                AppMessageBox.Show(
                    this,
                    "Select a Customer",
                    "Please select a customer to delete.",
                    MessageType.Warning);
                return;
            }

            try {
                _customerService.DeleteCustomer(selectedCustomer.CustomerId);

                _customerService.LoadCustomer();
                LoadDgvCustomer();
                UpdateCustomerSummary();
                AppMessageBox.Show(
                    this,
                    "Customer Deleted",
                    "Customer deleted successfully.",
                    MessageType.Success);
            } catch (ArgumentException ex) {
                AppMessageBox.Show(
                    this,
                    "Validation Error",
                    ex.Message,
                    MessageType.Warning);
            } catch (Exception ex) {
                AppMessageBox.Show(
                    this,
                    "Customer Error",
                    "Error occurred while deleting customer: " + ex.Message,
                    MessageType.Error);
            }
        }

        private void btClear_Click(object sender, EventArgs e) {
            ClearInputFiled();
        }

        private void btFilterRest_Click(object sender, EventArgs e) {
            LoadDgvCustomer();
            filterByGender.SelectedIndex = 0;
        }

        private void UpdateCustomerSummary() {
            var summary = _customerService.GetCustomerSummary();

            lbTotalCustomer.Text = summary.TotalCustomers.ToString();
            lbTotalMale.Text = summary.TotalCustomerMale.ToString();
            lbTotalFemale.Text = summary.TotalCustomerFemale.ToString();

        }

        private void CustomDgvCustomer() {
            dgvCustomers.Columns["CustomerId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCustomers.Columns["CustomerName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvCustomers.Columns["Gender"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Stretches to fill space
            dgvCustomers.Columns["Phone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCustomers.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //dgvRooms.Columns["Status"].
        }

        private void ClearInputFiled() {
            txtCustomerName.Clear();
            cbGender.SelectedIndex = 1;
            txtPhone.Clear();
            txtEmail.Clear();
        }

        private void filterByGender_SelectedIndexChanged(object sender, EventArgs e) {
            ApplyCustomerFilter();
        }

        private void ApplyCustomerFilter() {
            string? gender = filterByGender.SelectedIndex <= 0 ? null :
                filterByGender.SelectedItem?.ToString();

            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = _customerService.FilterCustomer(gender).ToList();

            CustomDgvCustomer();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(txtSearch.Text)) {
                LoadDgvCustomer();
                return;
            }

            dgvCustomers.DataSource = null;

            dgvCustomers.DataSource = _customerService.SearchCustomers(txtSearch.Text).ToList();
            CustomDgvCustomer();
        }

        private void txtSearch_Leave(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(txtSearch.Text)) {
                txtSearch.Text = "Search by ID, Full Name, Phone...";
                LoadDgvCustomer();
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e) {
            if (txtSearch.Text == "Search by ID, Full Name, Phone...") {
                txtSearch.Clear();
            }
        }

        private void txtCustomerName_MouseEnter(object sender, EventArgs e) {
            if (txtCustomerName.Text == "e.g. Moeurn Panha") {
                txtCustomerName.Clear();
            }
        }

        private void txtCustomerName_Leave(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text)) {
                txtCustomerName.Text = "e.g. Moeurn Panha";
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(txtPhone.Text)) {
                txtPhone.Text = "e.g. 09999XXXX";
            }
        }

        private void txtPhone_Enter(object sender, EventArgs e) {
            if (txtPhone.Text == "e.g. 09999XXXX") {
                txtPhone.Clear();
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(txtEmail.Text)) {
                txtEmail.Text = "e.g. example@gmail.com";
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e) {
            if (txtEmail.Text == "e.g. example@gmail.com") {
                txtEmail.Clear();
            }
        }

        private void txtCustomerName_Enter(object sender, EventArgs e) {
            if (txtCustomerName.Text == "e.g. Moeurn Panha") {
                txtCustomerName.Clear();
            }
        }

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e) {
            ReloadTextField();
        }
        private void ReloadTextField() {
            var selectedCustomer = dgvCustomers.CurrentRow?.DataBoundItem as CustomerModel;
            if (selectedCustomer != null) {
                txtCustomerId.Text = selectedCustomer.CustomerId.ToString();
                txtCustomerName.Text = selectedCustomer.CustomerName;
                cbGender.SelectedItem = selectedCustomer.Gender;
                txtPhone.Text = selectedCustomer.Phone;
                txtEmail.Text = selectedCustomer.Email;
            }
        }
    }
}
