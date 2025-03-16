using EcommerceStoreDB.DAL;
using System;
using System.Collections.Generic;

namespace EcommerceStoreDB.BLL
{
    public class ManagerProfileBO
    {
        private readonly ManagerDAL managerDAL = new ManagerDAL();

        public Dictionary<string, string> GetProfileDetails(string username)
        {
            return managerDAL.GetManagerDetails(username);
        }

        public void UpdateProfile(string username, string firstName, string lastName, string email, string phoneNumber, string address)
        {
            if (!string.IsNullOrWhiteSpace(email) && !IsValidEmail(email))
            {
                throw new Exception("Invalid email format.");
            }

            if (!string.IsNullOrWhiteSpace(phoneNumber) && !long.TryParse(phoneNumber, out _))
            {
                throw new Exception("Phone number must be numeric.");
            }

            Dictionary<string, object> updateFields = new Dictionary<string, object>();
            if (!string.IsNullOrWhiteSpace(firstName)) updateFields.Add("FIRSTNAME = :FIRSTNAME", firstName);
            if (!string.IsNullOrWhiteSpace(lastName)) updateFields.Add("LASTNAME = :LASTNAME", lastName);
            if (!string.IsNullOrWhiteSpace(email)) updateFields.Add("EMAIL = :EMAIL", email);
            if (!string.IsNullOrWhiteSpace(phoneNumber)) updateFields.Add("PHONENUMBER = :PHONENUMBER", phoneNumber);
            if (!string.IsNullOrWhiteSpace(address)) updateFields.Add("ADDRESS = :ADDRESS", address);

            if (updateFields.Count == 0)
            {
                throw new Exception("No changes detected in the fields.");
            }

            int rowsUpdated = managerDAL.UpdateManagerDetails(username, updateFields);
            if (rowsUpdated == 0)
            {
                throw new Exception("No changes were made.");
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}