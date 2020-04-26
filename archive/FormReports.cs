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
    public partial class FormReports : Form
    {
        string username;
        string job;
        ArchieveDatabase Reports = new ArchieveDatabase();
        public FormReports(string name, string password)
        {
            InitializeComponent();
            username = name;
            initCmbBxOrgName();
        }

        void Authority()
        {
            DataTable Dt = new DataTable();
            String Quary = "select * from login where name ='" + username + "' ";
            Dt = Reports.QueryExecute(Quary);
            job = Dt.Rows[0]["job"].ToString();
        }
        private void FormReports_Load(object sender, EventArgs e)
        {
            Authority();
            FillMyData();
        }
        void FillMyData()
        {
            DatepickerStart.Value = Convert.ToDateTime(DateTime.Now.Year.ToString() + "-1-1");
            DatepickerEnd.Value = DateTime.Now;
            Search();
        }


        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
        void Search()
        {
            String type = "وارد / صادر ";
            String CommandText1 = System.String.Empty;
            String CommandText2 = System.String.Empty;
            try
            {
                string[] Dates = DatesMaker();
                DataTable Dt1 = new DataTable();
                DataTable Dt2 = new DataTable();
                CommandText1 = "select importid as id , importdate as date, orgname  , summary  , primaryfileid, secondfileid FROM importdata where ";

                CommandText1 += " orgname like'" + '%' + CmbBxOrgName.Text + '%' + "' and ";

                if (job != "")
                {
                    CommandText1 += "username like'" + '%' + job + '%' + "' and ";
                }


                CommandText1 += "importdate >= '" + Dates[0] + "' AND importdate <= '" + Dates[1] + "'";


                CommandText2 = "select exportid as id , exportdate as date , orgname , username , followingdate , summary , action , primaryfileid, secondfileid FROM exportdata where following = 1 and ";
               
                if (job != "")
                {
                    CommandText2 += "username like'" + '%' + job + '%' + "' and ";
                }
                CommandText2 += " orgname like'" + '%' + CmbBxOrgName.Text + '%' + "' and ";
                


                CommandText2 += "exportdate >= '" + Dates[0] + "' AND exportdate <= '" + Dates[1] + "'";

                if (ChkBxImportExport.Checked == true)
                {
                    type = "وارد / صادر ";
                    Dt1 = Reports.QueryExecute(CommandText1);
                    Dt2 = Reports.QueryExecute(CommandText2);
                    Dt1.Merge(Dt2);
                    Dt1.DefaultView.Sort = "date ASC,id ASC";
                    Dt1 = Dt1.DefaultView.ToTable();
                    ReportViwerData(Dt1, Dates, type);
                }
                else if (ChkBxImport.Checked == true)
                {
                    type = "وارد";
                    Dt1 = Reports.QueryExecute(CommandText1);
                    Dt1.DefaultView.Sort = "date ASC,id ASC";
                    Dt1 = Dt1.DefaultView.ToTable();
                    ReportViwerData(Dt1, Dates, type);
                }
                else if (ChkBxExport.Checked == true)
                {
                    type = "صادر";
                    Dt2 = Reports.QueryExecute(CommandText2);
                    Dt2.DefaultView.Sort = "date ASC,id ASC";
                    Dt2 = Dt2.DefaultView.ToTable();
                    ReportViwerData(Dt2, Dates, type);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public void ReportViwerData(DataTable dt, string[] Dates, String type)
        {
            ReportDataSource rprtDTSource = new ReportDataSource("ReportData", dt);
            ReportParameterCollection ReportParameters = new ReportParameterCollection();
            ReportParameters.Add(new ReportParameter("date1", Dates[0]));
            ReportParameters.Add(new ReportParameter("date2", Dates[1]));
            ReportParameters.Add(new ReportParameter("type", type));

            this.ReportViewerFollowing.LocalReport.SetParameters(ReportParameters);
            this.ReportViewerFollowing.LocalReport.DataSources.Clear();
            this.ReportViewerFollowing.LocalReport.DataSources.Add(rprtDTSource);
            this.ReportViewerFollowing.LocalReport.Refresh();
            this.ReportViewerFollowing.RefreshReport();
            ReportViewerFollowing.ZoomPercent = 130;
        }
        public string[] DatesMaker()
        {
            string[] Dates = new string[2];
            DateTime[] Datespickers = { DatepickerStart.Value, DatepickerEnd.Value };
            for (int i = 0; i < Datespickers.Length; i++)
            {
                Dates[i] = Convert.ToDateTime(Datespickers[i]).ToString("yyyy-MM-dd");
            }
            return Dates;
        }

        private void ChkBxImportExport_OnChange(object sender, EventArgs e)
        {
            if (ChkBxImportExport.Checked == true)
            {
                ChkBxImport.Checked = false;
                ChkBxExport.Checked = false;
            }
            else
            {
                if (ChkBxImport.Checked == true)
                {
                    ChkBxExport.Checked = false;
                }
                else
                {
                    ChkBxExport.Checked = true;
                }
            }
        }
        private void ChkBxImport_OnChange(object sender, EventArgs e)
        {
            if (ChkBxImport.Checked == true)
            {
                ChkBxImportExport.Checked = false;
                ChkBxExport.Checked = false;
            }
            else
            {
                if (ChkBxExport.Checked == true)
                {
                    ChkBxImportExport.Checked = false;
                }
                else
                {
                    ChkBxImportExport.Checked = true;
                }
            }

        }
        private void ChkBxExport_OnChange(object sender, EventArgs e)
        {
            if (ChkBxExport.Checked == true)
            {
                ChkBxImportExport.Checked = false;
                ChkBxImport.Checked = false;
            }
            else
            {
                if (ChkBxImport.Checked == true)
                {
                    ChkBxImportExport.Checked = false;
                }
                else
                {
                    ChkBxImportExport.Checked = true;
                }
            }
        }

        void initCmbBxOrgName()
        {
            DataTable Dt = new DataTable();
            CmbBxOrgName.Items.Clear();
            CmbBxOrgName.Text = "";
            Dt = Reports.QueryExecute("select orgname from org order by orgname");
            for (int Index = 0; Index < Dt.Rows.Count; Index++)
            {
                CmbBxOrgName.Items.Add(Dt.Rows[Index][0]);
            }

        }

    }
}
