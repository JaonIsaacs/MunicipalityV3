namespace MunicipalityV3.Forms
{
    partial class ViewReportsForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ListBox lstReports;
        private System.Windows.Forms.RichTextBox rtbDetails;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUndoDelete;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Label lblReports;
        private System.Windows.Forms.Label lblDetails;

        /// <summary>
        /// Clean up resources
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        /// <summary>
        /// Initialize UI components
        /// </summary>
        private void InitializeComponent()
        {
            this.lstReports = new System.Windows.Forms.ListBox();
            this.rtbDetails = new System.Windows.Forms.RichTextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUndoDelete = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.lblReports = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();

            
            this.ClientSize = new System.Drawing.Size(750, 480);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Submitted Reports";
            this.Font = new System.Drawing.Font("Segoe UI", 10F);

            /// Label: Reports
            this.lblReports.Text = "Submitted Reports";
            this.lblReports.Location = new System.Drawing.Point(20, 10);
            this.lblReports.AutoSize = true;

            ///ListBox: Reports
            this.lstReports.Location = new System.Drawing.Point(20, 40);
            this.lstReports.Size = new System.Drawing.Size(280, 380);
            this.lstReports.Anchor = (System.Windows.Forms.AnchorStyles.Top
                                     | System.Windows.Forms.AnchorStyles.Bottom
                                     | System.Windows.Forms.AnchorStyles.Left);
            this.lstReports.SelectedIndexChanged += new System.EventHandler(this.lstReports_SelectedIndexChanged);

            ///Label: Details
            this.lblDetails.Text = "Report Details";
            this.lblDetails.Location = new System.Drawing.Point(320, 10);
            this.lblDetails.AutoSize = true;

            /// RichTextBox: Details
            this.rtbDetails.Location = new System.Drawing.Point(320, 40);
            this.rtbDetails.Size = new System.Drawing.Size(400, 200);
            this.rtbDetails.ReadOnly = true;
            this.rtbDetails.Anchor = (System.Windows.Forms.AnchorStyles.Top
                                     | System.Windows.Forms.AnchorStyles.Left
                                     | System.Windows.Forms.AnchorStyles.Right);

            ///Edit Button 
            this.btnEdit.Text = "✏ Edit";
            this.btnEdit.Location = new System.Drawing.Point(320, 260);
            this.btnEdit.Size = new System.Drawing.Size(90, 35);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            ///Delete Button
            this.btnDelete.Text = "🗑 Delete";
            this.btnDelete.Location = new System.Drawing.Point(420, 260);
            this.btnDelete.Size = new System.Drawing.Size(90, 35);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            ///Undo Delete Button 
            this.btnUndoDelete.Text = "↩ Undo Delete";
            this.btnUndoDelete.Location = new System.Drawing.Point(520, 260);
            this.btnUndoDelete.Size = new System.Drawing.Size(130, 35);
            this.btnUndoDelete.Click += new System.EventHandler(this.btnUndoDelete_Click);

            /// ComboBox: Status 
            this.cmbStatus.Location = new System.Drawing.Point(320, 320);
            this.cmbStatus.Size = new System.Drawing.Size(160, 30);
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Items.AddRange(new string[] { "Pending", "In Progress", "Resolved" });

            /// Update Status Button
            this.btnUpdateStatus.Text = "🔄 Update Status";
            this.btnUpdateStatus.Location = new System.Drawing.Point(500, 320);
            this.btnUpdateStatus.Size = new System.Drawing.Size(150, 35);
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);

            /// Add Controls
            this.Controls.Add(this.lblReports);
            this.Controls.Add(this.lstReports);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.rtbDetails);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUndoDelete);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnUpdateStatus);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}