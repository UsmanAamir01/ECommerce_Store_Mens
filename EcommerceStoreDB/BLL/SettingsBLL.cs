using System;
using System.Security.Cryptography;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using EcommerceStoreDB.DAL;

namespace EcommerceStoreDB.BLL
{
    public class SettingsBLL
    {
        private SettingsDAL settingsDAL = new SettingsDAL();

        // Method to hash the password using SHA-256
        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hashBytes);
            }
        }

        public bool VerifyPassword(string username, string currentPassword, OracleConnection conn)
        {
            string hashedPassword = HashPassword(currentPassword);
            return settingsDAL.VerifyPassword(username, hashedPassword, conn);
        }

        public bool UpdatePassword(string username, string newPassword, OracleConnection conn)
        {
            string hashedPassword = HashPassword(newPassword);
            return settingsDAL.UpdatePassword(username, hashedPassword, conn);
        }
    }
}
