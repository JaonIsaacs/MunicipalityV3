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
        public ReportIssueForm()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog();
            dialog.Multiselect = true;
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
            var report = new IssueReport
            {
                Location = txtLocation.Text,
                Category = cmbCategory.SelectedItem?.ToString(),
                Description = rtbDescription.Text
            };

            foreach (var item in lstAttachments.Items)
            {
                report.Attachments.Add(item.ToString());
            }

            ReportService.AddReport(report);
            lblEngagement.Text = "✅ Thank you! Your report has been submitted.";
            ClearForm();
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
