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
    public partial class ReportIssueForm : Form
    {
        private readonly IssueReport _editingReport;

        /// <summary>
        /// Default constructor for new report
        /// </summary>
        public ReportIssueForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Overloaded constructor for editing existing report
        /// </summary>
        /// <param name="report"></param>
        public ReportIssueForm(IssueReport report) : this()
        {
            _editingReport = report;
            txtLocation.Text = report.Location;
            cmbCategory.SelectedItem = report.Category;
            rtbDescription.Text = report.Description;
            foreach (var att in report.Attachments)
            {
                lstAttachments.Items.Add(att);
            }
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog { Multiselect = true };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var file in dialog.FileNames)
                {
                    lstAttachments.Items.Add(file);
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_editingReport != null)
            {
                /// Editing an existing report
                _editingReport.Location = txtLocation.Text;
                _editingReport.Category = cmbCategory.SelectedItem?.ToString();
                _editingReport.Description = rtbDescription.Text;

                var newAttachments = new LinkedList<string>();
                foreach (var item in lstAttachments.Items)
                    newAttachments.AddLast(item.ToString());

                _editingReport.Attachments = newAttachments;

                ReportService.UpdateReport(_editingReport);
                lblEngagement.Text = "✏ Report updated successfully!";
            }
            else
            {
                /// New report entry
                var report = new IssueReport
                {
                    Location = txtLocation.Text,
                    Category = cmbCategory.SelectedItem?.ToString(),
                    Description = rtbDescription.Text
                };

                foreach (var item in lstAttachments.Items)
                {
                    report.Attachments.AddLast(item.ToString());
                }

                ReportService.AddReport(report);
                lblEngagement.Text = "✅ Thank you! Report submitted.";
                progressEngagement.Value = Math.Min(progressEngagement.Value + 20, 100);
                ClearForm();
            }
        }

        private void ClearForm()
        {
            txtLocation.Clear();
            cmbCategory.SelectedIndex = -1;
            rtbDescription.Clear();
            lstAttachments.Items.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
