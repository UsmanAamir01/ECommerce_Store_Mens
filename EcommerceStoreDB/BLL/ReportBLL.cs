using EcommerceStoreDB.DAL;
using System;
using System.Data;

namespace EcommerceStoreDB.BLL
{
    public class ReportBLL
    {
        private readonly ReportDAL reportDAL;

        public ReportBLL()
        {
            reportDAL = new ReportDAL();
        }

        public DataTable LoadReports()
        {
            return reportDAL.GetReports();
        }

        public bool ApproveReport(int reportId)
        {
            return reportDAL.UpdateReportStatus(reportId, "Approved") > 0;
        }

        public bool DeclineReport(int reportId)
        {
            return reportDAL.UpdateReportStatus(reportId, "Declined") > 0;
        }
    }
}
