using MunicipalityV3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityV3.Services
{
    public static class ReportService
    {
        // Static list to hold all reports in memory
        private static readonly List<IssueReport> _reports = new List<IssueReport>();

        public static void AddReport(IssueReport report)
        {
            _reports.Add(report);
        }

        public static List<IssueReport> GetAllReports()
        {
            return new List<IssueReport>(_reports);
        }
    }
}
