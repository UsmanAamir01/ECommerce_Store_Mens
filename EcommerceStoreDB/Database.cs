using Oracle.ManagedDataAccess.Client;

namespace EcommerceStoreDB
{
    public class Database
    {
        public OracleConnection GetConnection()
        {
            string connectionString = "User Id=Ecomdb; Password=37093688; Data Source=//localhost:1521/XE";
            return new OracleConnection(connectionString);
        }
    }
}