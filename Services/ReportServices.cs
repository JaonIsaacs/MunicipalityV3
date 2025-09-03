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
        private static readonly LinkedList<IssueReport> _reports = new LinkedList<IssueReport>();
        private static readonly Queue<IssueReport> _newReports = new Queue<IssueReport>();
        private static readonly Stack<IssueReport> _deletedReports = new Stack<IssueReport>();

        public static void AddReport(IssueReport report)
        {
            _reports.AddLast(report);
            _newReports.Enqueue(report);
        }

        public static IEnumerable<IssueReport> GetAllReports()
        {
            return _reports;
        }

        public static void UpdateReport(IssueReport updatedReport)
        {
            var node = _reports.First;
            while (node != null)
            {
                if (node.Value.Id == updatedReport.Id)
                {
                    node.Value.Location = updatedReport.Location;
                    node.Value.Category = updatedReport.Category;
                    node.Value.Description = updatedReport.Description;
                    node.Value.Attachments = updatedReport.Attachments;
                    node.Value.Status = updatedReport.Status;
                    break;
                }
                node = node.Next;
            }
        }

        public static void DeleteReport(Guid reportId)
        {
            var node = _reports.First;
            while (node != null)
            {
                if (node.Value.Id == reportId)
                {
                    _deletedReports.Push(node.Value);
                    _reports.Remove(node);
                    break;
                }
                node = node.Next;
            }
        }

        public static bool UndoDelete()
        {
            if (_deletedReports.Count == 0) return false;
            var report = _deletedReports.Pop();
            _reports.AddLast(report);
            return true;
        }

        public static IssueReport GetNextNewReport()
        {
            if (_newReports.Count > 0)
                return _newReports.Dequeue();
            return null;
        }
    }
}
