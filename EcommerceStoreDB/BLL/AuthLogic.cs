using EcommerceStoreDB.DAL;
using EcommerceStoreDB.Models;

namespace EcommerceStoreDB.BLL
{
    public class AuthLogic
    {
        private readonly AuthDataAccess dataAccess;

        public AuthLogic()
        {
            dataAccess = new AuthDataAccess();
        }

        public bool Signup(User user)
        {
            // Business rules can be applied here, like checking if the username or email is unique.
            return dataAccess.InsertUser(user);
        }
        public User Login(string username, string password, string role)
        {
            User user = dataAccess.ValidateLogin(username, password, role);
            return user;
        }
    }
}
