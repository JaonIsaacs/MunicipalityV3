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

        public ReportIssueForm()
        {
            InitializeComponent();
            HookEventsForProgress();
            UpdateProgress(); /// ensure bar starts at 0
        }

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

            UpdateProgress(); /// update based on pre-filled fields
        }

        private void HookEventsForProgress()
        {
            txtLocation.TextChanged += (s, e) => UpdateProgress();
            cmbCategory.SelectedIndexChanged += (s, e) => UpdateProgress();
            rtbDescription.TextChanged += (s, e) => UpdateProgress();
            lstAttachments.SelectedIndexChanged += (s, e) => UpdateProgress();
        }

        private void UpdateProgress()
        {
            int progress = 0;

            if (!string.IsNullOrWhiteSpace(txtLocation.Text)) progress += 25;
            if (cmbCategory.SelectedItem != null) progress += 25;
            if (!string.IsNullOrWhiteSpace(rtbDescription.Text)) progress += 25;
            if (lstAttachments.Items.Count > 0) progress += 25;

            progressEngagement.Value = progress;
            lblEngagement.Text = progress switch
            {
                0 => "Let's get started! ",
                25 => "Good start, keep going! ",
                50 => "Halfway there! ",
                75 => "Almost done! ",
                100 => "Ready to submit! ✅",
                _ => lblEngagement.Text
            };
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
                UpdateProgress(); /// update progress after adding attachments
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_editingReport != null)
            {
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
                ClearForm();
                UpdateProgress(); /// reset after submit
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
