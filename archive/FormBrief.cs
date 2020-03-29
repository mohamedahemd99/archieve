using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace archive
{
    public partial class FormBrief : Form
    {
        public FormBrief(DataTable dt)
        {
            InitializeComponent();
            ReportViwerData(dt);

        }

        private void FormBrief_Load(object sender, EventArgs e)
        {
            this.ReportViewerFollowing.RefreshReport();

        }
        public void ReportViwerData(DataTable dt)
        {
            ReportDataSource rprtDTSource = new ReportDataSource("ReportData", dt);
            ReportParameterCollection ReportParameters = new ReportParameterCollection();
            this.ReportViewerFollowing.LocalReport.SetParameters(ReportParameters);
            this.ReportViewerFollowing.LocalReport.DataSources.Clear();
            this.ReportViewerFollowing.LocalReport.DataSources.Add(rprtDTSource);
            this.ReportViewerFollowing.LocalReport.Refresh();
            this.ReportViewerFollowing.RefreshReport();
            this.ReportViewerFollowing.ZoomPercent = 125;
        }
    }
}
