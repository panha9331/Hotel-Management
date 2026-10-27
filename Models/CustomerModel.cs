using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Management.Models
{
    public class CustomerSummary {
        public int TotalCustomers { get; set; }
        public int TotalCustomerMale { get; set; }
        public int TotalCustomerFemale { get; set; }
        public int TotalCutomerThisMonth { get; set; }
    }
    public class CustomerModel
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public string CustomerDisplay =>
            $"{CustomerName}-({CustomerID})";

    }
}