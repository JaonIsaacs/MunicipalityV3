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
        public ViewReportsForm()
        {
            InitializeComponent();
            LoadReports();
        }

        private void LoadReports()
        {
            lstReports.Items.Clear();
            foreach (var report in ReportService.GetAllReports())
            {
                lstReports.Items.Add(report.ToString());
            }
        }
    }
}
