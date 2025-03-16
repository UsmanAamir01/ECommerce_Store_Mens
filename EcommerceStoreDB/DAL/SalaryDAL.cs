using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace EcommerceStoreDB.DAL
{
    public class SalaryDAL
    {
        private readonly Database database;

        public SalaryDAL()
        {
            database = new Database();
        }

        public DataTable ExecuteQuery(string query, OracleParameter[] parameters)
        {
            DataTable dt = new DataTable();

            using (OracleConnection conn = database.GetConnection())
            {
                conn.Open();

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }
    }
}
