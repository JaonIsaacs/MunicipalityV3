namespace MunicipalityV3.Forms
{
    partial class ViewReportsForm
    {
        private System.ComponentModel.IContainer components = null;
        private ListBox lstReports;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstReports = new ListBox();
            this.SuspendLayout();

            /// Reports List
            this.lstReports.Location = new System.Drawing.Point(20, 20);
            this.lstReports.Width = 350;
            this.lstReports.Height = 300;

            /// ViewReportsForm
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.lstReports);
            this.Text = "Submitted Reports";
            this.ResumeLayout(false);
        }
    }
}