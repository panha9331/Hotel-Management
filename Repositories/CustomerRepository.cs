using System;
using System.Collections.Generic;
using Hotel_Management.Data;
using System.Data.SqlClient;
//using Microsoft.Data.SqlClient; 
using System.Text;

namespace Hotel_Management.Repositories
{
    public class CustomerRepository
    {
        public void AddCustomer(
            int customerId,
            string customerName,
            string gender,
            string phone,
            string email
        )
        {
            string query = @"
                INSERT INTO dbo.CUSTOMERS (customer_id, name, gender, phone, email)
                VALUES (@id, @name, @gender, @phone, @email);";

            using var connection = DatabaseConnection.GetConnection();
            using(SqlCommand cmd = new SqlCommand(query, connection))
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
