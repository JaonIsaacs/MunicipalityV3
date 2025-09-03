using MunicipalityV3.Forms;

namespace MunicipalityV3
{
    /// <summary>
    /// main navigation
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            new ReportIssueForm().ShowDialog();
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            new ViewReportsForm().ShowDialog();
        }
    }
}
