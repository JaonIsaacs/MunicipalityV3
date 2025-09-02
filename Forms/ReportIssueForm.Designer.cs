namespace MunicipalityV3.Forms
{
    partial class ReportIssueForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtLocation;
        private ComboBox cmbCategory;
        private RichTextBox rtbDescription;
        private Button btnAttach;
        private ListBox lstAttachments;
        private Button btnSubmit;
        private Label lblEngagement;
        private Button btnBack;
        private ProgressBar progressEngagement;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtLocation = new TextBox();
            this.cmbCategory = new ComboBox();
            this.rtbDescription = new RichTextBox();
            this.btnAttach = new Button();
            this.lstAttachments = new ListBox();
            this.btnSubmit = new Button();
            this.lblEngagement = new Label();
            this.btnBack = new Button();
            this.progressEngagement = new ProgressBar();
            this.SuspendLayout();

            // ===== ReportIssueForm =====
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Report an Issue - MunicipalityV3";
            this.Font = new System.Drawing.Font("Segoe UI", 10F);

            // ===== Location Label =====
            Label lblLocation = new Label();
            lblLocation.Text = "📍 Location:";
            lblLocation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblLocation.Location = new System.Drawing.Point(20, 20);
            lblLocation.AutoSize = true;

            // Location TextBox
            this.txtLocation.Location = new System.Drawing.Point(20, 45);
            this.txtLocation.Width = 400;
            this.txtLocation.PlaceholderText = "Enter the location of the issue...";

            // ===== Category Label =====
            Label lblCategory = new Label();
            lblCategory.Text = "📂 Category:";
            lblCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblCategory.Location = new System.Drawing.Point(20, 85);
            lblCategory.AutoSize = true;

            // Category ComboBox
            this.cmbCategory.Location = new System.Drawing.Point(20, 110);
            this.cmbCategory.Width = 250;
            this.cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbCategory.Items.AddRange(new string[] { "Sanitation", "Roads", "Utilities", "Other" });

            // ===== Description Label =====
            Label lblDescription = new Label();
            lblDescription.Text = "📝 Description:";
            lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblDescription.Location = new System.Drawing.Point(20, 150);
            lblDescription.AutoSize = true;

            // Description RichTextBox
            this.rtbDescription.Location = new System.Drawing.Point(20, 175);
            this.rtbDescription.Size = new System.Drawing.Size(540, 120);

            // ===== Attachments Label =====
            Label lblAttachments = new Label();
            lblAttachments.Text = "📎 Attachments:";
            lblAttachments.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblAttachments.Location = new System.Drawing.Point(20, 310);
            lblAttachments.AutoSize = true;

            // Attach Button
            this.btnAttach.Text = "Add Files...";
            this.btnAttach.Location = new System.Drawing.Point(20, 335);
            this.btnAttach.Click += new EventHandler(this.btnAttach_Click);

            // Attachments ListBox
            this.lstAttachments.Location = new System.Drawing.Point(120, 335);
            this.lstAttachments.Size = new System.Drawing.Size(440, 80);

            // ===== Submit Button =====
            this.btnSubmit.Text = "✅ Submit Report";
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(20, 430);
            this.btnSubmit.Click += new EventHandler(this.btnSubmit_Click);

            // Back Button
            this.btnBack.Text = "⬅ Back to Menu";
            this.btnBack.Location = new System.Drawing.Point(200, 430);
            this.btnBack.Click += new EventHandler(this.btnBack_Click);

            // Engagement Label
            this.lblEngagement.Text = "We value your participation!";
            this.lblEngagement.Location = new System.Drawing.Point(400, 435);
            this.lblEngagement.AutoSize = true;

            // Engagement ProgressBar
            this.progressEngagement.Location = new System.Drawing.Point(400, 460);
            this.progressEngagement.Size = new System.Drawing.Size(160, 20);
            this.progressEngagement.Value = 0;

            // Add Controls
            this.Controls.Add(lblLocation);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(lblDescription);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(lblAttachments);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.lstAttachments);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblEngagement);
            this.Controls.Add(this.progressEngagement);

            this.ResumeLayout(false);
        }
    }
}