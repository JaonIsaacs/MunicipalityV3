using MunicipalityV3.Forms;

namespace MunicipalityV3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            var reportForm = new ReportIssueForm();
            reportForm.ShowDialog();
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            var viewReportsForm = new ViewReportsForm();
            viewReportsForm.ShowDialog();
        }
    }
}
