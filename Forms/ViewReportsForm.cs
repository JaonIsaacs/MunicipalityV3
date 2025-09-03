using MunicipalityV3.Models;
using MunicipalityV3.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalityV3.Forms
{

    public partial class ViewReportsForm : Form
    {
        private IssueReport selectedReport;

        public ViewReportsForm()
        {
            InitializeComponent();
            LoadReports();
        }
        /// <summary>
        /// loads all currently saved reports
        /// </summary>
        private void LoadReports()
        {
            lstReports.Items.Clear();
            foreach (var report in ReportService.GetAllReports())
            {
                lstReports.Items.Add(report);
            }
        }

        private void lstReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstReports.SelectedItem is IssueReport report)
            {
                selectedReport = report;
                DisplayReportDetails(report);
                cmbStatus.SelectedItem = report.Status;
            }
        }
        /// <summary>
        /// uses basic icons from andriod emojis to be used in ui
        /// </summary>
        /// <param name="report"></param>
        private void DisplayReportDetails(IssueReport report)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"📍 Location: {report.Location}");
            sb.AppendLine($"📂 Category: {report.Category}");
            sb.AppendLine($"📝 Description: {report.Description}");
            sb.AppendLine($"📎 Attachments: {string.Join(", ", report.Attachments)}");
            sb.AppendLine($"📅 Submitted: {report.SubmittedAt}");
            sb.AppendLine($"🔄 Status: {report.Status}");

            rtbDetails.Text = sb.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedReport == null) return;
            new ReportIssueForm(selectedReport).ShowDialog();
            LoadReports();
        }
        /// <summary>
        /// A basic data removel feature which asks if the user is sure they wish to remove the selected item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedReport == null) return;

            var confirm = MessageBox.Show("Are you sure you want to delete this report?",
                                          "Confirm Delete",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                ReportService.DeleteReport(selectedReport.Id);
                LoadReports();
                rtbDetails.Clear();
                selectedReport = null;
            }
        }
        /// <summary>
        /// in case of accidental delete of a repot, users can undo last removel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUndoDelete_Click(object sender, EventArgs e)
        {
            if (ReportService.UndoDelete())
            {
                LoadReports();
                MessageBox.Show("Last deleted report restored.", "Undo Successful");
            }
            else
            {
                MessageBox.Show("No deleted reports to restore.", "Undo Failed");
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (selectedReport == null || cmbStatus.SelectedItem == null) return;

            selectedReport.Status = cmbStatus.SelectedItem.ToString();
            ReportService.UpdateReport(selectedReport);
            LoadReports();
            DisplayReportDetails(selectedReport);
        }
    }
}

