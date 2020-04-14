using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace archive
{
    public partial class FormSearchReports : Form
    {
        public FormSearchReports(DataTable dt ,string type)
        {
            InitializeComponent();
            ReportViwerData(dt, type);
        }

        private void FormSearchReports_Load(object sender, EventArgs e)
        {
            this.ReportSearch.RefreshReport();
        }

        public void ReportViwerData(DataTable dt,string type)
        {
            ReportDataSource rprtDTSource = new ReportDataSource("ReportData", dt);
            ReportParameterCollection ReportParameters = new ReportParameterCollection();
            ReportParameters.Add(new ReportParameter("type", type));

            this.ReportSearch.LocalReport.SetParameters(ReportParameters);
            this.ReportSearch.LocalReport.DataSources.Clear();
            this.ReportSearch.LocalReport.DataSources.Add(rprtDTSource);
            this.ReportSearch.LocalReport.Refresh();
            this.ReportSearch.RefreshReport();
            this.ReportSearch.ZoomPercent = 183;
        }
    }
}
