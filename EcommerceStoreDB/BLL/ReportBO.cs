using EcommerceStoreDB.DAL;
using EcommerceStoreDB.DataAccess;
using System.Data;

namespace EcommerceStoreDB.BLL
{
    public class ReportBO
    {
        private readonly ReportDAO reportDAO;

        public ReportBO()
        {
            reportDAO = new ReportDAO();
        }

        public bool AddReport(string reportID, string reportName, string generateDate, string totalRevenue, string reportDescription)
        {
            return reportDAO.AddReport(reportID, reportName, generateDate, totalRevenue, reportDescription);
        }

        public bool DeleteReport(string reportID)
        {
            return reportDAO.DeleteReport(reportID);
        }

        public DataTable GetReportByName(string reportName)
        {
            return reportDAO.GetReportByName(reportName);
        }

        public DataTable GetAllReports()
        {
            return reportDAO.GetAllReports();
        }
    }
}
