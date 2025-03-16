// BLL/DeliveryPersonBLL.cs
using EcommerceStoreDB.DAL;
using System;
using System.Collections.Generic;

namespace EcommerceStoreDB.BLL
{
    public class DeliveryPersonBLL
    {
        private DeliveryPersonDAO deliveryPersonDAO = new DeliveryPersonDAO();

        public Dictionary<string, string> GetDeliveryPersonDetails(string username)
        {
            return deliveryPersonDAO.GetDeliveryPersonDetails(username);
        }

        public bool SaveDeliveryPersonDetails(string username, string firstName, string lastName, string email, string phoneNumber, string address)
        {
            Dictionary<string, object> updateParameters = new Dictionary<string, object>();

            if (!string.IsNullOrWhiteSpace(firstName)) updateParameters.Add("FIRSTNAME", firstName.Trim());
            if (!string.IsNullOrWhiteSpace(lastName)) updateParameters.Add("LASTNAME", lastName.Trim());
            if (!string.IsNullOrWhiteSpace(email)) updateParameters.Add("EMAIL", email.Trim());
            if (!string.IsNullOrWhiteSpace(phoneNumber)) updateParameters.Add("PHONENUMBER", phoneNumber.Trim());
            if (!string.IsNullOrWhiteSpace(address)) updateParameters.Add("ADDRESS", address.Trim());

            return deliveryPersonDAO.UpdateDeliveryPersonDetails(username, updateParameters);
        }
    }
}
