using System;
using System.Collections.Generic;
using Hotel_Management.Data;
using System.Data.SqlClient;
//using Microsoft.Data.SqlClient; 
using System.Text;
using Hotel_Management.Models;

namespace Hotel_Management.Repositories
{
    public class CustomerRepository
    {

        public List<CustomerModel> GetAllCustomers() {
            string query = @"SELECT customer_id, name, gender, phone, email FROM dbo.CUSTOMERS
                            ORDER BY customer_id";

            var customers = new List<CustomerModel>();

            using var connection = DatabaseConnection.GetConnection();
            using var cmd = new SqlCommand(query, connection);

            try {
                connection.Open();
                using var reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    customers.Add(new CustomerModel {
                        CustomerID = Convert.ToInt32(reader["customer_id"]),
                        CustomerName = reader["name"].ToString(),
                        Gender = reader["gender"].ToString(),
                        Phone = reader["phone"].ToString(),
                        Email = reader["email"].ToString()

                    });
                }
            }catch(Exception ex) {
                Console.WriteLine("[GET ALL CUSTOMERS ERROR!]: " + ex);
            }

            return customers;

        }
        public void AddCustomer(
            //int customerId,
            string customerName,
            string gender,
            string phone,
            string email
        )
        {
            string query = @"
                INSERT INTO dbo.CUSTOMERS (name, gender, phone, email)
                VALUES (@name, @gender, @phone, @email);";

            using var connection = DatabaseConnection.GetConnection();
            using(SqlCommand cmd = new SqlCommand(query, connection))
            {
                //cmd.Parameters.AddWithValue("@id", customerId);
                cmd.Parameters.AddWithValue("@name", customerName);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[Error adding customer]: {ex.Message}");
                }
            }

        }

        public void UpdateCustomer(
            int customerId,
            string customerName,
            string gender,
            string phone,
            string email
        )
        {
            string query = @"
                UPDATE dbo.CUSTOMERS 
                SET name = @name, 
                    gender = @gender, 
                    phone = @phone, 
                    email = @email 
                WHERE customer_id = @id";
            using var connection = DatabaseConnection.GetConnection();
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@id", customerId);
                cmd.Parameters.AddWithValue("@name", customerName);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[Error updating customer]: {ex.Message}");
                }
            }
        }   

        public void DeleteCustomer(int customerId)
        {
            string query = @"
                DELETE FROM dbo.CUSTOMERS 
                WHERE customer_id = @id";
            using var connection = DatabaseConnection.GetConnection();
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@id", customerId);
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[Error deleting customer]: {ex.Message}");
                }
            }
        }
    }
}
