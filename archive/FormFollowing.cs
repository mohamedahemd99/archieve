﻿using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace archive
{
    public partial class FormFollowing : Form
    {
        ArchieveDatabase Following = new ArchieveDatabase();
        string job;
        string pw;
        public FormFollowing(string Name, string password, DateTime start, DateTime end)
        {
            InitializeComponent();
            DatepickerStart.Value = start;
            DatepickerEnd.Value = end;
            TxtUser.Text = Name;
            pw = password;
        }
        private void FormFollowing_Load(object sender, EventArgs e)
        {
            
            if (job != null)
            {
                CmbBxUserName.Visible = false;
            }
            Search();
            FillCmbBxUserName();
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
        void Search()
        {
            string type = "وارد / صادر ";
            string CommandText1 = string.Empty;
            string CommandText2 = string.Empty;
            try
            {
                string[] Dates = DatesMaker();
                DataTable Dt1 = new DataTable();
                DataTable Dt2 = new DataTable();
                CommandText1 = "select importid as id , importdate as date, orgname ,summary , username , followingdate  , primaryfileid, secondfileid,  action,importdata.id as uniqueId FROM importdata where following = 1 and ";
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


                CommandText2 = "select exportid as id , exportdate as date , orgname ,summary , username , followingdate  , primaryfileid, secondfileid,  action ,exportdata.id as uniqueId FROM exportdata where following = 1 and ";
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
                    dataGridView.DataSource = Dt1;
                }
                else if (ChkBxImport.Checked == true)
                {
                    type = "وارد";
                    Dt1 = Following.QueryExecute(CommandText1);
                    Dt1.DefaultView.Sort = "followingdate ASC,id ASC";
                    Dt1 = Dt1.DefaultView.ToTable();
                    ReportViwerData(Dt1, Dates, type);
                    dataGridView.DataSource = Dt1;
                }
                else if (ChkBxExport.Checked == true)
                {
                    type = "صادر";
                    Dt2 = Following.QueryExecute(CommandText2);
                    Dt2.DefaultView.Sort = "followingdate ASC,id ASC";
                    Dt2 = Dt2.DefaultView.ToTable();
                    ReportViwerData(Dt2, Dates, type);
                    dataGridView.DataSource = Dt2;
                }
                Init_Dgv();
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Init_Dgv()
        {
            String[] DgvHeaders = { "رقم المكانبة ", "تاريخ المكاتبة ", "اسم الجهة", " ملخص الموضوع", "المختصون ", "تاريخ المتابعة ","ملف" ,"ك", "اجراء متخذ" };
            for (int i = 0; i < DgvHeaders.Length; i++)
            {
                dataGridView.Columns[i].HeaderText = DgvHeaders[i];
            }

            dataGridView.Columns[0].Width = 55;
            dataGridView.Columns[1].Width = 75;
            dataGridView.Columns[2].Width = 150;
            dataGridView.Columns[3].Width = 500;
            dataGridView.Columns[4].Width = 75;
            dataGridView.Columns[5].Width = 75;
            dataGridView.Columns[6].Width = 75;
            dataGridView.Columns[7].Width = 75;
            dataGridView.Columns[8].Width = 75;
            dataGridView.Columns[9].Visible = false;
        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            string id = dataGridView[9, e.RowIndex].Value.ToString(); //to get id of clicked cell
            string summary = dataGridView[3, e.RowIndex].Value.ToString();
            string[] splittedID = id.Split('-');
            string[] correspondenceData = new string[3];
            correspondenceData[0] = (splittedID[2] == "ص") ? "export" : "import";
            correspondenceData[1] = splittedID[0];
            correspondenceData[2] = summary;
            FormSearch Formsearch = new FormSearch(" " + TxtUser.Text, pw, correspondenceData);
            Formsearch.Show();
            Formsearch.BringToFront();
        }

        private void show_report_btn_Click(object sender, EventArgs e)
        {
            dataGridView.Visible = !dataGridView.Visible;
        }
    }
}
