﻿using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace archive
{
    public partial class FormVisit : Form
    {
       
        ArchieveDatabase Visit = new ArchieveDatabase();
        string username;
        string visit;
        public FormVisit(string name, string password)
        {
       
            InitializeComponent();
            username = name;
        }


        private void FormVisit_Load(object sender, EventArgs e)
        {
            FillMyData();
            DateStartVisit.Value = DateTime.Now;
            DateEndVisit.Value = DateTime.Now;
            DatepickerStart.Value = DateTime.Now;
            DatepickerEnd.Value = Convert.ToDateTime(DateTime.Now.Year.ToString() + "-12-31");
            DgvVisit.Columns[0].HeaderText = " رقم الوارد";
            DgvVisit.Columns[1].HeaderText = "جهة الوارد " ;
            DgvVisit.Columns[2].HeaderText = "الموضوع" ;
            DgvVisit.Columns[3].HeaderText = " جهة الزيارة" ;
            DgvVisit.Columns[4].HeaderText = " بداية الزيارة" ;
            DgvVisit.Columns[5].HeaderText = " نهاية الزيارة" ;
            Authority();
        }
        void Authority()
        {
            DataTable Dt = new DataTable();
            String Quary = "select * from login where name ='" + username + "' ";
            Dt = Visit.QueryExecute(Quary);
            visit = Dt.Rows[0]["visit"].ToString();
        }
        void FillMyData()
        {
            DataTable Dt = new DataTable();
            string[] Dates = DatesMaker();
            Dt = Visit.QueryExecute("select * from Visit where date >= '" + Dates[0] + "' AND date <= '" + Dates[1] + "'  ORDER BY DATE(date) ASC");
            DgvVisit.DataSource = Dt;
            ReportViwerData(Dt, Dates);
            //DgvVisit.DataSource = Visit.QuaryExecute("select * from Visit");
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

        private void BtnAddVisit_Click(object sender, EventArgs e)
        {
            if (Txtsubject.Text != "" && TxtorgVisit.Text != "")
            {
                try
                {
                    if (visit == "1")
                    {

                    String VisitDate = Convert.ToDateTime(DateStartVisit.Value).ToString("yyyy-MM-dd");
                    String EndVisitDate = Convert.ToDateTime(DateEndVisit.Value).ToString("yyyy-MM-dd");
                    int Test = Visit.MyExecuteNonQuery("INSERT INTO Visit (subject,orgvisit,date,enddate,org,importid) VALUES ('" + Txtsubject.Text + "','" + TxtorgVisit.Text + "','" + VisitDate + "','" + EndVisitDate + "','" + TxtImportID.Text + "','" + TxtImportID.Text + "')");
                    if (Test == 1)
                    {
                        FillMyData();
                        MessageBox.Show("تم ادخال البيانات بنجاح");
                    }
                    else
                    {
                        MessageBox.Show("لم يتم ادخال البيانات");
                    }
                    Txtsubject.ResetText();
                    TxtorgVisit.ResetText();
                    TxtImportID.ResetText();
                    TxtImportID.ResetText();
                    DateStartVisit.ResetText();
                    DateEndVisit.ResetText();
                    }
                    else
                    {

                        MessageBox.Show("غير مسموح لك باضافة زيارة");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("هذه البيانات غير صحيحة");
                }
            }
            else
            {
                MessageBox.Show("من فضلك قم بادخال البيانات");
            }
       
    }

        private void BtnEditVisit_Click(object sender, EventArgs e)
        {
            try
            {
                if (visit == "1")
                {

                    String VisitDate = Convert.ToDateTime(DateStartVisit.Value).ToString("yyyy-MM-dd");
                String EndVisitDate = Convert.ToDateTime(DateEndVisit.Value).ToString("yyyy-MM-dd");
                String DeleteQuery = "DELETE FROM  Visit  WHERE importid= '" + TxtImportID.Text + "' ";
                String InsertQuery = "INSERT INTO Visit (subject,orgvisit,date,enddate,org,importid) VALUES ('" + Txtsubject.Text + "','" + TxtorgVisit.Text + "','" + VisitDate + "','" + EndVisitDate + "','" + TxtImportID.Text + "','" + TxtImportID.Text + "')";
                int Test1 = Visit.MyExecuteNonQuery(DeleteQuery);
                int Test2 = Visit.MyExecuteNonQuery(InsertQuery);
                if (Test1 == 1 && Test2 == 1)
                {
                    FillMyData();
                    MessageBox.Show("تم تعديل البيانات بنجاح");
                }
                else
                {
                    MessageBox.Show("لم يتم التعديل");
                }
                Txtsubject.ResetText();
                TxtorgVisit.ResetText();
                TxtImportID.ResetText();
                TxtImportID.ResetText();
                DateStartVisit.ResetText();
                DateEndVisit.ResetText();
                }
                else
                {

                    MessageBox.Show("غير مسموح لك بتعديل زيارة");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("هذه البيانات غير صحيحة");
            }
        }

        private void BtnDeleteVisit_Click(object sender, EventArgs e)
        {
            try
            {
                if (visit == "1")
                {

                    String DeleteQuery = "DELETE FROM  Visit  WHERE importid= '" + TxtImportID.Text + "' ";
                int Test = Visit.MyExecuteNonQuery(DeleteQuery);
                if (Test == 1)
                {
                    FillMyData();
                    MessageBox.Show("تم حذف البيانات بنجاح");
                }
                else
                {
                    MessageBox.Show("لم يتم الحذف");
                }
                Txtsubject.ResetText();
                TxtorgVisit.ResetText();
                TxtImportID.ResetText();
                TxtImportID.ResetText();
                DateStartVisit.ResetText();
                DateEndVisit.ResetText();
                }
                else
                {

                    MessageBox.Show("غير مسموح لك بحذف زيارة");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("هذه البيانات غير صحيحة");
            }
        }

        private void DgvVisit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Txtsubject.Text = DgvVisit[2, e.RowIndex].Value.ToString();
                TxtImportID.Text = DgvVisit[1, e.RowIndex].Value.ToString();  
                TxtorgVisit.Text = DgvVisit[3, e.RowIndex].Value.ToString();
                TxtImportID.Text = DgvVisit[0, e.RowIndex].Value.ToString();
                DateStartVisit.Value = Convert.ToDateTime(DgvVisit[4, e.RowIndex].Value.ToString());
                DateEndVisit.Value = Convert.ToDateTime(DgvVisit[5, e.RowIndex].Value.ToString());

            }
            catch (Exception ex)
            {
            }
        }

        public void ReportViwerData(DataTable dt, string[] Dates)
        {
            ReportDataSource rprtDTSource = new ReportDataSource("ReportDataVisit", dt);
            ReportParameterCollection ReportParameters = new ReportParameterCollection();
            ReportParameters.Add(new ReportParameter("date1", Dates[0]));
            ReportParameters.Add(new ReportParameter("date2", Dates[1]));
            this.ReportViewerVisit.LocalReport.SetParameters(ReportParameters);
            this.ReportViewerVisit.LocalReport.DataSources.Clear();
            this.ReportViewerVisit.LocalReport.DataSources.Add(rprtDTSource);
            this.ReportViewerVisit.LocalReport.Refresh();
            this.ReportViewerVisit.RefreshReport();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            FillMyData();
        }


        private void TxtImportID_OnValueChanged(object sender, EventArgs e)
        {

            DataTable Dt = new DataTable();
            Dt = Visit.QueryExecute("select orgname,summary from importdata where importid = '" + TxtImportID.Text + "' order by importdate DESC");
            string array = String.Empty;
            if (Dt.Rows.Count > 0)
            {
                TxtOrg.Text = Dt.Rows[0]["orgname"].ToString();
                Txtsubject.Text = Dt.Rows[0]["summary"].ToString();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Txtsubject.Text = string.Empty;
            TxtorgVisit.Text = string.Empty;
            TxtImportID.Text = string.Empty;
            TxtOrg.Text = string.Empty;
            TxtExportID.Text = string.Empty;
        }

        private void TxtExportID_OnValueChanged(object sender, EventArgs e)
        {
            
            DataTable Dt = new DataTable();
            Dt = Visit.QueryExecute("select orgname,summary from exportdata where exportid = '" + TxtExportID.Text + "' order by exportdate DESC");
            string array = String.Empty;
            if (Dt.Rows.Count > 0)
            {
                TxtOrg.Text = Dt.Rows[0]["orgname"].ToString();
                Txtsubject.Text = Dt.Rows[0]["summary"].ToString();
            }

        }

        private void TxtImportID_OnValueChanged(object sender, KeyEventArgs e)
        {

        }
    }
}
