using EcommerceStoreDB.DAL;
using System;
using System.Data;

namespace EcommerceStoreDB.BLL
{
    public class CashierService
    {
        private CashierDAL cashierDAL = new CashierDAL();
        public DataRow GetCashierDetails(string username)
        {
            return cashierDAL.GetCashierDetails(username); 
        }
        public bool UpdateCashierDetails(string username, string firstName, string lastName, string email, string phoneNumber, string address)
        {
            return cashierDAL.UpdateCashierDetails(username, firstName, lastName, email, phoneNumber, address);
        }
    }
}
