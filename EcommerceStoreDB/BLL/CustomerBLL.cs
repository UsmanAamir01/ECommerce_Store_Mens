// BLL/CustomerBLL.cs
using System;
using System.Net.Mail;
using EcommerceStoreDB.DAL;
using EcommerceStoreDB.Models;

namespace EcommerceStoreDB.BLL
{
    public class CustomerBLL
    {
        private CustomerDAO customerDAO = new CustomerDAO();

        // Method to get customer details
        public Customer GetCustomerDetails(string username)
        {
            return customerDAO.GetCustomerDetails(username);
        }

        // Method to update customer profile after validation
        public bool UpdateCustomerProfile(string username, Customer customer)
        {
            if (string.IsNullOrWhiteSpace(customer.FirstName) && string.IsNullOrWhiteSpace(customer.LastName) &&
                string.IsNullOrWhiteSpace(customer.Email) && string.IsNullOrWhiteSpace(customer.PhoneNumber) && string.IsNullOrWhiteSpace(customer.Address))
            {
                throw new Exception("Please fill in at least one field to update.");
            }

            if (!string.IsNullOrWhiteSpace(customer.Email) && !IsValidEmail(customer.Email))
            {
                throw new Exception("Invalid email format.");
            }

            if (!string.IsNullOrWhiteSpace(customer.PhoneNumber) && !long.TryParse(customer.PhoneNumber, out _))
            {
                throw new Exception("Phone number must be numeric.");
            }

            // If no issues with validation, update profile in the database
            return customerDAO.UpdateCustomerProfile(customer, username);
        }

        // Email validation
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
