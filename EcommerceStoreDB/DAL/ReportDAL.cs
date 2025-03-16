using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace EcommerceStoreDB.DAL
{
    public class ReportDAL
    {
        private readonly Database database;

        public ReportDAL()
        {
            database = new Database();
        }

        public DataTable GetReports()
        {
            using (var connection = database.GetConnection())
            {
                connection.Open();
                string query = "SELECT REPORTID, REPORTNAME, GENERATEDATE, TOTALREVENUE, REPORTDESCRIPTION, STATUS FROM REPORTS";
                using (var command = new OracleCommand(query, connection))
                {
                    using (var adapter = new OracleDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public int UpdateReportStatus(int reportId, string status)
        {
            using (var connection = database.GetConnection())
            {
                connection.Open();
                string query = "UPDATE REPORTS SET STATUS = :status WHERE REPORTID = :reportId";
                using (var command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(":status", OracleDbType.Varchar2).Value = status;
                    command.Parameters.Add(":reportId", OracleDbType.Int32).Value = reportId;
                    return command.ExecuteNonQuery();
                }
            }
        }
    }
}
