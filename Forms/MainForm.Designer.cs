namespace MunicipalityV3
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblSubtitle;
        private Button btnReportIssues;
        private Button btnLocalEvents;
        private Button btnServiceStatus;
        private Button btnViewReports;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblSubtitle = new Label();
            this.btnReportIssues = new Button();
            this.btnLocalEvents = new Button();
            this.btnServiceStatus = new Button();
            this.btnViewReports = new Button();
            this.SuspendLayout();

            // ===== MainForm =====
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "MunicipalityV3 - Main Menu";
            this.Font = new System.Drawing.Font("Segoe UI", 10F);

            // ===== Title Label =====
            this.lblTitle.Text = "🏛 MunicipalityV3";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.AutoSize = true;

            // ===== Subtitle Label =====
            this.lblSubtitle.Text = "Citizen Engagement Platform";
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitle.Location = new System.Drawing.Point(22, 55);
            this.lblSubtitle.AutoSize = true;

            // ===== Report Issues Button =====
            this.btnReportIssues.Text = "📝 Report Issues";
            this.btnReportIssues.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnReportIssues.Size = new System.Drawing.Size(300, 50);
            this.btnReportIssues.Location = new System.Drawing.Point(100, 110);
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);

            // ===== Local Events Button =====
            this.btnLocalEvents.Text = "📅 Local Events (Coming Soon)";
            this.btnLocalEvents.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnLocalEvents.Size = new System.Drawing.Size(300, 50);
            this.btnLocalEvents.Location = new System.Drawing.Point(100, 170);
            this.btnLocalEvents.Enabled = false;

            // ===== Service Status Button =====
            this.btnServiceStatus.Text = "🔧 Service Request Status (Coming Soon)";
            this.btnServiceStatus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnServiceStatus.Size = new System.Drawing.Size(300, 50);
            this.btnServiceStatus.Location = new System.Drawing.Point(100, 230);
            this.btnServiceStatus.Enabled = false;

            // ===== View Reports Button =====
            this.btnViewReports.Text = "📂 View Submitted Reports";
            this.btnViewReports.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnViewReports.Size = new System.Drawing.Size(300, 50);
            this.btnViewReports.Location = new System.Drawing.Point(100, 290);
            this.btnViewReports.Click += new System.EventHandler(this.btnViewReports_Click);

            // Add Controls
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.btnReportIssues);
            this.Controls.Add(this.btnLocalEvents);
            this.Controls.Add(this.btnServiceStatus);
            this.Controls.Add(this.btnViewReports);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
