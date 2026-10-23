using Hotel_Management.Models;
using Hotel_Management.Repositories;
using Hotel_Management.State;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Hotel_Management.Services {

    public class CustomerService {
        private readonly CustomerRepository _customerRepository;
        private readonly StateModel _stateModel;

        public CustomerSummary GetCustomerSummary() {
            var customers = _stateModel.Customers;

            var summary = new CustomerSummary {
                TotalCustomers = customers.Count,
                TotalCustomerMale = customers.Count(c => c.Gender.Equals("Male")),
                TotalCustomerFemale = customers.Count(c => c.Gender.Equals("Female")),
                //implement new this month
            };

            return summary;
        }
        public int GetNextCustomerId() {
            var customers = _stateModel.Customers;
            var nextCustomerId = customers.Any() ? customers.Max(r => r.CustomerID) + 1 : 1;
            return nextCustomerId;
        }
        public CustomerService(
            CustomerRepository customerRepository,
            StateModel stateModel
        ) {
            _customerRepository = customerRepository;
            _stateModel = stateModel;
        }

        public IReadOnlyList<CustomerModel> GetCustomers() { //load to state for sharing UI
            return _stateModel.Customers.AsReadOnly();
        }
        public void LoadCustomer() {
            _stateModel.Customers = _customerRepository.GetAllCustomers();
        }
        public void AddCustomer(
            string customerName,
            string gender,
            string phone,
            string email
        ) {
            ValidatCustomer(
                customerName,
                gender,
                phone,
                email
            );

            _customerRepository.AddCustomer(
                customerName,
                gender,
                phone,
                email
            );
        }

        public void DeleteCustomer( int customerId ) {
            _customerRepository.DeleteCustomer(customerId);
        }

        public void UpdateCustomer(
            int customerId,
            string customerName,
            string gender,
            string phone,
            string email
        ) {
            ValidatCustomer(
                customerName,
                gender,
                phone,
            email);

            _customerRepository.UpdateCustomer(
                customerId,
                customerName,
                gender,
                phone,
                email
            );
        }


        private void ValidatCustomer(
            string CustomerName,
            string gender,
            string phone,
            string email
        ) {
            // 1. Validate Customer Name
            if (string.IsNullOrWhiteSpace(CustomerName)) {
                throw new ArgumentException("Customer name is required.");
            }

            if (CustomerName.Trim().Length < 2) {
                throw new ArgumentException(
                    "Customer name must contain at least 2 characters."
                );
            }

            // 2. Validate Gender
            if (string.IsNullOrWhiteSpace(gender)) {
                throw new ArgumentException("Please select a gender.");
            }

            if (gender != "Male" && gender != "Female" && gender != "Other") {
                throw new ArgumentException("Invalid gender.");
            }

            // 3. Validate Phone Number
            if (string.IsNullOrWhiteSpace(phone)) {
                throw new ArgumentException("Phone number is required.");
            }

            // Allows optional + and digits, with a total of 8–15 digits.
            string phonePattern = @"^\+?[0-9]{8,15}$";

            if (!Regex.IsMatch(phone.Trim(), phonePattern)) {
                throw new ArgumentException(
                    "Phone number must contain 8–15 digits."
                );
            }

            // 4. Validate Email
            if (string.IsNullOrWhiteSpace(email)) {
                throw new ArgumentException("Email address is required.");
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(email.Trim(), emailPattern)) {
                throw new ArgumentException(
                    "Please enter a valid email address."
                );
            }
        }
    }
}
