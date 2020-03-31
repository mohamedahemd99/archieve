using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Reporting.WinForms;

namespace archive
{
    public partial class FormFollowing : Form
    {
        ArchieveDatabase Following = new ArchieveDatabase();
        string job;
        public FormFollowing(string Name, string password)
        {
            InitializeComponent();
            TxtUser.Text = Name;
        }
        private void FormFollowing_Load(object sender, EventArgs e)
        {
            if (job != null)
            {
                bunifuCustomLabel1.Visible = false;
                CmbBxUserName.Visible = false;
            }
            Authority();
            DatepickerStart.Value = DateTime.Now;
            DatepickerEnd.Value = DateTime.Now;
            Search();
            FillCmbBxUserName();
           
        }
        void Authority()
        {
            DataTable Dt = new DataTable();
            String Quary = "select * from login where name ='" + TxtUser.Text + "' ";
            Dt = Following.QueryExecute(Quary);

            job = Dt.Rows[0]["job"].ToString();

        }
        void FillCmbBxUserName()
        {
            DataTable Dt = new DataTable();
            Dt = Following.QueryExecute("select username from users");
            for (int Index = 0; Index < Dt.Rows.Count; Index++)
            {
                CmbBxUserName.Items.Add(Dt.Rows[Index][0]);
            }
            CmbBxUserName.Text = "اختر مختص";
            //CmbBxUserName.Sorted = true;
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
        public void ReportViwerData(DataTable dt, string[] Dates , String type)
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
            this.ReportViewerFollowing.ZoomPercent = 125;
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
        private void orgid_OnValueChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = Following.QueryExecute("select orgname from org where idorg = '" + orgid.Text + "'");
            string array = String.Empty;
            if (Dt.Rows.Count > 0)
            {
                array = Dt.Rows[0]["orgname"].ToString();
            }
            orgname.Text = array;
        }
        private void orgname_OnValueChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = Following.QueryExecute("select idorg from org where orgname like '" + orgname.Text + "'");
            string array = String.Empty;
            if (Dt.Rows.Count > 0)
            {
                array = Dt.Rows[0]["idorg"].ToString();
            }
            orgid.Text = array;
        }
        String StringNewSearchForm(String Data)
        {
            int IndexString;
            StringBuilder NewFormat = new StringBuilder(Data);

            for (IndexString = 0; IndexString < Data.Length; IndexString++)
            {
                if (Data[IndexString] == 'أ' || Data[IndexString] == 'ا' || Data[IndexString] == 'إ' || Data[IndexString] == 'آ' || Data[IndexString] == 'ي' || Data[IndexString] == 'ى' || Data[IndexString] == 'ه' || Data[IndexString] == 'ة' || Data[IndexString] == ' ')
                {
                    NewFormat[IndexString] = '%';
                }
            }
            return NewFormat.ToString();
        }
        private void CmbBxUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBxUsers.Items.Contains(CmbBxUserName.Text) == false)
            {
                lstBxUsers.Items.Add(CmbBxUserName.Text);
            }
        }
        private void Active_OnChange(object sender, EventArgs e)
        {
            if (Active.Checked == true)
            {
                BothActive.Checked = false;
                NotActive.Checked = false;
            }
            else
            {
                if (ChkBxExport.Checked == true)
                {
                    BothActive.Checked = false;
                }
                else
                {
                    BothActive.Checked = true;
                }
            }
        }
        private void NotActive_OnChange(object sender, EventArgs e)
        {
            if (NotActive.Checked == true)
            {
                BothActive.Checked = false;
                Active.Checked = false;
            }
            else
            {
                if (Active.Checked == true)
                {
                    BothActive.Checked = false;
                }
                else
                {
                    BothActive.Checked = true;
                }
            }
        }
        private void BothActive_OnChange(object sender, EventArgs e)
        {
            if (BothActive.Checked == true)
            {
                Active.Checked = false;
                NotActive.Checked = false;
            }
            else
            {
                if (Active.Checked == true)
                {
                    NotActive.Checked = false;
                }
                else
                {
                    NotActive.Checked = true;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormReportItem FormSearchReport = new FormReportItem();
            FormSearchReport.Show();
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
                CommandText1 = "select importid as id , importdate as date, orgname , username , followingdate , summary , action , primaryfileid, secondfileid FROM importdata where following = 1 and ";
                if (orgname.Text != "")
                {
                    CommandText1 += " orgname like'" + '%' + StringNewSearchForm(orgname.Text) + '%' + "' and ";
                }
                if (job != "")
                {
                    CommandText1 += "username like'" + '%' + job + '%' + "' and ";
                }

                if (CmbBxUserName.Text != "اختر مختص")
                {
                    CommandText1 += " username like'" + '%' + StringNewSearchForm(CmbBxUserName.Text) + '%' + "' and ";
                }
                   CommandText1 += " followingdate >= '" + Dates[0] + "' AND followingdate <= '" + Dates[1] + "'";


                    CommandText2 = "select exportid as id , exportdate as date , orgname , username , followingdate , summary , action , primaryfileid, secondfileid FROM exportdata where following = 1 and ";
                if (orgname.Text != "")
                {
                    CommandText2 += " orgname like'" + '%' + StringNewSearchForm(orgname.Text) + '%' + "' and ";
                }
                if (job != "")
                {
                    CommandText2 += "username like'" + '%' + job + '%' + "' and ";
                }

                if (CmbBxUserName.Text != "اختر مختص")
                {
                    CommandText2 += " username like'" + '%' + StringNewSearchForm(CmbBxUserName.Text) + '%' + "' and ";
                }
                    CommandText2 += " followingdate >= '" + Dates[0] + "' AND followingdate <= '" + Dates[1] + "'";

                if (ChkBxImportExport.Checked == true)
                {
                    type = "وارد / صادر ";
                    Dt1 = Following.QueryExecute(CommandText1);
                    Dt2 = Following.QueryExecute(CommandText2);
                    Dt1.Merge(Dt2);
                    Dt1.DefaultView.Sort = "followingdate ASC,id ASC";
                    Dt1 = Dt1.DefaultView.ToTable();
                    ReportViwerData(Dt1, Dates, type);
                }
                else if (ChkBxImport.Checked == true)
                {
                    type = "وارد";
                    Dt1 = Following.QueryExecute(CommandText1);
                    Dt1.DefaultView.Sort = "followingdate ASC,id ASC";
                    Dt1 = Dt1.DefaultView.ToTable();
                    ReportViwerData(Dt1, Dates, type);
                }
                else if (ChkBxExport.Checked == true)
                {
                    type = "صادر";
                    Dt2 = Following.QueryExecute(CommandText2);
                    Dt2.DefaultView.Sort = "followingdate ASC,id ASC";
                    Dt2 = Dt2.DefaultView.ToTable();
                    ReportViwerData(Dt2, Dates, type);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
