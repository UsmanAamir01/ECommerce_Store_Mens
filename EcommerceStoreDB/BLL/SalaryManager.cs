using System.Data;
using Oracle.ManagedDataAccess.Client;
using EcommerceStoreDB.DAL;

namespace EcommerceStoreDB.BLL
{
    public class SalaryManager
    {
        private readonly SalaryDAL salaryDAL;

        public SalaryManager()
        {
            salaryDAL = new SalaryDAL();
        }

        public DataTable GetSalariesByRole(string role)
        {
            string query = @"
                SELECT 
                    u.USERID AS UserID, 
                    u.EMAIL, 
                    (u.FIRSTNAME || ' ' || u.LASTNAME) AS Name, 
                    u.ROLE, 
                    NVL(u.SALARY, 0) AS Salary
                FROM USERS u
                WHERE u.ROLE = :role";

            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("role", OracleDbType.Varchar2) { Value = role }
            };

            return salaryDAL.ExecuteQuery(query, parameters);
        }
    }
}
