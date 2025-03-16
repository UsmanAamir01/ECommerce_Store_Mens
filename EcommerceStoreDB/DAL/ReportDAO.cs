using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace EcommerceStoreDB.DataAccess
{
    public class ReportDAO
    {
        public bool AddReport(string reportID, string reportName, string generateDate, string totalRevenue, string reportDescription)
        {
            try
            {
                using (var connection = new Database().GetConnection())
                {
                    connection.Open();
                    string query = "INSERT INTO reports (reportid, reportname, generatedate, totalrevenue, reportdescription) " +
                                   "VALUES (:reportID, :reportName, TO_DATE(:generateDate, 'YYYY-MM-DD'), :totalRevenue, :reportDescription)";

                    using (var command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(":reportID", reportID);
                        command.Parameters.Add(":reportName", reportName);
                        command.Parameters.Add(":generateDate", generateDate);
                        command.Parameters.Add(":totalRevenue", totalRevenue);
                        command.Parameters.Add(":reportDescription", reportDescription);

                        return command.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteReport(string reportID)
        {
            try
            {
                using (var connection = new Database().GetConnection())
                {
                    connection.Open();
                    string query = "DELETE FROM reports WHERE reportid = :reportID";

                    using (var command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(":reportID", reportID);

                        return command.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable GetReportByName(string reportName)
        {
            try
            {
                using (var connection = new Database().GetConnection())
                {
                    connection.Open();
                    string query = "SELECT * FROM reports WHERE reportname = :reportName";

                    using (var command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(":reportName", reportName);

                        using (var adapter = new OracleDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            return dataTable;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable GetAllReports()
        {
            try
            {
                using (var connection = new Database().GetConnection())
                {
                    connection.Open();
                    string query = "SELECT * FROM reports";

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
            catch (Exception)
            {
                throw;
            }
        }
    }
}