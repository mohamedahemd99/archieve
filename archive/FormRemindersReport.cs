using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace archive
{
    public partial class FormRemindersReport : Form
    {
        DataTable reportDatatable;
        public FormRemindersReport(DataTable dt)
        {
            InitializeComponent();
            reportDatatable = dt;
        }

        private void FormRemindersReport_Load(object sender, EventArgs e)
        {
            showReport(reportDatatable);
            this.reportViewer1.RefreshReport();
        }

        public void showReport(DataTable dt)
        {

            ReportDataSource rprtDTSource = new ReportDataSource("ReportData", dt);
            ReportParameterCollection ReportParameters = new ReportParameterCollection();
            this.reportViewer1.LocalReport.SetParameters(ReportParameters);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rprtDTSource);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.ZoomPercent = 125;
        }

    }
}
