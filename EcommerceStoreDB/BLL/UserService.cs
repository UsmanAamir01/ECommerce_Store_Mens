using System;
using System.Collections.Generic;
using EcommerceStoreDB.DAL;

namespace EcommerceStoreDB.BLL
{
    public class UserService
    {
        private UserDAL userDAL = new UserDAL();

        public Dictionary<string, string> GetAdminDetails(string username)
        {
            return userDAL.GetAdminDetails(username);
        }

        public bool UpdateAdminDetails(string username, string firstName, string lastName, string email, string phoneNumber, string address)
        {
            Dictionary<string, object> updates = new Dictionary<string, object>();

            if (!string.IsNullOrWhiteSpace(firstName))
                updates["FIRSTNAME"] = firstName.Trim();

            if (!string.IsNullOrWhiteSpace(lastName))
                updates["LASTNAME"] = lastName.Trim();

            if (!string.IsNullOrWhiteSpace(email) && IsValidEmail(email))
                updates["EMAIL"] = email.Trim();
            else if (!string.IsNullOrWhiteSpace(email))
                throw new Exception("Invalid email format.");

            if (!string.IsNullOrWhiteSpace(phoneNumber) && long.TryParse(phoneNumber, out _))
                updates["PHONENUMBER"] = phoneNumber.Trim();
            else if (!string.IsNullOrWhiteSpace(phoneNumber))
                throw new Exception("Phone number must be numeric.");

            if (!string.IsNullOrWhiteSpace(address))
                updates["ADDRESS"] = address.Trim();

            if (updates.Count == 0)
                throw new Exception("No fields to update.");

            return userDAL.UpdateAdminDetails(username, updates) > 0;
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
